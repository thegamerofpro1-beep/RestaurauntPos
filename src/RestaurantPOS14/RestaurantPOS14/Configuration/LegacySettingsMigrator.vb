Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class LegacySettingsMigrator
        Private Const ConnectionStringName As String = "RestaurantPOS14.My.MySettings.RPOS_DBConnectionString"
        Private ReadOnly _applicationDirectory As String
        Private ReadOnly _terminalSettingsPath As String
        Private ReadOnly _secretStore As ISecretStore

        Public Sub New(applicationDirectory As String, terminalSettingsPath As String, secretStore As ISecretStore)
            _applicationDirectory = System.IO.Path.GetFullPath(applicationDirectory)
            _terminalSettingsPath = System.IO.Path.GetFullPath(terminalSettingsPath)
            _secretStore = secretStore
        End Sub

        Public Sub Migrate()
            Dim root = LoadTerminalSettings()
            Dim sources As New List(Of String)()

            MigrateConnectionString(root, sources)
            MigrateEInvoiceFile(root, sources)
            MigrateRegistry(root, sources)

            root("_schemaVersion") = 1
            root("_legacyMigrationCompleted") = True
            If sources.Count > 0 Then root("_legacySources") = New JArray(sources)
            SaveTerminalSettings(root)
        End Sub

        Public Function ReadLegacyConnectionString() As String
            Dim legacyPath = System.IO.Path.Combine(_applicationDirectory, "SQLSettings.dat")
            If File.Exists(legacyPath) Then
                Dim value = File.ReadAllLines(legacyPath).FirstOrDefault()
                If Not String.IsNullOrWhiteSpace(value) Then Return ValidateConnectionString(value.Trim(), legacyPath)
            End If

            Dim configured = ConfigurationManager.ConnectionStrings(ConnectionStringName)
            If configured IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(configured.ConnectionString) Then
                Return ValidateConnectionString(configured.ConnectionString, "App.config")
            End If
            Return String.Empty
        End Function

        Private Sub MigrateConnectionString(root As JObject, sources As List(Of String))
            Dim connectionString = ReadLegacyConnectionString()
            If String.IsNullOrWhiteSpace(connectionString) Then Return

            If _secretStore IsNot Nothing Then _secretStore.SetSecret("Database.ConnectionString", connectionString)
            SetIfMissing(root, "Database.ConnectionStringSecretKey", New JValue("Database.ConnectionString"))
            sources.Add(If(File.Exists(System.IO.Path.Combine(_applicationDirectory, "SQLSettings.dat")), "SQLSettings.dat", "App.config"))
        End Sub

        Private Sub MigrateEInvoiceFile(root As JObject, sources As List(Of String))
            Dim path = System.IO.Path.Combine(_applicationDirectory, "EInvoiceConfig.json")
            If Not File.Exists(path) Then Return
            Dim legacy As JObject
            Try
                legacy = JObject.Parse(File.ReadAllText(path))
            Catch ex As JsonException
                Throw New InvalidDataException("Legacy EInvoiceConfig.json is invalid: " & ex.Message, ex)
            End Try

            Dim baseUrl = FirstString(legacy, "baseUrl", "BaseUrl")
            Dim clientId = FirstString(legacy, "clientId", "ClientId")
            Dim clientSecret = FirstString(legacy, "clientSecret", "ClientSecret")
            If Not String.IsNullOrWhiteSpace(baseUrl) Then SetIfMissing(root, "EInvoice.BaseUrl", New JValue(baseUrl))
            If _secretStore IsNot Nothing Then
                If Not String.IsNullOrWhiteSpace(clientId) Then _secretStore.SetSecret("EInvoice.ClientId", clientId)
                If Not String.IsNullOrWhiteSpace(clientSecret) Then _secretStore.SetSecret("EInvoice.ClientSecret", clientSecret)
            End If
            sources.Add("EInvoiceConfig.json")
        End Sub

        Private Shared Sub MigrateRegistry(root As JObject, sources As List(Of String))
            Try
                Using key = Registry.CurrentUser.OpenSubKey("Software\RestaurantPOS14")
                    If key Is Nothing Then Return
                    Dim backupFolder = TryCast(key.GetValue("BackupFolder"), String)
                    If String.IsNullOrWhiteSpace(backupFolder) Then Return
                    SetIfMissing(root, "Paths.BackupDirectory", New JValue(backupFolder))
                    sources.Add("HKCU\Software\RestaurantPOS14")
                End Using
            Catch ex As System.Security.SecurityException
                Throw New InvalidOperationException("The legacy RestaurantPOS14 registry settings could not be read.", ex)
            End Try
        End Sub

        Private Function LoadTerminalSettings() As JObject
            If Not File.Exists(_terminalSettingsPath) Then Return New JObject()
            Try
                Return JObject.Parse(File.ReadAllText(_terminalSettingsPath))
            Catch ex As JsonException
                Throw New InvalidDataException("Terminal settings are invalid JSON: " & _terminalSettingsPath, ex)
            End Try
        End Function

        Private Sub SaveTerminalSettings(root As JObject)
            Dim directory = System.IO.Path.GetDirectoryName(_terminalSettingsPath)
            System.IO.Directory.CreateDirectory(directory)
            Dim temporary = _terminalSettingsPath & ".tmp"
            File.WriteAllText(temporary, root.ToString(Formatting.Indented), New UTF8Encoding(False))
            If File.Exists(_terminalSettingsPath) Then
                File.Replace(temporary, _terminalSettingsPath, Nothing)
            Else
                File.Move(temporary, _terminalSettingsPath)
            End If
        End Sub

        Private Shared Function ValidateConnectionString(value As String, source As String) As String
            Try
                Dim builder As New SqlConnectionStringBuilder(value)
                If String.IsNullOrWhiteSpace(builder.DataSource) OrElse String.IsNullOrWhiteSpace(builder.InitialCatalog) Then
                    Throw New InvalidDataException(source & " does not specify both Data Source and Initial Catalog.")
                End If
                Return builder.ConnectionString
            Catch ex As ArgumentException
                Throw New InvalidDataException(source & " contains an invalid SQL connection string: " & ex.Message, ex)
            End Try
        End Function

        Private Shared Sub SetIfMissing(root As JObject, path As String, value As JToken)
            If root.SelectToken(path, errorWhenNoMatch:=False) Is Nothing Then JsonSettingsUtility.SetPath(root, path, value)
        End Sub

        Private Shared Function FirstString(root As JObject, ParamArray names As String()) As String
            For Each name In names
                Dim token = root(name)
                If token IsNot Nothing AndAlso token.Type <> JTokenType.Null Then Return CStr(token)
            Next
            Return String.Empty
        End Function
    End Class

End Namespace
