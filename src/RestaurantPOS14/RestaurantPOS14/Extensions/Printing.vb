Imports System
Imports System.Collections.Generic
Imports System.Drawing.Printing
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Extensions.Printing

    Public NotInheritable Class PrintJob
        Public Property DocumentName As String = String.Empty
        Public Property PrinterName As String = String.Empty
        Public Property Copies As Integer = 1
        Public Property Payload As Object
        Public Property Metadata As IDictionary(Of String, String) = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
    End Class

    Public NotInheritable Class PrintResult
        Public Property Accepted As Boolean
        Public Property Message As String = String.Empty
    End Class

    Public Interface IPrintService
        ReadOnly Property Name As String
        Function Print(job As PrintJob) As PrintResult
    End Interface

    ''' <summary>
    ''' Lets existing Crystal Reports, PrintDocument, or raw-printer code be exposed
    ''' through one seam without changing their output behavior.
    ''' </summary>
    Public NotInheritable Class DelegatingPrintService
        Implements IPrintService

        Private ReadOnly _name As String
        Private ReadOnly _handler As Func(Of PrintJob, PrintResult)

        Public Sub New(name As String, handler As Func(Of PrintJob, PrintResult))
            If String.IsNullOrWhiteSpace(name) Then Throw New ArgumentException("A print service name is required.", NameOf(name))
            If handler Is Nothing Then Throw New ArgumentNullException(NameOf(handler))
            _name = name
            _handler = handler
        End Sub

        Public ReadOnly Property Name As String Implements IPrintService.Name
            Get
                Return _name
            End Get
        End Property

        Public Function Print(job As PrintJob) As PrintResult Implements IPrintService.Print
            If job Is Nothing Then Throw New ArgumentNullException(NameOf(job))
            If job.Copies < 1 Then Throw New ArgumentOutOfRangeException(NameOf(job.Copies), "Copies must be at least one.")
            Return _handler(job)
        End Function
    End Class

    Public NotInheritable Class NullPrintService
        Implements IPrintService

        Private ReadOnly _jobs As New List(Of PrintJob)()

        Public ReadOnly Property Name As String Implements IPrintService.Name
            Get
                Return "Null/DryRun"
            End Get
        End Property

        Public ReadOnly Property Jobs As IReadOnlyList(Of PrintJob)
            Get
                Return _jobs.AsReadOnly()
            End Get
        End Property

        Public Function Print(job As PrintJob) As PrintResult Implements IPrintService.Print
            If job Is Nothing Then Throw New ArgumentNullException(NameOf(job))
            If job.Copies < 1 Then Throw New ArgumentOutOfRangeException(NameOf(job.Copies), "Copies must be at least one.")
            _jobs.Add(job)
            Return New PrintResult With {.Accepted = True, .Message = "Dry-run print captured."}
        End Function
    End Class

    Public NotInheritable Class CrystalReportPrintService
        Implements IPrintService

        Public ReadOnly Property Name As String Implements IPrintService.Name
            Get
                Return "Crystal Reports"
            End Get
        End Property

        Public Function Print(job As PrintJob) As PrintResult Implements IPrintService.Print
            If job Is Nothing Then Throw New ArgumentNullException(NameOf(job))
            If job.Copies < 1 OrElse job.Copies > Short.MaxValue Then Throw New ArgumentOutOfRangeException(NameOf(job.Copies), "Copies must be between one and 32767.")
            If String.IsNullOrWhiteSpace(job.PrinterName) Then
                Return New PrintResult With {.Accepted = False, .Message = "No printer is configured for this report."}
            End If

            Dim report = TryCast(job.Payload, ReportDocument)
            If report Is Nothing Then Throw New ArgumentException("Crystal Reports printing requires a ReportDocument payload.", NameOf(job))

            Dim printerSettings As New PrinterSettings With {.PrinterName = job.PrinterName, .Copies = CShort(job.Copies)}
            If Not printerSettings.IsValid Then
                Return New PrintResult With {.Accepted = False, .Message = "The configured printer '" & job.PrinterName & "' is not installed or is unavailable."}
            End If

            ' Microsoft Print to PDF cannot accept a silent Crystal print job without
            ' an output file. Exporting directly also avoids the driver's null-reference
            ' failure when Crystal is given a thermal custom paper size.
            If String.Equals(job.PrinterName.Trim(), "Microsoft Print to PDF", StringComparison.OrdinalIgnoreCase) Then
                Return New PdfPrintService().Print(job)
            End If

            Try
                report.PrintOptions.PrinterName = job.PrinterName
                report.PrintOptions.DissociatePageSizeAndPrinterPaperSize = True
                ' The report template and printer driver own the page size. The previous
                ' overload combined the target printer with PageSettings created for the
                ' Windows default printer, which can fail inside Crystal Reports.
                report.PrintToPrinter(job.Copies, collated:=False, 0, 0)
                Return New PrintResult With {.Accepted = True, .Message = "Print job submitted to '" & job.PrinterName & "'."}
            Catch ex As Exception
                Throw New InvalidOperationException("Crystal Reports could not print to '" & job.PrinterName & "'. Verify the printer is online and that its Windows driver supports this invoice layout. " & ex.Message, ex)
            End Try
        End Function
    End Class

    Public NotInheritable Class ThermalPrintService
        Implements IPrintService

        Public ReadOnly Property Name As String Implements IPrintService.Name
            Get
                Return "Thermal PrintDocument"
            End Get
        End Property

        Public Function Print(job As PrintJob) As PrintResult Implements IPrintService.Print
            Dim document = GetPrintDocument(job)
            Dim paperWidth = CInt(Math.Truncate(SettingsHost.Current.Printing.ThermalPaperWidthMm / 25.4R * 100.0R))
            document.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("Thermal", paperWidth, 60000)
            document.Print()
            Return New PrintResult With {.Accepted = True, .Message = "Thermal print job submitted."}
        End Function

        Private Shared Function GetPrintDocument(job As PrintJob) As PrintDocument
            If job Is Nothing Then Throw New ArgumentNullException(NameOf(job))
            If job.Copies < 1 OrElse job.Copies > Short.MaxValue Then Throw New ArgumentOutOfRangeException(NameOf(job.Copies), "Copies must be between one and 32767.")
            Dim document = TryCast(job.Payload, PrintDocument)
            If document Is Nothing Then Throw New ArgumentException("Thermal printing requires a PrintDocument payload.", NameOf(job))
            If Not String.IsNullOrWhiteSpace(job.DocumentName) Then document.DocumentName = job.DocumentName
            If Not String.IsNullOrWhiteSpace(job.PrinterName) Then document.PrinterSettings.PrinterName = job.PrinterName
            document.PrinterSettings.Copies = CShort(job.Copies)
            Return document
        End Function
    End Class

    Public NotInheritable Class A4PrintService
        Implements IPrintService

        Public ReadOnly Property Name As String Implements IPrintService.Name
            Get
                Return "A4 PrintDocument"
            End Get
        End Property

        Public Function Print(job As PrintJob) As PrintResult Implements IPrintService.Print
            If job Is Nothing Then Throw New ArgumentNullException(NameOf(job))
            If job.Copies < 1 OrElse job.Copies > Short.MaxValue Then Throw New ArgumentOutOfRangeException(NameOf(job.Copies), "Copies must be between one and 32767.")
            Dim document = TryCast(job.Payload, PrintDocument)
            If document Is Nothing Then Throw New ArgumentException("A4 printing requires a PrintDocument payload.", NameOf(job))
            If Not String.IsNullOrWhiteSpace(job.DocumentName) Then document.DocumentName = job.DocumentName
            If Not String.IsNullOrWhiteSpace(job.PrinterName) Then document.PrinterSettings.PrinterName = job.PrinterName
            document.PrinterSettings.Copies = CShort(job.Copies)

            Dim configuredName = SettingsHost.Current.Printing.A4PaperName
            Dim selected As System.Drawing.Printing.PaperSize = Nothing
            For Each candidate As System.Drawing.Printing.PaperSize In document.PrinterSettings.PaperSizes
                If String.Equals(candidate.PaperName, configuredName, StringComparison.OrdinalIgnoreCase) Then
                    selected = candidate
                    Exit For
                End If
            Next
            If selected Is Nothing Then selected = New System.Drawing.Printing.PaperSize(If(String.IsNullOrWhiteSpace(configuredName), "A4", configuredName), 827, 1169)
            document.DefaultPageSettings.PaperSize = selected
            document.Print()
            Return New PrintResult With {.Accepted = True, .Message = "A4 print job submitted."}
        End Function
    End Class

    Public NotInheritable Class PdfPrintService
        Implements IPrintService

        Public ReadOnly Property Name As String Implements IPrintService.Name
            Get
                Return "PDF"
            End Get
        End Property

        Public Function Print(job As PrintJob) As PrintResult Implements IPrintService.Print
            If job Is Nothing Then Throw New ArgumentNullException(NameOf(job))
            Dim report = TryCast(job.Payload, ReportDocument)
            If report Is Nothing Then Throw New ArgumentException("PDF output requires a Crystal ReportDocument payload.", NameOf(job))

            Dim outputPath As String = Nothing
            If job.Metadata IsNot Nothing Then job.Metadata.TryGetValue("OutputPath", outputPath)
            If String.IsNullOrWhiteSpace(outputPath) Then
                Dim prefix = If(String.IsNullOrWhiteSpace(job.DocumentName), "Report", job.DocumentName)
                outputPath = RestaurantPOS14.Customization.ReportOutputPath.BuildFilePath(prefix, ".pdf")
            Else
                outputPath = Path.GetFullPath(outputPath)
                Dim outputDirectory = Path.GetDirectoryName(outputPath)
                If Not String.IsNullOrWhiteSpace(outputDirectory) Then System.IO.Directory.CreateDirectory(outputDirectory)
            End If

            report.ExportToDisk(ExportFormatType.PortableDocFormat, outputPath)
            Return New PrintResult With {.Accepted = True, .Message = outputPath}
        End Function
    End Class

    ''' <summary>
    ''' Adds an explicit network-printer boundary while delegating the document
    ''' format to the selected physical print service.
    ''' </summary>
    Public NotInheritable Class NetworkPrintService
        Implements IPrintService

        Private ReadOnly _inner As IPrintService

        Public Sub New(inner As IPrintService)
            If inner Is Nothing Then Throw New ArgumentNullException(NameOf(inner))
            _inner = inner
        End Sub

        Public ReadOnly Property Name As String Implements IPrintService.Name
            Get
                Return "Network/" & _inner.Name
            End Get
        End Property

        Public Function Print(job As PrintJob) As PrintResult Implements IPrintService.Print
            If job Is Nothing Then Throw New ArgumentNullException(NameOf(job))
            If String.IsNullOrWhiteSpace(job.PrinterName) Then Return New PrintResult With {.Accepted = False, .Message = "A network printer name or share is required."}
            Return _inner.Print(job)
        End Function
    End Class

    ''' <summary>
    ''' Keeps the recovered Crystal printer as the default while allowing tests or
    ''' deployments to replace it with another IPrintService implementation.
    ''' </summary>
    Public NotInheritable Class PrintServiceHost
        Private Shared ReadOnly Gate As New Object()
        Private Shared _current As IPrintService = New CrystalReportPrintService()

        Private Sub New()
        End Sub

        Public Shared Property Current As IPrintService
            Get
                SyncLock Gate
                    Return _current
                End SyncLock
            End Get
            Set(value As IPrintService)
                If value Is Nothing Then Throw New ArgumentNullException(NameOf(value))
                SyncLock Gate
                    _current = value
                End SyncLock
            End Set
        End Property

        Public Shared Sub Reset()
            Current = New CrystalReportPrintService()
        End Sub
    End Class

End Namespace
