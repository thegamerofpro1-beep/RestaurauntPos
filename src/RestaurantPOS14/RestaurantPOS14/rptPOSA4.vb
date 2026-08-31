Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Namespace RestaurantPOS14
    Public Class rptPOSA4
        Inherits CrystalDecisions.CrystalReports.Engine.ReportClass
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        Public Overrides Property ResourceName As String
            Get
                Return "rptPOSA4.rpt"
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
                Return "RestaurantPOS14.rptPOSA4.rpt"
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
        Public ReadOnly Property Section3 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(2)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Section4 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(3)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Section5 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(4)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_p1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(0)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_p2 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(1)
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.rptPOSA4.__ENCList
                If RestaurantPOS14.rptPOSA4.__ENCList.Count = RestaurantPOS14.rptPOSA4.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.rptPOSA4.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.rptPOSA4.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.rptPOSA4.__ENCList(num) = RestaurantPOS14.rptPOSA4.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.rptPOSA4.__ENCList.RemoveRange(num, RestaurantPOS14.rptPOSA4.__ENCList.Count - num)
                    RestaurantPOS14.rptPOSA4.__ENCList.Capacity = RestaurantPOS14.rptPOSA4.__ENCList.Count
                End If

                Call RestaurantPOS14.rptPOSA4.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub New()
            Call RestaurantPOS14.rptPOSA4.__ENCAddToList(Me)
            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing
            For Each section As CrystalDecisions.CrystalReports.Engine.Section In MyBase.ReportDefinition.Sections
                For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects

                    textObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.TextObject)
                    text = If(textObject Is Nothing, Nothing, textObject.Text)
                    If textObject IsNot Nothing AndAlso text IsNot Nothing Then
                        If text.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            textObject.Text = text.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                            text = textObject.Text
                        End If

                        If text.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                            textObject.Text = text.Replace(CStr(("Service Charge % :")), CStr(("service charge"))).Replace(CStr(("Service Charge :")), CStr(("service charge"))).Replace(CStr(("Service Charge %")), CStr(("service charge"))).Replace("Service Charge", "service charge")
                            Dim text2 As String = textObject.Text
                        End If
                    End If
                Next
            Next
            Dim textObject2 As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text3 As String = Nothing

            For i As Integer = 0 To MyBase.Subreports.Count - 1
                For Each section2 As CrystalDecisions.CrystalReports.Engine.Section In MyBase.Subreports(CInt((i))).ReportDefinition.Sections
                    For Each reportObject2 As CrystalDecisions.CrystalReports.Engine.ReportObject In section2.ReportObjects

                        textObject2 = TryCast(reportObject2, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text3 = If(textObject2 Is Nothing, Nothing, textObject2.Text)
                        If textObject2 IsNot Nothing AndAlso text3 IsNot Nothing Then
                            If text3.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                                textObject2.Text = text3.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                                text3 = textObject2.Text
                            End If

                            If text3.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text3.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                                textObject2.Text = text3.Replace(CStr(("Service Charge % :")), CStr(("service charge"))).Replace(CStr(("Service Charge :")), CStr(("service charge"))).Replace(CStr(("Service Charge %")), CStr(("service charge"))).Replace("Service Charge", "service charge")
                                Dim text4 As String = textObject2.Text
                            End If
                        End If
                    Next
                Next
            Next
        End Sub

    End Class
End Namespace
