Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports MetroFramework
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmFundTransfer
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBranchName")>
        Private _txtBranchName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtIFSCCode")>
        Private _txtIFSCCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSwiftCode")>
        Private _txtSwiftCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label14")>
        Private _Label14 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBank")>
        Private _txtBank As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label12")>
        Private _Label12 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAccountName")>
        Private _txtAccountName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDate")>
        Private _dtpDate As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAmount")>
        Private _txtAmount As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtNotes")>
        Private _txtNotes As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtOperator")>
        Private _txtOperator As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label11")>
        Private _Label11 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbAccountNo")>
        Private _cmbAccountNo As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTo")>
        Private _DateTo As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateFrom")>
        Private _DateFrom As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("label9")>
        Private _label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("groupBox5")>
        Private _groupBox5 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAccNo")>
        Private _txtAccNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel5")>
        Private _Panel5 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox6")>
        Private _GroupBox6 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBank1")>
        Private _txtBank1 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbAccountNo1")>
        Private _cmbAccountNo1 As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label13")>
        Private _Label13 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label15")>
        Private _Label15 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSwiftCode1")>
        Private _txtSwiftCode1 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtIFSCCode1")>
        Private _txtIFSCCode1 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label16")>
        Private _Label16 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBranchName1")>
        Private _txtBranchName1 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label17")>
        Private _Label17 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label18")>
        Private _Label18 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAccountName1")>
        Private _txtAccountName1 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label19")>
        Private _Label19 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label20")>
        Private _Label20 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBalanceAmount")>
        Private _txtBalanceAmount As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        Friend Overridable Property txtBranchName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBranchName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBranchName = value
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

        Friend Overridable Property txtIFSCCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtIFSCCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtIFSCCode = value
            End Set
        End Property

        Friend Overridable Property txtSwiftCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSwiftCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSwiftCode = value
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

        Friend Overridable Property txtBank As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBank
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBank = value
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

        Friend Overridable Property txtAccountName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAccountName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAccountName = value
            End Set
        End Property

        Friend Overridable Property DataGridView1 As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.DataGridView1_MouseClick
                Dim value3 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.DataGridView1_RowPostPaint
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.MouseClick, value2
                    RemoveHandler Me._DataGridView1.RowPostPaint, value3
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.MouseClick, value2
                    AddHandler Me._DataGridView1.RowPostPaint, value3
                End If
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

        Friend Overridable Property dtpDate As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDate = value
            End Set
        End Property

        Friend Overridable Property txtAmount As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAmount
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtAmount_KeyPress
                If Me._txtAmount IsNot Nothing Then
                    RemoveHandler Me._txtAmount.KeyPress, value2
                End If

                Me._txtAmount = value
                If Me._txtAmount IsNot Nothing Then
                    AddHandler Me._txtAmount.KeyPress, value2
                End If
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

        Friend Overridable Property txtNotes As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtNotes
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtNotes = value
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

        Friend Overridable Property txtOperator As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtOperator
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtOperator = value
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

        Friend Overridable Property cmbAccountNo As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbAccountNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbAccountNo_SelectedIndexChanged
                If Me._cmbAccountNo IsNot Nothing Then
                    RemoveHandler Me._cmbAccountNo.SelectedIndexChanged, value2
                End If

                Me._cmbAccountNo = value
                If Me._cmbAccountNo IsNot Nothing Then
                    AddHandler Me._cmbAccountNo.SelectedIndexChanged, value2
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

        Friend Overridable Property Button1 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
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

        Friend Overridable Property DateTo As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTo = value
            End Set
        End Property

        Friend Overridable Property DateFrom As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateFrom
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateFrom = value
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

        Friend Overridable Property label9 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._label9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._label9 = value
            End Set
        End Property

        Friend Overridable Property groupBox5 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._groupBox5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._groupBox5 = value
            End Set
        End Property

        Friend Overridable Property txtAccNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAccNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtAccNo_TextChanged
                If Me._txtAccNo IsNot Nothing Then
                    RemoveHandler Me._txtAccNo.TextChanged, value2
                End If

                Me._txtAccNo = value
                If Me._txtAccNo IsNot Nothing Then
                    AddHandler Me._txtAccNo.TextChanged, value2
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

        Friend Overridable Property btnExportExcel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnExportExcel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnExportExcel_Click
                If Me._btnExportExcel IsNot Nothing Then
                    RemoveHandler Me._btnExportExcel.Click, value2
                End If

                Me._btnExportExcel = value
                If Me._btnExportExcel IsNot Nothing Then
                    AddHandler Me._btnExportExcel.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnReset As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnReset
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
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

        Friend Overridable Property GroupBox6 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox6 = value
            End Set
        End Property

        Friend Overridable Property txtBank1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBank1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBank1 = value
            End Set
        End Property

        Friend Overridable Property cmbAccountNo1 As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbAccountNo1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbAccountNo1_SelectedIndexChanged
                If Me._cmbAccountNo1 IsNot Nothing Then
                    RemoveHandler Me._cmbAccountNo1.SelectedIndexChanged, value2
                End If

                Me._cmbAccountNo1 = value
                If Me._cmbAccountNo1 IsNot Nothing Then
                    AddHandler Me._cmbAccountNo1.SelectedIndexChanged, value2
                End If
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

        Friend Overridable Property txtSwiftCode1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSwiftCode1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSwiftCode1 = value
            End Set
        End Property

        Friend Overridable Property txtIFSCCode1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtIFSCCode1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtIFSCCode1 = value
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

        Friend Overridable Property txtBranchName1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBranchName1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBranchName1 = value
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

        Friend Overridable Property txtAccountName1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAccountName1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAccountName1 = value
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

        Friend Overridable Property txtBalanceAmount As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBalanceAmount
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBalanceAmount = value
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

        Friend Overridable Property Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column4 = value
            End Set
        End Property

        Friend Overridable Property Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column5 = value
            End Set
        End Property

        Friend Overridable Property Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column6 = value
            End Set
        End Property

        Friend Overridable Property Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column7 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmFundTransfer_Load
            Call RestaurantPOS14.frmFundTransfer.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmFundTransfer.__ENCList
                If RestaurantPOS14.frmFundTransfer.__ENCList.Count = RestaurantPOS14.frmFundTransfer.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmFundTransfer.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmFundTransfer.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmFundTransfer.__ENCList(num) = RestaurantPOS14.frmFundTransfer.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmFundTransfer.__ENCList.RemoveRange(num, RestaurantPOS14.frmFundTransfer.__ENCList.Count - num)
                    RestaurantPOS14.frmFundTransfer.__ENCList.Capacity = RestaurantPOS14.frmFundTransfer.__ENCList.Count
                End If

                Call RestaurantPOS14.frmFundTransfer.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub auto()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(ID) FROM FundTransfer")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                    Me.txtID.Text = 1.ToString()
                Else
                    Dim num As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                    Me.txtID.Text = num.ToString()
                End If

                RestaurantPOS14.ModClasses.cmd.Dispose()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con.Dispose()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Clear()
            Me.DateFrom.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTo.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.txtAccNo.Text = ""
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Banking") Then
                Me.Getdata()
                Me.GroupBox4.Enabled = True
                Me.groupBox5.Enabled = True
            Else
                Me.DataGridView1.Rows.Clear()
                Me.GroupBox4.Enabled = False
                Me.groupBox5.Enabled = False
            End If
        End Sub

        Public Sub Reset()
            Me.txtOperator.Text = ""
            Me.txtAccountName.Text = ""
            Me.txtAccountName1.Text = ""
            Me.cmbAccountNo.SelectedIndex = -1
            Me.cmbAccountNo1.SelectedIndex = -1
            Me.txtAmount.Text = ""
            Me.dtpDate.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.txtNotes.Text = ""
            Me.txtIFSCCode.Text = ""
            Me.txtSwiftCode.Text = ""
            Me.txtBranchName.Text = ""
            Me.txtBank.Text = ""
            Me.txtIFSCCode1.Text = ""
            Me.txtSwiftCode1.Text = ""
            Me.txtBranchName1.Text = ""
            Me.txtBalanceAmount.Text = ""
            Me.txtBank1.Text = ""
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Banking") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Banking") Then
                Me.Getdata()
                Me.GroupBox4.Enabled = True
                Me.groupBox5.Enabled = True
            Else
                Me.DataGridView1.Rows.Clear()
                Me.GroupBox4.Enabled = False
                Me.groupBox5.Enabled = False
            End If

            Me.btnDelete.Enabled = False
            Me.txtOperator.Text = Me.lblUser.Text
            Me.txtOperator.Focus()
            Me.Clear()
            Me.auto()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtOperator.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter operator", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtOperator.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAmount.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter amount", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAmount.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text) <= 0.0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Amount must be greater than zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAmount.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbAccountNo.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please select account no. from", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbAccountNo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbAccountNo1.Text, "", TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please select account no. to", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbAccountNo1.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Conversion.Val(Me.txtBalanceAmount.Text) < Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text) Then
                MetroFramework.MetroMessageBox.Show(Me, "Transferred Amount must be less than or equal to balance amount", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Me.txtAmount.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbAccountNo.Text, Me.cmbAccountNo1.Text, TextCompare:=False) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Both the accounts must be different", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Return
            End If

            Try
                Me.auto()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into FundTransfer(Id, AccountTransFrom, AccountTransTo, Amount, Date, Operator, Notes) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.cmbAccountNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbAccountNo1.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.dtpDate.Value.[Date])
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtOperator.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.txtNotes.Text)
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new fund Transfer from account no. '" & Me.cmbAccountNo.Text & "' to account no. '" & Me.cmbAccountNo.Text & "' having Transaction ID '" & Me.txtID.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                RestaurantPOS14.ModFunc.BankAccountLedgerSave(System.DateTime.Now, Me.cmbAccountNo.Text, Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text)), "Fund Transfer", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text)), 0D)
                RestaurantPOS14.ModFunc.BankAccountLedgerSave(System.DateTime.Now, Me.cmbAccountNo1.Text, Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text)), "Fund Transfer", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtAmount.Text)))
                MetroFramework.MetroMessageBox.Show(Me, "Successfully saved", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT FundTransfer.Id, RTRIM(Operator), Amount, FundTransfer.Date, RTRIM(FundTransfer.Notes),RTRIM(AccountTransFrom), RTRIM(AccountTransTo) from FundTransfer order by Date", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.DataGridView1.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As System.EventArgs)
            Try
                If MetroFramework.MetroMessageBox.Show(Me, "Do you really want to delete this record?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
                    Me.DeleteRecord()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from FundTransfer where ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "Deleted the fund Transfer record having Transaction ID '" & Me.txtID.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    RestaurantPOS14.ModFunc.BankAccountLedgerDelete(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text)), "Fund Transfer")
                    MetroFramework.MetroMessageBox.Show(Me, "Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "No Record found", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbAccountNo_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(AccountName),RTRIM(BankName),RTRIM(BranchName),RTRIM(SwiftCode),RTRIM(IFSCCode),IsNull(Sum(Credit)-Sum(Debit),0) from BankAccountRegistration LEFT JOIN BankBranch ON BankAccountRegistration.BranchID = BankBranch.Id LEFT JOIN BankAccountLedger ON BankAccountRegistration.AccountNo = BankAccountLedger.AccNo where AccountNo=@d1 group by AccountName,BankName,BranchName,SwiftCode,IFSCCode"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbAccountNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtAccountName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.txtBank.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.txtBranchName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.txtSwiftCode.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                    Me.txtIFSCCode.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(4))
                    Me.txtBalanceAmount.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(5))
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillAccountNo()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(AccountNo) FROM BankAccountRegistration where Active='Yes' order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbAccountNo.Items.Clear()
                Me.cmbAccountNo1.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbAccountNo.Items.Add(dataRow(CInt((0))).ToString())
                    Me.cmbAccountNo1.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmFundTransfer_Load(sender As Object, e As System.EventArgs)
            Me.fillAccountNo()
        End Sub

        Private Sub txtAmount_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtAmount.Text
                Dim selectionStart As Integer = Me.txtAmount.SelectionStart
                Dim selectionLength As Integer = Me.txtAmount.SelectionLength
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

        Private Sub DataGridView1_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
            Dim text As String =(e.RowIndex + 1).ToString()
            Dim sizeF As System.Drawing.SizeF = e.Graphics.MeasureString(text, MyBase.Font)
            If Me.DataGridView1.RowHeadersWidth < System.Convert.ToInt32(sizeF.Width + 20F) Then
                Me.DataGridView1.RowHeadersWidth = System.Convert.ToInt32(sizeF.Width + 20F)
            End If

            Dim controlText As System.Drawing.Brush = System.Drawing.SystemBrushes.ControlText
            e.Graphics.DrawString(text, MyBase.Font, controlText, e.RowBounds.Location.X + 15, CSng(e.RowBounds.Location.Y) + (CSng(e.RowBounds.Height) - sizeF.Height) / 2F)
        End Sub

        Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.DataGridView1.Rows.Count > 0 Then
                    If Me.DataGridView1.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.DataGridView1.SelectedRows(0)
                    Me.txtID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.txtOperator.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtAmount.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    Me.dtpDate.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    Me.txtNotes.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    Me.cmbAccountNo.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                    Me.cmbAccountNo1.Text = dataGridViewRow.Cells(CInt((6))).Value.ToString()
                    Me.btnSave.Enabled = False
                    If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Banking") Then
                        Me.btnDelete.Enabled = True
                    Else
                        Me.btnDelete.Enabled = False
                    End If
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Clear()
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.ExportExcel(Me.DataGridView1)
        End Sub

        Private Sub txtAccNo_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT FundTransfer.Id, RTRIM(Operator), Amount, FundTransfer.Date, RTRIM(FundTransfer.Notes),RTRIM(AccountTransFrom), RTRIM(AccountTransTo) from FundTransfer where AccountTransFrom like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtAccNo.Text) & "%' or AccountTransTo like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtAccNo.Text) & "%' order by Date", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.DataGridView1.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT FundTransfer.Id, RTRIM(Operator), Amount, FundTransfer.Date, RTRIM(FundTransfer.Notes),RTRIM(AccountTransFrom), RTRIM(AccountTransTo) from FundTransfer where Date between @d1 and @d2 order by Date", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTo.Value.[Date]
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.DataGridView1.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbAccountNo1_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(AccountName),RTRIM(BankName),RTRIM(BranchName),RTRIM(SwiftCode),RTRIM(IFSCCode) from BankBranch,BankAccountRegistration where BankBranch.ID=BankAccountRegistration.BranchID and AccountNo=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbAccountNo1.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtAccountName1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.txtBank1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.txtBranchName1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.txtSwiftCode1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                    Me.txtIFSCCode1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(4))
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmFundTransfer))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox6 = New System.Windows.Forms.GroupBox()
            Me.txtBank1 = New System.Windows.Forms.TextBox()
            Me.cmbAccountNo1 = New System.Windows.Forms.ComboBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtSwiftCode1 = New System.Windows.Forms.TextBox()
            Me.txtIFSCCode1 = New System.Windows.Forms.TextBox()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.txtBranchName1 = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtAccountName1 = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.DateTo = New System.Windows.Forms.DateTimePicker()
            Me.DateFrom = New System.Windows.Forms.DateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.groupBox5 = New System.Windows.Forms.GroupBox()
            Me.txtAccNo = New System.Windows.Forms.TextBox()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.dtpDate = New System.Windows.Forms.DateTimePicker()
            Me.txtAmount = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtNotes = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtOperator = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.txtBalanceAmount = New System.Windows.Forms.TextBox()
            Me.txtBank = New System.Windows.Forms.TextBox()
            Me.cmbAccountNo = New System.Windows.Forms.ComboBox()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtSwiftCode = New System.Windows.Forms.TextBox()
            Me.txtIFSCCode = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtBranchName = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtAccountName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Panel1.SuspendLayout()
            Me.GroupBox6.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.groupBox5.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox6)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.groupBox5)
            Me.Panel1.Controls.Add(Me.Panel5)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.DataGridView1)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(985, 667)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox6.Controls.Add(Me.txtBank1)
            Me.GroupBox6.Controls.Add(Me.cmbAccountNo1)
            Me.GroupBox6.Controls.Add(Me.Label13)
            Me.GroupBox6.Controls.Add(Me.Label15)
            Me.GroupBox6.Controls.Add(Me.txtSwiftCode1)
            Me.GroupBox6.Controls.Add(Me.txtIFSCCode1)
            Me.GroupBox6.Controls.Add(Me.Label16)
            Me.GroupBox6.Controls.Add(Me.txtBranchName1)
            Me.GroupBox6.Controls.Add(Me.Label17)
            Me.GroupBox6.Controls.Add(Me.Label18)
            Me.GroupBox6.Controls.Add(Me.txtAccountName1)
            Me.GroupBox6.Controls.Add(Me.Label19)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox6
            location = New System.Drawing.Point(594, 46)
            groupBox.Location = location
            Me.GroupBox6.Name = "GroupBox6"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox6
            size = New System.Drawing.Size(279, 193)
            groupBox2.Size = size
            Me.GroupBox6.TabIndex = 48
            Me.GroupBox6.TabStop = False
            Me.GroupBox6.Text = "To Bank Account"
            Me.txtBank1.BackColor = System.Drawing.SystemColors.Control
            Me.txtBank1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtBank1
            location = New System.Drawing.Point(112, 75)
            textBox.Location = location
            Me.txtBank1.Name = "txtBank1"
            Me.txtBank1.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtBank1
            size = New System.Drawing.Size(155, 21)
            textBox2.Size = size
            Me.txtBank1.TabIndex = 2
            Me.cmbAccountNo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAccountNo1.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbAccountNo1
            location = New System.Drawing.Point(112, 20)
            comboBox.Location = location
            Me.cmbAccountNo1.Name = "cmbAccountNo1"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbAccountNo1
            size = New System.Drawing.Size(155, 21)
            comboBox2.Size = size
            Me.cmbAccountNo1.TabIndex = 0
            Me.Label13.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label13
            location = New System.Drawing.Point(14, 76)
            label.Location = location
            Me.Label13.Name = "Label13"
            Dim label2 As System.Windows.Forms.Label = Me.Label13
            size = New System.Drawing.Size(38, 13)
            label2.Size = size
            Me.Label13.TabIndex = 32
            Me.Label13.Text = "Bank :"
            Me.Label15.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label15
            location = New System.Drawing.Point(14, 23)
            label3.Location = location
            Me.Label15.Name = "Label15"
            Dim label4 As System.Windows.Forms.Label = Me.Label15
            size = New System.Drawing.Size(73, 13)
            label4.Size = size
            Me.Label15.TabIndex = 38
            Me.Label15.Text = "Account No. :"
            Me.txtSwiftCode1.BackColor = System.Drawing.SystemColors.Control
            Me.txtSwiftCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtSwiftCode1
            location = New System.Drawing.Point(112, 131)
            textBox3.Location = location
            Me.txtSwiftCode1.Name = "txtSwiftCode1"
            Me.txtSwiftCode1.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtSwiftCode1
            size = New System.Drawing.Size(155, 21)
            textBox4.Size = size
            Me.txtSwiftCode1.TabIndex = 4
            Me.txtIFSCCode1.BackColor = System.Drawing.SystemColors.Control
            Me.txtIFSCCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtIFSCCode1
            location = New System.Drawing.Point(112, 160)
            textBox5.Location = location
            Me.txtIFSCCode1.Name = "txtIFSCCode1"
            Me.txtIFSCCode1.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtIFSCCode1
            size = New System.Drawing.Size(155, 21)
            textBox6.Size = size
            Me.txtIFSCCode1.TabIndex = 5
            Me.Label16.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label16
            location = New System.Drawing.Point(14, 133)
            label5.Location = location
            Me.Label16.Name = "Label16"
            Dim label6 As System.Windows.Forms.Label = Me.Label16
            size = New System.Drawing.Size(64, 13)
            label6.Size = size
            Me.Label16.TabIndex = 12
            Me.Label16.Text = "Swift Code :"
            Me.txtBranchName1.BackColor = System.Drawing.SystemColors.Control
            Me.txtBranchName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtBranchName1
            location = New System.Drawing.Point(112, 102)
            textBox7.Location = location
            Me.txtBranchName1.Name = "txtBranchName1"
            Me.txtBranchName1.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtBranchName1
            size = New System.Drawing.Size(155, 21)
            textBox8.Size = size
            Me.txtBranchName1.TabIndex = 3
            Me.Label17.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label17
            location = New System.Drawing.Point(14, 160)
            label7.Location = location
            Me.Label17.Name = "Label17"
            Dim label8 As System.Windows.Forms.Label = Me.Label17
            size = New System.Drawing.Size(75, 13)
            label8.Size = size
            Me.Label17.TabIndex = 13
            Me.Label17.Text = "Branch Code :"
            Me.Label18.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label18
            location = New System.Drawing.Point(14, 51)
            label9.Location = location
            Me.Label18.Name = "Label18"
            Dim label10 As System.Windows.Forms.Label = Me.Label18
            size = New System.Drawing.Size(84, 13)
            label10.Size = size
            Me.Label18.TabIndex = 33
            Me.Label18.Text = "Account Name :"
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtAccountName1
            location = New System.Drawing.Point(112, 47)
            textBox9.Location = location
            Me.txtAccountName1.Name = "txtAccountName1"
            Me.txtAccountName1.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtAccountName1
            size = New System.Drawing.Size(155, 20)
            textBox10.Size = size
            Me.txtAccountName1.TabIndex = 1
            Me.Label19.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label19
            location = New System.Drawing.Point(14, 106)
            label11.Location = location
            Me.Label19.Name = "Label19"
            Dim label12 As System.Windows.Forms.Label = Me.Label19
            size = New System.Drawing.Size(78, 13)
            label12.Size = size
            Me.Label19.TabIndex = 0
            Me.Label19.Text = "Branch Name :"
            Me.GroupBox4.Controls.Add(Me.Button1)
            Me.GroupBox4.Controls.Add(Me.DateTo)
            Me.GroupBox4.Controls.Add(Me.DateFrom)
            Me.GroupBox4.Controls.Add(Me.Label4)
            Me.GroupBox4.Controls.Add(Me.label9)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(205, 257)
            groupBox3.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(383, 77)
            groupBox4.Size = size
            Me.GroupBox4.TabIndex = 47
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Search By Transaction Date"
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.Image = CType(componentResourceManager.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(289, 26)
            button.Location = location
            Me.Button1.Name = "Button1"
            Dim button2 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(82, 36)
            button2.Size = size
            Me.Button1.TabIndex = 46
            Me.Button1.Text = "Search"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            Me.DateTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTo.CustomFormat = "dd/MM/yyyy"
            Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTo As System.Windows.Forms.DateTimePicker = Me.DateTo
            location = New System.Drawing.Point(166, 42)
            dateTo.Location = location
            Me.DateTo.Name = "DateTo"
            Dim dateTo2 As System.Windows.Forms.DateTimePicker = Me.DateTo
            size = New System.Drawing.Size(117, 20)
            dateTo2.Size = size
            Me.DateTo.TabIndex = 12
            Me.DateFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateFrom.CustomFormat = "dd/MM/yyyy"
            Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateFrom As System.Windows.Forms.DateTimePicker = Me.DateFrom
            location = New System.Drawing.Point(30, 42)
            dateFrom.Location = location
            Me.DateFrom.Name = "DateFrom"
            Dim dateFrom2 As System.Windows.Forms.DateTimePicker = Me.DateFrom
            size = New System.Drawing.Size(124, 20)
            dateFrom2.Size = size
            Me.DateFrom.TabIndex = 11
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label13 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(27, 21)
            label13.Location = location
            Me.Label4.Name = "Label4"
            Dim label14 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(30, 13)
            label14.Size = size
            Me.Label4.TabIndex = 9
            Me.Label4.Text = "From"
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label15 As System.Windows.Forms.Label = Me.label9
            location = New System.Drawing.Point(163, 21)
            label15.Location = location
            Me.label9.Name = "label9"
            Dim label16 As System.Windows.Forms.Label = Me.label9
            size = New System.Drawing.Size(20, 13)
            label16.Size = size
            Me.label9.TabIndex = 10
            Me.label9.Text = "To"
            Me.groupBox5.Controls.Add(Me.txtAccNo)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.groupBox5
            location = New System.Drawing.Point(4, 262)
            groupBox5.Location = location
            Me.groupBox5.Name = "groupBox5"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.groupBox5
            size = New System.Drawing.Size(194, 72)
            groupBox6.Size = size
            Me.groupBox5.TabIndex = 46
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Search By Account No."
            Me.txtAccNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtAccNo
            location = New System.Drawing.Point(17, 28)
            textBox11.Location = location
            Me.txtAccNo.Name = "txtAccNo"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtAccNo
            size = New System.Drawing.Size(156, 22)
            textBox12.Size = size
            Me.txtAccNo.TabIndex = 0
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.btnExportExcel)
            Me.Panel5.Controls.Add(Me.btnReset)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel5
            location = New System.Drawing.Point(594, 262)
            panel3.Location = location
            Me.Panel5.Name = "Panel5"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel5
            size = New System.Drawing.Size(216, 70)
            panel4.Size = size
            Me.Panel5.TabIndex = 45
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(101, 16)
            button3.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button4 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(106, 36)
            button4.Size = size
            Me.btnExportExcel.TabIndex = 5
            Me.btnExportExcel.Text = "Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(13, 16)
            button5.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button6 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(82, 36)
            button6.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.dtpDate)
            Me.GroupBox1.Controls.Add(Me.txtAmount)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtNotes)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.txtOperator)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(4, 44)
            groupBox7.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(299, 212)
            groupBox8.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Transaction Info"
            Me.dtpDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDate
            location = New System.Drawing.Point(109, 76)
            dateTimePicker.Location = location
            Me.dtpDate.Name = "dtpDate"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDate
            size = New System.Drawing.Size(134, 20)
            dateTimePicker2.Size = size
            Me.dtpDate.TabIndex = 2
            Me.txtAmount.BackColor = System.Drawing.Color.White
            Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtAmount
            location = New System.Drawing.Point(109, 47)
            textBox13.Location = location
            Me.txtAmount.Name = "txtAmount"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtAmount
            size = New System.Drawing.Size(134, 21)
            textBox14.Size = size
            Me.txtAmount.TabIndex = 1
            Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label2.AutoSize = True
            Dim label17 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(11, 48)
            label17.Location = location
            Me.Label2.Name = "Label2"
            Dim label18 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(49, 13)
            label18.Size = size
            Me.Label2.TabIndex = 32
            Me.Label2.Text = "Amount :"
            Me.txtNotes.BackColor = System.Drawing.Color.White
            Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtNotes
            location = New System.Drawing.Point(109, 104)
            textBox15.Location = location
            Me.txtNotes.Multiline = True
            Me.txtNotes.Name = "txtNotes"
            Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtNotes
            size = New System.Drawing.Size(178, 98)
            textBox16.Size = size
            Me.txtNotes.TabIndex = 3
            Me.Label8.AutoSize = True
            Dim label19 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(11, 105)
            label19.Location = location
            Me.Label8.Name = "Label8"
            Dim label20 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(41, 13)
            label20.Size = size
            Me.Label8.TabIndex = 12
            Me.Label8.Text = "Notes :"
            Me.Label10.AutoSize = True
            Dim label21 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(11, 23)
            label21.Location = location
            Me.Label10.Name = "Label10"
            Dim label22 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(54, 13)
            label22.Size = size
            Me.Label10.TabIndex = 33
            Me.Label10.Text = "Operator :"
            Me.txtOperator.BackColor = System.Drawing.Color.White
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtOperator
            location = New System.Drawing.Point(109, 19)
            textBox17.Location = location
            Me.txtOperator.Name = "txtOperator"
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtOperator
            size = New System.Drawing.Size(134, 20)
            textBox18.Size = size
            Me.txtOperator.TabIndex = 0
            Me.Label11.AutoSize = True
            Dim label23 As System.Windows.Forms.Label = Me.Label11
            location = New System.Drawing.Point(11, 78)
            label23.Location = location
            Me.Label11.Name = "Label11"
            Dim label24 As System.Windows.Forms.Label = Me.Label11
            size = New System.Drawing.Size(36, 13)
            label24.Size = size
            Me.Label11.TabIndex = 0
            Me.Label11.Text = "Date :"
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = RestaurantPOS14.My.Resources.Resources.Close_32x32
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(906, 0)
            button7.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button8 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(74, 40)
            button8.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.Label20)
            Me.GroupBox2.Controls.Add(Me.txtBalanceAmount)
            Me.GroupBox2.Controls.Add(Me.txtBank)
            Me.GroupBox2.Controls.Add(Me.cmbAccountNo)
            Me.GroupBox2.Controls.Add(Me.Label14)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.txtSwiftCode)
            Me.GroupBox2.Controls.Add(Me.txtIFSCCode)
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.txtBranchName)
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.Label12)
            Me.GroupBox2.Controls.Add(Me.txtAccountName)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Dim groupBox9 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(309, 44)
            groupBox9.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox10 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(279, 212)
            groupBox10.Size = size
            Me.GroupBox2.TabIndex = 1
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "From Bank Account"
            Me.Label20.AutoSize = True
            Dim label25 As System.Windows.Forms.Label = Me.Label20
            location = New System.Drawing.Point(14, 177)
            label25.Location = location
            Me.Label20.Name = "Label20"
            Dim label26 As System.Windows.Forms.Label = Me.Label20
            size = New System.Drawing.Size(91, 13)
            label26.Size = size
            Me.Label20.TabIndex = 40
            Me.Label20.Text = "Balance Amount :"
            Me.txtBalanceAmount.BackColor = System.Drawing.SystemColors.Control
            Me.txtBalanceAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox19 As System.Windows.Forms.TextBox = Me.txtBalanceAmount
            location = New System.Drawing.Point(112, 177)
            textBox19.Location = location
            Me.txtBalanceAmount.Name = "txtBalanceAmount"
            Me.txtBalanceAmount.[ReadOnly] = True
            Dim textBox20 As System.Windows.Forms.TextBox = Me.txtBalanceAmount
            size = New System.Drawing.Size(155, 21)
            textBox20.Size = size
            Me.txtBalanceAmount.TabIndex = 39
            Me.txtBank.BackColor = System.Drawing.SystemColors.Control
            Me.txtBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtBank
            location = New System.Drawing.Point(112, 70)
            textBox21.Location = location
            Me.txtBank.Name = "txtBank"
            Me.txtBank.[ReadOnly] = True
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtBank
            size = New System.Drawing.Size(155, 21)
            textBox22.Size = size
            Me.txtBank.TabIndex = 2
            Me.cmbAccountNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAccountNo.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbAccountNo
            location = New System.Drawing.Point(112, 20)
            comboBox3.Location = location
            Me.cmbAccountNo.Name = "cmbAccountNo"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbAccountNo
            size = New System.Drawing.Size(155, 21)
            comboBox4.Size = size
            Me.cmbAccountNo.TabIndex = 0
            Me.Label14.AutoSize = True
            Dim label27 As System.Windows.Forms.Label = Me.Label14
            location = New System.Drawing.Point(14, 70)
            label27.Location = location
            Me.Label14.Name = "Label14"
            Dim label28 As System.Windows.Forms.Label = Me.Label14
            size = New System.Drawing.Size(38, 13)
            label28.Size = size
            Me.Label14.TabIndex = 32
            Me.Label14.Text = "Bank :"
            Me.Label5.AutoSize = True
            Dim label29 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(14, 20)
            label29.Location = location
            Me.Label5.Name = "Label5"
            Dim label30 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(73, 13)
            label30.Size = size
            Me.Label5.TabIndex = 38
            Me.Label5.Text = "Account No. :"
            Me.txtSwiftCode.BackColor = System.Drawing.SystemColors.Control
            Me.txtSwiftCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtSwiftCode
            location = New System.Drawing.Point(112, 124)
            textBox23.Location = location
            Me.txtSwiftCode.Name = "txtSwiftCode"
            Me.txtSwiftCode.[ReadOnly] = True
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtSwiftCode
            size = New System.Drawing.Size(155, 21)
            textBox24.Size = size
            Me.txtSwiftCode.TabIndex = 4
            Me.txtIFSCCode.BackColor = System.Drawing.SystemColors.Control
            Me.txtIFSCCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox25 As System.Windows.Forms.TextBox = Me.txtIFSCCode
            location = New System.Drawing.Point(112, 151)
            textBox25.Location = location
            Me.txtIFSCCode.Name = "txtIFSCCode"
            Me.txtIFSCCode.[ReadOnly] = True
            Dim textBox26 As System.Windows.Forms.TextBox = Me.txtIFSCCode
            size = New System.Drawing.Size(155, 21)
            textBox26.Size = size
            Me.txtIFSCCode.TabIndex = 5
            Me.Label6.AutoSize = True
            Dim label31 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(14, 124)
            label31.Location = location
            Me.Label6.Name = "Label6"
            Dim label32 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(64, 13)
            label32.Size = size
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Swift Code :"
            Me.txtBranchName.BackColor = System.Drawing.SystemColors.Control
            Me.txtBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox27 As System.Windows.Forms.TextBox = Me.txtBranchName
            location = New System.Drawing.Point(112, 97)
            textBox27.Location = location
            Me.txtBranchName.Name = "txtBranchName"
            Me.txtBranchName.[ReadOnly] = True
            Dim textBox28 As System.Windows.Forms.TextBox = Me.txtBranchName
            size = New System.Drawing.Size(155, 21)
            textBox28.Size = size
            Me.txtBranchName.TabIndex = 3
            Me.Label7.AutoSize = True
            Dim label33 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(14, 152)
            label33.Location = location
            Me.Label7.Name = "Label7"
            Dim label34 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(75, 13)
            label34.Size = size
            Me.Label7.TabIndex = 13
            Me.Label7.Text = "Branch Code :"
            Me.Label12.AutoSize = True
            Dim label35 As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(14, 46)
            label35.Location = location
            Me.Label12.Name = "Label12"
            Dim label36 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(84, 13)
            label36.Size = size
            Me.Label12.TabIndex = 33
            Me.Label12.Text = "Account Name :"
            Dim textBox29 As System.Windows.Forms.TextBox = Me.txtAccountName
            location = New System.Drawing.Point(112, 46)
            textBox29.Location = location
            Me.txtAccountName.Name = "txtAccountName"
            Me.txtAccountName.[ReadOnly] = True
            Dim textBox30 As System.Windows.Forms.TextBox = Me.txtAccountName
            size = New System.Drawing.Size(155, 20)
            textBox30.Size = size
            Me.txtAccountName.TabIndex = 1
            Me.Label3.AutoSize = True
            Dim label37 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(14, 97)
            label37.Location = location
            Me.Label3.Name = "Label3"
            Dim label38 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(78, 13)
            label38.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Branch Name :"
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
            Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.DataGridView1.ColumnHeadersHeight = 24
            Me.DataGridView1.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7)
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            location = New System.Drawing.Point(4, 340)
            dataGridView.Location = location
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowTemplate.Height = 18
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(976, 314)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 3
            Me.Column1.HeaderText = "ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column2.HeaderText = "Operator"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Width = 147
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column3.DefaultCellStyle = dataGridViewCellStyle5
            Me.Column3.HeaderText = "Amount"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            dataGridViewCellStyle6.Format = "dd/MM/yyyy"
            Me.Column4.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column4.HeaderText = "Date"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column5.HeaderText = "Notes"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column5.Width = 200
            Me.Column6.HeaderText = "Account No. From"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column6.Width = 150
            Me.Column7.HeaderText = "Account No. To"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column7.Width = 150
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Me.GroupBox3.Controls.Add(Me.btnNew)
            Dim groupBox11 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(879, 47)
            groupBox11.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox12 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(101, 152)
            groupBox12.Size = size
            Me.GroupBox3.TabIndex = 6
            Me.GroupBox3.TabStop = False
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = RestaurantPOS14.My.Resources.Resources.Delete_32x32
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(9, 102)
            button9.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button10 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(82, 38)
            button10.Size = size
            Me.btnDelete.TabIndex = 5
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = RestaurantPOS14.My.Resources.Resources.Save_32x32
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(9, 60)
            button11.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button12 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(82, 38)
            button12.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = RestaurantPOS14.My.Resources.Resources.AddFile_32x32
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button13 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(9, 15)
            button13.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button14 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(82, 38)
            button14.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.lblUser)
            Me.Panel2.Controls.Add(Me.txtID)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 3)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(896, 32)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label39 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(383, 4)
            label39.Location = location
            Me.Label1.Name = "Label1"
            Dim label40 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(142, 24)
            label40.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Fund Transfer"
            Me.lblUser.AutoSize = True
            Dim label41 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(198, 7)
            label41.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label42 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label42.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Dim textBox31 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(749, 9)
            textBox31.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox32 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(68, 20)
            textBox32.Size = size
            Me.txtID.TabIndex = 9
            Me.txtID.Visible = False
            MyBase.AcceptButton = Me.btnSave
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(990, 673)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmFundTransfer"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox6.ResumeLayout(False)
            Me.GroupBox6.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.groupBox5.ResumeLayout(False)
            Me.groupBox5.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
