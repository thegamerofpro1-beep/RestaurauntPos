Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RestaurantPOS14.Configuration

Module AllReceiptRenderSmoke
    Private Class ReceiptSpec
        Public ReadOnly Kind As String
        Public ReadOnly BillingTable As String
        Public ReadOnly ProductTable As String
        Public ReadOnly ReportName As String
        Public ReadOnly OutputName As String
        Public ReadOnly ParameterName As String

        Public Sub New(
            kind As String,
            billingTable As String,
            productTable As String,
            reportName As String,
            outputName As String,
            parameterName As String)

            Me.Kind = kind
            Me.BillingTable = billingTable
            Me.ProductTable = productTable
            Me.ReportName = reportName
            Me.OutputName = outputName
            Me.ParameterName = parameterName
        End Sub
    End Class

    Private ReadOnly Receipts As New List(Of ReceiptSpec) From {
        New ReceiptSpec("DIB", "RestaurantPOS_BillingInfoKOT", "RestaurantPOS_OrderedProductBillKOT", "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt", "receipt-layout-dine-in.pdf", "p1"),
        New ReceiptSpec("TA", "RestaurantPOS_BillingInfoTA", "RestaurantPOS_OrderedProductBillTA", "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt", "receipt-layout-takeaway.pdf", "p1"),
        New ReceiptSpec("HD", "RestaurantPOS_BillingInfoHD", "RestaurantPOS_OrderedProductBillHD", "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt", "receipt-layout-home-delivery.pdf", "DP"),
        New ReceiptSpec("EB", "RestaurantPOS_BillingInfoEB", "RestaurantPOS_OrderedProductBillEB", "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt", "receipt-layout-express.pdf", "p1")
    }

    Public Sub Main(args As String())
        If args.Length <> 2 Then
            Console.Error.WriteLine("Usage: AllReceiptRenderSmoke <report-directory> <output-directory>")
            Environment.ExitCode = 2
            Return
        End If

        Try
            SettingsHost.Initialize()
            Dim reportDirectory = Path.GetFullPath(args(0))
            Dim outputDirectory = Path.GetFullPath(args(1))
            Directory.CreateDirectory(outputDirectory)

            Using connection As New SqlConnection(SettingsHost.Current.Database.ConnectionString)
                connection.Open()
                For Each spec In Receipts
                    RenderReceipt(connection, spec, reportDirectory, outputDirectory)
                Next
            End Using
        Catch ex As Exception
            Console.Error.WriteLine(ex.ToString())
            Environment.ExitCode = 1
        End Try
    End Sub

    Private Sub RenderReceipt(
        connection As SqlConnection,
        spec As ReceiptSpec,
        reportDirectory As String,
        outputDirectory As String)

        Dim sourceBillingTable = spec.BillingTable
        Dim sourceProductTable = spec.ProductTable
        Dim extraSelect = String.Empty
        Dim billId = FindLatestBillId(connection, sourceBillingTable, sourceProductTable)

        ' The validation database may not contain an express-billing sale yet. TA has
        ' the same receipt line schema, so use its latest row to exercise the EB layout.
        If billId <= 0 AndAlso String.Equals(spec.Kind, "EB", StringComparison.OrdinalIgnoreCase) Then
            sourceBillingTable = "RestaurantPOS_BillingInfoTA"
            sourceProductTable = "RestaurantPOS_OrderedProductBillTA"
            extraSelect = ", B.PhoneNo AS EB_PhoneNo, B.TA_Status AS EB_Status"
            billId = FindLatestBillId(connection, sourceBillingTable, sourceProductTable)
        End If
        If billId <= 0 Then Throw New InvalidOperationException("No " & spec.Kind & " receipt data is available for rendering.")

        Dim dataSet As New DataSet()
        Dim invoiceSql =
            "SELECT P.*, B.*" & extraSelect & " FROM " & sourceProductTable & " P " &
            "INNER JOIN " & sourceBillingTable & " B ON P.BillID = B.ID " &
            "WHERE B.ID = @BillId"

        Using command As New SqlCommand(invoiceSql, connection),
              adapter As New SqlDataAdapter(command),
              hotelCommand As New SqlCommand("SELECT * FROM Hotel", connection),
              hotelAdapter As New SqlDataAdapter(hotelCommand)

            command.Parameters.Add("@BillId", SqlDbType.Int).Value = billId
            adapter.Fill(dataSet, spec.BillingTable)
            adapter.Fill(dataSet, spec.ProductTable)
            hotelAdapter.Fill(dataSet, "Hotel")
        End Using

        Dim outputPath = Path.Combine(outputDirectory, spec.OutputName)
        If File.Exists(outputPath) Then File.Delete(outputPath)

        Using report As New ReportDocument()
            report.Load(Path.Combine(reportDirectory, spec.ReportName), OpenReportMethod.OpenReportByTempCopy)
            report.SetDataSource(dataSet)
            report.SetParameterValue(spec.ParameterName, String.Empty)
            report.ExportToDisk(ExportFormatType.PortableDocFormat, outputPath)
        End Using

        If Not File.Exists(outputPath) OrElse New FileInfo(outputPath).Length = 0 Then
            Throw New InvalidOperationException("Crystal Reports did not create " & spec.OutputName & ".")
        End If

        Console.WriteLine(
            "RENDERED|" & spec.Kind &
            "|BillID=" & billId.ToString() &
            "|Bytes=" & New FileInfo(outputPath).Length.ToString() &
            "|Output=" & outputPath)
    End Sub

    Private Function FindLatestBillId(
        connection As SqlConnection,
        billingTable As String,
        productTable As String) As Integer

        Dim sql =
            "SELECT TOP (1) B.ID FROM " & billingTable & " B " &
            "INNER JOIN " & productTable & " P ON P.BillID = B.ID " &
            "ORDER BY B.ID DESC"
        Using command As New SqlCommand(sql, connection)
            Dim value = command.ExecuteScalar()
            If value Is Nothing OrElse value Is DBNull.Value Then Return 0
            Return Convert.ToInt32(value)
        End Using
    End Function
End Module
