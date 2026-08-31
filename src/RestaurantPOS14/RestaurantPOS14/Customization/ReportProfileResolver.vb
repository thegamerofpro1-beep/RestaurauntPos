Imports System
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Customization

    Public NotInheritable Class ReportProfile
        Public Property ReportName As String = String.Empty
        Public Property PrinterName As String = String.Empty
        Public Property ExportFormat As String = "PDF"
        Public Property UseCrystalReport As Boolean = True
    End Class

    ''' <summary>
    ''' Resolves per-report overrides while retaining the recovered Crystal Reports
    ''' behavior as the default output path.
    ''' </summary>
    Public NotInheritable Class ReportProfileResolver
        Private ReadOnly _settings As ReportSettings
        Private ReadOnly _defaultPrinterName As String

        Public Sub New(settings As ReportSettings, defaultPrinterName As String)
            If settings Is Nothing Then Throw New ArgumentNullException(NameOf(settings))
            _settings = settings
            _defaultPrinterName = If(defaultPrinterName, String.Empty)
        End Sub

        Public Function Resolve(reportName As String) As ReportProfile
            If String.IsNullOrWhiteSpace(reportName) Then Throw New ArgumentException("A report name is required.", NameOf(reportName))

            Dim printerName = _defaultPrinterName
            Dim configuredPrinter As String = Nothing
            If _settings.PrinterAssignments IsNot Nothing AndAlso _settings.PrinterAssignments.TryGetValue(reportName, configuredPrinter) Then
                printerName = configuredPrinter
            End If

            Dim exportFormat = _settings.DefaultExportFormat
            Dim configuredFormat As String = Nothing
            If _settings.ExportFormats IsNot Nothing AndAlso _settings.ExportFormats.TryGetValue(reportName, configuredFormat) Then
                exportFormat = configuredFormat
            End If

            Return New ReportProfile With {
                .ReportName = reportName,
                .PrinterName = If(printerName, String.Empty),
                .ExportFormat = exportFormat,
                .UseCrystalReport = _settings.KeepCrystalReportsAsDefault
            }
        End Function
    End Class

End Namespace
