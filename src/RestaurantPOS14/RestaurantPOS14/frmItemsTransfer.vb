Imports System
Imports System.Collections
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
    Public Class frmItemsTransfer
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbTranferFrom")>
        Private _cmbTranferFrom As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbTransferTo")>
        Private _cmbTransferTo As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTableTransfer")>
        Private _btnTableTransfer As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSelectedTable")>
        Private _lblSelectedTable As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbTicketNo")>
        Private _cmbTicketNo As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView2")>
        Private _DataGridView2 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn1")>
        Private _DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn2")>
        Private _DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn3")>
        Private _DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn4")>
        Private _DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn5")>
        Private _DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn6")>
        Private _DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn7")>
        Private _DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn8")>
        Private _DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn9")>
        Private _DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn10")>
        Private _DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn11")>
        Private _DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblBalance1")>
        Private _lblBalance1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblBalance2")>
        Private _lblBalance2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Rate")>
        Private _Rate As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Qty")>
        Private _Qty As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Amount")>
        Private _Amount As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column8")>
        Private _Column8 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("VATPer")>
        Private _VATPer As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("VAT")>
        Private _VAT As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column17")>
        Private _Column17 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column18")>
        Private _Column18 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TotalAmount")>
        Private _TotalAmount As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column13")>
        Private _Column13 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column30")>
        Private _Column30 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column31")>
        Private _Column31 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column37")>
        Private _Column37 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTicketID")>
        Private _txtTicketID As System.Windows.Forms.TextBox

        Private num1 As Double

        Private num2 As Double

        Private num3 As Double

        Private num4 As Double

        Private num5 As Double

        Private num6 As Double

        Private num7 As Double

        Private str2 As Integer

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property cmbTranferFrom As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbTranferFrom
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbTranferFrom_SelectedIndexChanged
                If Me._cmbTranferFrom IsNot Nothing Then
                    RemoveHandler Me._cmbTranferFrom.SelectedIndexChanged, value2
                End If

                Me._cmbTranferFrom = value
                If Me._cmbTranferFrom IsNot Nothing Then
                    AddHandler Me._cmbTranferFrom.SelectedIndexChanged, value2
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

        Friend Overridable Property cmbTransferTo As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbTransferTo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbTransferTo_SelectedIndexChanged
                If Me._cmbTransferTo IsNot Nothing Then
                    RemoveHandler Me._cmbTransferTo.SelectedIndexChanged, value2
                End If

                Me._cmbTransferTo = value
                If Me._cmbTransferTo IsNot Nothing Then
                    AddHandler Me._cmbTransferTo.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTableTransfer As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTableTransfer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnTableTransfer_Click
                If Me._btnTableTransfer IsNot Nothing Then
                    RemoveHandler Me._btnTableTransfer.Click, value2
                End If

                Me._btnTableTransfer = value
                If Me._btnTableTransfer IsNot Nothing Then
                    AddHandler Me._btnTableTransfer.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblSelectedTable As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblSelectedTable
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblSelectedTable = value
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

        Friend Overridable Property cmbTicketNo As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbTicketNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbTicketNo_SelectedIndexChanged
                If Me._cmbTicketNo IsNot Nothing Then
                    RemoveHandler Me._cmbTicketNo.SelectedIndexChanged, value2
                End If

                Me._cmbTicketNo = value
                If Me._cmbTicketNo IsNot Nothing Then
                    AddHandler Me._cmbTicketNo.SelectedIndexChanged, value2
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

        Friend Overridable Property DataGridView1 As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.DataGridView1_MouseClick
                Dim value3 As System.Windows.Forms.DataGridViewCellEventHandler = AddressOf Me.DataGridView1_CellValueChanged
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.MouseClick, value2
                    RemoveHandler Me._DataGridView1.CellValueChanged, value3
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.MouseClick, value2
                    AddHandler Me._DataGridView1.CellValueChanged, value3
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

        Friend Overridable Property DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn2 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn3 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn4 = value
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

        Friend Overridable Property DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn9 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn10
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn10 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn11
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn11 = value
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

        Friend Overridable Property lblBalance1 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblBalance1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblBalance1 = value
            End Set
        End Property

        Friend Overridable Property lblBalance2 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblBalance2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblBalance2 = value
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

        Friend Overridable Property Column30 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column30
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column30 = value
            End Set
        End Property

        Friend Overridable Property Column31 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column31
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column31 = value
            End Set
        End Property

        Friend Overridable Property Column37 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column37
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column37 = value
            End Set
        End Property

        Friend Overridable Property txtTicketID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTicketID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTicketID = value
            End Set
        End Property

        Public Sub New()
            Call RestaurantPOS14.frmItemsTransfer.__ENCAddToList(Me)
            Me.str2 = 0
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmItemsTransfer.__ENCList
                If RestaurantPOS14.frmItemsTransfer.__ENCList.Count = RestaurantPOS14.frmItemsTransfer.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmItemsTransfer.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmItemsTransfer.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmItemsTransfer.__ENCList(num) = RestaurantPOS14.frmItemsTransfer.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmItemsTransfer.__ENCList.RemoveRange(num, RestaurantPOS14.frmItemsTransfer.__ENCList.Count - num)
                    RestaurantPOS14.frmItemsTransfer.__ENCList.Capacity = RestaurantPOS14.frmItemsTransfer.__ENCList.Count
                End If

                Call RestaurantPOS14.frmItemsTransfer.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Reset()
            MyBase.Close()
        End Sub

        Public Sub FillTransferFrom()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select distinct RTRIM(TableNo) from RestaurantPOS_OrderInfoKOT where KOT_Status in ('Open','Prepared') and TableNo not in (Select RTRIM(TableNo) from RestaurantPOS_BillingInfoKOT,RestaurantPOS_OrderedProductBillKOT where RestaurantPOS_BillingInfoKOT.Id=RestaurantPOS_OrderedProductBillKOT.BillID and DIB_Status='Unpaid') order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Me.cmbTranferFrom.Items.Clear()
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.cmbTranferFrom.Items.Add(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString())
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub FillTransferTo()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select distinct RTRIM(TableNo) from R_Table where Status='Activate' and TableNo not in (Select RTRIM(TableNo) from RestaurantPOS_BillingInfoKOT,RestaurantPOS_OrderedProductBillKOT where RestaurantPOS_BillingInfoKOT.Id=RestaurantPOS_OrderedProductBillKOT.BillID and DIB_Status='Unpaid') order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Me.cmbTransferTo.Items.Clear()
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.cmbTransferTo.Items.Add(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString())
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.FillTransferFrom()
            Me.FillTransferTo()
            Me.cmbTranferFrom.SelectedIndex = -1
            Me.cmbTransferTo.SelectedIndex = -1
            Me.cmbTicketNo.SelectedIndex = -1
            Me.cmbTicketNo.Enabled = False
            Me.cmbTranferFrom.Enabled = True
            Me.DataGridView1.Rows.Clear()
            Me.DataGridView2.Rows.Clear()
            Me.lblBalance1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
            Me.lblBalance2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
            Me.txtTicketID.Text = ""
        End Sub

        Private Sub btnTableTransfer_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.DataGridView2.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry, no item added to datagridview for transfer.", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbTransferTo.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select transter to table.", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbTranferFrom.Text, Me.cmbTransferTo.Text, TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("'Transfer From' and 'Transfer To' tables must be different.", "Selection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Return
                End If

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.auto()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into RestaurantPOS_OrderInfoKOT( Id,TicketNo, BillDate, GrandTotal,tableNo,Operator,GroupName,TicketNote,KOT_Status,TaxType,NoOfPerson) Values (" & RestaurantPOS14.Security.SqlInput.RequireInteger(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTicketID.Text, "Record ID") & ",@d6,@d2," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblBalance2.Text)) & ",@d1,@d3,@d4,@d5,'Open',@dTax," & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNoofPeople.Text)) & ")")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbTransferTo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.DateTime.Now)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", "")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", "")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTicketNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@dTax", RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTaxType.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into RestaurantPOS_OrderedProductKOT(TicketID,Dish,Rate,Quantity,Amount,DiscountPer, DiscountAmount, STPer, STAmount, VATPer, VATAmount,SCPer,SCAmount,TotalAmount,Notes,Category,T_Number,DishNameArabic,ItemStatus) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTicketID.Text, "Record ID") & ",@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18)")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Prepare()
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value)))
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
                        If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((13))).Value, "", TextCompare:=False) Then
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", "")
                        Else
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((13))).Value))
                        End If

                        If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((15))).Value, "", TextCompare:=False) Then
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", "")
                        Else
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((15))).Value))
                        End If

                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.cmbTransferTo.Text)
                        If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((16))).Value.ToString(), "", TextCompare:=False) = 0 Then
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", "")
                        Else
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", dataGridViewRow.Cells(CInt((16))).Value.ToString())
                        End If

                        If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((17))).Value.ToString(), "", TextCompare:=False) = 0 Then
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d18", "")
                        Else
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d18", dataGridViewRow.Cells(CInt((17))).Value.ToString())
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update R_Table set BkColor=@d2 where TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbTransferTo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Drawing.Color.Red.ToArgb())
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                If Me.DataGridView1.Rows.Count = 0 Then
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select Count(TicketNo) from RestaurantPOS_OrderInfoKOT where TableNo=@d1 and KOT_Status in ('Open','Served','Prepared')")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbTranferFrom.Text)
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.str2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                        If Microsoft.VisualBasic.Conversion.Val(Me.str2) = 1.0 Then
                            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                            RestaurantPOS14.ModClasses.con.Open()
                            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update R_Table set BkColor=@d2 where TableNo=@d1")
                            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbTranferFrom.Text)
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Drawing.Color.LightGreen.ToArgb())
                            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                            RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                            RestaurantPOS14.ModClasses.con.Close()
                        End If
                    End If

                    If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                        RestaurantPOS14.ModClasses.con.Close()
                    End If

                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from RestaurantPOS_OrderInfoKOT where TicketNo=@d1")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbTicketNo.Text)
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                        RestaurantPOS14.ModClasses.con.Close()
                    End If
                End If

                If Me.DataGridView1.Rows.Count > 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT ID from RestaurantPOS_OrderInfoKOT where TicketNo=@d1", RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbTicketNo.Text)
                    Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    If sqlDataReader.Read() Then
                        Me.txtTicketID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0))
                    Else
                        Me.txtTicketID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_OrderInfoKOT set  GrandTotal=" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblBalance1.Text)) & " where ID=@d1")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtTicketID.Text))
                    RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from RestaurantPOS_OrderedProductKOT where TicketID=@d1")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtTicketID.Text))
                    RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                    If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                        RestaurantPOS14.ModClasses.con.Close()
                    End If

                    Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into RestaurantPOS_OrderedProductKOT(TicketID,Dish,Rate,Quantity,Amount,DiscountPer, DiscountAmount, STPer, STAmount, VATPer, VATAmount,SCPer,SCAmount,TotalAmount,Notes,Category,T_Number,DishNameArabic,ItemStatus) VALUES (" & Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtTicketID.Text)) & ",@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,'Old')")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Prepare()
                    For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                        If Not dataGridViewRow2.IsNewRow Then
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((0))).Value))
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((1))).Value)))
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
                            If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells(CInt((13))).Value, "", TextCompare:=False) Then
                                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", "")
                            Else
                                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d14", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((13))).Value))
                            End If

                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d15", System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((15))).Value))
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d16", Me.cmbTranferFrom.Text)
                            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow2.Cells(CInt((16))).Value.ToString(), "", TextCompare:=False) = 0 Then
                                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", "")
                            Else
                                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d17", dataGridViewRow2.Cells(CInt((16))).Value.ToString())
                            End If

                            RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                            RestaurantPOS14.ModClasses.cmd.Parameters.Clear()
                        End If
                    Next

                    RestaurantPOS14.ModClasses.con.Close()
                End If

                Call System.Windows.Forms.MessageBox.Show("Transferred Successfully.", "Items", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub cmbTranferFrom_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                Me.DataGridView1.Rows.Clear()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(TicketNo) from RestaurantPOS_OrderInfoKOT where KOT_Status in ('Open','Prepared') and TableNo=@d1 order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbTranferFrom.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Me.cmbTicketNo.Enabled = True
                Me.cmbTicketNo.Items.Clear()
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.cmbTicketNo.Items.Add(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString())
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbTicketNo_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                Me.cmbTranferFrom.Enabled = False
                Me.cmbTicketNo.Enabled = False
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(Dish),RTRIM(Rate),RTRIM(Quantity),RTRIM(Amount),RTRIM(DiscountPer), RTRIM(DiscountAmount), RTRIM(STPer), RTRIM(STAmount), RTRIM(VATPer), RTRIM(VATAmount),SCPer,SCAmount,RTRIM(TotalAmount),RTRIM(Notes),Quantity,RTRIM(Category),RTRIM(DishNameArabic) from RestaurantPOS_OrderInfoKOT,RestaurantPOS_OrderedProductKOT where RestaurantPOS_OrderInfoKOT.Id=RestaurantPOS_OrderedProductKOT.TicketID and ItemStatus in ('Old','New') and RestaurantPOS_OrderInfoKOT.TicketNo=@d1 order by op_id", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbTicketNo.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.DataGridView1.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(16)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
                Dim value As Double = Me.GrandTotal_Food1()
                value = System.Math.Round(value, 2)
                Me.lblBalance1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Me.DataGridView1.Rows.Count > 0 Then
                If Me.DataGridView1.SelectedRows.Count = 0 Then Return
                Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.DataGridView1.SelectedRows(0)
                RestaurantPOS14.My.MyProject.Forms.frmEnterQtyX.txtQ.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((2))).Value)
                RestaurantPOS14.My.MyProject.Forms.frmEnterQtyX.txtCategory.Text = dataGridViewRow.Cells(CInt((15))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmEnterQtyX.txtDishNameArabic.Text = dataGridViewRow.Cells(CInt((16))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmEnterQtyX.txtQty.Text = ""
                Call RestaurantPOS14.My.MyProject.Forms.frmEnterQtyX.txtQty.Focus()
                Call RestaurantPOS14.My.MyProject.Forms.frmEnterQtyX.ShowDialog()
            End If
        End Sub

        Public Function GrandTotal_Food1() As Double
            Dim num As Double = 0.0
            Try
                If Me.DataGridView1.Rows.Count > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                        num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((12))).Value))
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
                        num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((12))).Value))
                    Next
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Private Sub DataGridView1_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            Try
                If Me.DataGridView1.Rows.Count > 0 Then
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTaxType.Text, "Inclusive", TextCompare:=False) = 0 Then
                        Me.num1 = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("Rate"))).Value)) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("Qty"))).Value))
                        Me.num1 = System.Math.Round(Me.num1, 2)
                        Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("Amount"))).Value = Me.num1
                        Me.num5 = Me.num1 - Me.num1 / (1.0 + Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("VATPer"))).Value)) / 100.0)
                        Me.num5 = System.Math.Round(Me.num5, 2)
                        Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("VAT"))).Value = Me.num5
                        Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("TotalAmount"))).Value = Me.num1
                    Else
                        Me.num1 = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("Rate"))).Value)) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("Qty"))).Value))
                        Me.num1 = System.Math.Round(Me.num1, 2)
                        Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("Amount"))).Value = Me.num1
                        Me.num5 = Microsoft.VisualBasic.Conversion.Val(Me.num1) * Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("VATPer"))).Value)) / 100.0
                        Me.num5 = System.Math.Round(Me.num5, 2)
                        Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("VAT"))).Value = Me.num5
                        Me.num6 = Me.num1 + Me.num5
                        Me.num6 = System.Math.Round(Me.num6, 2)
                        Me.DataGridView1.Rows(CInt((e.RowIndex))).Cells(CStr(("TotalAmount"))).Value = Me.num6
                    End If
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbTransferTo_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbTranferFrom.Text, Me.cmbTransferTo.Text, TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("'Transfer From' and 'Transfer To' tables must be different.", "Selection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmItemsTransfer))
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cmbTranferFrom = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cmbTransferTo = New System.Windows.Forms.ComboBox()
            Me.btnTableTransfer = New System.Windows.Forms.Button()
            Me.lblSelectedTable = New System.Windows.Forms.Label()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.cmbTicketNo = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VATPer = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.VAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridView2 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblBalance1 = New System.Windows.Forms.Label()
            Me.lblBalance2 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.txtTicketID = New System.Windows.Forms.TextBox()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label5
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 1)
            label.Location = location
            Me.Label5.Name = "Label5"
            Dim label2 As System.Windows.Forms.Label = Me.Label5
            Dim size As System.Drawing.Size = New System.Drawing.Size(927, 50)
            label2.Size = size
            Me.Label5.TabIndex = 20
            Me.Label5.Text = "Items Transfer"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(0, 55)
            label3.Location = location
            Me.Label1.Name = "Label1"
            Dim label4 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(140, 25)
            label4.Size = size
            Me.Label1.TabIndex = 66
            Me.Label1.Text = "Transfer From :"
            Me.cmbTranferFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTranferFrom.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbTranferFrom.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbTranferFrom
            location = New System.Drawing.Point(5, 83)
            comboBox.Location = location
            Me.cmbTranferFrom.Name = "cmbTranferFrom"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbTranferFrom
            size = New System.Drawing.Size(177, 45)
            comboBox2.Size = size
            Me.cmbTranferFrom.TabIndex = 67
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(390, 55)
            label5.Location = location
            Me.Label4.Name = "Label4"
            Dim label6 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(114, 25)
            label6.Size = size
            Me.Label4.TabIndex = 71
            Me.Label4.Text = "Transfer To :"
            Me.cmbTransferTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTransferTo.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbTransferTo.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbTransferTo
            location = New System.Drawing.Point(395, 83)
            comboBox3.Location = location
            Me.cmbTransferTo.Name = "cmbTransferTo"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbTransferTo
            size = New System.Drawing.Size(183, 45)
            comboBox4.Size = size
            Me.cmbTransferTo.TabIndex = 72
            Me.btnTableTransfer.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnTableTransfer.FlatAppearance.BorderSize = 0
            Me.btnTableTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnTableTransfer.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTableTransfer.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnTableTransfer
            location = New System.Drawing.Point(584, 83)
            button.Location = location
            Me.btnTableTransfer.Name = "btnTableTransfer"
            Dim button2 As System.Windows.Forms.Button = Me.btnTableTransfer
            size = New System.Drawing.Size(201, 45)
            button2.Size = size
            Me.btnTableTransfer.TabIndex = 73
            Me.btnTableTransfer.Text = "Transfer"
            Me.btnTableTransfer.UseVisualStyleBackColor = False
            Me.lblSelectedTable.AutoSize = True
            Me.lblSelectedTable.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblSelectedTable.ForeColor = System.Drawing.Color.MidnightBlue
            Dim label7 As System.Windows.Forms.Label = Me.lblSelectedTable
            location = New System.Drawing.Point(441, 179)
            label7.Location = location
            Me.lblSelectedTable.Name = "lblSelectedTable"
            Dim label8 As System.Windows.Forms.Label = Me.lblSelectedTable
            size = New System.Drawing.Size(0, 25)
            label8.Size = size
            Me.lblSelectedTable.TabIndex = 75
            Me.btnReset.BackColor = System.Drawing.Color.Crimson
            Me.btnReset.FlatAppearance.BorderSize = 0
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.ForeColor = System.Drawing.Color.White
            Dim button3 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(791, 83)
            button3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button4 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(106, 45)
            button4.Size = size
            Me.btnReset.TabIndex = 399
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
            Me.cmbTicketNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTicketNo.Enabled = False
            Me.cmbTicketNo.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbTicketNo.FormattingEnabled = True
            Dim comboBox5 As System.Windows.Forms.ComboBox = Me.cmbTicketNo
            location = New System.Drawing.Point(188, 83)
            comboBox5.Location = location
            Me.cmbTicketNo.Name = "cmbTicketNo"
            Dim comboBox6 As System.Windows.Forms.ComboBox = Me.cmbTicketNo
            size = New System.Drawing.Size(170, 45)
            comboBox6.Size = size
            Me.cmbTicketNo.TabIndex = 400
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label9 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(188, 55)
            label9.Location = location
            Me.Label2.Name = "Label2"
            Dim label10 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(109, 25)
            label10.Size = size
            Me.Label2.TabIndex = 401
            Me.Label2.Text = "Ticket No. :"
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.DataGridView1.ColumnHeadersHeight = 24
            Me.DataGridView1.Columns.AddRange(Me.Column1, Me.Rate, Me.Qty, Me.Amount, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.VATPer, Me.VAT, Me.Column17, Me.Column18, Me.TotalAmount, Me.Column13, Me.Column30, Me.Column31, Me.Column37)
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            location = New System.Drawing.Point(5, 134)
            dataGridView.Location = location
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowHeadersVisible = False
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.DataGridView1.RowTemplate.Height = 45
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(353, 518)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 402
            Me.Column1.HeaderText = "Item Name"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Width = 140
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Rate.DefaultCellStyle = dataGridViewCellStyle6
            Me.Rate.HeaderText = "Rate"
            Me.Rate.Name = "Rate"
            Me.Rate.[ReadOnly] = True
            Me.Rate.Width = 70
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Qty.DefaultCellStyle = dataGridViewCellStyle7
            Me.Qty.HeaderText = "Qty."
            Me.Qty.Name = "Qty"
            Me.Qty.[ReadOnly] = True
            Me.Qty.Width = 50
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Amount.DefaultCellStyle = dataGridViewCellStyle8
            Me.Amount.HeaderText = "Amount"
            Me.Amount.Name = "Amount"
            Me.Amount.[ReadOnly] = True
            Me.Amount.Visible = False
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column5.DefaultCellStyle = dataGridViewCellStyle9
            Me.Column5.HeaderText = "Discount %"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column5.Visible = False
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column6.DefaultCellStyle = dataGridViewCellStyle10
            Me.Column6.HeaderText = "Discount"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column6.Visible = False
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column7.DefaultCellStyle = dataGridViewCellStyle11
            Me.Column7.HeaderText = "ST %"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column7.Visible = False
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column8.DefaultCellStyle = dataGridViewCellStyle12
            Me.Column8.HeaderText = "ST Amount"
            Me.Column8.Name = "Column8"
            Me.Column8.[ReadOnly] = True
            Me.Column8.Visible = False
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.VATPer.DefaultCellStyle = dataGridViewCellStyle13
            Me.VATPer.HeaderText = "VAT %"
            Me.VATPer.Name = "VATPer"
            Me.VATPer.[ReadOnly] = True
            Me.VATPer.Visible = False
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.VAT.DefaultCellStyle = dataGridViewCellStyle14
            Me.VAT.HeaderText = "VAT Amt"
            Me.VAT.Name = "VAT"
            Me.VAT.[ReadOnly] = True
            Me.VAT.Visible = False
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column17.DefaultCellStyle = dataGridViewCellStyle15
            Me.Column17.HeaderText = "SC %"
            Me.Column17.Name = "Column17"
            Me.Column17.[ReadOnly] = True
            Me.Column17.Visible = False
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column18.DefaultCellStyle = dataGridViewCellStyle16
            Me.Column18.HeaderText = "SC Amount"
            Me.Column18.Name = "Column18"
            Me.Column18.[ReadOnly] = True
            Me.Column18.Visible = False
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.TotalAmount.DefaultCellStyle = dataGridViewCellStyle17
            Me.TotalAmount.HeaderText = "Total Amt."
            Me.TotalAmount.Name = "TotalAmount"
            Me.TotalAmount.[ReadOnly] = True
            Me.TotalAmount.Visible = False
            Me.Column13.HeaderText = "Notes"
            Me.Column13.Name = "Column13"
            Me.Column13.[ReadOnly] = True
            Me.Column13.Width = 90
            Me.Column30.HeaderText = "TempQty"
            Me.Column30.Name = "Column30"
            Me.Column30.[ReadOnly] = True
            Me.Column30.Visible = False
            Me.Column31.HeaderText = "Category"
            Me.Column31.Name = "Column31"
            Me.Column31.[ReadOnly] = True
            Me.Column31.Visible = False
            Me.Column37.HeaderText = "Dish Name Arabic"
            Me.Column37.Name = "Column37"
            Me.Column37.[ReadOnly] = True
            Me.Column37.Visible = False
            Me.DataGridView2.AllowUserToAddRows = False
            Me.DataGridView2.AllowUserToDeleteRows = False
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18
            Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
            Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19
            Me.DataGridView2.ColumnHeadersHeight = 24
            Me.DataGridView2.Columns.AddRange(Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18)
            Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.DefaultCellStyle = dataGridViewCellStyle20
            Me.DataGridView2.EnableHeadersVisualStyles = False
            Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Dim dataGridView3 As System.Windows.Forms.DataGridView = Me.DataGridView2
            location = New System.Drawing.Point(395, 134)
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
            dataGridViewCellStyle22.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle22
            Me.DataGridView2.RowTemplate.Height = 45
            Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView4 As System.Windows.Forms.DataGridView = Me.DataGridView2
            size = New System.Drawing.Size(355, 518)
            dataGridView4.Size = size
            Me.DataGridView2.TabIndex = 403
            Me.DataGridViewTextBoxColumn1.HeaderText = "Item Name"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn1.Width = 140
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle23
            Me.DataGridViewTextBoxColumn2.HeaderText = "Rate"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn2.Width = 70
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle24
            Me.DataGridViewTextBoxColumn3.HeaderText = "Qty."
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn3.Width = 50
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle25
            Me.DataGridViewTextBoxColumn4.HeaderText = "Amount"
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn4.Visible = False
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle26
            Me.DataGridViewTextBoxColumn5.HeaderText = "Discount %"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn5.Visible = False
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle27
            Me.DataGridViewTextBoxColumn6.HeaderText = "Discount"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn6.Visible = False
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle28
            Me.DataGridViewTextBoxColumn7.HeaderText = "ST %"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn7.Visible = False
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle29
            Me.DataGridViewTextBoxColumn8.HeaderText = "ST Amount"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn8.Visible = False
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle30
            Me.DataGridViewTextBoxColumn9.HeaderText = "VAT %"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn9.Visible = False
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle31
            Me.DataGridViewTextBoxColumn10.HeaderText = "VAT Amt"
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn10.Visible = False
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle32
            Me.DataGridViewTextBoxColumn11.HeaderText = "SC %"
            Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
            Me.DataGridViewTextBoxColumn11.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn11.Visible = False
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle33
            Me.DataGridViewTextBoxColumn12.HeaderText = "SC Amount"
            Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
            Me.DataGridViewTextBoxColumn12.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn12.Visible = False
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle34
            Me.DataGridViewTextBoxColumn13.HeaderText = "Total Amt."
            Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
            Me.DataGridViewTextBoxColumn13.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn13.Visible = False
            Me.DataGridViewTextBoxColumn14.HeaderText = "Notes"
            Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
            Me.DataGridViewTextBoxColumn14.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn14.Width = 90
            Me.DataGridViewTextBoxColumn15.HeaderText = "TempQty"
            Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
            Me.DataGridViewTextBoxColumn15.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn15.Visible = False
            Me.DataGridViewTextBoxColumn16.HeaderText = "Category"
            Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
            Me.DataGridViewTextBoxColumn16.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn16.Visible = False
            Me.DataGridViewTextBoxColumn17.HeaderText = "Dish Name Arabic"
            Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
            Me.DataGridViewTextBoxColumn17.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn17.Visible = False
            Me.DataGridViewTextBoxColumn18.HeaderText = "Item Status"
            Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
            Me.DataGridViewTextBoxColumn18.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn18.Visible = False
            Me.lblBalance1.AutoSize = True
            Me.lblBalance1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblBalance1.ForeColor = System.Drawing.Color.White
            Dim label11 As System.Windows.Forms.Label = Me.lblBalance1
            location = New System.Drawing.Point(96, 658)
            label11.Location = location
            Me.lblBalance1.Name = "lblBalance1"
            Dim label12 As System.Windows.Forms.Label = Me.lblBalance1
            size = New System.Drawing.Size(99, 25)
            label12.Size = size
            Me.lblBalance1.TabIndex = 404
            Me.lblBalance1.Text = "lblBalance"
            Me.lblBalance2.AutoSize = True
            Me.lblBalance2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblBalance2.ForeColor = System.Drawing.Color.White
            Dim label13 As System.Windows.Forms.Label = Me.lblBalance2
            location = New System.Drawing.Point(484, 658)
            label13.Location = location
            Me.lblBalance2.Name = "lblBalance2"
            Dim label14 As System.Windows.Forms.Label = Me.lblBalance2
            size = New System.Drawing.Size(99, 25)
            label14.Size = size
            Me.lblBalance2.TabIndex = 405
            Me.lblBalance2.Text = "lblBalance"
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button5 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(933, 2)
            button5.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button6 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 49)
            button6.Size = size
            Me.btnCancel.TabIndex = 61
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Dim label15 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(2, 658)
            label15.Location = location
            Me.Label3.Name = "Label3"
            Dim label16 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(88, 25)
            label16.Size = size
            Me.Label3.TabIndex = 406
            Me.Label3.Text = "Balance :"
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label6.ForeColor = System.Drawing.Color.White
            Dim label17 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(390, 658)
            label17.Location = location
            Me.Label6.Name = "Label6"
            Dim label18 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(88, 25)
            label18.Size = size
            Me.Label6.TabIndex = 407
            Me.Label6.Text = "Balance :"
            Dim textBox As System.Windows.Forms.TextBox = Me.txtTicketID
            location = New System.Drawing.Point(835, 233)
            textBox.Location = location
            Me.txtTicketID.Name = "txtTicketID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtTicketID
            size = New System.Drawing.Size(30, 20)
            textBox2.Size = size
            Me.txtTicketID.TabIndex = 454
            Me.txtTicketID.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(985, 689)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.txtTicketID)
            MyBase.Controls.Add(Me.Label6)
            MyBase.Controls.Add(Me.Label3)
            MyBase.Controls.Add(Me.lblBalance2)
            MyBase.Controls.Add(Me.lblBalance1)
            MyBase.Controls.Add(Me.DataGridView2)
            MyBase.Controls.Add(Me.DataGridView1)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.cmbTicketNo)
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.lblSelectedTable)
            MyBase.Controls.Add(Me.btnTableTransfer)
            MyBase.Controls.Add(Me.cmbTransferTo)
            MyBase.Controls.Add(Me.Label4)
            MyBase.Controls.Add(Me.cmbTranferFrom)
            MyBase.Controls.Add(Me.Label1)
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Label5)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmItemsTransfer"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Items Transfer"
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
