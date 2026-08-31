Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports MetroFramework
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmCreditCustomerReceipt
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTransactionNo")>
        Private _txtTransactionNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpTranactionDate")>
        Private _dtpTranactionDate As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtRemarks")>
        Private _txtRemarks As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label12")>
        Private _Label12 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCustID")>
        Private _txtCustID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtT_ID")>
        Private _txtT_ID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("gbPartyInfo")>
        Private _gbPartyInfo As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSelection")>
        Private _btnSelection As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCustomerID")>
        Private _txtCustomerID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblBalance")>
        Private _lblBalance As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label11")>
        Private _Label11 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCustomerName")>
        Private _txtCustomerName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddress")>
        Private _txtAddress As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label26")>
        Private _Label26 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label30")>
        Private _Label30 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label36")>
        Private _Label36 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label19")>
        Private _Label19 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTransactionAmount")>
        Private _txtTransactionAmount As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbPaymentMode")>
        Private _cmbPaymentMode As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox3")>
        Private _TextBox3 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox2")>
        Private _TextBox2 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox1")>
        Private _TextBox1 As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPaymentModeDetails")>
        Private _txtPaymentModeDetails As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTempAmt")>
        Private _txtTempAmt As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPrint")>
        Private _btnPrint As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        Private str As String

        Private OBType As String

        Private num1 As Decimal

        Private num2 As Decimal

        Private num3 As Decimal

        Private num4 As Decimal

        Private i As Integer

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

        Friend Overridable Property dtpTranactionDate As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpTranactionDate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpTranactionDate = value
            End Set
        End Property

        Friend Overridable Property txtRemarks As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtRemarks
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtRemarks = value
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

        Friend Overridable Property txtCustID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCustID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCustID = value
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

        Friend Overridable Property lblUserType As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUserType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUserType = value
            End Set
        End Property

        Friend Overridable Property gbPartyInfo As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._gbPartyInfo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._gbPartyInfo = value
            End Set
        End Property

        Friend Overridable Property btnSelection As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSelection
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSelection_Click
                If Me._btnSelection IsNot Nothing Then
                    RemoveHandler Me._btnSelection.Click, value2
                End If

                Me._btnSelection = value
                If Me._btnSelection IsNot Nothing Then
                    AddHandler Me._btnSelection.Click, value2
                End If
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

        Friend Overridable Property txtCustomerID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCustomerID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCustomerID = value
            End Set
        End Property

        Friend Overridable Property lblBalance As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblBalance
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblBalance = value
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

        Friend Overridable Property txtCustomerName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCustomerName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCustomerName = value
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

        Friend Overridable Property Label26 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label26
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label26 = value
            End Set
        End Property

        Friend Overridable Property Label30 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label30
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label30 = value
            End Set
        End Property

        Friend Overridable Property Label36 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label36
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label36 = value
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

        Friend Overridable Property txtTransactionAmount As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTransactionAmount
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtTotalPaid_KeyPress
                If Me._txtTransactionAmount IsNot Nothing Then
                    RemoveHandler Me._txtTransactionAmount.KeyPress, value2
                End If

                Me._txtTransactionAmount = value
                If Me._txtTransactionAmount IsNot Nothing Then
                    AddHandler Me._txtTransactionAmount.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property cmbPaymentMode As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbPaymentMode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbPaymentMode = value
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

        Friend Overridable Property TextBox3 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox3 = value
            End Set
        End Property

        Friend Overridable Property TextBox2 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox2 = value
            End Set
        End Property

        Friend Overridable Property TextBox1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox1 = value
            End Set
        End Property

        Friend Overridable Property txtPaymentModeDetails As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPaymentModeDetails
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtPaymentModeDetails = value
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

        Friend Overridable Property txtTempAmt As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTempAmt
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTempAmt = value
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

        Public Sub New()
            Call RestaurantPOS14.frmCreditCustomerReceipt.__ENCAddToList(Me)
            Me.i = 0
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCreditCustomerReceipt.__ENCList
                If RestaurantPOS14.frmCreditCustomerReceipt.__ENCList.Count = RestaurantPOS14.frmCreditCustomerReceipt.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCreditCustomerReceipt.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCreditCustomerReceipt.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCreditCustomerReceipt.__ENCList(num) = RestaurantPOS14.frmCreditCustomerReceipt.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCreditCustomerReceipt.__ENCList.RemoveRange(num, RestaurantPOS14.frmCreditCustomerReceipt.__ENCList.Count - num)
                    RestaurantPOS14.frmCreditCustomerReceipt.__ENCList.Capacity = RestaurantPOS14.frmCreditCustomerReceipt.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCreditCustomerReceipt.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub GetCustomerBalance()
            Try
                Try
                    Me.num1 = DirectCast(Nothing, System.Decimal)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT isNULL(Sum(Credit),0)-IsNull(Sum(Debit),0) from LedgerBook where PartyID=@d1 group By PartyID", RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtCustomerID.Text)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.num1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num1)
                    If Microsoft.VisualBasic.Conversion.Val(Me.lblBalance.Text) >= 0.0 Then
                        Me.str = "CR"
                    ElseIf Microsoft.VisualBasic.Conversion.Val(Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.lblBalance.Text) < 0.0) <> 0.0 Then
                        Me.str = "DR"
                    End If

                    Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(System.Math.Abs(Microsoft.VisualBasic.Conversion.Val(Me.lblBalance.Text)))
                    Me.lblBalance.Text =(Me.lblBalance.Text & " " & Me.str).ToString()
                Catch ex As System.Exception
                    MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                End Try
            Catch ex2 As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex2.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Function GenerateID() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            Dim text As String = "0000"
            Try
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 T_ID FROM CreditCustomerPayment ORDER BY T_ID DESC", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.HasRows Then
                    RestaurantPOS14.ModClasses.rdr.Read()
                    text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr("T_ID"))
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
                Me.txtT_ID.Text = Me.GenerateID()
                Me.txtTransactionNo.Text = Me.txtCustomerID.Text & " - T-" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.GenerateID()))
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtAddress.Text = ""
            Me.txtContactNo.Text = ""
            Me.txtRemarks.Text = ""
            Me.txtCustomerID.Text = ""
            Me.txtCustomerName.Text = ""
            Me.txtTransactionAmount.Text = ""
            Me.txtPaymentModeDetails.Text = ""
            Me.cmbPaymentMode.SelectedIndex = 0
            Me.dtpTranactionDate.Value = Microsoft.VisualBasic.DateAndTime.Now
            Me.lblBalance.Text = "0.00"
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Credit Customer") Then
                Me.btnGetData.Enabled = True
            Else
                Me.btnGetData.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Credit Customer") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.btnDelete.Enabled = False
            Me.btnUpdate.Enabled = False
            Me.btnSelection.Enabled = True
            Me.txtTransactionNo.Text = ""
            Me.txtT_ID.Text = ""
            Me.btnPrint.Enabled = False
        End Sub

        Public Sub GetCustomerInfo()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT CreditCustomerID,Name,Address,ContactNo from CreditCustomer where CC_ID=@d1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtCustID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtCustomerID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.txtCustomerName.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.txtAddress.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.txtContactNo.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                End If

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from CreditCustomerPayment where T_ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtT_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    RestaurantPOS14.ModFunc.LedgerDelete(Me.txtTransactionNo.Text, "Receipt")
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "deleted the CreditCustomerPayment record having transaction No. '" & Me.txtTransactionNo.Text & "'")
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

        Private Sub txtTotalPaid_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtTransactionAmount.Text
                Dim selectionStart As Integer = Me.txtTransactionAmount.SelectionStart
                Dim selectionLength As Integer = Me.txtTransactionAmount.SelectionLength
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

        Private Sub btnSelection_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomersList.lblSet.Text = "Payment"
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomersList.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomersList.ShowDialog()
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtCustomerID.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please retrieve credit customer info", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCustomerID.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtTransactionAmount.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter transaction amount", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtTransactionAmount.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Conversion.Val(Me.txtTransactionAmount.Text) = 0.0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Transaction amount must be greater than zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtTransactionAmount.Focus()
                Return
            End If

            Try
                Me.auto()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into CreditCustomerPayment(T_ID, TransactionID, Date,PaymentMode, CreditCustomer_ID, Amount,Remarks,PaymentModeDetails) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtT_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtTransactionNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.dtpTranactionDate.Value)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.cmbPaymentMode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(Me.txtCustID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(Me.txtTransactionAmount.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.txtRemarks.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.txtPaymentModeDetails.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LedgerSave(Me.dtpTranactionDate.Value.[Date], "Cash", Me.txtTransactionNo.Text, "Receipt", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtTransactionAmount.Text)), 0D, "", Me.txtCustomerName.Text)
                RestaurantPOS14.ModFunc.LedgerSave(Me.dtpTranactionDate.Value.[Date], Me.txtCustomerName.Text, Me.txtTransactionNo.Text, "Receipt", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtTransactionAmount.Text)), Me.txtCustomerID.Text, "Cash")
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "added the new CreditCustomerPayment having transaction No. '" & Me.txtTransactionNo.Text & "'")
                MetroFramework.MetroMessageBox.Show(Me, "Successfully saved", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
                Me.btnPrint.Enabled = True
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtCustomerID.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please retrieve credit customer info", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCustomerID.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtTransactionAmount.Text)) = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter transaction amount", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtTransactionAmount.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Conversion.Val(Me.txtTransactionAmount.Text) = 0.0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Transaction amount must be greater than zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtTransactionAmount.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update CreditCustomerPayment set TransactionID=@d2, Date=@d3, PaymentMode=@d4, CreditCustomer_ID=@d5, Amount=@d6,Remarks=@d7,PaymentModeDetails=@d8 where T_ID=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtT_ID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtTransactionNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.dtpTranactionDate.Value)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.cmbPaymentMode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(Me.txtCustID.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(Me.txtTransactionAmount.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.txtRemarks.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Me.txtPaymentModeDetails.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModFunc.LedgerUpdate1(Me.dtpTranactionDate.Value.[Date], "Cash", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtTransactionAmount.Text)), 0D, "", Me.txtTransactionNo.Text, "Receipt")
                RestaurantPOS14.ModFunc.LedgerUpdate1(Me.dtpTranactionDate.Value.[Date], Me.txtCustomerName.Text, 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtTransactionAmount.Text)), Me.txtCustomerID.Text, Me.txtTransactionNo.Text, "Receipt")
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, "updated CreditCustomerPayment record having transaction No. '" & Me.txtTransactionNo.Text & "'")
                MetroFramework.MetroMessageBox.Show(Me, "Successfully updated", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
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

        Private Sub btnGetData_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerReceiptRecord.lblSet.Text = "Payment"
            RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerReceiptRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerReceiptRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmCreditCustomerReceiptRecord.ShowDialog()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnPrint_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim rptReceiptTP2 As RestaurantPOS14.rptReceiptTP = New RestaurantPOS14.rptReceiptTP()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT CreditCustomerPayment.T_ID, CreditCustomerPayment.TransactionID, CreditCustomerPayment.Date, CreditCustomerPayment.PaymentMode, CreditCustomerPayment.CreditCustomer_ID, CreditCustomerPayment.Amount,CreditCustomerPayment.Remarks, CreditCustomerPayment.PaymentModeDetails, CreditCustomer.CC_ID, CreditCustomer.CreditCustomerID, CreditCustomer.Name, CreditCustomer.ContactNo, CreditCustomer.Address,CreditCustomer.OpeningBalance, CreditCustomer.OpeningBalanceType, CreditCustomer.RegistrationDate, CreditCustomer.Active FROM CreditCustomerPayment INNER JOIN CreditCustomer ON CreditCustomerPayment.CreditCustomer_ID = CreditCustomer.CC_ID where T_ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtT_ID.Text))
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "CreditCustomer")
                sqlDataAdapter.Fill(dataSet, "CreditCustomerPayment")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                rptReceiptTP2.SetDataSource(dataSet)
                Me.GetCustomerBalance()
                rptReceiptTP2.SetParameterValue("p1", Me.lblBalance.Text)
                RestaurantPOS14.ModFunc.GetPrinterName(System.Net.Dns.GetHostName(), rptReceiptTP2)
                rptReceiptTP2.Close()
                rptReceiptTP2.Dispose()
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCreditCustomerReceipt))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.txtTempAmt = New System.Windows.Forms.TextBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnGetData = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.gbPartyInfo = New System.Windows.Forms.GroupBox()
            Me.btnSelection = New System.Windows.Forms.Button()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.txtCustomerID = New System.Windows.Forms.TextBox()
            Me.lblBalance = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.txtCustomerName = New System.Windows.Forms.TextBox()
            Me.txtAddress = New System.Windows.Forms.TextBox()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label36 = New System.Windows.Forms.Label()
            Me.txtRemarks = New System.Windows.Forms.RichTextBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtPaymentModeDetails = New System.Windows.Forms.RichTextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cmbPaymentMode = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.dtpTranactionDate = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtTransactionNo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTransactionAmount = New System.Windows.Forms.TextBox()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.TextBox3 = New System.Windows.Forms.TextBox()
            Me.TextBox2 = New System.Windows.Forms.TextBox()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.txtCustID = New System.Windows.Forms.TextBox()
            Me.txtT_ID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.gbPartyInfo.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.txtTempAmt)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.gbPartyInfo)
            Me.Panel1.Controls.Add(Me.txtRemarks)
            Me.Panel1.Controls.Add(Me.Label12)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(6, 6)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(803, 548)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.txtTempAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtTempAmt
            location = New System.Drawing.Point(438, 261)
            textBox.Location = location
            Me.txtTempAmt.Name = "txtTempAmt"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtTempAmt
            size = New System.Drawing.Size(88, 20)
            textBox2.Size = size
            Me.txtTempAmt.TabIndex = 11
            Me.txtTempAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtTempAmt.Visible = False
            Me.GroupBox2.Controls.Add(Me.btnPrint)
            Me.GroupBox2.Controls.Add(Me.btnNew)
            Me.GroupBox2.Controls.Add(Me.btnGetData)
            Me.GroupBox2.Controls.Add(Me.btnSave)
            Me.GroupBox2.Controls.Add(Me.btnDelete)
            Me.GroupBox2.Controls.Add(Me.btnUpdate)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(688, 51)
            groupBox.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(108, 285)
            groupBox2.Size = size
            Me.GroupBox2.TabIndex = 10
            Me.GroupBox2.TabStop = False
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(8, 14)
            button.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button2 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(92, 40)
            button2.Size = size
            Me.btnNew.TabIndex = 1
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGetData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnGetData.Image = CType(componentResourceManager.GetObject("btnGetData.Image"), System.Drawing.Image)
            Me.btnGetData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnGetData
            location = New System.Drawing.Point(10, 190)
            button3.Location = location
            Me.btnGetData.Name = "btnGetData"
            Dim button4 As System.Windows.Forms.Button = Me.btnGetData
            size = New System.Drawing.Size(92, 40)
            button4.Size = size
            Me.btnGetData.TabIndex = 5
            Me.btnGetData.Text = "Get Data"
            Me.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnGetData.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(9, 58)
            button5.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button6 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(92, 40)
            button6.Size = size
            Me.btnSave.TabIndex = 2
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(10, 103)
            button7.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button8 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(92, 40)
            button8.Size = size
            Me.btnDelete.TabIndex = 4
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Enabled = False
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(9, 146)
            button9.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button10 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(93, 40)
            button10.Size = size
            Me.btnUpdate.TabIndex = 3
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = RestaurantPOS14.My.Resources.Resources.Close_32x32
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(720, 7)
            button11.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button12 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(76, 38)
            button12.Size = size
            Me.btnClose.TabIndex = 9
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.gbPartyInfo.Controls.Add(Me.btnSelection)
            Me.gbPartyInfo.Controls.Add(Me.Label10)
            Me.gbPartyInfo.Controls.Add(Me.txtCustomerID)
            Me.gbPartyInfo.Controls.Add(Me.lblBalance)
            Me.gbPartyInfo.Controls.Add(Me.Label11)
            Me.gbPartyInfo.Controls.Add(Me.txtContactNo)
            Me.gbPartyInfo.Controls.Add(Me.txtCustomerName)
            Me.gbPartyInfo.Controls.Add(Me.txtAddress)
            Me.gbPartyInfo.Controls.Add(Me.Label26)
            Me.gbPartyInfo.Controls.Add(Me.Label30)
            Me.gbPartyInfo.Controls.Add(Me.Label36)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.gbPartyInfo
            location = New System.Drawing.Point(9, 51)
            groupBox3.Location = location
            Me.gbPartyInfo.Name = "gbPartyInfo"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.gbPartyInfo
            size = New System.Drawing.Size(423, 174)
            groupBox4.Size = size
            Me.gbPartyInfo.TabIndex = 0
            Me.gbPartyInfo.TabStop = False
            Me.gbPartyInfo.Text = "Credit Customer Info"
            Dim button13 As System.Windows.Forms.Button = Me.btnSelection
            location = New System.Drawing.Point(199, 25)
            button13.Location = location
            Me.btnSelection.Name = "btnSelection"
            Dim button14 As System.Windows.Forms.Button = Me.btnSelection
            size = New System.Drawing.Size(29, 21)
            button14.Size = size
            Me.btnSelection.TabIndex = 6
            Me.btnSelection.Text = "..."
            Me.btnSelection.UseVisualStyleBackColor = True
            Me.Label10.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(11, 53)
            label.Location = location
            Me.Label10.Name = "Label10"
            Dim label2 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(41, 13)
            label2.Size = size
            Me.Label10.TabIndex = 36
            Me.Label10.Text = "Name :"
            Me.txtCustomerID.BackColor = System.Drawing.SystemColors.Control
            Me.txtCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtCustomerID
            location = New System.Drawing.Point(95, 25)
            textBox3.Location = location
            Me.txtCustomerID.Name = "txtCustomerID"
            Me.txtCustomerID.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtCustomerID
            size = New System.Drawing.Size(98, 21)
            textBox4.Size = size
            Me.txtCustomerID.TabIndex = 0
            Me.lblBalance.AutoSize = True
            Me.lblBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblBalance.ForeColor = System.Drawing.Color.Maroon
            Dim label3 As System.Windows.Forms.Label = Me.lblBalance
            location = New System.Drawing.Point(91, 139)
            label3.Location = location
            Me.lblBalance.Name = "lblBalance"
            Dim label4 As System.Windows.Forms.Label = Me.lblBalance
            size = New System.Drawing.Size(44, 20)
            label4.Size = size
            Me.lblBalance.TabIndex = 5
            Me.lblBalance.Text = "0.00"
            Me.Label11.AutoSize = True
            Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label11
            location = New System.Drawing.Point(10, 139)
            label5.Location = location
            Me.Label11.Name = "Label11"
            Dim label6 As System.Windows.Forms.Label = Me.Label11
            size = New System.Drawing.Size(84, 20)
            label6.Size = size
            Me.Label11.TabIndex = 34
            Me.Label11.Text = "Balance :"
            Me.txtContactNo.BackColor = System.Drawing.SystemColors.Control
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(95, 106)
            textBox5.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Me.txtContactNo.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(315, 21)
            textBox6.Size = size
            Me.txtContactNo.TabIndex = 4
            Me.txtCustomerName.BackColor = System.Drawing.SystemColors.Control
            Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtCustomerName
            location = New System.Drawing.Point(95, 52)
            textBox7.Location = location
            Me.txtCustomerName.Name = "txtCustomerName"
            Me.txtCustomerName.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtCustomerName
            size = New System.Drawing.Size(315, 21)
            textBox8.Size = size
            Me.txtCustomerName.TabIndex = 1
            Me.txtAddress.BackColor = System.Drawing.SystemColors.Control
            Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtAddress
            location = New System.Drawing.Point(95, 79)
            textBox9.Location = location
            Me.txtAddress.Name = "txtAddress"
            Me.txtAddress.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtAddress
            size = New System.Drawing.Size(315, 21)
            textBox10.Size = size
            Me.txtAddress.TabIndex = 2
            Me.Label26.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label26
            location = New System.Drawing.Point(11, 106)
            label7.Location = location
            Me.Label26.Name = "Label26"
            Dim label8 As System.Windows.Forms.Label = Me.Label26
            size = New System.Drawing.Size(70, 13)
            label8.Size = size
            Me.Label26.TabIndex = 29
            Me.Label26.Text = "Contact No. :"
            Me.Label30.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label30
            location = New System.Drawing.Point(11, 77)
            label9.Location = location
            Me.Label30.Name = "Label30"
            Dim label10 As System.Windows.Forms.Label = Me.Label30
            size = New System.Drawing.Size(51, 13)
            label10.Size = size
            Me.Label30.TabIndex = 26
            Me.Label30.Text = "Address :"
            Me.Label36.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label36
            location = New System.Drawing.Point(11, 25)
            label11.Location = location
            Me.Label36.Name = "Label36"
            Dim label12 As System.Windows.Forms.Label = Me.Label36
            size = New System.Drawing.Size(73, 13)
            label12.Size = size
            Me.Label36.TabIndex = 23
            Me.Label36.Text = "Account No. :"
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtRemarks
            location = New System.Drawing.Point(438, 73)
            richTextBox.Location = location
            Me.txtRemarks.Name = "txtRemarks"
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtRemarks
            size = New System.Drawing.Size(242, 174)
            richTextBox2.Size = size
            Me.txtRemarks.TabIndex = 4
            Me.txtRemarks.Text = ""
            Me.Label12.AutoSize = True
            Dim label13 As System.Windows.Forms.Label = Me.Label12
            location = New System.Drawing.Point(438, 57)
            label13.Location = location
            Me.Label12.Name = "Label12"
            Dim label14 As System.Windows.Forms.Label = Me.Label12
            size = New System.Drawing.Size(55, 13)
            label14.Size = size
            Me.Label12.TabIndex = 5
            Me.Label12.Text = "Remarks :"
            Me.GroupBox1.Controls.Add(Me.txtPaymentModeDetails)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Me.GroupBox1.Controls.Add(Me.cmbPaymentMode)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.dtpTranactionDate)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtTransactionNo)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtTransactionAmount)
            Me.GroupBox1.Controls.Add(Me.Label19)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(9, 234)
            groupBox5.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(423, 305)
            groupBox6.Size = size
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Transaction Info"
            Dim richTextBox3 As System.Windows.Forms.RichTextBox = Me.txtPaymentModeDetails
            location = New System.Drawing.Point(14, 145)
            richTextBox3.Location = location
            Me.txtPaymentModeDetails.Name = "txtPaymentModeDetails"
            Dim richTextBox4 As System.Windows.Forms.RichTextBox = Me.txtPaymentModeDetails
            size = New System.Drawing.Size(379, 154)
            richTextBox4.Size = size
            Me.txtPaymentModeDetails.TabIndex = 4
            Me.txtPaymentModeDetails.Text = ""
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label15 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(14, 129)
            label15.Location = location
            Me.Label4.Name = "Label4"
            Dim label16 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(263, 13)
            label16.Size = size
            Me.Label4.TabIndex = 97
            Me.Label4.Text = "Payment Mode Details : (Transaction ID/ Cheque No.)"
            Me.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbPaymentMode.FormattingEnabled = True
            Me.cmbPaymentMode.Items.AddRange(New Object(2) {"By Cash", "By Cheque", "By Online Transfer"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbPaymentMode
            location = New System.Drawing.Point(109, 76)
            comboBox.Location = location
            Me.cmbPaymentMode.Name = "cmbPaymentMode"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbPaymentMode
            size = New System.Drawing.Size(124, 21)
            comboBox2.Size = size
            Me.cmbPaymentMode.TabIndex = 2
            Me.Label5.AutoSize = True
            Dim label17 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(14, 76)
            label17.Location = location
            Me.Label5.Name = "Label5"
            Dim label18 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(84, 13)
            label18.Size = size
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "Payment Mode :"
            Me.dtpTranactionDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpTranactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpTranactionDate
            location = New System.Drawing.Point(109, 51)
            dateTimePicker.Location = location
            Me.dtpTranactionDate.Name = "dtpTranactionDate"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpTranactionDate
            size = New System.Drawing.Size(124, 20)
            dateTimePicker2.Size = size
            Me.dtpTranactionDate.TabIndex = 1
            Me.Label3.AutoSize = True
            Dim label19 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(14, 26)
            label19.Location = location
            Me.Label3.Name = "Label3"
            Dim label20 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(89, 13)
            label20.Size = size
            Me.Label3.TabIndex = 0
            Me.Label3.Text = "Transaction No. :"
            Me.txtTransactionNo.BackColor = System.Drawing.SystemColors.Control
            Me.txtTransactionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtTransactionNo
            location = New System.Drawing.Point(109, 26)
            textBox11.Location = location
            Me.txtTransactionNo.Name = "txtTransactionNo"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtTransactionNo
            size = New System.Drawing.Size(124, 21)
            textBox12.Size = size
            Me.txtTransactionNo.TabIndex = 0
            Me.Label2.AutoSize = True
            Dim label21 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(14, 52)
            label21.Location = location
            Me.Label2.Name = "Label2"
            Dim label22 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(95, 13)
            label22.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Transaction Date :"
            Me.txtTransactionAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtTransactionAmount
            location = New System.Drawing.Point(109, 103)
            textBox13.Location = location
            Me.txtTransactionAmount.Name = "txtTransactionAmount"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtTransactionAmount
            size = New System.Drawing.Size(88, 20)
            textBox14.Size = size
            Me.txtTransactionAmount.TabIndex = 3
            Me.txtTransactionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label23 As System.Windows.Forms.Label = Me.Label19
            location = New System.Drawing.Point(14, 103)
            label23.Location = location
            Me.Label19.Name = "Label19"
            Dim label24 As System.Windows.Forms.Label = Me.Label19
            size = New System.Drawing.Size(49, 13)
            label24.Size = size
            Me.Label19.TabIndex = 96
            Me.Label19.Text = "Amount :"
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.TextBox3)
            Me.Panel2.Controls.Add(Me.TextBox2)
            Me.Panel2.Controls.Add(Me.TextBox1)
            Me.Panel2.Controls.Add(Me.lblUserType)
            Me.Panel2.Controls.Add(Me.lblSet)
            Me.Panel2.Controls.Add(Me.lblUser)
            Me.Panel2.Controls.Add(Me.txtCustID)
            Me.Panel2.Controls.Add(Me.txtT_ID)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(707, 38)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Dim textBox15 As System.Windows.Forms.TextBox = Me.TextBox3
            location = New System.Drawing.Point(523, 9)
            textBox15.Location = location
            Me.TextBox3.Name = "TextBox3"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.TextBox3
            size = New System.Drawing.Size(31, 20)
            textBox16.Size = size
            Me.TextBox3.TabIndex = 315
            Me.TextBox3.Visible = False
            Dim textBox17 As System.Windows.Forms.TextBox = Me.TextBox2
            location = New System.Drawing.Point(486, 9)
            textBox17.Location = location
            Me.TextBox2.Name = "TextBox2"
            Dim textBox18 As System.Windows.Forms.TextBox = Me.TextBox2
            size = New System.Drawing.Size(31, 20)
            textBox18.Size = size
            Me.TextBox2.TabIndex = 314
            Me.TextBox2.Visible = False
            Dim textBox19 As System.Windows.Forms.TextBox = Me.TextBox1
            location = New System.Drawing.Point(449, 9)
            textBox19.Location = location
            Me.TextBox1.Name = "TextBox1"
            Dim textBox20 As System.Windows.Forms.TextBox = Me.TextBox1
            size = New System.Drawing.Size(31, 20)
            textBox20.Size = size
            Me.TextBox1.TabIndex = 313
            Me.TextBox1.Visible = False
            Me.lblUserType.AutoSize = True
            Dim label25 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(142, 16)
            label25.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label26 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(56, 13)
            label26.Size = size
            Me.lblUserType.TabIndex = 312
            Me.lblUserType.Text = "User Type"
            Me.lblUserType.Visible = False
            Me.lblSet.AutoSize = True
            Dim label27 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(187, 30)
            label27.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label28 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label28.Size = size
            Me.lblSet.TabIndex = 311
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.lblUser.AutoSize = True
            Dim label29 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(142, 29)
            label29.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label30 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label30.Size = size
            Me.lblUser.TabIndex = 6
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtCustID
            location = New System.Drawing.Point(60, 22)
            textBox21.Location = location
            Me.txtCustID.Name = "txtCustID"
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtCustID
            size = New System.Drawing.Size(35, 20)
            textBox22.Size = size
            Me.txtCustID.TabIndex = 2
            Me.txtCustID.Visible = False
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtT_ID
            location = New System.Drawing.Point(19, 22)
            textBox23.Location = location
            Me.txtT_ID.Name = "txtT_ID"
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtT_ID
            size = New System.Drawing.Size(35, 20)
            textBox24.Size = size
            Me.txtT_ID.TabIndex = 1
            Me.txtT_ID.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label31 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(279, 6)
            label31.Location = location
            Me.Label1.Name = "Label1"
            Dim label32 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(135, 24)
            label32.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Receipt Entry"
            Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrint.Enabled = False
            Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPrint.Image = CType(componentResourceManager.GetObject("btnPrint.Image"), System.Drawing.Image)
            Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button15 As System.Windows.Forms.Button = Me.btnPrint
            location = New System.Drawing.Point(10, 234)
            button15.Location = location
            Me.btnPrint.Name = "btnPrint"
            Dim button16 As System.Windows.Forms.Button = Me.btnPrint
            size = New System.Drawing.Size(92, 40)
            button16.Size = size
            Me.btnPrint.TabIndex = 9
            Me.btnPrint.Text = "Print"
            Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnPrint.UseVisualStyleBackColor = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(815, 558)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmCreditCustomerReceipt"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.gbPartyInfo.ResumeLayout(False)
            Me.gbPartyInfo.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub

    End Class
End Namespace
