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

Module RoundingReceiptRenderSmoke
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
        New ReceiptSpec("DIB", "RestaurantPOS_BillingInfoKOT", "RestaurantPOS_OrderedProductBillKOT", "RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice.rpt", "rounding-dine-in.pdf", "p1"),
        New ReceiptSpec("TA", "RestaurantPOS_BillingInfoTA", "RestaurantPOS_OrderedProductBillTA", "RestaurantPOS14.rptRestaurantPOSTAInvoice.rpt", "rounding-takeaway.pdf", "p1"),
        New ReceiptSpec("HD", "RestaurantPOS_BillingInfoHD", "RestaurantPOS_OrderedProductBillHD", "RestaurantPOS14.rptRestaurantPOSHDInvoice.rpt", "rounding-home-delivery.pdf", "DP"),
        New ReceiptSpec("EB", "RestaurantPOS_BillingInfoEB", "RestaurantPOS_OrderedProductBillEB", "RestaurantPOS14.rptRestaurantPOSEBInvoice.rpt", "rounding-express.pdf", "p1")
    }

    Public Sub Main(args As String())
        If args.Length <> 2 Then
            Console.Error.WriteLine("Usage: RoundingReceiptRenderSmoke <report-directory> <output-directory>")
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

        ' Schema is read from the existing database, but all invoice values below
        ' are synthetic and held only in memory. Never save or update a sale.
        For Each tableName In New String() {spec.BillingTable, spec.ProductTable}
            Dim table = dataSet.Tables(tableName)
            While table.Rows.Count > 1
                table.Rows.RemoveAt(table.Rows.Count - 1)
            End While
            Dim row = table.Rows(0)
            For Each column As DataColumn In table.Columns
                If column.DataType Is GetType(Decimal) OrElse column.DataType Is GetType(Double) OrElse column.DataType Is GetType(Integer) Then row(column) = 0
                If column.DataType Is GetType(String) Then row(column) = String.Empty
            Next
            SetValue(row, "BillNo", "ROUND-TEST")
            SetValue(row, "BillDate", New DateTime(2026, 9, 4, 12, 0, 0))
            SetValue(row, "BillType", "Normal Bill")
            SetValue(row, "DIB_Status", "Paid")
            SetValue(row, "TA_Status", "Paid")
            SetValue(row, "HD_Status", "Paid")
            SetValue(row, "EB_Status", "Paid")
            SetValue(row, "PaymentMode", "Cash")
            SetValue(row, "Operator", "TEST")
            SetValue(row, "TableNo", "TEST")
            SetValue(row, "Dish", "ROUNDING TEST")
            SetValue(row, "Rate", 1.58D)
            SetValue(row, "Quantity", 1D)
            SetValue(row, "Amount", 1.58D)
            SetValue(row, "STPer", 6D)
            SetValue(row, "STAmount", 0.09D)
            SetValue(row, "TotalAmount", 1.67D)
            SetValue(row, "GrandTotal", MoneyMath.RoundPayableTotal(1.67D))
            SetValue(row, "Cash", 1.7D)
            SetValue(row, "NoofPerson", 1)
            SetValue(row, "ExchangeRate", 1D)
        Next
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

    Private Sub SetValue(row As DataRow, name As String, value As Object)
        If row.Table.Columns.Contains(name) Then row(name) = value
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
