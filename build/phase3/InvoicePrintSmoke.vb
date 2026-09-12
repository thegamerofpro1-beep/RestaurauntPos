Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports RestaurantPOS14.Configuration
Imports RestaurantPOS14.Extensions.Printing

Module InvoicePrintSmoke
    Public Sub Main(args As String())
        Dim outputPath = Path.Combine(Path.GetTempPath(), "RestaurantPOS14-InvoicePrintSmoke-" & Guid.NewGuid().ToString("N") & ".pdf")
        Try
            SettingsHost.Initialize()
            Console.WriteLine("ConfiguredPrinter=" & SettingsHost.Current.Printing.DefaultPrinterName)
            Console.WriteLine("SettingsDiagnostics=" & String.Join(" | ", SettingsHost.Service.Diagnostics))
            If String.IsNullOrWhiteSpace(SettingsHost.Current.Printing.DefaultPrinterName) Then
                Throw New InvalidOperationException("The effective printer setting is empty.")
            End If
            Dim dataSet As New DataSet()
            Const invoiceSql = "SELECT DishNameArabic,Tip,Billtype,DIB_Status,NoofPerson,Card,TaxType,CustomerName,PhoneNo,EmailID,GiftCardID,GiftCardAmount,LP,LA,Waiter,Member_ID, ODN,KOTDiscountPer,KOTDiscountAmt,RestaurantPOS_OrderedProductBillKOT.OP_ID,Operator,SCPer,SCAmount,PaymentMode,CurrencyCode, RestaurantPOS_OrderedProductBillKOT.BillID, RestaurantPOS_OrderedProductBillKOT.Dish, RestaurantPOS_OrderedProductBillKOT.VATPer,RestaurantPOS_OrderedProductBillKOT.VATAmount, RestaurantPOS_OrderedProductBillKOT.STPer, RestaurantPOS_OrderedProductBillKOT.STAmount, RestaurantPOS_OrderedProductBillKOT.DiscountPer, RestaurantPOS_OrderedProductBillKOT.DiscountAmount,RestaurantPOS_OrderedProductBillKOT.Rate, RestaurantPOS_OrderedProductBillKOT.Quantity, RestaurantPOS_OrderedProductBillKOT.Amount, RestaurantPOS_OrderedProductBillKOT.TotalAmount,RestaurantPOS_BillingInfoKOT.ID, RestaurantPOS_BillingInfoKOT.BillNo,RestaurantPOS_OrderedProductBillKOT.TableNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.GrandTotal,RestaurantPOS_BillingInfoKOT.Cash,RestaurantPOS_BillingInfoKOT.Change FROM RestaurantPOS_OrderedProductBillKOT INNER JOIN RestaurantPOS_BillingInfoKOT ON RestaurantPOS_OrderedProductBillKOT.BillID = RestaurantPOS_BillingInfoKOT.ID WHERE RestaurantPOS_BillingInfoKOT.ID=COALESCE(@BillId,(SELECT MAX(ID) FROM RestaurantPOS_BillingInfoKOT))"

            Dim requestedBillId As Integer
            Dim hasRequestedBill = args IsNot Nothing AndAlso args.Length > 0 AndAlso Integer.TryParse(args(0), requestedBillId)

            Using connection As New SqlConnection(SettingsHost.Current.Database.ConnectionString)
                Using invoiceCommand As New SqlCommand(invoiceSql, connection), hotelCommand As New SqlCommand("SELECT * FROM Hotel", connection)
                    invoiceCommand.Parameters.Add("@BillId", SqlDbType.Int).Value = If(hasRequestedBill, CType(requestedBillId, Object), DBNull.Value)
                    Using invoiceAdapter As New SqlDataAdapter(invoiceCommand), hotelAdapter As New SqlDataAdapter(hotelCommand)
                        invoiceAdapter.Fill(dataSet, "RestaurantPOS_BillingInfoKOT")
                        invoiceAdapter.Fill(dataSet, "RestaurantPOS_OrderedProductBillKOT")
                        hotelAdapter.Fill(dataSet, "Hotel")
                    End Using
                End Using
            End Using

            If dataSet.Tables("RestaurantPOS_BillingInfoKOT").Rows.Count = 0 Then Throw New InvalidOperationException("No dine-in invoice is available for the print smoke test.")

            Using report As New RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice()
                report.SetDataSource(dataSet)
                report.SetParameterValue("p1", String.Empty)
                ' Match the application's final Save & Print preparation path.
                Dim printPreparationType = report.GetType().Assembly.GetType("RestaurantPOS14.ModFunc", True)
                Dim printPreparationMethod = printPreparationType.GetMethod(
                    "ApplyServiceChargeLabelFix",
                    Reflection.BindingFlags.Public Or Reflection.BindingFlags.Static)
                If printPreparationMethod Is Nothing Then
                    Throw New MissingMethodException(printPreparationType.FullName, "ApplyServiceChargeLabelFix")
                End If
                printPreparationMethod.Invoke(Nothing, New Object() {report})
                Dim configuredPrinter = SettingsHost.Current.Printing.DefaultPrinterName
                Dim expectsPdf = String.Equals(configuredPrinter, "Microsoft Print to PDF", StringComparison.OrdinalIgnoreCase)
                Dim job As New PrintJob With {
                    .DocumentName = "InvoicePrintSmoke",
                    .PrinterName = configuredPrinter,
                    .Copies = 1,
                    .Payload = report
                }
                job.Metadata("OutputPath") = outputPath
                Dim result = New CrystalReportPrintService().Print(job)
                Console.WriteLine("InvoicePdfAccepted=" & result.Accepted.ToString())
                Console.WriteLine("InvoicePdfCreated=" & File.Exists(outputPath).ToString())
                Console.WriteLine("InvoicePdfBytes=" & If(File.Exists(outputPath), New FileInfo(outputPath).Length, 0L).ToString())
                If Not result.Accepted Then Environment.ExitCode = 1
                If expectsPdf AndAlso (Not File.Exists(outputPath) OrElse New FileInfo(outputPath).Length = 0) Then Environment.ExitCode = 1

                Dim missingPrinterResult = New CrystalReportPrintService().Print(New PrintJob With {
                    .DocumentName = "InvoicePrintSmoke",
                    .PrinterName = "RestaurantPOS14 missing-printer smoke target",
                    .Copies = 1,
                    .Payload = report
                })
                Console.WriteLine("MissingPrinterRejected=" & (Not missingPrinterResult.Accepted).ToString())
                If missingPrinterResult.Accepted Then Environment.ExitCode = 1
            End Using
        Catch ex As Exception
            Console.WriteLine("InvoicePrintSmokeSucceeded=False")
            Console.WriteLine("FailureType=" & ex.GetBaseException().GetType().FullName)
            Console.WriteLine("FailureMessage=" & ex.GetBaseException().Message)
            Console.WriteLine("FailureDetail=" & ex.ToString())
            Environment.ExitCode = 1
            Return
        Finally
            If File.Exists(outputPath) Then File.Delete(outputPath)
        End Try

        Console.WriteLine("InvoicePrintSmokeSucceeded=True")
    End Sub
End Module
