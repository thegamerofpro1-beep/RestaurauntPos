Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Namespace RestaurantPOS14

    Public Class rptLoyaltyCardMemberLedger
        Inherits CrystalDecisions.CrystalReports.Engine.ReportClass

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        Public Overrides Property ResourceName As String
            Get
                Return "rptLoyaltyCardMemberLedger.rpt"
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
                Return "RestaurantPOS14.rptLoyaltyCardMemberLedger.rpt"
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
        Public ReadOnly Property Section3 As CrystalDecisions.CrystalReports.Engine.Section
            Get
                Return MyBase.ReportDefinition.Sections(2)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
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

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_p2 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(0)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_p1 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(1)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_P7 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(2)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_P6 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(3)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_P5 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(4)
            End Get
        End Property

        <System.ComponentModel.BrowsableAttribute(False)>
        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        Public ReadOnly Property Parameter_P4 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(5)
            End Get
        End Property

        <System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)>
        <System.ComponentModel.BrowsableAttribute(False)>
        Public ReadOnly Property Parameter_P3 As CrystalDecisions.[Shared].IParameterField
            Get
                Return MyBase.DataDefinition.ParameterFields(6)
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList
                If RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList.Count = RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList(num) = RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList.RemoveRange(num, RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList.Count - num)
                    RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList.Capacity = RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList.Count
                End If

                Call RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub New()
            Call RestaurantPOS14.rptLoyaltyCardMemberLedger.__ENCAddToList(Me)
        End Sub
    End Class
End Namespace
