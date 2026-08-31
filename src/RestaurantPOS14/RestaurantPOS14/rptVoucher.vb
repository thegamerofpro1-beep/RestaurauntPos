Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports CrystalDecisions.CrystalReports.Engine

Namespace RestaurantPOS14

    Public Class rptVoucher
        Inherits CrystalDecisions.CrystalReports.Engine.ReportClass
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        Public Overrides Property ResourceName As String
            Get
                Return "rptVoucher.rpt"
            End Get
            Set(value As String)
            End Set
        End Property

        Public Overrides Property NewGenerator As Boolean
            Get
                Return True
            End Get
            Set(value As Boolean)
            End Set
        End Property

        Public Overrides Property FullResourceName As String
            Get
                Return "RestaurantPOS14.rptVoucher.rpt"
            End Get
            Set(value As String)
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Section1 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(0)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Section2 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(1)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property GroupHeaderSection1 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(2)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Section3 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(3)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property GroupFooterSection1 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(4)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Section4 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(5)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Section5 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(6)
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.rptVoucher.__ENCList
                If RestaurantPOS14.rptVoucher.__ENCList.Count = RestaurantPOS14.rptVoucher.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.rptVoucher.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If
                        If RestaurantPOS14.rptVoucher.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.rptVoucher.__ENCList(num) = RestaurantPOS14.rptVoucher.__ENCList(num3)
                            End If
                            num += 1
                        End If
                        num3 += 1
                    End While
                    Call RestaurantPOS14.rptVoucher.__ENCList.RemoveRange(num, RestaurantPOS14.rptVoucher.__ENCList.Count - num)
                    RestaurantPOS14.rptVoucher.__ENCList.Capacity = RestaurantPOS14.rptVoucher.__ENCList.Count
                End If
                Call RestaurantPOS14.rptVoucher.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub New()
            Call RestaurantPOS14.rptVoucher.__ENCAddToList(Me)
        End Sub
    End Class
End Namespace
