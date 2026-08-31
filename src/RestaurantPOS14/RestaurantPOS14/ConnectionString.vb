Imports System

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute>
    Friend NotInheritable Class ConnectionString
        Public Shared ReadOnly cs As String = RestaurantPOS14.ConnectionString.ReadCS()

        Public Shared Function ReadCS() As String
            RestaurantPOS14.Configuration.SettingsHost.Initialize()
            Dim value = RestaurantPOS14.Configuration.SettingsHost.Current.Database.ConnectionString
            If String.IsNullOrWhiteSpace(value) Then
                Throw New InvalidOperationException("No database connection string is configured. Run SQL Server Setup or configure the protected Database.ConnectionString secret.")
            End If
            Return value
        End Function
    End Class
End Namespace
