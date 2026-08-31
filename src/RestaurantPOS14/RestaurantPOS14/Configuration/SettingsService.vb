Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.IO
Imports Newtonsoft.Json.Linq

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class SettingsReloadedEventArgs
        Inherits EventArgs

        Public ReadOnly Property RestartRequiredSettings As IReadOnlyList(Of String)

        Public Sub New(restartRequiredSettings As IEnumerable(Of String))
            Me.RestartRequiredSettings = New List(Of String)(restartRequiredSettings).AsReadOnly()
        End Sub
    End Class

    Public NotInheritable Class SettingsService
        Private ReadOnly _providers As IReadOnlyList(Of ISettingsProvider)
        Private ReadOnly _secretStore As ISecretStore
        Private ReadOnly _gate As New Object()
        Private ReadOnly _diagnostics As New List(Of String)()
        Private _current As ApplicationSettings = ApplicationSettings.CreateDefaults()

        Public Sub New(providers As IEnumerable(Of ISettingsProvider), secretStore As ISecretStore)
            If providers Is Nothing Then Throw New ArgumentNullException(NameOf(providers))
            Dim providerList = New List(Of ISettingsProvider)(providers)
            If providerList.Count = 0 Then Throw New ArgumentException("At least one settings provider is required.", NameOf(providers))
            _providers = providerList.AsReadOnly()
            _secretStore = secretStore
            For Each provider In _providers
                AddHandler provider.SettingsChanged, AddressOf OnProviderChanged
            Next
        End Sub

        Public ReadOnly Property Current As ApplicationSettings
            Get
                SyncLock _gate
                    Return _current
                End SyncLock
            End Get
        End Property

        Public ReadOnly Property Providers As IReadOnlyList(Of ISettingsProvider)
            Get
                Return _providers
            End Get
        End Property

        Public ReadOnly Property Diagnostics As IReadOnlyList(Of String)
            Get
                SyncLock _gate
                    Return New List(Of String)(_diagnostics).AsReadOnly()
                End SyncLock
            End Get
        End Property

        Public Event SettingsReloaded As EventHandler(Of SettingsReloadedEventArgs)
        Public Event ReloadFailed As EventHandler(Of ErrorEventArgs)

        Public Sub Reload()
            Dim restartRequired As IReadOnlyList(Of String)
            SyncLock _gate
                Dim merged As New JObject()
                _diagnostics.Clear()
                For Each provider In _providers
                    Dim layer = provider.Load()
                    If layer Is Nothing Then Throw New InvalidOperationException(provider.Name & " returned an empty settings document.")
                    JsonSettingsUtility.MergeInto(merged, layer)
                    If Not String.IsNullOrWhiteSpace(provider.LastWarning) Then _diagnostics.Add(provider.Name & ": " & provider.LastWarning)
                Next

                Dim nextSettings = merged.ToObject(Of ApplicationSettings)()
                HydrateSecrets(nextSettings)
                Dim errors = SettingsValidator.Validate(nextSettings)
                If errors.Count > 0 Then Throw New SettingsValidationException(errors)
                restartRequired = FindRestartRequiredChanges(_current, nextSettings)
                _current = nextSettings
            End SyncLock
            RaiseEvent SettingsReloaded(Me, New SettingsReloadedEventArgs(restartRequired))
        End Sub

        Private Sub HydrateSecrets(settings As ApplicationSettings)
            If _secretStore Is Nothing Then Return
            Dim value As String = Nothing
            If _secretStore.TryGetSecret(settings.Database.ConnectionStringSecretKey, value) Then settings.Database.ConnectionString = value
            If _secretStore.TryGetSecret(settings.EInvoice.ClientIdSecretKey, value) Then settings.EInvoice.ClientId = value
            If _secretStore.TryGetSecret(settings.EInvoice.ClientSecretSecretKey, value) Then settings.EInvoice.ClientSecret = value
            If _secretStore.TryGetSecret(settings.OnlineOrders.ApiKeySecretKey, value) Then settings.OnlineOrders.ApiKey = value
            If _secretStore.TryGetSecret(settings.OnlineOrders.SharedSecretSecretKey, value) Then settings.OnlineOrders.SharedSecret = value
        End Sub

        Private Shared Function FindRestartRequiredChanges(previous As ApplicationSettings, current As ApplicationSettings) As IReadOnlyList(Of String)
            Dim changed As New List(Of String)()
            If previous Is Nothing Then Return changed.AsReadOnly()
            If Not String.Equals(previous.Database.ConnectionString, current.Database.ConnectionString, StringComparison.Ordinal) Then changed.Add("Database.ConnectionString")
            If previous.Database.ConnectionTimeoutSeconds <> current.Database.ConnectionTimeoutSeconds Then changed.Add("Database.ConnectionTimeoutSeconds")
            If Not String.Equals(previous.Printing.CashDrawerPort, current.Printing.CashDrawerPort, StringComparison.OrdinalIgnoreCase) Then changed.Add("Printing.CashDrawerPort")
            If Not String.Equals(previous.Printing.CustomerDisplayPort, current.Printing.CustomerDisplayPort, StringComparison.OrdinalIgnoreCase) Then changed.Add("Printing.CustomerDisplayPort")
            If Not String.Equals(previous.Printing.CallerIdPort, current.Printing.CallerIdPort, StringComparison.OrdinalIgnoreCase) Then changed.Add("Printing.CallerIdPort")
            If Not String.Equals(previous.Printing.WeighingScalePort, current.Printing.WeighingScalePort, StringComparison.OrdinalIgnoreCase) Then changed.Add("Printing.WeighingScalePort")
            If Not String.Equals(previous.Printing.PaymentTerminalAddress, current.Printing.PaymentTerminalAddress, StringComparison.OrdinalIgnoreCase) Then changed.Add("Printing.PaymentTerminalAddress")
            If previous.Printing.PaymentTerminalPort <> current.Printing.PaymentTerminalPort Then changed.Add("Printing.PaymentTerminalPort")
            Return changed.AsReadOnly()
        End Function

        Private Sub OnProviderChanged(sender As Object, e As EventArgs)
            Try
                Reload()
            Catch ex As Exception
                SyncLock _gate
                    _diagnostics.Add("Hot reload failed: " & ex.Message)
                End SyncLock
                RaiseEvent ReloadFailed(Me, New ErrorEventArgs(ex))
            End Try
        End Sub
    End Class

End Namespace
