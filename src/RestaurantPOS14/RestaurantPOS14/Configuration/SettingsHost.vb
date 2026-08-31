Imports System
Imports System.Collections.Generic
Imports System.IO
Imports Newtonsoft.Json.Linq

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class SettingsHost
        Private Shared ReadOnly Gate As New Object()
        Private Shared _service As SettingsService
        Private Shared _runtime As RuntimeSettingsProvider
        Private Shared _secretStore As ProtectedSecretStore
        Private Shared _machineSettingsPath As String
        Private Shared _terminalSettingsPath As String

        Private Sub New()
        End Sub

        Public Shared ReadOnly Property Current As ApplicationSettings
            Get
                EnsureInitialized()
                Return _service.Current
            End Get
        End Property

        Public Shared ReadOnly Property Service As SettingsService
            Get
                EnsureInitialized()
                Return _service
            End Get
        End Property

        Public Shared ReadOnly Property RuntimeOverrides As RuntimeSettingsProvider
            Get
                EnsureInitialized()
                Return _runtime
            End Get
        End Property

        Public Shared ReadOnly Property SecretStore As ISecretStore
            Get
                EnsureInitialized()
                Return _secretStore
            End Get
        End Property

        Public Shared ReadOnly Property MachineSettingsPath As String
            Get
                EnsureInitialized()
                Return _machineSettingsPath
            End Get
        End Property

        Public Shared ReadOnly Property TerminalSettingsPath As String
            Get
                EnsureInitialized()
                Return _terminalSettingsPath
            End Get
        End Property

        Public Shared Sub Initialize()
            EnsureInitialized()
        End Sub

        Private Shared Sub EnsureInitialized()
            If _service IsNot Nothing Then Return
            SyncLock Gate
                If _service IsNot Nothing Then Return

                Dim applicationDirectory = AppDomain.CurrentDomain.BaseDirectory
                Dim machineDirectory = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "RestaurantPOS14")
                Dim terminalDirectory = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestaurantPOS14")
                _machineSettingsPath = System.IO.Path.Combine(machineDirectory, "settings.json")
                _terminalSettingsPath = System.IO.Path.Combine(terminalDirectory, "terminal.settings.json")
                _secretStore = New ProtectedSecretStore(System.IO.Path.Combine(terminalDirectory, "secrets.dpapi.json"))

                Dim migrator As New LegacySettingsMigrator(applicationDirectory, _terminalSettingsPath, _secretStore)
                migrator.Migrate()

                Dim defaults = ApplicationSettings.CreateDefaults()
                defaults.Database.ConnectionString = migrator.ReadLegacyConnectionString()
                Dim builtIn As New BuiltInSettingsProvider(defaults)
                Dim machine As New JsonFileSettingsProvider("Machine JSON", _machineSettingsPath, enableHotReload:=True)
                Dim terminal As New JsonFileSettingsProvider("Terminal JSON", _terminalSettingsPath, enableHotReload:=True)

                Dim bootstrapProviders As ISettingsProvider() = {builtIn, machine, terminal}
                Dim bootstrapDocument As New JObject()
                For Each provider In bootstrapProviders
                    JsonSettingsUtility.MergeInto(bootstrapDocument, provider.Load())
                Next
                Dim bootstrap = bootstrapDocument.ToObject(Of ApplicationSettings)()
                Dim protectedConnectionString As String = Nothing
                If _secretStore.TryGetSecret(bootstrap.Database.ConnectionStringSecretKey, protectedConnectionString) Then
                    bootstrap.Database.ConnectionString = protectedConnectionString
                End If

                _runtime = New RuntimeSettingsProvider()
                Dim providers As New List(Of ISettingsProvider) From {
                    builtIn,
                    machine,
                    terminal,
                    New DatabaseSettingsProvider(bootstrap.Database.ConnectionString, _secretStore),
                    _runtime
                }
                _service = New SettingsService(providers, _secretStore)
                _service.Reload()
            End SyncLock
        End Sub
    End Class

End Namespace
