Imports System

Namespace RestaurantPOS14.EInvoicing

    Public Class QueueItem
        Public Property QueueId As Integer

        Public Property BillId As Integer

        Public Property BillType As String

        Public Property Payload As String

        Public Property Status As String

        Public Property AttemptCount As Integer

        Public Property NextAttemptAt As System.DateTime?

        Public Property SubmissionId As String

        Public Property UIN As String

        Public Property QRUrl As String
    End Class
End Namespace
