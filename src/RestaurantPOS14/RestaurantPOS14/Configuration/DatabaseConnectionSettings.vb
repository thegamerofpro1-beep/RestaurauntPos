Imports System
Imports System.Data.SqlClient

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class DatabaseConnectionSettings
        Private Sub New()
        End Sub

        Public Shared Function HasConfiguredConnection() As Boolean
            Return Not String.IsNullOrWhiteSpace(SettingsHost.Current.Database.ConnectionString)
        End Function

        Public Shared Function Build(serverName As String, catalog As String, integratedSecurity As Boolean, userName As String, password As String) As String
            If String.IsNullOrWhiteSpace(serverName) Then Throw New ArgumentException("SQL server name is required.", NameOf(serverName))
            If String.IsNullOrWhiteSpace(catalog) Then Throw New ArgumentException("SQL catalog is required.", NameOf(catalog))

            Dim builder As New SqlConnectionStringBuilder With {
                .DataSource = serverName.Trim(),
                .InitialCatalog = catalog.Trim(),
                .IntegratedSecurity = integratedSecurity,
                .MultipleActiveResultSets = True
            }
            If Not integratedSecurity Then
                If String.IsNullOrWhiteSpace(userName) Then Throw New ArgumentException("SQL user name is required.", NameOf(userName))
                If String.IsNullOrEmpty(password) Then Throw New ArgumentException("SQL password is required.", NameOf(password))
                builder.UserID = userName.Trim()
                builder.Password = password
            End If
            Return builder.ConnectionString
        End Function

        Public Shared Sub Save(connectionString As String)
            If String.IsNullOrWhiteSpace(connectionString) Then Throw New ArgumentException("A SQL connection string is required.", NameOf(connectionString))

            Dim builder As New SqlConnectionStringBuilder(connectionString)
            If String.IsNullOrWhiteSpace(builder.DataSource) OrElse String.IsNullOrWhiteSpace(builder.InitialCatalog) Then
                Throw New ArgumentException("The SQL connection string must specify a server and catalog.", NameOf(connectionString))
            End If

            Dim secretKey = SettingsHost.Current.Database.ConnectionStringSecretKey
            SettingsHost.SecretStore.SetSecret(secretKey, builder.ConnectionString)
            SettingsHost.Service.Reload()
        End Sub
    End Class

End Namespace
