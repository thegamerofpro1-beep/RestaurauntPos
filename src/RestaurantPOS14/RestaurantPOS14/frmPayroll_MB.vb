Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmPayroll_MB
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel4")>
        Private _Panel4 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGetData")>
        Private _btnGetData As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByEmployee")>
        Private _txtSearchByEmployee As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("groupBox3")>
        Private _groupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label11")>
        Private _Label11 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label12")>
        Private _Label12 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPaymentID")>
        Private _txtPaymentID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label19")>
        Private _Label19 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSIN")>
        Private _txtSIN As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label17")>
        Private _Label17 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPaymentModeDetails")>
        Private _txtPaymentModeDetails As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label15")>
        Private _Label15 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCPPPer")>
        Private _txtCPPPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label14")>
        Private _Label14 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtNetPay")>
        Private _txtNetPay As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpPaymentDate")>
        Private _dtpPaymentDate As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMonthlySalary")>
        Private _txtMonthlySalary As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbPaymentmode")>
        Private _cmbPaymentmode As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmployeeName")>
        Private _txtEmployeeName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmployeeID")>
        Private _txtEmployeeID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPrint")>
        Private _btnPrint As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label20")>
        Private _Label20 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label16")>
        Private _Label16 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label13")>
        Private _Label13 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtFedTaxPer")>
        Private _txtFedTaxPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEIPer")>
        Private _txtEIPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtFedTax")>
        Private _txtFedTax As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEI")>
        Private _txtEI As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCPP")>
        Private _txtCPP As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbYear")>
        Private _cmbYear As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbMonth")>
        Private _cmbMonth As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVP")>
        Private _txtVP As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVPPer")>
        Private _txtVPPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label18")>
        Private _Label18 As System.Windows.Forms.Label

        Private s2 As String

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

        Friend Overridable Property Panel4 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel4 = value
            End Set
        End Property

        Friend Overridable Property btnDelete As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDelete
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnDelete_Click
                If Me._btnDelete IsNot Nothing Then
                    RemoveHandler Me._btnDelete.Click, value2
                End If

                Me._btnDelete = value
                If Me._btnDelete IsNot Nothing Then
                    AddHandler Me._btnDelete.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnClose As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClose
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
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

        Friend Overridable Property btnSave As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSave
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSave_Click
                If Me._btnSave IsNot Nothing Then
                    RemoveHandler Me._btnSave.Click, value2
                End If

                Me._btnSave = value
                If Me._btnSave IsNot Nothing Then
                    AddHandler Me._btnSave.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnNew As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnNew
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnNew_Click
                If Me._btnNew IsNot Nothing Then
                    RemoveHandler Me._btnNew.Click, value2
                End If

                Me._btnNew = value
                If Me._btnNew IsNot Nothing Then
                    AddHandler Me._btnNew.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._OpenFileDialog1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.OpenFileDialog)
                Me._OpenFileDialog1 = value
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

        Friend Overridable Property txtID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtID = value
            End Set
        End Property

        Friend Overridable Property lblUser As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUser
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUser = value
            End Set
        End Property

        Friend Overridable Property btnGetData As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnGetData
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnGetData_Click
                If Me._btnGetData IsNot Nothing Then
                    RemoveHandler Me._btnGetData.Click, value2
                End If

                Me._btnGetData = value
                If Me._btnGetData IsNot Nothing Then
                    AddHandler Me._btnGetData.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property dgw As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgw
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.dgw_MouseClick
                Dim value3 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.dgw_RowPostPaint
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.MouseClick, value2
                    RemoveHandler Me._dgw.RowPostPaint, value3
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.MouseClick, value2
                    AddHandler Me._dgw.RowPostPaint, value3
                End If
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

        Friend Overridable Property txtSearchByEmployee As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSearchByEmployee
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtEmployee_TextChanged
                If Me._txtSearchByEmployee IsNot Nothing Then
                    RemoveHandler Me._txtSearchByEmployee.TextChanged, value2
                End If

                Me._txtSearchByEmployee = value
                If Me._txtSearchByEmployee IsNot Nothing Then
                    AddHandler Me._txtSearchByEmployee.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property groupBox3 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._groupBox3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._groupBox3 = value
            End Set
        End Property

        Friend Overridable Property Label11 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label11
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label11 = value
            End Set
        End Property

        Friend Overridable Property Label12 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label12
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label12 = value
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

        Friend Overridable Property txtPaymentID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPaymentID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPaymentID = value
            End Set
        End Property

        Friend Overridable Property Label19 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label19
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label19 = value
            End Set
        End Property

        Friend Overridable Property txtSIN As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSIN
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSIN = value
            End Set
        End Property

        Friend Overridable Property Label17 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label17
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label17 = value
            End Set
        End Property

        Public Overridable Property txtPaymentModeDetails As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPaymentModeDetails
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPaymentModeDetails = value
            End Set
        End Property

        Friend Overridable Property Label15 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label15
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label15 = value
            End Set
        End Property

        Friend Overridable Property txtCPPPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCPPPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtCPPPer_KeyPress
                Dim value3 As System.EventHandler = AddressOf Me.txtCPPPer_TextChanged
                If Me._txtCPPPer IsNot Nothing Then
                    RemoveHandler Me._txtCPPPer.KeyPress, value2
                    RemoveHandler Me._txtCPPPer.TextChanged, value3
                End If

                Me._txtCPPPer = value
                If Me._txtCPPPer IsNot Nothing Then
                    AddHandler Me._txtCPPPer.KeyPress, value2
                    AddHandler Me._txtCPPPer.TextChanged, value3
                End If
            End Set
        End Property

        Friend Overridable Property Label14 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label14
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label14 = value
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

        Friend Overridable Property txtNetPay As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtNetPay
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtNetPay = value
            End Set
        End Property

        Friend Overridable Property dtpPaymentDate As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpPaymentDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpPaymentDate = value
            End Set
        End Property

        Friend Overridable Property txtMonthlySalary As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMonthlySalary
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtMonthlySalary_KeyPress
                If Me._txtMonthlySalary IsNot Nothing Then
                    RemoveHandler Me._txtMonthlySalary.KeyPress, value2
                End If

                Me._txtMonthlySalary = value
                If Me._txtMonthlySalary IsNot Nothing Then
                    AddHandler Me._txtMonthlySalary.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property cmbPaymentmode As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbPaymentmode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbPaymentmode = value
            End Set
        End Property

        Friend Overridable Property txtEmployeeName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmployeeName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEmployeeName = value
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

        Friend Overridable Property Label9 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label9 = value
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

        Friend Overridable Property txtEmployeeID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmployeeID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEmployeeID = value
            End Set
        End Property

        Friend Overridable Property btnPrint As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPrint
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnPrint_Click
                If Me._btnPrint IsNot Nothing Then
                    RemoveHandler Me._btnPrint.Click, value2
                End If

                Me._btnPrint = value
                If Me._btnPrint IsNot Nothing Then
                    AddHandler Me._btnPrint.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox4 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox4 = value
            End Set
        End Property

        Friend Overridable Property Label20 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label20
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label20 = value
            End Set
        End Property

        Friend Overridable Property Label16 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label16
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label16 = value
            End Set
        End Property

        Friend Overridable Property Label13 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label13
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label13 = value
            End Set
        End Property

        Friend Overridable Property txtFedTaxPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtFedTaxPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtFedTaxPer_KeyPress
                Dim value3 As System.EventHandler = AddressOf Me.txtFedTaxPer_TextChanged
                If Me._txtFedTaxPer IsNot Nothing Then
                    RemoveHandler Me._txtFedTaxPer.KeyPress, value2
                    RemoveHandler Me._txtFedTaxPer.TextChanged, value3
                End If

                Me._txtFedTaxPer = value
                If Me._txtFedTaxPer IsNot Nothing Then
                    AddHandler Me._txtFedTaxPer.KeyPress, value2
                    AddHandler Me._txtFedTaxPer.TextChanged, value3
                End If
            End Set
        End Property

        Friend Overridable Property txtEIPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEIPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtEIPer_KeyPress
                Dim value3 As System.EventHandler = AddressOf Me.txtEIPer_TextChanged
                If Me._txtEIPer IsNot Nothing Then
                    RemoveHandler Me._txtEIPer.KeyPress, value2
                    RemoveHandler Me._txtEIPer.TextChanged, value3
                End If

                Me._txtEIPer = value
                If Me._txtEIPer IsNot Nothing Then
                    AddHandler Me._txtEIPer.KeyPress, value2
                    AddHandler Me._txtEIPer.TextChanged, value3
                End If
            End Set
        End Property

        Friend Overridable Property txtFedTax As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtFedTax
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtFedTax = value
            End Set
        End Property

        Friend Overridable Property txtEI As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEI
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEI = value
            End Set
        End Property

        Friend Overridable Property txtCPP As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCPP
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCPP = value
            End Set
        End Property

        Friend Overridable Property cmbYear As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbYear
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbYear = value
            End Set
        End Property

        Friend Overridable Property cmbMonth As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbMonth
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbMonth = value
            End Set
        End Property

        Friend Overridable Property Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column2 = value
            End Set
        End Property

        Friend Overridable Property Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column3 = value
            End Set
        End Property

        Friend Overridable Property Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column1 = value
            End Set
        End Property

        Friend Overridable Property txtVP As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtVP
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtVP = value
            End Set
        End Property

        Friend Overridable Property Label10 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label10
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label10 = value
            End Set
        End Property

        Friend Overridable Property txtVPPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtVPPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtVPPer_KeyPress
                Dim value3 As System.EventHandler = AddressOf Me.txtVPPer_TextChanged
                If Me._txtVPPer IsNot Nothing Then
                    RemoveHandler Me._txtVPPer.KeyPress, value2
                    RemoveHandler Me._txtVPPer.TextChanged, value3
                End If

                Me._txtVPPer = value
                If Me._txtVPPer IsNot Nothing Then
                    AddHandler Me._txtVPPer.KeyPress, value2
                    AddHandler Me._txtVPPer.TextChanged, value3
                End If
            End Set
        End Property

        Friend Overridable Property Label18 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label18
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label18 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmAdvanceEntry_Load
            Call RestaurantPOS14.frmPayroll_MB.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPayroll_MB.__ENCList
                If RestaurantPOS14.frmPayroll_MB.__ENCList.Count = RestaurantPOS14.frmPayroll_MB.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPayroll_MB.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPayroll_MB.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPayroll_MB.__ENCList(num) = RestaurantPOS14.frmPayroll_MB.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPayroll_MB.__ENCList.RemoveRange(num, RestaurantPOS14.frmPayroll_MB.__ENCList.Count - num)
                    RestaurantPOS14.frmPayroll_MB.__ENCList.Capacity = RestaurantPOS14.frmPayroll_MB.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPayroll_MB.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.cmbMonth.SelectedIndex = -1
            Me.cmbYear.SelectedIndex = -1
            Me.txtEmployeeID.Text = ""
            Me.txtEmployeeName.Text = ""
            Me.txtSIN.Text = ""
            Me.txtMonthlySalary.Text = ""
            Me.txtCPPPer.Text = "0.00"
            Me.txtEIPer.Text = "0.00"
            Me.txtFedTaxPer.Text = "0.00"
            Me.txtCPP.Text = "0.00"
            Me.txtEI.Text = "0.00"
            Me.txtFedTax.Text = "0.00"
            Me.dtpPaymentDate.Value = Microsoft.VisualBasic.DateAndTime.Now
            Me.txtVPPer.Text = "0.00"
            Me.txtVP.Text = "0.00"
            Me.cmbPaymentmode.SelectedIndex = 0
            Me.txtPaymentModeDetails.Text = ""
            Me.txtNetPay.Text = "0.00"
            Me.txtSearchByEmployee.Text = ""
            Me.GetData()
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Payment") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Payment") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.btnDelete.Enabled = False
            Me.btnPrint.Enabled = False
            Me.dtpPaymentDate.Enabled = True
            Me.dgw.Enabled = True
            Me.auto()
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(UserID),RTRIM(Name),RTRIM(SSN) from Registration where Active='Yes' and PayrollType='Monthly Basis' order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtEmployeeID.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please retrieve employee id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtEmployeeID.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbMonth.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select month", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbMonth.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbYear.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select year", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.cmbYear.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Conversion.Val(Me.txtMonthlySalary.Text) = 0.0 Then
                    Call System.Windows.Forms.MessageBox.Show("Monthly salary must be greater than zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtMonthlySalary.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.Conversion.Val(Me.txtNetPay.Text) < 0.0 Then
                    Call System.Windows.Forms.MessageBox.Show("net pay should be more than 0", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * FROM Payroll_MB WHERE Month=@d1 and year=@d2 and UserID=@d3")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbMonth.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(Me.cmbYear.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtEmployeeID.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Salary already paid for selected month and year", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                Me.auto()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Payroll_MB( ID, PaymentID,Month,Year, PaymentDate, PaymentMode, UserID, GrossSalary, CPPPer, CPP, EIPer, EI, FedTaxPer, FedTax, NetPay, Remarks,VPPer,VP) values(" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text)) & ",@d1,@d2,@d3,@d4,@d5,@d6,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtPaymentID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.cmbMonth.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(Me.cmbYear.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.dtpPaymentDate.Value)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.cmbPaymentmode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtEmployeeID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Microsoft.VisualBasic.Conversion.Val(Me.txtMonthlySalary.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Microsoft.VisualBasic.Conversion.Val(Me.txtCPPPer.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Microsoft.VisualBasic.Conversion.Val(Me.txtCPP.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Microsoft.VisualBasic.Conversion.Val(Me.txtEIPer.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Microsoft.VisualBasic.Conversion.Val(Me.txtEI.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Microsoft.VisualBasic.Conversion.Val(Me.txtFedTaxPer.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Microsoft.VisualBasic.Conversion.Val(Me.txtFedTax.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Microsoft.VisualBasic.Conversion.Val(Me.txtNetPay.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", Me.txtPaymentModeDetails.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d18", Microsoft.VisualBasic.Conversion.Val(Me.txtVPPer.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d19", Microsoft.VisualBasic.Conversion.Val(Me.txtVP.Text))
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new payroll entry having payment id '" & Me.txtPaymentID.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Me.Print()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As System.EventArgs)
            Try
                If System.Windows.Forms.MessageBox.Show("Do you really want to delete this record?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
                    Me.DeleteRecord()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Payroll_MB where id=" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID"))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "deleted the Payroll record having payment id '" & Me.txtPaymentID.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.GetData()
                    Me.Reset()
                    Me.Reset()
                Else
                    Call System.Windows.Forms.MessageBox.Show("No Record found", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
            Me.Reset()
        End Sub

        Private Sub frmAdvanceEntry_Load(sender As Object, e As System.EventArgs)
            Me.GetData()
            Dim num As Integer = 2020
            Dim num2 As Integer
            Dim num3 As Integer
            Do
                Me.cmbYear.Items.Add(num)
                num = num + 1
                num2 = num
                num3 = 2040
            Loop While num2 <= num3
        End Sub

        Public Sub Compute()
            Try
                Dim value As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtMonthlySalary.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtCPPPer.Text) / 100.0
                value = System.Math.Round(value, 2)
                Me.txtCPP.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                Dim value2 As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtMonthlySalary.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtEIPer.Text) / 100.0
                value2 = System.Math.Round(value2, 2)
                Me.txtEI.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                Dim value3 As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtMonthlySalary.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtFedTaxPer.Text) / 100.0
                value3 = System.Math.Round(value3, 2)
                Me.txtFedTax.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value3)
                Dim value4 As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtMonthlySalary.Text) * Microsoft.VisualBasic.Conversion.Val(Me.txtVPPer.Text) / 100.0
                value4 = System.Math.Round(value4, 2)
                Me.txtVP.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value4)
                Dim value5 As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtMonthlySalary.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtEI.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtCPP.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtFedTax.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtVP.Text)
                value5 = System.Math.Round(value5, 2)
                Me.txtNetPay.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value5)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    Me.txtEmployeeID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.txtEmployeeName.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtSIN.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub dgw_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
            Dim text As String =(e.RowIndex + 1).ToString()
            Dim sizeF As System.Drawing.SizeF = e.Graphics.MeasureString(text, MyBase.Font)
            If Me.dgw.RowHeadersWidth < System.Convert.ToInt32(sizeF.Width + 20F) Then
                Me.dgw.RowHeadersWidth = System.Convert.ToInt32(sizeF.Width + 20F)
            End If

            Dim controlText As System.Drawing.Brush = System.Drawing.SystemBrushes.ControlText
            e.Graphics.DrawString(text, MyBase.Font, controlText, e.RowBounds.Location.X + 15, CSng(e.RowBounds.Location.Y) + (CSng(e.RowBounds.Height) - sizeF.Height) / 2F)
        End Sub

        Private Sub auto()
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(ID) FROM Payroll_MB")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                Dim num As Integer = 1
                Me.txtID.Text = num.ToString()
                Me.txtPaymentID.Text = "P-" & num.ToString() & "/" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(System.DateTime.Today.Year)
            Else
                Dim num2 As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                Me.txtID.Text = num2.ToString()
                Me.txtPaymentID.Text = "P-" & num2.ToString() & "/" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(System.DateTime.Today.Year)
            End If

            RestaurantPOS14.ModClasses.cmd.Dispose()
            RestaurantPOS14.ModClasses.con.Close()
            RestaurantPOS14.ModClasses.con.Dispose()
        End Sub

        Private Sub btnGetData_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmPayroll_MBRecord.lblSet.Text = "Payment"
            RestaurantPOS14.My.MyProject.Forms.frmPayroll_MBRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmPayroll_MBRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmPayroll_MBRecord.ShowDialog()
        End Sub

        Private Sub txtEmployee_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(UserID),RTRIM(Name),RTRIM(SIN) from Registration where Active='Yes' and Name like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtSearchByEmployee.Text) & "%' and PayrollType='Monthly Basis' order by Name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Print()
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptSalarySlip_MB2 As RestaurantPOS14.rptSalarySlip_MB = New RestaurantPOS14.rptSalarySlip_MB()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT VPPer,VP,Payroll_MB.ID, Payroll_MB.PaymentID, Payroll_MB.PaymentDate, Payroll_MB.PaymentMode, Payroll_MB.UserID, Payroll_MB.GrossSalary, Payroll_MB.CPPPer, Payroll_MB.CPP, Payroll_MB.EIPer, Payroll_MB.EI, Payroll_MB.FedTaxPer,Payroll_MB.FedTax, Payroll_MB.NetPay, Payroll_MB.Month, Payroll_MB.Year, Payroll_MB.Remarks, Registration.UserID AS Expr1, Registration.UserType, Registration.Password, Registration.Name, Registration.ContactNo,Registration.EmailID, Registration.JoiningDate, Registration.Active, Registration.SSN FROM Payroll_MB INNER JOIN Registration ON Payroll_MB.UserID = Registration.UserID where PaymentID=@d1"
                sqlCommand.Parameters.AddWithValue("@d1", Me.txtPaymentID.Text)
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "Payroll_MB")
                sqlDataAdapter.Fill(dataSet, "Registration")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                rptSalarySlip_MB2.SetDataSource(dataSet)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptSalarySlip_MB2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
                rptSalarySlip_MB2.Close()
                rptSalarySlip_MB2.Dispose()
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub btnPrint_Click(sender As Object, e As System.EventArgs)
            Me.Print()
        End Sub

        Private Sub txtRate_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtCPPPer_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtEIPer_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtFedTaxPer_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtCPPPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtCPPPer.Text
                Dim selectionStart As Integer = Me.txtCPPPer.SelectionStart
                Dim selectionLength As Integer = Me.txtCPPPer.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtEIPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtEIPer.Text
                Dim selectionStart As Integer = Me.txtEIPer.SelectionStart
                Dim selectionLength As Integer = Me.txtEIPer.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtFedTaxPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtFedTaxPer.Text
                Dim selectionStart As Integer = Me.txtFedTaxPer.SelectionStart
                Dim selectionLength As Integer = Me.txtFedTaxPer.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtMonthlySalary_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtMonthlySalary.Text
                Dim selectionStart As Integer = Me.txtMonthlySalary.SelectionStart
                Dim selectionLength As Integer = Me.txtMonthlySalary.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtVPPer_TextChanged(sender As Object, e As System.EventArgs)
            Me.Compute()
        End Sub

        Private Sub txtVPPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtVPPer.Text
                Dim selectionStart As Integer = Me.txtVPPer.SelectionStart
                Dim selectionLength As Integer = Me.txtVPPer.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim s As String = text
                Dim num As Integer = 0
                If Integer.TryParse(s, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim s2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(s2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPayroll_MB))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtSearchByEmployee = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtVP = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtVPPer = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtFedTax = New System.Windows.Forms.TextBox()
            Me.txtEI = New System.Windows.Forms.TextBox()
            Me.txtCPP = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtFedTaxPer = New System.Windows.Forms.TextBox()
            Me.txtEIPer = New System.Windows.Forms.TextBox()
            Me.txtEmployeeID = New System.Windows.Forms.TextBox()
            Me.txtPaymentID = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.txtSIN = New System.Windows.Forms.TextBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.txtPaymentModeDetails = New System.Windows.Forms.TextBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtCPPPer = New System.Windows.Forms.TextBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtNetPay = New System.Windows.Forms.TextBox()
            Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
            Me.txtMonthlySalary = New System.Windows.Forms.TextBox()
            Me.cmbPaymentmode = New System.Windows.Forms.ComboBox()
            Me.txtEmployeeName = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.cmbYear = New System.Windows.Forms.ComboBox()
            Me.cmbMonth = New System.Windows.Forms.ComboBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.groupBox3)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(967, 570)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox4.Controls.Add(Me.Panel4)
            Me.GroupBox4.Controls.Add(Me.btnSave)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(837, 62)
            groupBox.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(125, 252)
            groupBox2.Size = size
            Me.GroupBox4.TabIndex = 300
            Me.GroupBox4.TabStop = False
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.btnPrint)
            Me.Panel4.Controls.Add(Me.btnNew)
            Me.Panel4.Controls.Add(Me.btnGetData)
            Me.Panel4.Controls.Add(Me.btnDelete)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel4
            location = New System.Drawing.Point(6, 16)
            panel3.Location = location
            Me.Panel4.Name = "Panel4"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel4
            size = New System.Drawing.Size(112, 184)
            panel4.Size = size
            Me.Panel4.TabIndex = 1
            Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrint.Enabled = False
            Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPrint.Image = CType(componentResourceManager.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnPrint
            location = New System.Drawing.Point(9, 137)
            button.Location = location
            Me.btnPrint.Name = "btnPrint"
            Dim button2 As System.Windows.Forms.Button = Me.btnPrint
            size = New System.Drawing.Size(90, 39)
            button2.Size = size
            Me.btnPrint.TabIndex = 6
            Me.btnPrint.Text = "Print"
            Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPrint.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(9, 6)
            button3.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button4 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(90, 39)
            button4.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(9, 93)
            button5.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button6 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(90, 39)
            button6.Size = size
            Me.btnGetData.TabIndex = 4
            Me.btnGetData.Text = "Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(9, 48)
            button7.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button8 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(90, 39)
            button8.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(6, 206)
            button9.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button10 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(112, 38)
            button10.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save+Print"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(886, 3)
            button11.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button12 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(76, 45)
            button12.Size = size
            Me.btnClose.TabIndex = 5
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.txtSearchByEmployee)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(438, 62)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(245, 54)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 299
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search by Employee Name"
            Dim textBox As System.Windows.Forms.TextBox = Me.txtSearchByEmployee
            location = New System.Drawing.Point(17, 21)
            textBox.Location = location
            Me.txtSearchByEmployee.Name = "txtSearchByEmployee"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtSearchByEmployee
            size = New System.Drawing.Size(217, 20)
            textBox2.Size = size
            Me.txtSearchByEmployee.TabIndex = 298
            Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox2.Controls.Add(Me.txtVP)
            Me.GroupBox2.Controls.Add(Me.Label10)
            Me.GroupBox2.Controls.Add(Me.txtVPPer)
            Me.GroupBox2.Controls.Add(Me.Label18)
            Me.GroupBox2.Controls.Add(Me.txtFedTax)
            Me.GroupBox2.Controls.Add(Me.txtEI)
            Me.GroupBox2.Controls.Add(Me.txtCPP)
            Me.GroupBox2.Controls.Add(Me.Label20)
            Me.GroupBox2.Controls.Add(Me.Label16)
            Me.GroupBox2.Controls.Add(Me.Label13)
            Me.GroupBox2.Controls.Add(Me.txtFedTaxPer)
            Me.GroupBox2.Controls.Add(Me.txtEIPer)
            Me.GroupBox2.Controls.Add(Me.txtEmployeeID)
            Me.GroupBox2.Controls.Add(Me.txtPaymentID)
            Me.GroupBox2.Controls.Add(Me.Label19)
            Me.GroupBox2.Controls.Add(Me.txtSIN)
            Me.GroupBox2.Controls.Add(Me.lblUser)
            Me.GroupBox2.Controls.Add(Me.Label17)
            Me.GroupBox2.Controls.Add(Me.txtID)
            Me.GroupBox2.Controls.Add(Me.txtPaymentModeDetails)
            Me.GroupBox2.Controls.Add(Me.Label15)
            Me.GroupBox2.Controls.Add(Me.txtCPPPer)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.txtNetPay)
            Me.GroupBox2.Controls.Add(Me.dtpPaymentDate)
            Me.GroupBox2.Controls.Add(Me.txtMonthlySalary)
            Me.GroupBox2.Controls.Add(Me.cmbPaymentmode)
            Me.GroupBox2.Controls.Add(Me.txtEmployeeName)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(4, 117)
            groupBox5.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(423, 444)
            groupBox6.Size = size
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.txtVP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtVP
            location = New System.Drawing.Point(265, 232)
            textBox3.Location = location
            Me.txtVP.Name = "txtVP"
            Me.txtVP.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtVP
            size = New System.Drawing.Size(91, 20)
            textBox4.Size = size
            Me.txtVP.TabIndex = 16
            Me.txtVP.Text = "0.00"
            Me.txtVP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(234, 230)
            label.Location = location
            Me.Label10.Name = "Label10"
            Dim label2 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(23, 20)
            label2.Size = size
            Me.Label10.TabIndex = 316
            Me.Label10.Text = "%"
            Me.txtVPPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtVPPer
            location = New System.Drawing.Point(169, 230)
            textBox5.Location = location
            Me.txtVPPer.Name = "txtVPPer"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtVPPer
            size = New System.Drawing.Size(59, 20)
            textBox6.Size = size
            Me.txtVPPer.TabIndex = 8
            Me.txtVPPer.Text = "0.00"
            Me.txtVPPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label18
            location = New System.Drawing.Point(26, 230)
            label3.Location = location
            Me.Label18.Name = "Label18"
            Dim label4 As System.Windows.Forms.Label = Me.Label18
            size = New System.Drawing.Size(76, 13)
            label4.Size = size
            Me.Label18.TabIndex = 315
            Me.Label18.Text = "Vacation Pay :"
            Me.txtFedTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtFedTax
            location = New System.Drawing.Point(265, 206)
            textBox7.Location = location
            Me.txtFedTax.Name = "txtFedTax"
            Me.txtFedTax.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtFedTax
            size = New System.Drawing.Size(91, 20)
            textBox8.Size = size
            Me.txtFedTax.TabIndex = 15
            Me.txtFedTax.Text = "0.00"
            Me.txtFedTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtEI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtEI
            location = New System.Drawing.Point(265, 180)
            textBox9.Location = location
            Me.txtEI.Name = "txtEI"
            Me.txtEI.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtEI
            size = New System.Drawing.Size(91, 20)
            textBox10.Size = size
            Me.txtEI.TabIndex = 14
            Me.txtEI.Text = "0.00"
            Me.txtEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtCPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtCPP
            location = New System.Drawing.Point(265, 152)
            textBox11.Location = location
            Me.txtCPP.Name = "txtCPP"
            Me.txtCPP.[ReadOnly] = True
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtCPP
            size = New System.Drawing.Size(91, 20)
            textBox12.Size = size
            Me.txtCPP.TabIndex = 13
            Me.txtCPP.Text = "0.00"
            Me.txtCPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label20
            location = New System.Drawing.Point(234, 204)
            label5.Location = location
            Me.Label20.Name = "Label20"
            Dim label6 As System.Windows.Forms.Label = Me.Label20
            size = New System.Drawing.Size(23, 20)
            label6.Size = size
            Me.Label20.TabIndex = 308
            Me.Label20.Text = "%"
            Me.Label16.AutoSize = True
            Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label16
            location = New System.Drawing.Point(234, 178)
            label7.Location = location
            Me.Label16.Name = "Label16"
            Dim label8 As System.Windows.Forms.Label = Me.Label16
            size = New System.Drawing.Size(23, 20)
            label8.Size = size
            Me.Label16.TabIndex = 307
            Me.Label16.Text = "%"
            Me.Label13.AutoSize = True
            Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label9 As System.Windows.Forms.Label = Me.Label13
            location = New System.Drawing.Point(234, 152)
            label9.Location = location
            Me.Label13.Name = "Label13"
            Dim label10 As System.Windows.Forms.Label = Me.Label13
            size = New System.Drawing.Size(23, 20)
            label10.Size = size
            Me.Label13.TabIndex = 306
            Me.Label13.Text = "%"
            Me.txtFedTaxPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtFedTaxPer
            location = New System.Drawing.Point(169, 204)
            textBox13.Location = location
            Me.txtFedTaxPer.Name = "txtFedTaxPer"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtFedTaxPer
            size = New System.Drawing.Size(59, 20)
            textBox14.Size = size
            Me.txtFedTaxPer.TabIndex = 7
            Me.txtFedTaxPer.Text = "0.00"
            Me.txtFedTaxPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtEIPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtEIPer
            location = New System.Drawing.Point(169, 178)
            textBox15.Location = location
            Me.txtEIPer.Name = "txtEIPer"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtEIPer
            size = New System.Drawing.Size(59, 20)
            textBox16.Size = size
            Me.txtEIPer.TabIndex = 6
            Me.txtEIPer.Text = "0.00"
            Me.txtEIPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtEmployeeID
            location = New System.Drawing.Point(169, 47)
            textBox17.Location = location
            Me.txtEmployeeID.Name = "txtEmployeeID"
            Me.txtEmployeeID.[ReadOnly] = True
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtEmployeeID
            size = New System.Drawing.Size(155, 20)
            textBox18.Size = size
            Me.txtEmployeeID.TabIndex = 1
            Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox19 As System.Windows.Forms.TextBox = Me.txtPaymentID
            location = New System.Drawing.Point(169, 21)
            textBox19.Location = location
            Me.txtPaymentID.Name = "txtPaymentID"
            Me.txtPaymentID.[ReadOnly] = True
            Dim textBox20 As System.Windows.Forms.TextBox = Me.txtPaymentID
            size = New System.Drawing.Size(155, 20)
            textBox20.Size = size
            Me.txtPaymentID.TabIndex = 0
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label11 As System.Windows.Forms.Label = Me.Label19
            location = New System.Drawing.Point(26, 21)
            label11.Location = location
            Me.Label19.Name = "Label19"
            Dim label12 As System.Windows.Forms.Label = Me.Label19
            size = New System.Drawing.Size(68, 13)
            label12.Size = size
            Me.Label19.TabIndex = 50
            Me.Label19.Text = "Payment ID :"
            Me.txtSIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtSIN
            location = New System.Drawing.Point(169, 99)
            textBox21.Location = location
            Me.txtSIN.Name = "txtSIN"
            Me.txtSIN.[ReadOnly] = True
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtSIN
            size = New System.Drawing.Size(201, 20)
            textBox22.Size = size
            Me.txtSIN.TabIndex = 3
            Me.lblUser.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(379, 303)
            label13.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label14 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label14.Size = size
            Me.lblUser.TabIndex = 293
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label15 As System.Windows.Forms.Label = Me.Label17
            location = New System.Drawing.Point(27, 99)
            label15.Location = location
            Me.Label17.Name = "Label17"
            Dim label16 As System.Windows.Forms.Label = Me.Label17
            size = New System.Drawing.Size(38, 13)
            label16.Size = size
            Me.Label17.TabIndex = 44
            Me.Label17.Text = "SIN# :"
            Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(383, 280)
            textBox23.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(23, 20)
            textBox24.Size = size
            Me.txtID.TabIndex = 292
            Me.txtID.Visible = False
            Me.txtPaymentModeDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox25 As System.Windows.Forms.TextBox = Me.txtPaymentModeDetails
            location = New System.Drawing.Point(169, 309)
            textBox25.Location = location
            Me.txtPaymentModeDetails.Multiline = True
            Me.txtPaymentModeDetails.Name = "txtPaymentModeDetails"
            Me.txtPaymentModeDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Dim textBox26 As System.Windows.Forms.TextBox = Me.txtPaymentModeDetails
            size = New System.Drawing.Size(237, 94)
            textBox26.Size = size
            Me.txtPaymentModeDetails.TabIndex = 11
            Me.Label15.AutoSize = True
            Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label17 As System.Windows.Forms.Label = Me.Label15
            location = New System.Drawing.Point(27, 334)
            label17.Location = location
            Me.Label15.Name = "Label15"
            Dim label18 As System.Windows.Forms.Label = Me.Label15
            size = New System.Drawing.Size(119, 13)
            label18.Size = size
            Me.Label15.TabIndex = 35
            Me.Label15.Text = "Payment Mode Details :"
            Me.txtCPPPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox27 As System.Windows.Forms.TextBox = Me.txtCPPPer
            location = New System.Drawing.Point(169, 152)
            textBox27.Location = location
            Me.txtCPPPer.Name = "txtCPPPer"
            Dim textBox28 As System.Windows.Forms.TextBox = Me.txtCPPPer
            size = New System.Drawing.Size(59, 20)
            textBox28.Size = size
            Me.txtCPPPer.TabIndex = 5
            Me.txtCPPPer.Text = "0.00"
            Me.txtCPPPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label19 As System.Windows.Forms.Label = Me.Label14
            location = New System.Drawing.Point(26, 152)
            label19.Location = location
            Me.Label14.Name = "Label14"
            Dim label20 As System.Windows.Forms.Label = Me.Label14
            size = New System.Drawing.Size(34, 13)
            label20.Size = size
            Me.Label14.TabIndex = 32
            Me.Label14.Text = "CPP :"
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label21 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(26, 204)
            label21.Location = location
            Me.Label3.Name = "Label3"
            Dim label22 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(52, 13)
            label22.Size = size
            Me.Label3.TabIndex = 28
            Me.Label3.Text = "Fed Tax :"
            Me.txtNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox29 As System.Windows.Forms.TextBox = Me.txtNetPay
            location = New System.Drawing.Point(169, 409)
            textBox29.Location = location
            Me.txtNetPay.Name = "txtNetPay"
            Me.txtNetPay.[ReadOnly] = True
            Dim textBox30 As System.Windows.Forms.TextBox = Me.txtNetPay
            size = New System.Drawing.Size(109, 20)
            textBox30.Size = size
            Me.txtNetPay.TabIndex = 12
            Me.dtpPaymentDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpPaymentDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpPaymentDate
            location = New System.Drawing.Point(169, 256)
            dateTimePicker.Location = location
            Me.dtpPaymentDate.Name = "dtpPaymentDate"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpPaymentDate
            size = New System.Drawing.Size(105, 20)
            dateTimePicker2.Size = size
            Me.dtpPaymentDate.TabIndex = 9
            Me.txtMonthlySalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox31 As System.Windows.Forms.TextBox = Me.txtMonthlySalary
            location = New System.Drawing.Point(169, 125)
            textBox31.Location = location
            Me.txtMonthlySalary.Name = "txtMonthlySalary"
            Dim textBox32 As System.Windows.Forms.TextBox = Me.txtMonthlySalary
            size = New System.Drawing.Size(109, 20)
            textBox32.Size = size
            Me.txtMonthlySalary.TabIndex = 4
            Me.cmbPaymentmode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cmbPaymentmode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbPaymentmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPaymentmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbPaymentmode.FormattingEnabled = True
            Me.cmbPaymentmode.Items.AddRange(New Object(2) {"By Cash", "By Cheque", "By Online Transfer"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbPaymentmode
            location = New System.Drawing.Point(169, 282)
            comboBox.Location = location
            Me.cmbPaymentmode.Name = "cmbPaymentmode"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbPaymentmode
            size = New System.Drawing.Size(169, 21)
            comboBox2.Size = size
            Me.cmbPaymentmode.TabIndex = 10
            Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox33 As System.Windows.Forms.TextBox = Me.txtEmployeeName
            location = New System.Drawing.Point(169, 73)
            textBox33.Location = location
            Me.txtEmployeeName.Name = "txtEmployeeName"
            Me.txtEmployeeName.[ReadOnly] = True
            Dim textBox34 As System.Windows.Forms.TextBox = Me.txtEmployeeName
            size = New System.Drawing.Size(201, 20)
            textBox34.Size = size
            Me.txtEmployeeName.TabIndex = 2
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label23 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(27, 409)
            label23.Location = location
            Me.Label8.Name = "Label8"
            Dim label24 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(51, 13)
            label24.Size = size
            Me.Label8.TabIndex = 17
            Me.Label8.Text = "Net Pay :"
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label25 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(27, 178)
            label25.Location = location
            Me.Label5.Name = "Label5"
            Dim label26 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(23, 13)
            label26.Size = size
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "EI :"
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label27 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(27, 125)
            label27.Location = location
            Me.Label6.Name = "Label6"
            Dim label28 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(82, 13)
            label28.Size = size
            Me.Label6.TabIndex = 15
            Me.Label6.Text = "Monthly Salary :"
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label29 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(26, 254)
            label29.Location = location
            Me.Label7.Name = "Label7"
            Dim label30 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(80, 13)
            label30.Size = size
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Payment Date :"
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label31 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(26, 47)
            label31.Location = location
            Me.Label9.Name = "Label9"
            Dim label32 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(73, 13)
            label32.Size = size
            Me.Label9.TabIndex = 11
            Me.Label9.Text = "Employee ID :"
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label33 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(27, 282)
            label33.Location = location
            Me.Label4.Name = "Label4"
            Dim label34 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(98, 13)
            label34.Size = size
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "Mode Of Payment :"
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label35 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(26, 73)
            label35.Location = location
            Me.Label2.Name = "Label2"
            Dim label36 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(90, 13)
            label36.Size = size
            Me.Label2.TabIndex = 10
            Me.Label2.Text = "Employee Name :"
            Me.groupBox3.BackColor = System.Drawing.Color.Transparent
            Me.groupBox3.Controls.Add(Me.cmbYear)
            Me.groupBox3.Controls.Add(Me.cmbMonth)
            Me.groupBox3.Controls.Add(Me.Label11)
            Me.groupBox3.Controls.Add(Me.Label12)
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.groupBox3
            location = New System.Drawing.Point(4, 40)
            groupBox7.Location = location
            Me.groupBox3.Name = "groupBox3"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.groupBox3
            size = New System.Drawing.Size(274, 75)
            groupBox8.Size = size
            Me.groupBox3.TabIndex = 0
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Payment"
            Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbYear.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbYear
            location = New System.Drawing.Point(173, 42)
            comboBox3.Location = location
            Me.cmbYear.Name = "cmbYear"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbYear
            size = New System.Drawing.Size(84, 21)
            comboBox4.Size = size
            Me.cmbYear.TabIndex = 1
            Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbMonth.FormattingEnabled = True
            Me.cmbMonth.Items.AddRange(New Object(11) {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
            Dim comboBox5 As System.Windows.Forms.ComboBox = Me.cmbMonth
            location = New System.Drawing.Point(16, 42)
            comboBox5.Location = location
            Me.cmbMonth.Name = "cmbMonth"
            Dim comboBox6 As System.Windows.Forms.ComboBox = Me.cmbMonth
            size = New System.Drawing.Size(151, 21)
            comboBox6.Size = size
            Me.cmbMonth.TabIndex = 0
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label37 As System.Windows.Forms.Label = Me.Label11
            location = New System.Drawing.Point(13, 21)
            label37.Location = location
            Me.Label11.Name = "Label11"
            Dim label38 As System.Windows.Forms.Label = Me.Label11
            size = New System.Drawing.Size(43, 13)
            label38.Size = size
            Me.Label11.TabIndex = 9
            Me.Label11.Text = "Month :"
            Me.Label12.AutoSize = True
            Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label39 As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(170, 22)
            label39.Location = location
            Me.Label12.Name = "Label12"
            Dim label40 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(35, 13)
            label40.Size = size
            Me.Label12.TabIndex = 10
            Me.Label12.Text = "Year :"
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.BackgroundColor = System.Drawing.Color.White
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 24
            Me.dgw.Columns.AddRange(Me.Column2, Me.Column3, Me.Column1)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64)
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(438, 122)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(382, 437)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 295
            Me.Column2.HeaderText = "Employee ID"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Width = 72
            Me.Column3.HeaderText = "Employee Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 150
            Me.Column1.HeaderText = "SIN#"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Width = 130
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 3)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(876, 34)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label41 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(378, 5)
            label41.Location = location
            Me.Label1.Name = "Label1"
            Dim label42 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(73, 24)
            label42.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Payroll"
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(972, 575)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmPayroll_MB"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub

    End Class
End Namespace
