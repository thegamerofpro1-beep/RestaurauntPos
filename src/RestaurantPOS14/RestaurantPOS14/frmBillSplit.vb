Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports IngenicoDLL
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmBillSplit
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblTableNo")>
        Private _lblTableNo As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel3")>
        Private _TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCash")>
        Private _btnCash As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCreditCard")>
        Private _btnCreditCard As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDebitCard")>
        Private _btnDebitCard As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCards")>
        Private _btnCards As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("pnlKOT")>
        Private _pnlKOT As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label58")>
        Private _Label58 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCard")>
        Private _txtCard As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label50")>
        Private _Label50 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label49")>
        Private _Label49 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label48")>
        Private _Label48 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label43")>
        Private _Label43 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtGFA")>
        Private _txtGFA As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtGFID")>
        Private _txtGFID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtLA")>
        Private _txtLA As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtLP")>
        Private _txtLP As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbKOTDiscountType")>
        Private _cmbKOTDiscountType As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label34")>
        Private _Label34 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label33")>
        Private _Label33 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtKOTDiscPer")>
        Private _txtKOTDiscPer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtKOTDiscountAmount")>
        Private _txtKOTDiscountAmount As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtGrandTotal")>
        Private _txtGrandTotal As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtChange")>
        Private _txtChange As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCash")>
        Private _txtCash As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel1")>
        Private _TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn100f")>
        Private _btn100f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn50f")>
        Private _btn50f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn20f")>
        Private _btn20f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn10f")>
        Private _btn10f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn1f")>
        Private _btn1f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn2f")>
        Private _btn2f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn3f")>
        Private _btn3f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn4f")>
        Private _btn4f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn5f")>
        Private _btn5f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn6f")>
        Private _btn6f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn7f")>
        Private _btn7f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn8f")>
        Private _btn8f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn9f")>
        Private _btn9f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDotf")>
        Private _btnDotf As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn0f")>
        Private _btn0f As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnXf")>
        Private _btnXf As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView2")>
        Private _DataGridView2 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave1")>
        Private _btnSave1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblTotal")>
        Private _lblTotal As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label24")>
        Private _Label24 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblBillNo")>
        Private _lblBillNo As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblPaymentMode")>
        Private _lblPaymentMode As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtBillID")>
        Private _txtBillID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblOrderNo")>
        Private _lblOrderNo As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblOD")>
        Private _lblOD As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblMemberType")>
        Private _lblMemberType As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblMemberID")>
        Private _lblMemberID As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserVAL")>
        Private _lblUserVAL As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTaxType")>
        Private _txtTaxType As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblCustNameVAL")>
        Private _lblCustNameVAL As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTransID")>
        Private _txtTransID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtGroupName")>
        Private _txtGroupName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer4")>
        Private _Timer4 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label74")>
        Private _Label74 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTip")>
        Private _txtTip As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn12")>
        Private _DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn13")>
        Private _DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn14")>
        Private _DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn15")>
        Private _DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn16")>
        Private _DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn17")>
        Private _DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn18")>
        Private _DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn19")>
        Private _DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn20")>
        Private _DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn21")>
        Private _DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn22")>
        Private _DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn23")>
        Private _DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn24")>
        Private _DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn25")>
        Private _DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn26")>
        Private _DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn27")>
        Private _DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn28")>
        Private _DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column12")>
        Private _Column12 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn1")>
        Private _DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Rate")>
        Private _Rate As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Qty")>
        Private _Qty As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Amount")>
        Private _Amount As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn5")>
        Private _DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn6")>
        Private _DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn7")>
        Private _DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn8")>
        Private _DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("VATPer")>
        Private _VATPer As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("VAT")>
        Private _VAT As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column19")>
        Private _Column19 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column20")>
        Private _Column20 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TotalAmount")>
        Private _TotalAmount As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column36")>
        Private _Column36 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column27")>
        Private _Column27 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column32")>
        Private _Column32 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        Private sign_Indicator As Integer

        Private variable1 As Double

        Private variable2 As Double

        Private fl As Boolean

        Private s As String

        Private x As String

        Private IpAddress As String

        Private PT As String

        Private PortNo As String

        Private k4 As String

        Private s4 As String

        Private s3 As String

        Private a As Decimal

        Private str As String

        Private LP As Double

        Private LA As Double

        Private num1 As Double

        Private num2 As Double

        Private num3 As Double

        Private num4 As Double

        Private num5 As Double

        Private num6 As Double

        Private num7 As Double

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property dgw As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgw
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.dgw_MouseClick
                Dim value3 As System.Windows.Forms.DataGridViewCellEventHandler = AddressOf Me.dgw_CellValueChanged
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.MouseClick, value2
                    RemoveHandler Me._dgw.CellValueChanged, value3
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.MouseClick, value2
                    AddHandler Me._dgw.CellValueChanged, value3
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

        Friend Overridable Property lblTableNo As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblTableNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblTableNo = value
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel3 = value
            End Set
        End Property

        Friend Overridable Property btnCash As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCash
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCash_Click
                If Me._btnCash IsNot Nothing Then
                    RemoveHandler Me._btnCash.Click, value2
                End If

                Me._btnCash = value
                If Me._btnCash IsNot Nothing Then
                    AddHandler Me._btnCash.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCreditCard As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCreditCard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCreditCard_Click
                If Me._btnCreditCard IsNot Nothing Then
                    RemoveHandler Me._btnCreditCard.Click, value2
                End If

                Me._btnCreditCard = value
                If Me._btnCreditCard IsNot Nothing Then
                    AddHandler Me._btnCreditCard.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnDebitCard As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDebitCard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnDebitCard_Click
                If Me._btnDebitCard IsNot Nothing Then
                    RemoveHandler Me._btnDebitCard.Click, value2
                End If

                Me._btnDebitCard = value
                If Me._btnDebitCard IsNot Nothing Then
                    AddHandler Me._btnDebitCard.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnCards As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCards
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCards_Click
                If Me._btnCards IsNot Nothing Then
                    RemoveHandler Me._btnCards.Click, value2
                End If

                Me._btnCards = value
                If Me._btnCards IsNot Nothing Then
                    AddHandler Me._btnCards.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property pnlKOT As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._pnlKOT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._pnlKOT = value
            End Set
        End Property

        Friend Overridable Property Label58 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label58
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label58 = value
            End Set
        End Property

        Public Overridable Property txtCard As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtCard IsNot Nothing Then
                    RemoveHandler Me._txtCard.TextChanged, value2
                End If

                Me._txtCard = value
                If Me._txtCard IsNot Nothing Then
                    AddHandler Me._txtCard.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label50 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label50
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label50 = value
            End Set
        End Property

        Friend Overridable Property Label49 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label49
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label49 = value
            End Set
        End Property

        Friend Overridable Property Label48 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label48
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label48 = value
            End Set
        End Property

        Friend Overridable Property Label43 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label43
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label43 = value
            End Set
        End Property

        Friend Overridable Property txtGFA As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtGFA
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtGFA IsNot Nothing Then
                    RemoveHandler Me._txtGFA.TextChanged, value2
                End If

                Me._txtGFA = value
                If Me._txtGFA IsNot Nothing Then
                    AddHandler Me._txtGFA.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtGFID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtGFID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtGFID IsNot Nothing Then
                    RemoveHandler Me._txtGFID.TextChanged, value2
                End If

                Me._txtGFID = value
                If Me._txtGFID IsNot Nothing Then
                    AddHandler Me._txtGFID.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtLA As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtLA
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtLA IsNot Nothing Then
                    RemoveHandler Me._txtLA.TextChanged, value2
                End If

                Me._txtLA = value
                If Me._txtLA IsNot Nothing Then
                    AddHandler Me._txtLA.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtLP As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtLP
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtLP IsNot Nothing Then
                    RemoveHandler Me._txtLP.TextChanged, value2
                End If

                Me._txtLP = value
                If Me._txtLP IsNot Nothing Then
                    AddHandler Me._txtLP.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property cmbKOTDiscountType As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbKOTDiscountType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbKOTDiscountType_SelectedIndexChanged
                If Me._cmbKOTDiscountType IsNot Nothing Then
                    RemoveHandler Me._cmbKOTDiscountType.SelectedIndexChanged, value2
                End If

                Me._cmbKOTDiscountType = value
                If Me._cmbKOTDiscountType IsNot Nothing Then
                    AddHandler Me._cmbKOTDiscountType.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label34 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label34
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label34 = value
            End Set
        End Property

        Friend Overridable Property Label33 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label33
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label33 = value
            End Set
        End Property

        Friend Overridable Property txtKOTDiscPer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtKOTDiscPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtKOTDiscPer IsNot Nothing Then
                    RemoveHandler Me._txtKOTDiscPer.TextChanged, value2
                End If

                Me._txtKOTDiscPer = value
                If Me._txtKOTDiscPer IsNot Nothing Then
                    AddHandler Me._txtKOTDiscPer.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtKOTDiscountAmount As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtKOTDiscountAmount
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtKOTDiscountAmount IsNot Nothing Then
                    RemoveHandler Me._txtKOTDiscountAmount.TextChanged, value2
                End If

                Me._txtKOTDiscountAmount = value
                If Me._txtKOTDiscountAmount IsNot Nothing Then
                    AddHandler Me._txtKOTDiscountAmount.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtGrandTotal As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtGrandTotal
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtGrandTotal IsNot Nothing Then
                    RemoveHandler Me._txtGrandTotal.TextChanged, value2
                End If

                Me._txtGrandTotal = value
                If Me._txtGrandTotal IsNot Nothing Then
                    AddHandler Me._txtGrandTotal.TextChanged, value2
                End If
            End Set
        End Property

        Public Overridable Property txtChange As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtChange
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtChange IsNot Nothing Then
                    RemoveHandler Me._txtChange.TextChanged, value2
                End If

                Me._txtChange = value
                If Me._txtChange IsNot Nothing Then
                    AddHandler Me._txtChange.TextChanged, value2
                End If
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

        Friend Overridable Property txtCash As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCash
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtKOTDiscPer_TextChanged
                If Me._txtCash IsNot Nothing Then
                    RemoveHandler Me._txtCash.TextChanged, value2
                End If

                Me._txtCash = value
                If Me._txtCash IsNot Nothing Then
                    AddHandler Me._txtCash.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel1 = value
            End Set
        End Property

        Friend Overridable Property btn100f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn100f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn100f_Click
                If Me._btn100f IsNot Nothing Then
                    RemoveHandler Me._btn100f.Click, value2
                End If

                Me._btn100f = value
                If Me._btn100f IsNot Nothing Then
                    AddHandler Me._btn100f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn50f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn50f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn50f_Click
                If Me._btn50f IsNot Nothing Then
                    RemoveHandler Me._btn50f.Click, value2
                End If

                Me._btn50f = value
                If Me._btn50f IsNot Nothing Then
                    AddHandler Me._btn50f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn20f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn20f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn20f_Click
                If Me._btn20f IsNot Nothing Then
                    RemoveHandler Me._btn20f.Click, value2
                End If

                Me._btn20f = value
                If Me._btn20f IsNot Nothing Then
                    AddHandler Me._btn20f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn10f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn10f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn10f_Click
                If Me._btn10f IsNot Nothing Then
                    RemoveHandler Me._btn10f.Click, value2
                End If

                Me._btn10f = value
                If Me._btn10f IsNot Nothing Then
                    AddHandler Me._btn10f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn1f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn1f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn1f_Click
                If Me._btn1f IsNot Nothing Then
                    RemoveHandler Me._btn1f.Click, value2
                End If

                Me._btn1f = value
                If Me._btn1f IsNot Nothing Then
                    AddHandler Me._btn1f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn2f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn2f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn2f_Click
                If Me._btn2f IsNot Nothing Then
                    RemoveHandler Me._btn2f.Click, value2
                End If

                Me._btn2f = value
                If Me._btn2f IsNot Nothing Then
                    AddHandler Me._btn2f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn3f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn3f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn3f_Click
                If Me._btn3f IsNot Nothing Then
                    RemoveHandler Me._btn3f.Click, value2
                End If

                Me._btn3f = value
                If Me._btn3f IsNot Nothing Then
                    AddHandler Me._btn3f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn4f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn4f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn4f_Click
                If Me._btn4f IsNot Nothing Then
                    RemoveHandler Me._btn4f.Click, value2
                End If

                Me._btn4f = value
                If Me._btn4f IsNot Nothing Then
                    AddHandler Me._btn4f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn5f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn5f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn5f_Click
                If Me._btn5f IsNot Nothing Then
                    RemoveHandler Me._btn5f.Click, value2
                End If

                Me._btn5f = value
                If Me._btn5f IsNot Nothing Then
                    AddHandler Me._btn5f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn6f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn6f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn6f_Click
                If Me._btn6f IsNot Nothing Then
                    RemoveHandler Me._btn6f.Click, value2
                End If

                Me._btn6f = value
                If Me._btn6f IsNot Nothing Then
                    AddHandler Me._btn6f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn7f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn7f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn7f_Click
                If Me._btn7f IsNot Nothing Then
                    RemoveHandler Me._btn7f.Click, value2
                End If

                Me._btn7f = value
                If Me._btn7f IsNot Nothing Then
                    AddHandler Me._btn7f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn8f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn8f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn8f_Click
                If Me._btn8f IsNot Nothing Then
                    RemoveHandler Me._btn8f.Click, value2
                End If

                Me._btn8f = value
                If Me._btn8f IsNot Nothing Then
                    AddHandler Me._btn8f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn9f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn9f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn9f_Click
                If Me._btn9f IsNot Nothing Then
                    RemoveHandler Me._btn9f.Click, value2
                End If

                Me._btn9f = value
                If Me._btn9f IsNot Nothing Then
                    AddHandler Me._btn9f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnDotf As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDotf
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnDotf_Click
                If Me._btnDotf IsNot Nothing Then
                    RemoveHandler Me._btnDotf.Click, value2
                End If

                Me._btnDotf = value
                If Me._btnDotf IsNot Nothing Then
                    AddHandler Me._btnDotf.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn0f As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn0f
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btn0f_Click
                If Me._btn0f IsNot Nothing Then
                    RemoveHandler Me._btn0f.Click, value2
                End If

                Me._btn0f = value
                If Me._btn0f IsNot Nothing Then
                    AddHandler Me._btn0f.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnXf As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnXf
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnXf_Click
                If Me._btnXf IsNot Nothing Then
                    RemoveHandler Me._btnXf.Click, value2
                End If

                Me._btnXf = value
                If Me._btnXf IsNot Nothing Then
                    AddHandler Me._btnXf.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property DataGridView2 As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridView2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Me._DataGridView2 = value
            End Set
        End Property

        Friend Overridable Property btnSave1 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSave1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSave1_Click
                If Me._btnSave1 IsNot Nothing Then
                    RemoveHandler Me._btnSave1.Click, value2
                End If

                Me._btnSave1 = value
                If Me._btnSave1 IsNot Nothing Then
                    AddHandler Me._btnSave1.Click, value2
                End If
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

        Friend Overridable Property lblTotal As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblTotal
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblTotal = value
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

        Friend Overridable Property lblBillNo As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblBillNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblBillNo = value
            End Set
        End Property

        Friend Overridable Property lblPaymentMode As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblPaymentMode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblPaymentMode = value
            End Set
        End Property

        Friend Overridable Property txtBillID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtBillID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtBillID = value
            End Set
        End Property

        Friend Overridable Property lblOrderNo As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblOrderNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblOrderNo = value
            End Set
        End Property

        Friend Overridable Property lblOD As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblOD
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblOD = value
            End Set
        End Property

        Friend Overridable Property lblMemberType As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblMemberType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._lblMemberType = value
            End Set
        End Property

        Friend Overridable Property lblMemberID As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblMemberID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblMemberID = value
            End Set
        End Property

        Friend Overridable Property lblUserVAL As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUserVAL
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUserVAL = value
            End Set
        End Property

        Friend Overridable Property txtTaxType As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTaxType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTaxType = value
            End Set
        End Property

        Friend Overridable Property lblCustNameVAL As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblCustNameVAL
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblCustNameVAL = value
            End Set
        End Property

        Friend Overridable Property txtTransID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTransID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTransID = value
            End Set
        End Property

        Friend Overridable Property txtGroupName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtGroupName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtGroupName = value
            End Set
        End Property

        Friend Overridable Property Timer4 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer4_Tick
                If Me._Timer4 IsNot Nothing Then
                    RemoveHandler Me._Timer4.Tick, value2
                End If

                Me._Timer4 = value
                If Me._Timer4 IsNot Nothing Then
                    AddHandler Me._Timer4.Tick, value2
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

        Friend Overridable Property Label74 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label74
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label74 = value
            End Set
        End Property

        Friend Overridable Property txtTip As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTip
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtTip_TextChanged
                Dim value3 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtTip_KeyPress
                If Me._txtTip IsNot Nothing Then
                    RemoveHandler Me._txtTip.TextChanged, value2
                    RemoveHandler Me._txtTip.KeyPress, value3
                End If

                Me._txtTip = value
                If Me._txtTip IsNot Nothing Then
                    AddHandler Me._txtTip.TextChanged, value2
                    AddHandler Me._txtTip.KeyPress, value3
                End If
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn12
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn12 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn13
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn13 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn14
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn14 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn15
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn15 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn16
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn16 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn17
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn17 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn18
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn18 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn19
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn19 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn20
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn20 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn21
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn21 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn22
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn22 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn23
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn23 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn24
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn24 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn25
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn25 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn26
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn26 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn27
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn27 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn28
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn28 = value
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

        Friend Overridable Property DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn1 = value
            End Set
        End Property

        Friend Overridable Property Rate As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Rate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Rate = value
            End Set
        End Property

        Friend Overridable Property Qty As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Qty
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Qty = value
            End Set
        End Property

        Friend Overridable Property Amount As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Amount
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Amount = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn5 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn6 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn7 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn8 = value
            End Set
        End Property

        Friend Overridable Property VATPer As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._VATPer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._VATPer = value
            End Set
        End Property

        Friend Overridable Property VAT As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._VAT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._VAT = value
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

        Friend Overridable Property TotalAmount As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TotalAmount
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._TotalAmount = value
            End Set
        End Property

        Friend Overridable Property Column36 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column36
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column36 = value
            End Set
        End Property

        Friend Overridable Property Column27 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column27
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column27 = value
            End Set
        End Property

        Friend Overridable Property Column32 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column32
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column32 = value
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

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmBillSplit_Load
            AddHandler MyBase.FormClosing, AddressOf Me.frmBillSplit_FormClosing
            Call RestaurantPOS14.frmBillSplit.__ENCAddToList(Me)
            Me.sign_Indicator = 0
            Me.fl = False
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmBillSplit.__ENCList
                If RestaurantPOS14.frmBillSplit.__ENCList.Count = RestaurantPOS14.frmBillSplit.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmBillSplit.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmBillSplit.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmBillSplit.__ENCList(num) = RestaurantPOS14.frmBillSplit.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmBillSplit.__ENCList.RemoveRange(num, RestaurantPOS14.frmBillSplit.__ENCList.Count - num)
                    RestaurantPOS14.frmBillSplit.__ENCList.Capacity = RestaurantPOS14.frmBillSplit.__ENCList.Count
                End If

                Call RestaurantPOS14.frmBillSplit.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub GetLoyaltySetting()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Points,Amount from LoyaltySetting"
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.LP = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.LA = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetBaseCurrency()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(CurrencyCode) from Hotel"
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.str = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Function GrandTotal_Food1() As Double
            Dim num As Double = 0.0
            Try
                If Me.dgw.Rows.Count > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.dgw.Rows, System.Collections.IEnumerable)
                        num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((13))).Value))
                    Next
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Public Function GrandTotal_Food1X() As Double
            Dim num As Double = 0.0
            Try
                If Me.DataGridView2.Rows.Count > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                        num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((13))).Value))
                    Next
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Private Sub dgw_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTaxType.Text, "Inclusive", TextCompare:=False) = 0 Then
                        Me.num1 = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("Rate"))).Value)) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("Qty"))).Value))
                        Me.num1 = System.Math.Round(Me.num1, 2)
                        Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("Amount"))).Value = Me.num1
                        Me.num5 = Me.num1 - Me.num1 / (1.0 + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("VATPer"))).Value)) / 100.0)
                        Me.num5 = System.Math.Round(Me.num5, 2)
                        Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("VAT"))).Value = Me.num5
                        Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("TotalAmount"))).Value = Me.num1
                    Else
                        Me.num1 = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("Rate"))).Value)) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("Qty"))).Value))
                        Me.num1 = System.Math.Round(Me.num1, 2)
                        Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("Amount"))).Value = Me.num1
                        Me.num5 = Microsoft.VisualBasic.Conversion.Val(Me.num1) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("VATPer"))).Value)) / 100.0
                        Me.num5 = System.Math.Round(Me.num5, 2)
                        Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("VAT"))).Value = Me.num5
                        Me.num6 = Me.num1 + Me.num5
                        Me.num6 = System.Math.Round(Me.num6, 2)
                        Me.dgw.Rows(CInt((e.RowIndex))).Cells(CStr(("TotalAmount"))).Value = Me.num6
                    End If
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Me.dgw.Rows.Count > 0 Then
                Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                RestaurantPOS14.My.MyProject.Forms.frmEnterQty.txtQ.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((3))).Value)
                RestaurantPOS14.My.MyProject.Forms.frmEnterQty.txtCategory.Text = dataGridViewRow.Cells(CInt((16))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmEnterQty.txtDishNameArabic.Text = dataGridViewRow.Cells(CInt((17))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmEnterQty.txtQty.Text = ""
                Call RestaurantPOS14.My.MyProject.Forms.frmEnterQty.txtQty.Focus()
                Call RestaurantPOS14.My.MyProject.Forms.frmEnterQty.ShowDialog()
            End If
        End Sub

        Private Sub btnCash_Click(sender As Object, e As System.EventArgs)
            Me.txtCash.[ReadOnly] = False
            Me.lblPaymentMode.Text = Me.btnCash.Text
            Me.txtCash.Text = Me.txtGrandTotal.Text
        End Sub

        Private Sub btnCreditCard_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) >= Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) Then
                Call System.Windows.Forms.MessageBox.Show("You can't use selected payment mode until Cash is less than Grand Total", "Selection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Return
            End If

            Me.txtCard.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtLA.Text))
            Me.ReadPaymentTerminalSetting()
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.PT, "Yes", TextCompare:=False) <> 0 Then
                Me.lblPaymentMode.Text = Me.btnCreditCard.Text
                Me.txtCard.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtLA.Text))
                Return
            End If

            Dim text As String = RestaurantPOS14.Extensions.Payments.PaymentProviderHost.SendSale(System.Convert.ToDecimal(Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text))).RawResponse
            If text.Contains("APPROVAL") Or text.Contains("APPROVED") Then
                Me.lblPaymentMode.Text = Me.btnCreditCard.Text
                Me.btnSave1.PerformClick()
            ElseIf text.Contains("DECLINED") Then
                Call System.Windows.Forms.MessageBox.Show("Transaction declined", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Me.lblPaymentMode.Text = ""
                Me.txtCard.Text = "0.00"
            Else
                Call System.Windows.Forms.MessageBox.Show(text, "Transaction failed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Me.lblPaymentMode.Text = ""
                Me.txtCard.Text = "0.00"
            End If
        End Sub

        Private Sub btnDebitCard_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) >= Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) Then
                Call System.Windows.Forms.MessageBox.Show("You can't use selected payment mode until Cash is less than Grand Total", "Selection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Return
            End If

            Me.txtCard.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtLA.Text))
            Me.ReadPaymentTerminalSetting()
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.PT, "Yes", TextCompare:=False) <> 0 Then
                Me.lblPaymentMode.Text = Me.btnDebitCard.Text
                Me.txtCard.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtLA.Text))
                Return
            End If

            Dim text As String = RestaurantPOS14.Extensions.Payments.PaymentProviderHost.SendSale(System.Convert.ToDecimal(Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text))).RawResponse
            If text.Contains("APPROVAL") Or text.Contains("APPROVED") Then
                Me.lblPaymentMode.Text = Me.btnDebitCard.Text
                Me.btnSave1.PerformClick()
            ElseIf text.Contains("DECLINED") Then
                Call System.Windows.Forms.MessageBox.Show("Transaction declined", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Me.lblPaymentMode.Text = ""
                Me.txtCard.Text = "0.00"
            Else
                Call System.Windows.Forms.MessageBox.Show(text, "Transaction failed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                Me.lblPaymentMode.Text = ""
                Me.txtCard.Text = "0.00"
            End If
        End Sub

        Private Sub btnCards_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCards_POS.lblSet.Text = "Split Bill"
            Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.ShowDialog()
        End Sub

        Public Sub ReadPaymentTerminalSetting()
            Try
                Dim settings = RestaurantPOS14.Configuration.SettingsHost.Current
                Me.IpAddress = settings.Printing.PaymentTerminalAddress
                Me.PortNo = settings.Printing.PaymentTerminalPort.ToString(System.Globalization.CultureInfo.InvariantCulture)
                Me.PT = If(settings.Features.IngenicoTerminal AndAlso
                           Not System.String.IsNullOrWhiteSpace(Me.IpAddress) AndAlso
                           settings.Printing.PaymentTerminalPort > 0, "Yes", "No")
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Function GenerateID1() As String
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            Dim text As String = "0000"
            Try
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT TOP 1 ID FROM RestaurantPOS_BillingInfoKOT ORDER BY ID DESC", RestaurantPOS14.ModClasses.con)
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

        Public Sub LoyaltyKOTCalc()
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblMemberType.Text, "Loyalty Member", TextCompare:=False) = 0 Then
                Dim num As Decimal = DirectCast(Nothing, System.Decimal)
                num = New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.LP) * Microsoft.VisualBasic.Conversion.Val(Me.txtLP.Text))
                If Decimal.Compare(num, 1D) > 0 Then
                    num = System.Math.Round(num, 2)
                End If

                Me.txtLA.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(num)
                Me.Calc()
            End If
        End Sub

        Public Sub auto1()
            Try
                Me.txtBillID.Text = Me.GenerateID1()
                Me.lblBillNo.Text = "DIB-" & Me.GenerateID1()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btn1f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(1)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(1)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn2f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(2)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(2)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn3f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(3)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(3)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn4f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(4)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(4)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn5f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(5)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(5)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn6f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(6)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(6)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn7f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(7)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(7)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn8f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(8)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(8)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn9f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(9)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(9)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btnDotf_Click(sender As Object, e As System.EventArgs)
            If Me.txtCash.[ReadOnly] Then
                Return
            End If

            Dim num As Integer = 0
            Dim num2 As Integer = Me.txtCash.Text.Length - 1
            If Me.sign_Indicator = 1 Then
                Return
            End If

            Dim num3 As Integer = num2
            Dim num4 As Integer = 0
            While True
                Dim num5 As Integer = num4
                Dim num6 As Integer = num3
                If num5 > num6 Then
                    Exit While
                End If

                If Me.txtCash.Text(num4) = "."c Then
                    num = 1
                End If

                num4 += 1
            End While

            If num <> 1 Then
                Me.txtCash.Text += System.Convert.ToString(".")
            End If
        End Sub

        Private Sub btn0f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(0)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(0)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btnXf_Click(sender As Object, e As System.EventArgs)
            If Me.txtCash.[ReadOnly] Then
                Return
            End If

            Me.s = Me.txtCash.Text
            Dim num As Integer = Me.s.Length - 2
            Dim num2 As Integer = 0
            While True
                Dim num3 As Integer = num2
                Dim num4 As Integer = num
                If num3 > num4 Then
                    Exit While
                End If

                Me.x += Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.s(num2))
                num2 += 1
            End While

            Me.txtCash.Text = Me.x
            Me.x = ""
        End Sub

        Private Sub btn10f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(10)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(10)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn20f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(20)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(20)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn50f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(50)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(50)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Private Sub btn100f_Click(sender As Object, e As System.EventArgs)
            If Not Me.txtCash.[ReadOnly] Then
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtCash.Text, "0.00", TextCompare:=False) = 0 Then
                    Me.txtCash.Text = ""
                End If

                If Me.sign_Indicator = 0 Then
                    Me.txtCash.Text += System.Convert.ToString(100)
                ElseIf Me.sign_Indicator = 1 Then
                    Me.txtCash.Text = System.Convert.ToString(100)
                    Me.sign_Indicator = 0
                End If

                Me.fl = True
            End If
        End Sub

        Public Sub GetTaxType()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(TaxType) from OtherSetting"
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtTaxType.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                Else
                    Me.txtTaxType.Text = "Exclusive"
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Function H1X() As Decimal
            Dim num As Decimal = DirectCast(Nothing, System.Decimal)
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                    num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((10))).Value))
                Next
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(System.Math.Round(CDec((num)), CInt((2))).ToString("F"))
        End Function

        Private Sub btnSave1_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.DataGridView2.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("sorry no item added to datagridview", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                If Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) < 0.0 Then
                    Call System.Windows.Forms.MessageBox.Show("Grand Total cant't be less than zero", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Return
                End If

                If(Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) > 0.0) And (Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text) > 0.0) And (Microsoft.VisualBasic.Conversion.Val(Me.txtChange.Text) > 0.0) Then
                    Call System.Windows.Forms.MessageBox.Show("Change must be zero when Cash and Card are used", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Return
                End If

                If(Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) = 0.0) And (Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text) > 0.0) And (Microsoft.VisualBasic.Conversion.Val(Me.txtChange.Text) > 0.0) Then
                    Call System.Windows.Forms.MessageBox.Show("Change must be zero for payment mode " & Me.lblPaymentMode.Text & ".", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtCard.Text = ""
                    Me.txtCard.Focus()
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblMemberType.Text, "Loyalty Member", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select ISNULL(sum(PointsEarned)-Sum(PointsRedeem),0) from LoyaltyMemberLedgerBook,LoyaltyMember where LoyaltyMember.MemberID=LoyaltyMemberLedgerBook.MemberID and LoyaltyMember.MemberID=@d1")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.lblMemberID.Text))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Else
                        Me.a = DirectCast(Nothing, System.Decimal)
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    If System.Convert.ToDouble(Me.a) < Microsoft.VisualBasic.Conversion.Val(Me.txtLP.Text) Then
                        Call System.Windows.Forms.MessageBox.Show("Insufficient loyalty points available in member's account." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Maximum available points are " & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.a)), "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Return
                    End If
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblPaymentMode.Text, "VIP Member Card", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select ISNULL(sum(Credit)-Sum(Debit),0) from MemberLedger,Member where Member.MemberID=MemberLedger.MemberID and Member.MemberID=@d1")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.lblMemberID.Text))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDecimal(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Else
                        Me.a = DirectCast(Nothing, System.Decimal)
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    If System.Convert.ToDouble(Me.a) < Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) Then
                        Call System.Windows.Forms.MessageBox.Show("Insufficient fund available in member's account...try other payment mode", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                        Return
                    End If
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RestaurantPOS_BillingInfoKOT.ID from RestaurantPOS_BillingInfoKOT,RestaurantPOS_OrderedProductBillKOT where RestaurantPOS_BillingInfoKOT.Id=RestaurantPOS_OrderedProductBillKOT.BillID and DIB_Status='Unpaid' and TableNo=@d1 and BillType='Normal Bill'", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblTableNo.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If sqlDataReader.Read() Then
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_BillingInfoKOT set DIB_Status='Changed to Split Bill' where ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader.GetValue(0)))))
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Me.auto1()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into RestaurantPOS_BillingInfoKOT( Id,BillNo, BillDate, GrandTotal,Cash,Change,Operator,PaymentMode,ExchangeRate,CurrencyCode,KOTDiscountPer,KOTDiscountAmt,Member_ID,ODN,Waiter,GiftCardID,GiftCardAmount,LP,LA,CustomerName,PhoneNo,EmailID,TaxType,Card,NoofPerson,DIB_Status,NPPaid,BillType,Tip) Values (" & Me.txtBillID.Text & ",'" & Me.lblBillNo.Text & "',@d1," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)) & "," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text)) & "," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtChange.Text)) & ",@d2,@d3,1,@d4," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtKOTDiscPer.Text)) & ",@d5,@d6,@d7,@d8,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text)) & ",1,@d19,1,'Split Bill'," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtTip.Text)) & ")")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.DateAndTime.Now)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblUserVAL.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.lblPaymentMode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.str)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(Me.txtKOTDiscountAmount.Text))
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblMemberID.Text, "", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", "")
                Else
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.lblMemberID.Text)
                End If

                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", "")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblWaiterNameVal.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.txtGFID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Microsoft.VisualBasic.Conversion.Val(Me.txtLP.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Microsoft.VisualBasic.Conversion.Val(Me.txtLA.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDICustomerName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDIContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEmailID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d18", Me.txtTaxType.Text)
                If Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text) > Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text) Then
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d19", "Unpaid")
                Else
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d19", "Paid")
                End If

                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into TempRestaurantPOS_BillingInfoKOT( Id,BillNo, BillDate, GrandTotal,Cash,Change,Operator,PaymentMode,ExchangeRate,CurrencyCode,KOTDiscountPer,KOTDiscountAmt,Member_ID,ODN,Waiter,GiftCardID,GiftCardAmount,LP,LA,CustomerName,PhoneNo,EmailID,TaxType,Card) Values (" & Me.txtBillID.Text & ",'" & Me.lblBillNo.Text & "',@d1," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)) & "," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text)) & "," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtChange.Text)) & ",@d2,@d3,1,@d4," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtKOTDiscPer.Text)) & ",@d5,@d6,@d7,@d8,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text)) & ")")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.DateTime.Now)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblUserVAL.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.lblPaymentMode.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.str)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(Me.txtKOTDiscountAmount.Text))
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblMemberID.Text, "", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", "")
                Else
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.lblMemberID.Text)
                End If

                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.lblOrderNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblWaiterNameVal.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.txtGFID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Microsoft.VisualBasic.Conversion.Val(Me.txtLP.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Microsoft.VisualBasic.Conversion.Val(Me.txtLA.Text))
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDICustomerName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDIContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEmailID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d18", Me.txtTaxType.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into RestaurantPOS_OrderedProductBillKOT(BillID,TableNo,Dish,Rate,Quantity,Amount,DiscountPer, DiscountAmount, STPer, STAmount, VATPer, VATAmount,SCPer,SCAmount,TotalAmount,Category,DishNameArabic) VALUES (" & Me.txtBillID.Text & ",@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((5))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((6))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((7))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((8))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((9))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((10))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((11))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((12))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((13))).Value)))
                        If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((16))).Value, "", TextCompare:=False) Then
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", "")
                        Else
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((16))).Value))
                        End If

                        If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((17))).Value.ToString(), "", TextCompare:=False) = 0 Then
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", "")
                        Else
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", dataGridViewRow.Cells(CInt((17))).Value.ToString())
                        End If

                        RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into TempRestaurantPOS_OrderedProductBillKOT(BillID,TableNo,Dish,Rate,Quantity,Amount,DiscountPer, DiscountAmount, STPer, STAmount, VATPer, VATAmount,SCPer,SCAmount,TotalAmount,Category,DishNameArabic) VALUES (" & Me.txtBillID.Text & ",@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow2.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((1))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((2))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((3))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((4))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((5))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((6))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d8", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((7))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((8))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d10", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((9))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((10))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d12", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((11))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d13", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((12))).Value)))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((13))).Value)))
                        If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells(CInt((16))).Value, "", TextCompare:=False) Then
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", "")
                        Else
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((16))).Value))
                        End If

                        If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow2.Cells(CInt((17))).Value.ToString(), "", TextCompare:=False) = 0 Then
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", "")
                        Else
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", dataGridViewRow2.Cells(CInt((17))).Value.ToString())
                        End If

                        RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                    End If
                Next

                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new restaurant pos record having bill no. '" & Me.lblBillNo.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUserVAL.Text, st)
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(TableNo),RTRIM(Dish),Rate,SUM(Qty),SUM(TempQty),Sum(Amount), VATPer, Sum(VATAmount),Sum(TotalAmount),RTRIM(Category) from (Select TableNo,Dish,Rate,0 as Qty,SUM(Quantity) as tempQty,0 as Amount,VATPer,0 as VATAmount,0 as TotalAmount,Category from TempRestaurantPOS_OrderedProductBillKOT where TempRestaurantPOS_OrderedProductBillKOT.TableNo=@d1 group by TableNo,Dish,Rate, VATPer,Category UNION Select TableNo,Dish,Rate,SUM(Quantity) as Qty,0 as tempQty,(Amount),VATPer,(VATAmount),(TotalAmount),Category from RestaurantPOS_OrderInfoKOT INNER JOIN RestaurantPOS_OrderedProductKOT ON RestaurantPOS_OrderInfoKOT.ID=RestaurantPOS_OrderedProductKOT.TicketID and KOT_Status in ('Open','Served','Prepared') and ItemStatus <>'Canceled' and TableNo=@d1 group by TableNo,Dish,Rate, VATPer,Category,Amount,VATAmount,TotalAmount) G group by TableNo,Dish,Rate, VATPer,Category having (SUM(Qty) - SUM(TempQty)) > 0 order by Dish", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblTableNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select distinct Count(TableNo) from RestaurantPOS_BillingInfoKOT INNER JOIN RestaurantPOS_OrderedProductBillKOT ON RestaurantPOS_OrderedProductBillKOT.BillID=RestaurantPOS_BillingInfoKOT.ID where TableNo=@d1 and DIB_Status='Unpaid' and BillType='Split Bill'")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblTableNo.Text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    Dim sqlDataReader2 As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If sqlDataReader2.Read() AndAlso Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader2.GetValue(0))) <= 0.0 Then
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update R_Table set BkColor=@d1 where TableNo=@d2")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Drawing.Color.LightGreen.ToArgb())
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblTableNo.Text)
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.con.Close()
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_OrderInfoKOT set KOT_Status='Closed' where TableNo=@d1 and KOT_Status in ('Open','Prepared','Served')")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblTableNo.Text)
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.con.Close()
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Delete from TempRestaurantPOS_BillingInfoKOT from TempRestaurantPOS_BillingInfoKOT INNER JOIN TempRestaurantPOS_OrderedProductBillKOT ON TempRestaurantPOS_OrderedProductBillKOT.BillID=TempRestaurantPOS_BillingInfoKOT.ID where TableNo=@d1")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblTableNo.Text)
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.con.Close()
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Delete from TempRestaurantPOS_OrderedProductBillKOT where TableNo=@d1")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblTableNo.Text)
                        RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                        RestaurantPOS14.ModClasses.con.Close()
                    End If
                End If

                RestaurantPOS14.ModClasses.con.Close()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblMemberType.Text, "Loyalty Member", TextCompare:=False) = 0 Then
                    Me.GetLoyaltySetting()
                    Dim num As Double = 0.0
                    For Each dataGridViewRow3 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                        If Not dataGridViewRow3.IsNewRow Then
                            num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow3.Cells(CInt((13))).Value))
                        End If
                    Next

                    Dim num2 As Integer = CInt(System.Math.Round(System.Math.Floor(Microsoft.VisualBasic.Conversion.Val(num) / Microsoft.VisualBasic.Conversion.Val(Me.LA))))
                    RestaurantPOS14.ModFunc.LoyaltyCardMemberLedgerSave(System.DateTime.Today, Me.lblBillNo.Text, "Points for dine in billing", CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(num2))), CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.txtLP.Text))), CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.lblMemberID.Text))))
                End If

                Me.GetTransID()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblPaymentMode.Text, "Credit Customer", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModFunc.LedgerSave(System.DateTime.Today, "Sales A/c", Me.lblBillNo.Text, "Sales Invoice", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), "", Me.lblCustNameVAL.Text)
                    RestaurantPOS14.ModFunc.LedgerSave(System.DateTime.Today, Me.lblCustNameVAL.Text, Me.lblBillNo.Text, "POS", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), 0D, Me.lblMemberID.Text, "Sales A/c")
                ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblPaymentMode.Text, "VIP Member Card", TextCompare:=False) = 0 Then
                    If Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text) > 0.0 Then
                        RestaurantPOS14.ModFunc.LedgerSave(System.DateTime.Today, "Cash", Me.lblBillNo.Text, "POS", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), "", Me.lblCustNameVAL.Text)
                    End If

                    RestaurantPOS14.ModFunc.LedgerSave(System.DateTime.Today, Me.lblCustNameVAL.Text, Me.lblBillNo.Text, "POS", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), 0D, Me.lblMemberID.Text, "Cash")
                    RestaurantPOS14.ModFunc.MemberLedgerSave(System.DateTime.Today, CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.txtTransID.Text))), Me.lblBillNo.Text, "Paid for dine in billing", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), 0D, CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.lblMemberID.Text))))
                Else
                    If Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text) > 0.0 Then
                        RestaurantPOS14.ModFunc.LedgerSave(System.DateTime.Today, "Cash", Me.lblBillNo.Text, "POS", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), 0D, "", "Sales A/c")
                    End If

                    RestaurantPOS14.ModFunc.LedgerSave(System.DateTime.Today, "Sales A/c", Me.lblBillNo.Text, "Sales Invoice", 0D, New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)), "", "Cash")
                End If

                If Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text) > 0.0 Then
                    RestaurantPOS14.ModFunc.LedgerSave(Microsoft.VisualBasic.DateAndTime.Today, "Gift Card Voucher", Me.txtGFID.Text, "Gift Card(POS)", New Decimal(Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text)), 0D, "", "POS")
                End If

                Me.btnSave1.Enabled = False
                Me.GetOtherSetting()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.k4, "Yes", TextCompare:=False) = 0 Then
                    Me.OpenCashdrawer()
                ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblPaymentMode.Text, "Cash", TextCompare:=False) = 0 Then
                    Me.OpenCashdrawer()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.PDP, "Yes", TextCompare:=False) = 0 Then
                    If System.Windows.Forms.MessageBox.Show("Do you want to print bill?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Asterisk) = System.Windows.Forms.DialogResult.Yes Then
                        Me.Print1()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.ECDB, "Yes", TextCompare:=False) = 0 Then
                        Me.Print1()
                    End If
                Else
                    Me.Print1()
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.ECDB, "Yes", TextCompare:=False) = 0 Then
                        Me.Print1()
                    End If
                End If

                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Print1()
            Try
                If Me.DataGridView2.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("sorry no item added to datagridview", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer4.Enabled = True
                Dim rptRestaurantPOSFinalBillKOTInvoice2 As RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice = New RestaurantPOS14.rptRestaurantPOSFinalBillKOTInvoice()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand()
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlCommand.Connection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = sqlCommand.Connection
                Dim connection As System.Data.SqlClient.SqlConnection = sqlConnection
                sqlCommand2.Connection = connection
                sqlCommand.CommandText = "SELECT DishNameArabic,Tip,DIB_Status,BillType,NoofPerson,Card,TaxType,CustomerName,PhoneNo,EmailID,GiftCardID,GiftCardAmount,LP,LA,Waiter,Member_ID, ODN,KOTDiscountPer,KOTDiscountAmt,RestaurantPOS_OrderedProductBillKOT.OP_ID,Operator,SCPer,SCAmount,PaymentMode,CurrencyCode, RestaurantPOS_OrderedProductBillKOT.BillID, RestaurantPOS_OrderedProductBillKOT.Dish, RestaurantPOS_OrderedProductBillKOT.VATPer,RestaurantPOS_OrderedProductBillKOT.VATAmount, RestaurantPOS_OrderedProductBillKOT.STPer, RestaurantPOS_OrderedProductBillKOT.STAmount, RestaurantPOS_OrderedProductBillKOT.DiscountPer, RestaurantPOS_OrderedProductBillKOT.DiscountAmount,RestaurantPOS_OrderedProductBillKOT.Rate, RestaurantPOS_OrderedProductBillKOT.Quantity, RestaurantPOS_OrderedProductBillKOT.Amount, RestaurantPOS_OrderedProductBillKOT.TotalAmount,RestaurantPOS_BillingInfoKOT.ID, RestaurantPOS_BillingInfoKOT.BillNo,RestaurantPOS_OrderedProductBillKOT.TableNo, RestaurantPOS_BillingInfoKOT.BillDate, RestaurantPOS_BillingInfoKOT.GrandTotal,RestaurantPOS_BillingInfoKOT.Cash,RestaurantPOS_BillingInfoKOT.Change FROM RestaurantPOS_OrderedProductBillKOT INNER JOIN  RestaurantPOS_BillingInfoKOT ON RestaurantPOS_OrderedProductBillKOT.BillID = RestaurantPOS_BillingInfoKOT.ID where RestaurantPOS_BillingInfoKOT.ID=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtBillID.Text))
                sqlCommand2.CommandText = "SELECT * from Hotel"
                sqlCommand.CommandType = System.Data.CommandType.Text
                sqlCommand2.CommandType = System.Data.CommandType.Text
                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter2.SelectCommand = sqlCommand2
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_BillingInfoKOT")
                sqlDataAdapter.Fill(dataSet, "RestaurantPOS_OrderedProductBillKOT")
                sqlDataAdapter2.Fill(dataSet, "Hotel")
                rptRestaurantPOSFinalBillKOTInvoice2.SetDataSource(dataSet)
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblPaymentMode.Text, "Credit Customer", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                    RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(Name) from CreditCustomer where CreditCustomerID=@d1"
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblMemberID.Text)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.lblCustNameVAL.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                    Else
                        Me.lblCustNameVAL.Text = ""
                    End If

                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                        RestaurantPOS14.ModClasses.con.Close()
                    End If

                    rptRestaurantPOSFinalBillKOTInvoice2.SetParameterValue("p1", Me.lblCustNameVAL.Text)
                Else
                    rptRestaurantPOSFinalBillKOTInvoice2.SetParameterValue("p1", "")
                End If

                RestaurantPOS14.ModFunc.GetPrinterName(System.Net.Dns.GetHostName(), rptRestaurantPOSFinalBillKOTInvoice2)
                rptRestaurantPOSFinalBillKOTInvoice2.Close()
                rptRestaurantPOSFinalBillKOTInvoice2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.cmbKOTDiscountType.SelectedIndex = 0
            Me.txtKOTDiscountAmount.Enabled = False
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUserVAL.Text, "Bill Discount(POS)") Then
                Me.txtKOTDiscPer.Enabled = True
            Else
                Me.txtKOTDiscPer.Enabled = False
            End If

            Me.txtKOTDiscPer.Text = "0.00"
            Me.txtKOTDiscountAmount.Text = "0.00"
            Me.txtCash.Text = ""
            Me.txtChange.Text = ""
            Me.DataGridView2.Rows.Clear()
            Me.btnSave1.Enabled = True
            Me.lblPaymentMode.Text = "Cash"
            Me.pnlKOT.Enabled = True
            Me.auto1()
            Me.GetOtherSetting()
            Me.txtGrandTotal.Text = ""
            Me.lblMemberID.Text = ""
            Me.lblMemberType.Text = ""
            Me.txtLP.[ReadOnly] = True
            Me.txtCash.[ReadOnly] = False
            Me.txtGFID.Text = ""
            Me.txtCard.Text = "0.00"
            Me.txtGFA.Text = "0.00"
            Me.txtLP.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
            Me.txtLA.Text = "0.00"
            Me.GetTaxType()
            Me.GetBaseCurrency()
            Me.auto1()
            Me.FillData()
        End Sub

        Private Sub GetTransID()
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(ID) FROM MemberLedger")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                Me.txtTransID.Text = 1.ToString()
            Else
                Dim num As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                Me.txtTransID.Text = num.ToString()
            End If

            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Sub OpenCashdrawer()
            Try
                Dim origString As String = Global.Microsoft.VisualBasic.Strings.ChrW(27) & "p0@@"
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(PrinterName) from POSPrinterSetting where TillID=@d1 and IsEnabled='Yes' and CashDrawer='Enabled'"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Net.Dns.GetHostName())
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.s4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                RestaurantPOS14.ModCashDrawer.RawPrinter.PrintRaw(Me.s4, origString)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetOtherSetting()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT RTRIM(KG) from OtherSetting"
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.k4 = RestaurantPOS14.ModClasses.rdr.GetString(0)
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub OrderNo()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(ODNo) FROM tblOrder")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                    Me.lblOrderNo.Text = 1.ToString()
                Else
                    Dim num As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                    Me.lblOrderNo.Text = num.ToString()
                End If

                RestaurantPOS14.ModClasses.cmd.Dispose()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmBillSplit_Load(sender As Object, e As System.EventArgs)
        End Sub

        Public Sub FillData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(TableNo),RTRIM(Dish),Rate,SUM(Qty),SUM(TempQty),Sum(Amount), VATPer, Sum(VATAmount),Sum(TotalAmount),RTRIM(Category),RTRIM(DishNameArabic) from (Select TableNo,Dish,Rate,0 as Qty,SUM(Quantity) as tempQty,0 as Amount,VATPer,0 as VATAmount,0 as TotalAmount,Category,DishNameArabic from TempRestaurantPOS_OrderedProductBillKOT where TempRestaurantPOS_OrderedProductBillKOT.TableNo=@d1 group by TableNo,Dish,Rate, VATPer,Category,DishNameArabic UNION Select TableNo,Dish,Rate,SUM(Quantity) as Qty,0 as tempQty,(Amount),VATPer,(VATAmount),(TotalAmount),Category,DishNameArabic from RestaurantPOS_OrderInfoKOT INNER JOIN RestaurantPOS_OrderedProductKOT ON RestaurantPOS_OrderInfoKOT.ID=RestaurantPOS_OrderedProductKOT.TicketID and KOT_Status in ('Open','Served','Prepared') and ItemStatus <>'Canceled' and TableNo=@d1 group by TableNo,Dish,Rate, VATPer,Category,Amount,VATAmount,TotalAmount,DishNameArabic) G group by TableNo,Dish,Rate, VATPer,Category,DishNameArabic having (SUM(Qty) - SUM(TempQty)) > 0 order by Dish", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblTableNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(RestaurantPOS14.ModClasses.rdr.GetValue(3), RestaurantPOS14.ModClasses.rdr.GetValue(4)))
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(6))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(RestaurantPOS14.ModClasses.rdr.GetValue(3), RestaurantPOS14.ModClasses.rdr.GetValue(4)), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text), 0, 0, 0, 0, System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), 0, 0, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), "", 0, System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
                Me.num1 = Me.GrandTotal_Food1()
                Me.num1 = System.Math.Round(Me.num1, 2)
                Me.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.num1)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmBillSplit_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Reset1()
        End Sub

        Private Sub cmbKOTDiscountType_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Me.Calc()
        End Sub

        Private Sub txtKOTDiscPer_TextChanged(sender As Object, e As System.EventArgs)
            Me.Calc()
        End Sub

        Public Sub Calc()
            If Me.DataGridView2.Rows.Count > 0 AndAlso Me.cmbKOTDiscountType.SelectedIndex = 0 Then
                If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUserVAL.Text, "Bill Discount(POS)") Then
                    Me.txtKOTDiscPer.Enabled = True
                Else
                    Me.txtKOTDiscPer.Enabled = False
                End If

                Me.txtKOTDiscountAmount.Enabled = False
                Dim num As Double = 0.0
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTaxType.Text, "Inclusive", TextCompare:=False) <> 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                        dataGridViewRow.Cells(CInt((5))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.txtKOTDiscPer.Text) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((15))).Value)), 4)
                        dataGridViewRow.Cells(CInt((6))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((5))).Value)) / 100.0, 3)
                        dataGridViewRow.Cells(CInt((8))).Value = System.Math.Round((Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((6))).Value))) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((7))).Value)) / 100.0, 2)
                        dataGridViewRow.Cells(CInt((10))).Value = System.Math.Round((Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((6))).Value))) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((9))).Value)) / 100.0, 3)
                        dataGridViewRow.Cells(CInt((12))).Value = System.Math.Round((Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((6))).Value))) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((11))).Value)) / 100.0, 2)
                        dataGridViewRow.Cells(CInt((13))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((6))).Value)) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((8))).Value)) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((10))).Value)) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((12))).Value)), 2)
                        num += Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((6))).Value))
                    Next
                Else
                    For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                        dataGridViewRow2.Cells(CInt((5))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.txtKOTDiscPer.Text) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((15))).Value)), 4)
                        dataGridViewRow2.Cells(CInt((6))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((4))).Value)) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((5))).Value)) / 100.0, 3)
                        Me.num1 = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((6))).Value))
                        dataGridViewRow2.Cells(CInt((8))).Value = 0
                        dataGridViewRow2.Cells(CInt((10))).Value = System.Math.Round(Me.num1 - Me.num1 / (1.0 + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((9))).Value)) / 100.0), 3)
                        dataGridViewRow2.Cells(CInt((12))).Value = 0
                        dataGridViewRow2.Cells(CInt((13))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((6))).Value)), 2)
                        num += Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((6))).Value))
                    Next
                End If

                num = System.Math.Round(num, 2)
                Me.txtKOTDiscountAmount.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(num)
                Dim value As Double = Me.GrandTotal_Food1X() - Microsoft.VisualBasic.Conversion.Val(Me.txtLA.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtTip.Text)
                value = System.Math.Round(value, 2)
                Me.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                Dim num2 As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)
                num2 = System.Math.Round(num2, 2)
                If num2 < 0.0 Then
                    Me.txtChange.Text = ""
                Else
                    Me.txtChange.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(num2)
                End If
            End If

            If Me.DataGridView2.Rows.Count <= 0 OrElse Me.cmbKOTDiscountType.SelectedIndex <> 1 Then
                Return
            End If

            Me.txtKOTDiscPer.Enabled = False
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUserVAL.Text, "Bill Discount(POS)") Then
                Me.txtKOTDiscountAmount.Enabled = True
            Else
                Me.txtKOTDiscountAmount.Enabled = False
            End If

            Dim num3 As Double = 0.0
            For Each dataGridViewRow3 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                num3 += Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((4))).Value))
            Next

            Dim num4 As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtKOTDiscountAmount.Text) * 100.0 / Microsoft.VisualBasic.Conversion.Val(num3)
            num4 = System.Math.Round(num4, 4)
            Me.txtKOTDiscPer.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(num4)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTaxType.Text, "Inclusive", TextCompare:=False) <> 0 Then
                For Each dataGridViewRow4 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                    dataGridViewRow4.Cells(CInt((5))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.txtKOTDiscPer.Text) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((15))).Value)), 4)
                    dataGridViewRow4.Cells(CInt((6))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((4))).Value)) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((5))).Value)) / 100.0, 3)
                    dataGridViewRow4.Cells(CInt((8))).Value = System.Math.Round((Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((6))).Value))) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((7))).Value)) / 100.0, 2)
                    dataGridViewRow4.Cells(CInt((10))).Value = System.Math.Round((Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((6))).Value))) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((9))).Value)) / 100.0, 3)
                    dataGridViewRow4.Cells(CInt((12))).Value = System.Math.Round((Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((6))).Value))) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((11))).Value)) / 100.0, 2)
                    dataGridViewRow4.Cells(CInt((13))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((6))).Value)) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((8))).Value)) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((10))).Value)) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((12))).Value)), 2)
                Next
            Else
                For Each dataGridViewRow5 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                    dataGridViewRow5.Cells(CInt((5))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(Me.txtKOTDiscPer.Text) + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((15))).Value)), 4)
                    dataGridViewRow5.Cells(CInt((6))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((4))).Value)) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((5))).Value)) / 100.0, 3)
                    num4 = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((6))).Value))
                    dataGridViewRow5.Cells(CInt((8))).Value = 0
                    dataGridViewRow5.Cells(CInt((10))).Value = System.Math.Round(num4 - num4 / (1.0 + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((9))).Value)) / 100.0), 3)
                    dataGridViewRow5.Cells(CInt((12))).Value = 0
                    dataGridViewRow5.Cells(CInt((13))).Value = System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((4))).Value)) - Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow5.Cells(CInt((6))).Value)), 2)
                Next
            End If

            Dim value2 As Double = Me.GrandTotal_Food1X() - Microsoft.VisualBasic.Conversion.Val(Me.txtLA.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtGFA.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtTip.Text)
            value2 = System.Math.Round(value2, 2)
            Me.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
            Dim num5 As Double = Microsoft.VisualBasic.Conversion.Val(Me.txtCash.Text) + Microsoft.VisualBasic.Conversion.Val(Me.txtCard.Text) - Microsoft.VisualBasic.Conversion.Val(Me.txtGrandTotal.Text)
            num5 = System.Math.Round(num5, 2)
            If num5 < 0.0 Then
                Me.txtChange.Text = ""
            Else
                Me.txtChange.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(num5)
            End If
        End Sub

        Private Sub Timer4_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer4.Enabled = False
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub txtTip_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtTip.Text
                Dim selectionStart As Integer = Me.txtTip.SelectionStart
                Dim selectionLength As Integer = Me.txtTip.SelectionLength
                text = text.Substring(0, selectionStart) & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(keyChar) & text.Substring(selectionStart + selectionLength)
                Dim obj As String = text
                Dim num As Integer = 0
                If Integer.TryParse(obj, num) AndAlso text.Length > 16 Then
                    e.Handled = True
                    Return
                End If

                Dim obj2 As String = text
                Dim num2 As Double = 0.0
                If Double.TryParse(obj2, num2) AndAlso text.IndexOf("."c) < text.Length - 3 Then
                    e.Handled = False
                End If
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub txtTip_TextChanged(sender As Object, e As System.EventArgs)
            Me.Calc()
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
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmBillSplit))
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VATPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.lblTableNo = New System.Windows.Forms.Label()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.btnCash = New System.Windows.Forms.Button()
            Me.btnCreditCard = New System.Windows.Forms.Button()
            Me.btnDebitCard = New System.Windows.Forms.Button()
            Me.btnCards = New System.Windows.Forms.Button()
            Me.pnlKOT = New System.Windows.Forms.Panel()
            Me.Label74 = New System.Windows.Forms.Label()
            Me.txtTip = New System.Windows.Forms.TextBox()
            Me.Label58 = New System.Windows.Forms.Label()
            Me.txtCard = New System.Windows.Forms.TextBox()
            Me.Label50 = New System.Windows.Forms.Label()
            Me.Label49 = New System.Windows.Forms.Label()
            Me.Label48 = New System.Windows.Forms.Label()
            Me.Label43 = New System.Windows.Forms.Label()
            Me.txtGFA = New System.Windows.Forms.TextBox()
            Me.txtGFID = New System.Windows.Forms.TextBox()
            Me.txtLA = New System.Windows.Forms.TextBox()
            Me.txtLP = New System.Windows.Forms.TextBox()
            Me.cmbKOTDiscountType = New System.Windows.Forms.ComboBox()
            Me.Label34 = New System.Windows.Forms.Label()
            Me.Label33 = New System.Windows.Forms.Label()
            Me.txtKOTDiscPer = New System.Windows.Forms.TextBox()
            Me.txtKOTDiscountAmount = New System.Windows.Forms.TextBox()
            Me.txtGrandTotal = New System.Windows.Forms.TextBox()
            Me.txtChange = New System.Windows.Forms.TextBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.txtCash = New System.Windows.Forms.TextBox()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.btn50f = New System.Windows.Forms.Button()
            Me.btn20f = New System.Windows.Forms.Button()
            Me.btn10f = New System.Windows.Forms.Button()
            Me.btn1f = New System.Windows.Forms.Button()
            Me.btn2f = New System.Windows.Forms.Button()
            Me.btn3f = New System.Windows.Forms.Button()
            Me.btn4f = New System.Windows.Forms.Button()
            Me.btn5f = New System.Windows.Forms.Button()
            Me.btn6f = New System.Windows.Forms.Button()
            Me.btn7f = New System.Windows.Forms.Button()
            Me.btn8f = New System.Windows.Forms.Button()
            Me.btn9f = New System.Windows.Forms.Button()
            Me.btnDotf = New System.Windows.Forms.Button()
            Me.btn0f = New System.Windows.Forms.Button()
            Me.btnXf = New System.Windows.Forms.Button()
            Me.btn100f = New System.Windows.Forms.Button()
            Me.DataGridView2 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnSave1 = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.Label24 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.lblBillNo = New System.Windows.Forms.Label()
            Me.lblPaymentMode = New System.Windows.Forms.Label()
            Me.txtBillID = New System.Windows.Forms.TextBox()
            Me.lblOrderNo = New System.Windows.Forms.Label()
            Me.lblOD = New System.Windows.Forms.Label()
            Me.lblMemberType = New System.Windows.Forms.TextBox()
            Me.lblMemberID = New System.Windows.Forms.Label()
            Me.lblUserVAL = New System.Windows.Forms.Label()
            Me.txtTaxType = New System.Windows.Forms.TextBox()
            Me.lblCustNameVAL = New System.Windows.Forms.Label()
            Me.txtTransID = New System.Windows.Forms.TextBox()
            Me.txtGroupName = New System.Windows.Forms.TextBox()
            Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
            Me.btnReset = New System.Windows.Forms.Button()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.pnlKOT.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgw.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 40
            Me.dgw.Columns.AddRange(Me.Column12, Me.DataGridViewTextBoxColumn1, Me.Rate, Me.Qty, Me.Amount, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.VATPer, Me.VAT, Me.Column19, Me.Column20, Me.TotalAmount, Me.Column36, Me.Column27, Me.Column32, Me.Column2)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            Dim location As System.Drawing.Point = New System.Drawing.Point(5, 85)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersVisible = False
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 25
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            Dim size As System.Drawing.Size = New System.Drawing.Size(425, 539)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 369
            Me.Column12.FillWeight = 115.2738F
            Me.Column12.HeaderText = "Table No."
            Me.Column12.Name = "Column12"
            Me.Column12.[ReadOnly] = True
            Me.Column12.Visible = False
            Me.Column12.Width = 105
            Me.DataGridViewTextBoxColumn1.FillWeight = 167.1456F
            Me.DataGridViewTextBoxColumn1.HeaderText = "Item Name"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn1.Width = 240
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            dataGridViewCellStyle6.NullValue = Nothing
            Me.Rate.DefaultCellStyle = dataGridViewCellStyle6
            Me.Rate.FillWeight = 101.3975F
            Me.Rate.HeaderText = "Rate"
            Me.Rate.Name = "Rate"
            Me.Rate.[ReadOnly] = True
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Qty.DefaultCellStyle = dataGridViewCellStyle7
            Me.Qty.FillWeight = 99.14185F
            Me.Qty.HeaderText = "Qty."
            Me.Qty.Name = "Qty"
            Me.Qty.[ReadOnly] = True
            Me.Qty.Width = 80
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Amount.DefaultCellStyle = dataGridViewCellStyle8
            Me.Amount.FillWeight = 96.83242F
            Me.Amount.HeaderText = "Amount"
            Me.Amount.Name = "Amount"
            Me.Amount.[ReadOnly] = True
            Me.Amount.Visible = False
            Me.Amount.Width = 89
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle9
            Me.DataGridViewTextBoxColumn5.FillWeight = 93.34656F
            Me.DataGridViewTextBoxColumn5.HeaderText = "Discount %"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn5.Visible = False
            Me.DataGridViewTextBoxColumn5.Width = 85
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle10
            Me.DataGridViewTextBoxColumn6.FillWeight = 92.25301F
            Me.DataGridViewTextBoxColumn6.HeaderText = "Discount"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn6.Visible = False
            Me.DataGridViewTextBoxColumn6.Width = 84
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle11
            Me.DataGridViewTextBoxColumn7.FillWeight = 89.92587F
            Me.DataGridViewTextBoxColumn7.HeaderText = "ST %"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn7.Visible = False
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle12
            Me.DataGridViewTextBoxColumn8.FillWeight = 88.78162F
            Me.DataGridViewTextBoxColumn8.HeaderText = "ST Amount"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn8.Visible = False
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.VATPer.DefaultCellStyle = dataGridViewCellStyle13
            Me.VATPer.FillWeight = 86.44057F
            Me.VATPer.HeaderText = "HST %"
            Me.VATPer.Name = "VATPer"
            Me.VATPer.[ReadOnly] = True
            Me.VATPer.Visible = False
            Me.VATPer.Width = 79
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.VAT.DefaultCellStyle = dataGridViewCellStyle14
            Me.VAT.FillWeight = 85.30766F
            Me.VAT.HeaderText = "HST Amount"
            Me.VAT.Name = "VAT"
            Me.VAT.[ReadOnly] = True
            Me.VAT.Visible = False
            Me.VAT.Width = 78
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column19.DefaultCellStyle = dataGridViewCellStyle15
            Me.Column19.HeaderText = "SC %"
            Me.Column19.Name = "Column19"
            Me.Column19.[ReadOnly] = True
            Me.Column19.Visible = False
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column20.DefaultCellStyle = dataGridViewCellStyle16
            Me.Column20.HeaderText = "SC Amount"
            Me.Column20.Name = "Column20"
            Me.Column20.[ReadOnly] = True
            Me.Column20.Visible = False
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.TotalAmount.DefaultCellStyle = dataGridViewCellStyle17
            Me.TotalAmount.FillWeight = 84.15354F
            Me.TotalAmount.HeaderText = "Total Amount"
            Me.TotalAmount.Name = "TotalAmount"
            Me.TotalAmount.[ReadOnly] = True
            Me.TotalAmount.Visible = False
            Me.TotalAmount.Width = 77
            Me.Column36.HeaderText = "Group Name"
            Me.Column36.Name = "Column36"
            Me.Column36.[ReadOnly] = True
            Me.Column36.Visible = False
            Me.Column27.HeaderText = "TempDesc"
            Me.Column27.Name = "Column27"
            Me.Column27.[ReadOnly] = True
            Me.Column27.Visible = False
            Me.Column32.HeaderText = "Category"
            Me.Column32.Name = "Column32"
            Me.Column32.[ReadOnly] = True
            Me.Column32.Visible = False
            Me.Column2.HeaderText = "Dish Name Arabic"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Visible = False
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(10, 32)
            label.Location = location
            Me.Label2.Name = "Label2"
            Dim label2 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(107, 25)
            label2.Size = size
            Me.Label2.TabIndex = 370
            Me.Label2.Text = "Table No. : "
            Me.lblTableNo.AutoSize = True
            Me.lblTableNo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblTableNo.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.lblTableNo
            location = New System.Drawing.Point(114, 32)
            label3.Location = location
            Me.lblTableNo.Name = "lblTableNo"
            Dim label4 As System.Windows.Forms.Label = Me.lblTableNo
            size = New System.Drawing.Size(103, 25)
            label4.Size = size
            Me.lblTableNo.TabIndex = 371
            Me.lblTableNo.Text = "lblTableNo"
            Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.TableLayoutPanel3.ColumnCount = 1
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel3.Controls.Add(Me.btnCash, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.btnCreditCard, 0, 1)
            Me.TableLayoutPanel3.Controls.Add(Me.btnDebitCard, 0, 2)
            Me.TableLayoutPanel3.Controls.Add(Me.btnCards, 0, 3)
            Dim tableLayoutPanel As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel3
            location = New System.Drawing.Point(436, 266)
            tableLayoutPanel.Location = location
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 4
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Dim tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel3
            size = New System.Drawing.Size(194, 406)
            tableLayoutPanel2.Size = size
            Me.TableLayoutPanel3.TabIndex = 376
            Me.btnCash.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCash.BackColor = System.Drawing.Color.Green
            Me.btnCash.FlatAppearance.BorderSize = 0
            Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCash.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button As System.Windows.Forms.Button = Me.btnCash
            location = New System.Drawing.Point(3, 3)
            button.Location = location
            Me.btnCash.Name = "btnCash"
            Dim button2 As System.Windows.Forms.Button = Me.btnCash
            size = New System.Drawing.Size(188, 95)
            button2.Size = size
            Me.btnCash.TabIndex = 364
            Me.btnCash.Text = "Cash"
            Me.btnCash.UseVisualStyleBackColor = False
            Me.btnCreditCard.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCreditCard.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnCreditCard.FlatAppearance.BorderSize = 0
            Me.btnCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCreditCard.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCreditCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button3 As System.Windows.Forms.Button = Me.btnCreditCard
            location = New System.Drawing.Point(3, 104)
            button3.Location = location
            Me.btnCreditCard.Name = "btnCreditCard"
            Dim button4 As System.Windows.Forms.Button = Me.btnCreditCard
            size = New System.Drawing.Size(188, 95)
            button4.Size = size
            Me.btnCreditCard.TabIndex = 370
            Me.btnCreditCard.Text = "Credit Card"
            Me.btnCreditCard.UseVisualStyleBackColor = False
            Me.btnDebitCard.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnDebitCard.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnDebitCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnDebitCard.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDebitCard.ForeColor = System.Drawing.Color.White
            Dim button5 As System.Windows.Forms.Button = Me.btnDebitCard
            location = New System.Drawing.Point(3, 205)
            button5.Location = location
            Me.btnDebitCard.Name = "btnDebitCard"
            Dim button6 As System.Windows.Forms.Button = Me.btnDebitCard
            size = New System.Drawing.Size(188, 95)
            button6.Size = size
            Me.btnDebitCard.TabIndex = 371
            Me.btnDebitCard.Text = "Debit Card"
            Me.btnDebitCard.UseVisualStyleBackColor = False
            Me.btnCards.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCards.BackColor = System.Drawing.Color.Crimson
            Me.btnCards.FlatAppearance.BorderSize = 0
            Me.btnCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCards.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCards.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button7 As System.Windows.Forms.Button = Me.btnCards
            location = New System.Drawing.Point(3, 306)
            button7.Location = location
            Me.btnCards.Name = "btnCards"
            Dim button8 As System.Windows.Forms.Button = Me.btnCards
            size = New System.Drawing.Size(188, 97)
            button8.Size = size
            Me.btnCards.TabIndex = 365
            Me.btnCards.Text = "Others Card"
            Me.btnCards.UseVisualStyleBackColor = False
            Me.pnlKOT.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.pnlKOT.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.pnlKOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlKOT.Controls.Add(Me.Label74)
            Me.pnlKOT.Controls.Add(Me.txtTip)
            Me.pnlKOT.Controls.Add(Me.Label58)
            Me.pnlKOT.Controls.Add(Me.txtCard)
            Me.pnlKOT.Controls.Add(Me.Label50)
            Me.pnlKOT.Controls.Add(Me.Label49)
            Me.pnlKOT.Controls.Add(Me.Label48)
            Me.pnlKOT.Controls.Add(Me.Label43)
            Me.pnlKOT.Controls.Add(Me.txtGFA)
            Me.pnlKOT.Controls.Add(Me.txtGFID)
            Me.pnlKOT.Controls.Add(Me.txtLA)
            Me.pnlKOT.Controls.Add(Me.txtLP)
            Me.pnlKOT.Controls.Add(Me.cmbKOTDiscountType)
            Me.pnlKOT.Controls.Add(Me.Label34)
            Me.pnlKOT.Controls.Add(Me.Label33)
            Me.pnlKOT.Controls.Add(Me.txtKOTDiscPer)
            Me.pnlKOT.Controls.Add(Me.txtKOTDiscountAmount)
            Me.pnlKOT.Controls.Add(Me.txtGrandTotal)
            Me.pnlKOT.Controls.Add(Me.txtChange)
            Me.pnlKOT.Controls.Add(Me.Label8)
            Me.pnlKOT.Controls.Add(Me.Label6)
            Me.pnlKOT.Controls.Add(Me.Label7)
            Me.pnlKOT.Controls.Add(Me.txtCash)
            Dim panel As System.Windows.Forms.Panel = Me.pnlKOT
            location = New System.Drawing.Point(633, 183)
            panel.Location = location
            Me.pnlKOT.Name = "pnlKOT"
            Dim panel2 As System.Windows.Forms.Panel = Me.pnlKOT
            size = New System.Drawing.Size(310, 332)
            panel2.Size = size
            Me.pnlKOT.TabIndex = 373
            Me.Label74.AutoSize = True
            Me.Label74.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label74.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label74
            location = New System.Drawing.Point(3, 183)
            label5.Location = location
            Me.Label74.Name = "Label74"
            Dim label6 As System.Windows.Forms.Label = Me.Label74
            size = New System.Drawing.Size(45, 21)
            label6.Size = size
            Me.Label74.TabIndex = 391
            Me.Label74.Text = "Tip : "
            Me.txtTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtTip
            location = New System.Drawing.Point(171, 181)
            textBox.Location = location
            Me.txtTip.Name = "txtTip"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtTip
            size = New System.Drawing.Size(134, 26)
            textBox2.Size = size
            Me.txtTip.TabIndex = 7
            Me.txtTip.Text = "0.00"
            Me.txtTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label58.AutoSize = True
            Me.Label58.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label58.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.Label58
            location = New System.Drawing.Point(5, 272)
            label7.Location = location
            Me.Label58.Name = "Label58"
            Dim label8 As System.Windows.Forms.Label = Me.Label58
            size = New System.Drawing.Size(56, 21)
            label8.Size = size
            Me.Label58.TabIndex = 387
            Me.Label58.Text = "Card : "
            Me.txtCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtCard
            location = New System.Drawing.Point(171, 272)
            textBox3.Location = location
            Me.txtCard.Name = "txtCard"
            Me.txtCard.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtCard
            size = New System.Drawing.Size(134, 26)
            textBox4.Size = size
            Me.txtCard.TabIndex = 10
            Me.txtCard.Text = "0.00"
            Me.txtCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label50.AutoSize = True
            Me.Label50.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label50.ForeColor = System.Drawing.Color.White
            Dim label9 As System.Windows.Forms.Label = Me.Label50
            location = New System.Drawing.Point(3, 154)
            label9.Location = location
            Me.Label50.Name = "Label50"
            Dim label10 As System.Windows.Forms.Label = Me.Label50
            size = New System.Drawing.Size(150, 21)
            label10.Size = size
            Me.Label50.TabIndex = 385
            Me.Label50.Text = "Gift Card Amount : "
            Me.Label49.AutoSize = True
            Me.Label49.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label49.ForeColor = System.Drawing.Color.White
            Dim label11 As System.Windows.Forms.Label = Me.Label49
            location = New System.Drawing.Point(3, 125)
            label11.Location = location
            Me.Label49.Name = "Label49"
            Dim label12 As System.Windows.Forms.Label = Me.Label49
            size = New System.Drawing.Size(107, 21)
            label12.Size = size
            Me.Label49.TabIndex = 384
            Me.Label49.Text = "Gift Card ID : "
            Me.Label48.AutoSize = True
            Me.Label48.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label48.ForeColor = System.Drawing.Color.White
            Dim label13 As System.Windows.Forms.Label = Me.Label48
            location = New System.Drawing.Point(3, 95)
            label13.Location = location
            Me.Label48.Name = "Label48"
            Dim label14 As System.Windows.Forms.Label = Me.Label48
            size = New System.Drawing.Size(137, 21)
            label14.Size = size
            Me.Label48.TabIndex = 383
            Me.Label48.Text = "Loyalty Amount : "
            Me.Label43.AutoSize = True
            Me.Label43.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label43.ForeColor = System.Drawing.Color.White
            Dim label15 As System.Windows.Forms.Label = Me.Label43
            location = New System.Drawing.Point(3, 62)
            label15.Location = location
            Me.Label43.Name = "Label43"
            Dim label16 As System.Windows.Forms.Label = Me.Label43
            size = New System.Drawing.Size(122, 21)
            label16.Size = size
            Me.Label43.TabIndex = 382
            Me.Label43.Text = "Loyalty Points : "
            Me.txtGFA.Enabled = False
            Me.txtGFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtGFA
            location = New System.Drawing.Point(171, 151)
            textBox5.Location = location
            Me.txtGFA.Name = "txtGFA"
            Me.txtGFA.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtGFA
            size = New System.Drawing.Size(134, 26)
            textBox6.Size = size
            Me.txtGFA.TabIndex = 6
            Me.txtGFA.Text = "0.00"
            Me.txtGFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtGFID.Enabled = False
            Me.txtGFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtGFID
            location = New System.Drawing.Point(171, 122)
            textBox7.Location = location
            Me.txtGFID.Name = "txtGFID"
            Me.txtGFID.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtGFID
            size = New System.Drawing.Size(134, 26)
            textBox8.Size = size
            Me.txtGFID.TabIndex = 5
            Me.txtLA.Enabled = False
            Me.txtLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtLA
            location = New System.Drawing.Point(171, 92)
            textBox9.Location = location
            Me.txtLA.Name = "txtLA"
            Me.txtLA.[ReadOnly] = True
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtLA
            size = New System.Drawing.Size(134, 26)
            textBox10.Size = size
            Me.txtLA.TabIndex = 4
            Me.txtLA.Text = "0.00"
            Me.txtLA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtLP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtLP
            location = New System.Drawing.Point(171, 62)
            textBox11.Location = location
            Me.txtLP.Name = "txtLP"
            Me.txtLP.[ReadOnly] = True
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtLP
            size = New System.Drawing.Size(134, 26)
            textBox12.Size = size
            Me.txtLP.TabIndex = 3
            Me.txtLP.Text = "0"
            Me.txtLP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.cmbKOTDiscountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbKOTDiscountType.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbKOTDiscountType.FormattingEnabled = True
            Me.cmbKOTDiscountType.Items.AddRange(New Object(1) {"%", "Amt"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbKOTDiscountType
            location = New System.Drawing.Point(112, 3)
            comboBox.Location = location
            Me.cmbKOTDiscountType.Name = "cmbKOTDiscountType"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbKOTDiscountType
            size = New System.Drawing.Size(56, 25)
            comboBox2.Size = size
            Me.cmbKOTDiscountType.TabIndex = 0
            Me.Label34.AutoSize = True
            Me.Label34.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label34.ForeColor = System.Drawing.Color.White
            Dim label17 As System.Windows.Forms.Label = Me.Label34
            location = New System.Drawing.Point(5, 215)
            label17.Location = location
            Me.Label34.Name = "Label34"
            Dim label18 As System.Windows.Forms.Label = Me.Label34
            size = New System.Drawing.Size(105, 21)
            label18.Size = size
            Me.Label34.TabIndex = 351
            Me.Label34.Text = "Grand Total : "
            Me.Label33.AutoSize = True
            Me.Label33.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label33.ForeColor = System.Drawing.Color.White
            Dim label19 As System.Windows.Forms.Label = Me.Label33
            location = New System.Drawing.Point(3, 33)
            label19.Location = location
            Me.Label33.Name = "Label33"
            Dim label20 As System.Windows.Forms.Label = Me.Label33
            size = New System.Drawing.Size(149, 21)
            label20.Size = size
            Me.Label33.TabIndex = 350
            Me.Label33.Text = "Discount Amount : "
            Me.txtKOTDiscPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtKOTDiscPer
            location = New System.Drawing.Point(171, 3)
            textBox13.Location = location
            Me.txtKOTDiscPer.Name = "txtKOTDiscPer"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtKOTDiscPer
            size = New System.Drawing.Size(134, 26)
            textBox14.Size = size
            Me.txtKOTDiscPer.TabIndex = 1
            Me.txtKOTDiscPer.Text = "0.00"
            Me.txtKOTDiscPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtKOTDiscountAmount.Enabled = False
            Me.txtKOTDiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox15 As System.Windows.Forms.TextBox = Me.txtKOTDiscountAmount
            location = New System.Drawing.Point(171, 33)
            textBox15.Location = location
            Me.txtKOTDiscountAmount.Name = "txtKOTDiscountAmount"
            Dim textBox16 As System.Windows.Forms.TextBox = Me.txtKOTDiscountAmount
            size = New System.Drawing.Size(134, 26)
            textBox16.Size = size
            Me.txtKOTDiscountAmount.TabIndex = 2
            Me.txtKOTDiscountAmount.Text = "0.00"
            Me.txtKOTDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox17 As System.Windows.Forms.TextBox = Me.txtGrandTotal
            location = New System.Drawing.Point(171, 212)
            textBox17.Location = location
            Me.txtGrandTotal.Name = "txtGrandTotal"
            Me.txtGrandTotal.[ReadOnly] = True
            Dim textBox18 As System.Windows.Forms.TextBox = Me.txtGrandTotal
            size = New System.Drawing.Size(134, 26)
            textBox18.Size = size
            Me.txtGrandTotal.TabIndex = 8
            Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox19 As System.Windows.Forms.TextBox = Me.txtChange
            location = New System.Drawing.Point(171, 301)
            textBox19.Location = location
            Me.txtChange.Name = "txtChange"
            Me.txtChange.[ReadOnly] = True
            Dim textBox20 As System.Windows.Forms.TextBox = Me.txtChange
            size = New System.Drawing.Size(134, 26)
            textBox20.Size = size
            Me.txtChange.TabIndex = 11
            Me.txtChange.Text = "0.00"
            Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.Label8.AutoSize = True
            Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label8.ForeColor = System.Drawing.Color.White
            Dim label21 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(5, 301)
            label21.Location = location
            Me.Label8.Name = "Label8"
            Dim label22 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(77, 21)
            label22.Size = size
            Me.Label8.TabIndex = 346
            Me.Label8.Text = "Change : "
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label6.ForeColor = System.Drawing.Color.White
            Dim label23 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(3, 3)
            label23.Location = location
            Me.Label6.Name = "Label6"
            Dim label24 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(103, 21)
            label24.Size = size
            Me.Label6.TabIndex = 344
            Me.Label6.Text = "Discount % : "
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label7.ForeColor = System.Drawing.Color.White
            Dim label25 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(5, 245)
            label25.Location = location
            Me.Label7.Name = "Label7"
            Dim label26 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(56, 21)
            label26.Size = size
            Me.Label7.TabIndex = 345
            Me.Label7.Text = "Cash : "
            Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox21 As System.Windows.Forms.TextBox = Me.txtCash
            location = New System.Drawing.Point(171, 242)
            textBox21.Location = location
            Me.txtCash.Name = "txtCash"
            Dim textBox22 As System.Windows.Forms.TextBox = Me.txtCash
            size = New System.Drawing.Size(134, 26)
            textBox22.Size = size
            Me.txtCash.TabIndex = 9
            Me.txtCash.Text = "0.00"
            Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.TableLayoutPanel1.ColumnCount = 4
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.Controls.Add(Me.btn50f, 3, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.btn20f, 3, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btn10f, 3, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn1f, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn2f, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn3f, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn4f, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btn5f, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btn6f, 2, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btn7f, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.btn8f, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.btn9f, 2, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.btnDotf, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.btn0f, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.btnXf, 2, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.btn100f, 3, 3)
            Dim tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            location = New System.Drawing.Point(633, 516)
            tableLayoutPanel3.Location = location
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 4
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
            Dim tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            size = New System.Drawing.Size(311, 159)
            tableLayoutPanel4.Size = size
            Me.TableLayoutPanel1.TabIndex = 375
            Me.btn50f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn50f.BackColor = System.Drawing.Color.Green
            Me.btn50f.FlatAppearance.BorderSize = 0
            Me.btn50f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn50f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn50f.ForeColor = System.Drawing.Color.White
            Dim button9 As System.Windows.Forms.Button = Me.btn50f
            location = New System.Drawing.Point(234, 81)
            button9.Location = location
            Me.btn50f.Name = "btn50f"
            Dim button10 As System.Windows.Forms.Button = Me.btn50f
            size = New System.Drawing.Size(74, 33)
            button10.Size = size
            Me.btn50f.TabIndex = 382
            Me.btn50f.Text = "50"
            Me.btn50f.UseVisualStyleBackColor = False
            Me.btn20f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn20f.BackColor = System.Drawing.Color.Green
            Me.btn20f.FlatAppearance.BorderSize = 0
            Me.btn20f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn20f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn20f.ForeColor = System.Drawing.Color.White
            Dim button11 As System.Windows.Forms.Button = Me.btn20f
            location = New System.Drawing.Point(234, 42)
            button11.Location = location
            Me.btn20f.Name = "btn20f"
            Dim button12 As System.Windows.Forms.Button = Me.btn20f
            size = New System.Drawing.Size(74, 33)
            button12.Size = size
            Me.btn20f.TabIndex = 383
            Me.btn20f.Text = "20"
            Me.btn20f.UseVisualStyleBackColor = False
            Me.btn10f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn10f.BackColor = System.Drawing.Color.Green
            Me.btn10f.FlatAppearance.BorderSize = 0
            Me.btn10f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn10f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn10f.ForeColor = System.Drawing.Color.White
            Dim button13 As System.Windows.Forms.Button = Me.btn10f
            location = New System.Drawing.Point(234, 3)
            button13.Location = location
            Me.btn10f.Name = "btn10f"
            Dim button14 As System.Windows.Forms.Button = Me.btn10f
            size = New System.Drawing.Size(74, 33)
            button14.Size = size
            Me.btn10f.TabIndex = 381
            Me.btn10f.Text = "10"
            Me.btn10f.UseVisualStyleBackColor = False
            Me.btn1f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn1f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn1f.FlatAppearance.BorderSize = 0
            Me.btn1f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn1f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn1f.ForeColor = System.Drawing.Color.White
            Dim button15 As System.Windows.Forms.Button = Me.btn1f
            location = New System.Drawing.Point(3, 3)
            button15.Location = location
            Me.btn1f.Name = "btn1f"
            Dim button16 As System.Windows.Forms.Button = Me.btn1f
            size = New System.Drawing.Size(71, 33)
            button16.Size = size
            Me.btn1f.TabIndex = 348
            Me.btn1f.Text = "1"
            Me.btn1f.UseVisualStyleBackColor = False
            Me.btn2f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn2f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn2f.FlatAppearance.BorderSize = 0
            Me.btn2f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn2f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn2f.ForeColor = System.Drawing.Color.White
            Dim button17 As System.Windows.Forms.Button = Me.btn2f
            location = New System.Drawing.Point(80, 3)
            button17.Location = location
            Me.btn2f.Name = "btn2f"
            Dim button18 As System.Windows.Forms.Button = Me.btn2f
            size = New System.Drawing.Size(71, 33)
            button18.Size = size
            Me.btn2f.TabIndex = 349
            Me.btn2f.Text = "2"
            Me.btn2f.UseVisualStyleBackColor = False
            Me.btn3f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn3f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn3f.FlatAppearance.BorderSize = 0
            Me.btn3f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn3f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn3f.ForeColor = System.Drawing.Color.White
            Dim button19 As System.Windows.Forms.Button = Me.btn3f
            location = New System.Drawing.Point(157, 3)
            button19.Location = location
            Me.btn3f.Name = "btn3f"
            Dim button20 As System.Windows.Forms.Button = Me.btn3f
            size = New System.Drawing.Size(71, 33)
            button20.Size = size
            Me.btn3f.TabIndex = 350
            Me.btn3f.Text = "3"
            Me.btn3f.UseVisualStyleBackColor = False
            Me.btn4f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn4f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn4f.FlatAppearance.BorderSize = 0
            Me.btn4f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn4f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn4f.ForeColor = System.Drawing.Color.White
            Dim button21 As System.Windows.Forms.Button = Me.btn4f
            location = New System.Drawing.Point(3, 42)
            button21.Location = location
            Me.btn4f.Name = "btn4f"
            Dim button22 As System.Windows.Forms.Button = Me.btn4f
            size = New System.Drawing.Size(71, 33)
            button22.Size = size
            Me.btn4f.TabIndex = 359
            Me.btn4f.Text = "4"
            Me.btn4f.UseVisualStyleBackColor = False
            Me.btn5f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn5f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn5f.FlatAppearance.BorderSize = 0
            Me.btn5f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn5f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn5f.ForeColor = System.Drawing.Color.White
            Dim button23 As System.Windows.Forms.Button = Me.btn5f
            location = New System.Drawing.Point(80, 42)
            button23.Location = location
            Me.btn5f.Name = "btn5f"
            Dim button24 As System.Windows.Forms.Button = Me.btn5f
            size = New System.Drawing.Size(71, 33)
            button24.Size = size
            Me.btn5f.TabIndex = 351
            Me.btn5f.Text = "5"
            Me.btn5f.UseVisualStyleBackColor = False
            Me.btn6f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn6f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn6f.FlatAppearance.BorderSize = 0
            Me.btn6f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn6f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn6f.ForeColor = System.Drawing.Color.White
            Dim button25 As System.Windows.Forms.Button = Me.btn6f
            location = New System.Drawing.Point(157, 42)
            button25.Location = location
            Me.btn6f.Name = "btn6f"
            Dim button26 As System.Windows.Forms.Button = Me.btn6f
            size = New System.Drawing.Size(71, 33)
            button26.Size = size
            Me.btn6f.TabIndex = 352
            Me.btn6f.Text = "6"
            Me.btn6f.UseVisualStyleBackColor = False
            Me.btn7f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn7f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn7f.FlatAppearance.BorderSize = 0
            Me.btn7f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn7f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn7f.ForeColor = System.Drawing.Color.White
            Dim button27 As System.Windows.Forms.Button = Me.btn7f
            location = New System.Drawing.Point(3, 81)
            button27.Location = location
            Me.btn7f.Name = "btn7f"
            Dim button28 As System.Windows.Forms.Button = Me.btn7f
            size = New System.Drawing.Size(71, 33)
            button28.Size = size
            Me.btn7f.TabIndex = 353
            Me.btn7f.Text = "7"
            Me.btn7f.UseVisualStyleBackColor = False
            Me.btn8f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn8f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn8f.FlatAppearance.BorderSize = 0
            Me.btn8f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn8f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn8f.ForeColor = System.Drawing.Color.White
            Dim button29 As System.Windows.Forms.Button = Me.btn8f
            location = New System.Drawing.Point(80, 81)
            button29.Location = location
            Me.btn8f.Name = "btn8f"
            Dim button30 As System.Windows.Forms.Button = Me.btn8f
            size = New System.Drawing.Size(71, 33)
            button30.Size = size
            Me.btn8f.TabIndex = 354
            Me.btn8f.Text = "8"
            Me.btn8f.UseVisualStyleBackColor = False
            Me.btn9f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn9f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn9f.FlatAppearance.BorderSize = 0
            Me.btn9f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn9f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn9f.ForeColor = System.Drawing.Color.White
            Dim button31 As System.Windows.Forms.Button = Me.btn9f
            location = New System.Drawing.Point(157, 81)
            button31.Location = location
            Me.btn9f.Name = "btn9f"
            Dim button32 As System.Windows.Forms.Button = Me.btn9f
            size = New System.Drawing.Size(71, 33)
            button32.Size = size
            Me.btn9f.TabIndex = 355
            Me.btn9f.Text = "9"
            Me.btn9f.UseVisualStyleBackColor = False
            Me.btnDotf.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnDotf.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnDotf.FlatAppearance.BorderSize = 0
            Me.btnDotf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDotf.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDotf.ForeColor = System.Drawing.Color.White
            Dim button33 As System.Windows.Forms.Button = Me.btnDotf
            location = New System.Drawing.Point(3, 120)
            button33.Location = location
            Me.btnDotf.Name = "btnDotf"
            Dim button34 As System.Windows.Forms.Button = Me.btnDotf
            size = New System.Drawing.Size(71, 36)
            button34.Size = size
            Me.btnDotf.TabIndex = 356
            Me.btnDotf.Text = "."
            Me.btnDotf.UseVisualStyleBackColor = False
            Me.btn0f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btn0f.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btn0f.FlatAppearance.BorderSize = 0
            Me.btn0f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn0f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn0f.ForeColor = System.Drawing.Color.White
            Dim button35 As System.Windows.Forms.Button = Me.btn0f
            location = New System.Drawing.Point(80, 120)
            button35.Location = location
            Me.btn0f.Name = "btn0f"
            Dim button36 As System.Windows.Forms.Button = Me.btn0f
            size = New System.Drawing.Size(71, 36)
            button36.Size = size
            Me.btn0f.TabIndex = 357
            Me.btn0f.Text = "0"
            Me.btn0f.UseVisualStyleBackColor = False
            Me.btnXf.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnXf.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnXf.FlatAppearance.BorderSize = 0
            Me.btnXf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnXf.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnXf.ForeColor = System.Drawing.Color.White
            Dim button37 As System.Windows.Forms.Button = Me.btnXf
            location = New System.Drawing.Point(157, 120)
            button37.Location = location
            Me.btnXf.Name = "btnXf"
            Dim button38 As System.Windows.Forms.Button = Me.btnXf
            size = New System.Drawing.Size(71, 36)
            button38.Size = size
            Me.btnXf.TabIndex = 358
            Me.btnXf.Text = "x"
            Me.btnXf.UseVisualStyleBackColor = False
            Me.btn100f.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btn100f.BackColor = System.Drawing.Color.Green
            Me.btn100f.FlatAppearance.BorderSize = 0
            Me.btn100f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn100f.Font = New System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn100f.ForeColor = System.Drawing.Color.White
            Dim button39 As System.Windows.Forms.Button = Me.btn100f
            location = New System.Drawing.Point(234, 120)
            button39.Location = location
            Me.btn100f.Name = "btn100f"
            Dim button40 As System.Windows.Forms.Button = Me.btn100f
            size = New System.Drawing.Size(74, 36)
            button40.Size = size
            Me.btn100f.TabIndex = 381
            Me.btn100f.Text = "100"
            Me.btn100f.UseVisualStyleBackColor = False
            Me.DataGridView2.AllowUserToAddRows = False
            Me.DataGridView2.AllowUserToDeleteRows = False
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18
            Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19
            Me.DataGridView2.ColumnHeadersHeight = 40
            Me.DataGridView2.Columns.AddRange(Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.Column1)
            Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.DefaultCellStyle = dataGridViewCellStyle20
            Me.DataGridView2.EnableHeadersVisualStyles = False
            Me.DataGridView2.GridColor = System.Drawing.Color.White
            Dim dataGridView3 As System.Windows.Forms.DataGridView = Me.DataGridView2
            location = New System.Drawing.Point(436, 0)
            dataGridView3.Location = location
            Me.DataGridView2.MultiSelect = False
            Me.DataGridView2.Name = "DataGridView2"
            Me.DataGridView2.[ReadOnly] = True
            Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSeaGreen
            dataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Orange
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle21
            Me.DataGridView2.RowHeadersVisible = False
            Me.DataGridView2.RowHeadersWidth = 25
            Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle22.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle22
            Me.DataGridView2.RowTemplate.Height = 20
            Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView4 As System.Windows.Forms.DataGridView = Me.DataGridView2
            size = New System.Drawing.Size(507, 177)
            dataGridView4.Size = size
            Me.DataGridView2.TabIndex = 377
            Me.DataGridViewTextBoxColumn12.FillWeight = 115.2738F
            Me.DataGridViewTextBoxColumn12.HeaderText = "Table No."
            Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
            Me.DataGridViewTextBoxColumn12.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn12.Visible = False
            Me.DataGridViewTextBoxColumn13.FillWeight = 229.3253F
            Me.DataGridViewTextBoxColumn13.HeaderText = "Item Name"
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.[ReadOnly] = True
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            dataGridViewCellStyle23.NullValue = Nothing
            Me.DataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle23
            Me.DataGridViewTextBoxColumn14.FillWeight = 71.88303F
            Me.DataGridViewTextBoxColumn14.HeaderText = "Rate"
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            Me.DataGridViewTextBoxColumn14.[ReadOnly] = True
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle24
            Me.DataGridViewTextBoxColumn15.FillWeight = 66.47659F
            Me.DataGridViewTextBoxColumn15.HeaderText = "Qty."
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.[ReadOnly] = True
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle25
            Me.DataGridViewTextBoxColumn16.FillWeight = 96.83242F
            Me.DataGridViewTextBoxColumn16.HeaderText = "Amount"
            Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
            Me.DataGridViewTextBoxColumn16.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn16.Visible = False
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle26
            Me.DataGridViewTextBoxColumn17.FillWeight = 93.34656F
            Me.DataGridViewTextBoxColumn17.HeaderText = "Discount %"
            Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
            Me.DataGridViewTextBoxColumn17.[ReadOnly] = True
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle27
            Me.DataGridViewTextBoxColumn18.FillWeight = 92.25301F
            Me.DataGridViewTextBoxColumn18.HeaderText = "Discount"
            Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
            Me.DataGridViewTextBoxColumn18.[ReadOnly] = True
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle28
            Me.DataGridViewTextBoxColumn19.FillWeight = 89.92587F
            Me.DataGridViewTextBoxColumn19.HeaderText = "ST %"
            Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
            Me.DataGridViewTextBoxColumn19.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn19.Visible = False
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle29
            Me.DataGridViewTextBoxColumn20.FillWeight = 88.78162F
            Me.DataGridViewTextBoxColumn20.HeaderText = "ST Amount"
            Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
            Me.DataGridViewTextBoxColumn20.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn20.Visible = False
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle30
            Me.DataGridViewTextBoxColumn21.FillWeight = 86.44057F
            Me.DataGridViewTextBoxColumn21.HeaderText = "HST %"
            Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
            Me.DataGridViewTextBoxColumn21.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn21.Visible = False
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle31
            Me.DataGridViewTextBoxColumn22.FillWeight = 85.30766F
            Me.DataGridViewTextBoxColumn22.HeaderText = "HST Amount"
            Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
            Me.DataGridViewTextBoxColumn22.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn22.Visible = False
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle32
            Me.DataGridViewTextBoxColumn23.HeaderText = "SC %"
            Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
            Me.DataGridViewTextBoxColumn23.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn23.Visible = False
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn24.DefaultCellStyle = dataGridViewCellStyle33
            Me.DataGridViewTextBoxColumn24.HeaderText = "SC Amount"
            Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
            Me.DataGridViewTextBoxColumn24.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn24.Visible = False
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn25.DefaultCellStyle = dataGridViewCellStyle34
            Me.DataGridViewTextBoxColumn25.FillWeight = 84.15354F
            Me.DataGridViewTextBoxColumn25.HeaderText = "Total Amount"
            Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
            Me.DataGridViewTextBoxColumn25.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn26.HeaderText = "Group Name"
            Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
            Me.DataGridViewTextBoxColumn26.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn26.Visible = False
            Me.DataGridViewTextBoxColumn27.HeaderText = "TempDesc"
            Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
            Me.DataGridViewTextBoxColumn27.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn27.Visible = False
            Me.DataGridViewTextBoxColumn28.HeaderText = "Category"
            Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
            Me.DataGridViewTextBoxColumn28.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn28.Visible = False
            Me.Column1.HeaderText = "Dish Name Arabic"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.btnSave1.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.btnSave1.BackColor = System.Drawing.Color.Green
            Me.btnSave1.FlatAppearance.BorderSize = 0
            Me.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button41 As System.Windows.Forms.Button = Me.btnSave1
            location = New System.Drawing.Point(439, 183)
            button41.Location = location
            Me.btnSave1.Name = "btnSave1"
            Dim button42 As System.Windows.Forms.Button = Me.btnSave1
            size = New System.Drawing.Size(188, 77)
            button42.Size = size
            Me.btnSave1.TabIndex = 378
            Me.btnSave1.Text = "Save + Print"
            Me.btnSave1.UseVisualStyleBackColor = False
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label27 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(-3, 627)
            label27.Location = location
            Me.Label1.Name = "Label1"
            Dim label28 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(117, 45)
            label28.Size = size
            Me.Label1.TabIndex = 379
            Me.Label1.Text = "Total : "
            Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblTotal.ForeColor = System.Drawing.Color.White
            Dim label29 As System.Windows.Forms.Label = Me.lblTotal
            location = New System.Drawing.Point(101, 627)
            label29.Location = location
            Me.lblTotal.Name = "lblTotal"
            Dim label30 As System.Windows.Forms.Label = Me.lblTotal
            size = New System.Drawing.Size(126, 45)
            label30.Size = size
            Me.lblTotal.TabIndex = 380
            Me.lblTotal.Text = "lblTotal"
            Me.Label24.AutoSize = True
            Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label24.ForeColor = System.Drawing.Color.White
            Dim label31 As System.Windows.Forms.Label = Me.Label24
            location = New System.Drawing.Point(10, 57)
            label31.Location = location
            Me.Label24.Name = "Label24"
            Dim label32 As System.Windows.Forms.Label = Me.Label24
            size = New System.Drawing.Size(157, 25)
            label32.Size = size
            Me.Label24.TabIndex = 383
            Me.Label24.Text = "Payment Mode : "
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = System.Drawing.Color.White
            Dim label33 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(10, 7)
            label33.Location = location
            Me.Label4.Name = "Label4"
            Dim label34 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(89, 25)
            label34.Size = size
            Me.Label4.TabIndex = 381
            Me.Label4.Text = "Bill No. : "
            Me.lblBillNo.AutoSize = True
            Me.lblBillNo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblBillNo.ForeColor = System.Drawing.Color.White
            Dim label35 As System.Windows.Forms.Label = Me.lblBillNo
            location = New System.Drawing.Point(114, 7)
            label35.Location = location
            Me.lblBillNo.Name = "lblBillNo"
            Dim label36 As System.Windows.Forms.Label = Me.lblBillNo
            size = New System.Drawing.Size(85, 25)
            label36.Size = size
            Me.lblBillNo.TabIndex = 382
            Me.lblBillNo.Text = "lblBillNo"
            Me.lblPaymentMode.AutoSize = True
            Me.lblPaymentMode.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblPaymentMode.ForeColor = System.Drawing.Color.White
            Dim label37 As System.Windows.Forms.Label = Me.lblPaymentMode
            location = New System.Drawing.Point(161, 57)
            label37.Location = location
            Me.lblPaymentMode.Name = "lblPaymentMode"
            Dim label38 As System.Windows.Forms.Label = Me.lblPaymentMode
            size = New System.Drawing.Size(0, 25)
            label38.Size = size
            Me.lblPaymentMode.TabIndex = 384
            Dim textBox23 As System.Windows.Forms.TextBox = Me.txtBillID
            location = New System.Drawing.Point(400, 62)
            textBox23.Location = location
            Me.txtBillID.Name = "txtBillID"
            Dim textBox24 As System.Windows.Forms.TextBox = Me.txtBillID
            size = New System.Drawing.Size(30, 20)
            textBox24.Size = size
            Me.txtBillID.TabIndex = 385
            Me.txtBillID.Visible = False
            Me.lblOrderNo.AutoSize = True
            Me.lblOrderNo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblOrderNo.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label39 As System.Windows.Forms.Label = Me.lblOrderNo
            location = New System.Drawing.Point(340, 32)
            label39.Location = location
            Me.lblOrderNo.Name = "lblOrderNo"
            Dim label40 As System.Windows.Forms.Label = Me.lblOrderNo
            size = New System.Drawing.Size(76, 25)
            label40.Size = size
            Me.lblOrderNo.TabIndex = 449
            Me.lblOrderNo.Text = "lblODN"
            Me.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblOrderNo.Visible = False
            Me.lblOD.AutoSize = True
            Me.lblOD.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblOD.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label41 As System.Windows.Forms.Label = Me.lblOD
            location = New System.Drawing.Point(340, 9)
            label41.Location = location
            Me.lblOD.Name = "lblOD"
            Dim label42 As System.Windows.Forms.Label = Me.lblOD
            size = New System.Drawing.Size(50, 25)
            label42.Size = size
            Me.lblOD.TabIndex = 448
            Me.lblOD.Text = "OD :"
            Me.lblOD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblOD.Visible = False
            Dim textBox25 As System.Windows.Forms.TextBox = Me.lblMemberType
            location = New System.Drawing.Point(345, 63)
            textBox25.Location = location
            Me.lblMemberType.Name = "lblMemberType"
            Dim textBox26 As System.Windows.Forms.TextBox = Me.lblMemberType
            size = New System.Drawing.Size(30, 20)
            textBox26.Size = size
            Me.lblMemberType.TabIndex = 450
            Me.lblMemberType.Visible = False
            Me.lblMemberID.AutoSize = True
            Me.lblMemberID.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblMemberID.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label43 As System.Windows.Forms.Label = Me.lblMemberID
            location = New System.Drawing.Point(304, 9)
            label43.Location = location
            Me.lblMemberID.Name = "lblMemberID"
            Dim label44 As System.Windows.Forms.Label = Me.lblMemberID
            size = New System.Drawing.Size(126, 25)
            label44.Size = size
            Me.lblMemberID.TabIndex = 451
            Me.lblMemberID.Text = "lblMemberID"
            Me.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblMemberID.Visible = False
            Me.lblUserVAL.AutoSize = True
            Me.lblUserVAL.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUserVAL.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label45 As System.Windows.Forms.Label = Me.lblUserVAL
            location = New System.Drawing.Point(340, 46)
            label45.Location = location
            Me.lblUserVAL.Name = "lblUserVAL"
            Dim label46 As System.Windows.Forms.Label = Me.lblUserVAL
            size = New System.Drawing.Size(104, 25)
            label46.Size = size
            Me.lblUserVAL.TabIndex = 452
            Me.lblUserVAL.Text = "lblUserVAL"
            Me.lblUserVAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.lblUserVAL.Visible = False
            Dim textBox27 As System.Windows.Forms.TextBox = Me.txtTaxType
            location = New System.Drawing.Point(345, 63)
            textBox27.Location = location
            Me.txtTaxType.Name = "txtTaxType"
            Dim textBox28 As System.Windows.Forms.TextBox = Me.txtTaxType
            size = New System.Drawing.Size(30, 20)
            textBox28.Size = size
            Me.txtTaxType.TabIndex = 453
            Me.txtTaxType.Visible = False
            Me.lblCustNameVAL.AutoSize = True
            Me.lblCustNameVAL.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblCustNameVAL.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label47 As System.Windows.Forms.Label = Me.lblCustNameVAL
            location = New System.Drawing.Point(322, 32)
            label47.Location = location
            Me.lblCustNameVAL.Name = "lblCustNameVAL"
            Dim label48 As System.Windows.Forms.Label = Me.lblCustNameVAL
            size = New System.Drawing.Size(156, 25)
            label48.Size = size
            Me.lblCustNameVAL.TabIndex = 454
            Me.lblCustNameVAL.Text = "lblCustNameVAL"
            Me.lblCustNameVAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblCustNameVAL.Visible = False
            Dim textBox29 As System.Windows.Forms.TextBox = Me.txtTransID
            location = New System.Drawing.Point(318, 59)
            textBox29.Location = location
            Me.txtTransID.Name = "txtTransID"
            Dim textBox30 As System.Windows.Forms.TextBox = Me.txtTransID
            size = New System.Drawing.Size(30, 20)
            textBox30.Size = size
            Me.txtTransID.TabIndex = 455
            Me.txtTransID.Visible = False
            Dim textBox31 As System.Windows.Forms.TextBox = Me.txtGroupName
            location = New System.Drawing.Point(375, 38)
            textBox31.Location = location
            Me.txtGroupName.Name = "txtGroupName"
            Dim textBox32 As System.Windows.Forms.TextBox = Me.txtGroupName
            size = New System.Drawing.Size(30, 20)
            textBox32.Size = size
            Me.txtGroupName.TabIndex = 456
            Me.txtGroupName.Visible = False
            Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.btnReset.BackColor = System.Drawing.Color.Crimson
            Me.btnReset.FlatAppearance.BorderSize = 0
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button43 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(316, 627)
            button43.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button44 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(114, 45)
            button44.Size = size
            Me.btnReset.TabIndex = 457
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(952, 675)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.txtGroupName)
            MyBase.Controls.Add(Me.txtTransID)
            MyBase.Controls.Add(Me.lblCustNameVAL)
            MyBase.Controls.Add(Me.txtTaxType)
            MyBase.Controls.Add(Me.lblUserVAL)
            MyBase.Controls.Add(Me.lblMemberID)
            MyBase.Controls.Add(Me.lblMemberType)
            MyBase.Controls.Add(Me.lblOrderNo)
            MyBase.Controls.Add(Me.lblOD)
            MyBase.Controls.Add(Me.txtBillID)
            MyBase.Controls.Add(Me.lblPaymentMode)
            MyBase.Controls.Add(Me.Label24)
            MyBase.Controls.Add(Me.Label4)
            MyBase.Controls.Add(Me.lblBillNo)
            MyBase.Controls.Add(Me.lblTotal)
            MyBase.Controls.Add(Me.Label1)
            MyBase.Controls.Add(Me.btnSave1)
            MyBase.Controls.Add(Me.DataGridView2)
            MyBase.Controls.Add(Me.TableLayoutPanel3)
            MyBase.Controls.Add(Me.TableLayoutPanel1)
            MyBase.Controls.Add(Me.pnlKOT)
            MyBase.Controls.Add(Me.lblTableNo)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.dgw)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmBillSplit"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Split Items"
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.pnlKOT.ResumeLayout(False)
            Me.pnlKOT.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub

    End Class
End Namespace
