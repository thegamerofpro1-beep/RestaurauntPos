Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Namespace RestaurantPOS14
    Public Class rptRPOS1
        Inherits CrystalDecisions.CrystalReports.Engine.ReportClass
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        Public Overrides Property ResourceName As String
            Get
                Return "rptRPOS1.rpt"
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
                Return "RestaurantPOS14.rptRPOS1.rpt"
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

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property ReportHeaderSection2 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(1)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property PageHeaderSection8 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(2)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property PageHeaderSection6 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(3)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property PageHeaderSection7 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(4)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property PageHeaderSection9 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(5)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property PageHeaderSection10 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(6)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property PageHeaderSection11 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(7)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property DetailSection6 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(8)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property DetailSection2 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(9)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property DetailSection3 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(10)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property DetailSection8 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(11)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property DetailSection10 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(12)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property DetailSection9 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(13)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property DetailSection4 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(14)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property DetailSection5 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(15)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property DetailSection7 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(16)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Section4 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(17)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Section5 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(18)
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

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_b5 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(2)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_b1x As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(3)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_b2x As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(4)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_b3x As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(5)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_b4x As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(6)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_T3 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(7)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_CS As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(8)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_D1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(9)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_M1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(10)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_M2 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(11)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_M3 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(12)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_M4 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(13)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_CX As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(14)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_S1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(15)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_S2 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(16)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_S3 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(17)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_S4 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(18)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_S5 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(19)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptBillingType_b4 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(20)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_rptBillingType_b3 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(21)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptBillingType_b2 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(22)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptBillingType_b1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(23)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_rptRPOS2rpt_p3 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(24)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptRPOS2rpt_p4 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(25)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptRPOS2rpt_Z3 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(26)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptRPOS2rpt_Z4 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(27)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_rptRPOS2rpt_T2 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(28)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_rptRPOS4rpt_p5 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(29)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptRPOS4rpt_p6 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(30)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptRPOS4rpt_Z1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(31)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_rptRPOS4rpt_Z2 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(32)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_rptRPOS4rpt_T1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(33)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_rptRPOS4rpt___01_G1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(34)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptRPOS4rpt___01_G2 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(35)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_rptRPOS4rpt___01_G3 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(36)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_rptRPOS4rpt___01_G4 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(37)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_rptRPOS4rpt___01_G5 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(38)
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.rptRPOS1.__ENCList
                If RestaurantPOS14.rptRPOS1.__ENCList.Count = RestaurantPOS14.rptRPOS1.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.rptRPOS1.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.rptRPOS1.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.rptRPOS1.__ENCList(num) = RestaurantPOS14.rptRPOS1.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.rptRPOS1.__ENCList.RemoveRange(num, RestaurantPOS14.rptRPOS1.__ENCList.Count - num)
                    RestaurantPOS14.rptRPOS1.__ENCList.Capacity = RestaurantPOS14.rptRPOS1.__ENCList.Count
                End If

                Call RestaurantPOS14.rptRPOS1.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub New()
            Call RestaurantPOS14.rptRPOS1.__ENCAddToList(Me)

            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing, fieldHeadingObject As CrystalDecisions.CrystalReports.Engine.FieldHeadingObject = Nothing, text2 As String = Nothing
            For Each section As CrystalDecisions.CrystalReports.Engine.Section In MyBase.ReportDefinition.Sections
                For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects

                    textObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.TextObject)
                    text = If(textObject Is Nothing, Nothing, textObject.Text)
                    If Not (textObject IsNot Nothing AndAlso text IsNot Nothing) Then
                        Continue For
                    End If

                    If Not Equals(text, Nothing) Then
                        If text.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            textObject.Text = text.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                            text = textObject.Text
                        End If

                        If text.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                            textObject.Text = text.Replace(CStr(("Service Charge % :")), CStr(("service charge"))).Replace(CStr(("Service Charge :")), CStr(("service charge"))).Replace(CStr(("Service Charge %")), CStr(("service charge"))).Replace("Service Charge", "service charge")
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
                For Each section2 As CrystalDecisions.CrystalReports.Engine.Section In MyBase.Subreports(CInt((i))).ReportDefinition.Sections
                    For Each reportObject2 As CrystalDecisions.CrystalReports.Engine.ReportObject In section2.ReportObjects

                        textObject2 = TryCast(reportObject2, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text3 = If(textObject2 Is Nothing, Nothing, textObject2.Text)
                        If Not (textObject2 IsNot Nothing AndAlso text3 IsNot Nothing) Then
                            Continue For
                        End If

                        If Not Equals(text3, Nothing) Then
                            If text3.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                                textObject2.Text = text3.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                                text3 = textObject2.Text
                            End If

                            If text3.IndexOf("Service Charge", System.StringComparison.OrdinalIgnoreCase) >= 0 AndAlso text3.IndexOf("service charge", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                                textObject2.Text = text3.Replace(CStr(("Service Charge % :")), CStr(("service charge"))).Replace(CStr(("Service Charge :")), CStr(("service charge"))).Replace(CStr(("Service Charge %")), CStr(("service charge"))).Replace("Service Charge", "service charge")
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
            Dim textObject3 As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text5 As String = Nothing

            Try
                For Each reportObject3 As CrystalDecisions.CrystalReports.Engine.ReportObject In MyBase.ReportDefinition.Sections(CInt((MyBase.ReportDefinition.Sections.Count - 1))).ReportObjects

                    textObject3 = TryCast(reportObject3, CrystalDecisions.CrystalReports.Engine.TextObject)
                    text5 = If(textObject3 Is Nothing, Nothing, textObject3.Text)
                    If textObject3 IsNot Nothing AndAlso text5 IsNot Nothing Then
                        If Not Equals(text5, Nothing) AndAlso text5.IndexOf("Developed by Hitech Computer Centre", System.StringComparison.OrdinalIgnoreCase) < 0 Then
                            textObject3.Text = (If(String.IsNullOrEmpty(text5), "", (text5 & System.Environment.NewLine))) & "Developed by Hitech Computer Centre"
                            textObject3.ObjectFormat.EnableCanGrow = True
                        End If

                        Exit For
                    End If
                Next

            Catch reportInitializationException As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Initialize rptRPOS1", reportInitializationException)
            End Try
        End Sub

    End Class
End Namespace
