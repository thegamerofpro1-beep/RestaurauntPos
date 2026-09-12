Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RestaurantPOS14.Configuration

Module SstReceiptRenderSmoke
    Public Sub Main(args As String())
        If args.Length <> 3 Then
            Console.Error.WriteLine("Usage: SstReceiptRenderSmoke <report-path> <bill-number> <output-pdf>")
            Environment.ExitCode = 2
            Return
        End If

        Dim useEmbeddedReport = String.Equals(args(0), "embedded", StringComparison.OrdinalIgnoreCase)
        Dim reportPath = If(useEmbeddedReport, String.Empty, Path.GetFullPath(args(0)))
        Dim billNumber = args(1)
        Dim outputPath = Path.GetFullPath(args(2))

        Try
            SettingsHost.Initialize()
            Directory.CreateDirectory(Path.GetDirectoryName(outputPath))

            Dim dataSet As New DataSet()
            Const invoiceSql = "SELECT DishNameArabic,Tip,Billtype,DIB_Status,NoofPerson,Card,TaxType,CustomerName,PhoneNo,EmailID,GiftCardID,GiftCardAmount,LP,LA,Waiter,Member_ID, ODN,KOTDiscountPer,KOTDiscountAmt,RestaurantPOS_OrderedProductBillKOT.OP_ID,Operator,SCPer,SCAmount,PaymentMode,CurrencyCode, RestaurantPOS_OrderedProductBillKOT.BillID, RestaurantPOS_OrderedProductBillKOT.Dish, RestaurantPOS_OrderedProductBillKOT.VATPer,RestaurantPOS_OrderedProductBillKOT.VATAmount, RestaurantPOS_OrderedProductBillKOT.STPer, RestaurantPOS_OrderedProductBillKOT.STAmount, RestaurantPOS_OrderedProductBillKOT.DiscountPer, RestaurantPOS_OrderedProductBillKOT.DiscountAmount,RestaurantPOS_OrderedProductBillKOT.Rate, RestaurantPOS_OrderedProductBillKOT.Quantity, RestaurantPOS_OrderedProductBillKOT.Amount, RestaurantPOS_OrderedProductBillKOT.TotalAmount,RestaurantPOS_BillingInfoKOT.ID, RestaurantPOS_BillingInfoKOT.BillNo,RestaurantPOS_OrderedProductBillKOT.TableNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.GrandTotal,RestaurantPOS_BillingInfoKOT.Cash,RestaurantPOS_BillingInfoKOT.Change FROM RestaurantPOS_OrderedProductBillKOT INNER JOIN RestaurantPOS_BillingInfoKOT ON RestaurantPOS_OrderedProductBillKOT.BillID = RestaurantPOS_BillingInfoKOT.ID WHERE RestaurantPOS_BillingInfoKOT.BillNo=@BillNo"

            Using connection As New SqlConnection(SettingsHost.Current.Database.ConnectionString)
                Using invoiceCommand As New SqlCommand(invoiceSql, connection),
                      hotelCommand As New SqlCommand("SELECT * FROM Hotel", connection)
                    invoiceCommand.Parameters.Add("@BillNo", SqlDbType.NVarChar, 50).Value = billNumber
                    Using invoiceAdapter As New SqlDataAdapter(invoiceCommand),
                          hotelAdapter As New SqlDataAdapter(hotelCommand)
                        invoiceAdapter.Fill(dataSet, "RestaurantPOS_BillingInfoKOT")
                        invoiceAdapter.Fill(dataSet, "RestaurantPOS_OrderedProductBillKOT")
                        hotelAdapter.Fill(dataSet, "Hotel")
                    End Using
                End Using
            End Using

            Dim invoiceTable = dataSet.Tables("RestaurantPOS_BillingInfoKOT")
            If invoiceTable.Rows.Count = 0 Then
                Throw New InvalidOperationException("Bill " & billNumber & " was not found.")
            End If

            Dim sstAmount As Decimal = 0D
            Dim sstPercentage As Decimal = 0D
            For Each row As DataRow In invoiceTable.Rows
                If Not row.IsNull("STAmount") Then sstAmount += Convert.ToDecimal(row("STAmount"))
                If Not row.IsNull("STPer") Then sstPercentage = Math.Max(sstPercentage, Convert.ToDecimal(row("STPer")))
                Console.WriteLine(
                    "ROW|Dish=" & Convert.ToString(row("Dish")) &
                    "|Amount=" & Convert.ToDecimal(row("Amount")).ToString("0.00") &
                    "|STPer=" & Convert.ToDecimal(row("STPer")).ToString("0.00") &
                    "|STAmount=" & Convert.ToDecimal(row("STAmount")).ToString("0.00"))
            Next

            If File.Exists(outputPath) Then File.Delete(outputPath)
            Using report As ReportDocument = If(
                useEmbeddedReport,
                DirectCast(New RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice(), ReportDocument),
                New ReportDocument())
                If Not useEmbeddedReport Then report.Load(reportPath, OpenReportMethod.OpenReportByTempCopy)
                report.SetDataSource(dataSet)
                report.SetParameterValue("p1", String.Empty)
                report.ExportToDisk(ExportFormatType.PortableDocFormat, outputPath)
            End Using

            If Not File.Exists(outputPath) OrElse New FileInfo(outputPath).Length = 0 Then
                Throw New InvalidOperationException("Crystal Reports did not create the validation PDF.")
            End If

            Console.WriteLine("RenderedBill=" & billNumber)
            Console.WriteLine("SSTPercentage=" & sstPercentage.ToString("0.00"))
            Console.WriteLine("SSTAmount=" & sstAmount.ToString("0.00"))
            Console.WriteLine("Output=" & outputPath)
            Console.WriteLine("Bytes=" & New FileInfo(outputPath).Length.ToString())
        Catch ex As Exception
            Console.Error.WriteLine(ex.ToString())
            Environment.ExitCode = 1
        End Try
    End Sub
End Module
