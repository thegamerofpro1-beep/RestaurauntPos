Imports System
Imports RestaurantPOS14.Configuration
Imports RestaurantPOS14.Extensions.Events

Namespace RestaurantPOS14.EInvoicing

    Public NotInheritable Class EInvoiceBillSettledSink
        Implements IIntegrationEventSink

        Public ReadOnly Property Name As String Implements IIntegrationEventSink.Name
            Get
                Return "MyInvois queue"
            End Get
        End Property

        Public Sub Handle(value As PosIntegrationEvent) Implements IIntegrationEventSink.Handle
            If value Is Nothing OrElse Not String.Equals(value.EventName, IntegrationEventNames.BillSettled, StringComparison.Ordinal) Then Return
            If Not SettingsHost.Current.Features.EInvoicing Then Return

            Dim payload = TryCast(value.Payload, BillSettledEventData)
            If payload Is Nothing Then Throw New InvalidOperationException("BillSettled requires BillSettledEventData.")
            Dim allowed = String.Equals(payload.BillType, "KOT", StringComparison.OrdinalIgnoreCase) OrElse
                          String.Equals(payload.BillType, "TA", StringComparison.OrdinalIgnoreCase) OrElse
                          String.Equals(payload.BillType, "HD", StringComparison.OrdinalIgnoreCase) OrElse
                          String.Equals(payload.BillType, "EB", StringComparison.OrdinalIgnoreCase)
            If Not allowed Then Throw New InvalidOperationException("Unsupported e-invoice bill type: " & payload.BillType)

            Dim queue As New EInvoiceQueue(SettingsHost.Current.Database.ConnectionString)
            queue.Enqueue(payload.BillId, payload.BillType.ToUpperInvariant())
        End Sub
    End Class

End Namespace
