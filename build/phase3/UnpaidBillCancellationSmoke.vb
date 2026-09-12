Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports RestaurantPOS14.Billing
Imports RestaurantPOS14.Configuration

Module UnpaidBillCancellationSmoke
    Public Sub Main(args As String())
        If args.Length <> 1 Then Throw New ArgumentException("Expected BlankDBscript.sql path.")
        Dim builder As New SqlConnectionStringBuilder(SettingsHost.Current.Database.ConnectionString)
        Dim databaseName = "CodexCancelBillSmoke_" & Guid.NewGuid().ToString("N")
        builder.InitialCatalog = "master"
        Using master As New SqlConnection(builder.ConnectionString)
            master.Open()
            Execute(master, "CREATE DATABASE [" & databaseName & "]")
        End Using
        builder.InitialCatalog = databaseName
        Console.WriteLine("TEST_DATABASE=" & databaseName)
        Using connection As New SqlConnection(builder.ConnectionString)
            connection.Open()
            Dim originalSchema = File.ReadAllText(args(0))
            For Each tableName In {"Registration", "OtherSetting", "Kitchen", "PosPrinterSetting",
                "RestaurantPOS_BillingInfoKOT", "RestaurantPOS_BillingInfoEB", "RestaurantPOS_BillingInfoHD", "RestaurantPOS_BillingInfoTA",
                "RestaurantPOS_OrderedProductBillKOT", "RestaurantPOS_OrderedProductKOT", "RestaurantPOS_OrderInfoKOT", "R_Table",
                "DeletedInvoices", "DeletedInvoices_Join", "LedgerBook", "MemberLedger", "CreditCustomerLedger", "LoyaltyMemberLedgerBook"}
                Dim match = Regex.Match(originalSchema, "(?ms)^CREATE TABLE \[dbo\]\.\[" & tableName & "\]\(.*?(?=^GO\s*$)")
                Assert(match.Success, "Missing original table definition: " & tableName)
                Execute(connection, match.Value)
            Next
            ' Force the true legacy path even if the source provisioning script
            ' already contains a newer optional setting column.
            Execute(connection, "IF COL_LENGTH('OtherSetting','ShowSSTOnSecondaryDisplay') IS NOT NULL ALTER TABLE OtherSetting DROP COLUMN ShowSSTOnSecondaryDisplay")
            DatabaseMaintenance.EnsureCompatibleSchema(connection)
            DatabaseMaintenance.EnsureCompatibleSchema(connection)
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM POSSchemaMigrations WHERE MigrationId=6")) = 1, "Migration is not idempotent.")
            Console.WriteLine("PASS|LegacyUpgradeTo6|IdempotentMigration")

            Seed(connection, 100, "TABLE 4")
            Seed(connection, 101, "Chef's Table")
            Execute(connection, "INSERT INTO RestaurantPOS_OrderedProductBillKOT(BillID,TableNo,Dish,Quantity,TotalAmount) VALUES (101,N'Patio, East',N'Tea',1,10)")
            Dim listed = UnpaidBillCancellation.ListUnpaid(connection)
            Assert(listed.Rows.Count = 2, "All users must see bills belonging to every operator/date.")
            Dim kitchensBefore = CStr(Scalar(connection, "SELECT * FROM RestaurantPOS_OrderInfoKOT ORDER BY ID FOR XML PATH('Order'),ROOT('Orders')"))
            UnpaidBillCancellation.Cancel(connection, 100, "DIB-0100", 20D, "cashier", "Correct wrong order")
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM RestaurantPOS_BillingInfoKOT WHERE ID=100")) = 0, "Active bill remains.")
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM RestaurantPOS_OrderedProductBillKOT WHERE BillID=100")) = 0, "Active bill items remain.")
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM LedgerBook WHERE LedgerNo='DIB-0100'")) = 0, "Unpaid sales accrual remains.")
            Assert(CStr(Scalar(connection, "SELECT CancelledBy FROM DineInBillCancellations WHERE BillId=100")) = "cashier", "Cashier audit missing.")
            Dim xml = CStr(Scalar(connection, "SELECT SnapshotXml FROM DineInBillCancellations WHERE BillId=100"))
            Dim archived As New DataSet()
            Using reader As New StringReader(xml)
                archived.ReadXml(reader, XmlReadMode.ReadSchema)
            End Using
            Assert(archived.Tables("Bill").Rows.Count = 1 AndAlso archived.Tables("Items").Rows.Count = 1 AndAlso archived.Tables("Ledgers").Rows.Count = 1, "Full audit snapshot is incomplete.")
            Assert(CDec(archived.Tables("Bill").Rows(0)("Cash")) = 0D, "Cancellation recorded cash.")
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM DeletedInvoices WHERE BillNo='DIB-0100' AND Canceled_Deleted='Canceled'")) = 1, "Existing cancellation history missing.")
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM DeletedInvoices_Join WHERE BillNo='DIB-0100'")) = 1, "Item history missing.")
            ExpectBlocked(connection, 100, "DIB-0100", 20D, "duplicate", False)
            UnpaidBillCancellation.Cancel(connection, 101, "DIB-0101", 20D, "waiter", "Customer changed merged order")
            Assert(CStr(Scalar(connection, "SELECT * FROM RestaurantPOS_OrderInfoKOT ORDER BY ID FOR XML PATH('Order'),ROOT('Orders')")) = kitchensBefore, "Kitchen order state changed.")
            Assert(CInt(Scalar(connection, UnpaidBillCancellation.LastBillIdSql)) = 101, "Cancelled bill IDs are no longer reserved.")
            Assert(UnpaidBillCancellation.ListUnpaid(connection).Rows.Count = 0, "Cancelled bill still listed.")
            Console.WriteLine("PASS|CashierAndWaiter|OtherOperatorBill|MergedTables|Audit|KitchenPreserved|NoCash|IdReservation|DuplicateCancellation")

            Dim id = 200
            For Each field In {"Cash", "Change", "Card", "GiftCardAmount", "LP", "LA"}
                Seed(connection, id, "Guard " & id.ToString())
                Execute(connection, "UPDATE RestaurantPOS_BillingInfoKOT SET " & field & "=1 WHERE ID=" & id.ToString())
                ExpectBlocked(connection, id, BillNo(id), 20D, field, True)
                id += 1
            Next
            For Each update In {"DIB_Status='Paid'", "BillType='Equal Split'", "BillType='Split Bill'", "PaymentMode='VIP Member Card'", "PaymentMode='Credit Customer'", "Cash=-1"}
                Seed(connection, id, "Guard " & id.ToString())
                Execute(connection, "UPDATE RestaurantPOS_BillingInfoKOT SET " & update & " WHERE ID=" & id.ToString())
                ExpectBlocked(connection, id, BillNo(id), 20D, update, True)
                id += 1
            Next
            Seed(connection, 230, "Account")
            Execute(connection, "INSERT INTO MemberLedger(Id,LedgerNo,Debit) VALUES(1,'DIB-0230',20)")
            ExpectBlocked(connection, 230, BillNo(230), 20D, "Member ledger", True)
            Seed(connection, 231, "Credit")
            Execute(connection, "INSERT INTO CreditCustomerLedger(LedgerNo,Debit) VALUES('DIB-0231',20)")
            ExpectBlocked(connection, 231, BillNo(231), 20D, "Credit ledger", True)
            Seed(connection, 232, "Loyalty")
            Execute(connection, "INSERT INTO LoyaltyMemberLedgerBook(Date,LedgerNo,Label,PointsEarned,PointsRedeem) VALUES(GETDATE(),'DIB-0232','Points for dine in billing',2,0)")
            ExpectBlocked(connection, 232, BillNo(232), 20D, "Loyalty ledger", True)
            Seed(connection, 233, "EInvoice")
            Execute(connection, "INSERT INTO EInvoiceQueue(BillId,BillType,Status) VALUES(233,'KOT','Pending')")
            ExpectBlocked(connection, 233, BillNo(233), 20D, "EInvoice", True)
            Seed(connection, 234, "Tender ledger")
            Execute(connection, "INSERT INTO LedgerBook(LedgerNo,Label,Debit) VALUES('DIB-0234','POS',20)")
            ExpectBlocked(connection, 234, BillNo(234), 20D, "Tender ledger", True)
            Seed(connection, 235, "Stale")
            ExpectBlocked(connection, 235, BillNo(235), 21D, "Stale total", True)
            ExpectBlocked(connection, 235, "DIB-WRONG", 20D, "Stale identity", True)
            ExpectBlocked(connection, 235, BillNo(235), 20D, "", True)
            Console.WriteLine("PASS|AllPaymentGuards|PaidAndSplitGuards|AccountAndEInvoiceGuards|StaleSelection|RequiredReason")

            Seed(connection, 250, "Rollback")
            Execute(connection, "CREATE TRIGGER RejectTestCancellation ON dbo.DeletedInvoices_Join AFTER INSERT AS BEGIN RAISERROR('Simulated audit failure',16,1); ROLLBACK TRANSACTION; END")
            ExpectBlocked(connection, 250, BillNo(250), 20D, "rollback", True)
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM DeletedInvoices WHERE BillNo='DIB-0250'")) = 0, "Partial audit survived rollback.")
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM LedgerBook WHERE LedgerNo='DIB-0250'")) = 1, "Ledger changed on rollback.")
            Execute(connection, "DROP TRIGGER dbo.RejectTestCancellation")
            Console.WriteLine("PASS|AuditFailureRollsBackEverything")

            Seed(connection, 260, "Concurrency")
            Dim first = Task.Factory.StartNew(Function() TryCancel(builder.ConnectionString, 260))
            Dim second = Task.Factory.StartNew(Function() TryCancel(builder.ConnectionString, 260))
            Task.WaitAll(first, second)
            Assert(If(first.Result, 1, 0) + If(second.Result, 1, 0) = 1, "Concurrent cancellation must succeed exactly once.")
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM DineInBillCancellations WHERE BillId=260")) = 1, "Concurrent audit duplicated.")
            Console.WriteLine("PASS|ConcurrentCancellationExactlyOnce")

            Seed(connection, 270, "Payment race")
            Using payment = connection.BeginTransaction()
                Using command As New SqlCommand("UPDATE RestaurantPOS_BillingInfoKOT SET Cash=5 WHERE ID=270", connection, payment)
                    command.ExecuteNonQuery()
                End Using
                Dim cancellation = Task.Factory.StartNew(Function() TryCancel(builder.ConnectionString, 270))
                payment.Commit()
                Assert(Not cancellation.Result, "A concurrent payment was ignored.")
            End Using
            Assert(CDec(Scalar(connection, "SELECT Cash FROM RestaurantPOS_BillingInfoKOT WHERE ID=270")) = 5D, "Concurrent payment changed.")
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM DineInBillCancellations WHERE BillId=270")) = 0, "Paid bill archived during race.")
            Console.WriteLine("PASS|ConcurrentPaymentRecheckedAndPreserved")
        End Using
        Console.WriteLine("UnpaidBillCancellationSmokeSucceeded=True|ProductionBillsChanged=False")
    End Sub

    Private Function TryCancel(connectionString As String, id As Integer) As Boolean
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Try
                UnpaidBillCancellation.Cancel(connection, id, BillNo(id), 20D, "cashier", "Concurrency test")
                Return True
            Catch ex As InvalidOperationException
                Return False
            End Try
        End Using
    End Function

    Private Sub Seed(connection As SqlConnection, id As Integer, tableName As String)
        Using command As New SqlCommand(
            "INSERT INTO RestaurantPOS_BillingInfoKOT(ID,BillNo,BillDate,GrandTotal,Cash,Change,Card,GiftCardAmount,LP,LA,Operator,PaymentMode,DIB_Status,BillType,NpPaid) " &
            "VALUES(@id,@no,'20240101',20,0,0,0,0,0,0,'different-cashier','Cash','Unpaid','Normal Bill',1);" &
            "INSERT INTO RestaurantPOS_OrderedProductBillKOT(BillID,TableNo,Dish,Quantity,TotalAmount) VALUES(@id,@table,N'Tea',2,20);" &
            "INSERT INTO RestaurantPOS_OrderInfoKOT(ID,TicketNo,BillDate,TableNo,KOT_Status) VALUES(@id,@no,'20240101',@table,'Open');" &
            "INSERT INTO LedgerBook(LedgerNo,Label,Debit,Credit) VALUES(@no,'Sales Invoice',0,20);", connection)
            command.Parameters.Add("@id", SqlDbType.Int).Value = id
            command.Parameters.Add("@no", SqlDbType.NVarChar, 15).Value = BillNo(id)
            command.Parameters.Add("@table", SqlDbType.NVarChar, 30).Value = tableName
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub ExpectBlocked(connection As SqlConnection, id As Integer, number As String, total As Decimal, reason As String, expectActive As Boolean)
        Dim failed As Boolean
        Try
            UnpaidBillCancellation.Cancel(connection, id, number, total, "cashier", reason)
        Catch ex As Exception When TypeOf ex Is InvalidOperationException OrElse TypeOf ex Is ArgumentException OrElse TypeOf ex Is SqlException
            failed = True
        End Try
        Assert(failed, "Unsafe cancellation was accepted: " & reason)
        If expectActive Then
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM RestaurantPOS_BillingInfoKOT WHERE ID=" & id.ToString())) = 1, "Blocked bill was removed.")
            Assert(CInt(Scalar(connection, "SELECT COUNT(*) FROM DineInBillCancellations WHERE BillId=" & id.ToString())) = 0, "Blocked bill was archived.")
        End If
    End Sub

    Private Function BillNo(id As Integer) As String
        Return "DIB-" & id.ToString("0000")
    End Function

    Private Function Scalar(connection As SqlConnection, sql As String) As Object
        Using command As New SqlCommand(sql, connection)
            Return command.ExecuteScalar()
        End Using
    End Function

    Private Sub Execute(connection As SqlConnection, sql As String)
        Using command As New SqlCommand(sql, connection)
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Assert(condition As Boolean, message As String)
        If Not condition Then Throw New InvalidOperationException(message)
    End Sub
End Module
