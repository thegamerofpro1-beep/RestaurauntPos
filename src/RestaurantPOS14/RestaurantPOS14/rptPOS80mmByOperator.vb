Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Namespace RestaurantPOS14
    Public Class rptPOS80mmByOperator
        Inherits CrystalDecisions.CrystalReports.Engine.ReportClass
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        Public Overrides Property ResourceName As String
            Get
                Return "rptPOS80mmByOperator.rpt"
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
                Return "RestaurantPOS14.rptPOS80mmByOperator.rpt"
            End Get

            Set(value As String)
            End Set
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
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

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
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

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property GroupFooterSection2 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(5)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
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

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Section5 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(8)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_p1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(0)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_p2 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(1)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_p3 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(2)
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.rptPOS80mmByOperator.__ENCList
                If RestaurantPOS14.rptPOS80mmByOperator.__ENCList.Count = RestaurantPOS14.rptPOS80mmByOperator.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.rptPOS80mmByOperator.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.rptPOS80mmByOperator.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.rptPOS80mmByOperator.__ENCList(num) = RestaurantPOS14.rptPOS80mmByOperator.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.rptPOS80mmByOperator.__ENCList.RemoveRange(num, RestaurantPOS14.rptPOS80mmByOperator.__ENCList.Count - num)
                    RestaurantPOS14.rptPOS80mmByOperator.__ENCList.Capacity = RestaurantPOS14.rptPOS80mmByOperator.__ENCList.Count
                End If

                Call RestaurantPOS14.rptPOS80mmByOperator.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub New()
            Call RestaurantPOS14.rptPOS80mmByOperator.__ENCAddToList(Me)

            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing, fieldHeadingObject As CrystalDecisions.CrystalReports.Engine.FieldHeadingObject = Nothing, text3 As String = Nothing
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
                            textObject.Text = System.Text.RegularExpressions.Regex.Replace(text, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                            If textObject.Text.Equals(text, System.StringComparison.Ordinal) Then
                                textObject.Text = "service charge"
                            End If

                            Dim text2 As String = textObject.Text
                        End If
                    End If

                    fieldHeadingObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.FieldHeadingObject)
                    text3 = If(fieldHeadingObject Is Nothing, Nothing, fieldHeadingObject.Text)
                    If Not (fieldHeadingObject IsNot Nothing AndAlso text3 IsNot Nothing) Then
                        Continue For
                    End If

                    If text3.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                        fieldHeadingObject.Text = text3.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                        text3 = fieldHeadingObject.Text
                    End If

                    If text3.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text3.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                        fieldHeadingObject.Text = System.Text.RegularExpressions.Regex.Replace(text3, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                        If fieldHeadingObject.Text.Equals(text3, System.StringComparison.Ordinal) Then
                            fieldHeadingObject.Text = "service charge"
                        End If
                    End If
                Next
            Next

            Dim textObject2 As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text4 As String = Nothing, fieldHeadingObject2 As CrystalDecisions.CrystalReports.Engine.FieldHeadingObject = Nothing, text6 As String = Nothing

            For i As Integer = 0 To MyBase.Subreports.Count - 1
                For Each section2 As CrystalDecisions.CrystalReports.Engine.Section In MyBase.Subreports(CInt((i))).ReportDefinition.Sections
                    For Each reportObject2 As CrystalDecisions.CrystalReports.Engine.ReportObject In section2.ReportObjects

                        textObject2 = TryCast(reportObject2, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text4 = If(textObject2 Is Nothing, Nothing, textObject2.Text)
                        If textObject2 IsNot Nothing AndAlso text4 IsNot Nothing Then
                            If text4.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                                textObject2.Text = text4.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                                text4 = textObject2.Text
                            End If

                            If text4.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text4.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                                textObject2.Text = System.Text.RegularExpressions.Regex.Replace(text4, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                                If textObject2.Text.Equals(text4, System.StringComparison.Ordinal) Then
                                    textObject2.Text = "service charge"
                                End If

                                Dim text5 As String = textObject2.Text
                            End If
                        End If

                        fieldHeadingObject2 = TryCast(reportObject2, CrystalDecisions.CrystalReports.Engine.FieldHeadingObject)
                        text6 = If(fieldHeadingObject2 Is Nothing, Nothing, fieldHeadingObject2.Text)
                        If Not (fieldHeadingObject2 IsNot Nothing AndAlso text6 IsNot Nothing) Then
                            Continue For
                        End If

                        If text6.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            fieldHeadingObject2.Text = text6.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                            text6 = fieldHeadingObject2.Text
                        End If

                        If text6.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text6.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                            fieldHeadingObject2.Text = System.Text.RegularExpressions.Regex.Replace(text6, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                            If fieldHeadingObject2.Text.Equals(text6, System.StringComparison.Ordinal) Then
                                fieldHeadingObject2.Text = "service charge"
                            End If
                        End If
                    Next
                Next
            Next
        End Sub

    End Class
End Namespace
