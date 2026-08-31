Imports System
Imports System.Data.SqlClient
Imports System.Threading.Tasks

Namespace RestaurantPOS14.EInvoicing
    Public Class EInvoiceQueue
        Private ReadOnly cs As String
        Public Sub New(connectionString As String)
            Me.cs = connectionString
        End Sub

        Public Sub Enqueue(billId As Integer, billType As String)
            If billId <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(billId), "Bill ID must be greater than zero.")
            If String.IsNullOrWhiteSpace(billType) Then Throw New ArgumentException("Bill type is required.", NameOf(billType))

            Using con As New SqlConnection(Me.cs)
                con.Open()
                Using cmd As New SqlCommand("IF NOT EXISTS (SELECT 1 FROM [dbo].[EInvoiceQueue] WITH (UPDLOCK,HOLDLOCK) WHERE BillId=@id AND UPPER(RTRIM(BillType))=UPPER(@type)) INSERT INTO [dbo].[EInvoiceQueue](BillId,BillType,Status) VALUES (@id,@type,'Pending')", con)
                    cmd.Parameters.AddWithValue("@id", billId)
                    cmd.Parameters.AddWithValue("@type", billType.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Public Async Function DequeueAsync() As System.Threading.Tasks.Task(Of RestaurantPOS14.EInvoicing.QueueItem)
            Using con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(Me.cs)
                Await con.OpenAsync()
                Using cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 QueueId,BillId,BillType,Payload,Status,AttemptCount,NextAttemptAt,SubmissionId,UIN,QRUrl FROM EInvoiceQueue WITH (ROWLOCK, READPAST) WHERE Status='Pending' AND (NextAttemptAt IS NULL OR NextAttemptAt<=GETDATE()) ORDER BY QueueId", con)
                    Using r As System.Data.SqlClient.SqlDataReader = Await cmd.ExecuteReaderAsync()
                        If Not r.Read() Then
                            Return Nothing
                        End If

                        Return New RestaurantPOS14.EInvoicing.QueueItem With {
        .QueueId = r.GetInt32(0),
        .BillId = r.GetInt32(1),
        .BillType = r.GetString(2),
        .Payload = (If(r.IsDBNull(3), Nothing, r.GetString(3))),
        .Status = r.GetString(4),
        .AttemptCount = r.GetInt32(5),
        .NextAttemptAt = (If(r.IsDBNull(6), CType(Nothing, System.DateTime?), New System.DateTime?(r.GetDateTime(6)))),
        .SubmissionId = (If(r.IsDBNull(7), Nothing, r.GetString(7))),
        .UIN = (If(r.IsDBNull(8), Nothing, r.GetString(8))),
        .QRUrl = (If(r.IsDBNull(9), Nothing, r.GetString(9)))
    }
                    End Using
                End Using
            End Using
        End Function

        Public Async Function MarkSubmittedAsync(queueId As Integer, submissionId As String, uin As String, qrUrl As String) As System.Threading.Tasks.Task
            Using con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(Me.cs)
                Await con.OpenAsync()
                Using cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("UPDATE EInvoiceQueue SET Status='Submitted', SubmissionId=@s, UIN=@u, QRUrl=@q, AttemptCount=AttemptCount+1 WHERE QueueId=@id", con)
                    cmd.Parameters.AddWithValue("@s", If((CObj(submissionId)), (CObj(System.DBNull.Value))))
                    cmd.Parameters.AddWithValue("@u", If((CObj(uin)), (CObj(System.DBNull.Value))))
                    cmd.Parameters.AddWithValue("@q", If((CObj(qrUrl)), (CObj(System.DBNull.Value))))
                    cmd.Parameters.AddWithValue("@id", queueId)
                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
        End Function

        Public Async Function MarkValidatedAsync(queueId As Integer) As System.Threading.Tasks.Task
            Using con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(Me.cs)
                Await con.OpenAsync()
                Using cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("UPDATE EInvoiceQueue SET Status='Validated' WHERE QueueId=@id", con)
                    cmd.Parameters.AddWithValue("@id", queueId)
                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
        End Function

        Public Async Function MarkErrorAsync(queueId As Integer, [error] As String, secondsBackoff As Integer) As System.Threading.Tasks.Task
            Using con As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(Me.cs)
                Await con.OpenAsync()
                Using cmd As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("UPDATE EInvoiceQueue SET Status='Pending', LastError=@e, AttemptCount=AttemptCount+1, NextAttemptAt=DATEADD(second,@b,GETDATE()) WHERE QueueId=@id", con)
                    cmd.Parameters.AddWithValue("@e", If((CObj([error])), (CObj(System.DBNull.Value))))
                    cmd.Parameters.AddWithValue("@b", secondsBackoff)
                    cmd.Parameters.AddWithValue("@id", queueId)
                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
        End Function
    End Class
End Namespace
