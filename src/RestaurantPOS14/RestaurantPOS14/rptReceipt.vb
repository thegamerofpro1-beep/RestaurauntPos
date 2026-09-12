Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Namespace RestaurantPOS14
    Public Class rptReceipt
        Inherits CrystalDecisions.CrystalReports.Engine.ReportClass
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        Public Overrides Property ResourceName As String
            Get
                Return "rptReceipt.rpt"
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
                Return "RestaurantPOS14.rptReceipt.rpt"
            End Get

            Set(value As String)
            End Set
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property ReportHeaderSection2 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(0)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Section1 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(1)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property ReportHeaderSection3 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(2)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property ReportHeaderSection4 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(3)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property ReportHeaderSection5 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(4)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Section2 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(5)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Section3 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(6)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.rptReceipt.__ENCList
                If RestaurantPOS14.rptReceipt.__ENCList.Count = RestaurantPOS14.rptReceipt.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.rptReceipt.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.rptReceipt.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.rptReceipt.__ENCList(num) = RestaurantPOS14.rptReceipt.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.rptReceipt.__ENCList.RemoveRange(num, RestaurantPOS14.rptReceipt.__ENCList.Count - num)
                    RestaurantPOS14.rptReceipt.__ENCList.Capacity = RestaurantPOS14.rptReceipt.__ENCList.Count
                End If

                Call RestaurantPOS14.rptReceipt.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub New()
            Call RestaurantPOS14.rptReceipt.__ENCAddToList(Me)

            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing, fieldHeadingObject As CrystalDecisions.CrystalReports.Engine.FieldHeadingObject = Nothing, text2 As String = Nothing
            For Each section2 As CrystalDecisions.CrystalReports.Engine.Section In MyBase.ReportDefinition.Sections
                For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section2.ReportObjects

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

                            text = textObject.Text
                        End If

                        If (text.IndexOf("visit", System.StringComparison.OrdinalIgnoreCase) >= 0 OrElse text.IndexOf("thank", System.StringComparison.OrdinalIgnoreCase) >= 0) AndAlso text.IndexOf("Developed by Hitech Computer Centre", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                            textObject.Text = text & System.Environment.NewLine & "Developed by Hitech Computer Centre"
                            textObject.ObjectFormat.EnableCanGrow = True
                        End If
                    End If

                    fieldHeadingObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.FieldHeadingObject)
                    text2 = If(fieldHeadingObject Is Nothing, Nothing, fieldHeadingObject.Text)
                    If Not (fieldHeadingObject IsNot Nothing AndAlso text2 IsNot Nothing) Then
                        Continue For
                    End If

                    If text2.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                        fieldHeadingObject.Text = text2.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                        text2 = fieldHeadingObject.Text
                    End If

                    If text2.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text2.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                        fieldHeadingObject.Text = System.Text.RegularExpressions.Regex.Replace(text2, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                        If fieldHeadingObject.Text.Equals(text2, System.StringComparison.Ordinal) Then
                            fieldHeadingObject.Text = "service charge"
                        End If
                    End If
                Next
            Next

            Dim textObject2 As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text3 As String = Nothing, fieldHeadingObject2 As CrystalDecisions.CrystalReports.Engine.FieldHeadingObject = Nothing, text4 As String = Nothing

            For i As Integer = 0 To MyBase.Subreports.Count - 1
                For Each section3 As CrystalDecisions.CrystalReports.Engine.Section In MyBase.Subreports(CInt((i))).ReportDefinition.Sections
                    For Each reportObject2 As CrystalDecisions.CrystalReports.Engine.ReportObject In section3.ReportObjects

                        textObject2 = TryCast(reportObject2, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text3 = If(textObject2 Is Nothing, Nothing, textObject2.Text)
                        If textObject2 IsNot Nothing AndAlso text3 IsNot Nothing Then
                            If text3.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                                textObject2.Text = text3.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                                text3 = textObject2.Text
                            End If

                            If text3.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text3.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                                textObject2.Text = System.Text.RegularExpressions.Regex.Replace(text3, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                                If textObject2.Text.Equals(text3, System.StringComparison.Ordinal) Then
                                    textObject2.Text = "service charge"
                                End If

                                text3 = textObject2.Text
                            End If

                            If (text3.IndexOf("visit", System.StringComparison.OrdinalIgnoreCase) >= 0 OrElse text3.IndexOf("thank", System.StringComparison.OrdinalIgnoreCase) >= 0) AndAlso text3.IndexOf("Developed by Hitech Computer Centre", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                                textObject2.Text = text3 & System.Environment.NewLine & "Developed by Hitech Computer Centre"
                                textObject2.ObjectFormat.EnableCanGrow = True
                            End If
                        End If

                        fieldHeadingObject2 = TryCast(reportObject2, CrystalDecisions.CrystalReports.Engine.FieldHeadingObject)
                        text4 = If(fieldHeadingObject2 Is Nothing, Nothing, fieldHeadingObject2.Text)
                        If Not (fieldHeadingObject2 IsNot Nothing AndAlso text4 IsNot Nothing) Then
                            Continue For
                        End If

                        If text4.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            fieldHeadingObject2.Text = text4.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                            text4 = fieldHeadingObject2.Text
                        End If

                        If text4.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text4.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                            fieldHeadingObject2.Text = System.Text.RegularExpressions.Regex.Replace(text4, "(?i)service\s*charge(\s*%)?\s*:", "service charge")
                            If fieldHeadingObject2.Text.Equals(text4, System.StringComparison.Ordinal) Then
                                fieldHeadingObject2.Text = "service charge"
                            End If
                        End If
                    Next
                Next
            Next
            Dim textObject4 As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing

            Try
                Dim section As CrystalDecisions.CrystalReports.Engine.Section = MyBase.ReportDefinition.Sections(MyBase.ReportDefinition.Sections.Count - 1)
                Dim textObject3 As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing
                For Each reportObject3 As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects

                    textObject4 = TryCast(reportObject3, CrystalDecisions.CrystalReports.Engine.TextObject)
                    If textObject4 IsNot Nothing Then
                        textObject3 = textObject4
                    End If
                Next

                If textObject3 Is Nothing Then
                    Return
                End If

                Dim text5 As String = textObject3.Text
                If Not Equals(text5, Nothing) AndAlso text5.IndexOf("Developed by Hitech Computer Centre", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                    textObject3.Text = (If(String.IsNullOrEmpty(text5), "", (text5 & System.Environment.NewLine))) & "Developed by Hitech Computer Centre"
                    textObject3.ObjectFormat.EnableCanGrow = True
                    Try
                        System.Math.Max(6.0, CDbl(textObject3.Font.Size) * 0.85)
                        Return
                    Catch
                        Return
                    End Try
                End If

            Catch reportInitializationException As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Initialize rptReceipt", reportInitializationException)
            End Try
        End Sub

    End Class
End Namespace
