Imports System
Imports System.Data.SqlClient

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class SecondaryDisplayOptions
        Private Shared ReadOnly SyncRoot As New Object()
        Private Shared _isLoaded As Boolean
        Private Shared _showSstColumn As Boolean = True

        Private Sub New()
        End Sub

        Public Shared ReadOnly Property ShowSstColumn As Boolean
            Get
                SyncLock SyncRoot
                    If _isLoaded Then Return _showSstColumn
                End SyncLock

                Refresh()
                SyncLock SyncRoot
                    Return _showSstColumn
                End SyncLock
            End Get
        End Property

        Public Shared Sub Refresh()
            Dim showColumn As Boolean = True
            Try
                Using connection As New SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    connection.Open()
                    Using command As New SqlCommand("SELECT TOP (1) RTRIM(ISNULL([ShowSSTOnSecondaryDisplay], N'Yes')) FROM [dbo].[OtherSetting] ORDER BY [ID]", connection)
                        Dim value As Object = command.ExecuteScalar()
                        If value IsNot Nothing AndAlso Not Convert.IsDBNull(value) Then
                            showColumn = Not String.Equals(Convert.ToString(value).Trim(), "No", StringComparison.OrdinalIgnoreCase)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                showColumn = True
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Load secondary-display SST column setting", ex)
            End Try

            SetShowSstColumn(showColumn)
        End Sub

        Public Shared Sub SetShowSstColumn(value As Boolean)
            SyncLock SyncRoot
                _showSstColumn = value
                _isLoaded = True
            End SyncLock
        End Sub
    End Class

End Namespace
