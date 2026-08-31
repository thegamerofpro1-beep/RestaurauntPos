Imports System
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Extensions.Payments

    Public NotInheritable Class PaymentRequest
        Public Property Amount As Decimal
        Public Property CurrencyCode As String = "MYR"
        Public Property Reference As String = String.Empty
    End Class

    Public NotInheritable Class PaymentResponse
        Public Property ProviderName As String = String.Empty
        Public Property RawResponse As String = String.Empty
        Public Property TransportCompleted As Boolean
    End Class

    Public Interface IPaymentProvider
        ReadOnly Property Name As String
        Function SendSale(request As PaymentRequest) As PaymentResponse
    End Interface

    ''' <summary>
    ''' Thin adapter over the Ingenico contract proven in the recovered application.
    ''' It deliberately leaves approval/decline interpretation to the existing POS flow.
    ''' </summary>
    Public NotInheritable Class IngenicoPaymentProvider
        Implements IPaymentProvider

        Private ReadOnly _address As String
        Private ReadOnly _port As Integer

        Public Sub New(settings As PrintingSettings)
            If settings Is Nothing Then Throw New ArgumentNullException(NameOf(settings))
            _address = settings.PaymentTerminalAddress
            _port = settings.PaymentTerminalPort
        End Sub

        Public ReadOnly Property Name As String Implements IPaymentProvider.Name
            Get
                Return "Ingenico"
            End Get
        End Property

        Public Function SendSale(request As PaymentRequest) As PaymentResponse Implements IPaymentProvider.SendSale
            If request Is Nothing Then Throw New ArgumentNullException(NameOf(request))
            If request.Amount < 0D Then Throw New ArgumentOutOfRangeException(NameOf(request.Amount), "Payment amount cannot be negative.")
            If String.IsNullOrWhiteSpace(_address) Then Throw New InvalidOperationException("Printing.PaymentTerminalAddress is required for Ingenico payments.")
            If _port < 1 OrElse _port > 65535 Then Throw New InvalidOperationException("Printing.PaymentTerminalPort must be between 1 and 65535.")

            Dim raw = New IngenicoDLL.IngenicoIntegration().SendSale(_address, _port, CDbl(request.Amount))
            Return New PaymentResponse With {
                .ProviderName = Name,
                .RawResponse = If(raw, String.Empty),
                .TransportCompleted = True
            }
        End Function
    End Class

    ''' <summary>
    ''' Creates the default provider from the latest layered settings and exposes a
    ''' replaceable provider for test terminals or future payment integrations.
    ''' </summary>
    Public NotInheritable Class PaymentProviderHost
        Private Shared ReadOnly Gate As New Object()
        Private Shared _overrideProvider As IPaymentProvider

        Private Sub New()
        End Sub

        Public Shared Property OverrideProvider As IPaymentProvider
            Get
                SyncLock Gate
                    Return _overrideProvider
                End SyncLock
            End Get
            Set(value As IPaymentProvider)
                SyncLock Gate
                    _overrideProvider = value
                End SyncLock
            End Set
        End Property

        Public Shared Function SendSale(amount As Decimal, Optional reference As String = "") As PaymentResponse
            Dim provider = OverrideProvider
            If provider Is Nothing Then provider = New IngenicoPaymentProvider(SettingsHost.Current.Printing)
            Return provider.SendSale(New PaymentRequest With {
                .Amount = amount,
                .CurrencyCode = SettingsHost.Current.Tax.CurrencyCode,
                .Reference = If(reference, String.Empty)
            })
        End Function

        Public Shared Sub Reset()
            OverrideProvider = Nothing
        End Sub
    End Class

End Namespace
