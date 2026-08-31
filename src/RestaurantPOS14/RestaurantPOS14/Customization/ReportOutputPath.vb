Imports System
Imports System.IO
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Customization

    ''' <summary>
    ''' Resolves report export paths from layered settings. Relative directories
    ''' remain relative to the application folder for recovered-app compatibility.
    ''' </summary>
    Public NotInheritable Class ReportOutputPath
        Private Sub New()
        End Sub

        Public Shared Function GetDirectoryPath() As String
            Return GetDirectoryPath(SettingsHost.Current.Paths)
        End Function

        Public Shared Function GetDirectoryPath(settings As PathSettings) As String
            If settings Is Nothing Then Throw New ArgumentNullException(NameOf(settings))

            Dim configured = settings.ReportOutputDirectory
            If String.IsNullOrWhiteSpace(configured) Then configured = "PDF Reports"
            If Not Path.IsPathRooted(configured) Then
                configured = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configured)
            End If

            Dim resolved = Path.GetFullPath(configured)
            Directory.CreateDirectory(resolved)
            Return resolved
        End Function

        Public Shared Function BuildFilePath(fileNamePrefix As String, extension As String) As String
            If String.IsNullOrWhiteSpace(fileNamePrefix) Then Throw New ArgumentException("A report file prefix is required.", NameOf(fileNamePrefix))
            If String.IsNullOrWhiteSpace(extension) Then extension = ".Pdf"
            If Not extension.StartsWith(".", StringComparison.Ordinal) Then extension = "." & extension

            Dim fileName = fileNamePrefix & " " & DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") & extension
            Return Path.Combine(GetDirectoryPath(), fileName)
        End Function
    End Class

End Namespace
