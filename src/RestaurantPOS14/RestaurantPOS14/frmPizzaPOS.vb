Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmPizzaPOS
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference)

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpPizzaSize")>
        Private _flpPizzaSize As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpPizza")>
        Private _flpPizza As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label32")>
        Private _Label32 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblPizzaSize")>
        Private _lblPizzaSize As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove")>
        Private _btnRemove As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblBalance")>
        Private _lblBalance As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label35")>
        Private _Label35 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView2")>
        Private _DataGridView2 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDone")>
        Private _btnDone As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblFinalBalance")>
        Private _lblFinalBalance As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnToppings")>
        Private _btnToppings As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblPizzaName")>
        Private _lblPizzaName As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove1")>
        Private _btnRemove1 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ToolTip1")>
        Private _ToolTip1 As System.Windows.Forms.ToolTip

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnFreeToppings")>
        Private _btnFreeToppings As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTaxType")>
        Private _txtTaxType As System.Windows.Forms.TextBox

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnModifiers")>
        Private _btnModifiers As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn34")>
        Private _DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn35")>
        Private _DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn36")>
        Private _DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn37")>
        Private _DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn38")>
        Private _DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn39")>
        Private _DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn42")>
        Private _DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn43")>
        Private _DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn44")>
        Private _DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        Private UserButtons As System.Collections.Generic.List(Of CButtonLib.CButton)

        Private Rate As Double

        Private DiscountPer As Double

        Private HST As Double

        Private Discount As Double

        Private HSTPer As Double

        Private Amount As Double

        Private TotalAmount As Double

        Private num1 As Double

        Private num2 As Double

        Private num3 As Double

        Private num4 As Double

        Private num5 As Double

        Private num6 As Double

        Private num7 As Double

        Private ItemName As String

        Private Topping As String

        Private Pizza As String

        Private PizzaSize As String

        Private Description As String

        Private ExtraTopping As String

        Private Modifier As String

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property flpPizzaSize As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpPizzaSize
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpPizzaSize = value
            End Set
        End Property

        Friend Overridable Property flpPizza As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpPizza
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpPizza = value
            End Set
        End Property

        Friend Overridable Property Label32 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label32
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label32 = value
            End Set
        End Property

        Friend Overridable Property lblPizzaSize As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblPizzaSize
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblPizzaSize = value
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
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.MouseClick, value2
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.MouseClick, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnRemove As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnRemove
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnRemove_Click
                If Me._btnRemove IsNot Nothing Then
                    RemoveHandler Me._btnRemove.Click, value2
                End If

                Me._btnRemove = value
                If Me._btnRemove IsNot Nothing Then
                    AddHandler Me._btnRemove.Click, value2
                End If
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

        Friend Overridable Property Label35 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label35
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label35 = value
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
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.DataGridView2_MouseClick
                If Me._DataGridView2 IsNot Nothing Then
                    RemoveHandler Me._DataGridView2.MouseClick, value2
                End If

                Me._DataGridView2 = value
                If Me._DataGridView2 IsNot Nothing Then
                    AddHandler Me._DataGridView2.MouseClick, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnDone As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDone
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnDone_Click
                If Me._btnDone IsNot Nothing Then
                    RemoveHandler Me._btnDone.Click, value2
                End If

                Me._btnDone = value
                If Me._btnDone IsNot Nothing Then
                    AddHandler Me._btnDone.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnAdd As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAdd
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnAdd_Click
                If Me._btnAdd IsNot Nothing Then
                    RemoveHandler Me._btnAdd.Click, value2
                End If

                Me._btnAdd = value
                If Me._btnAdd IsNot Nothing Then
                    AddHandler Me._btnAdd.Click, value2
                End If
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

        Friend Overridable Property lblFinalBalance As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblFinalBalance
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblFinalBalance = value
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

        Friend Overridable Property btnToppings As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnToppings
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnToppings_Click
                If Me._btnToppings IsNot Nothing Then
                    RemoveHandler Me._btnToppings.Click, value2
                End If

                Me._btnToppings = value
                If Me._btnToppings IsNot Nothing Then
                    AddHandler Me._btnToppings.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblPizzaName As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblPizzaName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblPizzaName = value
            End Set
        End Property

        Friend Overridable Property btnRemove1 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnRemove1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnRemove1_Click
                If Me._btnRemove1 IsNot Nothing Then
                    RemoveHandler Me._btnRemove1.Click, value2
                End If

                Me._btnRemove1 = value
                If Me._btnRemove1 IsNot Nothing Then
                    AddHandler Me._btnRemove1.Click, value2
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

        Friend Overridable Property ToolTip1 As System.Windows.Forms.ToolTip
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ToolTip1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolTip)
                Me._ToolTip1 = value
            End Set
        End Property

        Friend Overridable Property btnFreeToppings As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnFreeToppings
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnFreeToppings_Click
                If Me._btnFreeToppings IsNot Nothing Then
                    RemoveHandler Me._btnFreeToppings.Click, value2
                End If

                Me._btnFreeToppings = value
                If Me._btnFreeToppings IsNot Nothing Then
                    AddHandler Me._btnFreeToppings.Click, value2
                End If
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

        Friend Overridable Property btnModifiers As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnModifiers
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnModifiers_Click
                If Me._btnModifiers IsNot Nothing Then
                    RemoveHandler Me._btnModifiers.Click, value2
                End If

                Me._btnModifiers = value
                If Me._btnModifiers IsNot Nothing Then
                    AddHandler Me._btnModifiers.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn34
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn34 = value
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

        Friend Overridable Property DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn35
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn35 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn36
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn36 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn37
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn37 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn38
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn38 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn39
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn39 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn42
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn42 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn43
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn43 = value
            End Set
        End Property

        Friend Overridable Property DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridViewTextBoxColumn44
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._DataGridViewTextBoxColumn44 = value
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

        Public Sub New()
            Call RestaurantPOS14.frmPizzaPOS.__ENCAddToList(Me)
            Me.InitializeComponent()
            MyBase.Hide()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPizzaPOS.__ENCList
                If RestaurantPOS14.frmPizzaPOS.__ENCList.Count = RestaurantPOS14.frmPizzaPOS.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPizzaPOS.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPizzaPOS.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPizzaPOS.__ENCList(num) = RestaurantPOS14.frmPizzaPOS.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPizzaPOS.__ENCList.RemoveRange(num, RestaurantPOS14.frmPizzaPOS.__ENCList.Count - num)
                    RestaurantPOS14.frmPizzaPOS.__ENCList.Capacity = RestaurantPOS14.frmPizzaPOS.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPizzaPOS.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub FillPizzaSize()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(Size) from PizzaSize,PizzaMaster where PizzaSize.Size=PizzaMaster.PizzaSize order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpPizzaSize.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim cbutton As CButtonLib.CButton = New CButtonLib.CButton()
                    cbutton.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                    Dim crimson As System.Drawing.Color = System.Drawing.Color.Crimson
                    cbutton.ColorFillBlend = New CButtonLib.cBlendItems With {.iColor = New System.Drawing.Color(2) {crimson, crimson, crimson}, .iPoint = New Single(2) {0F, 0.5F, 1F}}
                    cbutton.Corners.All = 3
                    cbutton.Corners.LowerLeft = 3
                    cbutton.Corners.LowerRight = 3
                    cbutton.Corners.UpperLeft = 3
                    cbutton.Corners.UpperRight = 3
                    cbutton.TextShadowShow = False
                    cbutton.ForeColor = System.Drawing.Color.White
                    cbutton.Width = 130
                    cbutton.Height = 60
                    cbutton.UseMnemonic = False
                    cbutton.BackColor = System.Drawing.Color.Transparent
                    cbutton.BorderShow = False
                    cbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(cbutton)
                    Me.flpPizzaSize.Controls.Add(cbutton)
                    AddHandler cbutton.Click, AddressOf Me.btnSize_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub FillPizza()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(PizzaName) from PizzaMaster order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpPizza.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim cbutton As CButtonLib.CButton = New CButtonLib.CButton()
                    cbutton.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                    Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(102, 106, 105)
                    cbutton.ColorFillBlend = New CButtonLib.cBlendItems With {.iColor = New System.Drawing.Color(2) {color, color, color}, .iPoint = New Single(2) {0F, 0.5F, 1F}}
                    cbutton.Corners.All = 3
                    cbutton.Corners.LowerLeft = 3
                    cbutton.Corners.LowerRight = 3
                    cbutton.Corners.UpperLeft = 3
                    cbutton.Corners.UpperRight = 3
                    cbutton.TextShadowShow = False
                    cbutton.ForeColor = System.Drawing.Color.White
                    cbutton.Width = 130
                    cbutton.Height = 60
                    cbutton.UseMnemonic = False
                    cbutton.BackColor = System.Drawing.Color.Transparent
                    cbutton.BorderShow = False
                    cbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(cbutton)
                    Me.flpPizza.Controls.Add(cbutton)
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmPizzaPOS_Load(sender As Object, e As System.EventArgs)
            Me.FillPizzaSize()
            Me.FillPizza()
            Me.GetTaxType()
            Me.DisableHSBar()
        End Sub

        Public Sub DisableHSBar()
            Me.flpPizza.HorizontalScroll.Maximum = 0
            Me.flpPizza.AutoScroll = False
            Me.flpPizza.VerticalScroll.Visible = False
            Me.flpPizza.AutoScroll = True
            Me.flpPizzaSize.HorizontalScroll.Maximum = 0
            Me.flpPizzaSize.AutoScroll = False
            Me.flpPizzaSize.VerticalScroll.Visible = False
            Me.flpPizzaSize.AutoScroll = True
        End Sub

        Private Sub btnSize_Click(sender As Object, e As System.EventArgs)
            Try
                Dim text As String = CType(sender, CButtonLib.CButton).Text.Trim()
                Me.lblPizzaSize.Text = text
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(PizzaName),BackColor from PizzaMaster where PizzaSize=@d1 order by 1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpPizza.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim cbutton As CButtonLib.CButton = New CButtonLib.CButton()
                    cbutton.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                    Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(1))))))
                    cbutton.ColorFillBlend = New CButtonLib.cBlendItems With {.iColor = New System.Drawing.Color(2) {color, color, color}, .iPoint = New Single(2) {0F, 0.5F, 1F}}
                    cbutton.Corners.All = 3
                    cbutton.Corners.LowerLeft = 3
                    cbutton.Corners.LowerRight = 3
                    cbutton.Corners.UpperLeft = 3
                    cbutton.Corners.UpperRight = 3
                    cbutton.TextShadowShow = False
                    cbutton.ForeColor = System.Drawing.Color.White
                    cbutton.Width = 130
                    cbutton.Height = 60
                    cbutton.UseMnemonic = False
                    cbutton.BackColor = System.Drawing.Color.Transparent
                    cbutton.BorderShow = False
                    cbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(cbutton)
                    Me.flpPizza.Controls.Add(cbutton)
                    AddHandler cbutton.Click, AddressOf Me.btnPizza_Click
                    AddHandler cbutton.Click, AddressOf Me.btnPizza_MouseHover
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnPizza_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblPizzaSize.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select pizza size", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                For Each item As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(item.Cells(CInt((10))).Value, "Pizza", TextCompare:=False) Then
                        Call System.Windows.Forms.MessageBox.Show("Pizza is already added", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                        Return
                    End If
                Next

                Dim text As String = CType(sender, CButtonLib.CButton).Text
                Me.lblPizzaName.Text = text
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Rate,Discount FROM PizzaMaster WHERE PizzaName=@d1 and PizzaSize=@d2"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblPizzaSize.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Rate = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.DiscountPer = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT VAT FROM Category WHERE CategoryName='ZZ_DISABLED_PIZZA'"
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.HSTPer = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.HSTPer = 0.0
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select distinct RTRIM(ModifierName) from PizzaModifier,PizzaMaster where PizzaMaster.Pizza_ID=PizzaModifier.PizzaID and PizzaName=@d1 and PizzaSize=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblPizzaSize.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Compute()
                    Me.DataGridView1.Rows.Add(text, Me.lblPizzaSize.Text, Me.Rate, 1, Me.Amount, Me.DiscountPer, Me.Discount, Me.HSTPer, Me.HST, Me.TotalAmount, "Pizza")
                    Dim value As Double = Me.GrandTotal_Food()
                    value = System.Math.Round(value, 2)
                    Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                    RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiersList_AutoPopUp.txtPizzaName.Text = text
                    RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiersList_AutoPopUp.txtPizzaSize.Text = Me.lblPizzaSize.Text
                    Call RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiersList_AutoPopUp.Reset()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiersList_AutoPopUp.ShowDialog()
                Else
                    Me.Compute()
                    Me.DataGridView1.Rows.Add(text, Me.lblPizzaSize.Text, Me.Rate, 1, Me.Amount, Me.DiscountPer, Me.Discount, Me.HSTPer, Me.HST, Me.TotalAmount, "Pizza")
                    Dim value2 As Double = Me.GrandTotal_Food()
                    value2 = System.Math.Round(value2, 2)
                    Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Function GrandTotal_Food() As Double
            Dim num As Double = 0.0
            Try
                If Me.DataGridView1.Rows.Count > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                        num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((9))).Value))
                    Next
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Public Function FinalGrandTotal() As Double
            Dim num As Double = 0.0
            Try
                If Me.DataGridView2.Rows.Count > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                        num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((9))).Value))
                    Next
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

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

        Public Sub Compute()
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTaxType.Text, "Inclusive", TextCompare:=False) = 0 Then
                    Me.num1 = Me.Rate
                    Me.num1 = System.Math.Round(Me.num1, 2)
                    Me.Amount = Me.num1
                    Me.num2 = Me.num1 * Me.DiscountPer / 100.0
                    Me.num2 = System.Math.Round(Me.num2, 2)
                    Me.Discount = Me.num2
                    Me.num3 = Me.Amount - Me.Discount
                    Me.num3 = System.Math.Round(Me.num3, 2)
                    Me.num4 = Me.num3 - Me.num3 / (1.0 + Microsoft.VisualBasic.Conversion.Val(Me.HSTPer) / 100.0)
                    Me.num4 = System.Math.Round(Me.num4, 2)
                    Me.HST = Me.num4
                    Me.num6 = Me.num3
                    Me.num6 = System.Math.Round(Me.num6, 2)
                    Me.TotalAmount = Me.num6
                Else
                    Me.num1 = Me.Rate
                    Me.num1 = System.Math.Round(Me.num1, 2)
                    Me.Amount = Me.num1
                    Me.num2 = Me.num1 * Me.DiscountPer / 100.0
                    Me.num2 = System.Math.Round(Me.num2, 2)
                    Me.Discount = Me.num2
                    Me.num3 = Me.Amount - Me.Discount
                    Me.num3 = System.Math.Round(Me.num3, 2)
                    Me.num4 = Me.num3 * Me.HSTPer / 100.0
                    Me.num4 = System.Math.Round(Me.num4, 2)
                    Me.HST = Me.num4
                    Me.num6 = Me.num3 + Me.num4
                    Me.num6 = System.Math.Round(Me.num6, 2)
                    Me.TotalAmount = Me.num6
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnToppings_Click(sender As Object, e As System.EventArgs)
            If Me.DataGridView1.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Add pizza first", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblPizzaSize.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select pizza size", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select ToppingSize from PizzaTopping where PizzaSize=@d1")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblPizzaSize.Text)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                Call System.Windows.Forms.MessageBox.Show("Sorry no topping avaialble for selected size Pizza", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If
            Else
                Call RestaurantPOS14.My.MyProject.Forms.frmToppingsList.Reset()
                RestaurantPOS14.My.MyProject.Forms.frmToppingsList.lblPizzaSize.Text = Me.lblPizzaSize.Text
                Call RestaurantPOS14.My.MyProject.Forms.frmToppingsList.ShowDialog()
            End If
        End Sub

        Private Sub btnRemove_Click(sender As Object, e As System.EventArgs)
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.DataGridView1.SelectedRows
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((10))).Value, "Pizza", TextCompare:=False) Then
                        If System.Windows.Forms.MessageBox.Show("Do you really want to remove the pizza?" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "It will also remove all added toppings and modifiers.", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
                            Me.DataGridView1.Rows.Clear()
                            Me.lblBalance.Text = "0.00"
                            Me.lblPizzaSize.Text = ""
                            Me.lblPizzaName.Text = ""
                        End If

                        Return
                    End If

                    Me.DataGridView1.Rows.Remove(dataGridViewRow)
                Next

                Dim value As Double = Me.GrandTotal_Food()
                value = System.Math.Round(value, 2)
                Me.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                Me.btnRemove.Enabled = False
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Me.DataGridView1.Rows.Count > 0 Then
                Me.btnRemove.Enabled = True
            End If
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.DataGridView1.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry,No pizza added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((10))).Value, "Topping", TextCompare:=False) Then
                        Me.Topping = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.Topping & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((dataGridViewRow.Cells(CInt((0))).Value))))), CObj((" "))))), CObj(("("))))), CObj((dataGridViewRow.Cells(CInt((1))).Value))))), CObj((")"))).ToString().Trim()
                    End If
                Next

                For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells(CInt((10))).Value, "Extra Topping", TextCompare:=False) Then
                        Me.ExtraTopping = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.ExtraTopping & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((dataGridViewRow2.Cells(CInt((0))).Value))))), CObj((" "))))), CObj(("("))))), CObj((dataGridViewRow2.Cells(CInt((1))).Value))))), CObj((")"))).ToString().Trim()
                    End If
                Next

                For Each dataGridViewRow3 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells(CInt((10))).Value, "Modifier", TextCompare:=False) Then
                        Me.Modifier = Me.Modifier & Global.Microsoft.VisualBasic.Constants.vbCrLf & dataGridViewRow3.Cells(CInt((0))).Value.ToString().Trim()
                    End If
                Next

                Dim obj4 As Object =(If((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Topping, "", TextCompare:=False) = 0), "".ToString().Trim(), "Toppings :"))
                Dim obj5 As Object =(If((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.ExtraTopping, "", TextCompare:=False) = 0), "".ToString().Trim(), "Extra Toppings :"))
                Dim obj6 As Object =(If((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.Modifier, "", TextCompare:=False) = 0), "".ToString().Trim(), "Modifiers :"))
                Me.Pizza = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Me.DataGridView1.Rows(CInt((0))).Cells(CInt((0))).Value, " "), "("), Me.DataGridView1.Rows(CInt((0))).Cells(CInt((1))).Value), ")"))
                If Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj4, "", TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj5, "", TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj6, "", TextCompare:=False))) Then
                    Me.ItemName = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.Pizza & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((obj4))))), CObj((Me.Topping))))), CObj((Global.Microsoft.VisualBasic.Constants.vbCrLf))))), CObj((obj5))))), CObj((Me.ExtraTopping))))), CObj((Global.Microsoft.VisualBasic.Constants.vbCrLf))))), CObj((obj6))))), CObj((Me.Modifier))).ToString().Trim()
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj4, "", TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj5, "", TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj6, "", TextCompare:=False))) Then
                    Me.ItemName = Me.Pizza.ToString().Trim()
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj4, "", TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj5, "", TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj6, "", TextCompare:=False))) Then
                    Me.ItemName = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.Pizza & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((obj4))))), CObj((Me.Topping))).ToString().Trim()
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj4, "", TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj5, "", TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj6, "", TextCompare:=False))) Then
                    Me.ItemName = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.Pizza & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((obj4))))), CObj((Me.Topping))))), CObj((Global.Microsoft.VisualBasic.Constants.vbCrLf))))), CObj((obj6))))), CObj((Me.Modifier))).ToString().Trim()
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj4, "", TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj5, "", TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj6, "", TextCompare:=False))) Then
                    Me.ItemName = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.Pizza & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((obj4))))), CObj((Me.Topping))))), CObj((Global.Microsoft.VisualBasic.Constants.vbCrLf))))), CObj((obj5))))), CObj((Me.ExtraTopping))).ToString().Trim()
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj4, "", TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj5, "", TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj6, "", TextCompare:=False))) Then
                    Me.ItemName = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.Pizza & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((obj6))))), CObj((Me.Modifier))).ToString().Trim()
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj4, "", TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj5, "", TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj6, "", TextCompare:=False))) Then
                    Me.ItemName = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.Pizza & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((obj5))))), CObj((Me.ExtraTopping))).ToString().Trim()
                ElseIf Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(obj4, "", TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj5, "", TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(obj6, "", TextCompare:=False))) Then
                    Me.ItemName = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.Pizza & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((obj5))))), CObj((Me.ExtraTopping))))), CObj((Global.Microsoft.VisualBasic.Constants.vbCrLf))))), CObj((obj6))))), CObj((Me.Modifier))).ToString().Trim()
                End If

                Me.PizzaSize = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Me.DataGridView1.Rows(CInt((0))).Cells(CInt((1))).Value)
                Me.num1 = Me.PizzaRate()
                Me.num1 = System.Math.Round(Me.num1, 2)
                Me.Rate = Me.num1
                Me.Amount = Me.num1
                Me.DiscountPer = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.DataGridView1.Rows(CInt((0))).Cells(CInt((5))).Value)
                Me.num2 = Me.PizzaDiscount()
                Me.num2 = System.Math.Round(Me.num2, 2)
                Me.Discount = Me.num2
                Me.HSTPer = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.DataGridView1.Rows(CInt((0))).Cells(CInt((7))).Value)
                Me.num3 = Me.PizzaHST()
                Me.num3 = System.Math.Round(Me.num3, 2)
                Me.HST = Me.num3
                Me.TotalAmount = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Me.lblBalance.Text)
                Me.DataGridView2.Rows.Add(Me.ItemName, Me.PizzaSize, Me.Rate, 1, Me.Amount, Me.DiscountPer, Me.Discount, Me.HSTPer, Me.HST, Me.TotalAmount, "")
                Dim value As Double = Me.FinalGrandTotal()
                value = System.Math.Round(value, 2)
                Me.lblFinalBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                Me.DataGridView1.Rows.Clear()
                Me.lblBalance.Text = "0.00"
                Me.lblPizzaSize.Text = ""
                Me.lblPizzaName.Text = ""
                Me.Topping = ""
                Me.ExtraTopping = ""
                Me.Modifier = ""
                Me.ItemName = ""
                Me.Pizza = ""
                Me.PizzaSize = ""
                Me.btnRemove.Enabled = False
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Function PizzaRate() As Double
            Dim num As Double = 0.0
            Try
                If Me.DataGridView1.Rows.Count > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                        num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((2))).Value))
                    Next
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Public Function PizzaDiscount() As Double
            Dim num As Double = 0.0
            Try
                If Me.DataGridView1.Rows.Count > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                        num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((6))).Value))
                    Next
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Public Function PizzaHST() As Double
            Dim num As Double = 0.0
            Try
                If Me.DataGridView1.Rows.Count > 0 Then
                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                        num = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num, dataGridViewRow.Cells(CInt((8))).Value))
                    Next
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.Message)
            End Try

            Return num
        End Function

        Public Sub Reset()
            Me.DataGridView1.Rows.Clear()
            Me.lblBalance.Text = "0.00"
            Me.lblPizzaSize.Text = ""
            Me.lblPizzaName.Text = ""
            Me.Topping = ""
            Me.ItemName = ""
            Me.Pizza = ""
            Me.PizzaSize = ""
            Me.DataGridView2.Rows.Clear()
            Me.lblFinalBalance.Text = "0.00"
            Me.btnRemove.Enabled = False
            Me.btnRemove1.Enabled = False
            Me.FillPizzaSize()
            Me.FillPizza()
            Me.GetTaxType()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnRemove1_Click(sender As Object, e As System.EventArgs)
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.DataGridView2.SelectedRows
                    Me.DataGridView2.Rows.Remove(dataGridViewRow)
                Next

                Dim value As Double = Me.FinalGrandTotal()
                value = System.Math.Round(value, 2)
                Me.lblFinalBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                Me.btnRemove1.Enabled = False
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DataGridView2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Me.DataGridView2.Rows.Count > 0 Then
                Me.btnRemove1.Enabled = True
                If Me.DataGridView2.SelectedRows.Count = 0 Then Return
                Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.DataGridView2.SelectedRows(0)
                RestaurantPOS14.My.MyProject.Forms.frmNotes.txtNotes.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((10))).Value)
                RestaurantPOS14.My.MyProject.Forms.frmNotes.lblSet.Text = "PizzaPOS"
                Call RestaurantPOS14.My.MyProject.Forms.frmNotes.ShowDialog()
            End If
        End Sub

        Private Sub btnDone_Click(sender As Object, e As System.EventArgs)
            If Me.DataGridView2.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Add pizza first", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "KOT", TextCompare:=False) = 0 Then
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                    Dim text As String =(If((Not Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((10))).Value, "", TextCompare:=False)), dataGridViewRow.Cells(CInt((10))).Value.ToString().Trim(), ""))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)), 1, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((5))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((6))).Value)), 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((7))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((8))).Value)), 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((9))).Value)), text, 0, "Pizza", "", "New")
                    Dim value As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food()
                    value = System.Math.Round(value, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((0))).Value))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((9))).Value))), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location As System.Drawing.Point = screen.Bounds.Location
                        Dim p As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj.Location = location + CType(p, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.AddItem(dataGridViewRow.Cells(CInt((0))).Value.ToString(), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)), 1, 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((9))).Value)))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H1()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If
                Next

                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                Me.lblSet.Text = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                For Each dataGridViewRow2 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                    Dim text2 As String =(If((Not Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow2.Cells(CInt((10))).Value, "", TextCompare:=False)), dataGridViewRow2.Cells(CInt((10))).Value.ToString().Trim(), ""))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((0))).Value), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((2))).Value)), 1, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((4))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((5))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((6))).Value)), 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((7))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((8))).Value)), 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((9))).Value)), text2, 0, "Pizza", "")
                    Dim value2 As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food3()
                    value2 = System.Math.Round(value2, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Calc2()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow2.Cells(CInt((0))).Value))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((9))).Value))), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen2 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj2 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location2 As System.Drawing.Point = screen2.Bounds.Location
                        Dim p2 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj2.Location = location2 + CType(p2, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.AddItem(dataGridViewRow2.Cells(CInt((0))).Value.ToString(), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((2))).Value)), 1, 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((9))).Value)))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H3()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If
                Next

                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                Me.lblSet.Text = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                For Each dataGridViewRow3 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                    Dim text3 As String =(If((Not Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow3.Cells(CInt((10))).Value, "", TextCompare:=False)), dataGridViewRow3.Cells(CInt((10))).Value.ToString().Trim(), ""))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((0))).Value), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((2))).Value)), 1, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((4))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((5))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((6))).Value)), 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((7))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((8))).Value)), 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((9))).Value)), text3, 0, "Pizza", "")
                    Dim value3 As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food2()
                    value3 = System.Math.Round(value3, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value3)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSubTotal1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Calc1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow3.Cells(CInt((0))).Value))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((9))).Value))), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen3 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj3 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location3 As System.Drawing.Point = screen3.Bounds.Location
                        Dim p3 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj3.Location = location3 + CType(p3, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.AddItem(dataGridViewRow3.Cells(CInt((0))).Value.ToString(), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((2))).Value)), 1, 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow3.Cells(CInt((9))).Value)))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H2()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If
                Next

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.fillCurrencyTA()
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                Me.lblSet.Text = ""
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) <> 0 Then
                Return
            End If

            For Each dataGridViewRow4 As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView2.Rows, System.Collections.IEnumerable)
                Dim text4 As String =(If((Not Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow4.Cells(CInt((10))).Value, "", TextCompare:=False)), dataGridViewRow4.Cells(CInt((10))).Value.ToString().Trim(), ""))
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((0))).Value), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((2))).Value)), 1, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((4))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((5))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((6))).Value)), 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((7))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((8))).Value)), 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((9))).Value)), text4, 0, "Pizza", "")
                Dim value4 As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food4()
                value4 = System.Math.Round(value4, 2)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value4)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text))
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Calc3()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow4.Cells(CInt((0))).Value))
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((9))).Value))), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text)))
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                    Dim screen4 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                    RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                    Dim obj4 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                    Dim location4 As System.Drawing.Point = screen4.Bounds.Location
                    Dim p4 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                    obj4.Location = location4 + CType(p4, System.Drawing.Size)
                    Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.AddItem(dataGridViewRow4.Cells(CInt((0))).Value.ToString(), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((2))).Value)), 1, 0, 0, Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((9))).Value)))
                    RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text))
                    RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H4()))
                    RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                    Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                End If
            Next

            Call RestaurantPOS14.My.MyProject.Forms.frmPOS.fillCurrencyEB()
            MyBase.Hide()
            Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
            Me.lblSet.Text = ""
        End Sub

        Private Sub btnPizza_MouseHover(sender As Object, e As System.EventArgs)
            Dim cbutton As CButtonLib.CButton = CType(sender, CButtonLib.CButton)
            Dim text As String = cbutton.Text
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(Description) from PizzaMaster where PizzaName=@d1 and PizzaSize=@d2 order by 1")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblPizzaSize.Text)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            Me.Description = ""
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            If RestaurantPOS14.ModClasses.rdr.Read() Then
                Me.Description = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
            Else
                Me.Description = ""
            End If

            RestaurantPOS14.ModClasses.con.Close()
            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.UseAnimation = True
            Me.ToolTip1.ToolTipTitle = ""
            Me.ToolTip1.SetToolTip(cbutton, Me.Description)
        End Sub

        Private Sub btnFreeToppings_Click(sender As Object, e As System.EventArgs)
            If Me.DataGridView1.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Add pizza first", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblPizzaSize.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select pizza size", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select ToppingSize from PizzaTopping where PizzaSize=@d1")
            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblPizzaSize.Text)
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                Call System.Windows.Forms.MessageBox.Show("Sorry no topping avaialble for selected size Pizza", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If
            Else
                Call RestaurantPOS14.My.MyProject.Forms.frmToppingsList1.Reset()
                RestaurantPOS14.My.MyProject.Forms.frmToppingsList1.lblPizzaSize.Text = Me.lblPizzaSize.Text
                Call RestaurantPOS14.My.MyProject.Forms.frmToppingsList1.ShowDialog()
            End If
        End Sub

        Private Sub btnModifiers_Click(sender As Object, e As System.EventArgs)
            If Me.DataGridView1.Rows.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Add pizza first", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblPizzaSize.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select pizza size", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            Try
                If Me.DataGridView1.Rows.Count <= 0 Then
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((10))).Value.ToString(), "Pizza", TextCompare:=False) = 0 Then
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select distinct RTRIM(ModifierName) from PizzaModifier,PizzaMaster where PizzaMaster.Pizza_ID=PizzaModifier.PizzaID and PizzaName=@d1 and PizzaSize=@d2")
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", dataGridViewRow.Cells(CInt((0))).Value.ToString())
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow.Cells(CInt((1))).Value.ToString())
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                            Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog20.ShowDialog()
                            Exit For
                        End If

                        RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiersList.txtPizzaName.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiersList.txtPizzaSize.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                        Call RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiersList.Reset()
                        Call RestaurantPOS14.My.MyProject.Forms.frmPizzaModifiersList.ShowDialog()
                    End If
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Shared Sub New()
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
            Dim cBlendItems As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
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
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems7 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems8 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPizzaPOS))
            Me.flpPizzaSize = New System.Windows.Forms.FlowLayoutPanel()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.flpPizza = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.lblPizzaSize = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnRemove = New CButtonLib.CButton()
            Me.lblBalance = New System.Windows.Forms.Label()
            Me.Label35 = New System.Windows.Forms.Label()
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
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnDone = New CButtonLib.CButton()
            Me.btnAdd = New CButtonLib.CButton()
            Me.btnReset = New CButtonLib.CButton()
            Me.lblFinalBalance = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnToppings = New CButtonLib.CButton()
            Me.lblPizzaName = New System.Windows.Forms.Label()
            Me.btnRemove1 = New CButtonLib.CButton()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.btnFreeToppings = New CButtonLib.CButton()
            Me.txtTaxType = New System.Windows.Forms.TextBox()
            Me.btnModifiers = New CButtonLib.CButton()
            Me.flpPizzaSize.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.flpPizzaSize.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.flpPizzaSize.AutoScroll = True
            Me.flpPizzaSize.Controls.Add(Me.lblSet)
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpPizzaSize
            Dim location As System.Drawing.Point = New System.Drawing.Point(516, 1)
            flowLayoutPanel.Location = location
            Me.flpPizzaSize.Name = "flpPizzaSize"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpPizzaSize
            Dim size As System.Drawing.Size = New System.Drawing.Size(145, 628)
            flowLayoutPanel2.Size = size
            Me.flpPizzaSize.TabIndex = 0
            Me.lblSet.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(3, 0)
            label.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label2.Size = size
            Me.lblSet.TabIndex = 417
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.flpPizza.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpPizza.AutoScroll = True
            Dim flowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel = Me.flpPizza
            location = New System.Drawing.Point(667, 1)
            flowLayoutPanel3.Location = location
            Me.flpPizza.Name = "flpPizza"
            Dim flowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel = Me.flpPizza
            size = New System.Drawing.Size(332, 628)
            flowLayoutPanel4.Size = size
            Me.flpPizza.TabIndex = 1
            Me.Label32.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label32.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label32
            location = New System.Drawing.Point(12, 9)
            label3.Location = location
            Me.Label32.Name = "Label32"
            Dim label4 As System.Windows.Forms.Label = Me.Label32
            size = New System.Drawing.Size(88, 20)
            label4.Size = size
            Me.Label32.TabIndex = 388
            Me.Label32.Text = "Pizza Size : "
            Me.lblPizzaSize.AutoSize = True
            Me.lblPizzaSize.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblPizzaSize.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.lblPizzaSize
            location = New System.Drawing.Point(98, 8)
            label5.Location = location
            Me.lblPizzaSize.Name = "lblPizzaSize"
            Dim label6 As System.Windows.Forms.Label = Me.lblPizzaSize
            size = New System.Drawing.Size(0, 21)
            label6.Size = size
            Me.lblPizzaSize.TabIndex = 389
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
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
            Me.DataGridView1.Columns.AddRange(Me.DataGridViewTextBoxColumn34, Me.Column2, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.Column1)
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            location = New System.Drawing.Point(134, 60)
            dataGridView.Location = location
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowHeadersVisible = False
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.DataGridView1.RowTemplate.Height = 45
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(372, 345)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 394
            Me.DataGridViewTextBoxColumn34.HeaderText = "Item Name"
            Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
            Me.DataGridViewTextBoxColumn34.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn34.Width = 150
            Me.Column2.HeaderText = "Size"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Width = 115
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn35.DefaultCellStyle = dataGridViewCellStyle6
            Me.DataGridViewTextBoxColumn35.HeaderText = "Rate"
            Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
            Me.DataGridViewTextBoxColumn35.[ReadOnly] = True
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn36.DefaultCellStyle = dataGridViewCellStyle7
            Me.DataGridViewTextBoxColumn36.HeaderText = "Qty."
            Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
            Me.DataGridViewTextBoxColumn36.[ReadOnly] = True
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn37.DefaultCellStyle = dataGridViewCellStyle8
            Me.DataGridViewTextBoxColumn37.HeaderText = "Amount"
            Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
            Me.DataGridViewTextBoxColumn37.[ReadOnly] = True
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn38.DefaultCellStyle = dataGridViewCellStyle9
            Me.DataGridViewTextBoxColumn38.HeaderText = "Discount %"
            Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
            Me.DataGridViewTextBoxColumn38.[ReadOnly] = True
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn39.DefaultCellStyle = dataGridViewCellStyle10
            Me.DataGridViewTextBoxColumn39.HeaderText = "Discount"
            Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
            Me.DataGridViewTextBoxColumn39.[ReadOnly] = True
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn42.DefaultCellStyle = dataGridViewCellStyle11
            Me.DataGridViewTextBoxColumn42.HeaderText = "HST %"
            Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
            Me.DataGridViewTextBoxColumn42.[ReadOnly] = True
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn43.DefaultCellStyle = dataGridViewCellStyle12
            Me.DataGridViewTextBoxColumn43.HeaderText = "HST Amt"
            Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
            Me.DataGridViewTextBoxColumn43.[ReadOnly] = True
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn44.DefaultCellStyle = dataGridViewCellStyle13
            Me.DataGridViewTextBoxColumn44.HeaderText = "Total Amt."
            Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
            Me.DataGridViewTextBoxColumn44.[ReadOnly] = True
            Me.Column1.HeaderText = "Item Type"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.btnRemove.BackColor = System.Drawing.Color.Transparent
            Me.btnRemove.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnRemove.ColorFillBlend = cBlendItems
            Me.btnRemove.Corners.All = 3
            Me.btnRemove.Corners.LowerLeft = 3
            Me.btnRemove.Corners.LowerRight = 3
            Me.btnRemove.Corners.UpperLeft = 3
            Me.btnRemove.Corners.UpperRight = 3
            Me.btnRemove.DesignerSelected = False
            Me.btnRemove.Enabled = False
            Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnRemove.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnRemove
            location = New System.Drawing.Point(12, 225)
            cButton.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim cButton2 As CButtonLib.CButton = Me.btnRemove
            size = New System.Drawing.Size(116, 47)
            cButton2.Size = size
            Me.btnRemove.TabIndex = 405
            Me.btnRemove.Text = "Remove"
            Me.btnRemove.TextShadowShow = False
            Me.btnRemove.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.lblBalance.AutoSize = True
            Me.lblBalance.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblBalance.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.lblBalance
            location = New System.Drawing.Point(219, 408)
            label7.Location = location
            Me.lblBalance.Name = "lblBalance"
            Dim label8 As System.Windows.Forms.Label = Me.lblBalance
            size = New System.Drawing.Size(41, 21)
            label8.Size = size
            Me.lblBalance.TabIndex = 407
            Me.lblBalance.Text = "0.00"
            Me.Label35.AutoSize = True
            Me.Label35.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label35.ForeColor = System.Drawing.Color.White
            Dim label9 As System.Windows.Forms.Label = Me.Label35
            location = New System.Drawing.Point(134, 408)
            label9.Location = location
            Me.Label35.Name = "Label35"
            Dim label10 As System.Windows.Forms.Label = Me.Label35
            size = New System.Drawing.Size(78, 21)
            label10.Size = size
            Me.Label35.TabIndex = 406
            Me.Label35.Text = "Balance : "
            Me.DataGridView2.AllowUserToAddRows = False
            Me.DataGridView2.AllowUserToDeleteRows = False
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14
            Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15
            Me.DataGridView2.ColumnHeadersHeight = 24
            Me.DataGridView2.Columns.AddRange(Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.Column3)
            Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.DefaultCellStyle = dataGridViewCellStyle16
            Me.DataGridView2.EnableHeadersVisualStyles = False
            Me.DataGridView2.GridColor = System.Drawing.Color.White
            Dim dataGridView3 As System.Windows.Forms.DataGridView = Me.DataGridView2
            location = New System.Drawing.Point(138, 431)
            dataGridView3.Location = location
            Me.DataGridView2.MultiSelect = False
            Me.DataGridView2.Name = "DataGridView2"
            Me.DataGridView2.[ReadOnly] = True
            Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle17
            Me.DataGridView2.RowHeadersVisible = False
            Me.DataGridView2.RowHeadersWidth = 25
            Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle18.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightGray
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle18
            Me.DataGridView2.RowTemplate.Height = 45
            Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView4 As System.Windows.Forms.DataGridView = Me.DataGridView2
            size = New System.Drawing.Size(372, 175)
            dataGridView4.Size = size
            Me.DataGridView2.TabIndex = 408
            Me.DataGridViewTextBoxColumn1.HeaderText = "Item Name"
            Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
            Me.DataGridViewTextBoxColumn1.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn1.Width = 120
            Me.DataGridViewTextBoxColumn2.HeaderText = "Size"
            Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
            Me.DataGridViewTextBoxColumn2.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn2.Width = 80
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle19
            Me.DataGridViewTextBoxColumn3.HeaderText = "Rate"
            Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
            Me.DataGridViewTextBoxColumn3.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn3.Width = 85
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle20
            Me.DataGridViewTextBoxColumn4.HeaderText = "Qty."
            Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
            Me.DataGridViewTextBoxColumn4.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn4.Visible = False
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle21
            Me.DataGridViewTextBoxColumn5.HeaderText = "Amount"
            Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
            Me.DataGridViewTextBoxColumn5.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn5.Visible = False
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle22
            Me.DataGridViewTextBoxColumn6.HeaderText = "Discount %"
            Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
            Me.DataGridViewTextBoxColumn6.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn6.Visible = False
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle23
            Me.DataGridViewTextBoxColumn7.HeaderText = "Discount"
            Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
            Me.DataGridViewTextBoxColumn7.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn7.Visible = False
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle24
            Me.DataGridViewTextBoxColumn8.HeaderText = "HST %"
            Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
            Me.DataGridViewTextBoxColumn8.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn8.Visible = False
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle25
            Me.DataGridViewTextBoxColumn9.HeaderText = "HST Amt"
            Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
            Me.DataGridViewTextBoxColumn9.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn9.Visible = False
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle26
            Me.DataGridViewTextBoxColumn10.HeaderText = "Total Amt."
            Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
            Me.DataGridViewTextBoxColumn10.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn10.Visible = False
            Me.Column3.HeaderText = "Notes"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.btnDone.BackColor = System.Drawing.Color.Transparent
            Me.btnDone.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnDone.ColorFillBlend = cBlendItems2
            Me.btnDone.Corners.All = 3
            Me.btnDone.Corners.LowerLeft = 3
            Me.btnDone.Corners.LowerRight = 3
            Me.btnDone.Corners.UpperLeft = 3
            Me.btnDone.Corners.UpperRight = 3
            Me.btnDone.DesignerSelected = False
            Me.btnDone.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnDone.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnDone
            location = New System.Drawing.Point(19, 537)
            cButton3.Location = location
            Me.btnDone.Name = "btnDone"
            Dim cButton4 As CButtonLib.CButton = Me.btnDone
            size = New System.Drawing.Size(116, 47)
            cButton4.Size = size
            Me.btnDone.TabIndex = 411
            Me.btnDone.Text = "Done"
            Me.btnDone.TextShadowShow = False
            Me.btnDone.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnAdd.BackColor = System.Drawing.Color.Transparent
            Me.btnAdd.BorderShow = False
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnAdd.ColorFillBlend = cBlendItems3
            Me.btnAdd.Corners.All = 3
            Me.btnAdd.Corners.LowerLeft = 3
            Me.btnAdd.Corners.LowerRight = 3
            Me.btnAdd.Corners.UpperLeft = 3
            Me.btnAdd.Corners.UpperRight = 3
            Me.btnAdd.DesignerSelected = False
            Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnAdd.ImageIndex = 0
            Dim cButton5 As CButtonLib.CButton = Me.btnAdd
            location = New System.Drawing.Point(12, 278)
            cButton5.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim cButton6 As CButtonLib.CButton = Me.btnAdd
            size = New System.Drawing.Size(116, 47)
            cButton6.Size = size
            Me.btnAdd.TabIndex = 410
            Me.btnAdd.Text = "Add Pizza"
            Me.btnAdd.TextShadowShow = False
            Me.btnAdd.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnReset.BackColor = System.Drawing.Color.Transparent
            Me.btnReset.BorderShow = False
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnReset.ColorFillBlend = cBlendItems4
            Me.btnReset.Corners.All = 3
            Me.btnReset.Corners.LowerLeft = 3
            Me.btnReset.Corners.LowerRight = 3
            Me.btnReset.Corners.UpperLeft = 3
            Me.btnReset.Corners.UpperRight = 3
            Me.btnReset.DesignerSelected = False
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnReset.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.btnReset
            location = New System.Drawing.Point(19, 431)
            cButton7.Location = location
            Me.btnReset.Name = "btnReset"
            Dim cButton8 As CButtonLib.CButton = Me.btnReset
            size = New System.Drawing.Size(116, 47)
            cButton8.Size = size
            Me.btnReset.TabIndex = 409
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextShadowShow = False
            Me.btnReset.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.lblFinalBalance.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.lblFinalBalance.AutoSize = True
            Me.lblFinalBalance.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblFinalBalance.ForeColor = System.Drawing.Color.White
            Dim label11 As System.Windows.Forms.Label = Me.lblFinalBalance
            location = New System.Drawing.Point(219, 609)
            label11.Location = location
            Me.lblFinalBalance.Name = "lblFinalBalance"
            Dim label12 As System.Windows.Forms.Label = Me.lblFinalBalance
            size = New System.Drawing.Size(41, 21)
            label12.Size = size
            Me.lblFinalBalance.TabIndex = 413
            Me.lblFinalBalance.Text = "0.00"
            Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label13 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(134, 609)
            label13.Location = location
            Me.Label2.Name = "Label2"
            Dim label14 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(78, 21)
            label14.Size = size
            Me.Label2.TabIndex = 412
            Me.Label2.Text = "Balance : "
            Me.btnToppings.BackColor = System.Drawing.Color.Transparent
            Me.btnToppings.BorderShow = False
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnToppings.ColorFillBlend = cBlendItems5
            Me.btnToppings.Corners.All = 3
            Me.btnToppings.Corners.LowerLeft = 3
            Me.btnToppings.Corners.LowerRight = 3
            Me.btnToppings.Corners.UpperLeft = 3
            Me.btnToppings.Corners.UpperRight = 3
            Me.btnToppings.DesignerSelected = False
            Me.btnToppings.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnToppings.ImageIndex = 0
            Dim cButton9 As CButtonLib.CButton = Me.btnToppings
            location = New System.Drawing.Point(12, 115)
            cButton9.Location = location
            Me.btnToppings.Name = "btnToppings"
            Dim cButton10 As CButtonLib.CButton = Me.btnToppings
            size = New System.Drawing.Size(116, 49)
            cButton10.Size = size
            Me.btnToppings.TabIndex = 414
            Me.btnToppings.Text = "Extra Toppings"
            Me.btnToppings.TextShadowShow = False
            Me.btnToppings.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.lblPizzaName.AutoSize = True
            Me.lblPizzaName.ForeColor = System.Drawing.Color.White
            Dim label15 As System.Windows.Forms.Label = Me.lblPizzaName
            location = New System.Drawing.Point(16, 41)
            label15.Location = location
            Me.lblPizzaName.Name = "lblPizzaName"
            Dim label16 As System.Windows.Forms.Label = Me.lblPizzaName
            size = New System.Drawing.Size(70, 13)
            label16.Size = size
            Me.lblPizzaName.TabIndex = 415
            Me.lblPizzaName.Text = "lblPizzaName"
            Me.lblPizzaName.Visible = False
            Me.btnRemove1.BackColor = System.Drawing.Color.Transparent
            Me.btnRemove1.BorderShow = False
            cBlendItems6.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems6.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnRemove1.ColorFillBlend = cBlendItems6
            Me.btnRemove1.Corners.All = 3
            Me.btnRemove1.Corners.LowerLeft = 3
            Me.btnRemove1.Corners.LowerRight = 3
            Me.btnRemove1.Corners.UpperLeft = 3
            Me.btnRemove1.Corners.UpperRight = 3
            Me.btnRemove1.DesignerSelected = False
            Me.btnRemove1.Enabled = False
            Me.btnRemove1.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnRemove1.ImageIndex = 0
            Dim cButton11 As CButtonLib.CButton = Me.btnRemove1
            location = New System.Drawing.Point(19, 484)
            cButton11.Location = location
            Me.btnRemove1.Name = "btnRemove1"
            Dim cButton12 As CButtonLib.CButton = Me.btnRemove1
            size = New System.Drawing.Size(116, 47)
            cButton12.Size = size
            Me.btnRemove1.TabIndex = 416
            Me.btnRemove1.Text = "Remove"
            Me.btnRemove1.TextShadowShow = False
            Me.btnRemove1.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnFreeToppings.BackColor = System.Drawing.Color.Transparent
            Me.btnFreeToppings.BorderShow = False
            cBlendItems7.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems7.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnFreeToppings.ColorFillBlend = cBlendItems7
            Me.btnFreeToppings.Corners.All = 3
            Me.btnFreeToppings.Corners.LowerLeft = 3
            Me.btnFreeToppings.Corners.LowerRight = 3
            Me.btnFreeToppings.Corners.UpperLeft = 3
            Me.btnFreeToppings.Corners.UpperRight = 3
            Me.btnFreeToppings.DesignerSelected = False
            Me.btnFreeToppings.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnFreeToppings.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnFreeToppings.ImageIndex = 0
            Dim cButton13 As CButtonLib.CButton = Me.btnFreeToppings
            location = New System.Drawing.Point(12, 60)
            cButton13.Location = location
            Me.btnFreeToppings.Name = "btnFreeToppings"
            Dim cButton14 As CButtonLib.CButton = Me.btnFreeToppings
            size = New System.Drawing.Size(116, 49)
            cButton14.Size = size
            Me.btnFreeToppings.TabIndex = 418
            Me.btnFreeToppings.Text = "Free Toppings"
            Me.btnFreeToppings.TextShadowShow = False
            Me.btnFreeToppings.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Dim textBox As System.Windows.Forms.TextBox = Me.txtTaxType
            location = New System.Drawing.Point(418, 12)
            textBox.Location = location
            Me.txtTaxType.Name = "txtTaxType"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtTaxType
            size = New System.Drawing.Size(53, 20)
            textBox2.Size = size
            Me.txtTaxType.TabIndex = 452
            Me.txtTaxType.Visible = False
            Me.btnModifiers.BackColor = System.Drawing.Color.Transparent
            Me.btnModifiers.BorderShow = False
            cBlendItems8.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems8.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnModifiers.ColorFillBlend = cBlendItems8
            Me.btnModifiers.Corners.All = 3
            Me.btnModifiers.Corners.LowerLeft = 3
            Me.btnModifiers.Corners.LowerRight = 3
            Me.btnModifiers.Corners.UpperLeft = 3
            Me.btnModifiers.Corners.UpperRight = 3
            Me.btnModifiers.DesignerSelected = False
            Me.btnModifiers.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnModifiers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnModifiers.ImageIndex = 0
            Dim cButton15 As CButtonLib.CButton = Me.btnModifiers
            location = New System.Drawing.Point(12, 170)
            cButton15.Location = location
            Me.btnModifiers.Name = "btnModifiers"
            Dim cButton16 As CButtonLib.CButton = Me.btnModifiers
            size = New System.Drawing.Size(116, 49)
            cButton16.Size = size
            Me.btnModifiers.TabIndex = 453
            Me.btnModifiers.Text = "Modifiers"
            Me.btnModifiers.TextShadowShow = False
            Me.btnModifiers.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1000, 635)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnModifiers)
            MyBase.Controls.Add(Me.txtTaxType)
            MyBase.Controls.Add(Me.btnFreeToppings)
            MyBase.Controls.Add(Me.btnRemove1)
            MyBase.Controls.Add(Me.lblPizzaName)
            MyBase.Controls.Add(Me.btnToppings)
            MyBase.Controls.Add(Me.lblFinalBalance)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.btnDone)
            MyBase.Controls.Add(Me.btnAdd)
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.DataGridView2)
            MyBase.Controls.Add(Me.lblBalance)
            MyBase.Controls.Add(Me.Label35)
            MyBase.Controls.Add(Me.btnRemove)
            MyBase.Controls.Add(Me.DataGridView1)
            MyBase.Controls.Add(Me.Label32)
            MyBase.Controls.Add(Me.lblPizzaSize)
            MyBase.Controls.Add(Me.flpPizza)
            MyBase.Controls.Add(Me.flpPizzaSize)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmPizzaPOS"
            Me.Text = "Pizza"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.flpPizzaSize.ResumeLayout(False)
            Me.flpPizzaSize.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
