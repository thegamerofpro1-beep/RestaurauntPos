Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO.Ports
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmTerminalSetting
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbPrinter")>
        Private _cmbPrinter As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkIsEnabled")>
        Private _chkIsEnabled As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTillID")>
        Private _txtTillID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkCashDrawer")>
        Private _chkCashDrawer As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTest")>
        Private _btnTest As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtMessage")>
        Private _txtMessage As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDisplayPort")>
        Private _txtDisplayPort As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkCustomerDisplay")>
        Private _chkCustomerDisplay As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClearDisplay")>
        Private _btnClearDisplay As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCallerIDPort")>
        Private _txtCallerIDPort As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkCallerID")>
        Private _chkCallerID As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkColoredCustomerDisplay")>
        Private _chkColoredCustomerDisplay As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkDisableColoredSingleScreen")>
        Private _chkDisableColoredSingleScreen As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button2")>
        Private _Button2 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPT_PortNo")>
        Private _txtPT_PortNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPT_IPAddress")>
        Private _txtPT_IPAddress As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkActivePT")>
        Private _chkActivePT As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox5")>
        Private _GroupBox5 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtWSPort")>
        Private _txtWSPort As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkActiveWS")>
        Private _chkActiveWS As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("IsEnabled")>
        Private _IsEnabled As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column9")>
        Private _Column9 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column8")>
        Private _Column8 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column10")>
        Private _Column10 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column11")>
        Private _Column11 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column12")>
        Private _Column12 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column13")>
        Private _Column13 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column14")>
        Private _Column14 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column15")>
        Private _Column15 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label11")>
        Private _Label11 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbMenuItemLayout")>
        Private _cmbMenuItemLayout As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        Private st2 As String

        Private st1 As String

        Private st3 As String

        Private st4 As String

        Private st6 As String

        Private st7 As String

        Private PT As String

        Private WS As String

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property Panel3 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel3 = value
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

        Friend Overridable Property btnUpdate As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnUpdate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnUpdate_Click
                If Me._btnUpdate IsNot Nothing Then
                    RemoveHandler Me._btnUpdate.Click, value2
                End If

                Me._btnUpdate = value
                If Me._btnUpdate IsNot Nothing Then
                    AddHandler Me._btnUpdate.Click, value2
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

        Friend Overridable Property dgw As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgw
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.dgw_RowPostPaint
                Dim value3 As System.Windows.Forms.MouseEventHandler = AddressOf Me.dgw_MouseClick
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.RowPostPaint, value2
                    RemoveHandler Me._dgw.MouseClick, value3
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.RowPostPaint, value2
                    AddHandler Me._dgw.MouseClick, value3
                End If
            End Set
        End Property

        Friend Overridable Property cmbPrinter As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbPrinter
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbPrinter = value
            End Set
        End Property

        Friend Overridable Property chkIsEnabled As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkIsEnabled
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkIsEnabled = value
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

        Friend Overridable Property txtTillID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTillID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTillID = value
            End Set
        End Property

        Friend Overridable Property chkCashDrawer As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkCashDrawer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkCashDrawer = value
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

        Friend Overridable Property btnTest As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTest
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnTest_Click
                If Me._btnTest IsNot Nothing Then
                    RemoveHandler Me._btnTest.Click, value2
                End If

                Me._btnTest = value
                If Me._btnTest IsNot Nothing Then
                    AddHandler Me._btnTest.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtMessage As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtMessage
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtMessage = value
            End Set
        End Property

        Friend Overridable Property txtDisplayPort As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDisplayPort
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDisplayPort = value
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

        Friend Overridable Property chkCustomerDisplay As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkCustomerDisplay
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkCustomerDisplay = value
            End Set
        End Property

        Friend Overridable Property btnCancel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCancel_Click
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, value2
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, value2
                End If
            End Set
        End Property

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

        Friend Overridable Property btnClearDisplay As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClearDisplay
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnClear_Click
                If Me._btnClearDisplay IsNot Nothing Then
                    RemoveHandler Me._btnClearDisplay.Click, value2
                End If

                Me._btnClearDisplay = value
                If Me._btnClearDisplay IsNot Nothing Then
                    AddHandler Me._btnClearDisplay.Click, value2
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

        Friend Overridable Property txtCallerIDPort As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCallerIDPort
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCallerIDPort = value
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

        Friend Overridable Property chkCallerID As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkCallerID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkCallerID = value
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

        Friend Overridable Property chkColoredCustomerDisplay As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkColoredCustomerDisplay
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkColoredCustomerDisplay = value
            End Set
        End Property

        Friend Overridable Property chkDisableColoredSingleScreen As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkDisableColoredSingleScreen
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkDisableColoredSingleScreen = value
            End Set
        End Property

        Friend Overridable Property Button2 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
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

        Friend Overridable Property txtPT_PortNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPT_PortNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPT_PortNo = value
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

        Friend Overridable Property txtPT_IPAddress As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPT_IPAddress
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPT_IPAddress = value
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

        Friend Overridable Property chkActivePT As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkActivePT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkActivePT = value
            End Set
        End Property

        Friend Overridable Property GroupBox5 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox5 = value
            End Set
        End Property

        Friend Overridable Property txtWSPort As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtWSPort
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtWSPort = value
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

        Friend Overridable Property chkActiveWS As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkActiveWS
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkActiveWS = value
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

        Friend Overridable Property IsEnabled As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._IsEnabled
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._IsEnabled = value
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

        Friend Overridable Property Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column9 = value
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

        Friend Overridable Property Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column8 = value
            End Set
        End Property

        Friend Overridable Property Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column10
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column10 = value
            End Set
        End Property

        Friend Overridable Property Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column11
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column11 = value
            End Set
        End Property

        Friend Overridable Property Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column12
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column12 = value
            End Set
        End Property

        Friend Overridable Property Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column13
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column13 = value
            End Set
        End Property

        Friend Overridable Property Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column14
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column14 = value
            End Set
        End Property

        Friend Overridable Property Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column15
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column15 = value
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

        Friend Overridable Property cmbMenuItemLayout As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbMenuItemLayout
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbMenuItemLayout = value
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmTerminalSetting_Load
            Call RestaurantPOS14.frmTerminalSetting.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmTerminalSetting.__ENCList
                If RestaurantPOS14.frmTerminalSetting.__ENCList.Count = RestaurantPOS14.frmTerminalSetting.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmTerminalSetting.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmTerminalSetting.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmTerminalSetting.__ENCList(num) = RestaurantPOS14.frmTerminalSetting.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmTerminalSetting.__ENCList.RemoveRange(num, RestaurantPOS14.frmTerminalSetting.__ENCList.Count - num)
                    RestaurantPOS14.frmTerminalSetting.__ENCList.Capacity = RestaurantPOS14.frmTerminalSetting.__ENCList.Count
                End If

                Call RestaurantPOS14.frmTerminalSetting.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.cmbPrinter.Text = ""
            Me.chkCashDrawer.Checked = False
            Me.chkIsEnabled.Checked = True
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Settings") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Settings") Then
                Me.Getdata()
            Else
                Me.dgw.Rows.Clear()
            End If

            Me.btnDelete.Enabled = False
            Me.btnUpdate.Enabled = False
            Me.chkColoredCustomerDisplay.Checked = False
            Me.chkDisableColoredSingleScreen.Checked = False
            Me.chkCustomerDisplay.Checked = False
            Me.txtDisplayPort.Text = "COM1"
            Me.chkCallerID.Checked = False
            Me.cmbMenuItemLayout.SelectedIndex = 0
            Me.txtCallerIDPort.Text = "COM2"
            Me.txtMessage.Text = "Hello, This is test message"
            Me.txtTillID.Text = System.Net.Dns.GetHostName()
            Me.txtPT_IPAddress.Text = ""
            Me.txtPT_PortNo.Text = ""
            Me.chkActivePT.Checked = False
            Me.chkActiveWS.Checked = False
            Me.txtWSPort.Text = "COM3"
            Me.txtTillID.Focus()
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtTillID.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter till id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtTillID.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbPrinter.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select printer", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbPrinter.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select tillID from PosPrinterSetting where TillID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTillID.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Record already exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                If Me.chkCustomerDisplay.Checked Then
                    Me.st3 = "Yes"
                Else
                    Me.st3 = "No"
                End If

                If Me.chkCallerID.Checked Then
                    Me.st4 = "Yes"
                Else
                    Me.st4 = "No"
                End If

                If Me.chkIsEnabled.Checked Then
                    Me.st2 = "Yes"
                Else
                    Me.st2 = "No"
                End If

                If Me.chkCashDrawer.Checked Then
                    Me.st1 = "Enabled"
                Else
                    Me.st1 = "Disabled"
                End If

                If Me.chkColoredCustomerDisplay.Checked Then
                    Me.st6 = "Yes"
                Else
                    Me.st6 = "No"
                End If

                If Me.chkDisableColoredSingleScreen.Checked Then
                    Me.st7 = "Yes"
                Else
                    Me.st7 = "No"
                End If

                If Me.chkActivePT.Checked Then
                    Me.PT = "Yes"
                Else
                    Me.PT = "No"
                End If

                If Me.chkActiveWS.Checked Then
                    Me.WS = "Yes"
                Else
                    Me.WS = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.Configuration.DatabaseMaintenance.EnsureCompatibleSchema(RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into PosPrinterSetting(TillID,PrinterName,IsEnabled,CashDrawer,CustomerDisplay,CDPort,CallerID,CallerIDPort,SMII,CCD,PT,PTIpAddress,PTPortNo,WS,WSPortNo,DisableColoredDisplaySingleScreen) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTillID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.cmbPrinter.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.st2)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.st1)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.st3)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtDisplayPort.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.st4)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.txtCallerIDPort.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.cmbMenuItemLayout.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Me.st6)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.PT)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Me.txtPT_IPAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Me.txtPT_PortNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Me.WS)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Me.txtWSPort.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.st7)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.Configuration.SettingsHost.Service.Reload()
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Terminal Setting", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT ID,RTRIM(TillID), RTRIM(PrinterName),RTRIM(IsEnabled),RTRIM(CashDrawer),RTRIM(SMII),RTRIM(CustomerDisplay),RTRIM(CDPort),RTRIM(CallerID),RTRIM(CallerIDPort),RTRIM(CCD),RTRIM(PT),RTRIM(PTIpAddress),RTRIM(PTPortNo),RTRIM(WS),RTRIM(WSPortNo) from PosPrinterSetting order by TillID", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub PopulateInstalledPrintersCombo()
            Try
                Me.cmbPrinter.Items.Clear()
                Dim num As Integer = System.Drawing.Printing.PrinterSettings.InstalledPrinters.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 <= num4 Then
                        Dim item As String = System.Drawing.Printing.PrinterSettings.InstalledPrinters(num2)
                        Me.cmbPrinter.Items.Add(item)
                        num2 += 1
                        Continue While
                    End If

                    Exit While
                End While
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from PosPrinterSetting where ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Setting", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                Else
                    Call System.Windows.Forms.MessageBox.Show("No Record found", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
                RestaurantPOS14.Configuration.SettingsHost.Service.Reload()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count <= 0 Then
                    Return
                End If

                If Me.dgw.SelectedRows.Count = 0 Then Return
                Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                Me.txtID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                Me.txtTillID.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                Me.cmbPrinter.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((3))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                    Me.chkIsEnabled.Checked = True
                Else
                    Me.chkIsEnabled.Checked = False
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((4))).Value.ToString(), "Enabled", TextCompare:=False) = 0 Then
                    Me.chkCashDrawer.Checked = True
                Else
                    Me.chkCashDrawer.Checked = False
                End If

                Me.cmbMenuItemLayout.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((6))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                    Me.chkCustomerDisplay.Checked = True
                Else
                    Me.chkCustomerDisplay.Checked = False
                End If

                Me.txtDisplayPort.Text = dataGridViewRow.Cells(CInt((7))).Value.ToString()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((8))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                    Me.chkCallerID.Checked = True
                Else
                    Me.chkCallerID.Checked = False
                End If

                Me.txtCallerIDPort.Text = dataGridViewRow.Cells(CInt((9))).Value.ToString()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((10))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                    Me.chkColoredCustomerDisplay.Checked = True
                Else
                    Me.chkColoredCustomerDisplay.Checked = False
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((11))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                    Me.chkActivePT.Checked = True
                Else
                    Me.chkActivePT.Checked = False
                End If

                Me.txtPT_IPAddress.Text = dataGridViewRow.Cells(CInt((12))).Value.ToString()
                Me.txtPT_PortNo.Text = dataGridViewRow.Cells(CInt((13))).Value.ToString()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((14))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                    Me.chkActiveWS.Checked = True
                Else
                    Me.chkActiveWS.Checked = False
                End If

                Me.txtWSPort.Text = dataGridViewRow.Cells(CInt((15))).Value.ToString()
                Try
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='PosPrinterSetting' AND COLUMN_NAME='DisableColoredDisplaySingleScreen'", RestaurantPOS14.ModClasses.con)
                    If Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.cmd.ExecuteScalar()) > 0 Then
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(DisableColoredDisplaySingleScreen) FROM PosPrinterSetting WHERE ID=@d1", RestaurantPOS14.ModClasses.con)
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Me.txtID.Text))
                        Dim obj As Object = RestaurantPOS14.ModClasses.cmd.ExecuteScalar()
                        Me.chkDisableColoredSingleScreen.Checked = obj IsNot Nothing AndAlso obj IsNot System.DBNull.Value AndAlso Microsoft.VisualBasic.CompilerServices.Operators.CompareString(obj.ToString(), "Yes", TextCompare:=False) = 0
                    Else
                        Me.chkDisableColoredSingleScreen.Checked = False
                    End If
                Catch
                    Me.chkDisableColoredSingleScreen.Checked = False
                End Try

                If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Settings") Then
                    Me.btnDelete.Enabled = True
                Else
                    Me.btnDelete.Enabled = False
                End If

                If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Settings") Then
                    Me.btnUpdate.Enabled = True
                Else
                    Me.btnUpdate.Enabled = False
                End If

                Me.btnSave.Enabled = False
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

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtTillID.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter till id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtTillID.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.cmbPrinter.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select printer", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbPrinter.Focus()
                Return
            End If

            Try
                If Me.chkCustomerDisplay.Checked Then
                    Me.st3 = "Yes"
                Else
                    Me.st3 = "No"
                End If

                If Me.chkCallerID.Checked Then
                    Me.st4 = "Yes"
                Else
                    Me.st4 = "No"
                End If

                If Me.chkIsEnabled.Checked Then
                    Me.st2 = "Yes"
                Else
                    Me.st2 = "No"
                End If

                If Me.chkCashDrawer.Checked Then
                    Me.st1 = "Enabled"
                Else
                    Me.st1 = "Disabled"
                End If

                If Me.chkColoredCustomerDisplay.Checked Then
                    Me.st6 = "Yes"
                Else
                    Me.st6 = "No"
                End If

                If Me.chkDisableColoredSingleScreen.Checked Then
                    Me.st7 = "Yes"
                Else
                    Me.st7 = "No"
                End If

                If Me.chkActivePT.Checked Then
                    Me.PT = "Yes"
                Else
                    Me.PT = "No"
                End If

                If Me.chkActiveWS.Checked Then
                    Me.WS = "Yes"
                Else
                    Me.WS = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.Configuration.DatabaseMaintenance.EnsureCompatibleSchema(RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update PosPrinterSetting set TillID=@d1,PrinterName=@d2,IsEnabled=@d3,CashDrawer=@d4,CustomerDisplay=@d5,CDPort=@d6,CallerID=@d7,CallerIDPort=@d8,SMII=@d9,CCD=@d10,PT=@d11,PTIpAddress=@d12,PTPortNo=@d13,WS=@d14,WSPortNo=@d15,DisableColoredDisplaySingleScreen=@d16 where ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text)))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTillID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.cmbPrinter.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.st2)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.st1)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.st3)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtDisplayPort.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.st4)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.txtCallerIDPort.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.cmbMenuItemLayout.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Me.st6)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.PT)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Me.txtPT_IPAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Me.txtPT_PortNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Me.WS)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Me.txtWSPort.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.st7)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.Configuration.SettingsHost.Service.Reload()
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Terminal Setting", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnTest_Click(sender As Object, e As System.EventArgs)
            Try
                    Dim serialPort As System.IO.Ports.SerialPort = RestaurantPOS14.Configuration.SerialPortFactory.CreateCustomerDisplay(Me.txtDisplayPort.Text)
                serialPort.Open()
                serialPort.Write(Global.Microsoft.VisualBasic.Constants.vbFormFeed)
                serialPort.WriteLine(Me.txtMessage.Text)
                serialPort.Close()
                serialPort.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmTerminalSetting_Load(sender As Object, e As System.EventArgs)
            Me.PopulateInstalledPrintersCombo()
            Me.txtTillID.Text = System.Net.Dns.GetHostName()
        End Sub

        Private Sub btnClear_Click(sender As Object, e As System.EventArgs)
            Try
                    Dim serialPort As System.IO.Ports.SerialPort = RestaurantPOS14.Configuration.SerialPortFactory.CreateCustomerDisplay(Me.txtDisplayPort.Text)
                serialPort.Open()
                serialPort.Write(Global.Microsoft.VisualBasic.Constants.vbFormFeed)
                serialPort.Close()
                serialPort.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Dim screen As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
            RestaurantPOS14.My.MyProject.Forms.frmTestDualDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Dim obj As RestaurantPOS14.frmTestDualDisplay = RestaurantPOS14.My.MyProject.Forms.frmTestDualDisplay
            Dim location As System.Drawing.Point = screen.Bounds.Location
            Dim p As System.Drawing.Point = New System.Drawing.Point(100, 100)
            obj.Location = location + CType(p, System.Drawing.Size)
            Call RestaurantPOS14.My.MyProject.Forms.frmTestDualDisplay.Show()
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            Dim screen As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
            RestaurantPOS14.My.MyProject.Forms.frmTestDualDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Dim obj As RestaurantPOS14.frmTestDualDisplay = RestaurantPOS14.My.MyProject.Forms.frmTestDualDisplay
            Dim location As System.Drawing.Point = screen.Bounds.Location
            Dim p As System.Drawing.Point = New System.Drawing.Point(100, 100)
            obj.Location = location + CType(p, System.Drawing.Size)
            Call RestaurantPOS14.My.MyProject.Forms.frmTestDualDisplay.Close()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmTerminalSetting))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.IsEnabled = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.cmbPrinter = New System.Windows.Forms.ComboBox()
            Me.chkIsEnabled = New System.Windows.Forms.CheckBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtTillID = New System.Windows.Forms.TextBox()
            Me.chkCashDrawer = New System.Windows.Forms.CheckBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnClearDisplay = New System.Windows.Forms.Button()
            Me.btnTest = New System.Windows.Forms.Button()
            Me.txtMessage = New System.Windows.Forms.TextBox()
            Me.txtDisplayPort = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.chkCustomerDisplay = New System.Windows.Forms.CheckBox()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.cmbMenuItemLayout = New System.Windows.Forms.ComboBox()
            Me.GroupBox5 = New System.Windows.Forms.GroupBox()
            Me.txtWSPort = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.chkActiveWS = New System.Windows.Forms.CheckBox()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.txtPT_PortNo = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtPT_IPAddress = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.chkActivePT = New System.Windows.Forms.CheckBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.chkColoredCustomerDisplay = New System.Windows.Forms.CheckBox()
            Me.chkDisableColoredSingleScreen = New System.Windows.Forms.CheckBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtCallerIDPort = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.chkCallerID = New System.Windows.Forms.CheckBox()
            Me.Panel3.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.GroupBox5.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim label As System.Windows.Forms.Label = Me.Label1
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 0)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            Dim size As System.Drawing.Size = New System.Drawing.Size(843, 49)
            label2.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Terminal Setting"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(12, 11)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(45, 15)
            label4.Size = size
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Till ID :"
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.btnDelete)
            Me.Panel3.Controls.Add(Me.btnUpdate)
            Me.Panel3.Controls.Add(Me.btnSave)
            Me.Panel3.Controls.Add(Me.btnNew)
            Dim panel As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(583, 11)
            panel.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(99, 175)
            panel2.Size = size
            Me.Panel3.TabIndex = 4
            Me.btnDelete.BackColor = System.Drawing.Color.White
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.ForeColor = System.Drawing.Color.Black
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(8, 129)
            button.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button2 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(83, 37)
            button2.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = False
            Me.btnUpdate.BackColor = System.Drawing.Color.White
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.ForeColor = System.Drawing.Color.Black
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(8, 89)
            button3.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button4 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(83, 37)
            button4.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = False
            Me.btnSave.BackColor = System.Drawing.Color.White
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.ForeColor = System.Drawing.Color.Black
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(8, 47)
            button5.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button6 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(83, 37)
            button6.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = False
            Me.btnNew.BackColor = System.Drawing.Color.White
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnNew.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.ForeColor = System.Drawing.Color.Black
            Me.btnNew.Image = RestaurantPOS14.My.Resources.Resources.AddFile_32x32
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 4)
            button7.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button8 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(83, 37)
            button8.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = False
            Dim textBox As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(0, -1)
            textBox.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(21, 20)
            textBox2.Size = size
            Me.txtID.TabIndex = 4
            Me.txtID.Visible = False
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(12, 38)
            label5.Location = location
            Me.Label3.Name = "Label3"
            Dim label6 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(80, 15)
            label6.Size = size
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Printer Name:"
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgw.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 45
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3, Me.IsEnabled, Me.Column4, Me.Column9, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(15, 396)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(867, 261)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 5
            Me.Column1.HeaderText = "ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.Column2.FillWeight = 104.7619F
            Me.Column2.HeaderText = "Till ID"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column3.FillWeight = 149.6922F
            Me.Column3.HeaderText = "Printer Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.IsEnabled.FillWeight = 62.22777F
            Me.IsEnabled.HeaderText = "IsEnabled"
            Me.IsEnabled.Name = "IsEnabled"
            Me.IsEnabled.[ReadOnly] = True
            Me.Column4.FillWeight = 94.69003F
            Me.Column4.HeaderText = "Cash Drawer"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column9.HeaderText = "Menu Item Layout"
            Me.Column9.Name = "Column9"
            Me.Column9.[ReadOnly] = True
            Me.Column5.FillWeight = 95.80145F
            Me.Column5.HeaderText = "Active Customer Display"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column6.FillWeight = 96.78057F
            Me.Column6.HeaderText = "Display Port"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column7.FillWeight = 97.64313F
            Me.Column7.HeaderText = "Active Caller ID"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column8.FillWeight = 98.40297F
            Me.Column8.HeaderText = "Caller ID Port"
            Me.Column8.Name = "Column8"
            Me.Column8.[ReadOnly] = True
            Me.Column10.HeaderText = "Active CCD"
            Me.Column10.Name = "Column10"
            Me.Column10.[ReadOnly] = True
            Me.Column11.HeaderText = "Active Payment Terminal"
            Me.Column11.Name = "Column11"
            Me.Column11.[ReadOnly] = True
            Me.Column12.HeaderText = "IP Address"
            Me.Column12.Name = "Column12"
            Me.Column12.[ReadOnly] = True
            Me.Column13.HeaderText = "Port No."
            Me.Column13.Name = "Column13"
            Me.Column13.[ReadOnly] = True
            Me.Column14.HeaderText = "Active Weighing Scale"
            Me.Column14.Name = "Column14"
            Me.Column14.[ReadOnly] = True
            Me.Column15.HeaderText = "WS Port No."
            Me.Column15.Name = "Column15"
            Me.Column15.[ReadOnly] = True
            Me.cmbPrinter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbPrinter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbPrinter.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbPrinter.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbPrinter
            location = New System.Drawing.Point(125, 41)
            comboBox.Location = location
            Me.cmbPrinter.Name = "cmbPrinter"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbPrinter
            size = New System.Drawing.Size(257, 23)
            comboBox2.Size = size
            Me.cmbPrinter.TabIndex = 1
            Me.chkIsEnabled.AutoSize = True
            Me.chkIsEnabled.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.chkIsEnabled.ForeColor = System.Drawing.Color.White
            Dim checkBox As System.Windows.Forms.CheckBox = Me.chkIsEnabled
            location = New System.Drawing.Point(15, 62)
            checkBox.Location = location
            Me.chkIsEnabled.Name = "chkIsEnabled"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.chkIsEnabled
            size = New System.Drawing.Size(77, 19)
            checkBox2.Size = size
            Me.chkIsEnabled.TabIndex = 2
            Me.chkIsEnabled.Text = "IsEnabled"
            Me.chkIsEnabled.UseVisualStyleBackColor = True
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(12, 113)
            label7.Location = location
            Me.Label5.Name = "Label5"
            Dim label8 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(379, 45)
            label8.Size = size
            Me.Label5.TabIndex = 9
            Me.Label5.Text = "Note : If printer is shared on network then use network path of shared" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "printer as printer name" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "e.g. : \\ServerName\PrinterName"
            Me.txtTillID.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtTillID
            location = New System.Drawing.Point(125, 12)
            textBox3.Location = location
            Me.txtTillID.Name = "txtTillID"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtTillID
            size = New System.Drawing.Size(195, 23)
            textBox4.Size = size
            Me.txtTillID.TabIndex = 0
            Me.chkCashDrawer.AutoSize = True
            Me.chkCashDrawer.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.chkCashDrawer.ForeColor = System.Drawing.Color.White
            Dim checkBox3 As System.Windows.Forms.CheckBox = Me.chkCashDrawer
            location = New System.Drawing.Point(15, 85)
            checkBox3.Location = location
            Me.chkCashDrawer.Name = "chkCashDrawer"
            Dim checkBox4 As System.Windows.Forms.CheckBox = Me.chkCashDrawer
            size = New System.Drawing.Size(92, 19)
            checkBox4.Size = size
            Me.chkCashDrawer.TabIndex = 3
            Me.chkCashDrawer.Text = "Cash Drawer"
            Me.chkCashDrawer.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.btnClearDisplay)
            Me.GroupBox1.Controls.Add(Me.btnTest)
            Me.GroupBox1.Controls.Add(Me.txtMessage)
            Me.GroupBox1.Controls.Add(Me.txtDisplayPort)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.chkCustomerDisplay)
            Me.GroupBox1.ForeColor = System.Drawing.Color.White
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(15, 166)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(562, 124)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Console Customer Display"
            Me.btnClearDisplay.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnClearDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnClearDisplay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim button9 As System.Windows.Forms.Button = Me.btnClearDisplay
            location = New System.Drawing.Point(431, 88)
            button9.Location = location
            Me.btnClearDisplay.Name = "btnClearDisplay"
            Dim button10 As System.Windows.Forms.Button = Me.btnClearDisplay
            size = New System.Drawing.Size(117, 24)
            button10.Size = size
            Me.btnClearDisplay.TabIndex = 4
            Me.btnClearDisplay.Text = "Clear Display"
            Me.btnClearDisplay.UseVisualStyleBackColor = False
            Me.btnTest.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnTest.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim button11 As System.Windows.Forms.Button = Me.btnTest
            location = New System.Drawing.Point(350, 88)
            button11.Location = location
            Me.btnTest.Name = "btnTest"
            Dim button12 As System.Windows.Forms.Button = Me.btnTest
            size = New System.Drawing.Size(75, 24)
            button12.Size = size
            Me.btnTest.TabIndex = 3
            Me.btnTest.Text = "Test"
            Me.btnTest.UseVisualStyleBackColor = False
            Me.txtMessage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtMessage
            location = New System.Drawing.Point(149, 87)
            textBox5.Location = location
            Me.txtMessage.Name = "txtMessage"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtMessage
            size = New System.Drawing.Size(195, 25)
            textBox6.Size = size
            Me.txtMessage.TabIndex = 2
            Me.txtMessage.Text = "Hello, This is test message"
            Me.txtDisplayPort.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtDisplayPort
            location = New System.Drawing.Point(149, 56)
            textBox7.Location = location
            Me.txtDisplayPort.Name = "txtDisplayPort"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtDisplayPort
            size = New System.Drawing.Size(195, 25)
            textBox8.Size = size
            Me.txtDisplayPort.TabIndex = 1
            Me.txtDisplayPort.Text = "COM1"
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label9 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(12, 87)
            label9.Location = location
            Me.Label6.Name = "Label6"
            Dim label10 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(84, 15)
            label10.Size = size
            Me.Label6.TabIndex = 7
            Me.Label6.Text = "Text Message :"
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label11 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(12, 56)
            label11.Location = location
            Me.Label4.Name = "Label4"
            Dim label12 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(131, 15)
            label12.Size = size
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Customer Display Port :"
            Me.chkCustomerDisplay.AutoSize = True
            Me.chkCustomerDisplay.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim checkBox5 As System.Windows.Forms.CheckBox = Me.chkCustomerDisplay
            location = New System.Drawing.Point(15, 26)
            checkBox5.Location = location
            Me.chkCustomerDisplay.Name = "chkCustomerDisplay"
            Dim checkBox6 As System.Windows.Forms.CheckBox = Me.chkCustomerDisplay
            size = New System.Drawing.Size(155, 19)
            checkBox6.Size = size
            Me.chkCustomerDisplay.TabIndex = 0
            Me.chkCustomerDisplay.Text = "Active Customer Display"
            Me.chkCustomerDisplay.UseVisualStyleBackColor = True
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button13 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(843, 0)
            button13.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button14 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 50)
            button14.Size = size
            Me.btnCancel.TabIndex = 400
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.Label11)
            Me.Panel1.Controls.Add(Me.cmbMenuItemLayout)
            Me.Panel1.Controls.Add(Me.GroupBox5)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.cmbPrinter)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.chkCashDrawer)
            Me.Panel1.Controls.Add(Me.chkIsEnabled)
            Me.Panel1.Controls.Add(Me.txtTillID)
            Me.Panel1.Controls.Add(Me.Label5)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(5, 50)
            panel3.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(888, 666)
            panel4.Size = size
            Me.Panel1.TabIndex = 0
            Me.lblUser.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(424, 326)
            label13.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label14 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label14.Size = size
            Me.lblUser.TabIndex = 44
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label11.ForeColor = System.Drawing.Color.White
            Dim label15 As System.Windows.Forms.Label = Me.Label11
            location = New System.Drawing.Point(122, 67)
            label15.Location = location
            Me.Label11.Name = "Label11"
            Dim label16 As System.Windows.Forms.Label = Me.Label11
            size = New System.Drawing.Size(150, 15)
            label16.Size = size
            Me.Label11.TabIndex = 11
            Me.Label11.Text = "Menu Item Layout in POS :"
            Me.cmbMenuItemLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbMenuItemLayout.FormattingEnabled = True
            Me.cmbMenuItemLayout.Items.AddRange(New Object(2) {"Button Shows Item Name", "Button Shows Item Name and Rate", "Show Menu Item Image"})
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbMenuItemLayout
            location = New System.Drawing.Point(125, 87)
            comboBox3.Location = location
            Me.cmbMenuItemLayout.Name = "cmbMenuItemLayout"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbMenuItemLayout
            size = New System.Drawing.Size(197, 21)
            comboBox4.Size = size
            Me.cmbMenuItemLayout.TabIndex = 10
            Me.GroupBox5.Controls.Add(Me.txtWSPort)
            Me.GroupBox5.Controls.Add(Me.Label10)
            Me.GroupBox5.Controls.Add(Me.chkActiveWS)
            Me.GroupBox5.ForeColor = System.Drawing.Color.White
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox5
            location = New System.Drawing.Point(583, 195)
            groupBox3.Location = location
            Me.GroupBox5.Name = "GroupBox5"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox5
            size = New System.Drawing.Size(232, 95)
            groupBox4.Size = size
            Me.GroupBox5.TabIndex = 2
            Me.GroupBox5.TabStop = False
            Me.GroupBox5.Text = "Weighing Scale"
            Me.txtWSPort.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtWSPort
            location = New System.Drawing.Point(139, 51)
            textBox9.Location = location
            Me.txtWSPort.Name = "txtWSPort"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtWSPort
            size = New System.Drawing.Size(81, 25)
            textBox10.Size = size
            Me.txtWSPort.TabIndex = 1
            Me.txtWSPort.Text = "COM3"
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label17 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(12, 56)
            label17.Location = location
            Me.Label10.Name = "Label10"
            Dim label18 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(121, 15)
            label18.Size = size
            Me.Label10.TabIndex = 6
            Me.Label10.Text = "Weighing Scale Port :"
            Me.chkActiveWS.AutoSize = True
            Me.chkActiveWS.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim checkBox7 As System.Windows.Forms.CheckBox = Me.chkActiveWS
            location = New System.Drawing.Point(15, 26)
            checkBox7.Location = location
            Me.chkActiveWS.Name = "chkActiveWS"
            Dim checkBox8 As System.Windows.Forms.CheckBox = Me.chkActiveWS
            size = New System.Drawing.Size(145, 19)
            checkBox8.Size = size
            Me.chkActiveWS.TabIndex = 0
            Me.chkActiveWS.Text = "Active Weighing Scale"
            Me.chkActiveWS.UseVisualStyleBackColor = True
            Me.GroupBox4.Controls.Add(Me.txtPT_PortNo)
            Me.GroupBox4.Controls.Add(Me.Label9)
            Me.GroupBox4.Controls.Add(Me.txtPT_IPAddress)
            Me.GroupBox4.Controls.Add(Me.Label7)
            Me.GroupBox4.Controls.Add(Me.chkActivePT)
            Me.GroupBox4.ForeColor = System.Drawing.Color.White
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(429, 296)
            groupBox5.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(433, 95)
            groupBox6.Size = size
            Me.GroupBox4.TabIndex = 5
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Payment Terminal"
            Me.txtPT_PortNo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtPT_PortNo
            location = New System.Drawing.Point(300, 57)
            textBox11.Location = location
            Me.txtPT_PortNo.Name = "txtPT_PortNo"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtPT_PortNo
            size = New System.Drawing.Size(127, 25)
            textBox12.Size = size
            Me.txtPT_PortNo.TabIndex = 2
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label19 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(237, 57)
            label19.Location = location
            Me.Label9.Name = "Label9"
            Dim label20 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(57, 15)
            label20.Size = size
            Me.Label9.TabIndex = 7
            Me.Label9.Text = "Port No. :"
            Me.txtPT_IPAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtPT_IPAddress
            location = New System.Drawing.Point(92, 56)
            textBox13.Location = location
            Me.txtPT_IPAddress.Name = "txtPT_IPAddress"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtPT_IPAddress
            size = New System.Drawing.Size(139, 25)
            textBox14.Size = size
            Me.txtPT_IPAddress.TabIndex = 1
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label21 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(12, 56)
            label21.Location = location
            Me.Label7.Name = "Label7"
            Dim label22 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(69, 15)
            label22.Size = size
            Me.Label7.TabIndex = 6
            Me.Label7.Text = "IP Address :"
            Me.chkActivePT.AutoSize = True
            Me.chkActivePT.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim checkBox9 As System.Windows.Forms.CheckBox = Me.chkActivePT
            location = New System.Drawing.Point(15, 26)
            checkBox9.Location = location
            Me.chkActivePT.Name = "chkActivePT"
            Dim checkBox10 As System.Windows.Forms.CheckBox = Me.chkActivePT
            size = New System.Drawing.Size(158, 19)
            checkBox10.Size = size
            Me.chkActivePT.TabIndex = 0
            Me.chkActivePT.Text = "Active Payment Terminal"
            Me.chkActivePT.UseVisualStyleBackColor = True
            Me.GroupBox3.Controls.Add(Me.Button2)
            Me.GroupBox3.Controls.Add(Me.Button1)
            Me.GroupBox3.Controls.Add(Me.chkDisableColoredSingleScreen)
            Me.GroupBox3.Controls.Add(Me.chkColoredCustomerDisplay)
            Me.GroupBox3.ForeColor = System.Drawing.Color.White
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(220, 296)
            groupBox7.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(203, 120)
            groupBox8.Size = size
            Me.GroupBox3.TabIndex = 4
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Colored Customer Display"
            Me.Button2.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim button15 As System.Windows.Forms.Button = Me.Button2
            location = New System.Drawing.Point(108, 74)
            button15.Location = location
            Me.Button2.Name = "Button2"
            Dim button16 As System.Windows.Forms.Button = Me.Button2
            size = New System.Drawing.Size(75, 24)
            button16.Size = size
            Me.Button2.TabIndex = 3
            Me.Button2.Text = "Close"
            Me.Button2.UseVisualStyleBackColor = False
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim button17 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(15, 74)
            button17.Location = location
            Me.Button1.Name = "Button1"
            Dim button18 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(87, 24)
            button18.Size = size
            Me.Button1.TabIndex = 2
            Me.Button1.Text = "Test Form"
            Me.Button1.UseVisualStyleBackColor = False
            Me.chkColoredCustomerDisplay.AutoSize = True
            Me.chkColoredCustomerDisplay.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim checkBox11 As System.Windows.Forms.CheckBox = Me.chkColoredCustomerDisplay
            location = New System.Drawing.Point(15, 26)
            checkBox11.Location = location
            Me.chkColoredCustomerDisplay.Name = "chkColoredCustomerDisplay"
            Dim checkBox12 As System.Windows.Forms.CheckBox = Me.chkColoredCustomerDisplay
            size = New System.Drawing.Size(155, 19)
            checkBox12.Size = size
            Me.chkColoredCustomerDisplay.TabIndex = 0
            Me.chkColoredCustomerDisplay.Text = "Active Customer Display"
            Me.chkColoredCustomerDisplay.UseVisualStyleBackColor = True
            Me.chkDisableColoredSingleScreen.AutoSize = True
            Me.chkDisableColoredSingleScreen.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim checkBox13 As System.Windows.Forms.CheckBox = Me.chkDisableColoredSingleScreen
            location = New System.Drawing.Point(15, 50)
            checkBox13.Location = location
            Me.chkDisableColoredSingleScreen.Name = "chkDisableColoredSingleScreen"
            Dim checkBox14 As System.Windows.Forms.CheckBox = Me.chkDisableColoredSingleScreen
            size = New System.Drawing.Size(180, 19)
            checkBox14.Size = size
            Me.chkDisableColoredSingleScreen.TabIndex = 1
            Me.chkDisableColoredSingleScreen.Text = "Disable on Single Screen"
            Me.chkDisableColoredSingleScreen.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.txtCallerIDPort)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.chkCallerID)
            Me.GroupBox2.ForeColor = System.Drawing.Color.White
            Dim groupBox9 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(15, 295)
            groupBox9.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox10 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(199, 95)
            groupBox10.Size = size
            Me.GroupBox2.TabIndex = 3
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Caller ID"
            Me.txtCallerIDPort.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtCallerIDPort
            location = New System.Drawing.Point(110, 56)
            textBox15.Location = location
            Me.txtCallerIDPort.Name = "txtCallerIDPort"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtCallerIDPort
            size = New System.Drawing.Size(81, 25)
            textBox16.Size = size
            Me.txtCallerIDPort.TabIndex = 1
            Me.txtCallerIDPort.Text = "COM2"
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label23 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(12, 56)
            label23.Location = location
            Me.Label8.Name = "Label8"
            Dim label24 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(83, 15)
            label24.Size = size
            Me.Label8.TabIndex = 6
            Me.Label8.Text = "Caller ID Port :"
            Me.chkCallerID.AutoSize = True
            Me.chkCallerID.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim checkBox15 As System.Windows.Forms.CheckBox = Me.chkCallerID
            location = New System.Drawing.Point(15, 26)
            checkBox15.Location = location
            Me.chkCallerID.Name = "chkCallerID"
            Dim checkBox16 As System.Windows.Forms.CheckBox = Me.chkCallerID
            size = New System.Drawing.Size(107, 19)
            checkBox16.Size = size
            Me.chkCallerID.TabIndex = 0
            Me.chkCallerID.Text = "Active Caller ID"
            Me.chkCallerID.UseVisualStyleBackColor = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(896, 720)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.txtID)
            MyBase.Controls.Add(Me.Label1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmTerminalSetting"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Terminal Setting"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel3.ResumeLayout(False)
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox5.ResumeLayout(False)
            Me.GroupBox5.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
