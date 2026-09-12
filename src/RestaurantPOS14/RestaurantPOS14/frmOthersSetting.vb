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

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmOthersSetting
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtHDCharges")>
        Private _txtHDCharges As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtParcelCharges")>
        Private _txtParcelCharges As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkKG")>
        Private _chkKG As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkEB")>
        Private _chkEB As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkHD")>
        Private _chkHD As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkTA")>
        Private _chkTA As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSCPer")>
        Private _txtSCPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txVATPer")>
        Private _txVATPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSTPer")>
        Private _txtSTPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbTaxType")>
        Private _cmbTaxType As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkPDP")>
        Private _chkPDP As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkTL")>
        Private _chkTL As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkECEB")>
        Private _chkECEB As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkECHD")>
        Private _chkECHD As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkECTA")>
        Private _chkECTA As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkECDB")>
        Private _chkECDB As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkECDI")>
        Private _chkECDI As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkA1")>
        Private _chkA1 As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkANB")>
        Private _chkANB As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkTLAP")>
        Private _chkTLAP As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkShowSSTOnSecondaryDisplay")>
        Private _chkShowSSTOnSecondaryDisplay As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column8")>
        Private _Column8 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column9")>
        Private _Column9 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column10")>
        Private _Column10 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column11")>
        Private _Column11 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column12")>
        Private _Column12 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column13")>
        Private _Column13 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column14")>
        Private _Column14 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column15")>
        Private _Column15 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column16")>
        Private _Column16 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column17")>
        Private _Column17 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column18")>
        Private _Column18 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column19")>
        Private _Column19 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column20")>
        Private _Column20 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column21")>
        Private _Column21 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column22")>
        Private _Column22 As System.Windows.Forms.DataGridViewTextBoxColumn

        Private st1 As String

        Private st2 As String

        Private st3 As String

        Private st4 As String

        Private st5 As String

        Private st6 As String

        Private st7 As String

        Private st8 As String

        Private st9 As String

        Private st10 As String

        Private ECDI As String

        Private ECDB As String

        Private ECTA As String

        Private ECHD As String

        Private ECEB As String

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

        Friend Overridable Property txtHDCharges As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtHDCharges
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtHDCharges_KeyPress
                If Me._txtHDCharges IsNot Nothing Then
                    RemoveHandler Me._txtHDCharges.KeyPress, value2
                End If

                Me._txtHDCharges = value
                If Me._txtHDCharges IsNot Nothing Then
                    AddHandler Me._txtHDCharges.KeyPress, value2
                End If
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

        Friend Overridable Property txtParcelCharges As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtParcelCharges
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtParcelCharges_KeyPress
                If Me._txtParcelCharges IsNot Nothing Then
                    RemoveHandler Me._txtParcelCharges.KeyPress, value2
                End If

                Me._txtParcelCharges = value
                If Me._txtParcelCharges IsNot Nothing Then
                    AddHandler Me._txtParcelCharges.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property chkKG As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkKG
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkKG = value
            End Set
        End Property

        Friend Overridable Property chkEB As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkEB
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkEB = value
            End Set
        End Property

        Friend Overridable Property chkHD As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkHD
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkHD = value
            End Set
        End Property

        Friend Overridable Property chkTA As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkTA
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkTA = value
            End Set
        End Property

        Friend Overridable Property txtSCPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSCPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtSCPer_KeyPress
                If Me._txtSCPer IsNot Nothing Then
                    RemoveHandler Me._txtSCPer.KeyPress, value2
                End If

                Me._txtSCPer = value
                If Me._txtSCPer IsNot Nothing Then
                    AddHandler Me._txtSCPer.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property txVATPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txVATPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtVATPer_KeyPress
                If Me._txVATPer IsNot Nothing Then
                    RemoveHandler Me._txVATPer.KeyPress, value2
                End If

                Me._txVATPer = value
                If Me._txVATPer IsNot Nothing Then
                    AddHandler Me._txVATPer.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtSTPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSTPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtSTPer_KeyPress
                If Me._txtSTPer IsNot Nothing Then
                    RemoveHandler Me._txtSTPer.KeyPress, value2
                End If

                Me._txtSTPer = value
                If Me._txtSTPer IsNot Nothing Then
                    AddHandler Me._txtSTPer.KeyPress, value2
                End If
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

        Friend Overridable Property cmbTaxType As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbTaxType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbTaxType = value
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

        Friend Overridable Property chkPDP As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkPDP
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkPDP = value
            End Set
        End Property

        Friend Overridable Property chkTL As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkTL
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkTL = value
            End Set
        End Property

        Friend Overridable Property chkECEB As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkECEB
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkECEB = value
            End Set
        End Property

        Friend Overridable Property chkECHD As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkECHD
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkECHD = value
            End Set
        End Property

        Friend Overridable Property chkECTA As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkECTA
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkECTA = value
            End Set
        End Property

        Friend Overridable Property chkECDB As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkECDB
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkECDB = value
            End Set
        End Property

        Friend Overridable Property chkECDI As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkECDI
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkECDI = value
            End Set
        End Property

        Friend Overridable Property chkA1 As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkA1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkA1 = value
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

        Friend Overridable Property chkANB As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkANB
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkANB = value
            End Set
        End Property

        Friend Overridable Property chkTLAP As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkTLAP
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkTLAP = value
            End Set
        End Property

        Friend Overridable Property chkShowSSTOnSecondaryDisplay As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkShowSSTOnSecondaryDisplay
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkShowSSTOnSecondaryDisplay = value
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

        Friend Overridable Property Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column18
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column18 = value
            End Set
        End Property

        Friend Overridable Property Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column19
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column19 = value
            End Set
        End Property

        Friend Overridable Property Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column20
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column20 = value
            End Set
        End Property

        Friend Overridable Property Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column21
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column21 = value
            End Set
        End Property

        Friend Overridable Property Column22 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column22
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column22 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmOthersSetting.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmOthersSetting.__ENCList
                If RestaurantPOS14.frmOthersSetting.__ENCList.Count = RestaurantPOS14.frmOthersSetting.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmOthersSetting.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmOthersSetting.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmOthersSetting.__ENCList(num) = RestaurantPOS14.frmOthersSetting.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmOthersSetting.__ENCList.RemoveRange(num, RestaurantPOS14.frmOthersSetting.__ENCList.Count - num)
                    RestaurantPOS14.frmOthersSetting.__ENCList.Capacity = RestaurantPOS14.frmOthersSetting.__ENCList.Count
                End If

                Call RestaurantPOS14.frmOthersSetting.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtHDCharges.Text = "0.00"
            Me.txtParcelCharges.Text = "0.00"
            Me.txtSTPer.Text = "0.00"
            Me.txtSCPer.Text = "0.00"
            Me.txVATPer.Text = "0.00"
            Me.chkEB.Checked = False
            Me.chkHD.Checked = False
            Me.chkKG.Checked = False
            Me.chkTA.Checked = False
            Me.cmbTaxType.SelectedIndex = 1
            Me.txtParcelCharges.Focus()
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

            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.cmbTaxType.Enabled = True
            Me.chkPDP.Checked = False
            Me.chkTL.Checked = False
            Me.chkECDB.Checked = False
            Me.chkECDI.Checked = False
            Me.chkECTA.Checked = False
            Me.chkECHD.Checked = False
            Me.chkECEB.Checked = False
            Me.chkA1.Checked = False
            Me.chkANB.Checked = False
            Me.chkTLAP.Checked = False
            Me.chkShowSSTOnSecondaryDisplay.Checked = True
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Not Me.ValidateChargePercentages() Then
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select count(*) from OtherSetting Having count(*) >= 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Record Already Exists" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "please update the others setting", "Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                If Me.chkTA.Checked Then
                    Me.st2 = "Yes"
                Else
                    Me.st2 = "No"
                End If

                If Me.chkHD.Checked Then
                    Me.st3 = "Yes"
                Else
                    Me.st3 = "No"
                End If

                If Me.chkEB.Checked Then
                    Me.st4 = "Yes"
                Else
                    Me.st4 = "No"
                End If

                If Me.chkKG.Checked Then
                    Me.st5 = "Yes"
                Else
                    Me.st5 = "No"
                End If

                If Me.chkPDP.Checked Then
                    Me.st6 = "Yes"
                Else
                    Me.st6 = "No"
                End If

                If Me.chkTL.Checked Then
                    Me.st7 = "Yes"
                Else
                    Me.st7 = "No"
                End If

                If Me.chkA1.Checked Then
                    Me.st8 = "Yes"
                Else
                    Me.st8 = "No"
                End If

                If Me.chkECDI.Checked Then
                    Me.ECDI = "Yes"
                Else
                    Me.ECDI = "No"
                End If

                If Me.chkECDB.Checked Then
                    Me.ECDB = "Yes"
                Else
                    Me.ECDB = "No"
                End If

                If Me.chkECTA.Checked Then
                    Me.ECTA = "Yes"
                Else
                    Me.ECTA = "No"
                End If

                If Me.chkECHD.Checked Then
                    Me.ECHD = "Yes"
                Else
                    Me.ECHD = "No"
                End If

                If Me.chkECEB.Checked Then
                    Me.ECEB = "Yes"
                Else
                    Me.ECEB = "No"
                End If

                If Me.chkANB.Checked Then
                    Me.st9 = "Yes"
                Else
                    Me.st9 = "No"
                End If

                If Me.chkTLAP.Checked Then
                    Me.st10 = "Yes"
                Else
                    Me.st10 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SET XACT_ABORT ON; BEGIN TRANSACTION; insert into OtherSetting(ParcelCharges,HomeDeliveryCharges,VAT,ServiceTax,ServiceCharges,TA,HD,EB,KG,TaxType,PDP,TL,ECDI, ECDB, ECTA, ECHD, ECEB,A1,ANB,TLAP,ShowSSTOnSecondaryDisplay) VALUES (@d1,@d2,@d3,@d4,@d5,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21,@d22); UPDATE Category SET ST=@d4; COMMIT TRANSACTION")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtParcelCharges.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(Me.txtHDCharges.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val("0.00"))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(Me.txtSTPer.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(Me.txVATPer.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.st2)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.st3)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.st4)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Me.st5)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.cmbTaxType.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Me.st6)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Me.st7)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Me.ECDI)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Me.ECDB)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.ECTA)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", Me.ECHD)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d18", Me.ECEB)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d19", Me.st8)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d20", Me.st9)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d21", Me.st10)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d22", If(Me.chkShowSSTOnSecondaryDisplay.Checked, "Yes", "No"))
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.Configuration.SecondaryDisplayOptions.SetShowSstColumn(Me.chkShowSSTOnSecondaryDisplay.Checked)
                Dim text As String = "added the others setting info"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, text)
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from OtherSetting where ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim text As String = "deleted the others setting info"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, text)
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

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Not Me.ValidateChargePercentages() Then
                Return
            End If

            Try
                If Me.chkTA.Checked Then
                    Me.st2 = "Yes"
                Else
                    Me.st2 = "No"
                End If

                If Me.chkHD.Checked Then
                    Me.st3 = "Yes"
                Else
                    Me.st3 = "No"
                End If

                If Me.chkEB.Checked Then
                    Me.st4 = "Yes"
                Else
                    Me.st4 = "No"
                End If

                If Me.chkKG.Checked Then
                    Me.st5 = "Yes"
                Else
                    Me.st5 = "No"
                End If

                If Me.chkKG.Checked Then
                    Me.st5 = "Yes"
                Else
                    Me.st5 = "No"
                End If

                If Me.chkPDP.Checked Then
                    Me.st6 = "Yes"
                Else
                    Me.st6 = "No"
                End If

                If Me.chkTL.Checked Then
                    Me.st7 = "Yes"
                Else
                    Me.st7 = "No"
                End If

                If Me.chkA1.Checked Then
                    Me.st8 = "Yes"
                Else
                    Me.st8 = "No"
                End If

                If Me.chkECDI.Checked Then
                    Me.ECDI = "Yes"
                Else
                    Me.ECDI = "No"
                End If

                If Me.chkECDB.Checked Then
                    Me.ECDB = "Yes"
                Else
                    Me.ECDB = "No"
                End If

                If Me.chkECTA.Checked Then
                    Me.ECTA = "Yes"
                Else
                    Me.ECTA = "No"
                End If

                If Me.chkECHD.Checked Then
                    Me.ECHD = "Yes"
                Else
                    Me.ECHD = "No"
                End If

                If Me.chkECEB.Checked Then
                    Me.ECEB = "Yes"
                Else
                    Me.ECEB = "No"
                End If

                If Me.chkANB.Checked Then
                    Me.st9 = "Yes"
                Else
                    Me.st9 = "No"
                End If

                If Me.chkTLAP.Checked Then
                    Me.st10 = "Yes"
                Else
                    Me.st10 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SET XACT_ABORT ON; BEGIN TRANSACTION; Update OtherSetting set ParcelCharges=@d1,HomeDeliveryCharges=@d2,VAT=@d3,ServiceTax=@d4,ServiceCharges=@d5,TA=@d7,HD=@d8,EB=@d9,KG=@d10,TaxType=@d11,PDP=@d12,TL=@d13,ECDI=@d14, ECDB=@d15, ECTA=@d16, ECHD=@d17, ECEB=@d18,A1=@d19,ANB=@d20,TLAP=@d21,ShowSSTOnSecondaryDisplay=@d22 where ID=" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID") & "; UPDATE Category SET ST=@d4; COMMIT TRANSACTION")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtParcelCharges.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(Me.txtHDCharges.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val("0.00"))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(Me.txtSTPer.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(Me.txVATPer.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.st2)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.st3)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.st4)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Me.st5)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.cmbTaxType.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Me.st6)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Me.st7)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Me.ECDI)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Me.ECDB)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.ECTA)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", Me.ECHD)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d18", Me.ECEB)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d19", Me.st8)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d20", Me.st9)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d21", Me.st10)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d22", If(Me.chkShowSSTOnSecondaryDisplay.Checked, "Yes", "No"))
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.Configuration.SecondaryDisplayOptions.SetShowSstColumn(Me.chkShowSSTOnSecondaryDisplay.Checked)
                Dim text As String = "Updated the others setting info"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, text)
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Getdata()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT ID,(ParcelCharges),(HomeDeliveryCharges),ServiceTax,VAT,ServiceCharges,RTRIM(TA),RTRIM(HD),RTRIM(EB),RTRIM(KG),RTRIM(TaxType),RTRIM(PDP),RTRIM(TL),RTRIM(ECDI), RTRIM(ECDB), RTRIM(ECTA), RTRIM(ECHD), RTRIM(ECEB),RTRIM(A1),RTRIM(ANB),RTRIM(TLAP),RTRIM(ISNULL(ShowSSTOnSecondaryDisplay,N'Yes')) from OtherSetting", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(16)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(17)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(18)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(19)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(20)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(21)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Function ValidateChargePercentages() As Boolean
            Dim sstPercent As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtSTPer.Text)
            If sstPercent < 0.0 OrElse sstPercent > 100.0 Then
                Call System.Windows.Forms.MessageBox.Show("SST charge must be between 0 and 100 percent.", "Invalid SST Charge", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtSTPer.Focus()
                Return False
            End If

            Dim serviceChargePercent As Double = Microsoft.VisualBasic.Conversion.Val(Me.txVATPer.Text)
            If serviceChargePercent < 0.0 OrElse serviceChargePercent > 100.0 Then
                Call System.Windows.Forms.MessageBox.Show("Service charge must be between 0 and 100 percent.", "Invalid Service Charge", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txVATPer.Focus()
                Return False
            End If

            Return True
        End Function

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    Dim v0 As Object = dataGridViewRow.Cells(CInt((1))).Value
                    Me.txtParcelCharges.Text =(If((v0 Is Nothing OrElse v0 Is System.DBNull.Value), String.Empty, v0.ToString()))
                    Dim v1 As Object = dataGridViewRow.Cells(CInt((0))).Value
                    Me.txtID.Text =(If((v1 Is Nothing OrElse v1 Is System.DBNull.Value), String.Empty, v1.ToString()))
                    Dim v2 As Object = dataGridViewRow.Cells(CInt((2))).Value
                    Me.txtHDCharges.Text =(If((v2 Is Nothing OrElse v2 Is System.DBNull.Value), String.Empty, v2.ToString()))
                    Dim v3 As Object = dataGridViewRow.Cells(CInt((3))).Value
                    Me.txtSTPer.Text =(If((v3 Is Nothing OrElse v3 Is System.DBNull.Value), String.Empty, v3.ToString()))
                    Dim v5a As Object = dataGridViewRow.Cells(CInt((5))).Value
                    Me.txVATPer.Text =(If((v5a Is Nothing OrElse v5a Is System.DBNull.Value), String.Empty, v5a.ToString()))
                    Dim v5b As Object = dataGridViewRow.Cells(CInt((5))).Value
                    Me.txtSCPer.Text =(If((v5b Is Nothing OrElse v5b Is System.DBNull.Value), String.Empty, v5b.ToString()))
                    Dim v6 As Object = dataGridViewRow.Cells(CInt((6))).Value
                    Dim s6 As String =(If((v6 Is Nothing OrElse v6 Is System.DBNull.Value), String.Empty, v6.ToString()))
                    Me.chkTA.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s6, "Yes", TextCompare:=False) = 0
                    Dim v7 As Object = dataGridViewRow.Cells(CInt((7))).Value
                    Dim s7 As String =(If((v7 Is Nothing OrElse v7 Is System.DBNull.Value), String.Empty, v7.ToString()))
                    Me.chkHD.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s7, "Yes", TextCompare:=False) = 0
                    Dim v8 As Object = dataGridViewRow.Cells(CInt((8))).Value
                    Dim s8 As String =(If((v8 Is Nothing OrElse v8 Is System.DBNull.Value), String.Empty, v8.ToString()))
                    Me.chkEB.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s8, "Yes", TextCompare:=False) = 0
                    Dim v9 As Object = dataGridViewRow.Cells(CInt((9))).Value
                    Dim s9 As String =(If((v9 Is Nothing OrElse v9 Is System.DBNull.Value), String.Empty, v9.ToString()))
                    Me.chkKG.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s9, "Yes", TextCompare:=False) = 0
                    Dim v10 As Object = dataGridViewRow.Cells(CInt((10))).Value
                    Me.cmbTaxType.Text =(If((v10 Is Nothing OrElse v10 Is System.DBNull.Value), String.Empty, v10.ToString()))
                    Dim v11 As Object = dataGridViewRow.Cells(CInt((11))).Value
                    Dim s11 As String =(If((v11 Is Nothing OrElse v11 Is System.DBNull.Value), String.Empty, v11.ToString()))
                    Me.chkPDP.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s11, "Yes", TextCompare:=False) = 0
                    Dim v12 As Object = dataGridViewRow.Cells(CInt((12))).Value
                    Dim s12 As String =(If((v12 Is Nothing OrElse v12 Is System.DBNull.Value), String.Empty, v12.ToString()))
                    Me.chkTL.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s12, "Yes", TextCompare:=False) = 0
                    Dim v13 As Object = dataGridViewRow.Cells(CInt((13))).Value
                    Dim s13 As String =(If((v13 Is Nothing OrElse v13 Is System.DBNull.Value), String.Empty, v13.ToString()))
                    Me.chkECDI.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s13, "Yes", TextCompare:=False) = 0
                    Dim v14 As Object = dataGridViewRow.Cells(CInt((14))).Value
                    Dim s14 As String =(If((v14 Is Nothing OrElse v14 Is System.DBNull.Value), String.Empty, v14.ToString()))
                    Me.chkECDB.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s14, "Yes", TextCompare:=False) = 0
                    Dim v15 As Object = dataGridViewRow.Cells(CInt((15))).Value
                    Dim s15 As String =(If((v15 Is Nothing OrElse v15 Is System.DBNull.Value), String.Empty, v15.ToString()))
                    Me.chkECTA.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s15, "Yes", TextCompare:=False) = 0
                    Dim v16 As Object = dataGridViewRow.Cells(CInt((16))).Value
                    Dim s16 As String =(If((v16 Is Nothing OrElse v16 Is System.DBNull.Value), String.Empty, v16.ToString()))
                    Me.chkECHD.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s16, "Yes", TextCompare:=False) = 0
                    Dim v17 As Object = dataGridViewRow.Cells(CInt((17))).Value
                    Dim s17 As String =(If((v17 Is Nothing OrElse v17 Is System.DBNull.Value), String.Empty, v17.ToString()))
                    Me.chkECEB.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s17, "Yes", TextCompare:=False) = 0
                    Dim v18 As Object = dataGridViewRow.Cells(CInt((18))).Value
                    Dim s18 As String =(If((v18 Is Nothing OrElse v18 Is System.DBNull.Value), String.Empty, v18.ToString()))
                    Me.chkA1.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s18, "Yes", TextCompare:=False) = 0
                    Dim v19 As Object = dataGridViewRow.Cells(CInt((19))).Value
                    Dim s19 As String =(If((v19 Is Nothing OrElse v19 Is System.DBNull.Value), String.Empty, v19.ToString()))
                    Me.chkANB.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s19, "Yes", TextCompare:=False) = 0
                    Dim v20 As Object = dataGridViewRow.Cells(CInt((20))).Value
                    Dim s20 As String =(If((v20 Is Nothing OrElse v20 Is System.DBNull.Value), String.Empty, v20.ToString()))
                    Me.chkTLAP.Checked = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(s20, "Yes", TextCompare:=False) = 0
                    Dim v21 As Object = dataGridViewRow.Cells(CInt((21))).Value
                    Dim s21 As String =(If((v21 Is Nothing OrElse v21 Is System.DBNull.Value), "Yes", v21.ToString()))
                    Me.chkShowSSTOnSecondaryDisplay.Checked = Not String.Equals(s21.Trim(), "No", StringComparison.OrdinalIgnoreCase)
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
                    Me.cmbTaxType.Enabled = False
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtParcelCharges_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtParcelCharges.Text
                Dim selectionStart As Integer = Me.txtParcelCharges.SelectionStart
                Dim selectionLength As Integer = Me.txtParcelCharges.SelectionLength
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

        Private Sub txtHDCharges_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtHDCharges.Text
                Dim selectionStart As Integer = Me.txtHDCharges.SelectionStart
                Dim selectionLength As Integer = Me.txtHDCharges.SelectionLength
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

        Private Sub txtSTPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtSTPer.Text
                Dim selectionStart As Integer = Me.txtSTPer.SelectionStart
                Dim selectionLength As Integer = Me.txtSTPer.SelectionLength
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

        Private Sub txtVATPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txVATPer.Text
                Dim selectionStart As Integer = Me.txVATPer.SelectionStart
                Dim selectionLength As Integer = Me.txVATPer.SelectionLength
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

        Private Sub txtSCPer_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtSCPer.Text
                Dim selectionStart As Integer = Me.txtSCPer.SelectionStart
                Dim selectionLength As Integer = Me.txtSCPer.SelectionLength
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmOthersSetting))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.chkANB = New System.Windows.Forms.CheckBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.chkA1 = New System.Windows.Forms.CheckBox()
            Me.chkECEB = New System.Windows.Forms.CheckBox()
            Me.chkECHD = New System.Windows.Forms.CheckBox()
            Me.chkECTA = New System.Windows.Forms.CheckBox()
            Me.chkECDB = New System.Windows.Forms.CheckBox()
            Me.chkECDI = New System.Windows.Forms.CheckBox()
            Me.chkTL = New System.Windows.Forms.CheckBox()
            Me.chkPDP = New System.Windows.Forms.CheckBox()
            Me.cmbTaxType = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.chkKG = New System.Windows.Forms.CheckBox()
            Me.chkEB = New System.Windows.Forms.CheckBox()
            Me.chkHD = New System.Windows.Forms.CheckBox()
            Me.chkTA = New System.Windows.Forms.CheckBox()
            Me.txVATPer = New System.Windows.Forms.TextBox()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtParcelCharges = New System.Windows.Forms.TextBox()
            Me.txtHDCharges = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtSCPer = New System.Windows.Forms.TextBox()
            Me.txtSTPer = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.chkTLAP = New System.Windows.Forms.CheckBox()
            Me.chkShowSSTOnSecondaryDisplay = New System.Windows.Forms.CheckBox()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 2)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(463, 641)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox3.Controls.Add(Me.btnDelete)
            Me.GroupBox3.Controls.Add(Me.btnUpdate)
            Me.GroupBox3.Controls.Add(Me.btnSave)
            Me.GroupBox3.Controls.Add(Me.btnNew)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(367, 43)
            groupBox.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(93, 181)
            groupBox2.Size = size
            Me.GroupBox3.TabIndex = 4
            Me.GroupBox3.TabStop = False
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(8, 136)
            button.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button2 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(79, 37)
            button2.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(8, 95)
            button3.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button4 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(79, 37)
            button4.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(8, 54)
            button5.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button6 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(79, 37)
            button6.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 11)
            button7.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button8 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(79, 39)
            button8.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.chkShowSSTOnSecondaryDisplay)
            Me.GroupBox1.Controls.Add(Me.chkTLAP)
            Me.GroupBox1.Controls.Add(Me.chkANB)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.chkA1)
            Me.GroupBox1.Controls.Add(Me.chkECEB)
            Me.GroupBox1.Controls.Add(Me.chkECHD)
            Me.GroupBox1.Controls.Add(Me.chkECTA)
            Me.GroupBox1.Controls.Add(Me.chkECDB)
            Me.GroupBox1.Controls.Add(Me.chkECDI)
            Me.GroupBox1.Controls.Add(Me.chkTL)
            Me.GroupBox1.Controls.Add(Me.chkPDP)
            Me.GroupBox1.Controls.Add(Me.cmbTaxType)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.chkKG)
            Me.GroupBox1.Controls.Add(Me.chkEB)
            Me.GroupBox1.Controls.Add(Me.chkHD)
            Me.GroupBox1.Controls.Add(Me.chkTA)
            Me.GroupBox1.Controls.Add(Me.txtSTPer)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txVATPer)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.txtParcelCharges)
            Me.GroupBox1.Controls.Add(Me.txtHDCharges)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(3, 42)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(360, 494)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Setting :"
            Me.chkANB.AutoSize = True
            Dim checkBox As System.Windows.Forms.CheckBox = Me.chkANB
            location = New System.Drawing.Point(19, 421)
            checkBox.Location = location
            Me.chkANB.Name = "chkANB"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.chkANB
            size = New System.Drawing.Size(202, 17)
            checkBox2.Size = size
            Me.chkANB.TabIndex = 18
            Me.chkANB.Text = "Allow POS without Menu Items Stock"
            Me.chkANB.UseVisualStyleBackColor = True
            Me.Label8.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(7, 249)
            label.Location = location
            Me.Label8.Name = "Label8"
            Dim label2 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(376, 13)
            label2.Size = size
            Me.Label8.TabIndex = 17
            Me.Label8.Text = "..........................................................................................................................."
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label6.ForeColor = System.Drawing.Color.Maroon
            Dim label3 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(38, 234)
            label3.Location = location
            Me.Label6.Name = "Label6"
            Dim label4 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(184, 13)
            label4.Size = size
            Me.Label6.TabIndex = 16
            Me.Label6.Text = "(Does not apply for Home Delivery)"
            Me.chkA1.AutoSize = True
            Dim checkBox3 As System.Windows.Forms.CheckBox = Me.chkA1
            location = New System.Drawing.Point(19, 400)
            checkBox3.Location = location
            Me.chkA1.Name = "chkA1"
            Dim checkBox4 As System.Windows.Forms.CheckBox = Me.chkA1
            size = New System.Drawing.Size(296, 17)
            checkBox4.Size = size
            Me.chkA1.TabIndex = 15
            Me.chkA1.Text = "Add last placed items (Old Items) in Updated Dine In KOT"
            Me.chkA1.UseVisualStyleBackColor = True
            Me.chkECEB.AutoSize = True
            Dim checkBox5 As System.Windows.Forms.CheckBox = Me.chkECEB
            location = New System.Drawing.Point(19, 378)
            checkBox5.Location = location
            Me.chkECEB.Name = "chkECEB"
            Dim checkBox6 As System.Windows.Forms.CheckBox = Me.chkECEB
            size = New System.Drawing.Size(172, 17)
            checkBox6.Size = size
            Me.chkECEB.TabIndex = 14
            Me.chkECEB.Text = "Bill extra copy in Express Billing"
            Me.chkECEB.UseVisualStyleBackColor = True
            Me.chkECHD.AutoSize = True
            Dim checkBox7 As System.Windows.Forms.CheckBox = Me.chkECHD
            location = New System.Drawing.Point(19, 355)
            checkBox7.Location = location
            Me.chkECHD.Name = "chkECHD"
            Dim checkBox8 As System.Windows.Forms.CheckBox = Me.chkECHD
            size = New System.Drawing.Size(174, 17)
            checkBox8.Size = size
            Me.chkECHD.TabIndex = 13
            Me.chkECHD.Text = "Bill extra copy in Home Delivery"
            Me.chkECHD.UseVisualStyleBackColor = True
            Me.chkECTA.AutoSize = True
            Dim checkBox9 As System.Windows.Forms.CheckBox = Me.chkECTA
            location = New System.Drawing.Point(19, 332)
            checkBox9.Location = location
            Me.chkECTA.Name = "chkECTA"
            Dim checkBox10 As System.Windows.Forms.CheckBox = Me.chkECTA
            size = New System.Drawing.Size(159, 17)
            checkBox10.Size = size
            Me.chkECTA.TabIndex = 12
            Me.chkECTA.Text = "Bill extra copy in Take Away"
            Me.chkECTA.UseVisualStyleBackColor = True
            Me.chkECDB.AutoSize = True
            Dim checkBox11 As System.Windows.Forms.CheckBox = Me.chkECDB
            location = New System.Drawing.Point(19, 309)
            checkBox11.Location = location
            Me.chkECDB.Name = "chkECDB"
            Dim checkBox12 As System.Windows.Forms.CheckBox = Me.chkECDB
            size = New System.Drawing.Size(169, 17)
            checkBox12.Size = size
            Me.chkECDB.TabIndex = 11
            Me.chkECDB.Text = "Bill extra copy in Dine In Billing"
            Me.chkECDB.UseVisualStyleBackColor = True
            Me.chkECDI.AutoSize = True
            Dim checkBox13 As System.Windows.Forms.CheckBox = Me.chkECDI
            location = New System.Drawing.Point(19, 286)
            checkBox13.Location = location
            Me.chkECDI.Name = "chkECDI"
            Dim checkBox14 As System.Windows.Forms.CheckBox = Me.chkECDI
            size = New System.Drawing.Size(148, 17)
            checkBox14.Size = size
            Me.chkECDI.TabIndex = 10
            Me.chkECDI.Text = "KOT extra copy in Dine In"
            Me.chkECDI.UseVisualStyleBackColor = True
            Me.chkTL.AutoSize = True
            Dim checkBox15 As System.Windows.Forms.CheckBox = Me.chkTL
            location = New System.Drawing.Point(19, 263)
            checkBox15.Location = location
            Me.chkTL.Name = "chkTL"
            Dim checkBox16 As System.Windows.Forms.CheckBox = Me.chkTL
            size = New System.Drawing.Size(170, 17)
            checkBox16.Size = size
            Me.chkTL.TabIndex = 9
            Me.chkTL.Text = "Table Layout View (Floor Map)"
            Me.chkTL.UseVisualStyleBackColor = True
            Me.chkPDP.AutoSize = True
            Dim checkBox17 As System.Windows.Forms.CheckBox = Me.chkPDP
            location = New System.Drawing.Point(19, 216)
            checkBox17.Location = location
            Me.chkPDP.Name = "chkPDP"
            Dim checkBox18 As System.Windows.Forms.CheckBox = Me.chkPDP
            size = New System.Drawing.Size(186, 17)
            checkBox18.Size = size
            Me.chkPDP.TabIndex = 8
            Me.chkPDP.Text = "Ask Before Printing POS Receipts"
            Me.chkPDP.UseVisualStyleBackColor = True
            Me.cmbTaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTaxType.FormattingEnabled = True
            Me.cmbTaxType.Items.AddRange(New Object(1) {"Inclusive", "Exclusive"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbTaxType
            location = New System.Drawing.Point(112, 189)
            comboBox.Location = location
            Me.cmbTaxType.Name = "cmbTaxType"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbTaxType
            size = New System.Drawing.Size(121, 21)
            comboBox2.Size = size
            Me.cmbTaxType.TabIndex = 7
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(48, 189)
            label5.Location = location
            Me.Label5.Name = "Label5"
            Dim label6 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(58, 13)
            label6.Size = size
            Me.Label5.TabIndex = 13
            Me.Label5.Text = "Tax Type :"
            Me.chkKG.AutoSize = True
            Dim checkBox19 As System.Windows.Forms.CheckBox = Me.chkKG
            location = New System.Drawing.Point(19, 166)
            checkBox19.Location = location
            Me.chkKG.Name = "chkKG"
            Dim checkBox20 As System.Windows.Forms.CheckBox = Me.chkKG
            size = New System.Drawing.Size(217, 17)
            checkBox20.Size = size
            Me.chkKG.TabIndex = 6
            Me.chkKG.Text = "Open Cash Drawer in all payment modes"
            Me.chkKG.UseVisualStyleBackColor = True
            Me.chkEB.AutoSize = True
            Dim checkBox21 As System.Windows.Forms.CheckBox = Me.chkEB
            location = New System.Drawing.Point(157, 143)
            checkBox21.Location = location
            Me.chkEB.Name = "chkEB"
            Dim checkBox22 As System.Windows.Forms.CheckBox = Me.chkEB
            size = New System.Drawing.Size(93, 17)
            checkBox22.Size = size
            Me.chkEB.TabIndex = 5
            Me.chkEB.Text = "Express Billing"
            Me.chkEB.UseVisualStyleBackColor = True
            Me.chkHD.AutoSize = True
            Dim checkBox23 As System.Windows.Forms.CheckBox = Me.chkHD
            location = New System.Drawing.Point(157, 120)
            checkBox23.Location = location
            Me.chkHD.Name = "chkHD"
            Dim checkBox24 As System.Windows.Forms.CheckBox = Me.chkHD
            size = New System.Drawing.Size(95, 17)
            checkBox24.Size = size
            Me.chkHD.TabIndex = 4
            Me.chkHD.Text = "Home Delivery"
            Me.chkHD.UseVisualStyleBackColor = True
            Me.chkTA.AutoSize = True
            Dim checkBox25 As System.Windows.Forms.CheckBox = Me.chkTA
            location = New System.Drawing.Point(157, 97)
            checkBox25.Location = location
            Me.chkTA.Name = "chkTA"
            Dim checkBox26 As System.Windows.Forms.CheckBox = Me.chkTA
            size = New System.Drawing.Size(76, 17)
            checkBox26.Size = size
            Me.chkTA.TabIndex = 3
            Me.chkTA.Text = "Takeaway"
            Me.chkTA.UseVisualStyleBackColor = True
            Me.txVATPer.BackColor = System.Drawing.Color.White
            Me.txVATPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txVATPer
            location = New System.Drawing.Point(105, 71)
            textBox.Location = location
            Me.txVATPer.Name = "txVATPer"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txVATPer
            size = New System.Drawing.Size(60, 20)
            textBox2.Size = size
            Me.txVATPer.TabIndex = 2
            Me.txVATPer.Text = "0.00"
            Me.txVATPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(14, 71)
            label7.Location = location
            Me.Label9.Name = "Label9"
            Dim label8 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(91, 13)
            label8.Size = size
            Me.Label9.TabIndex = 12
            Me.Label9.Text = "Service Charge %:"
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label9 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(16, 98)
            label9.Location = location
            Me.Label7.Name = "Label7"
            Dim label10 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(135, 13)
            label10.Size = size
            Me.Label7.TabIndex = 10
            Me.Label7.Text = "Print Kitchen Order Ticket :"
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label11 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(27, 45)
            label11.Location = location
            Me.Label4.Name = "Label4"
            Dim label12 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(124, 13)
            label12.Size = size
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "Home Delivery Charges :"
            Me.txtParcelCharges.BackColor = System.Drawing.Color.White
            Me.txtParcelCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtParcelCharges
            location = New System.Drawing.Point(157, 20)
            textBox3.Location = location
            Me.txtParcelCharges.Name = "txtParcelCharges"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtParcelCharges
            size = New System.Drawing.Size(124, 20)
            textBox4.Size = size
            Me.txtParcelCharges.TabIndex = 0
            Me.txtParcelCharges.Text = "0.00"
            Me.txtParcelCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtHDCharges.BackColor = System.Drawing.Color.White
            Me.txtHDCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtHDCharges
            location = New System.Drawing.Point(157, 45)
            textBox5.Location = location
            Me.txtHDCharges.Name = "txtHDCharges"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtHDCharges
            size = New System.Drawing.Size(124, 20)
            textBox6.Size = size
            Me.txtHDCharges.TabIndex = 1
            Me.txtHDCharges.Text = "0.00"
            Me.txtHDCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label13 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(66, 20)
            label13.Location = location
            Me.Label2.Name = "Label2"
            Dim label14 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(85, 13)
            label14.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Parcel Charges :"
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(379, 3)
            button9.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button10 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(75, 38)
            button10.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
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
            Me.dgw.ColumnHeadersHeight = 35
            Me.dgw.Columns.AddRange(Me.Column3, Me.Column1, Me.Column2, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column4, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(6, 542)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.RowHeadersVisible = False
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(451, 94)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 1
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.txtID)
            Me.Panel2.Controls.Add(Me.lblUser)
            Me.Panel2.Controls.Add(Me.txtSCPer)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(3, 3)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(370, 31)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label15 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(125, 3)
            label15.Location = location
            Me.Label1.Name = "Label1"
            Dim label16 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(142, 24)
            label16.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Others Setting"
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(3, 7)
            textBox7.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(39, 20)
            textBox8.Size = size
            Me.txtID.TabIndex = 4
            Me.txtID.Visible = False
            Me.lblUser.AutoSize = True
            Dim label17 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(26, 10)
            label17.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label18 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label18.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.txtSCPer.BackColor = System.Drawing.Color.White
            Me.txtSCPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtSCPer
            location = New System.Drawing.Point(50, 3)
            textBox9.Location = location
            Me.txtSCPer.Name = "txtSCPer"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtSCPer
            size = New System.Drawing.Size(56, 20)
            textBox10.Size = size
            Me.txtSCPer.TabIndex = 3
            Me.txtSCPer.Text = "0.00"
            Me.txtSCPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtSCPer.Visible = False
            Me.txtSTPer.BackColor = System.Drawing.Color.White
            Me.txtSTPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtSTPer
            location = New System.Drawing.Point(270, 71)
            textBox11.Location = location
            Me.txtSTPer.Name = "txtSTPer"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtSTPer
            size = New System.Drawing.Size(65, 20)
            textBox12.Size = size
            Me.txtSTPer.TabIndex = 2
            Me.txtSTPer.Text = "0.00"
            Me.txtSTPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtSTPer.Visible = True
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label19 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(181, 71)
            label19.Location = location
            Me.Label3.Name = "Label3"
            Dim label20 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(83, 13)
            label20.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "SST Charge %:"
            Me.chkTLAP.AutoSize = True
            Me.chkTLAP.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.chkTLAP.ForeColor = System.Drawing.Color.MidnightBlue
            Dim checkBox27 As System.Windows.Forms.CheckBox = Me.chkTLAP
            location = New System.Drawing.Point(19, 444)
            checkBox27.Location = location
            Me.chkTLAP.Name = "chkTLAP"
            Dim checkBox28 As System.Windows.Forms.CheckBox = Me.chkTLAP
            size = New System.Drawing.Size(231, 19)
            checkBox28.Size = size
            Me.chkTLAP.TabIndex = 19
            Me.chkTLAP.Text = "Auto Pop up Tables List in POS Dine In"
            Me.chkTLAP.UseVisualStyleBackColor = True
            Me.chkShowSSTOnSecondaryDisplay.AutoSize = True
            Me.chkShowSSTOnSecondaryDisplay.Checked = True
            Me.chkShowSSTOnSecondaryDisplay.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkShowSSTOnSecondaryDisplay.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.chkShowSSTOnSecondaryDisplay.ForeColor = System.Drawing.Color.MidnightBlue
            Dim checkBox29 As System.Windows.Forms.CheckBox = Me.chkShowSSTOnSecondaryDisplay
            location = New System.Drawing.Point(19, 467)
            checkBox29.Location = location
            Me.chkShowSSTOnSecondaryDisplay.Name = "chkShowSSTOnSecondaryDisplay"
            Dim checkBox30 As System.Windows.Forms.CheckBox = Me.chkShowSSTOnSecondaryDisplay
            size = New System.Drawing.Size(290, 19)
            checkBox30.Size = size
            Me.chkShowSSTOnSecondaryDisplay.TabIndex = 20
            Me.chkShowSSTOnSecondaryDisplay.Text = "Show SST column on colored customer display"
            Me.chkShowSSTOnSecondaryDisplay.UseVisualStyleBackColor = True
            Me.Column3.HeaderText = "ID"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Visible = False
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column1.DefaultCellStyle = dataGridViewCellStyle5
            Me.Column1.HeaderText = "Parcel Charges"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column2.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column2.HeaderText = "Home Delivery Charges"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column5.DefaultCellStyle = dataGridViewCellStyle7
            Me.Column5.HeaderText = "SST Charge %"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column6.DefaultCellStyle = dataGridViewCellStyle8
            Me.Column6.HeaderText = "service charge%"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column7.DefaultCellStyle = dataGridViewCellStyle9
            Me.Column7.HeaderText = "service charges %"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column7.Visible = False
            Me.Column8.HeaderText = "KOT Print in Takeaway"
            Me.Column8.Name = "Column8"
            Me.Column8.[ReadOnly] = True
            Me.Column9.HeaderText = "KOT Print in Home Delivery"
            Me.Column9.Name = "Column9"
            Me.Column9.[ReadOnly] = True
            Me.Column10.HeaderText = "KOT Print in Express Billing"
            Me.Column10.Name = "Column10"
            Me.Column10.[ReadOnly] = True
            Me.Column11.HeaderText = "Open Cash Drawer in all Payment Modes"
            Me.Column11.Name = "Column11"
            Me.Column11.[ReadOnly] = True
            Me.Column4.HeaderText = "Tax Type"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column12.HeaderText = "Print Dialog Prompt in POS"
            Me.Column12.Name = "Column12"
            Me.Column12.[ReadOnly] = True
            Me.Column13.HeaderText = "Table Layout View"
            Me.Column13.Name = "Column13"
            Me.Column13.[ReadOnly] = True
            Me.Column14.HeaderText = "C1"
            Me.Column14.Name = "Column14"
            Me.Column14.[ReadOnly] = True
            Me.Column15.HeaderText = "C2"
            Me.Column15.Name = "Column15"
            Me.Column15.[ReadOnly] = True
            Me.Column16.HeaderText = "C3"
            Me.Column16.Name = "Column16"
            Me.Column16.[ReadOnly] = True
            Me.Column17.HeaderText = "C4"
            Me.Column17.Name = "Column17"
            Me.Column17.[ReadOnly] = True
            Me.Column18.HeaderText = "C5"
            Me.Column18.Name = "Column18"
            Me.Column18.[ReadOnly] = True
            Me.Column19.HeaderText = "Add last placed items (Old Items) in Updated Dine In KOT"
            Me.Column19.Name = "Column19"
            Me.Column19.[ReadOnly] = True
            Me.Column20.HeaderText = "A2"
            Me.Column20.Name = "Column20"
            Me.Column20.[ReadOnly] = True
            Me.Column21.HeaderText = "Auto Pop up Tables List in POS"
            Me.Column21.Name = "Column21"
            Me.Column21.[ReadOnly] = True
            Me.Column22.HeaderText = "Show SST column on colored customer display"
            Me.Column22.Name = "Column22"
            Me.Column22.[ReadOnly] = True
            MyBase.AcceptButton = Me.btnSave
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(470, 646)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmOthersSetting"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
