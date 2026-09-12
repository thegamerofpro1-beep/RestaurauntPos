Imports System
Imports System.IO
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Customization

    Public NotInheritable Class ApplicationPathResolver
        Private Sub New()
        End Sub

        Public Shared Function GetMenuImageDirectory() As String
            Return ResolveDirectory(SettingsHost.Current.Paths.MenuImageDirectory, "Menu Items Image")
        End Function

        Public Shared Function GetSecondaryDisplayImageDirectory() As String
            Return ResolveDirectory(SettingsHost.Current.Paths.SecondaryDisplayImageDirectory, "Secondary Display Images")
        End Function

        Public Shared Function GetBackupDirectory() As String
            Dim configured = SettingsHost.Current.Paths.BackupDirectory
            If String.IsNullOrWhiteSpace(configured) Then
                Try
                    Using key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\RestaurantPOS14")
                        If key IsNot Nothing Then configured = TryCast(key.GetValue("BackupFolder"), String)
                    End Using
                Catch suppressedException As System.Exception
                    RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Suppressed exception in ApplicationPathResolver", suppressedException)
                End Try
            End If
            If String.IsNullOrWhiteSpace(configured) Then
                configured = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), DatabaseMaintenance.GetCatalogFileStem() & " Backups")
            End If
            Return ResolveDirectory(configured, DatabaseMaintenance.GetCatalogFileStem() & " Backups")
        End Function

        Public Shared Sub RememberBackupDirectory(value As String)
            If String.IsNullOrWhiteSpace(value) Then Return
            Directory.CreateDirectory(value)
            Try
                Using key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\RestaurantPOS14")
                    key.SetValue("BackupFolder", value)
                End Using
            Catch suppressedException As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Suppressed exception in ApplicationPathResolver", suppressedException)
            End Try
        End Sub

        Private Shared Function ResolveDirectory(configured As String, fallback As String) As String
            If String.IsNullOrWhiteSpace(configured) Then configured = fallback
            If Not Path.IsPathRooted(configured) Then configured = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configured)
            Dim resolved = Path.GetFullPath(configured)
            Directory.CreateDirectory(resolved)
            Return resolved
        End Function
    End Class

End Namespace
