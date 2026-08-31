Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmPOSReport
        Inherits System.Windows.Forms.Form
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel5")>
        Private _Panel5 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("CButton3")>
        Private _CButton3 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("CButton2")>
        Private _CButton2 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("CButton5")>
        Private _CButton5 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("CButton1")>
        Private _CButton1 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker2")>
        Private _DateTimePicker2 As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker3")>
        Private _DateTimePicker3 As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker1")>
        Private _DateTimePicker1 As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button5")>
        Private _Button5 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("CButton4")>
        Private _CButton4 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateTo")>
        Private _dtpDateTo As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateFrom")>
        Private _dtpDateFrom As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbKitchen")>
        Private _cmbKitchen As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnViewReportDeletedInvoicesItemwise")>
        Private _btnViewReportDeletedInvoicesItemwise As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCanceledKOTs")>
        Private _btnCanceledKOTs As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnViewReportDeletedInvoices")>
        Private _btnViewReportDeletedInvoices As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbWaiterName")>
        Private _cmbWaiterName As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbOperatorID")>
        Private _cmbOperatorID As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button4")>
        Private _Button4 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button3")>
        Private _Button3 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button2")>
        Private _Button2 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnViewReport")>
        Private _btnViewReport As CButtonLib.CButton

        Private a As Double

        Private b As Double

        Private b1 As Double

        Private b2 As Double

        Private b3 As Double

        Private b4 As Double

        Private b5 As Double

        Private Z1 As Double

        Private Z2 As Double

        Private G1 As Double

        Private G2 As Double

        Private G3 As Double

        Private G4 As Double

        Private G5 As Double

        Private T1 As Double

        Private D1 As Double

        Private M3 As Double

        Private M4 As Double

        Private CX As Double

        Private S1 As Double

        Private S2 As Double

        Private S3 As Double

        Private S4 As Double

        Private S5 As Double

        Private M1 As Integer

        Private M2 As Integer

        Private TC As Integer

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property Panel1 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel1
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel1 = value
            End Set
        End Property

        Friend Overridable Property Panel2 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel2
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel2 = value
            End Set
        End Property

        Friend Overridable Property Label1 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label1
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label1 = value
            End Set
        End Property

        Friend Overridable Property btnReset As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnReset
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnReset_Click
                If Me._btnReset IsNot Nothing Then
                    RemoveHandler Me._btnReset.Click, value2
                End If
                Me._btnReset = value
                If Me._btnReset IsNot Nothing Then
                    AddHandler Me._btnReset.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Timer1 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer1
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer1_Tick
                If Me._Timer1 IsNot Nothing Then
                    RemoveHandler Me._Timer1.Tick, value2
                End If
                Me._Timer1 = value
                If Me._Timer1 IsNot Nothing Then
                    AddHandler Me._Timer1.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnClose As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClose
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnClose_Click
                If Me._btnClose IsNot Nothing Then
                    RemoveHandler Me._btnClose.Click, value2
                End If
                Me._btnClose = value
                If Me._btnClose IsNot Nothing Then
                    AddHandler Me._btnClose.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Panel5 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel5
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel5 = value
            End Set
        End Property

        Friend Overridable Property CButton3 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._CButton3
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.CButton3_ClickButtonArea
                If Me._CButton3 IsNot Nothing Then
                    RemoveHandler Me._CButton3.ClickButtonArea, obj
                End If
                Me._CButton3 = value
                If Me._CButton3 IsNot Nothing Then
                    AddHandler Me._CButton3.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property CButton2 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._CButton2
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.CButton2_ClickButtonArea
                If Me._CButton2 IsNot Nothing Then
                    RemoveHandler Me._CButton2.ClickButtonArea, obj
                End If
                Me._CButton2 = value
                If Me._CButton2 IsNot Nothing Then
                    AddHandler Me._CButton2.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox3 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox3
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox3 = value
            End Set
        End Property

        Friend Overridable Property CButton5 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._CButton5
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.CButton5_ClickButtonArea
                If Me._CButton5 IsNot Nothing Then
                    RemoveHandler Me._CButton5.ClickButtonArea, obj
                End If
                Me._CButton5 = value
                If Me._CButton5 IsNot Nothing Then
                    AddHandler Me._CButton5.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property CButton1 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._CButton1
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.CButton1_ClickButtonArea
                If Me._CButton1 IsNot Nothing Then
                    RemoveHandler Me._CButton1.ClickButtonArea, obj
                End If
                Me._CButton1 = value
                If Me._CButton1 IsNot Nothing Then
                    AddHandler Me._CButton1.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property Label6 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label6
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label6 = value
            End Set
        End Property

        Friend Overridable Property DateTimePicker2 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker2
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker2 = value
            End Set
        End Property

        Friend Overridable Property DateTimePicker3 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker3
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker3 = value
            End Set
        End Property

        Friend Overridable Property Label8 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label8
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label8 = value
            End Set
        End Property

        Friend Overridable Property GroupBox2 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox2
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox2 = value
            End Set
        End Property

        Friend Overridable Property DateTimePicker1 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker1
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker1 = value
            End Set
        End Property

        Friend Overridable Property Button5 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button5
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Button5_Click
                If Me._Button5 IsNot Nothing Then
                    RemoveHandler Me._Button5.Click, value2
                End If
                Me._Button5 = value
                If Me._Button5 IsNot Nothing Then
                    AddHandler Me._Button5.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label7 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label7
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label7 = value
            End Set
        End Property

        Friend Overridable Property GroupBox1 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox1
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox1 = value
            End Set
        End Property

        Friend Overridable Property CButton4 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._CButton4
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim obj As CButtonLib.CButton.ClickButtonAreaEventHandler = AddressOf Me.CButton4_ClickButtonArea
                If Me._CButton4 IsNot Nothing Then
                    RemoveHandler Me._CButton4.ClickButtonArea, obj
                End If
                Me._CButton4 = value
                If Me._CButton4 IsNot Nothing Then
                    AddHandler Me._CButton4.ClickButtonArea, obj
                End If
            End Set
        End Property

        Friend Overridable Property Label4 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label4
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label4 = value
            End Set
        End Property

        Friend Overridable Property dtpDateTo As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateTo
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateTo = value
            End Set
        End Property

        Friend Overridable Property dtpDateFrom As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateFrom
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateFrom = value
            End Set
        End Property

        Friend Overridable Property Label2 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label2
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label2 = value
            End Set
        End Property

        Friend Overridable Property cmbKitchen As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbKitchen
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbKitchen_SelectedIndexChanged
                If Me._cmbKitchen IsNot Nothing Then
                    RemoveHandler Me._cmbKitchen.SelectedIndexChanged, value2
                End If
                Me._cmbKitchen = value
                If Me._cmbKitchen IsNot Nothing Then
                    AddHandler Me._cmbKitchen.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnViewReportDeletedInvoicesItemwise As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnViewReportDeletedInvoicesItemwise
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnViewReportDeletedInvoicesItemwise_Click
                If Me._btnViewReportDeletedInvoicesItemwise IsNot Nothing Then
                    RemoveHandler Me._btnViewReportDeletedInvoicesItemwise.Click, value2
                End If
                Me._btnViewReportDeletedInvoicesItemwise = value
                If Me._btnViewReportDeletedInvoicesItemwise IsNot Nothing Then
                    AddHandler Me._btnViewReportDeletedInvoicesItemwise.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCanceledKOTs As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCanceledKOTs
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnCanceledKOTs_Click
                If Me._btnCanceledKOTs IsNot Nothing Then
                    RemoveHandler Me._btnCanceledKOTs.Click, value2
                End If
                Me._btnCanceledKOTs = value
                If Me._btnCanceledKOTs IsNot Nothing Then
                    AddHandler Me._btnCanceledKOTs.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnViewReportDeletedInvoices As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnViewReportDeletedInvoices
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnViewReportDeletedInvoices_Click
                If Me._btnViewReportDeletedInvoices IsNot Nothing Then
                    RemoveHandler Me._btnViewReportDeletedInvoices.Click, value2
                End If
                Me._btnViewReportDeletedInvoices = value
                If Me._btnViewReportDeletedInvoices IsNot Nothing Then
                    AddHandler Me._btnViewReportDeletedInvoices.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label5 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label5
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label5 = value
            End Set
        End Property

        Friend Overridable Property Label3 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label3
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label3 = value
            End Set
        End Property

        Friend Overridable Property cmbWaiterName As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbWaiterName
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbWaiterName_SelectedIndexChanged
                If Me._cmbWaiterName IsNot Nothing Then
                    RemoveHandler Me._cmbWaiterName.SelectedIndexChanged, value2
                End If
                Me._cmbWaiterName = value
                If Me._cmbWaiterName IsNot Nothing Then
                    AddHandler Me._cmbWaiterName.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property cmbOperatorID As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbOperatorID
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbOperatorID = value
            End Set
        End Property

        Friend Overridable Property Button4 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button4
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Button4_Click
                If Me._Button4 IsNot Nothing Then
                    RemoveHandler Me._Button4.Click, value2
                End If
                Me._Button4 = value
                If Me._Button4 IsNot Nothing Then
                    AddHandler Me._Button4.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Button3 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button3
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Button3_Click
                If Me._Button3 IsNot Nothing Then
                    RemoveHandler Me._Button3.Click, value2
                End If
                Me._Button3 = value
                If Me._Button3 IsNot Nothing Then
                    AddHandler Me._Button3.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Button2 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button2
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Button2_Click
                If Me._Button2 IsNot Nothing Then
                    RemoveHandler Me._Button2.Click, value2
                End If
                Me._Button2 = value
                If Me._Button2 IsNot Nothing Then
                    AddHandler Me._Button2.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Button1 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, value2
                End If
                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnViewReport As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnViewReport
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnExportExcel_Click
                If Me._btnViewReport IsNot Nothing Then
                    RemoveHandler Me._btnViewReport.Click, value2
                End If
                Me._btnViewReport = value
                If Me._btnViewReport IsNot Nothing Then
                    AddHandler Me._btnViewReport.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmRPOSReport_Load
            Call RestaurantPOS14.frmPOSReport.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPOSReport.__ENCList
                If RestaurantPOS14.frmPOSReport.__ENCList.Count = RestaurantPOS14.frmPOSReport.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPOSReport.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If
                        If RestaurantPOS14.frmPOSReport.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPOSReport.__ENCList(num) = RestaurantPOS14.frmPOSReport.__ENCList(num3)
                            End If
                            num += 1
                        End If
                        num3 += 1
                    End While
                    Call RestaurantPOS14.frmPOSReport.__ENCList.RemoveRange(num, RestaurantPOS14.frmPOSReport.__ENCList.Count - num)
                    RestaurantPOS14.frmPOSReport.__ENCList.Capacity = RestaurantPOS14.frmPOSReport.__ENCList.Count
                End If
                Call RestaurantPOS14.frmPOSReport.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub cmbKitchen_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                If Me.cmbKitchen.SelectedIndex < 0 Then
                    Return
                End If
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and Category.CategoryName=RestaurantPOS_OrderedProductBillKOT.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') and Category.CategoryName=RestaurantPOS_OrderedProductBillTA.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and Category.CategoryName=RestaurantPOS_OrderedProductBillHD.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared') and Category.CategoryName=RestaurantPOS_OrderedProductBillEB.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9)G  group by Dish order by 1")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.cmbKitchen.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * from Hotel", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.cmd1 = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and Category.CategoryName=RestaurantPOS_OrderedProductBillKOT.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') and Category.CategoryName=RestaurantPOS_OrderedProductBillTA.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and Category.CategoryName=RestaurantPOS_OrderedProductBillHD.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared') and Category.CategoryName=RestaurantPOS_OrderedProductBillEB.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9)G  group by Dish order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd1.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd1.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd1.Parameters.AddWithValue("@d9", Me.cmbKitchen.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp1 = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd1)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.dtable1 = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.adp1.Fill(RestaurantPOS14.ModClasses.dtable1)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable1)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("RPOSByKitchen.xml")
                Dim rptRPOSByKitchen2 As RestaurantPOS14.rptRPOSByKitchen = New RestaurantPOS14.rptRPOSByKitchen()
                rptRPOSByKitchen2.Subreports(CInt((0))).SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptRPOSByKitchen2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptRPOSByKitchen2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptRPOSByKitchen2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptRPOSByKitchen2.SetParameterValue("T1", Me.cmbKitchen.Text)
                RestaurantPOS14.ModFunc.GetPrinterName(System.Net.Dns.GetHostName(), rptRPOSByKitchen2)
                rptRPOSByKitchen2.Close()
                rptRPOSByKitchen2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillKitchen()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(KitchenName) FROM Kitchen order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbKitchen.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbKitchen.Items.Add(dataRow(CInt((0))).ToString())
                Next
                sqlConnection.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.dtpDateFrom.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.dtpDateTo.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTimePicker1.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTimePicker3.Value = Microsoft.VisualBasic.DateAndTime.Now
            Me.DateTimePicker2.Value = Microsoft.VisualBasic.DateAndTime.Now
            Me.cmbWaiterName.SelectedIndex = -1
            Me.cmbOperatorID.SelectedIndex = -1
            Me.cmbKitchen.SelectedIndex = -1
        End Sub

        Public Sub fillWaiter()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(UserID) FROM Registration where Active='Yes' and UserType='Waiter' order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbWaiterName.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbWaiterName.Items.Add(dataRow(CInt((0))).ToString())
                Next
                sqlConnection.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillOperatorID()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(UserID) FROM Registration where Active='Yes' order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbOperatorID.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbOperatorID.Items.Add(dataRow(CInt((0))).ToString())
                Next
                sqlConnection.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing, textObject2 As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text2 As String = Nothing
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT * from Hotel", RestaurantPOS14.ModClasses.con)
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlCommand3 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Operator,Sum(GrandTotal) as [GrandTotal] from(Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select Operator,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Operator order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand3.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand3.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand3.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand3)
                Dim sqlCommand4 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(TotalAmount) as Total from (Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,(TotalAmount) as [TotalAmount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand4.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand4.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand4.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand4)
                Dim sqlCommand5 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(Quantity) as TotalQuantity from (Select category,Quantity from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d5 and BillDate < @d6 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d5 and BillDate < @d6 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d5 and BillDate < @d6 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,Quantity from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d5 and BillDate < @d6 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand5.Parameters.Add(CStr(("@d5")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand5.Parameters.Add(CStr(("@d6")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand5.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand5)
                Dim sqlCommand6 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Dish order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand6.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand6.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand6.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand6)
                Dim sqlCommand7 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT PaymentMode,IsNull(Sum(Card),0) as [Card] from (Select PaymentMode,Card as [Card] from RestaurantPOS_BillingInfoKOT where BillDate >=@d11 and BillDate < @d12 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,GrandTotal as [Card] from RestaurantPOS_BillingInfoHD where BillDate >=@d11 and BillDate < @d12 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union all Select PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoEB where BillDate >=@d11 and BillDate < @d12 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card'))G  group by PaymentMode order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand7.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand7.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand7.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand7)
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand8 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(HomeDeliveryCharges),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d9 and BillDate < @d10 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand8.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand8.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand8.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand8.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand8.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand9 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(ParcelCharges*ExchangeRate),0) from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand9.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand9.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand9.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand9.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand9.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand10 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoKOT where BillDate >=@d13 and BillDate < @d14 and DIB_Status not in ('Unpaid','Changed to Split Bill')")
                sqlCommand10.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand10.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand10.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand10.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand10.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand11 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoTA where BillDate >=@d13 and BillDate < @d14 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand11.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand11.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand11.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand11.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand11.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand12 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal),0)  from RestaurantPOS_BillingInfoHD where BillDate >=@d13 and BillDate < @d14 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand12.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand12.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand12.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand12.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand12.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand13 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoEB where BillDate >=@d13 and BillDate < @d14 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand13.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand13.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand13.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand13.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand13.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand14 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(TotalVAT) as TotalVAT,SUM(TotalDiscount) as TotalDicount from (Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand14.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand14.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand14.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand14.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand14.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.D1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand15 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(LA) as [LA] from(Select LA as [LA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select LA as [LA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select LA as [LA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select LA as [LA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand15.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand15.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand15.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand15.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand15.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand16 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(GCA) as [GCA] from(Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand16.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand16.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand16.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand16.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand16.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand17 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Cash' Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand17.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand17.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand17.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand17.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand17.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand18 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card')G")
                sqlCommand18.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand18.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand18.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand18.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand18.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand19 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Debit Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Debit Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card')G")
                sqlCommand19.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand19.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand19.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand19.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand19.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand20 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='VIP Member Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='VIP Member Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card')G")
                sqlCommand20.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand20.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand20.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand20.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand20.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand21 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(GrandTotal),0) as [GrandTotal] from(Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Customer'  Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer')G")
                sqlCommand21.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand21.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand21.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand21.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand21.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand22 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(TIP),0) as [TIP] from(Select Tip as [TIP] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') )G")
                sqlCommand22.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand22.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand22.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand22.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand22.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.T1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand23 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(NoOfPerson),0) from RestaurantPOS_OrderInfoKOT where BillDate >=@d9 and BillDate < @d10 and KOT_Status <> 'Void'")
                sqlCommand23.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand23.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand23.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand23.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand23.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.TC = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand24 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNULL(Count(Case when Canceled_Deleted ='Canceled' then 1 else NULL end),0),IsNULL(Count(Case when Canceled_Deleted ='Deleted' then 1 else NULL end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Canceled') then GrandTotal else 0 end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Deleted') then GrandTotal else 0 end),0) from DeletedInvoices where deletedDate >=@d13 and DeletedDate < @d14")
                sqlCommand24.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand24.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand24.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand24.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand24.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.M1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.M2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.M3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.M4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand25 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT iSNULL(SUM(TotalDiscount),0) as TotalDiscount from (Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand25.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand25.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand25.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand25.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand25.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.CX = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                Me.S1 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from Payment where Date >=@d1 and Date < @d2", Me.dtpDateFrom.Value.[Date], Me.dtpDateTo.Value.[Date].AddDays(1.0))
                Me.S2 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from CreditCustomerPayment where Date >=@d1 and Date < @d2", Me.dtpDateFrom.Value.[Date], Me.dtpDateTo.Value.[Date].AddDays(1.0))
                Me.S3 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from Voucher where Date >=@d1 and Date < @d2", Me.dtpDateFrom.Value.[Date], Me.dtpDateTo.Value.[Date].AddDays(1.0))
                Me.S4 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", Me.dtpDateFrom.Value.[Date], Me.dtpDateTo.Value.[Date].AddDays(1.0))
                Me.S5 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0)-IsNull(Sum(AmtReceived),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", Me.dtpDateFrom.Value.[Date], Me.dtpDateTo.Value.[Date].AddDays(1.0))
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable3 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable4 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable5 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable6 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                sqlDataAdapter3.Fill(dataTable3)
                sqlDataAdapter4.Fill(dataTable4)
                sqlDataAdapter5.Fill(dataTable5)
                sqlDataAdapter6.Fill(dataTable6)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.Tables.Add(dataTable3)
                dataSet.Tables.Add(dataTable4)
                dataSet.Tables.Add(dataTable5)
                dataSet.Tables.Add(dataTable6)
                dataSet.WriteXmlSchema("RPOSLatest.xml")
                Dim rptRPOS3 As RestaurantPOS14.rptRPOS = New RestaurantPOS14.rptRPOS()
                rptRPOS3.Subreports(CInt((0))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((1))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((2))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((3))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((4))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((5))).SetDataSource(dataSet)
                rptRPOS3.SetDataSource(dataSet)
                For Each section As CrystalDecisions.CrystalReports.Engine.Section In rptRPOS3.ReportDefinition.Sections
                    For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects
                        textObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text = If(textObject Is Nothing, Nothing, textObject.Text)
                        If textObject IsNot Nothing AndAlso text IsNot Nothing AndAlso text.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            textObject.Text = text.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                        End If
                    Next
                Next
                For i As Integer = 0 To rptRPOS3.Subreports.Count - 1
                    For Each section2 As CrystalDecisions.CrystalReports.Engine.Section In rptRPOS3.Subreports(CInt((i))).ReportDefinition.Sections
                        For Each reportObject2 As CrystalDecisions.CrystalReports.Engine.ReportObject In section2.ReportObjects
                            textObject2 = TryCast(reportObject2, CrystalDecisions.CrystalReports.Engine.TextObject)
                            text2 = If(textObject2 Is Nothing, Nothing, textObject2.Text)
                            If textObject2 IsNot Nothing AndAlso text2 IsNot Nothing AndAlso text2.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                                textObject2.Text = text2.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                            End If
                        Next
                    Next
                Next
                rptRPOS3.SetParameterValue("p1", Me.dtpDateFrom.Value.ToString("dd/MM/yyyy"))
                rptRPOS3.SetParameterValue("p2", Me.dtpDateTo.Value.ToString("dd/MM/yyyy"))
                rptRPOS3.SetParameterValue("p3", Me.a)
                rptRPOS3.SetParameterValue("p4", Me.b)
                rptRPOS3.SetParameterValue("p5", Me.a)
                rptRPOS3.SetParameterValue("p6", Me.b)
                rptRPOS3.SetParameterValue("b1", Me.b1)
                rptRPOS3.SetParameterValue("b2", Me.b2)
                rptRPOS3.SetParameterValue("b3", Me.b3)
                rptRPOS3.SetParameterValue("b4", Me.b4)
                rptRPOS3.SetParameterValue("b1x", Me.b1)
                rptRPOS3.SetParameterValue("b2x", Me.b2)
                rptRPOS3.SetParameterValue("b3x", Me.b3)
                rptRPOS3.SetParameterValue("b4x", Me.b4)
                rptRPOS3.SetParameterValue("b5", Me.b5)
                rptRPOS3.SetParameterValue("Z1", Me.Z1)
                rptRPOS3.SetParameterValue("Z2", Me.Z2)
                rptRPOS3.SetParameterValue("Z3", Me.Z1)
                rptRPOS3.SetParameterValue("Z4", Me.Z2)
                rptRPOS3.SetParameterValue("G1", Me.G1)
                rptRPOS3.SetParameterValue("G2", Me.G2)
                rptRPOS3.SetParameterValue("G3", Me.G3)
                rptRPOS3.SetParameterValue("G4", Me.G4)
                rptRPOS3.SetParameterValue("G5", Me.G5)
                rptRPOS3.SetParameterValue("T1", Me.T1)
                rptRPOS3.SetParameterValue("T2", Me.T1)
                rptRPOS3.SetParameterValue("T3", Me.T1)
                rptRPOS3.SetParameterValue("CS", Me.TC)
                rptRPOS3.SetParameterValue("D1", Me.D1)
                rptRPOS3.SetParameterValue("M1", Me.M1)
                rptRPOS3.SetParameterValue("M2", Me.M2)
                rptRPOS3.SetParameterValue("M3", Me.M3)
                rptRPOS3.SetParameterValue("M4", Me.M4)
                rptRPOS3.SetParameterValue("CX", Me.CX)
                rptRPOS3.SetParameterValue("S1", Me.S1)
                rptRPOS3.SetParameterValue("S2", Me.S2)
                rptRPOS3.SetParameterValue("S3", Me.S3)
                rptRPOS3.SetParameterValue("S4", Me.S4)
                rptRPOS3.SetParameterValue("S5", Me.S5)
                RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer.CrystalReportViewer1.ReportSource = rptRPOS3
                RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer.dtpDateFrom.Value = Me.dtpDateFrom.Value
                RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer.dtpDateTo.Value = Me.dtpDateTo.Value
                RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer.txtEmailID.Text = ""
                Call RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer.ShowDialog()
                rptRPOS3.Close()
                rptRPOS3.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill')")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptRestaurantPOS2 As RestaurantPOS14.rptRestaurantPOS = New RestaurantPOS14.rptRestaurantPOS()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT Card,GiftCardID,GiftCardAmount,LP,LA,RestaurantPOS_BillingInfoKOT.Id,PaymentMode,Operator,CurrencyCode, RestaurantPOS_BillingInfoKOT.BillNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.GrandTotal, RestaurantPOS_BillingInfoKOT.Cash, RestaurantPOS_BillingInfoKOT.Change,RestaurantPOS_OrderedProductBillKOT.OP_ID, RestaurantPOS_OrderedProductBillKOT.BillID, RestaurantPOS_OrderedProductBillKOT.Dish,RestaurantPOS_OrderedProductBillKOT.Rate, RestaurantPOS_OrderedProductBillKOT.Quantity,SCPer,SCAmount, RestaurantPOS_OrderedProductBillKOT.Amount,RestaurantPOS_OrderedProductBillKOT.VATPer, RestaurantPOS_OrderedProductBillKOT.VATAmount, RestaurantPOS_OrderedProductBillKOT.STPer, RestaurantPOS_OrderedProductBillKOT.STAmount,RestaurantPOS_OrderedProductBillKOT.DiscountPer, RestaurantPOS_OrderedProductBillKOT.DiscountAmount, RestaurantPOS_OrderedProductBillKOT.TotalAmount, RestaurantPOS_OrderedProductBillKOT.TableNo FROM RestaurantPOS_BillingInfoKOT INNER JOIN RestaurantPOS_OrderedProductBillKOT ON RestaurantPOS_BillingInfoKOT.Id = RestaurantPOS_OrderedProductBillKOT.BillID where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') order by BillDate"
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_BillingInfoKOT")
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_OrderedProductBillKOT")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End While
                RestaurantPOS14.ModClasses.con.Close()
                rptRestaurantPOS2.SetDataSource(dataSet)
                For Each section As CrystalDecisions.CrystalReports.Engine.Section In rptRestaurantPOS2.ReportDefinition.Sections
                    For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects
                        textObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text = If(textObject Is Nothing, Nothing, textObject.Text)
                        If textObject IsNot Nothing AndAlso text IsNot Nothing AndAlso text.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            textObject.Text = text.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                        End If
                    Next
                Next
                rptRestaurantPOS2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptRestaurantPOS2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptRestaurantPOS2.SetParameterValue("p3", Me.a)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptRestaurantPOS2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptRestaurantPOS2.Close()
                rptRestaurantPOS2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptRestaurantPOSTA2 As RestaurantPOS14.rptRestaurantPOSTA = New RestaurantPOS14.rptRestaurantPOSTA()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT Card,GiftCardID,GiftCardAmount,LP,LA,TA_Status,RestaurantPOS_BillingInfoTA.Id,Operator,SCPer,SCAmount,PaymentMode,ParcelCharges,SubTotal,CurrencyCode, RestaurantPOS_BillingInfoTA.BillNo, RestaurantPOS_BillingInfoTA.BillDate, RestaurantPOS_BillingInfoTA.GrandTotal, RestaurantPOS_BillingInfoTA.Cash, RestaurantPOS_BillingInfoTA.Change,RestaurantPOS_OrderedProductBillTA.OP_ID, RestaurantPOS_OrderedProductBillTA.BillID, RestaurantPOS_OrderedProductBillTA.Dish,RestaurantPOS_OrderedProductBillTA.Rate, RestaurantPOS_OrderedProductBillTA.Quantity, RestaurantPOS_OrderedProductBillTA.Amount,RestaurantPOS_OrderedProductBillTA.VATPer, RestaurantPOS_OrderedProductBillTA.VATAmount, RestaurantPOS_OrderedProductBillTA.STPer, RestaurantPOS_OrderedProductBillTA.STAmount,RestaurantPOS_OrderedProductBillTA.DiscountPer, RestaurantPOS_OrderedProductBillTA.DiscountAmount, RestaurantPOS_OrderedProductBillTA.TotalAmount FROM RestaurantPOS_BillingInfoTA INNER JOIN RestaurantPOS_OrderedProductBillTA ON RestaurantPOS_BillingInfoTA.Id = RestaurantPOS_OrderedProductBillTA.BillID where BillDate >=@d1 and BillDate < @d2 order by BillDate"
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_BillingInfoTA")
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_OrderedProductBillTA")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End While
                RestaurantPOS14.ModClasses.con.Close()
                rptRestaurantPOSTA2.SetDataSource(dataSet)
                For Each section As CrystalDecisions.CrystalReports.Engine.Section In rptRestaurantPOSTA2.ReportDefinition.Sections
                    For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects
                        textObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text = If(textObject Is Nothing, Nothing, textObject.Text)
                        If textObject IsNot Nothing AndAlso text IsNot Nothing AndAlso text.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            textObject.Text = text.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                        End If
                    Next
                Next
                rptRestaurantPOSTA2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptRestaurantPOSTA2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptRestaurantPOSTA2.SetParameterValue("p3", Me.a)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptRestaurantPOSTA2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptRestaurantPOSTA2.Close()
                rptRestaurantPOSTA2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button3_Click(sender As Object, e As System.EventArgs)
            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptRestaurantPOSHD2 As RestaurantPOS14.rptRestaurantPOSHD = New RestaurantPOS14.rptRestaurantPOSHD()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT GiftCardID,GiftCardAmount,LP,LA,HD_Status,RestaurantPOS_BillingInfoHD.Id, RestaurantPOS_BillingInfoHD.BillNo,SCPer,SCAmount, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.Operator, RestaurantPOS_BillingInfoHD.SubTotal,RestaurantPOS_BillingInfoHD.HomeDeliveryCharges, RestaurantPOS_BillingInfoHD.GrandTotal, RestaurantPOS_BillingInfoHD.CustomerName, RestaurantPOS_BillingInfoHD.Address,RestaurantPOS_BillingInfoHD.ContactNo, RestaurantPOS_BillingInfoHD.Employee_ID, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_OrderedProductBillHD.OP_ID, RestaurantPOS_OrderedProductBillHD.BillID, RestaurantPOS_OrderedProductBillHD.Dish, RestaurantPOS_OrderedProductBillHD.Rate, RestaurantPOS_OrderedProductBillHD.Quantity,RestaurantPOS_OrderedProductBillHD.Amount, RestaurantPOS_OrderedProductBillHD.VATPer, RestaurantPOS_OrderedProductBillHD.VATAmount, RestaurantPOS_OrderedProductBillHD.STPer,RestaurantPOS_OrderedProductBillHD.STAmount, RestaurantPOS_OrderedProductBillHD.DiscountPer, RestaurantPOS_OrderedProductBillHD.DiscountAmount,RestaurantPOS_OrderedProductBillHD.TotalAmount, RestaurantPOS_OrderedProductBillHD.Notes, EmployeeRegistration.EmpId, EmployeeRegistration.EmployeeID, EmployeeRegistration.EmployeeName,EmployeeRegistration.Address AS Expr1, EmployeeRegistration.City, EmployeeRegistration.ContactNo AS Expr2, EmployeeRegistration.Email, EmployeeRegistration.DateOfJoining, EmployeeRegistration.Photo,EmployeeRegistration.Active FROM RestaurantPOS_BillingInfoHD INNER JOIN RestaurantPOS_OrderedProductBillHD ON RestaurantPOS_BillingInfoHD.Id = RestaurantPOS_OrderedProductBillHD.BillID INNER JOIN EmployeeRegistration ON RestaurantPOS_BillingInfoHD.Employee_ID = EmployeeRegistration.EmpId where BillDate >=@d1 and BillDate < @d2 order by BillDate"
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_BillingInfoHD")
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_OrderedProductBillHD")
                sqlDataAdapter.Fill(dataSet, "EmployeeRegistration")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End While
                RestaurantPOS14.ModClasses.con.Close()
                rptRestaurantPOSHD2.SetDataSource(dataSet)
                For Each section As CrystalDecisions.CrystalReports.Engine.Section In rptRestaurantPOSHD2.ReportDefinition.Sections
                    For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects
                        textObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text = If(textObject Is Nothing, Nothing, textObject.Text)
                        If textObject IsNot Nothing AndAlso text IsNot Nothing AndAlso text.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            textObject.Text = text.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                        End If
                    Next
                Next
                rptRestaurantPOSHD2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptRestaurantPOSHD2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptRestaurantPOSHD2.SetParameterValue("p3", Me.a)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptRestaurantPOSHD2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptRestaurantPOSHD2.Close()
                rptRestaurantPOSHD2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button4_Click(sender As Object, e As System.EventArgs)
            Dim textObject As CrystalDecisions.CrystalReports.Engine.TextObject = Nothing, text As String = Nothing
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptRestaurantPOSEB2 As RestaurantPOS14.rptRestaurantPOSEB = New RestaurantPOS14.rptRestaurantPOSEB()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT Card,GiftCardID,GiftCardAmount,LP,LA,EB_Status,RestaurantPOS_BillingInfoEB.Id,PaymentMode,Operator,SCPer,SCAmount,CurrencyCode, RestaurantPOS_BillingInfoEB.BillNo, RestaurantPOS_BillingInfoEB.BillDate, RestaurantPOS_BillingInfoEB.GrandTotal, RestaurantPOS_BillingInfoEB.Cash, RestaurantPOS_BillingInfoEB.Change,RestaurantPOS_OrderedProductBillEB.OP_ID, RestaurantPOS_OrderedProductBillEB.BillID, RestaurantPOS_OrderedProductBillEB.Dish,RestaurantPOS_OrderedProductBillEB.Rate, RestaurantPOS_OrderedProductBillEB.Quantity, RestaurantPOS_OrderedProductBillEB.Amount,RestaurantPOS_OrderedProductBillEB.VATPer, RestaurantPOS_OrderedProductBillEB.VATAmount, RestaurantPOS_OrderedProductBillEB.STPer, RestaurantPOS_OrderedProductBillEB.STAmount,RestaurantPOS_OrderedProductBillEB.DiscountPer, RestaurantPOS_OrderedProductBillEB.DiscountAmount, RestaurantPOS_OrderedProductBillEB.TotalAmount FROM RestaurantPOS_BillingInfoEB INNER JOIN RestaurantPOS_OrderedProductBillEB ON RestaurantPOS_BillingInfoEB.Id = RestaurantPOS_OrderedProductBillEB.BillID where BillDate >=@d1 and BillDate < @d2 order by BillDate"
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_BillingInfoEB")
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_OrderedProductBillEB")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End While
                RestaurantPOS14.ModClasses.con.Close()
                rptRestaurantPOSEB2.SetDataSource(dataSet)
                For Each section As CrystalDecisions.CrystalReports.Engine.Section In rptRestaurantPOSEB2.ReportDefinition.Sections
                    For Each reportObject As CrystalDecisions.CrystalReports.Engine.ReportObject In section.ReportObjects
                        textObject = TryCast(reportObject, CrystalDecisions.CrystalReports.Engine.TextObject)
                        text = If(textObject Is Nothing, Nothing, textObject.Text)
                        If textObject IsNot Nothing AndAlso text IsNot Nothing AndAlso text.IndexOf("VAT", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                            textObject.Text = text.Replace(CStr(("VAT%")), CStr(("service charge"))).Replace(CStr(("VAT :")), CStr(("service charge"))).Replace("VAT", "service charge")
                        End If
                    Next
                Next
                rptRestaurantPOSEB2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptRestaurantPOSEB2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptRestaurantPOSEB2.SetParameterValue("p3", Me.a)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptRestaurantPOSEB2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptRestaurantPOSEB2.Close()
                rptRestaurantPOSEB2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button5_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT BillDate,Sum(GrandTotal) as [GrandTotal] from(Select Cast(BillDate as Date) as BillDate,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoKOT WHERE (MONTH(BillDate) = @d1) AND (YEAR(BillDate) =@d2) and DIB_Status not in ('Unpaid','Changed to Split Bill') Union all Select Cast(BillDate as Date) as BillDate,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoTA WHERE (MONTH(BillDate) = @d1) AND (YEAR(BillDate) =@d2) and TA_Status not in ('Void','Unpaid','Prepared') Union all Select Cast(BillDate as Date) as BillDate,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD WHERE (MONTH(BillDate) = @d1) AND (YEAR(BillDate) =@d2) and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Cast(BillDate as Date) as BillDate,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoEB WHERE (MONTH(BillDate) = @d1) AND (YEAR(BillDate) =@d2) and EB_Status not in ('Void','Unpaid','Prepared'))G  group by BillDate order by 1")
                sqlCommand.Parameters.AddWithValue("@d1", Me.DateTimePicker1.Value.[Date].Month)
                sqlCommand.Parameters.AddWithValue("@d2", Me.DateTimePicker1.Value.[Date].Year)
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(New System.Data.SqlClient.SqlCommand("SELECT * from Hotel", RestaurantPOS14.ModClasses.con))
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT BillDate,Sum(GrandTotal) as [GrandTotal] from(Select Cast(BillDate as Date) as BillDate,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoKOT WHERE (MONTH(BillDate) = @d1) AND (YEAR(BillDate) =@d2) and DIB_Status not in ('Unpaid','Changed to Split Bill') Union all Select Cast(BillDate as Date) as BillDate,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoTA WHERE (MONTH(BillDate) = @d1) AND (YEAR(BillDate) =@d2) and TA_Status not in ('Void','Unpaid','Prepared') Union all Select Cast(BillDate as Date) as BillDate,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD WHERE (MONTH(BillDate) = @d1) AND (YEAR(BillDate) =@d2) and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Cast(BillDate as Date) as BillDate,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoEB WHERE (MONTH(BillDate) = @d1) AND (YEAR(BillDate) =@d2) and EB_Status not in ('Void','Unpaid','Prepared'))G  group by BillDate order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand2.Parameters.AddWithValue("@d1", Me.DateTimePicker1.Value.[Date].Month)
                sqlCommand2.Parameters.AddWithValue("@d2", Me.DateTimePicker1.Value.[Date].Year)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.WriteXmlSchema("NewROSReportByMonth.xml")
                Dim rptRPOSByMonth2 As RestaurantPOS14.rptRPOSByMonth = New RestaurantPOS14.rptRPOSByMonth()
                rptRPOSByMonth2.SetDataSource(dataSet)
                rptRPOSByMonth2.SetParameterValue("p1", Me.DateTimePicker1.Value)
                RestaurantPOS14.ModFunc.GetPrinterName(System.Net.Dns.GetHostName(), rptRPOSByMonth2)
                rptRPOSByMonth2.Close()
                rptRPOSByMonth2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbWaiterName_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                If Me.cmbWaiterName.SelectedIndex < 0 Then
                    Return
                End If
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Waiter from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and Waiter=@d3")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbWaiterName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT BillNo, BillDate, Operator, PaymentMode, GrandTotal FROM RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and Waiter=@d3 order by 2", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbWaiterName.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("CollectionByWaiter.xml")
                Dim rptCollectionsByWaiter2 As RestaurantPOS14.rptCollectionsByWaiter = New RestaurantPOS14.rptCollectionsByWaiter()
                rptCollectionsByWaiter2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptCollectionsByWaiter2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptCollectionsByWaiter2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptCollectionsByWaiter2.SetParameterValue("p3", Me.cmbWaiterName.Text)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptCollectionsByWaiter2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptCollectionsByWaiter2.Close()
                rptCollectionsByWaiter2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmRPOSReport_Load(sender As Object, e As System.EventArgs)
            Me.fillOperatorID()
            Me.fillWaiter()
            Me.fillKitchen()
        End Sub

        Private Sub btnCanceledKOTs_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select * from RestaurantPOS_OrderInfoKOT where BillDate >=@d1 and BillDate < @d2 and KOT_Status='Void'")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_OrderInfoKOT.TicketNo, RestaurantPOS_OrderInfoKOT.BillDate, RestaurantPOS_OrderInfoKOT.TableNo, RestaurantPOS_OrderInfoKOT.Operator,RestaurantPOS_OrderedProductKOT.Dish, RestaurantPOS_OrderedProductKOT.Quantity FROM RestaurantPOS_OrderInfoKOT INNER JOIN RestaurantPOS_OrderedProductKOT ON RestaurantPOS_OrderInfoKOT.ID = RestaurantPOS_OrderedProductKOT.TicketID where BillDate >=@d1 and BillDate < @d2 and KOT_Status='Void' order by BillDate", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("VoidKOT.xml")
                Dim rptVoidKOT2 As RestaurantPOS14.rptVoidKOT = New RestaurantPOS14.rptVoidKOT()
                rptVoidKOT2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptVoidKOT2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptVoidKOT2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptVoidKOT2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptVoidKOT2.Close()
                rptVoidKOT2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnViewReportDeletedInvoices_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT BillNo, BillDate, GrandTotal, Operator, PaymentMode, Reason, DeletedDate, BillType FROM DeletedInvoices  where DeletedDate >=@d1 and DeletedDate < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT BillNo, BillDate, GrandTotal, Operator, PaymentMode, Reason, DeletedDate, BillType,Canceled_Deleted FROM DeletedInvoices where DeletedDate >=@d1 and DeletedDate < @d2 order by DeletedDate", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("DeletedBills1.xml")
                Dim rptDeletedBills2 As RestaurantPOS14.rptDeletedBills = New RestaurantPOS14.rptDeletedBills()
                rptDeletedBills2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptDeletedBills2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptDeletedBills2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptDeletedBills2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptDeletedBills2.Close()
                rptDeletedBills2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnViewReportDeletedInvoicesItemwise_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * FROM DeletedInvoices INNER JOIN DeletedInvoices_JOIN ON DeletedInvoices.BillNo=DeletedInvoices_Join.BillNo where DeletedDate >=@d1 and DeletedDate < @d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * FROM DeletedInvoices INNER JOIN DeletedInvoices_JOIN ON DeletedInvoices.BillNo=DeletedInvoices_Join.BillNo where DeletedDate >=@d1 and DeletedDate < @d2 order by DeletedDate", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("DeletedBillsItems.xml")
                Dim rptDeletedItems2 As RestaurantPOS14.rptDeletedItems = New RestaurantPOS14.rptDeletedItems()
                rptDeletedItems2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptDeletedItems2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptDeletedItems2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptDeletedItems2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptDeletedItems2.Close()
                rptDeletedItems2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub CButton1_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT * from Hotel", RestaurantPOS14.ModClasses.con)
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlCommand3 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Operator,Sum(GrandTotal) as [GrandTotal] from(Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select Operator,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Operator order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand3.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand3.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand3.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand3)
                Dim sqlCommand4 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(TotalAmount) as Total from (Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,(TotalAmount) as [TotalAmount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand4.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand4.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand4.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand4)
                Dim sqlCommand5 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(Quantity) as TotalQuantity from (Select category,Quantity from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d5 and BillDate < @d6 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d5 and BillDate < @d6 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d5 and BillDate < @d6 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,Quantity from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d5 and BillDate < @d6 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand5.Parameters.Add(CStr(("@d5")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand5.Parameters.Add(CStr(("@d6")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand5.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand5)
                Dim sqlCommand6 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Dish order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand6.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand6.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand6.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand6)
                Dim sqlCommand7 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT PaymentMode,IsNull(Sum(Card),0) as [Card] from (Select PaymentMode,Card as [Card] from RestaurantPOS_BillingInfoKOT where BillDate >=@d11 and BillDate < @d12 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,GrandTotal as [Card] from RestaurantPOS_BillingInfoHD where BillDate >=@d11 and BillDate < @d12 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union all Select PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoEB where BillDate >=@d11 and BillDate < @d12 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card'))G  group by PaymentMode order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand7.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand7.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand7.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand7)
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand8 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(HomeDeliveryCharges),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d9 and BillDate < @d10 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand8.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand8.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand8.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand8.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand8.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand9 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(ParcelCharges*ExchangeRate),0) from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand9.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand9.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand9.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand9.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand9.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand10 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoKOT where BillDate >=@d13 and BillDate < @d14 and DIB_Status not in ('Unpaid','Changed to Split Bill')")
                sqlCommand10.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand10.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand10.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand10.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand10.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand11 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoTA where BillDate >=@d13 and BillDate < @d14 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand11.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand11.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand11.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand11.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand11.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand12 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal),0)  from RestaurantPOS_BillingInfoHD where BillDate >=@d13 and BillDate < @d14 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand12.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand12.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand12.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand12.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand12.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand13 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoEB where BillDate >=@d13 and BillDate < @d14 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand13.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand13.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand13.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand13.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand13.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand14 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(TotalVAT) as TotalVAT,SUM(TotalDiscount) as TotalDicount from (Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand14.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand14.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand14.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand14.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand14.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.D1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand15 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(LA) as [LA] from(Select LA as [LA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select LA as [LA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select LA as [LA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select LA as [LA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand15.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand15.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand15.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand15.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand15.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand16 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(GCA) as [GCA] from(Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand16.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand16.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand16.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand16.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand16.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand17 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Cash' Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand17.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand17.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand17.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand17.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand17.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand18 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card')G")
                sqlCommand18.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand18.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand18.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand18.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand18.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand19 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Debit Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Debit Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card')G")
                sqlCommand19.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand19.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand19.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand19.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand19.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand20 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='VIP Member Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='VIP Member Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card')G")
                sqlCommand20.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand20.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand20.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand20.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand20.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand21 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(GrandTotal),0) as [GrandTotal] from(Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Customer'  Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer')G")
                sqlCommand21.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand21.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand21.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand21.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand21.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand22 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(TIP),0) as [TIP] from(Select Tip as [TIP] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') )G")
                sqlCommand22.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand22.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand22.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand22.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand22.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.T1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand23 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(NoOfPerson),0) from RestaurantPOS_OrderInfoKOT where BillDate >=@d9 and BillDate < @d10 and KOT_Status <> 'Void'")
                sqlCommand23.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand23.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand23.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand23.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand23.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.TC = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand24 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNULL(Count(Case when Canceled_Deleted ='Canceled' then 1 else NULL end),0),IsNULL(Count(Case when Canceled_Deleted ='Deleted' then 1 else NULL end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Canceled') then GrandTotal else 0 end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Deleted') then GrandTotal else 0 end),0) from DeletedInvoices where deletedDate >=@d13 and DeletedDate < @d14")
                sqlCommand24.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand24.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand24.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand24.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand24.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.M1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.M2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.M3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.M4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand25 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT iSNULL(SUM(TotalDiscount),0) as TotalDiscount from (Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand25.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand25.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand25.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand25.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand25.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.CX = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If
                RestaurantPOS14.ModClasses.con.Close()
                Me.S1 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from Payment where Date >=@d1 and Date < @d2", Me.DateTimePicker3.Value, Me.DateTimePicker2.Value)
                Me.S2 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from CreditCustomerPayment where Date >=@d1 and Date < @d2", Me.DateTimePicker3.Value, Me.DateTimePicker2.Value)
                Me.S3 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from Voucher where Date >=@d1 and Date < @d2", Me.DateTimePicker3.Value, Me.DateTimePicker2.Value)
                Me.S4 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", Me.DateTimePicker3.Value, Me.DateTimePicker2.Value)
                Me.S5 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0)-IsNull(Sum(AmtReceived),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", Me.DateTimePicker3.Value, Me.DateTimePicker2.Value)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable3 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable4 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable5 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable6 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                sqlDataAdapter3.Fill(dataTable3)
                sqlDataAdapter4.Fill(dataTable4)
                sqlDataAdapter5.Fill(dataTable5)
                sqlDataAdapter6.Fill(dataTable6)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.Tables.Add(dataTable3)
                dataSet.Tables.Add(dataTable4)
                dataSet.Tables.Add(dataTable5)
                dataSet.Tables.Add(dataTable6)
                dataSet.WriteXmlSchema("RPOSLatest.xml")
                Dim rptRPOS3 As RestaurantPOS14.rptRPOS = New RestaurantPOS14.rptRPOS()
                rptRPOS3.Subreports(CInt((0))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((1))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((2))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((3))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((4))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((5))).SetDataSource(dataSet)
                rptRPOS3.SetDataSource(dataSet)
                rptRPOS3.SetParameterValue("p1", Me.DateTimePicker3.Value.ToString("dd/MM/yyyy hh:mm:ss tt"))
                rptRPOS3.SetParameterValue("p2", Me.DateTimePicker2.Value.ToString("dd/MM/yyyy hh:mm:ss tt"))
                rptRPOS3.SetParameterValue("p3", Me.a)
                rptRPOS3.SetParameterValue("p4", Me.b)
                rptRPOS3.SetParameterValue("p5", Me.a)
                rptRPOS3.SetParameterValue("p6", Me.b)
                rptRPOS3.SetParameterValue("b1", Me.b1)
                rptRPOS3.SetParameterValue("b2", Me.b2)
                rptRPOS3.SetParameterValue("b3", Me.b3)
                rptRPOS3.SetParameterValue("b4", Me.b4)
                rptRPOS3.SetParameterValue("b1x", Me.b1)
                rptRPOS3.SetParameterValue("b2x", Me.b2)
                rptRPOS3.SetParameterValue("b3x", Me.b3)
                rptRPOS3.SetParameterValue("b4x", Me.b4)
                rptRPOS3.SetParameterValue("b5", Me.b5)
                rptRPOS3.SetParameterValue("Z1", Me.Z1)
                rptRPOS3.SetParameterValue("Z2", Me.Z2)
                rptRPOS3.SetParameterValue("Z3", Me.Z1)
                rptRPOS3.SetParameterValue("Z4", Me.Z2)
                rptRPOS3.SetParameterValue("G1", Me.G1)
                rptRPOS3.SetParameterValue("G2", Me.G2)
                rptRPOS3.SetParameterValue("G3", Me.G3)
                rptRPOS3.SetParameterValue("G4", Me.G4)
                rptRPOS3.SetParameterValue("G5", Me.G5)
                rptRPOS3.SetParameterValue("T1", Me.T1)
                rptRPOS3.SetParameterValue("T2", Me.T1)
                rptRPOS3.SetParameterValue("T3", Me.T1)
                rptRPOS3.SetParameterValue("CS", Me.TC)
                rptRPOS3.SetParameterValue("D1", Me.D1)
                rptRPOS3.SetParameterValue("M1", Me.M1)
                rptRPOS3.SetParameterValue("M2", Me.M2)
                rptRPOS3.SetParameterValue("M3", Me.M3)
                rptRPOS3.SetParameterValue("M4", Me.M4)
                rptRPOS3.SetParameterValue("CX", Me.CX)
                rptRPOS3.SetParameterValue("S1", Me.S1)
                rptRPOS3.SetParameterValue("S2", Me.S2)
                rptRPOS3.SetParameterValue("S3", Me.S3)
                rptRPOS3.SetParameterValue("S4", Me.S4)
                rptRPOS3.SetParameterValue("S5", Me.S5)
                RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer1.CrystalReportViewer1.ReportSource = rptRPOS3
                RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer1.dtpDateFrom.Value = Me.DateTimePicker3.Value
                RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer1.dtpDateTo.Value = Me.DateTimePicker2.Value
                RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer1.txtEmailID.Text = ""
                Call RestaurantPOS14.My.MyProject.Forms.frmPOSReport_CRViewer1.ShowDialog()
                rptRPOS3.Close()
                rptRPOS3.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub CButton2_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbOperatorID.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select operator id.", "Selection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Me.cmbOperatorID.SelectedIndex = -1
                Me.cmbOperatorID.Focus()
                Return
            End If
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand.Parameters.AddWithValue("@d3", Me.cmbOperatorID.Text)
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_BillingInfoKOT.BillNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.PaymentMode, RestaurantPOS_BillingInfoKOT.Operator,RestaurantPOS_BillingInfoKOT.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoKOT INNER JOIN RestaurantPOS_OrderedProductBillKOT ON RestaurantPOS_BillingInfoKOT.Id = RestaurantPOS_OrderedProductBillKOT.BillID Where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION SELECT RestaurantPOS_BillingInfoTA.BillNo, RestaurantPOS_BillingInfoTA.BillDate, RestaurantPOS_BillingInfoTA.PaymentMode, RestaurantPOS_BillingInfoTA.Operator,RestaurantPOS_BillingInfoTA.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoTA INNER JOIN RestaurantPOS_OrderedProductBillTA ON RestaurantPOS_BillingInfoTA.Id = RestaurantPOS_OrderedProductBillTA.BillID Where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and TA_Status not in ('Void','Unpaid','Prepared') UNION SELECT RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,RestaurantPOS_BillingInfoHD.GrandTotal,0,0 FROM RestaurantPOS_BillingInfoHD INNER JOIN RestaurantPOS_OrderedProductBillHD ON RestaurantPOS_BillingInfoHD.Id = RestaurantPOS_OrderedProductBillHD.BillID Where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') group by RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,RestaurantPOS_BillingInfoHD.GrandTotal UNION SELECT RestaurantPOS_BillingInfoEB.BillNo, RestaurantPOS_BillingInfoEB.BillDate, RestaurantPOS_BillingInfoEB.PaymentMode, RestaurantPOS_BillingInfoEB.Operator,RestaurantPOS_BillingInfoEB.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoEB INNER JOIN RestaurantPOS_OrderedProductBillEB ON RestaurantPOS_BillingInfoEB.Id = RestaurantPOS_OrderedProductBillEB.BillID Where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and EB_Status not in ('Void','Unpaid','Prepared') order by 2", RestaurantPOS14.ModClasses.con)
                sqlCommand2.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand2.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand2.Parameters.AddWithValue("@d3", Me.cmbOperatorID.Text)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(New System.Data.SqlClient.SqlCommand("Select * from Hotel", RestaurantPOS14.ModClasses.con))
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                RestaurantPOS14.ModClasses.con.Close()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.WriteXmlSchema("POSReportA4.xml")
                Dim rptPOS80mmByOperator2 As RestaurantPOS14.rptPOS80mmByOperator = New RestaurantPOS14.rptPOS80mmByOperator()
                rptPOS80mmByOperator2.SetDataSource(dataSet)
                rptPOS80mmByOperator2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptPOS80mmByOperator2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptPOS80mmByOperator2.SetParameterValue("p3", Me.cmbOperatorID.Text)
                RestaurantPOS14.ModFunc.GetPrinterName(System.Net.Dns.GetHostName(), rptPOS80mmByOperator2)
                rptPOS80mmByOperator2.Close()
                rptPOS80mmByOperator2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub CButton3_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbOperatorID.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select operator id.", "Selection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Me.cmbOperatorID.SelectedIndex = -1
                Me.cmbOperatorID.Focus()
                Return
            End If
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand.Parameters.AddWithValue("@d3", Me.cmbOperatorID.Text)
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_BillingInfoKOT.BillNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.PaymentMode, RestaurantPOS_BillingInfoKOT.Operator,RestaurantPOS_BillingInfoKOT.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoKOT INNER JOIN RestaurantPOS_OrderedProductBillKOT ON RestaurantPOS_BillingInfoKOT.Id = RestaurantPOS_OrderedProductBillKOT.BillID Where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION SELECT RestaurantPOS_BillingInfoTA.BillNo, RestaurantPOS_BillingInfoTA.BillDate, RestaurantPOS_BillingInfoTA.PaymentMode, RestaurantPOS_BillingInfoTA.Operator,RestaurantPOS_BillingInfoTA.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoTA INNER JOIN RestaurantPOS_OrderedProductBillTA ON RestaurantPOS_BillingInfoTA.Id = RestaurantPOS_OrderedProductBillTA.BillID Where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and TA_Status not in ('Void','Unpaid','Prepared') UNION SELECT RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,RestaurantPOS_BillingInfoHD.GrandTotal,0,0 FROM RestaurantPOS_BillingInfoHD INNER JOIN RestaurantPOS_OrderedProductBillHD ON RestaurantPOS_BillingInfoHD.Id = RestaurantPOS_OrderedProductBillHD.BillID Where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') group by RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,RestaurantPOS_BillingInfoHD.GrandTotal UNION SELECT RestaurantPOS_BillingInfoEB.BillNo, RestaurantPOS_BillingInfoEB.BillDate, RestaurantPOS_BillingInfoEB.PaymentMode, RestaurantPOS_BillingInfoEB.Operator,RestaurantPOS_BillingInfoEB.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoEB INNER JOIN RestaurantPOS_OrderedProductBillEB ON RestaurantPOS_BillingInfoEB.Id = RestaurantPOS_OrderedProductBillEB.BillID Where BillDate >=@d1 and BillDate < @d2 and Operator=@d3 and EB_Status not in ('Void','Unpaid','Prepared') order by 2", RestaurantPOS14.ModClasses.con)
                sqlCommand2.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand2.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand2.Parameters.AddWithValue("@d3", Me.cmbOperatorID.Text)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(New System.Data.SqlClient.SqlCommand("Select * from Hotel", RestaurantPOS14.ModClasses.con))
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                RestaurantPOS14.ModClasses.con.Close()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.WriteXmlSchema("POSReportA4.xml")
                Dim rptPOSA4ByOperator2 As RestaurantPOS14.rptPOSA4ByOperator = New RestaurantPOS14.rptPOSA4ByOperator()
                rptPOSA4ByOperator2.SetDataSource(dataSet)
                rptPOSA4ByOperator2.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptPOSA4ByOperator2.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                rptPOSA4ByOperator2.SetParameterValue("p3", Me.cmbOperatorID.Text)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptPOSA4ByOperator2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptPOSA4ByOperator2.Dispose()
                rptPOSA4ByOperator2.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub CButton4_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_BillingInfoKOT.BillNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.PaymentMode, RestaurantPOS_BillingInfoKOT.Operator,RestaurantPOS_BillingInfoKOT.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoKOT INNER JOIN RestaurantPOS_OrderedProductBillKOT ON RestaurantPOS_BillingInfoKOT.Id = RestaurantPOS_OrderedProductBillKOT.BillID Where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION SELECT RestaurantPOS_BillingInfoTA.BillNo, RestaurantPOS_BillingInfoTA.BillDate, RestaurantPOS_BillingInfoTA.PaymentMode, RestaurantPOS_BillingInfoTA.Operator,RestaurantPOS_BillingInfoTA.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoTA INNER JOIN RestaurantPOS_OrderedProductBillTA ON RestaurantPOS_BillingInfoTA.Id = RestaurantPOS_OrderedProductBillTA.BillID Where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') UNION SELECT RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,RestaurantPOS_BillingInfoHD.GrandTotal,0,0 FROM RestaurantPOS_BillingInfoHD INNER JOIN RestaurantPOS_OrderedProductBillHD ON RestaurantPOS_BillingInfoHD.Id = RestaurantPOS_OrderedProductBillHD.BillID Where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') group by RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,RestaurantPOS_BillingInfoHD.GrandTotal UNION SELECT RestaurantPOS_BillingInfoEB.BillNo, RestaurantPOS_BillingInfoEB.BillDate, RestaurantPOS_BillingInfoEB.PaymentMode, RestaurantPOS_BillingInfoEB.Operator,RestaurantPOS_BillingInfoEB.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoEB INNER JOIN RestaurantPOS_OrderedProductBillEB ON RestaurantPOS_BillingInfoEB.Id = RestaurantPOS_OrderedProductBillEB.BillID Where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared') order by 2", RestaurantPOS14.ModClasses.con)
                sqlCommand2.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value.[Date]
                sqlCommand2.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(New System.Data.SqlClient.SqlCommand("Select * from Hotel", RestaurantPOS14.ModClasses.con))
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                RestaurantPOS14.ModClasses.con.Close()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.WriteXmlSchema("POSReportA4.xml")
                Dim rptPOSA5 As RestaurantPOS14.rptPOSA4 = New RestaurantPOS14.rptPOSA4()
                rptPOSA5.SetDataSource(dataSet)
                rptPOSA5.SetParameterValue("p1", Me.dtpDateFrom.Value.[Date])
                rptPOSA5.SetParameterValue("p2", Me.dtpDateTo.Value.[Date])
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptPOSA5
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptPOSA5.Dispose()
                rptPOSA5.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub CButton5_ClickButtonArea(Sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If
                    Return
                End If
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_BillingInfoKOT.BillNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.PaymentMode, RestaurantPOS_BillingInfoKOT.Operator,RestaurantPOS_BillingInfoKOT.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoKOT INNER JOIN RestaurantPOS_OrderedProductBillKOT ON RestaurantPOS_BillingInfoKOT.Id = RestaurantPOS_OrderedProductBillKOT.BillID Where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION SELECT RestaurantPOS_BillingInfoTA.BillNo, RestaurantPOS_BillingInfoTA.BillDate, RestaurantPOS_BillingInfoTA.PaymentMode, RestaurantPOS_BillingInfoTA.Operator,RestaurantPOS_BillingInfoTA.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoTA INNER JOIN RestaurantPOS_OrderedProductBillTA ON RestaurantPOS_BillingInfoTA.Id = RestaurantPOS_OrderedProductBillTA.BillID Where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') UNION SELECT RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,RestaurantPOS_BillingInfoHD.GrandTotal,0,0 FROM RestaurantPOS_BillingInfoHD INNER JOIN RestaurantPOS_OrderedProductBillHD ON RestaurantPOS_BillingInfoHD.Id = RestaurantPOS_OrderedProductBillHD.BillID Where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') group by RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.PaymentMode, RestaurantPOS_BillingInfoHD.Operator,RestaurantPOS_BillingInfoHD.GrandTotal UNION SELECT RestaurantPOS_BillingInfoEB.BillNo, RestaurantPOS_BillingInfoEB.BillDate, RestaurantPOS_BillingInfoEB.PaymentMode, RestaurantPOS_BillingInfoEB.Operator,RestaurantPOS_BillingInfoEB.GrandTotal,(Cash-Change) as [Cash],Card FROM RestaurantPOS_BillingInfoEB INNER JOIN RestaurantPOS_OrderedProductBillEB ON RestaurantPOS_BillingInfoEB.Id = RestaurantPOS_OrderedProductBillEB.BillID Where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared') order by 2", RestaurantPOS14.ModClasses.con)
                sqlCommand2.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker3.Value
                sqlCommand2.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTimePicker2.Value
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(New System.Data.SqlClient.SqlCommand("Select * from Hotel", RestaurantPOS14.ModClasses.con))
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                RestaurantPOS14.ModClasses.con.Close()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.WriteXmlSchema("POSReportA4.xml")
                Dim rptPOSA4X2 As RestaurantPOS14.rptPOSA4X = New RestaurantPOS14.rptPOSA4X()
                rptPOSA4X2.SetDataSource(dataSet)
                rptPOSA4X2.SetParameterValue("p1", Me.DateTimePicker3.Value)
                rptPOSA4X2.SetParameterValue("p2", Me.DateTimePicker2.Value)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptPOSA4X2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptPOSA4X2.Dispose()
                rptPOSA4X2.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <System.Diagnostics.DebuggerStepThroughAttribute>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim cBlendItems As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPOSReport))
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems7 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems8 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems9 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems10 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems11 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems12 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems13 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems14 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems15 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems16 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.CButton3 = New CButtonLib.CButton()
            Me.CButton2 = New CButtonLib.CButton()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.CButton5 = New CButtonLib.CButton()
            Me.CButton1 = New CButtonLib.CButton()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.Button5 = New CButtonLib.CButton()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.CButton4 = New CButtonLib.CButton()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
            Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cmbKitchen = New System.Windows.Forms.ComboBox()
            Me.btnViewReportDeletedInvoicesItemwise = New CButtonLib.CButton()
            Me.btnCanceledKOTs = New CButtonLib.CButton()
            Me.btnViewReportDeletedInvoices = New CButtonLib.CButton()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.cmbWaiterName = New System.Windows.Forms.ComboBox()
            Me.cmbOperatorID = New System.Windows.Forms.ComboBox()
            Me.Button4 = New CButtonLib.CButton()
            Me.Button3 = New CButtonLib.CButton()
            Me.Button2 = New CButtonLib.CButton()
            Me.Button1 = New CButtonLib.CButton()
            Me.btnViewReport = New CButtonLib.CButton()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnClose = New CButtonLib.CButton()
            Me.btnReset = New CButtonLib.CButton()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Panel5)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.btnReset)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(5, 4)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(758, 617)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.Panel5.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.CButton3)
            Me.Panel5.Controls.Add(Me.CButton2)
            Me.Panel5.Controls.Add(Me.GroupBox3)
            Me.Panel5.Controls.Add(Me.GroupBox2)
            Me.Panel5.Controls.Add(Me.Label7)
            Me.Panel5.Controls.Add(Me.GroupBox1)
            Me.Panel5.Controls.Add(Me.cmbKitchen)
            Me.Panel5.Controls.Add(Me.btnViewReportDeletedInvoicesItemwise)
            Me.Panel5.Controls.Add(Me.btnCanceledKOTs)
            Me.Panel5.Controls.Add(Me.btnViewReportDeletedInvoices)
            Me.Panel5.Controls.Add(Me.Label5)
            Me.Panel5.Controls.Add(Me.Label3)
            Me.Panel5.Controls.Add(Me.cmbWaiterName)
            Me.Panel5.Controls.Add(Me.cmbOperatorID)
            Me.Panel5.Controls.Add(Me.Button4)
            Me.Panel5.Controls.Add(Me.Button3)
            Me.Panel5.Controls.Add(Me.Button2)
            Me.Panel5.Controls.Add(Me.Button1)
            Me.Panel5.Controls.Add(Me.btnViewReport)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel5
            location = New System.Drawing.Point(5, 52)
            panel3.Location = location
            Me.Panel5.Name = "Panel5"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel5
            size = New System.Drawing.Size(748, 557)
            panel4.Size = size
            Me.Panel5.TabIndex = 42
            Me.CButton3.BackColor = System.Drawing.Color.Transparent
            Me.CButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.CButton3.BorderColor = System.Drawing.Color.Black
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.CButton3.ColorFillBlend = cBlendItems
            Me.CButton3.Corners.All = 5
            Me.CButton3.Corners.LowerLeft = 5
            Me.CButton3.Corners.LowerRight = 5
            Me.CButton3.Corners.UpperLeft = 5
            Me.CButton3.Corners.UpperRight = 5
            Me.CButton3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CButton3.DesignerSelected = False
            Me.CButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.CButton3.Image = CType(componentResourceManager.GetObject("CButton3.Image"), System.Drawing.Image)
            Me.CButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.CButton3.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.CButton3
            size = New System.Drawing.Size(32, 32)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.CButton3
            location = New System.Drawing.Point(583, 116)
            cButton2.Location = location
            Me.CButton3.Name = "CButton3"
            Dim cButton3 As CButtonLib.CButton = Me.CButton3
            size = New System.Drawing.Size(118, 45)
            cButton3.Size = size
            Me.CButton3.TabIndex = 114
            Me.CButton3.Text = "View Report A4"
            Me.CButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.CButton3.TextShadowShow = False
            Me.CButton3.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.CButton2.BackColor = System.Drawing.Color.Transparent
            Me.CButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.CButton2.BorderColor = System.Drawing.Color.Black
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.CButton2.ColorFillBlend = cBlendItems2
            Me.CButton2.Corners.All = 5
            Me.CButton2.Corners.LowerLeft = 5
            Me.CButton2.Corners.LowerRight = 5
            Me.CButton2.Corners.UpperLeft = 5
            Me.CButton2.Corners.UpperRight = 5
            Me.CButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CButton2.DesignerSelected = False
            Me.CButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.CButton2.Image = CType(componentResourceManager.GetObject("CButton2.Image"), System.Drawing.Image)
            Me.CButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.CButton2.ImageIndex = 0
            Dim cButton4 As CButtonLib.CButton = Me.CButton2
            size = New System.Drawing.Size(32, 32)
            cButton4.ImageSize = size
            Dim cButton5 As CButtonLib.CButton = Me.CButton2
            location = New System.Drawing.Point(439, 116)
            cButton5.Location = location
            Me.CButton2.Name = "CButton2"
            Dim cButton6 As CButtonLib.CButton = Me.CButton2
            size = New System.Drawing.Size(138, 45)
            cButton6.Size = size
            Me.CButton2.TabIndex = 113
            Me.CButton2.Text = "Print Report 80 mm"
            Me.CButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.CButton2.TextShadowShow = False
            Me.CButton2.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.GroupBox3.Controls.Add(Me.CButton5)
            Me.GroupBox3.Controls.Add(Me.CButton1)
            Me.GroupBox3.Controls.Add(Me.Label6)
            Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
            Me.GroupBox3.Controls.Add(Me.DateTimePicker3)
            Me.GroupBox3.Controls.Add(Me.Label8)
            Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox3.ForeColor = System.Drawing.Color.White
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(4, 447)
            groupBox.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(738, 102)
            groupBox2.Size = size
            Me.GroupBox3.TabIndex = 112
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Search By DateTime :"
            Me.CButton5.BackColor = System.Drawing.Color.Transparent
            Me.CButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.CButton5.BorderColor = System.Drawing.Color.Black
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.CButton5.ColorFillBlend = cBlendItems3
            Me.CButton5.Corners.All = 5
            Me.CButton5.Corners.LowerLeft = 5
            Me.CButton5.Corners.LowerRight = 5
            Me.CButton5.Corners.UpperLeft = 5
            Me.CButton5.Corners.UpperRight = 5
            Me.CButton5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CButton5.DesignerSelected = False
            Me.CButton5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.CButton5.Image = CType(componentResourceManager.GetObject("CButton5.Image"), System.Drawing.Image)
            Me.CButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.CButton5.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.CButton5
            size = New System.Drawing.Size(32, 32)
            cButton7.ImageSize = size
            Dim cButton8 As CButtonLib.CButton = Me.CButton5
            location = New System.Drawing.Point(622, 41)
            cButton8.Location = location
            Me.CButton5.Name = "CButton5"
            Dim cButton9 As CButtonLib.CButton = Me.CButton5
            size = New System.Drawing.Size(110, 48)
            cButton9.Size = size
            Me.CButton5.TabIndex = 116
            Me.CButton5.Text = "View Report A4"
            Me.CButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.CButton5.TextShadowShow = False
            Me.CButton5.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.CButton1.BackColor = System.Drawing.Color.Transparent
            Me.CButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.CButton1.BorderColor = System.Drawing.Color.Black
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.CButton1.ColorFillBlend = cBlendItems4
            Me.CButton1.Corners.All = 5
            Me.CButton1.Corners.LowerLeft = 5
            Me.CButton1.Corners.LowerRight = 5
            Me.CButton1.Corners.UpperLeft = 5
            Me.CButton1.Corners.UpperRight = 5
            Me.CButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CButton1.DesignerSelected = False
            Me.CButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.CButton1.Image = CType(componentResourceManager.GetObject("CButton1.Image"), System.Drawing.Image)
            Me.CButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.CButton1.ImageIndex = 0
            Dim cButton10 As CButtonLib.CButton = Me.CButton1
            size = New System.Drawing.Size(32, 32)
            cButton10.ImageSize = size
            Dim cButton11 As CButtonLib.CButton = Me.CButton1
            location = New System.Drawing.Point(520, 41)
            cButton11.Location = location
            Me.CButton1.Name = "CButton1"
            Dim cButton12 As CButtonLib.CButton = Me.CButton1
            size = New System.Drawing.Size(97, 50)
            cButton12.Size = size
            Me.CButton1.TabIndex = 108
            Me.CButton1.Text = "View Report"
            Me.CButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.CButton1.TextShadowShow = False
            Me.CButton1.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(266, 32)
            label.Location = location
            Me.Label6.Name = "Label6"
            Dim label2 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(33, 20)
            label2.Size = size
            Me.Label6.TabIndex = 10
            Me.Label6.Text = "To :"
            Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
            Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.DateTimePicker2
            location = New System.Drawing.Point(270, 60)
            dateTimePicker.Location = location
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker2
            size = New System.Drawing.Size(244, 29)
            dateTimePicker2.Size = size
            Me.DateTimePicker2.TabIndex = 107
            Me.DateTimePicker3.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTimePicker3.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
            Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker3 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker3
            location = New System.Drawing.Point(22, 60)
            dateTimePicker3.Location = location
            Me.DateTimePicker3.Name = "DateTimePicker3"
            Dim dateTimePicker4 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker3
            size = New System.Drawing.Size(242, 29)
            dateTimePicker4.Size = size
            Me.DateTimePicker3.TabIndex = 106
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(18, 32)
            label3.Location = location
            Me.Label8.Name = "Label8"
            Dim label4 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(53, 20)
            label4.Size = size
            Me.Label8.TabIndex = 9
            Me.Label8.Text = "From :"
            Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
            Me.GroupBox2.Controls.Add(Me.Button5)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox2.ForeColor = System.Drawing.Color.White
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(485, 3)
            groupBox3.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(260, 102)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 111
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search By Monthly Sales"
            Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTimePicker1.CustomFormat = "MM/yyyy"
            Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker5 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker1
            location = New System.Drawing.Point(6, 58)
            dateTimePicker5.Location = location
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Dim dateTimePicker6 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker1
            size = New System.Drawing.Size(132, 29)
            dateTimePicker6.Size = size
            Me.DateTimePicker1.TabIndex = 108
            Me.Button5.BackColor = System.Drawing.Color.Transparent
            Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button5.BorderColor = System.Drawing.Color.Black
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.Button5.ColorFillBlend = cBlendItems5
            Me.Button5.Corners.All = 5
            Me.Button5.Corners.LowerLeft = 5
            Me.Button5.Corners.LowerRight = 5
            Me.Button5.Corners.UpperLeft = 5
            Me.Button5.Corners.UpperRight = 5
            Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button5.DesignerSelected = False
            Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button5.Image = CType(componentResourceManager.GetObject("Button5.Image"), System.Drawing.Image)
            Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button5.ImageIndex = 0
            Dim button As CButtonLib.CButton = Me.Button5
            size = New System.Drawing.Size(32, 32)
            button.ImageSize = size
            Dim button2 As CButtonLib.CButton = Me.Button5
            location = New System.Drawing.Point(144, 38)
            button2.Location = location
            Me.Button5.Name = "Button5"
            Dim button3 As CButtonLib.CButton = Me.Button5
            size = New System.Drawing.Size(110, 50)
            button3.Size = size
            Me.Button5.TabIndex = 109
            Me.Button5.Text = "Print Report"
            Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button5.TextShadowShow = False
            Me.Button5.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label7.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(251, 231)
            label5.Location = location
            Me.Label7.Name = "Label7"
            Dim label6 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(195, 20)
            label6.Size = size
            Me.Label7.TabIndex = 27
            Me.Label7.Text = "Search By Kitchen/Section :"
            Me.GroupBox1.Controls.Add(Me.CButton4)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.dtpDateTo)
            Me.GroupBox1.Controls.Add(Me.dtpDateFrom)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox1.ForeColor = System.Drawing.Color.White
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(7, 3)
            groupBox5.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(478, 102)
            groupBox6.Size = size
            Me.GroupBox1.TabIndex = 3
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Date :"
            Me.CButton4.BackColor = System.Drawing.Color.Transparent
            Me.CButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.CButton4.BorderColor = System.Drawing.Color.Black
            cBlendItems6.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems6.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.CButton4.ColorFillBlend = cBlendItems6
            Me.CButton4.Corners.All = 5
            Me.CButton4.Corners.LowerLeft = 5
            Me.CButton4.Corners.LowerRight = 5
            Me.CButton4.Corners.UpperLeft = 5
            Me.CButton4.Corners.UpperRight = 5
            Me.CButton4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CButton4.DesignerSelected = False
            Me.CButton4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.CButton4.Image = CType(componentResourceManager.GetObject("CButton4.Image"), System.Drawing.Image)
            Me.CButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.CButton4.ImageIndex = 0
            Dim cButton13 As CButtonLib.CButton = Me.CButton4
            size = New System.Drawing.Size(32, 32)
            cButton13.ImageSize = size
            Dim cButton14 As CButtonLib.CButton = Me.CButton4
            location = New System.Drawing.Point(351, 44)
            cButton14.Location = location
            Me.CButton4.Name = "CButton4"
            Dim cButton15 As CButtonLib.CButton = Me.CButton4
            size = New System.Drawing.Size(121, 45)
            cButton15.Size = size
            Me.CButton4.TabIndex = 115
            Me.CButton4.Text = "View Report A4"
            Me.CButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.CButton4.TextShadowShow = False
            Me.CButton4.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(185, 32)
            label7.Location = location
            Me.Label4.Name = "Label4"
            Dim label8 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(33, 20)
            label8.Size = size
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "To :"
            Me.dtpDateTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
            Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker7 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            location = New System.Drawing.Point(189, 60)
            dateTimePicker7.Location = location
            Me.dtpDateTo.Name = "dtpDateTo"
            Dim dateTimePicker8 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            size = New System.Drawing.Size(156, 29)
            dateTimePicker8.Size = size
            Me.dtpDateTo.TabIndex = 107
            Me.dtpDateFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
            Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker9 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            location = New System.Drawing.Point(22, 60)
            dateTimePicker9.Location = location
            Me.dtpDateFrom.Name = "dtpDateFrom"
            Dim dateTimePicker10 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            size = New System.Drawing.Size(152, 29)
            dateTimePicker10.Size = size
            Me.dtpDateFrom.TabIndex = 106
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label9 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(18, 32)
            label9.Location = location
            Me.Label2.Name = "Label2"
            Dim label10 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(53, 20)
            label10.Size = size
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "From :"
            Me.cmbKitchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbKitchen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbKitchen.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbKitchen
            location = New System.Drawing.Point(251, 254)
            comboBox.Location = location
            Me.cmbKitchen.Name = "cmbKitchen"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbKitchen
            size = New System.Drawing.Size(264, 32)
            comboBox2.Size = size
            Me.cmbKitchen.TabIndex = 26
            Me.btnViewReportDeletedInvoicesItemwise.BackColor = System.Drawing.Color.Transparent
            Me.btnViewReportDeletedInvoicesItemwise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnViewReportDeletedInvoicesItemwise.BorderColor = System.Drawing.Color.Black
            cBlendItems7.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems7.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnViewReportDeletedInvoicesItemwise.ColorFillBlend = cBlendItems7
            Me.btnViewReportDeletedInvoicesItemwise.Corners.All = 5
            Me.btnViewReportDeletedInvoicesItemwise.Corners.LowerLeft = 5
            Me.btnViewReportDeletedInvoicesItemwise.Corners.LowerRight = 5
            Me.btnViewReportDeletedInvoicesItemwise.Corners.UpperLeft = 5
            Me.btnViewReportDeletedInvoicesItemwise.Corners.UpperRight = 5
            Me.btnViewReportDeletedInvoicesItemwise.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewReportDeletedInvoicesItemwise.DesignerSelected = False
            Me.btnViewReportDeletedInvoicesItemwise.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnViewReportDeletedInvoicesItemwise.Image = CType(componentResourceManager.GetObject("btnViewReportDeletedInvoicesItemwise.Image"), System.Drawing.Image)
            Me.btnViewReportDeletedInvoicesItemwise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnViewReportDeletedInvoicesItemwise.ImageIndex = 0
            Dim cButton16 As CButtonLib.CButton = Me.btnViewReportDeletedInvoicesItemwise
            size = New System.Drawing.Size(32, 32)
            cButton16.ImageSize = size
            Dim cButton17 As CButtonLib.CButton = Me.btnViewReportDeletedInvoicesItemwise
            location = New System.Drawing.Point(251, 391)
            cButton17.Location = location
            Me.btnViewReportDeletedInvoicesItemwise.Name = "btnViewReportDeletedInvoicesItemwise"
            Dim cButton18 As CButtonLib.CButton = Me.btnViewReportDeletedInvoicesItemwise
            size = New System.Drawing.Size(253, 50)
            cButton18.Size = size
            Me.btnViewReportDeletedInvoicesItemwise.TabIndex = 20
            Me.btnViewReportDeletedInvoicesItemwise.Text = "View Report Deleted/Canceled Invoices Itemwise"
            Me.btnViewReportDeletedInvoicesItemwise.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnViewReportDeletedInvoicesItemwise.TextShadowShow = False
            Me.btnViewReportDeletedInvoicesItemwise.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnCanceledKOTs.BackColor = System.Drawing.Color.Transparent
            Me.btnCanceledKOTs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnCanceledKOTs.BorderColor = System.Drawing.Color.Black
            cBlendItems8.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems8.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCanceledKOTs.ColorFillBlend = cBlendItems8
            Me.btnCanceledKOTs.Corners.All = 5
            Me.btnCanceledKOTs.Corners.LowerLeft = 5
            Me.btnCanceledKOTs.Corners.LowerRight = 5
            Me.btnCanceledKOTs.Corners.UpperLeft = 5
            Me.btnCanceledKOTs.Corners.UpperRight = 5
            Me.btnCanceledKOTs.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCanceledKOTs.DesignerSelected = False
            Me.btnCanceledKOTs.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCanceledKOTs.Image = CType(componentResourceManager.GetObject("btnCanceledKOTs.Image"), System.Drawing.Image)
            Me.btnCanceledKOTs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnCanceledKOTs.ImageIndex = 0
            Dim cButton19 As CButtonLib.CButton = Me.btnCanceledKOTs
            size = New System.Drawing.Size(32, 32)
            cButton19.ImageSize = size
            Dim cButton20 As CButtonLib.CButton = Me.btnCanceledKOTs
            location = New System.Drawing.Point(7, 391)
            cButton20.Location = location
            Me.btnCanceledKOTs.Name = "btnCanceledKOTs"
            Dim cButton21 As CButtonLib.CButton = Me.btnCanceledKOTs
            size = New System.Drawing.Size(238, 50)
            cButton21.Size = size
            Me.btnCanceledKOTs.TabIndex = 19
            Me.btnCanceledKOTs.Text = "View Report Canceled KOTs"
            Me.btnCanceledKOTs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCanceledKOTs.TextShadowShow = False
            Me.btnCanceledKOTs.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnViewReportDeletedInvoices.BackColor = System.Drawing.Color.Transparent
            Me.btnViewReportDeletedInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnViewReportDeletedInvoices.BorderColor = System.Drawing.Color.Black
            cBlendItems9.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems9.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnViewReportDeletedInvoices.ColorFillBlend = cBlendItems9
            Me.btnViewReportDeletedInvoices.Corners.All = 5
            Me.btnViewReportDeletedInvoices.Corners.LowerLeft = 5
            Me.btnViewReportDeletedInvoices.Corners.LowerRight = 5
            Me.btnViewReportDeletedInvoices.Corners.UpperLeft = 5
            Me.btnViewReportDeletedInvoices.Corners.UpperRight = 5
            Me.btnViewReportDeletedInvoices.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewReportDeletedInvoices.DesignerSelected = False
            Me.btnViewReportDeletedInvoices.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnViewReportDeletedInvoices.Image = CType(componentResourceManager.GetObject("btnViewReportDeletedInvoices.Image"), System.Drawing.Image)
            Me.btnViewReportDeletedInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnViewReportDeletedInvoices.ImageIndex = 0
            Dim cButton22 As CButtonLib.CButton = Me.btnViewReportDeletedInvoices
            size = New System.Drawing.Size(32, 32)
            cButton22.ImageSize = size
            Dim cButton23 As CButtonLib.CButton = Me.btnViewReportDeletedInvoices
            location = New System.Drawing.Point(251, 335)
            cButton23.Location = location
            Me.btnViewReportDeletedInvoices.Name = "btnViewReportDeletedInvoices"
            Dim cButton24 As CButtonLib.CButton = Me.btnViewReportDeletedInvoices
            size = New System.Drawing.Size(253, 50)
            cButton24.Size = size
            Me.btnViewReportDeletedInvoices.TabIndex = 18
            Me.btnViewReportDeletedInvoices.Text = "View Report Deleted/Canceled Invoices"
            Me.btnViewReportDeletedInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnViewReportDeletedInvoices.TextShadowShow = False
            Me.btnViewReportDeletedInvoices.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.White
            Dim label11 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(251, 167)
            label11.Location = location
            Me.Label5.Name = "Label5"
            Dim label12 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(132, 20)
            label12.Size = size
            Me.Label5.TabIndex = 17
            Me.Label5.Text = "Search By Waiter :"
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Dim label13 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(251, 106)
            label13.Location = location
            Me.Label3.Name = "Label3"
            Dim label14 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(169, 20)
            label14.Size = size
            Me.Label3.TabIndex = 16
            Me.Label3.Text = "Search By Operator ID :"
            Me.cmbWaiterName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbWaiterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbWaiterName.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbWaiterName
            location = New System.Drawing.Point(251, 190)
            comboBox3.Location = location
            Me.cmbWaiterName.Name = "cmbWaiterName"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbWaiterName
            size = New System.Drawing.Size(182, 32)
            comboBox4.Size = size
            Me.cmbWaiterName.TabIndex = 15
            Me.cmbOperatorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbOperatorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbOperatorID.FormattingEnabled = True
            Dim comboBox5 As System.Windows.Forms.ComboBox = Me.cmbOperatorID
            location = New System.Drawing.Point(251, 129)
            comboBox5.Location = location
            Me.cmbOperatorID.Name = "cmbOperatorID"
            Dim comboBox6 As System.Windows.Forms.ComboBox = Me.cmbOperatorID
            size = New System.Drawing.Size(182, 32)
            comboBox6.Size = size
            Me.cmbOperatorID.TabIndex = 14
            Me.Button4.BackColor = System.Drawing.Color.Transparent
            Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button4.BorderColor = System.Drawing.Color.Black
            cBlendItems10.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems10.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.Button4.ColorFillBlend = cBlendItems10
            Me.Button4.Corners.All = 5
            Me.Button4.Corners.LowerLeft = 5
            Me.Button4.Corners.LowerRight = 5
            Me.Button4.Corners.UpperLeft = 5
            Me.Button4.Corners.UpperRight = 5
            Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button4.DesignerSelected = False
            Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button4.Image = CType(componentResourceManager.GetObject("Button4.Image"), System.Drawing.Image)
            Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button4.ImageIndex = 0
            Dim button4 As CButtonLib.CButton = Me.Button4
            size = New System.Drawing.Size(32, 32)
            button4.ImageSize = size
            Dim button5 As CButtonLib.CButton = Me.Button4
            location = New System.Drawing.Point(7, 279)
            button5.Location = location
            Me.Button4.Name = "Button4"
            Dim button6 As CButtonLib.CButton = Me.Button4
            size = New System.Drawing.Size(218, 50)
            button6.Size = size
            Me.Button4.TabIndex = 9
            Me.Button4.Text = "View Report Express Billing"
            Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button4.TextShadowShow = False
            Me.Button4.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Button3.BackColor = System.Drawing.Color.Transparent
            Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button3.BorderColor = System.Drawing.Color.Black
            cBlendItems11.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems11.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.Button3.ColorFillBlend = cBlendItems11
            Me.Button3.Corners.All = 5
            Me.Button3.Corners.LowerLeft = 5
            Me.Button3.Corners.LowerRight = 5
            Me.Button3.Corners.UpperLeft = 5
            Me.Button3.Corners.UpperRight = 5
            Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button3.DesignerSelected = False
            Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button3.Image = CType(componentResourceManager.GetObject("Button3.Image"), System.Drawing.Image)
            Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button3.ImageIndex = 0
            Dim button7 As CButtonLib.CButton = Me.Button3
            size = New System.Drawing.Size(32, 32)
            button7.ImageSize = size
            Dim button8 As CButtonLib.CButton = Me.Button3
            location = New System.Drawing.Point(7, 335)
            button8.Location = location
            Me.Button3.Name = "Button3"
            Dim button9 As CButtonLib.CButton = Me.Button3
            size = New System.Drawing.Size(218, 50)
            button9.Size = size
            Me.Button3.TabIndex = 8
            Me.Button3.Text = "View Report Home Delivery Billing"
            Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button3.TextShadowShow = False
            Me.Button3.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Button2.BackColor = System.Drawing.Color.Transparent
            Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button2.BorderColor = System.Drawing.Color.Black
            cBlendItems12.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems12.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.Button2.ColorFillBlend = cBlendItems12
            Me.Button2.Corners.All = 5
            Me.Button2.Corners.LowerLeft = 5
            Me.Button2.Corners.LowerRight = 5
            Me.Button2.Corners.UpperLeft = 5
            Me.Button2.Corners.UpperRight = 5
            Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button2.DesignerSelected = False
            Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button2.Image = CType(componentResourceManager.GetObject("Button2.Image"), System.Drawing.Image)
            Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button2.ImageIndex = 0
            Dim button10 As CButtonLib.CButton = Me.Button2
            size = New System.Drawing.Size(32, 32)
            button10.ImageSize = size
            Dim button11 As CButtonLib.CButton = Me.Button2
            location = New System.Drawing.Point(7, 223)
            button11.Location = location
            Me.Button2.Name = "Button2"
            Dim button12 As CButtonLib.CButton = Me.Button2
            size = New System.Drawing.Size(218, 50)
            button12.Size = size
            Me.Button2.TabIndex = 7
            Me.Button2.Text = "View Report Takeaway Billing"
            Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button2.TextShadowShow = False
            Me.Button2.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Button1.BackColor = System.Drawing.Color.Transparent
            Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Button1.BorderColor = System.Drawing.Color.Black
            cBlendItems13.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems13.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.Button1.ColorFillBlend = cBlendItems13
            Me.Button1.Corners.All = 5
            Me.Button1.Corners.LowerLeft = 5
            Me.Button1.Corners.LowerRight = 5
            Me.Button1.Corners.UpperLeft = 5
            Me.Button1.Corners.UpperRight = 5
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.DesignerSelected = False
            Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.Image = CType(componentResourceManager.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Button1.ImageIndex = 0
            Dim button13 As CButtonLib.CButton = Me.Button1
            size = New System.Drawing.Size(32, 32)
            button13.ImageSize = size
            Dim button14 As CButtonLib.CButton = Me.Button1
            location = New System.Drawing.Point(7, 167)
            button14.Location = location
            Me.Button1.Name = "Button1"
            Dim button15 As CButtonLib.CButton = Me.Button1
            size = New System.Drawing.Size(218, 50)
            button15.Size = size
            Me.Button1.TabIndex = 6
            Me.Button1.Text = "View Report KOT Billing"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.TextShadowShow = False
            Me.Button1.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnViewReport.BackColor = System.Drawing.Color.Transparent
            Me.btnViewReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnViewReport.BorderColor = System.Drawing.Color.Black
            cBlendItems14.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems14.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnViewReport.ColorFillBlend = cBlendItems14
            Me.btnViewReport.Corners.All = 5
            Me.btnViewReport.Corners.LowerLeft = 5
            Me.btnViewReport.Corners.LowerRight = 5
            Me.btnViewReport.Corners.UpperLeft = 5
            Me.btnViewReport.Corners.UpperRight = 5
            Me.btnViewReport.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewReport.DesignerSelected = False
            Me.btnViewReport.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnViewReport.Image = CType(componentResourceManager.GetObject("btnViewReport.Image"), System.Drawing.Image)
            Me.btnViewReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnViewReport.ImageIndex = 0
            Dim cButton25 As CButtonLib.CButton = Me.btnViewReport
            size = New System.Drawing.Size(32, 32)
            cButton25.ImageSize = size
            Dim cButton26 As CButtonLib.CButton = Me.btnViewReport
            location = New System.Drawing.Point(7, 111)
            cButton26.Location = location
            Me.btnViewReport.Name = "btnViewReport"
            Dim cButton27 As CButtonLib.CButton = Me.btnViewReport
            size = New System.Drawing.Size(218, 50)
            cButton27.Size = size
            Me.btnViewReport.TabIndex = 5
            Me.btnViewReport.Text = "View Report Overall"
            Me.btnViewReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnViewReport.TextShadowShow = False
            Me.btnViewReport.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(5, 5)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(610, 41)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label15 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(265, 8)
            label15.Location = location
            Me.Label1.Name = "Label1"
            Dim label16 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(148, 25)
            label16.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "POS Reports"
            cBlendItems15.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems15.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnClose.ColorFillBlend = cBlendItems15
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.DesignerSelected = False
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageIndex = 0
            Dim cButton28 As CButtonLib.CButton = Me.btnClose
            size = New System.Drawing.Size(48, 48)
            cButton28.ImageSize = size
            Dim cButton29 As CButtonLib.CButton = Me.btnClose
            location = New System.Drawing.Point(713, 5)
            cButton29.Location = location
            Me.btnClose.Name = "btnClose"
            Dim cButton30 As CButtonLib.CButton = Me.btnClose
            size = New System.Drawing.Size(40, 41)
            cButton30.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = ""
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.BackColor = System.Drawing.Color.Transparent
            Me.btnReset.BorderColor = System.Drawing.Color.Black
            Me.btnReset.BorderShow = False
            cBlendItems16.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems16.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnReset.ColorFillBlend = cBlendItems16
            Me.btnReset.Corners.All = 5
            Me.btnReset.Corners.LowerLeft = 5
            Me.btnReset.Corners.LowerRight = 5
            Me.btnReset.Corners.UpperLeft = 5
            Me.btnReset.Corners.UpperRight = 5
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.DesignerSelected = True
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnReset.ImageIndex = 0
            Dim cButton31 As CButtonLib.CButton = Me.btnReset
            size = New System.Drawing.Size(32, 32)
            cButton31.ImageSize = size
            Dim cButton32 As CButtonLib.CButton = Me.btnReset
            location = New System.Drawing.Point(621, 5)
            cButton32.Location = location
            Me.btnReset.Name = "btnReset"
            Dim cButton33 As CButtonLib.CButton = Me.btnReset
            size = New System.Drawing.Size(86, 41)
            cButton33.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.TextShadowShow = False
            Me.btnReset.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(767, 625)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmPOSReport"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub

    End Class
End Namespace
