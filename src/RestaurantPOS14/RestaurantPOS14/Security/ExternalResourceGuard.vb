Imports System
Imports System.Diagnostics
Imports System.Net
Imports System.Windows.Forms

Namespace RestaurantPOS14.Security

    Friend NotInheritable Class ExternalResourceGuard
        Private Sub New()
        End Sub

        Public Shared Function RequireHttpUri(value As String, allowLoopbackHttp As Boolean) As Uri
            Dim uri As Uri = Nothing
            If Not Uri.TryCreate(If(value, String.Empty).Trim(), UriKind.Absolute, uri) Then
                Throw New ArgumentException("The configured service URL is not valid.")
            End If
            If uri.Scheme.Equals(Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase) Then Return uri
            If allowLoopbackHttp AndAlso uri.Scheme.Equals(Uri.UriSchemeHttp, StringComparison.OrdinalIgnoreCase) AndAlso uri.IsLoopback Then Return uri
            Throw New InvalidOperationException("The configured service URL must use HTTPS. HTTP is allowed only for a loopback service on this computer.")
        End Function

        Public Shared Function CreateRequest(uri As Uri, Optional timeoutMilliseconds As Integer = 10000) As HttpWebRequest
            If uri Is Nothing Then Throw New ArgumentNullException(NameOf(uri))
            Dim request = DirectCast(WebRequest.Create(uri), HttpWebRequest)
            request.Timeout = Math.Max(1000, timeoutMilliseconds)
            request.ReadWriteTimeout = Math.Max(1000, timeoutMilliseconds)
            request.AllowAutoRedirect = False
            request.UserAgent = "Hitech-RestaurantPOS14"
            Return request
        End Function

        Public Shared Sub OpenWebUrl(value As String)
            Dim uri = RequireHttpUri(value, False)
            Dim startInfo As New ProcessStartInfo(uri.AbsoluteUri) With {.UseShellExecute = True}
            Process.Start(startInfo)
        End Sub

        Public Shared Sub StartTrustedWindowsApplication(fileName As String, displayName As String)
            Dim normalizedName = If(fileName, String.Empty).Trim()
            Select Case normalizedName.ToLowerInvariant()
                Case "notepad.exe", "wordpad.exe", "calc.exe", "winword.exe", "mspaint.exe", "taskmgr.exe"
                    ' These fixed executable names are wired to Back Office buttons. Do not accept arbitrary paths here.
                Case Else
                    Throw New InvalidOperationException("The requested application is not allowed.")
            End Select

            Try
                Process.Start(New ProcessStartInfo(normalizedName) With {.UseShellExecute = True})
            Catch ex As Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Open Windows application " & normalizedName, ex)
                MessageBox.Show(If(String.IsNullOrWhiteSpace(displayName), "The selected application", displayName) & " is not installed or could not be opened.", "Open application", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Sub
    End Class
End Namespace
