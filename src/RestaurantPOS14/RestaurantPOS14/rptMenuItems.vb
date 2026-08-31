Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports CrystalDecisions.CrystalReports.Engine

Namespace RestaurantPOS14
    Public Class rptMenuItems
        Inherits CrystalDecisions.CrystalReports.Engine.ReportClass
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        Public Overrides Property ResourceName As String
            Get
                Return "rptMenuItems.rpt"
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
                Return "RestaurantPOS14.rptMenuItems.rpt"
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

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Section2 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(1)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property GroupHeaderSection1 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(2)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property GroupHeaderSection2 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(3)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Section3 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(4)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property GroupFooterSection2 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(5)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property GroupFooterSection1 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(6)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Section4 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(7)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Section5 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(8)
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.rptMenuItems.__ENCList
                If RestaurantPOS14.rptMenuItems.__ENCList.Count = RestaurantPOS14.rptMenuItems.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.rptMenuItems.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.rptMenuItems.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.rptMenuItems.__ENCList(num) = RestaurantPOS14.rptMenuItems.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.rptMenuItems.__ENCList.RemoveRange(num, RestaurantPOS14.rptMenuItems.__ENCList.Count - num)
                    RestaurantPOS14.rptMenuItems.__ENCList.Capacity = RestaurantPOS14.rptMenuItems.__ENCList.Count
                End If

                Call RestaurantPOS14.rptMenuItems.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub New()
            Call RestaurantPOS14.rptMenuItems.__ENCAddToList(Me)
            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing
            For Each section As CrystalDecisions.CrystalReports.Engine.Section In MyBase.ReportDefinition.Sections
                For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects

                    textObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.TextObject)
                    text = If(textObject Is Nothing, Nothing, textObject.Text)
                    If textObject IsNot Nothing AndAlso text IsNot Nothing AndAlso text.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                        textObject.Text = text.Replace(CStr(("VAT%")), CStr(("service charge%"))).Replace(CStr(("VAT Amt")), CStr(("service chargeAmt"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                    End If
                Next
            Next
            Dim textObject2 As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text2 As String = Nothing

            For i As Integer = 0 To MyBase.Subreports.Count - 1
                For Each section2 As CrystalDecisions.CrystalReports.Engine.Section In MyBase.Subreports(CInt((i))).ReportDefinition.Sections
                    For Each reportObject2 As CrystalDecisions.CrystalReports.Engine.ReportObject In section2.ReportObjects

                        textObject2 = TryCast(reportObject2, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text2 = If(textObject2 Is Nothing, Nothing, textObject2.Text)
                        If textObject2 IsNot Nothing AndAlso text2 IsNot Nothing AndAlso text2.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            textObject2.Text = text2.Replace(CStr(("VAT%")), CStr(("service charge%"))).Replace(CStr(("VAT Amt")), CStr(("service chargeAmt"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                        End If
                    Next
                Next
            Next
        End Sub

    End Class
End Namespace
