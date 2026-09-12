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
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmSupplier
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel4")>
        Private _Panel4 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSupplierID")>
        Private _txtSupplierID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddress")>
        Private _txtAddress As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtRemarks")>
        Private _txtRemarks As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSupplierName")>
        Private _txtSupplierName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmailID")>
        Private _txtEmailID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCity")>
        Private _txtCity As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label12")>
        Private _Label12 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtZipCode")>
        Private _txtZipCode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbState")>
        Private _cmbState As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSupName")>
        Private _txtSupName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGetData")>
        Private _btnGetData As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtT_ID")>
        Private _txtT_ID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTransactionNo")>
        Private _txtTransactionNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPAN")>
        Private _txtPAN As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtHSTNo")>
        Private _txtHSTNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCIN")>
        Private _txtCIN As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSTNo")>
        Private _txtSTNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBank")>
        Private _txtBank As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label22")>
        Private _Label22 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label17")>
        Private _Label17 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtIFSCcode")>
        Private _txtIFSCcode As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label18")>
        Private _Label18 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBranch")>
        Private _txtBranch As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label20")>
        Private _Label20 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label21")>
        Private _Label21 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAccountNo")>
        Private _txtAccountNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAccountName")>
        Private _txtAccountName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtOpeningBalance")>
        Private _txtOpeningBalance As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label15")>
        Private _Label15 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbOpeningBalanceType")>
        Private _cmbOpeningBalanceType As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

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

        Friend Overridable Property txtSupplierID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSupplierID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSupplierID = value
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

        Friend Overridable Property txtAddress As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAddress
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAddress = value
            End Set
        End Property

        Friend Overridable Property txtRemarks As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtRemarks
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtRemarks = value
            End Set
        End Property

        Friend Overridable Property txtSupplierName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSupplierName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSupplierName = value
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

        Friend Overridable Property txtCity As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCity
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCity = value
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

        Friend Overridable Property txtZipCode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtZipCode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtZipCode = value
            End Set
        End Property

        Friend Overridable Property cmbState As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbState
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.Windows.Forms.ListControlConvertEventHandler = AddressOf Me.cmbState_Format
                If Me._cmbState IsNot Nothing Then
                    RemoveHandler Me._cmbState.Format, value2
                End If

                Me._cmbState = value
                If Me._cmbState IsNot Nothing Then
                    AddHandler Me._cmbState.Format, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtSupName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSupName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSupName = value
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
                Dim value2 As System.EventHandler = AddressOf Me.btnClose_Click_1
                If Me._btnClose IsNot Nothing Then
                    RemoveHandler Me._btnClose.Click, value2
                End If

                Me._btnClose = value
                If Me._btnClose IsNot Nothing Then
                    AddHandler Me._btnClose.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtT_ID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtT_ID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtT_ID = value
            End Set
        End Property

        Friend Overridable Property txtTransactionNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTransactionNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTransactionNo = value
            End Set
        End Property

        Friend Overridable Property txtPAN As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPAN
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPAN = value
            End Set
        End Property

        Friend Overridable Property txtHSTNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtHSTNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtHSTNo = value
            End Set
        End Property

        Friend Overridable Property txtCIN As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCIN
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCIN = value
            End Set
        End Property

        Friend Overridable Property txtSTNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSTNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSTNo = value
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

        Public Overridable Property txtBank As System.Windows.Forms.TextBox
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

        Friend Overridable Property Label22 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label22
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label22 = value
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

        Public Overridable Property txtIFSCcode As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtIFSCcode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtIFSCcode = value
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

        Public Overridable Property txtBranch As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBranch
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBranch = value
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

        Friend Overridable Property Label21 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label21
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label21 = value
            End Set
        End Property

        Public Overridable Property txtAccountNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAccountNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAccountNo = value
            End Set
        End Property

        Public Overridable Property txtAccountName As System.Windows.Forms.TextBox
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

        Friend Overridable Property txtOpeningBalance As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtOpeningBalance
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtOpeningBalance_KeyPress
                If Me._txtOpeningBalance IsNot Nothing Then
                    RemoveHandler Me._txtOpeningBalance.KeyPress, value2
                End If

                Me._txtOpeningBalance = value
                If Me._txtOpeningBalance IsNot Nothing Then
                    AddHandler Me._txtOpeningBalance.KeyPress, value2
                End If
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

        Friend Overridable Property cmbOpeningBalanceType As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbOpeningBalanceType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbOpeningBalanceType = value
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

        Friend Overridable Property lblSet As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblSet
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblSet = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmSupplier_Load
            Call RestaurantPOS14.frmSupplier.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSupplier.__ENCList
                If RestaurantPOS14.frmSupplier.__ENCList.Count = RestaurantPOS14.frmSupplier.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSupplier.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSupplier.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSupplier.__ENCList(num) = RestaurantPOS14.frmSupplier.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSupplier.__ENCList.RemoveRange(num, RestaurantPOS14.frmSupplier.__ENCList.Count - num)
                    RestaurantPOS14.frmSupplier.__ENCList.Capacity = RestaurantPOS14.frmSupplier.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSupplier.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtSupplierName.Text = ""
            Me.txtAddress.Text = ""
            Me.txtRemarks.Text = ""
            Me.txtSupplierName.Text = ""
            Me.txtSupplierID.Text = ""
            Me.txtContactNo.Text = ""
            Me.txtEmailID.Text = ""
            Me.cmbState.Text = ""
            Me.txtZipCode.Text = ""
            Me.txtCity.Text = ""
            Me.txtSupplierName.Focus()
            Me.txtHSTNo.Text = ""
            Me.txtPAN.Text = ""
            Me.txtCIN.Text = ""
            Me.txtSTNo.Text = ""
            Me.txtAccountName.Text = ""
            Me.txtAccountNo.Text = ""
            Me.txtBank.Text = ""
            Me.txtBranch.Text = ""
            Me.txtIFSCcode.Text = ""
            Me.cmbOpeningBalanceType.SelectedIndex = 0
            Me.txtOpeningBalance.Text = "0.00"
            Me.cmbOpeningBalanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbOpeningBalanceType.Enabled = True
            Me.txtOpeningBalance.[ReadOnly] = False
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Supplier") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Supplier") Then
                Me.btnSave.Enabled = True
                Me.btnExportExcel.Enabled = True
            Else
                Me.btnSave.Enabled = False
                Me.btnExportExcel.Enabled = False
            End If

            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.txtSupplierName.Enabled = True
            Me.auto()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Function GenerateID() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            Dim text As String = "0000"
            Try
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 ID FROM Supplier ORDER BY ID DESC", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.HasRows Then
                    RestaurantPOS14.ModClasses.rdr.Read()
                    text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr("ID"))
                End If

                RestaurantPOS14.ModClasses.rdr.Close()
                text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(text) + 1.0)
                If Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(text) <= 9.0 Then
                    text = "000" & text
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(text) <= 99.0 Then
                    text = "00" & text
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(text) <= 999.0 Then
                    text = "0" & text
                End If
            Catch __unusedException1__ As System.Exception
                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                text = "0000"
            End Try

            Return text
        End Function

        Public Sub auto()
            Try
                Me.txtID.Text = Me.GenerateID()
                Me.txtSupplierID.Text = "S-" & Me.GenerateID()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Supplier.ID FROM Supplier INNER JOIN PurchaseOrder ON Supplier.ID = PurchaseOrder.Supplier_ID where Supplier.ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Purchase Order", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Supplier.ID FROM Supplier INNER JOIN Purchase ON Supplier.ID = Purchase.Supplier_ID where Supplier.ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Purchase Entry", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Supplier.ID FROM Supplier INNER JOIN Payment ON Supplier.ID = Payment.SupplierID where Supplier.ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Payment Entry", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Payment where SupplierID =" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID") & " and Amount=0")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from Supplier where ID =" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID"))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    RestaurantPOS14.ModFunc.LedgerDelete(Me.txtSupplierID.Text, "Opening Balance")
                    RestaurantPOS14.ModFunc.SupplierLedgerDelete(Me.txtSupplierID.Text)
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "deleted the supplier record having supplier id '" & Me.txtSupplierID.Text & "'")
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                    Me.fillState()
                Else
                    Call System.Windows.Forms.MessageBox.Show("No record found", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                    If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                        RestaurantPOS14.ModClasses.con.Close()
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmSupplier_Load(sender As Object, e As System.EventArgs)
            Me.fillState()
        End Sub

        Public Sub fillState()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(State) FROM Supplier order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbState.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbState.Items.Add(dataRow(CInt((0))).ToString())
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbState_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs)
            If e.DesiredType Is GetType(String) Then
                e.Value = e.Value.ToString().Trim()
            End If
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtSupplierName.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter supplier name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtSupplierName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtAddress.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Address", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddress.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtCity.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter City", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCity.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtContactNo.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Contact No.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtOpeningBalance.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Opening Balance", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtOpeningBalance.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Name from Supplier where Name=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtSupplierName.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Supplier Name already exists", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtSupplierName.Text = ""
                    Me.txtSupplierName.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select RTRIM(ContactNo) from Supplier where ContactNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Entered contact no. is already registered", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into Supplier(ID, SupplierID, [Name], Address, City, ContactNo, EmailID,Remarks,State,ZipCode,TIN,STNo,CST,PAN,AccountName,AccountNumber,Bank,Branch,IFSCCode,OpeningBalance,OpeningBalanceType) VALUES (@d1,@d2,@d3,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21,@d22)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtSupplierID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtSupplierName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtCity.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.txtEmailID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.txtRemarks.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Me.cmbState.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.txtZipCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Me.txtHSTNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Me.txtSTNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Me.txtCIN.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Me.txtPAN.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.txtAccountName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d18", Me.txtBank.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d19", Me.txtBranch.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d20", Me.txtIFSCcode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d21", Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d22", Me.cmbOpeningBalanceType.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                If(Me.cmbOpeningBalanceType.SelectedIndex = 0) And (Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text) > 0.0) Then
                    RestaurantPOS14.ModFunc.LedgerSave(Microsoft.VisualBasic.DateAndTime.Today, Me.txtSupplierName.Text, Me.txtSupplierID.Text, "Opening Balance", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text)), Me.txtSupplierID.Text, "Opening")
                End If

                If(Me.cmbOpeningBalanceType.SelectedIndex = 1) And (Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text) > 0.0) Then
                    RestaurantPOS14.ModFunc.LedgerSave(Microsoft.VisualBasic.DateAndTime.Today, Me.txtSupplierName.Text, Me.txtSupplierID.Text, "Opening Balance", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtOpeningBalance.Text)), 0D, Me.txtSupplierID.Text, "Opening")
                End If

                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "added the new supplier having supplier id '" & Me.txtSupplierID.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Supplier Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                Me.fillState()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtSupplierName.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter supplier name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtSupplierName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtAddress.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Address", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddress.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtCity.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter City", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCity.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbState.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter state", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbState.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtContactNo.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please Enter Contact No.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update Product set P_Supplier=@d3 where P_Supplier=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtSupName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtSupplierName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update LedgerBook set [Name]=@d3 where PartyID=@d1 and Name=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtSupplierID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtSupName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtSupplierName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update supplier set SupplierID=@d2,[Name]=@d3, Address=@d5,City=@d6, ContactNo=@d7, EmailID=@d8,Remarks=@d9,State=@d10,ZipCode=@d11,TIN=@d12,STNo=@d13,CST=@d14,PAN=@d15,AccountName=@d16,AccountNumber=@d17,Bank=@d18,Branch=@d19,IFSCCode=@d20 where ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtSupplierID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtSupplierName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtCity.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.txtEmailID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.txtRemarks.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Me.cmbState.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.txtZipCode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Me.txtHSTNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Me.txtSTNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Me.txtCIN.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", Me.txtPAN.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.txtAccountName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", Me.txtAccountNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d18", Me.txtBank.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d19", Me.txtBranch.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d20", Me.txtIFSCcode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "updated the supplier having supplier id '" & Me.txtSupplierID.Text & "'")
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Supplier Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
                Me.fillState()
                RestaurantPOS14.ModClasses.con.Close()
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

        Private Sub btnGetData_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.lblSet.Text = "Supplier Entry"
            RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.ShowDialog()
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Product", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmProduct.fillSupplier()
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "ANS", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmSupplierRecord.Getdata()
            End If

            MyBase.Close()
        End Sub

        Private Sub txtOpeningBalance_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtOpeningBalance.Text
                Dim selectionStart As Integer = Me.txtOpeningBalance.SelectionStart
                Dim selectionLength As Integer = Me.txtOpeningBalance.SelectionLength
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

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmImportExportExcel_Supplier.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmImportExportExcel_Supplier.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSupplier))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.cmbOpeningBalanceType = New System.Windows.Forms.ComboBox()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.txtOpeningBalance = New System.Windows.Forms.TextBox()
            Me.txtPAN = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtBank = New System.Windows.Forms.TextBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.txtIFSCcode = New System.Windows.Forms.TextBox()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.txtBranch = New System.Windows.Forms.TextBox()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.txtAccountNo = New System.Windows.Forms.TextBox()
            Me.txtAccountName = New System.Windows.Forms.TextBox()
            Me.txtCIN = New System.Windows.Forms.TextBox()
            Me.txtSTNo = New System.Windows.Forms.TextBox()
            Me.txtSupName = New System.Windows.Forms.TextBox()
            Me.cmbState = New System.Windows.Forms.ComboBox()
            Me.txtHSTNo = New System.Windows.Forms.TextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.txtZipCode = New System.Windows.Forms.TextBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtCity = New System.Windows.Forms.TextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtSupplierName = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtSupplierID = New System.Windows.Forms.TextBox()
            Me.txtAddress = New System.Windows.Forms.TextBox()
            Me.txtRemarks = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtEmailID = New System.Windows.Forms.TextBox()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtTransactionNo = New System.Windows.Forms.TextBox()
            Me.txtT_ID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnExportExcel)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(6, 7)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(765, 538)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(651, 295)
            button.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button2 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(108, 61)
            button2.Size = size
            Me.btnExportExcel.TabIndex = 9
            Me.btnExportExcel.Text = "Import/" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = RestaurantPOS14.My.Resources.Resources.Close_32x32
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(683, 7)
            button3.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button4 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(76, 38)
            button4.Size = size
            Me.btnClose.TabIndex = 8
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.btnNew)
            Me.GroupBox2.Controls.Add(Me.btnGetData)
            Me.GroupBox2.Controls.Add(Me.btnSave)
            Me.GroupBox2.Controls.Add(Me.btnUpdate)
            Me.GroupBox2.Controls.Add(Me.btnDelete)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(651, 52)
            groupBox.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(108, 237)
            groupBox2.Size = size
            Me.GroupBox2.TabIndex = 7
            Me.GroupBox2.TabStop = False
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 14)
            button5.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button6 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(92, 40)
            button6.Size = size
            Me.btnNew.TabIndex = 1
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(8, 190)
            button7.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button8 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(92, 40)
            button8.Size = size
            Me.btnGetData.TabIndex = 5
            Me.btnGetData.Text = "Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(9, 58)
            button9.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button10 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(92, 40)
            button10.Size = size
            Me.btnSave.TabIndex = 2
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Enabled = False
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(9, 102)
            button11.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button12 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(92, 40)
            button12.Size = size
            Me.btnUpdate.TabIndex = 3
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button13 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(9, 146)
            button13.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button14 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(92, 40)
            button14.Size = size
            Me.btnDelete.TabIndex = 4
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.lblSet)
            Me.Panel4.Controls.Add(Me.Label8)
            Me.Panel4.Controls.Add(Me.cmbOpeningBalanceType)
            Me.Panel4.Controls.Add(Me.Label15)
            Me.Panel4.Controls.Add(Me.txtOpeningBalance)
            Me.Panel4.Controls.Add(Me.txtPAN)
            Me.Panel4.Controls.Add(Me.GroupBox1)
            Me.Panel4.Controls.Add(Me.txtCIN)
            Me.Panel4.Controls.Add(Me.txtSTNo)
            Me.Panel4.Controls.Add(Me.txtSupName)
            Me.Panel4.Controls.Add(Me.cmbState)
            Me.Panel4.Controls.Add(Me.txtHSTNo)
            Me.Panel4.Controls.Add(Me.Label12)
            Me.Panel4.Controls.Add(Me.Label9)
            Me.Panel4.Controls.Add(Me.txtZipCode)
            Me.Panel4.Controls.Add(Me.lblUser)
            Me.Panel4.Controls.Add(Me.txtID)
            Me.Panel4.Controls.Add(Me.Label4)
            Me.Panel4.Controls.Add(Me.txtCity)
            Me.Panel4.Controls.Add(Me.Label10)
            Me.Panel4.Controls.Add(Me.txtSupplierName)
            Me.Panel4.Controls.Add(Me.Label2)
            Me.Panel4.Controls.Add(Me.Label3)
            Me.Panel4.Controls.Add(Me.txtSupplierID)
            Me.Panel4.Controls.Add(Me.txtAddress)
            Me.Panel4.Controls.Add(Me.txtRemarks)
            Me.Panel4.Controls.Add(Me.Label5)
            Me.Panel4.Controls.Add(Me.Label7)
            Me.Panel4.Controls.Add(Me.txtEmailID)
            Me.Panel4.Controls.Add(Me.txtContactNo)
            Me.Panel4.Controls.Add(Me.Label6)
            Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel4
            location = New System.Drawing.Point(9, 52)
            panel3.Location = location
            Me.Panel4.Name = "Panel4"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel4
            size = New System.Drawing.Size(636, 479)
            panel4.Size = size
            Me.Panel4.TabIndex = 0
            Me.Label8.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(10, 227)
            label.Location = location
            Me.Label8.Name = "Label8"
            Dim label2 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(84, 15)
            label2.Size = size
            Me.Label8.TabIndex = 307
            Me.Label8.Text = "TRN/VAT No. :"
            Me.cmbOpeningBalanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbOpeningBalanceType.FormattingEnabled = True
            Me.cmbOpeningBalanceType.Items.AddRange(New Object(1) {"CR", "DR"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbOpeningBalanceType
            location = New System.Drawing.Point(241, 254)
            comboBox.Location = location
            Me.cmbOpeningBalanceType.Name = "cmbOpeningBalanceType"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbOpeningBalanceType
            size = New System.Drawing.Size(50, 23)
            comboBox2.Size = size
            Me.cmbOpeningBalanceType.TabIndex = 9
            Me.Label15.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label15
            location = New System.Drawing.Point(10, 254)
            label3.Location = location
            Me.Label15.Name = "Label15"
            Dim label4 As System.Windows.Forms.Label = Me.Label15
            size = New System.Drawing.Size(108, 15)
            label4.Size = size
            Me.Label15.TabIndex = 306
            Me.Label15.Text = "Opening Balance :"
            Me.txtOpeningBalance.BackColor = System.Drawing.Color.White
            Me.txtOpeningBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtOpeningBalance
            location = New System.Drawing.Point(125, 254)
            textBox.Location = location
            Me.txtOpeningBalance.Name = "txtOpeningBalance"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtOpeningBalance
            size = New System.Drawing.Size(110, 21)
            textBox2.Size = size
            Me.txtOpeningBalance.TabIndex = 8
            Me.txtOpeningBalance.Text = "0.00"
            Me.txtOpeningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtPAN.BackColor = System.Drawing.Color.White
            Me.txtPAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtPAN
            location = New System.Drawing.Point(443, 262)
            textBox3.Location = location
            Me.txtPAN.Name = "txtPAN"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtPAN
            size = New System.Drawing.Size(82, 21)
            textBox4.Size = size
            Me.txtPAN.TabIndex = 11
            Me.txtPAN.Visible = False
            Me.GroupBox1.Controls.Add(Me.txtBank)
            Me.GroupBox1.Controls.Add(Me.Label22)
            Me.GroupBox1.Controls.Add(Me.Label17)
            Me.GroupBox1.Controls.Add(Me.txtIFSCcode)
            Me.GroupBox1.Controls.Add(Me.Label18)
            Me.GroupBox1.Controls.Add(Me.txtBranch)
            Me.GroupBox1.Controls.Add(Me.Label20)
            Me.GroupBox1.Controls.Add(Me.Label21)
            Me.GroupBox1.Controls.Add(Me.txtAccountNo)
            Me.GroupBox1.Controls.Add(Me.txtAccountName)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(297, 317)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(327, 153)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 11
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Bank Details"
            Me.txtBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtBank
            location = New System.Drawing.Point(146, 71)
            textBox5.Location = location
            Me.txtBank.Name = "txtBank"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtBank
            size = New System.Drawing.Size(166, 20)
            textBox6.Size = size
            Me.txtBank.TabIndex = 2
            Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label22.AutoSize = True
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label22.ForeColor = System.Drawing.Color.Black
            Dim label5 As System.Windows.Forms.Label = Me.Label22
            location = New System.Drawing.Point(23, 123)
            label5.Location = location
            Me.Label22.Name = "Label22"
            Dim label6 As System.Windows.Forms.Label = Me.Label22
            size = New System.Drawing.Size(93, 13)
            label6.Size = size
            Me.Label22.TabIndex = 338
            Me.Label22.Text = "Swift/IBAN code :"
            Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label17.ForeColor = System.Drawing.Color.Black
            Dim label7 As System.Windows.Forms.Label = Me.Label17
            location = New System.Drawing.Point(23, 45)
            label7.Location = location
            Me.Label17.Name = "Label17"
            Dim label8 As System.Windows.Forms.Label = Me.Label17
            size = New System.Drawing.Size(73, 13)
            label8.Size = size
            Me.Label17.TabIndex = 326
            Me.Label17.Text = "Account No. :"
            Me.txtIFSCcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtIFSCcode
            location = New System.Drawing.Point(146, 123)
            textBox7.Location = location
            Me.txtIFSCcode.Name = "txtIFSCcode"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtIFSCcode
            size = New System.Drawing.Size(166, 20)
            textBox8.Size = size
            Me.txtIFSCcode.TabIndex = 4
            Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label18.ForeColor = System.Drawing.Color.Black
            Dim label9 As System.Windows.Forms.Label = Me.Label18
            location = New System.Drawing.Point(23, 18)
            label9.Location = location
            Me.Label18.Name = "Label18"
            Dim label10 As System.Windows.Forms.Label = Me.Label18
            size = New System.Drawing.Size(84, 13)
            label10.Size = size
            Me.Label18.TabIndex = 0
            Me.Label18.Text = "Account Name :"
            Me.txtBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtBranch
            location = New System.Drawing.Point(146, 97)
            textBox9.Location = location
            Me.txtBranch.Name = "txtBranch"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtBranch
            size = New System.Drawing.Size(166, 20)
            textBox10.Size = size
            Me.txtBranch.TabIndex = 3
            Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label20.ForeColor = System.Drawing.Color.Black
            Dim label11 As System.Windows.Forms.Label = Me.Label20
            location = New System.Drawing.Point(24, 71)
            label11.Location = location
            Me.Label20.Name = "Label20"
            Dim label12 As System.Windows.Forms.Label = Me.Label20
            size = New System.Drawing.Size(38, 13)
            label12.Size = size
            Me.Label20.TabIndex = 328
            Me.Label20.Text = "Bank :"
            Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label21.AutoSize = True
            Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label21.ForeColor = System.Drawing.Color.Black
            Dim label13 As System.Windows.Forms.Label = Me.Label21
            location = New System.Drawing.Point(24, 97)
            label13.Location = location
            Me.Label21.Name = "Label21"
            Dim label14 As System.Windows.Forms.Label = Me.Label21
            size = New System.Drawing.Size(47, 13)
            label14.Size = size
            Me.Label21.TabIndex = 329
            Me.Label21.Text = "Branch :"
            Me.txtAccountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtAccountNo
            location = New System.Drawing.Point(146, 45)
            textBox11.Location = location
            Me.txtAccountNo.Name = "txtAccountNo"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtAccountNo
            size = New System.Drawing.Size(166, 20)
            textBox12.Size = size
            Me.txtAccountNo.TabIndex = 1
            Me.txtAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtAccountName
            location = New System.Drawing.Point(146, 18)
            textBox13.Location = location
            Me.txtAccountName.Name = "txtAccountName"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtAccountName
            size = New System.Drawing.Size(166, 20)
            textBox14.Size = size
            Me.txtAccountName.TabIndex = 0
            Me.txtCIN.BackColor = System.Drawing.Color.White
            Me.txtCIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtCIN
            location = New System.Drawing.Point(443, 235)
            textBox15.Location = location
            Me.txtCIN.Name = "txtCIN"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtCIN
            size = New System.Drawing.Size(82, 21)
            textBox16.Size = size
            Me.txtCIN.TabIndex = 10
            Me.txtCIN.Visible = False
            Me.txtSTNo.BackColor = System.Drawing.Color.White
            Me.txtSTNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtSTNo
            location = New System.Drawing.Point(443, 208)
            textBox17.Location = location
            Me.txtSTNo.Name = "txtSTNo"
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtSTNo
            size = New System.Drawing.Size(70, 21)
            textBox18.Size = size
            Me.txtSTNo.TabIndex = 2
            Me.txtSTNo.Visible = False
            Dim textBox19 As System.Windows.Forms.TextBox = Me.txtSupName
            location = New System.Drawing.Point(333, 31)
            textBox19.Location = location
            Me.txtSupName.Name = "txtSupName"
            Dim textBox20 As System.Windows.Forms.TextBox = Me.txtSupName
            size = New System.Drawing.Size(111, 21)
            textBox20.Size = size
            Me.txtSupName.TabIndex = 296
            Me.txtSupName.Visible = False
            Me.cmbState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbState.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbState
            location = New System.Drawing.Point(125, 118)
            comboBox3.Location = location
            Me.cmbState.Name = "cmbState"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbState
            size = New System.Drawing.Size(166, 23)
            comboBox4.Size = size
            Me.cmbState.TabIndex = 3
            Me.txtHSTNo.BackColor = System.Drawing.Color.White
            Me.txtHSTNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtHSTNo
            location = New System.Drawing.Point(125, 227)
            textBox21.Location = location
            Me.txtHSTNo.Name = "txtHSTNo"
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtHSTNo
            size = New System.Drawing.Size(166, 21)
            textBox22.Size = size
            Me.txtHSTNo.TabIndex = 7
            Me.Label12.AutoSize = True
            Dim label15 As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(10, 146)
            label15.Location = location
            Me.Label12.Name = "Label12"
            Dim label16 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(79, 15)
            label16.Size = size
            Me.Label12.TabIndex = 295
            Me.Label12.Text = "Postal Code :"
            Me.Label9.AutoSize = True
            Dim label17 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(10, 119)
            label17.Location = location
            Me.Label9.Name = "Label9"
            Dim label18 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(41, 15)
            label18.Size = size
            Me.Label9.TabIndex = 294
            Me.Label9.Text = "State :"
            Me.txtZipCode.BackColor = System.Drawing.Color.White
            Me.txtZipCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtZipCode
            location = New System.Drawing.Point(125, 146)
            textBox23.Location = location
            Me.txtZipCode.Name = "txtZipCode"
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtZipCode
            size = New System.Drawing.Size(166, 21)
            textBox24.Size = size
            Me.txtZipCode.TabIndex = 4
            Me.lblUser.AutoSize = True
            Dim label19 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(330, 30)
            label19.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label20 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(45, 15)
            label20.Size = size
            Me.lblUser.TabIndex = 5
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Dim textBox25 As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(333, 6)
            textBox25.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox26 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(111, 21)
            textBox26.Size = size
            Me.txtID.TabIndex = 4
            Me.txtID.Visible = False
            Me.Label4.AutoSize = True
            Dim label21 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(10, 93)
            label21.Location = location
            Me.Label4.Name = "Label4"
            Dim label22 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(32, 15)
            label22.Size = size
            Me.Label4.TabIndex = 24
            Me.Label4.Text = "City :"
            Me.txtCity.BackColor = System.Drawing.Color.White
            Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox27 As System.Windows.Forms.TextBox = Me.txtCity
            location = New System.Drawing.Point(125, 92)
            textBox27.Location = location
            Me.txtCity.Name = "txtCity"
            Dim textBox28 As System.Windows.Forms.TextBox = Me.txtCity
            size = New System.Drawing.Size(166, 21)
            textBox28.Size = size
            Me.txtCity.TabIndex = 2
            Me.Label10.AutoSize = True
            Dim label23 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(7, 340)
            label23.Location = location
            Me.Label10.Name = "Label10"
            Dim label24 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(63, 15)
            label24.Size = size
            Me.Label10.TabIndex = 21
            Me.Label10.Text = "Remarks :"
            Me.txtSupplierName.BackColor = System.Drawing.Color.White
            Me.txtSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox29 As System.Windows.Forms.TextBox = Me.txtSupplierName
            location = New System.Drawing.Point(125, 38)
            textBox29.Location = location
            Me.txtSupplierName.Name = "txtSupplierName"
            Dim textBox30 As System.Windows.Forms.TextBox = Me.txtSupplierName
            size = New System.Drawing.Size(329, 21)
            textBox30.Size = size
            Me.txtSupplierName.TabIndex = 0
            Me.Label2.AutoSize = True
            Dim label25 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(10, 37)
            label25.Location = location
            Me.Label2.Name = "Label2"
            Dim label26 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(96, 15)
            label26.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Supplier Name :"
            Me.Label3.AutoSize = True
            Dim label27 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(10, 11)
            label27.Location = location
            Me.Label3.Name = "Label3"
            Dim label28 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(74, 15)
            label28.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Supplier ID :"
            Me.txtSupplierID.BackColor = System.Drawing.SystemColors.Control
            Me.txtSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox31 As System.Windows.Forms.TextBox = Me.txtSupplierID
            location = New System.Drawing.Point(125, 11)
            textBox31.Location = location
            Me.txtSupplierID.Name = "txtSupplierID"
            Me.txtSupplierID.[ReadOnly] = True
            Dim textBox32 As System.Windows.Forms.TextBox = Me.txtSupplierID
            size = New System.Drawing.Size(70, 21)
            textBox32.Size = size
            Me.txtSupplierID.TabIndex = 12
            Me.txtAddress.BackColor = System.Drawing.Color.White
            Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox33 As System.Windows.Forms.TextBox = Me.txtAddress
            location = New System.Drawing.Point(125, 66)
            textBox33.Location = location
            Me.txtAddress.Name = "txtAddress"
            Dim textBox34 As System.Windows.Forms.TextBox = Me.txtAddress
            size = New System.Drawing.Size(329, 21)
            textBox34.Size = size
            Me.txtAddress.TabIndex = 1
            Me.txtRemarks.BackColor = System.Drawing.Color.White
            Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox35 As System.Windows.Forms.TextBox = Me.txtRemarks
            location = New System.Drawing.Point(125, 283)
            textBox35.Location = location
            Me.txtRemarks.Multiline = True
            Me.txtRemarks.Name = "txtRemarks"
            Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Dim textBox36 As System.Windows.Forms.TextBox = Me.txtRemarks
            size = New System.Drawing.Size(166, 187)
            textBox36.Size = size
            Me.txtRemarks.TabIndex = 10
            Me.Label5.AutoSize = True
            Dim label29 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(10, 66)
            label29.Location = location
            Me.Label5.Name = "Label5"
            Dim label30 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(57, 15)
            label30.Size = size
            Me.Label5.TabIndex = 11
            Me.Label5.Text = "Address :"
            Me.Label7.AutoSize = True
            Dim label31 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(10, 173)
            label31.Location = location
            Me.Label7.Name = "Label7"
            Dim label32 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(73, 15)
            label32.Size = size
            Me.Label7.TabIndex = 13
            Me.Label7.Text = "Contact No :"
            Me.txtEmailID.BackColor = System.Drawing.Color.White
            Me.txtEmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox37 As System.Windows.Forms.TextBox = Me.txtEmailID
            location = New System.Drawing.Point(125, 200)
            textBox37.Location = location
            Me.txtEmailID.Name = "txtEmailID"
            Dim textBox38 As System.Windows.Forms.TextBox = Me.txtEmailID
            size = New System.Drawing.Size(166, 21)
            textBox38.Size = size
            Me.txtEmailID.TabIndex = 6
            Me.txtContactNo.BackColor = System.Drawing.Color.White
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox39 As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(125, 173)
            textBox39.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Dim textBox40 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(166, 21)
            textBox40.Size = size
            Me.txtContactNo.TabIndex = 5
            Me.Label6.AutoSize = True
            Dim label33 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(10, 200)
            label33.Location = location
            Me.Label6.Name = "Label6"
            Dim label34 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(60, 15)
            label34.Size = size
            Me.Label6.TabIndex = 12
            Me.Label6.Text = "Email ID :"
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.txtTransactionNo)
            Me.Panel2.Controls.Add(Me.txtT_ID)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(668, 39)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.txtTransactionNo.BackColor = System.Drawing.SystemColors.Control
            Me.txtTransactionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox41 As System.Windows.Forms.TextBox = Me.txtTransactionNo
            location = New System.Drawing.Point(44, 5)
            textBox41.Location = location
            Me.txtTransactionNo.Name = "txtTransactionNo"
            Me.txtTransactionNo.[ReadOnly] = True
            Dim textBox42 As System.Windows.Forms.TextBox = Me.txtTransactionNo
            size = New System.Drawing.Size(27, 21)
            textBox42.Size = size
            Me.txtTransactionNo.TabIndex = 3
            Me.txtTransactionNo.Visible = False
            Dim textBox43 As System.Windows.Forms.TextBox = Me.txtT_ID
            location = New System.Drawing.Point(3, 6)
            textBox43.Location = location
            Me.txtT_ID.Name = "txtT_ID"
            Dim textBox44 As System.Windows.Forms.TextBox = Me.txtT_ID
            size = New System.Drawing.Size(35, 20)
            textBox44.Size = size
            Me.txtT_ID.TabIndex = 2
            Me.txtT_ID.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label35 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(252, 6)
            label35.Location = location
            Me.Label1.Name = "Label1"
            Dim label36 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(142, 24)
            label36.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Supplier Entry"
            Me.lblSet.AutoSize = True
            Dim label37 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(298, 231)
            label37.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label38 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(38, 15)
            label38.Size = size
            Me.lblSet.TabIndex = 308
            Me.lblSet.Text = "lblSet"
            Me.lblSet.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(778, 549)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmSupplier"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
