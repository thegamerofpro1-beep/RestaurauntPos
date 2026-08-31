Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared

Namespace RestaurantPOS14

    <System.Drawing.ToolboxBitmapAttribute(GetType(CrystalDecisions.[Shared].ExportOptions), "report.bmp")>
    Public Class CachedrptPOSA4
        Inherits System.ComponentModel.Component
        Implements CrystalDecisions.ReportSource.ICachedReport

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public Overridable Property IsCacheable As Boolean Implements Global.CrystalDecisions.ReportSource.ICachedReport.IsCacheable
            Get
                Return True
            End Get

            Set(value As Boolean)
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public Overridable Property ShareDBLogonInfo As Boolean Implements Global.CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
            Get
                Return False
            End Get

            Set(value As Boolean)
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public Overridable Property CacheTimeOut As System.TimeSpan Implements Global.CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
            Get
                Return CrystalDecisions.ReportSource.CachedReportConstants.DEFAULT_TIMEOUT
            End Get

            Set(value As System.TimeSpan)
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.CachedrptPOSA4.__ENCList
                If RestaurantPOS14.CachedrptPOSA4.__ENCList.Count = RestaurantPOS14.CachedrptPOSA4.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.CachedrptPOSA4.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.CachedrptPOSA4.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.CachedrptPOSA4.__ENCList(num) = RestaurantPOS14.CachedrptPOSA4.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.CachedrptPOSA4.__ENCList.RemoveRange(num, RestaurantPOS14.CachedrptPOSA4.__ENCList.Count - num)
                    RestaurantPOS14.CachedrptPOSA4.__ENCList.Capacity = RestaurantPOS14.CachedrptPOSA4.__ENCList.Count
                End If

                Call RestaurantPOS14.CachedrptPOSA4.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub New()
            Call RestaurantPOS14.CachedrptPOSA4.__ENCAddToList(Me)
        End Sub

        Public Overridable Function CreateReport() As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Return New RestaurantPOS14.rptPOSA4 With {.Site = MyBase.Site}
        End Function

        Private Function CreateReport1() As CrystalDecisions.CrystalReports.Engine.ReportDocument Implements Global.CrystalDecisions.ReportSource.ICachedReport.CreateReport
            Return Me.CreateReport()
        End Function

        Public Overridable Function GetCustomizedCacheKey(request As CrystalDecisions.[Shared].RequestContext) As String
            Return Nothing
        End Function

        Private Function GetCustomizedCacheKey1(request As CrystalDecisions.[Shared].RequestContext) As String Implements Global.CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
            Return Me.GetCustomizedCacheKey(request)
        End Function
    End Class
End Namespace
