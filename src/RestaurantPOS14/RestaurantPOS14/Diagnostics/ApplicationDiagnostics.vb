Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms

Namespace RestaurantPOS14.Diagnostics

    ''' <summary>
    ''' Last-resort diagnostics that deliberately has no database dependency.  It is
    ''' safe to call while configuration, startup, or SQL Server is failing.
    ''' </summary>
    Friend NotInheritable Class ApplicationDiagnostics
        Private Shared ReadOnly SyncRoot As New Object()
        Private Const MaximumLogBytes As Long = 5L * 1024L * 1024L

        Private Sub New()
        End Sub

        Public Shared ReadOnly Property LogFilePath As String
            Get
                Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                                    "Hitech Computers", "RestaurantPOS14", "Logs", "application.log")
            End Get
        End Property

        Public Shared Sub ReportNonFatal(context As String, ex As Exception)
            If ex Is Nothing Then Return
            WriteEntry("NON-FATAL", context, ex)
        End Sub

        Public Shared Sub ReportFatal(context As String, ex As Exception)
            If ex Is Nothing Then Return
            WriteEntry("FATAL", context, ex)
        End Sub

        Private Shared Sub WriteEntry(level As String, context As String, ex As Exception)
            Try
                SyncLock SyncRoot
                    Dim path = LogFilePath
                    Dim directory = System.IO.Path.GetDirectoryName(path)
                    If Not System.IO.Directory.Exists(directory) Then System.IO.Directory.CreateDirectory(directory)

                    If File.Exists(path) AndAlso New FileInfo(path).Length > MaximumLogBytes Then
                        Dim archive = System.IO.Path.Combine(directory, "application.previous.log")
                        If File.Exists(archive) Then File.Delete(archive)
                        File.Move(path, archive)
                    End If

                    Dim message As New StringBuilder()
                    message.Append(DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss.fff zzz"))
                    message.Append(" [").Append(level).Append("] [thread ")
                    message.Append(Thread.CurrentThread.ManagedThreadId).Append("] ")
                    message.Append(If(context, String.Empty)).AppendLine()
                    message.AppendLine(ex.ToString())
                    message.AppendLine(New String("-"c, 80))
                    File.AppendAllText(path, message.ToString(), Encoding.UTF8)
                End SyncLock
            Catch
                ' Diagnostics must never become a second application failure.
            End Try
        End Sub

        Public Shared Sub HandleUnhandledUiException(sender As Object, e As ThreadExceptionEventArgs)
            ReportFatal("Unhandled Windows Forms exception", e.Exception)
            MessageBox.Show("The operation could not be completed. Details were written to:" &
                            Environment.NewLine & LogFilePath,
                            "Restaurant POS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

        Public Shared Sub HandleUnhandledDomainException(sender As Object, e As UnhandledExceptionEventArgs)
            Dim ex = TryCast(e.ExceptionObject, Exception)
            If ex Is Nothing Then ex = New Exception(Convert.ToString(e.ExceptionObject))
            ReportFatal("Unhandled application-domain exception", ex)
        End Sub
    End Class
End Namespace
