Imports System
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Customization

    Public NotInheritable Class CrystalReportExporter
        Private Sub New()
        End Sub

        Public Shared Function Export(reportSource As Object, reportName As String, fileNamePrefix As String) As String
            Dim report = TryCast(reportSource, ReportDocument)
            If report Is Nothing Then Throw New ArgumentException("Report export requires a Crystal ReportDocument.", NameOf(reportSource))

            Dim settings = SettingsHost.Current
            Dim resolver As New ReportProfileResolver(settings.Reports, settings.Printing.DefaultPrinterName)
            Dim profile = resolver.Resolve(reportName)
            Dim format As ExportFormatType = ExportFormatType.PortableDocFormat
            Dim extension As String = ".Pdf"
            ResolveFormat(profile.ExportFormat, format, extension)

            Dim outputPath = ReportOutputPath.BuildFilePath(fileNamePrefix, extension)
            report.ExportToDisk(format, outputPath)
            Return outputPath
        End Function

        Private Shared Sub ResolveFormat(configured As String, ByRef format As ExportFormatType, ByRef extension As String)
            Select Case If(configured, String.Empty).Trim().ToUpperInvariant()
                Case "EXCEL"
                    format = ExportFormatType.Excel
                    extension = ".xls"
                Case "WORD"
                    format = ExportFormatType.WordForWindows
                    extension = ".doc"
                Case "CRYSTAL"
                    format = ExportFormatType.CrystalReport
                    extension = ".rpt"
                Case Else
                    format = ExportFormatType.PortableDocFormat
                    extension = ".Pdf"
            End Select
        End Sub
    End Class

End Namespace
