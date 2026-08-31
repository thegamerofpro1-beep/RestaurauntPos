Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class DatabaseMaintenance
        Private Sub New()
        End Sub

        Public Shared Function BuildBackupFileName() As String
            Return GetCatalogFileStem() & " " & DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") & ".bak"
        End Function

        Public Shared Function CreateBackupCommand(connection As SqlConnection, filePath As String) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            If String.IsNullOrWhiteSpace(filePath) Then Throw New ArgumentException("A backup file path is required.", NameOf(filePath))
            Dim command As New SqlCommand("BACKUP DATABASE " & QuoteCatalogName() & " TO DISK=@path WITH INIT, STATS=10", connection)
            command.Parameters.Add("@path", SqlDbType.NVarChar, 4000).Value = filePath
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function CreateRestoreCommand(connection As SqlConnection, filePath As String) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            If String.IsNullOrWhiteSpace(filePath) Then Throw New ArgumentException("A restore file path is required.", NameOf(filePath))
            Dim catalog = QuoteCatalogName()
            Dim commandText = "USE [master]; ALTER DATABASE " & catalog & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " &
                              "RESTORE DATABASE " & catalog & " FROM DISK=@path WITH REPLACE; " &
                              "ALTER DATABASE " & catalog & " SET MULTI_USER;"
            Dim command As New SqlCommand(commandText, connection)
            command.Parameters.Add("@path", SqlDbType.NVarChar, 4000).Value = filePath
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function CreateDatabaseExistsCommand(connection As SqlConnection) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            Dim command As New SqlCommand("SELECT 1 FROM sys.databases WHERE name=@catalog", connection)
            command.Parameters.Add("@catalog", SqlDbType.NVarChar, 128).Value = GetCatalogName()
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function CreateDropDatabaseCommand(connection As SqlConnection) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            Dim catalog = QuoteCatalogName()
            Dim command As New SqlCommand("USE [master]; ALTER DATABASE " & catalog & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE " & catalog & ";", connection)
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function CreateDatabaseCommand(connection As SqlConnection) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            Dim command As New SqlCommand("CREATE DATABASE " & QuoteCatalogName() & ";", connection)
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function PrepareDatabaseScript(script As String) As String
            If script Is Nothing Then Throw New ArgumentNullException(NameOf(script))
            Return script.Replace("[RPOS_DB]", QuoteCatalogName())
        End Function

        Public Shared Function GetCatalogName() As String
            Dim value = SettingsHost.Current.Database.DefaultCatalog
            If String.IsNullOrWhiteSpace(value) Then value = "RPOS_DB"
            Return value.Trim()
        End Function

        Public Shared Function GetCatalogFileStem() As String
            Dim value = GetCatalogName()
            For Each invalidCharacter In System.IO.Path.GetInvalidFileNameChars()
                value = value.Replace(invalidCharacter, "_"c)
            Next
            Return value
        End Function

        Private Shared Function QuoteCatalogName() As String
            Return New SqlCommandBuilder().QuoteIdentifier(GetCatalogName())
        End Function
    End Class

End Namespace
