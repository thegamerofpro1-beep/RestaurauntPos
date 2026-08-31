Imports System
Imports System.IO.Ports

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class SerialPortFactory
        Private Sub New()
        End Sub

        Public Shared Function CreateCustomerDisplay(portName As String) As SerialPort
            If String.IsNullOrWhiteSpace(portName) Then Throw New InvalidOperationException("Printing.CustomerDisplayPort is not configured.")
            Dim port As New SerialPort(portName, 9600, Parity.None, 8, StopBits.One)
            ApplyTimeouts(port)
            Return port
        End Function

        Public Shared Sub ApplyTimeouts(port As SerialPort)
            If port Is Nothing Then Throw New ArgumentNullException(NameOf(port))
            Dim settings = SettingsHost.Current.Printing
            port.ReadTimeout = settings.SerialReadTimeoutMilliseconds
            port.WriteTimeout = settings.SerialWriteTimeoutMilliseconds
        End Sub
    End Class

End Namespace
