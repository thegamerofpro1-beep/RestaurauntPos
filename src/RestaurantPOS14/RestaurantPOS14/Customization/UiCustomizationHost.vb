Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Customization

    ''' <summary>
    ''' Applies configured culture/theme/touch overrides once when each recovered
    ''' form opens. Built-in UI override values are no-op, preserving designer styles.
    ''' </summary>
    Public NotInheritable Class UiCustomizationHost
        Private Shared ReadOnly Gate As New Object()
        Private Shared ReadOnly AppliedForms As New HashSet(Of Form)()
        Private Shared _initialized As Boolean

        Private Sub New()
        End Sub

        Public Shared Sub Initialize()
            SyncLock Gate
                If _initialized Then Return
                SettingsHost.Initialize()
                AddHandler Application.Idle, AddressOf OnApplicationIdle
                _initialized = True
            End SyncLock
        End Sub

        Private Shared Sub OnApplicationIdle(sender As Object, e As EventArgs)
            Dim openForms As New List(Of Form)()
            For Each form As Form In Application.OpenForms
                openForms.Add(form)
            Next

            For Each form In openForms
                If AppliedForms.Contains(form) Then Continue For
                Try
                    ThemeService.Apply(form, SettingsHost.Current.Ui)
                Catch
                    ' A third-party control should not prevent the recovered form opening.
                End Try
                AppliedForms.Add(form)
            Next

            AppliedForms.RemoveWhere(Function(form) form Is Nothing OrElse form.IsDisposed)
        End Sub
    End Class

End Namespace
