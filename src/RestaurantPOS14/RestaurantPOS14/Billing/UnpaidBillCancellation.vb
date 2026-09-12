Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO

Namespace RestaurantPOS14.Billing
    Public NotInheritable Class UnpaidBillCancellation
        Public Const SchemaSql As String =
            "IF OBJECT_ID(N'dbo.DineInBillCancellations', N'U') IS NULL " &
            "CREATE TABLE dbo.DineInBillCancellations (BillId int NOT NULL PRIMARY KEY, BillNo nvarchar(15) NOT NULL," &
            "CancelledBy nvarchar(100) NOT NULL, Reason nvarchar(200) NOT NULL, CancelledAtUtc datetime NOT NULL," &
            "GrandTotal decimal(18,2) NOT NULL, SnapshotXml nvarchar(max) NOT NULL);"

        Public Const LastBillIdSql As String =
            "SELECT TOP 1 ID FROM (SELECT ID FROM RestaurantPOS_BillingInfoKOT " &
            "UNION ALL SELECT BillId FROM DineInBillCancellations) ReservedBills ORDER BY ID DESC"

        Private Sub New()
        End Sub

        Public Shared Function ListUnpaid(connection As SqlConnection) As DataTable
            ' Deliberately no operator/role filter: cancellation is available to all users.
            Using command As New SqlCommand(
                "SELECT B.ID, RTRIM(B.BillNo) AS BillNo,B.BillDate,RTRIM(B.Operator) AS Operator," &
                "ISNULL(B.GrandTotal,0) AS GrandTotal,RTRIM(B.BillType) AS BillType," &
                "STUFF((SELECT DISTINCT N', ' + RTRIM(P.TableNo) FROM RestaurantPOS_OrderedProductBillKOT P " &
                "WHERE P.BillID=B.ID FOR XML PATH(''),TYPE).value('.','nvarchar(max)'),1,2,N'') AS Tables " &
                "FROM RestaurantPOS_BillingInfoKOT B WHERE B.DIB_Status=N'Unpaid' ORDER BY B.BillDate DESC,B.ID DESC", connection)
                Dim result As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(result)
                End Using
                Return result
            End Using
        End Function

        Public Shared Sub Cancel(connection As SqlConnection, billId As Integer, expectedBillNo As String,
                                 expectedTotal As Decimal, actor As String, reason As String)
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            If billId <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(billId))
            actor = If(actor, String.Empty).Trim()
            reason = If(reason, String.Empty).Trim()
            If actor.Length = 0 OrElse actor.Length > 100 Then Throw New ArgumentException("A signed-in user is required.")
            If reason.Length = 0 OrElse reason.Length > 200 Then Throw New ArgumentException("Enter a cancellation reason (1 to 200 characters).")
            If connection.State <> ConnectionState.Open Then Throw New InvalidOperationException("Open the database connection first.")

            Using transaction = connection.BeginTransaction(IsolationLevel.Serializable)
                Try
                    Dim snapshot As New DataSet("CancelledUnpaidDineInBill")
                    Dim bill = ReadTable(connection, transaction,
                        "SELECT * FROM RestaurantPOS_BillingInfoKOT WITH (UPDLOCK,HOLDLOCK) WHERE ID=@id", billId, Nothing)
                    bill.TableName = "Bill"
                    snapshot.Tables.Add(bill)
                    If bill.Rows.Count <> 1 Then Throw New InvalidOperationException("This bill was already cancelled or removed. Refresh the bill list.")
                    Dim row = bill.Rows(0)
                    Dim billNo = TextValue(row, "BillNo")
                    If billNo <> expectedBillNo OrElse NumberValue(row, "GrandTotal") <> expectedTotal Then
                        Throw New InvalidOperationException("This bill has changed. Refresh and review it before cancelling.")
                    End If
                    If TextValue(row, "DIB_Status") <> "Unpaid" Then
                        Throw New InvalidOperationException("Only unpaid bills can be cancelled. This bill is no longer unpaid.")
                    End If
                    ' Split bills may already have paid siblings without a reliable ticket link
                    ' in the legacy schema. Never unlock their kitchen orders by table name.
                    If TextValue(row, "BillType") <> "Normal Bill" Then
                        Throw New InvalidOperationException("Split bills cannot be cancelled here because another portion may already be paid. Review the split bill first.")
                    End If
                    For Each field In {"Cash", "Change", "Card", "GiftCardAmount", "LP", "LA"}
                        If NumberValue(row, field) <> 0D Then
                            Throw New InvalidOperationException("This bill has a payment, gift-card amount or loyalty redemption recorded. Use payment/refund reconciliation instead of cancelling it.")
                        End If
                    Next
                    If TextValue(row, "PaymentMode") = "VIP Member Card" OrElse TextValue(row, "PaymentMode") = "Credit Customer" Then
                        Throw New InvalidOperationException("Member-account and credit-customer bills require account reconciliation and cannot be cancelled here.")
                    End If

                    Dim items = ReadTable(connection, transaction,
                        "SELECT * FROM RestaurantPOS_OrderedProductBillKOT WITH (UPDLOCK,HOLDLOCK) WHERE BillID=@id", billId, billNo)
                    items.TableName = "Items"
                    snapshot.Tables.Add(items)
                    Dim ledgers = ReadTable(connection, transaction,
                        "SELECT * FROM LedgerBook WITH (UPDLOCK,HOLDLOCK) WHERE LedgerNo=@billNo", billId, billNo)
                    ledgers.TableName = "Ledgers"
                    snapshot.Tables.Add(ledgers)
                    For Each ledger As DataRow In ledgers.Rows
                        If TextValue(ledger, "Label") <> "Sales Invoice" AndAlso
                           (NumberValue(ledger, "Debit") <> 0D OrElse NumberValue(ledger, "Credit") <> 0D) Then
                            Throw New InvalidOperationException("Payment/accounting entries exist for this bill. Review them before cancellation.")
                        End If
                    Next
                    For Each tableName In {"MemberLedger", "CreditCustomerLedger", "LoyaltyMemberLedgerBook"}
                        ' Fixed, internal table names, never user input.
                        Dim entries = ReadTable(connection, transaction,
                            "SELECT * FROM " & tableName & " WITH (UPDLOCK,HOLDLOCK) WHERE LedgerNo=@billNo", billId, billNo)
                        If entries.Rows.Count > 0 Then
                            Throw New InvalidOperationException("This bill has member, credit-customer or loyalty ledger entries. Reconcile those entries before cancelling.")
                        End If
                    Next
                    Dim queue = ReadTable(connection, transaction,
                        "SELECT QueueId FROM EInvoiceQueue WITH (UPDLOCK,HOLDLOCK) WHERE BillId=@id AND BillType=N'KOT'", billId, billNo)
                    If queue.Rows.Count > 0 Then Throw New InvalidOperationException("This bill has an e-invoice submission record. Use the e-invoice cancellation/reconciliation process.")

                    Dim xml As String
                    Using writer As New StringWriter(CultureInfo.InvariantCulture)
                        snapshot.WriteXml(writer, XmlWriteMode.WriteSchema)
                        xml = writer.ToString()
                    End Using
                    Using command As New SqlCommand(
                        "INSERT INTO DineInBillCancellations(BillId,BillNo,CancelledBy,Reason,CancelledAtUtc,GrandTotal,SnapshotXml) " &
                        "VALUES(@id,@billNo,@actor,@reason,GETUTCDATE(),@total,@xml);" &
                        "INSERT INTO DeletedInvoices(BillNo,BillDate,GrandTotal,Operator,PaymentMode,Reason,DeletedDate,BillType,Canceled_Deleted) " &
                        "SELECT BillNo,BillDate,GrandTotal,@actor,PaymentMode,@reason,GETDATE(),N'Dine In Billing',N'Canceled' " &
                        "FROM RestaurantPOS_BillingInfoKOT WHERE ID=@id;" &
                        "INSERT INTO DeletedInvoices_Join(BillNo,ItemName,Qty,TotalAmount) " &
                        "SELECT @billNo,Dish,Quantity,TotalAmount FROM RestaurantPOS_OrderedProductBillKOT WHERE BillID=@id;" &
                        "DELETE FROM LedgerBook WHERE LedgerNo=@billNo AND (Label=N'Sales Invoice' OR (ISNULL(Debit,0)=0 AND ISNULL(Credit,0)=0));" &
                        "DELETE FROM RestaurantPOS_OrderedProductBillKOT WHERE BillID=@id;" &
                        "DELETE FROM RestaurantPOS_BillingInfoKOT WHERE ID=@id;", connection, transaction)
                        AddKeys(command, billId, billNo)
                        command.Parameters.Add("@actor", SqlDbType.NVarChar, 100).Value = actor
                        command.Parameters.Add("@reason", SqlDbType.NVarChar, 200).Value = reason
                        Dim total = command.Parameters.Add("@total", SqlDbType.Decimal)
                        total.Precision = 18
                        total.Scale = 2
                        total.Value = expectedTotal
                        command.Parameters.Add("@xml", SqlDbType.NVarChar, -1).Value = xml
                        command.ExecuteNonQuery()
                    End Using
                    transaction.Commit()
                Catch
                    Try
                        transaction.Rollback()
                    Catch rollbackError As Exception
                        Diagnostics.ApplicationDiagnostics.ReportNonFatal("Rollback unpaid bill cancellation", rollbackError)
                    End Try
                    Throw
                End Try
            End Using
        End Sub

        Private Shared Function ReadTable(connection As SqlConnection, transaction As SqlTransaction, sql As String,
                                          billId As Integer, billNo As String) As DataTable
            Using command As New SqlCommand(sql, connection, transaction)
                AddKeys(command, billId, billNo)
                Dim result As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(result)
                End Using
                Return result
            End Using
        End Function

        Private Shared Sub AddKeys(command As SqlCommand, billId As Integer, billNo As String)
            command.Parameters.Add("@id", SqlDbType.Int).Value = billId
            command.Parameters.Add("@billNo", SqlDbType.NVarChar, 15).Value = If(billNo, String.Empty)
        End Sub

        Private Shared Function TextValue(row As DataRow, name As String) As String
            Return If(row.IsNull(name), String.Empty, Convert.ToString(row(name), CultureInfo.InvariantCulture).Trim())
        End Function

        Private Shared Function NumberValue(row As DataRow, name As String) As Decimal
            Return If(row.IsNull(name), 0D, Convert.ToDecimal(row(name), CultureInfo.InvariantCulture))
        End Function
    End Class
End Namespace
