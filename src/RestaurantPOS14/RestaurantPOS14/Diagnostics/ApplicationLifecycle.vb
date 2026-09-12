Imports System
Imports System.Windows.Forms

Namespace RestaurantPOS14.Diagnostics
    Friend NotInheritable Class ApplicationLifecycle
        Private Sub New()
        End Sub

        Public Shared Sub ExitApplication()
            Try
                Application.Exit()
            Catch ex As Exception
                ApplicationDiagnostics.ReportNonFatal("Graceful application shutdown", ex)
            End Try
        End Sub
    End Class
End Namespace
