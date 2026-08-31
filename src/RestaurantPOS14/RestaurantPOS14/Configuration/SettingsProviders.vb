Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Namespace RestaurantPOS14.Configuration

    Public Interface ISettingsProvider
        ReadOnly Property Name As String
        ReadOnly Property SupportsHotReload As Boolean
        ReadOnly Property LastWarning As String
        Event SettingsChanged As EventHandler
        Function Load() As JObject
    End Interface

    Public Interface ISecretStore
        Function TryGetSecret(key As String, ByRef value As String) As Boolean
        Sub SetSecret(key As String, value As String)
        Sub RemoveSecret(key As String)
    End Interface

    Public NotInheritable Class BuiltInSettingsProvider
        Implements ISettingsProvider

        Private ReadOnly _settings As ApplicationSettings

        Public Sub New(settings As ApplicationSettings)
            If settings Is Nothing Then Throw New ArgumentNullException(NameOf(settings))
            _settings = settings
        End Sub

        Public ReadOnly Property Name As String Implements ISettingsProvider.Name
            Get
                Return "Built-in defaults"
            End Get
        End Property

        Public ReadOnly Property SupportsHotReload As Boolean Implements ISettingsProvider.SupportsHotReload
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property LastWarning As String Implements ISettingsProvider.LastWarning
            Get
                Return String.Empty
            End Get
        End Property

        Public Event SettingsChanged As EventHandler Implements ISettingsProvider.SettingsChanged

        Public Function Load() As JObject Implements ISettingsProvider.Load
            Return JObject.FromObject(_settings)
        End Function
    End Class

    Public NotInheritable Class JsonFileSettingsProvider
        Implements ISettingsProvider, IDisposable

        Private ReadOnly _path As String
        Private ReadOnly _name As String
        Private ReadOnly _watcher As FileSystemWatcher
        Private ReadOnly _debounceTimer As Timer
        Private _disposed As Boolean

        Public Sub New(name As String, path As String, enableHotReload As Boolean)
            If String.IsNullOrWhiteSpace(name) Then Throw New ArgumentException("A provider name is required.", NameOf(name))
            If String.IsNullOrWhiteSpace(path) Then Throw New ArgumentException("A settings path is required.", NameOf(path))
            _name = name
            _path = System.IO.Path.GetFullPath(path)
            _debounceTimer = New Timer(AddressOf RaiseDebouncedChange, Nothing, Timeout.Infinite, Timeout.Infinite)

            Dim directory = System.IO.Path.GetDirectoryName(_path)
            If enableHotReload AndAlso System.IO.Directory.Exists(directory) Then
                _watcher = New FileSystemWatcher(directory, System.IO.Path.GetFileName(_path)) With {
                    .IncludeSubdirectories = False,
                    .NotifyFilter = NotifyFilters.FileName Or NotifyFilters.LastWrite Or NotifyFilters.Size,
                    .EnableRaisingEvents = True
                }
                AddHandler _watcher.Changed, AddressOf OnFileChanged
                AddHandler _watcher.Created, AddressOf OnFileChanged
                AddHandler _watcher.Renamed, AddressOf OnFileRenamed
                AddHandler _watcher.Deleted, AddressOf OnFileChanged
            End If
        End Sub

        Public ReadOnly Property FilePath As String
            Get
                Return _path
            End Get
        End Property

        Public ReadOnly Property Name As String Implements ISettingsProvider.Name
            Get
                Return _name
            End Get
        End Property

        Public ReadOnly Property SupportsHotReload As Boolean Implements ISettingsProvider.SupportsHotReload
            Get
                Return _watcher IsNot Nothing
            End Get
        End Property

        Public ReadOnly Property LastWarning As String Implements ISettingsProvider.LastWarning
            Get
                Return String.Empty
            End Get
        End Property

        Public Event SettingsChanged As EventHandler Implements ISettingsProvider.SettingsChanged

        Public Function Load() As JObject Implements ISettingsProvider.Load
            If Not File.Exists(_path) Then Return New JObject()
            Try
                Dim root = JObject.Parse(File.ReadAllText(_path))
                RejectPlaintextSecrets(root)
                Return root
            Catch ex As JsonException
                Throw New InvalidDataException("Invalid JSON in " & _path & ": " & ex.Message, ex)
            End Try
        End Function

        Private Shared Sub RejectPlaintextSecrets(root As JObject)
            Dim forbidden = New HashSet(Of String)(
                New String() {"ClientId", "ClientSecret", "ApiKey", "SharedSecret", "Password", "Pwd"},
                StringComparer.OrdinalIgnoreCase)
            For Each item In root.Descendants().OfType(Of JProperty)()
                If forbidden.Contains(item.Name) AndAlso item.Value.Type <> JTokenType.Null AndAlso Not String.IsNullOrWhiteSpace(CStr(item.Value)) Then
                    Throw New InvalidDataException("Plaintext secret '" & item.Path & "' is not allowed. Store it through the DPAPI secret store and reference its secret key.")
                End If
            Next

            Dim connectionToken = root.SelectToken("Database.ConnectionString", errorWhenNoMatch:=False)
            If connectionToken Is Nothing OrElse connectionToken.Type = JTokenType.Null Then Return
            Dim connectionString = CStr(connectionToken)
            If String.IsNullOrWhiteSpace(connectionString) Then Return
            Try
                Dim builder As New SqlConnectionStringBuilder(connectionString)
                If Not String.IsNullOrEmpty(builder.Password) Then
                    Throw New InvalidDataException("Database.ConnectionString contains a plaintext password. Store the connection string through the DPAPI secret store.")
                End If
            Catch ex As ArgumentException
                Throw New InvalidDataException("Database.ConnectionString is invalid: " & ex.Message, ex)
            End Try
        End Sub

        Private Sub OnFileChanged(sender As Object, e As FileSystemEventArgs)
            _debounceTimer.Change(250, Timeout.Infinite)
        End Sub

        Private Sub OnFileRenamed(sender As Object, e As RenamedEventArgs)
            _debounceTimer.Change(250, Timeout.Infinite)
        End Sub

        Private Sub RaiseDebouncedChange(state As Object)
            RaiseEvent SettingsChanged(Me, EventArgs.Empty)
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            If _disposed Then Return
            _disposed = True
            If _watcher IsNot Nothing Then _watcher.Dispose()
            _debounceTimer.Dispose()
        End Sub
    End Class

    Public NotInheritable Class RuntimeSettingsProvider
        Implements ISettingsProvider

        Private ReadOnly _values As New JObject()
        Private ReadOnly _gate As New Object()

        Public ReadOnly Property Name As String Implements ISettingsProvider.Name
            Get
                Return "Runtime overrides"
            End Get
        End Property

        Public ReadOnly Property SupportsHotReload As Boolean Implements ISettingsProvider.SupportsHotReload
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property LastWarning As String Implements ISettingsProvider.LastWarning
            Get
                Return String.Empty
            End Get
        End Property

        Public Event SettingsChanged As EventHandler Implements ISettingsProvider.SettingsChanged

        Public Function Load() As JObject Implements ISettingsProvider.Load
            SyncLock _gate
                Return CType(_values.DeepClone(), JObject)
            End SyncLock
        End Function

        Public Sub SetValue(path As String, value As Object)
            SyncLock _gate
                JsonSettingsUtility.SetPath(_values, path, If(value Is Nothing, JValue.CreateNull(), JToken.FromObject(value)))
            End SyncLock
            RaiseEvent SettingsChanged(Me, EventArgs.Empty)
        End Sub

        Public Sub Clear()
            SyncLock _gate
                _values.RemoveAll()
            End SyncLock
            RaiseEvent SettingsChanged(Me, EventArgs.Empty)
        End Sub
    End Class

    Public NotInheritable Class DatabaseSettingsProvider
        Implements ISettingsProvider

        Private ReadOnly _connectionString As String
        Private ReadOnly _secretStore As ISecretStore
        Private _lastWarning As String = String.Empty

        Public Sub New(connectionString As String, secretStore As ISecretStore)
            _connectionString = connectionString
            _secretStore = secretStore
        End Sub

        Public ReadOnly Property Name As String Implements ISettingsProvider.Name
            Get
                Return "Database settings"
            End Get
        End Property

        Public ReadOnly Property SupportsHotReload As Boolean Implements ISettingsProvider.SupportsHotReload
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property LastWarning As String Implements ISettingsProvider.LastWarning
            Get
                Return _lastWarning
            End Get
        End Property

        Public Event SettingsChanged As EventHandler Implements ISettingsProvider.SettingsChanged

        Public Function Load() As JObject Implements ISettingsProvider.Load
            Dim result As New JObject()
            _lastWarning = String.Empty
            If String.IsNullOrWhiteSpace(_connectionString) Then Return result

            Try
                Using connection As New SqlConnection(_connectionString)
                    connection.Open()
                    LoadApplicationSettings(connection, result)
                    LoadLegacyOtherSetting(connection, result)
                    LoadLegacyTerminalSettings(connection, result)
                End Using
            Catch ex As SqlException
                _lastWarning = "Database settings were unavailable: " & ex.Message
            End Try
            Return result
        End Function

        Private Shared Sub LoadApplicationSettings(connection As SqlConnection, destination As JObject)
            Const sql = "IF OBJECT_ID('dbo.ApplicationSettings','U') IS NOT NULL SELECT SettingPath, JsonValue FROM dbo.ApplicationSettings WHERE IsEnabled=1"
            Using command As New SqlCommand(sql, connection)
                Using reader = command.ExecuteReader()
                    While reader.Read()
                        Dim path = reader.GetString(0).Trim()
                        Dim raw = reader.GetString(1)
                        Dim value As JToken
                        Try
                            value = JToken.Parse(raw)
                        Catch ex As JsonException
                            Throw New InvalidDataException("Database setting '" & path & "' does not contain valid JSON.", ex)
                        End Try
                        JsonSettingsUtility.SetPath(destination, path, value)
                    End While
                End Using
            End Using
        End Sub

        Private Sub LoadLegacyOtherSetting(connection As SqlConnection, destination As JObject)
            Const sql = "IF OBJECT_ID('dbo.OtherSetting','U') IS NOT NULL SELECT TOP 1 EnableChecklist, EnableMyInvois, MyInvoisBaseUrl, MyInvoisClientId, MyInvoisClientSecret, MyInvoisEnvironment FROM dbo.OtherSetting"
            Using command As New SqlCommand(sql, connection)
                Using reader = command.ExecuteReader()
                    If Not reader.Read() Then Return
                    If Not reader.IsDBNull(0) Then JsonSettingsUtility.SetPath(destination, "Features.Checklist", New JValue(String.Equals(reader.GetString(0).Trim(), "Yes", StringComparison.OrdinalIgnoreCase)))
                    If Not reader.IsDBNull(1) Then JsonSettingsUtility.SetPath(destination, "Features.EInvoicing", New JValue(String.Equals(reader.GetString(1).Trim(), "Yes", StringComparison.OrdinalIgnoreCase)))
                    If Not reader.IsDBNull(2) AndAlso Not String.IsNullOrWhiteSpace(reader.GetString(2)) Then JsonSettingsUtility.SetPath(destination, "EInvoice.BaseUrl", New JValue(reader.GetString(2).Trim()))
                    If Not reader.IsDBNull(5) AndAlso Not String.IsNullOrWhiteSpace(reader.GetString(5)) Then JsonSettingsUtility.SetPath(destination, "EInvoice.Environment", New JValue(reader.GetString(5).Trim()))
                    If _secretStore IsNot Nothing Then
                        If Not reader.IsDBNull(3) AndAlso Not String.IsNullOrWhiteSpace(reader.GetString(3)) Then _secretStore.SetSecret("EInvoice.ClientId", reader.GetString(3).Trim())
                        If Not reader.IsDBNull(4) AndAlso Not String.IsNullOrWhiteSpace(reader.GetString(4)) Then _secretStore.SetSecret("EInvoice.ClientSecret", reader.GetString(4))
                    End If
                End Using
            End Using
        End Sub

        Private Shared Sub LoadLegacyTerminalSettings(connection As SqlConnection, destination As JObject)
            Const sql = "IF OBJECT_ID('dbo.POSPrinterSetting','U') IS NOT NULL SELECT TOP 1 PrinterName, IsEnabled, CashDrawer, CustomerDisplay, CDPort, CallerID, CallerIDPort, PT, PTipAddress, PTPortNo, CCD, WS, WSPortNo FROM dbo.POSPrinterSetting WHERE TillID=@TillID"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@TillID", System.Net.Dns.GetHostName())
                Using reader = command.ExecuteReader()
                    If Not reader.Read() Then Return

                    Dim printerName = ReadTrimmedString(reader, 0)
                    Dim printerEnabled = IsYes(reader, 1)
                    Dim cashDrawerEnabled = String.Equals(ReadTrimmedString(reader, 2), "Enabled", StringComparison.OrdinalIgnoreCase)
                    Dim customerDisplayEnabled = IsYes(reader, 3)
                    Dim callerIdEnabled = IsYes(reader, 5)
                    Dim paymentTerminalEnabled = IsYes(reader, 7)
                    Dim coloredCustomerDisplayEnabled = IsYes(reader, 10)
                    Dim weighingScaleEnabled = IsYes(reader, 11)

                    If printerEnabled AndAlso Not String.IsNullOrWhiteSpace(printerName) Then
                        JsonSettingsUtility.SetPath(destination, "Printing.DefaultPrinterName", New JValue(printerName))
                    End If
                    If cashDrawerEnabled AndAlso Not String.IsNullOrWhiteSpace(printerName) Then
                        JsonSettingsUtility.SetPath(destination, "Printing.CashDrawerPort", New JValue(printerName))
                    End If

                    Dim customerDisplayPort = ReadTrimmedString(reader, 4)
                    If customerDisplayEnabled AndAlso Not String.IsNullOrWhiteSpace(customerDisplayPort) Then
                        JsonSettingsUtility.SetPath(destination, "Printing.CustomerDisplayPort", New JValue(customerDisplayPort))
                    End If

                    Dim callerIdPort = ReadTrimmedString(reader, 6)
                    If callerIdEnabled AndAlso Not String.IsNullOrWhiteSpace(callerIdPort) Then
                        JsonSettingsUtility.SetPath(destination, "Printing.CallerIdPort", New JValue(callerIdPort))
                    End If

                    Dim paymentAddress = ReadTrimmedString(reader, 8)
                    Dim paymentPort As Integer
                    If paymentTerminalEnabled AndAlso Not String.IsNullOrWhiteSpace(paymentAddress) Then
                        JsonSettingsUtility.SetPath(destination, "Printing.PaymentTerminalAddress", New JValue(paymentAddress))
                    End If
                    If paymentTerminalEnabled AndAlso Integer.TryParse(ReadTrimmedString(reader, 9), paymentPort) Then
                        JsonSettingsUtility.SetPath(destination, "Printing.PaymentTerminalPort", New JValue(paymentPort))
                    End If

                    Dim weighingScalePort = ReadTrimmedString(reader, 12)
                    If weighingScaleEnabled AndAlso Not String.IsNullOrWhiteSpace(weighingScalePort) Then
                        JsonSettingsUtility.SetPath(destination, "Printing.WeighingScalePort", New JValue(weighingScalePort))
                    End If

                    JsonSettingsUtility.SetPath(destination, "Features.SecondaryDisplay", New JValue(customerDisplayEnabled OrElse coloredCustomerDisplayEnabled))
                    JsonSettingsUtility.SetPath(destination, "Features.CallerId", New JValue(callerIdEnabled))
                    JsonSettingsUtility.SetPath(destination, "Features.WeighingScale", New JValue(weighingScaleEnabled))
                    JsonSettingsUtility.SetPath(destination, "Features.IngenicoTerminal", New JValue(paymentTerminalEnabled))
                End Using
            End Using
        End Sub

        Private Shared Function ReadTrimmedString(reader As SqlDataReader, ordinal As Integer) As String
            If reader.IsDBNull(ordinal) Then Return String.Empty
            Return Convert.ToString(reader.GetValue(ordinal)).Trim()
        End Function

        Private Shared Function IsYes(reader As SqlDataReader, ordinal As Integer) As Boolean
            Return String.Equals(ReadTrimmedString(reader, ordinal), "Yes", StringComparison.OrdinalIgnoreCase)
        End Function
    End Class

    Friend NotInheritable Class JsonSettingsUtility
        Private Sub New()
        End Sub

        Public Shared Sub MergeInto(destination As JObject, source As JObject)
            For Each item In source.Properties()
                Dim destinationObject = TryCast(destination(item.Name), JObject)
                Dim sourceObject = TryCast(item.Value, JObject)
                If destinationObject IsNot Nothing AndAlso sourceObject IsNot Nothing Then
                    MergeInto(destinationObject, sourceObject)
                Else
                    destination(item.Name) = item.Value.DeepClone()
                End If
            Next
        End Sub

        Public Shared Sub SetPath(root As JObject, path As String, value As JToken)
            If String.IsNullOrWhiteSpace(path) Then Throw New ArgumentException("A setting path is required.", NameOf(path))
            Dim parts = path.Split("."c)
            Dim current = root
            For index = 0 To parts.Length - 2
                Dim child = TryCast(current(parts(index)), JObject)
                If child Is Nothing Then
                    child = New JObject()
                    current(parts(index)) = child
                End If
                current = child
            Next
            current(parts(parts.Length - 1)) = value.DeepClone()
        End Sub
    End Class

End Namespace
