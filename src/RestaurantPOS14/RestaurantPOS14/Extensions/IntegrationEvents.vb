Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Extensions.Events

    Public NotInheritable Class PosIntegrationEvent
        Public Property EventName As String = String.Empty
        Public Property OccurredUtc As DateTime = DateTime.UtcNow
        Public Property Reference As String = String.Empty
        Public Property Payload As Object
    End Class

    Public NotInheritable Class IntegrationEventDispatchResult
        Public Property SubscribersInvoked As Integer
        Public ReadOnly Property Errors As List(Of Exception)

        Public Sub New()
            Errors = New List(Of Exception)()
        End Sub
    End Class

    Public NotInheritable Class BillSettledEventData
        Public Property BillId As Integer
        Public Property BillType As String = String.Empty
        Public Property SettlementStatus As String = String.Empty
    End Class

    Public NotInheritable Class OrderCreatedEventData
        Public Property OrderId As Integer
        Public Property OrderType As String = String.Empty
    End Class

    Public NotInheritable Class DayClosedEventData
        Public Property WorkPeriodId As Integer
        Public Property StartedAt As DateTime
        Public Property EndedAt As DateTime
    End Class

    Public Interface IOnlineOrderEventPublisher
        ReadOnly Property Name As String
        Sub Publish(value As PosIntegrationEvent)
    End Interface

    ''' <summary>
    ''' Safe default until a deployment supplies the contract-specific online-order
    ''' adapter. The recovered binary does not contain a proven outbound API contract.
    ''' </summary>
    Public NotInheritable Class NullOnlineOrderEventPublisher
        Implements IOnlineOrderEventPublisher

        Public ReadOnly Property Name As String Implements IOnlineOrderEventPublisher.Name
            Get
                Return "Null/NotConfigured"
            End Get
        End Property

        Public Sub Publish(value As PosIntegrationEvent) Implements IOnlineOrderEventPublisher.Publish
        End Sub
    End Class

    Public NotInheritable Class OnlineOrderEventPublisherHost
        Private Shared ReadOnly Gate As New Object()
        Private Shared _current As IOnlineOrderEventPublisher = New NullOnlineOrderEventPublisher()

        Private Sub New()
        End Sub

        Public Shared Property Current As IOnlineOrderEventPublisher
            Get
                SyncLock Gate
                    Return _current
                End SyncLock
            End Get
            Set(value As IOnlineOrderEventPublisher)
                If value Is Nothing Then Throw New ArgumentNullException(NameOf(value))
                SyncLock Gate
                    _current = value
                End SyncLock
            End Set
        End Property

        Public Shared Sub Reset()
            Current = New NullOnlineOrderEventPublisher()
        End Sub
    End Class

    Public NotInheritable Class OnlineOrderIntegrationSink
        Implements IIntegrationEventSink

        Public ReadOnly Property Name As String Implements IIntegrationEventSink.Name
            Get
                Return "Online order publisher"
            End Get
        End Property

        Public Sub Handle(value As PosIntegrationEvent) Implements IIntegrationEventSink.Handle
            If value Is Nothing OrElse Not SettingsHost.Current.Features.OnlineOrders Then Return
            If Not String.Equals(value.EventName, IntegrationEventNames.OrderCreated, StringComparison.Ordinal) AndAlso
               Not String.Equals(value.EventName, IntegrationEventNames.BillSettled, StringComparison.Ordinal) AndAlso
               Not String.Equals(value.EventName, IntegrationEventNames.DayClosed, StringComparison.Ordinal) Then Return
            OnlineOrderEventPublisherHost.Current.Publish(value)
        End Sub
    End Class

    Public Interface IIntegrationEventSink
        ReadOnly Property Name As String
        Sub Handle(value As PosIntegrationEvent)
    End Interface

    Public NotInheritable Class IntegrationEventHub
        Private ReadOnly _gate As New Object()
        Private ReadOnly _sinks As New List(Of IIntegrationEventSink)()

        Public Sub Register(sink As IIntegrationEventSink)
            If sink Is Nothing Then Throw New ArgumentNullException(NameOf(sink))
            SyncLock _gate
                If Not _sinks.Contains(sink) Then _sinks.Add(sink)
            End SyncLock
        End Sub

        Public Sub Unregister(sink As IIntegrationEventSink)
            If sink Is Nothing Then Return
            SyncLock _gate
                _sinks.Remove(sink)
            End SyncLock
        End Sub

        Public Function Publish(value As PosIntegrationEvent) As IntegrationEventDispatchResult
            If value Is Nothing Then Throw New ArgumentNullException(NameOf(value))
            If String.IsNullOrWhiteSpace(value.EventName) Then Throw New ArgumentException("An integration event name is required.", NameOf(value))

            Dim snapshot As IIntegrationEventSink()
            SyncLock _gate
                snapshot = _sinks.ToArray()
            End SyncLock

            Dim result As New IntegrationEventDispatchResult()
            For Each sink In snapshot
                Try
                    sink.Handle(value)
                    result.SubscribersInvoked += 1
                Catch ex As Exception
                    result.Errors.Add(New InvalidOperationException("Integration event sink failed: " & sink.Name, ex))
                End Try
            Next
            Return result
        End Function
    End Class

    Public NotInheritable Class IntegrationEventNames
        Public Const OrderCreated As String = "OrderCreated"
        Public Const BillSettled As String = "BillSettled"
        Public Const DayClosed As String = "DayClosed"

        Private Sub New()
        End Sub
    End Class

    Public NotInheritable Class IntegrationEventHost
        Private Shared ReadOnly DefaultHub As New Lazy(Of IntegrationEventHub)(AddressOf CreateDefaultHub, isThreadSafe:=True)

        Private Sub New()
        End Sub

        Public Shared ReadOnly Property Current As IntegrationEventHub
            Get
                Return DefaultHub.Value
            End Get
        End Property

        Public Shared Function PublishBillSettled(billId As Integer, billType As String) As IntegrationEventDispatchResult
            Return PublishBillSettledIfEligible(billId, billType)
        End Function

        Public Shared Function PublishBillSettledIfEligible(billId As Integer, billType As String) As IntegrationEventDispatchResult
            If billId <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(billId), "Bill ID must be greater than zero.")
            If String.IsNullOrWhiteSpace(billType) Then Throw New ArgumentException("Bill type is required.", NameOf(billType))

            Dim normalizedType = billType.Trim().ToUpperInvariant()
            Dim settlementStatus = ReadSettlementStatus(billId, normalizedType)
            If Not IsSettledStatus(normalizedType, settlementStatus) Then Return New IntegrationEventDispatchResult()

            Dim result = Current.Publish(New PosIntegrationEvent With {
                .EventName = IntegrationEventNames.BillSettled,
                .Reference = normalizedType & ":" & billId.ToString(Globalization.CultureInfo.InvariantCulture),
                .Payload = New BillSettledEventData With {.BillId = billId, .BillType = normalizedType, .SettlementStatus = settlementStatus}
            })
            If result.Errors.Count > 0 Then Throw New AggregateException("One or more BillSettled subscribers failed.", result.Errors)
            Return result
        End Function

        Public Shared Function PublishOrderCreated(orderId As Integer, orderType As String) As IntegrationEventDispatchResult
            If orderId <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(orderId), "Order ID must be greater than zero.")
            If String.IsNullOrWhiteSpace(orderType) Then Throw New ArgumentException("Order type is required.", NameOf(orderType))

            Dim normalizedType = orderType.Trim().ToUpperInvariant()
            Dim result = Current.Publish(New PosIntegrationEvent With {
                .EventName = IntegrationEventNames.OrderCreated,
                .Reference = normalizedType & ":" & orderId.ToString(Globalization.CultureInfo.InvariantCulture),
                .Payload = New OrderCreatedEventData With {.OrderId = orderId, .OrderType = normalizedType}
            })
            If result.Errors.Count > 0 Then Throw New AggregateException("One or more OrderCreated subscribers failed.", result.Errors)
            Return result
        End Function

        Public Shared Function PublishDayClosed(workPeriodId As Integer, startedAt As DateTime, endedAt As DateTime) As IntegrationEventDispatchResult
            If workPeriodId <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(workPeriodId), "Work-period ID must be greater than zero.")
            If endedAt < startedAt Then Throw New ArgumentException("Work-period end time cannot precede its start time.", NameOf(endedAt))

            Dim result = Current.Publish(New PosIntegrationEvent With {
                .EventName = IntegrationEventNames.DayClosed,
                .Reference = "WP:" & workPeriodId.ToString(Globalization.CultureInfo.InvariantCulture),
                .Payload = New DayClosedEventData With {.WorkPeriodId = workPeriodId, .StartedAt = startedAt, .EndedAt = endedAt}
            })
            If result.Errors.Count > 0 Then Throw New AggregateException("One or more DayClosed subscribers failed.", result.Errors)
            Return result
        End Function

        Private Shared Function ReadSettlementStatus(billId As Integer, billType As String) As String
            Dim tableName As String
            Dim statusColumn As String
            Select Case billType
                Case "KOT"
                    tableName = "RestaurantPOS_BillingInfoKOT"
                    statusColumn = "DIB_Status"
                Case "TA"
                    tableName = "RestaurantPOS_BillingInfoTA"
                    statusColumn = "TA_Status"
                Case "HD"
                    tableName = "RestaurantPOS_BillingInfoHD"
                    statusColumn = "HD_Status"
                Case "EB"
                    tableName = "RestaurantPOS_BillingInfoEB"
                    statusColumn = "EB_Status"
                Case Else
                    Throw New ArgumentException("Unsupported bill type: " & billType, NameOf(billType))
            End Select

            Using connection As New SqlConnection(SettingsHost.Current.Database.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("SELECT " & statusColumn & " FROM " & tableName & " WHERE ID=@id", connection)
                    command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
                    command.Parameters.AddWithValue("@id", billId)
                    Dim raw = command.ExecuteScalar()
                    If raw Is Nothing OrElse Convert.IsDBNull(raw) Then Return String.Empty
                    Return Convert.ToString(raw, Globalization.CultureInfo.InvariantCulture).Trim()
                End Using
            End Using
        End Function

        Private Shared Function IsSettledStatus(billType As String, status As String) As Boolean
            Select Case billType
                Case "KOT"
                    Return String.Equals(status, "Paid", StringComparison.OrdinalIgnoreCase)
                Case "TA", "EB"
                    Return String.Equals(status, "Paid Directly", StringComparison.OrdinalIgnoreCase) OrElse
                           String.Equals(status, "Closed", StringComparison.OrdinalIgnoreCase)
                Case "HD"
                    Return String.Equals(status, "Delivered", StringComparison.OrdinalIgnoreCase)
                Case Else
                    Return False
            End Select
        End Function

        Private Shared Function CreateDefaultHub() As IntegrationEventHub
            Dim hub As New IntegrationEventHub()
            hub.Register(New RestaurantPOS14.EInvoicing.EInvoiceBillSettledSink())
            hub.Register(New OnlineOrderIntegrationSink())
            Return hub
        End Function
    End Class

End Namespace
