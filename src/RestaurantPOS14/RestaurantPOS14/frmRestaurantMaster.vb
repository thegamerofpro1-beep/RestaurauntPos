Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports GelButtons
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmRestaurantMaster
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtHotelName")>
        Private _txtHotelName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtInvoiceHeader")>
        Private _txtInvoiceHeader As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtVATNo")>
        Private _txtVATNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmailID")>
        Private _txtEmailID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBrowse")>
        Private _btnBrowse As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("PictureBox1")>
        Private _PictureBox1 As System.Windows.Forms.PictureBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddressLine1")>
        Private _txtAddressLine1 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBaseCurrency")>
        Private _txtBaseCurrency As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label11")>
        Private _Label11 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCurrencyCode")>
        Private _txtCurrencyCode As System.Windows.Forms.MaskedTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtcCode")>
        Private _txtcCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label14")>
        Private _Label14 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTicketFooterMessage")>
        Private _txtTicketFooterMessage As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label13")>
        Private _Label13 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label12")>
        Private _Label12 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddressLine3")>
        Private _txtAddressLine3 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddressLine2")>
        Private _txtAddressLine2 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkShowLogo")>
        Private _chkShowLogo As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCapitalAccount")>
        Private _txtCapitalAccount As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkShowQRCode")>
        Private _chkShowQRCode As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label24")>
        Private _Label24 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GelButton2")>
        Private _GelButton2 As GelButtons.GelButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GelButton1")>
        Private _GelButton1 As GelButtons.GelButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDBBackupLocation")>
        Private _txtDBBackupLocation As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label23")>
        Private _Label23 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("FolderBrowserDialog1")>
        Private _FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column9")>
        Private _Column9 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column12")>
        Private _Column12 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column13")>
        Private _Column13 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column10")>
        Private _Column10 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column11")>
        Private _Column11 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column14")>
        Private _Column14 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column8")>
        Private _Column8 As System.Windows.Forms.DataGridViewImageColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column15")>
        Private _Column15 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column16")>
        Private _Column16 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column17")>
        Private _Column17 As System.Windows.Forms.DataGridViewTextBoxColumn

        Private s1 As String

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

        Friend Overridable Property txtHotelName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtHotelName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtHotelName = value
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

        Friend Overridable Property dgw As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgw
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.dgw_MouseClick
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.MouseClick, value2
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.MouseClick, value2
                End If
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

        Friend Overridable Property txtInvoiceHeader As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtInvoiceHeader
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtInvoiceHeader = value
            End Set
        End Property

        Friend Overridable Property txtVATNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtVATNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtVATNo = value
            End Set
        End Property

        Friend Overridable Property txtEmailID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmailID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEmailID = value
            End Set
        End Property

        Friend Overridable Property txtContactNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtContactNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtContactNo = value
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

        Public Overridable Property btnBrowse As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBrowse
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnBrowse_Click
                If Me._btnBrowse IsNot Nothing Then
                    RemoveHandler Me._btnBrowse.Click, value2
                End If

                Me._btnBrowse = value
                If Me._btnBrowse IsNot Nothing Then
                    AddHandler Me._btnBrowse.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property PictureBox1 As System.Windows.Forms.PictureBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._PictureBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.PictureBox)
                Me._PictureBox1 = value
            End Set
        End Property

        Friend Overridable Property txtAddressLine1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAddressLine1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAddressLine1 = value
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

        Friend Overridable Property txtBaseCurrency As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBaseCurrency
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBaseCurrency = value
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

        Friend Overridable Property txtCurrencyCode As System.Windows.Forms.MaskedTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCurrencyCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.MaskedTextBox)
                Me._txtCurrencyCode = value
            End Set
        End Property

        Friend Overridable Property txtcCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtcCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtcCode = value
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

        Friend Overridable Property txtTicketFooterMessage As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTicketFooterMessage
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTicketFooterMessage = value
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

        Friend Overridable Property txtAddressLine3 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAddressLine3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAddressLine3 = value
            End Set
        End Property

        Friend Overridable Property txtAddressLine2 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAddressLine2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAddressLine2 = value
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

        Friend Overridable Property chkShowLogo As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkShowLogo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkShowLogo = value
            End Set
        End Property

        Friend Overridable Property txtCapitalAccount As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCapitalAccount
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCapitalAccount = value
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

        Friend Overridable Property chkShowQRCode As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkShowQRCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkShowQRCode = value
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

        Friend Overridable Property Label24 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label24
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label24 = value
            End Set
        End Property

        Friend Overridable Property GelButton2 As GelButtons.GelButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GelButton2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As GelButtons.GelButton)
                Dim value2 As System.EventHandler = AddressOf Me.GelButton2_Click
                If Me._GelButton2 IsNot Nothing Then
                    RemoveHandler Me._GelButton2.Click, value2
                End If

                Me._GelButton2 = value
                If Me._GelButton2 IsNot Nothing Then
                    AddHandler Me._GelButton2.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property GelButton1 As GelButtons.GelButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GelButton1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As GelButtons.GelButton)
                Dim value2 As System.EventHandler = AddressOf Me.GelButton1_Click
                If Me._GelButton1 IsNot Nothing Then
                    RemoveHandler Me._GelButton1.Click, value2
                End If

                Me._GelButton1 = value
                If Me._GelButton1 IsNot Nothing Then
                    AddHandler Me._GelButton1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtDBBackupLocation As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDBBackupLocation
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDBBackupLocation = value
            End Set
        End Property

        Friend Overridable Property Label23 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label23
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label23 = value
            End Set
        End Property

        Friend Overridable Property FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._FolderBrowserDialog1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FolderBrowserDialog)
                Me._FolderBrowserDialog1 = value
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

        Friend Overridable Property Column8 As System.Windows.Forms.DataGridViewImageColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewImageColumn)
                Me._Column8 = value
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

        Friend Overridable Property Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column16
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column16 = value
            End Set
        End Property

        Friend Overridable Property Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column17
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column17 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmRestaurantMaster.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmRestaurantMaster.__ENCList
                If RestaurantPOS14.frmRestaurantMaster.__ENCList.Count = RestaurantPOS14.frmRestaurantMaster.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmRestaurantMaster.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmRestaurantMaster.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmRestaurantMaster.__ENCList(num) = RestaurantPOS14.frmRestaurantMaster.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmRestaurantMaster.__ENCList.RemoveRange(num, RestaurantPOS14.frmRestaurantMaster.__ENCList.Count - num)
                    RestaurantPOS14.frmRestaurantMaster.__ENCList.Capacity = RestaurantPOS14.frmRestaurantMaster.__ENCList.Count
                End If

                Call RestaurantPOS14.frmRestaurantMaster.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtInvoiceHeader.Text = "TAX INVOICE"
            Me.txtVATNo.Text = ""
            Me.txtEmailID.Text = ""
            Me.txtContactNo.Text = ""
            Me.txtHotelName.Text = ""
            Me.chkShowQRCode.Checked = False
            Me.txtAddressLine1.Text = ""
            Me.PictureBox1.Image = RestaurantPOS14.My.Resources.Resources.icon_restaurant
            Me.txtBaseCurrency.Text = ""
            Me.txtCurrencyCode.Text = ""
            Me.txtAddressLine2.Text = ""
            Me.txtAddressLine3.Text = ""
            Me.txtTicketFooterMessage.Text = ""
            Me.txtCapitalAccount.Text = "0.00"
            Me.txtHotelName.Focus()
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Restaurant Master") Then
                Me.Getdata()
            Else
                Me.dgw.Rows.Clear()
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Restaurant Master") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.chkShowLogo.Checked = False
            Me.txtCapitalAccount.Enabled = True
            Me.txtDBBackupLocation.Text = ""
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtHotelName.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter restaurant name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtHotelName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAddressLine1.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter address line 1", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddressLine1.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAddressLine2.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter address line 2", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddressLine2.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtContactNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter contact no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtEmailID.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter email id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtEmailID.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtBaseCurrency.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter base currency", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtBaseCurrency.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCurrencyCode.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter currency code", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCurrencyCode.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select count(*) from Hotel Having count(*) >= 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Record Already Exists" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "please update the restautant info", "Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                If Me.chkShowLogo.Checked Then
                    Me.s1 = "Yes"
                Else
                    Me.s1 = "No"
                End If

                If Me.chkShowQRCode.Checked Then
                    Me.s2 = "Yes"
                Else
                    Me.s2 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Hotel( HotelName, AddressLine1, ContactNo, EmailID, TIN, STNo, CIN, Logo,BaseCurrency,CurrencyCode,AddressLine2,AddressLine3,TicketFooterMessage,ShowLogo,CapitalAccount,DBLocation) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtHotelName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtAddressLine1.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtEmailID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtVATNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtInvoiceHeader.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.s2)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.txtBaseCurrency.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Me.txtCurrencyCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.txtAddressLine2.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Me.txtAddressLine3.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Me.txtTicketFooterMessage.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Me.s1)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Microsoft.VisualBasic.Conversion.Val(Me.txtCapitalAccount.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.txtDBBackupLocation.Text)
                Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
                Call New System.Drawing.Bitmap(CType((Me.PictureBox1.Image), System.Drawing.Image)).Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim buffer As Byte() = memoryStream.GetBuffer()
                Dim sqlParameter As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter("@d8", System.Data.SqlDbType.Image)
                sqlParameter.Value = buffer
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(sqlParameter)
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the restaurant '" & Me.txtHotelName.Text & "' info"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                If Microsoft.VisualBasic.Conversion.Val(Me.txtCapitalAccount.Text) > 0.0 Then
                    RestaurantPOS14.ModFunc.LedgerSave(Microsoft.VisualBasic.DateAndTime.Today, "Cash", "1", "Initial Fund", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtCapitalAccount.Text)), 0D, "", "Capital A/c")
                    RestaurantPOS14.ModFunc.LedgerSave(Microsoft.VisualBasic.DateAndTime.Today, "Capital A/c", "1", "Initial Fund", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtCapitalAccount.Text)), "", "Cash")
                End If

                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Restaurant Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtHotelName.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter restaurant name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtHotelName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAddressLine1.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter address line 1", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddressLine1.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtAddressLine2.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter address line 2", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddressLine2.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtContactNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter contact no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtEmailID.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter email id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtEmailID.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtBaseCurrency.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter base currency", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtBaseCurrency.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCurrencyCode.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter currency code", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCurrencyCode.Focus()
                Return
            End If

            Try
                If Me.chkShowLogo.Checked Then
                    Me.s1 = "Yes"
                Else
                    Me.s1 = "No"
                End If

                If Me.chkShowQRCode.Checked Then
                    Me.s2 = "Yes"
                Else
                    Me.s2 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update RestaurantPOS_BillingInfoEB set CurrencyCode=@d1 where CurrencyCode=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCurrencyCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtcCode.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update RestaurantPOS_BillingInfoKOT set CurrencyCode=@d1 where CurrencyCode=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCurrencyCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtcCode.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update RestaurantPOS_BillingInfoTA set CurrencyCode=@d1 where CurrencyCode=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCurrencyCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtcCode.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update Hotel set HotelName=@d1, AddressLine1=@d2, ContactNo=@d3, EmailID=@d4, TIN=@d5, STNo=@d6, CIN=@d7, Logo=@d8,BaseCurrency=@d9,CurrencyCode=@d10,AddressLine2=@d11,AddressLine3=@d12,TicketFooterMessage=@d13,ShowLogo=@d14,CapitalAccount=@d15,DBLocation=@d16 where ID=" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID"))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtHotelName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtAddressLine1.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtEmailID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtVATNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtInvoiceHeader.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.s2)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.txtBaseCurrency.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Me.txtCurrencyCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.txtAddressLine2.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Me.txtAddressLine3.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Me.txtTicketFooterMessage.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Me.s1)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Microsoft.VisualBasic.Conversion.Val(Me.txtCapitalAccount.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.txtDBBackupLocation.Text)
                Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
                Call New System.Drawing.Bitmap(CType((Me.PictureBox1.Image), System.Drawing.Image)).Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim buffer As Byte() = memoryStream.GetBuffer()
                Dim sqlParameter As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter("@d8", System.Data.SqlDbType.Image)
                sqlParameter.Value = buffer
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(sqlParameter)
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "updated the restaurant '" & Me.txtHotelName.Text & "' info"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Restaurant Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(ID), RTRIM(HotelName), RTRIM(AddressLine1),RTRIM(AddressLine2),RTRIM(AddressLine3), RTRIM(ContactNo), RTRIM(EmailID), RTRIM(TIN), RTRIM(STNo), RTRIM(CIN),RTRIM(BaseCurrency),RTRIM(CurrencyCode),RTRIM(TicketFooterMessage),Logo,RTRIM(ShowLogo),CapitalAccount,RTRIM(DBLocation) from Hotel", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(16)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    Me.txtID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    Me.txtHotelName.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    Me.txtAddressLine1.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    Me.txtAddressLine2.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    Me.txtAddressLine3.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    Me.txtContactNo.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                    Me.txtEmailID.Text = dataGridViewRow.Cells(CInt((6))).Value.ToString()
                    Me.txtVATNo.Text = dataGridViewRow.Cells(CInt((7))).Value.ToString()
                    Me.txtInvoiceHeader.Text = dataGridViewRow.Cells(CInt((8))).Value.ToString()
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((9))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                        Me.chkShowQRCode.Checked = True
                    Else
                        Me.chkShowQRCode.Checked = False
                    End If

                    Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream(CType(dataGridViewRow.Cells(CInt((13))).Value, Byte()))
                    Me.PictureBox1.Image = System.Drawing.Image.FromStream(stream)
                    Me.txtBaseCurrency.Text = dataGridViewRow.Cells(CInt((10))).Value.ToString()
                    Me.txtCurrencyCode.Text = dataGridViewRow.Cells(CInt((11))).Value.ToString()
                    Me.txtcCode.Text = dataGridViewRow.Cells(CInt((11))).Value.ToString()
                    Me.txtTicketFooterMessage.Text = dataGridViewRow.Cells(CInt((12))).Value.ToString()
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((14))).Value.ToString(), "Yes", TextCompare:=False) = 0 Then
                        Me.chkShowLogo.Checked = True
                    Else
                        Me.chkShowLogo.Checked = False
                    End If

                    Me.txtCapitalAccount.Text = dataGridViewRow.Cells(CInt((15))).Value.ToString()
                    Me.txtDBBackupLocation.Text = dataGridViewRow.Cells(CInt((16))).Value.ToString()
                    Me.btnSave.Enabled = False
                    If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Restaurant Master") Then
                        Me.btnDelete.Enabled = True
                    Else
                        Me.btnDelete.Enabled = False
                    End If

                    If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Restaurant Master") Then
                        Me.btnUpdate.Enabled = True
                    Else
                        Me.btnUpdate.Enabled = False
                    End If

                    Me.txtCapitalAccount.Enabled = False
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnBrowse_Click(sender As Object, e As System.EventArgs)
            Try
                Dim openFileDialog As System.Windows.Forms.OpenFileDialog = Me.OpenFileDialog1
                openFileDialog.Filter = "Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;*.ico;"
                openFileDialog.FilterIndex = 4
                Me.OpenFileDialog1.FileName = ""
                If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.PictureBox1.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog1.FileName)
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.ToString())
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Hotel where ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "deleted the restaurant '" & Me.txtHotelName.Text & "' info"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
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

        Private Sub GelButton1_Click(sender As Object, e As System.EventArgs)
            Dim folderBrowserDialog As System.Windows.Forms.FolderBrowserDialog = Me.FolderBrowserDialog1
            If Me.FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.txtDBBackupLocation.Text = folderBrowserDialog.SelectedPath
            End If
        End Sub

        Private Sub GelButton2_Click(sender As Object, e As System.EventArgs)
            Me.txtDBBackupLocation.Text = ""
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmRestaurantMaster))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.txtcCode = New System.Windows.Forms.TextBox()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.txtCapitalAccount = New System.Windows.Forms.TextBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.chkShowLogo = New System.Windows.Forms.CheckBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtTicketFooterMessage = New System.Windows.Forms.TextBox()
            Me.txtInvoiceHeader = New System.Windows.Forms.TextBox()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.txtAddressLine3 = New System.Windows.Forms.TextBox()
            Me.txtAddressLine2 = New System.Windows.Forms.TextBox()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtVATNo = New System.Windows.Forms.TextBox()
            Me.txtCurrencyCode = New System.Windows.Forms.MaskedTextBox()
            Me.txtBaseCurrency = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.btnBrowse = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtEmailID = New System.Windows.Forms.TextBox()
            Me.txtHotelName = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txtAddressLine1 = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.chkShowQRCode = New System.Windows.Forms.CheckBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.GelButton2 = New GelButtons.GelButton()
            Me.GelButton1 = New GelButtons.GelButton()
            Me.txtDBBackupLocation = New System.Windows.Forms.TextBox()
            Me.Label23 = New System.Windows.Forms.Label()
            Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.txtcCode)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(740, 641)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Dim textBox As System.Windows.Forms.TextBox = Me.txtcCode
            location = New System.Drawing.Point(676, 241)
            textBox.Location = location
            Me.txtcCode.Name = "txtcCode"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtcCode
            size = New System.Drawing.Size(31, 20)
            textBox2.Size = size
            Me.txtcCode.TabIndex = 20
            Me.txtcCode.Visible = False
            Me.btnClose.BackColor = System.Drawing.SystemColors.Control
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.ForeColor = System.Drawing.Color.Black
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(660, 2)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(74, 37)
            button2.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Me.GroupBox1.Controls.Add(Me.Label24)
            Me.GroupBox1.Controls.Add(Me.GelButton2)
            Me.GroupBox1.Controls.Add(Me.GelButton1)
            Me.GroupBox1.Controls.Add(Me.txtDBBackupLocation)
            Me.GroupBox1.Controls.Add(Me.Label23)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.txtCapitalAccount)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.chkShowLogo)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(Me.txtTicketFooterMessage)
            Me.GroupBox1.Controls.Add(Me.txtInvoiceHeader)
            Me.GroupBox1.Controls.Add(Me.Label13)
            Me.GroupBox1.Controls.Add(Me.Label12)
            Me.GroupBox1.Controls.Add(Me.txtAddressLine3)
            Me.GroupBox1.Controls.Add(Me.txtAddressLine2)
            Me.GroupBox1.Controls.Add(Me.Label11)
            Me.GroupBox1.Controls.Add(Me.txtVATNo)
            Me.GroupBox1.Controls.Add(Me.txtCurrencyCode)
            Me.GroupBox1.Controls.Add(Me.txtBaseCurrency)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.btnBrowse)
            Me.GroupBox1.Controls.Add(Me.PictureBox1)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtEmailID)
            Me.GroupBox1.Controls.Add(Me.txtHotelName)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.txtAddressLine1)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtContactNo)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(5, 40)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(608, 504)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Restaurant Details"
            Me.Label8.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(139, 370)
            label.Location = location
            Me.Label8.Name = "Label8"
            Dim label2 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(111, 13)
            label2.Size = size
            Me.Label8.TabIndex = 28
            Me.Label8.Text = "POS Invoice Header :"
            Me.txtCapitalAccount.BackColor = System.Drawing.Color.White
            Me.txtCapitalAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtCapitalAccount
            location = New System.Drawing.Point(500, 179)
            textBox3.Location = location
            Me.txtCapitalAccount.Name = "txtCapitalAccount"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtCapitalAccount
            size = New System.Drawing.Size(98, 21)
            textBox4.Size = size
            Me.txtCapitalAccount.TabIndex = 7
            Me.txtCapitalAccount.Text = "0.00"
            Me.txtCapitalAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label7.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(411, 179)
            label3.Location = location
            Me.Label7.Name = "Label7"
            Dim label4 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(88, 13)
            label4.Size = size
            Me.Label7.TabIndex = 27
            Me.Label7.Text = "Capital Account :"
            Me.chkShowLogo.AutoSize = True
            Dim checkBox As System.Windows.Forms.CheckBox = Me.chkShowLogo
            location = New System.Drawing.Point(324, 234)
            checkBox.Location = location
            Me.chkShowLogo.Name = "chkShowLogo"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.chkShowLogo
            size = New System.Drawing.Size(160, 17)
            checkBox2.Size = size
            Me.chkShowLogo.TabIndex = 11
            Me.chkShowLogo.Text = "Show Logo on POS Receipt"
            Me.chkShowLogo.UseVisualStyleBackColor = True
            Me.Label6.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(168, 179)
            label5.Location = location
            Me.Label6.Name = "Label6"
            Dim label6 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(82, 13)
            label6.Size = size
            Me.Label6.TabIndex = 26
            Me.Label6.Text = "TRN/VAT No. :"
            Me.Label14.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label14
            location = New System.Drawing.Point(128, 303)
            label7.Location = location
            Me.Label14.Name = "Label14"
            Dim label8 As System.Windows.Forms.Label = Me.Label14
            size = New System.Drawing.Size(122, 13)
            label8.Size = size
            Me.Label14.TabIndex = 25
            Me.Label14.Text = "Ticket Footer Message :"
            Me.txtTicketFooterMessage.BackColor = System.Drawing.Color.White
            Me.txtTicketFooterMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtTicketFooterMessage
            location = New System.Drawing.Point(259, 259)
            textBox5.Location = location
            Me.txtTicketFooterMessage.Multiline = True
            Me.txtTicketFooterMessage.Name = "txtTicketFooterMessage"
            Me.txtTicketFooterMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtTicketFooterMessage
            size = New System.Drawing.Size(343, 100)
            textBox6.Size = size
            Me.txtTicketFooterMessage.TabIndex = 12
            Me.txtInvoiceHeader.BackColor = System.Drawing.Color.White
            Me.txtInvoiceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtInvoiceHeader
            location = New System.Drawing.Point(259, 365)
            textBox7.Location = location
            Me.txtInvoiceHeader.Name = "txtInvoiceHeader"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtInvoiceHeader
            size = New System.Drawing.Size(343, 21)
            textBox8.Size = size
            Me.txtInvoiceHeader.TabIndex = 13
            Me.Label13.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label13
            location = New System.Drawing.Point(168, 98)
            label9.Location = location
            Me.Label13.Name = "Label13"
            Dim label10 As System.Windows.Forms.Label = Me.Label13
            size = New System.Drawing.Size(83, 13)
            label10.Size = size
            Me.Label13.TabIndex = 23
            Me.Label13.Text = "Address Line 3 :"
            Me.Label12.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(167, 71)
            label11.Location = location
            Me.Label12.Name = "Label12"
            Dim label12 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(83, 13)
            label12.Size = size
            Me.Label12.TabIndex = 22
            Me.Label12.Text = "Address Line 2 :"
            Me.txtAddressLine3.BackColor = System.Drawing.Color.White
            Me.txtAddressLine3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtAddressLine3
            location = New System.Drawing.Point(255, 98)
            textBox9.Location = location
            Me.txtAddressLine3.Name = "txtAddressLine3"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtAddressLine3
            size = New System.Drawing.Size(344, 21)
            textBox10.Size = size
            Me.txtAddressLine3.TabIndex = 3
            Me.txtAddressLine2.BackColor = System.Drawing.Color.White
            Me.txtAddressLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtAddressLine2
            location = New System.Drawing.Point(255, 71)
            textBox11.Location = location
            Me.txtAddressLine2.Name = "txtAddressLine2"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtAddressLine2
            size = New System.Drawing.Size(344, 21)
            textBox12.Size = size
            Me.txtAddressLine2.TabIndex = 2
            Me.Label11.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.Label11
            location = New System.Drawing.Point(301, 264)
            label13.Location = location
            Me.Label11.Name = "Label11"
            Dim label14 As System.Windows.Forms.Label = Me.Label11
            size = New System.Drawing.Size(111, 13)
            label14.Size = size
            Me.Label11.TabIndex = 12
            Me.Label11.Text = "e.g. - USD, INR, AUD"
            Me.txtVATNo.BackColor = System.Drawing.Color.White
            Me.txtVATNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtVATNo
            location = New System.Drawing.Point(255, 179)
            textBox13.Location = location
            Me.txtVATNo.Name = "txtVATNo"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtVATNo
            size = New System.Drawing.Size(150, 21)
            textBox14.Size = size
            Me.txtVATNo.TabIndex = 6
            Me.txtCurrencyCode.AsciiOnly = True
            Me.txtCurrencyCode.BeepOnError = True
            Dim maskedTextBox As System.Windows.Forms.MaskedTextBox = Me.txtCurrencyCode
            location = New System.Drawing.Point(255, 233)
            maskedTextBox.Location = location
            Me.txtCurrencyCode.Mask = "???"
            Me.txtCurrencyCode.Name = "txtCurrencyCode"
            Dim maskedTextBox2 As System.Windows.Forms.MaskedTextBox = Me.txtCurrencyCode
            size = New System.Drawing.Size(40, 20)
            maskedTextBox2.Size = size
            Me.txtCurrencyCode.TabIndex = 10
            Me.txtBaseCurrency.BackColor = System.Drawing.Color.White
            Me.txtBaseCurrency.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtBaseCurrency
            location = New System.Drawing.Point(255, 206)
            textBox15.Location = location
            Me.txtBaseCurrency.Name = "txtBaseCurrency"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtBaseCurrency
            size = New System.Drawing.Size(150, 21)
            textBox16.Size = size
            Me.txtBaseCurrency.TabIndex = 8
            Me.Label10.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(168, 233)
            label15.Location = location
            Me.Label10.Name = "Label10"
            Dim label16 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(83, 13)
            label16.Size = size
            Me.Label10.TabIndex = 19
            Me.Label10.Text = "Currency Code :"
            Me.Label9.AutoSize = True
            Dim label17 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(168, 206)
            label17.Location = location
            Me.Label9.Name = "Label9"
            Dim label18 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(82, 13)
            label18.Size = size
            Me.Label9.TabIndex = 18
            Me.Label9.Text = "Base Currency :"
            Me.Label3.AutoSize = True
            Dim label19 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(154, 16)
            label19.Location = location
            Me.Label3.Name = "Label3"
            Dim label20 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(96, 13)
            label20.Size = size
            Me.Label3.TabIndex = 11
            Me.Label3.Text = "Restaurant Name :"
            Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBrowse.Image = CType(componentResourceManager.GetObject("btnBrowse.Image"), System.Drawing.Image)
            Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnBrowse
            location = New System.Drawing.Point(15, 125)
            button3.Location = location
            Me.btnBrowse.Name = "btnBrowse"
            Dim button4 As System.Windows.Forms.Button = Me.btnBrowse
            size = New System.Drawing.Size(135, 31)
            button4.Size = size
            Me.btnBrowse.TabIndex = 14
            Me.btnBrowse.Text = "&Browse..."
            Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBrowse.UseVisualStyleBackColor = True
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Image = RestaurantPOS14.My.Resources.Resources.icon_restaurant
            Dim pictureBox As System.Windows.Forms.PictureBox = Me.PictureBox1
            location = New System.Drawing.Point(14, 22)
            pictureBox.Location = location
            Me.PictureBox1.Name = "PictureBox1"
            Dim pictureBox2 As System.Windows.Forms.PictureBox = Me.PictureBox1
            size = New System.Drawing.Size(136, 100)
            pictureBox2.Size = size
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 17
            Me.PictureBox1.TabStop = False
            Me.Label4.AutoSize = True
            Dim label21 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(180, 125)
            label21.Location = location
            Me.Label4.Name = "Label4"
            Dim label22 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(70, 13)
            label22.Size = size
            Me.Label4.TabIndex = 6
            Me.Label4.Text = "Contact No. :"
            Me.txtEmailID.BackColor = System.Drawing.Color.White
            Me.txtEmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtEmailID
            location = New System.Drawing.Point(255, 152)
            textBox17.Location = location
            Me.txtEmailID.Name = "txtEmailID"
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtEmailID
            size = New System.Drawing.Size(343, 21)
            textBox18.Size = size
            Me.txtEmailID.TabIndex = 5
            Me.txtHotelName.BackColor = System.Drawing.Color.White
            Me.txtHotelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox19 As System.Windows.Forms.TextBox = Me.txtHotelName
            location = New System.Drawing.Point(255, 16)
            textBox19.Location = location
            Me.txtHotelName.Name = "txtHotelName"
            Dim textBox20 As System.Windows.Forms.TextBox = Me.txtHotelName
            size = New System.Drawing.Size(344, 21)
            textBox20.Size = size
            Me.txtHotelName.TabIndex = 0
            Me.Label5.AutoSize = True
            Dim label23 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(198, 152)
            label23.Location = location
            Me.Label5.Name = "Label5"
            Dim label24 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(52, 13)
            label24.Size = size
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "Email ID :"
            Me.txtAddressLine1.BackColor = System.Drawing.Color.White
            Me.txtAddressLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtAddressLine1
            location = New System.Drawing.Point(255, 43)
            textBox21.Location = location
            Me.txtAddressLine1.Name = "txtAddressLine1"
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtAddressLine1
            size = New System.Drawing.Size(344, 21)
            textBox22.Size = size
            Me.txtAddressLine1.TabIndex = 1
            Me.Label2.AutoSize = True
            Dim label25 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(167, 43)
            label25.Location = location
            Me.Label2.Name = "Label2"
            Dim label26 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(83, 13)
            label26.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Address Line 1 :"
            Me.txtContactNo.BackColor = System.Drawing.Color.White
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(255, 125)
            textBox23.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(344, 21)
            textBox24.Size = size
            Me.txtContactNo.TabIndex = 4
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
            Me.dgw.Columns.AddRange(Me.Column9, Me.Column1, Me.Column2, Me.Column12, Me.Column13, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column10, Me.Column11, Me.Column14, Me.Column8, Me.Column15, Me.Column16, Me.Column17)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(5, 550)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.RowHeadersVisible = False
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(729, 83)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 1
            Me.GroupBox2.Controls.Add(Me.btnNew)
            Me.GroupBox2.Controls.Add(Me.btnUpdate)
            Me.GroupBox2.Controls.Add(Me.btnSave)
            Me.GroupBox2.Controls.Add(Me.btnDelete)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(631, 45)
            groupBox3.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(103, 190)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 3
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Action Button"
            Me.btnNew.BackColor = System.Drawing.SystemColors.Control
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.ForeColor = System.Drawing.Color.Black
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(6, 18)
            button5.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button6 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(87, 37)
            button6.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = False
            Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.ForeColor = System.Drawing.Color.Black
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(6, 99)
            button7.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button8 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(87, 37)
            button8.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = False
            Me.btnSave.BackColor = System.Drawing.SystemColors.Control
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.ForeColor = System.Drawing.Color.Black
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(6, 58)
            button9.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button10 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(87, 37)
            button10.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = False
            Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.ForeColor = System.Drawing.Color.Black
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(6, 140)
            button11.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button12 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(87, 37)
            button12.Size = size
            Me.btnDelete.TabIndex = 6
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = False
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.chkShowQRCode)
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.lblUser)
            Me.Panel2.Controls.Add(Me.txtID)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(5, 4)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(650, 28)
            panel4.Size = size
            Me.Panel2.TabIndex = 2
            Me.chkShowQRCode.AutoSize = True
            Dim checkBox3 As System.Windows.Forms.CheckBox = Me.chkShowQRCode
            location = New System.Drawing.Point(25, 5)
            checkBox3.Location = location
            Me.chkShowQRCode.Name = "chkShowQRCode"
            Dim checkBox4 As System.Windows.Forms.CheckBox = Me.chkShowQRCode
            size = New System.Drawing.Size(180, 17)
            checkBox4.Size = size
            Me.chkShowQRCode.TabIndex = 9
            Me.chkShowQRCode.Text = "Show QR Code on POS Receipt"
            Me.chkShowQRCode.UseVisualStyleBackColor = True
            Me.chkShowQRCode.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label27 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(280, 2)
            label27.Location = location
            Me.Label1.Name = "Label1"
            Dim label28 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(149, 24)
            label28.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Restaurant Info"
            Me.lblUser.AutoSize = True
            Dim label29 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(40, 5)
            label29.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label30 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label30.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Dim textBox25 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(15, 5)
            textBox25.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox26 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(19, 20)
            textBox26.Size = size
            Me.txtID.TabIndex = 0
            Me.txtID.Visible = False
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label24.ForeColor = System.Drawing.Color.Red
            Dim label31 As System.Windows.Forms.Label = Me.Label24
            location = New System.Drawing.Point(139, 435)
            label31.Location = location
            Me.Label24.Name = "Label24"
            Dim label32 As System.Windows.Forms.Label = Me.Label24
            size = New System.Drawing.Size(227, 39)
            label32.Size = size
            Me.Label24.TabIndex = 404
            Me.Label24.Text = "Note : Automatic backup will delete all older" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "backups and keep copy of " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "new backup only."
            Me.GelButton2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.GelButton2.FlatAppearance.BorderSize = 0
            Me.GelButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.GelButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GelButton2.ForeColor = System.Drawing.Color.White
            Me.GelButton2.GradientBottom = System.Drawing.Color.Red
            Me.GelButton2.GradientTop = System.Drawing.Color.FromArgb(192, 0, 0)
            Me.GelButton2.Image = CType(componentResourceManager.GetObject("GelButton2.Image"), System.Drawing.Image)
            Me.GelButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim gelButton As GelButtons.GelButton = Me.GelButton2
            location = New System.Drawing.Point(496, 453)
            gelButton.Location = location
            Me.GelButton2.Name = "GelButton2"
            Dim gelButton2 As GelButtons.GelButton = Me.GelButton2
            size = New System.Drawing.Size(105, 40)
            gelButton2.Size = size
            Me.GelButton2.TabIndex = 403
            Me.GelButton2.Text = "Clear Folder " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Path"
            Me.GelButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.GelButton2.UseVisualStyleBackColor = False
            Me.GelButton1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.GelButton1.FlatAppearance.BorderSize = 0
            Me.GelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.GelButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GelButton1.ForeColor = System.Drawing.Color.White
            Me.GelButton1.GradientBottom = System.Drawing.Color.DodgerBlue
            Me.GelButton1.GradientTop = System.Drawing.SystemColors.HotTrack
            Me.GelButton1.Image = CType(componentResourceManager.GetObject("GelButton1.Image"), System.Drawing.Image)
            Me.GelButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim gelButton3 As GelButtons.GelButton = Me.GelButton1
            location = New System.Drawing.Point(496, 411)
            gelButton3.Location = location
            Me.GelButton1.Name = "GelButton1"
            Dim gelButton4 As GelButtons.GelButton = Me.GelButton1
            size = New System.Drawing.Size(105, 37)
            gelButton4.Size = size
            Me.GelButton1.TabIndex = 402
            Me.GelButton1.Text = "Select Folder..."
            Me.GelButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.GelButton1.UseVisualStyleBackColor = False
            Me.txtDBBackupLocation.BackColor = System.Drawing.SystemColors.Control
            Me.txtDBBackupLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox27 As System.Windows.Forms.TextBox = Me.txtDBBackupLocation
            location = New System.Drawing.Point(142, 411)
            textBox27.Location = location
            Me.txtDBBackupLocation.Name = "txtDBBackupLocation"
            Me.txtDBBackupLocation.[ReadOnly] = True
            Dim textBox28 As System.Windows.Forms.TextBox = Me.txtDBBackupLocation
            size = New System.Drawing.Size(348, 21)
            textBox28.Size = size
            Me.txtDBBackupLocation.TabIndex = 401
            Me.Label23.AutoSize = True
            Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label23.ForeColor = System.Drawing.Color.Red
            Dim label33 As System.Windows.Forms.Label = Me.Label23
            location = New System.Drawing.Point(139, 395)
            label33.Location = location
            Me.Label23.Name = "Label23"
            Dim label34 As System.Windows.Forms.Label = Me.Label23
            size = New System.Drawing.Size(429, 13)
            label34.Size = size
            Me.Label23.TabIndex = 400
            Me.Label23.Text = "Automatic Database Backup Destination Folder Path(Once close the application) :"
            Me.Column9.HeaderText = "ID"
            Me.Column9.Name = "Column9"
            Me.Column9.[ReadOnly] = True
            Me.Column9.Visible = False
            Me.Column1.HeaderText = "Restaurant Name"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column2.HeaderText = "Address line 1"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column12.HeaderText = "Address line 2"
            Me.Column12.Name = "Column12"
            Me.Column12.[ReadOnly] = True
            Me.Column13.HeaderText = "Address line 3"
            Me.Column13.Name = "Column13"
            Me.Column13.[ReadOnly] = True
            Me.Column3.HeaderText = "Contact No."
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column4.HeaderText = "Email ID"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column5.HeaderText = "TRN/VAT No."
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column6.HeaderText = "Invoice Header"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column7.HeaderText = "CIN"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column7.Visible = False
            Me.Column10.HeaderText = "Base Currency"
            Me.Column10.Name = "Column10"
            Me.Column10.[ReadOnly] = True
            Me.Column11.HeaderText = "Currency Code"
            Me.Column11.Name = "Column11"
            Me.Column11.[ReadOnly] = True
            Me.Column14.HeaderText = "Ticket Footer Message"
            Me.Column14.Name = "Column14"
            Me.Column14.[ReadOnly] = True
            Me.Column8.HeaderText = "Logo"
            Me.Column8.Name = "Column8"
            Me.Column8.[ReadOnly] = True
            Me.Column8.Visible = False
            Me.Column15.HeaderText = "Show Logo"
            Me.Column15.Name = "Column15"
            Me.Column15.[ReadOnly] = True
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column16.DefaultCellStyle = dataGridViewCellStyle5
            Me.Column16.HeaderText = "Capital Account"
            Me.Column16.Name = "Column16"
            Me.Column16.[ReadOnly] = True
            Me.Column17.HeaderText = "Database Backup Location"
            Me.Column17.Name = "Column17"
            Me.Column17.[ReadOnly] = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(746, 650)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmRestaurantMaster"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
