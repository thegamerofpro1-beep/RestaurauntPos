Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace RestaurantPOS14

    Public Class MyButton
        Inherits System.Windows.Forms.Button
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.MyButton.__ENCList
                If RestaurantPOS14.MyButton.__ENCList.Count = RestaurantPOS14.MyButton.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.MyButton.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If
                        If RestaurantPOS14.MyButton.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.MyButton.__ENCList(num) = RestaurantPOS14.MyButton.__ENCList(num3)
                            End If
                            num += 1
                        End If
                        num3 += 1
                    End While
                    Call RestaurantPOS14.MyButton.__ENCList.RemoveRange(num, RestaurantPOS14.MyButton.__ENCList.Count - num)
                    RestaurantPOS14.MyButton.__ENCList.Capacity = RestaurantPOS14.MyButton.__ENCList.Count
                End If
                Call RestaurantPOS14.MyButton.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub New()
            Call RestaurantPOS14.MyButton.__ENCAddToList(Me)
            MyBase.SetStyle(System.Windows.Forms.ControlStyles.StandardDoubleClick, value:=True)
            MyBase.SetStyle(System.Windows.Forms.ControlStyles.StandardClick, value:=True)
        End Sub
    End Class
End Namespace
