Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmSupplierRecord
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel4")>
        Private _Panel4 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCity")>
        Private _txtCity As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSupplierName")>
        Private _txtSupplierName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel6")>
        Private _Panel6 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel5")>
        Private _Panel5 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column8")>
        Private _Column8 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column9")>
        Private _Column9 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column10")>
        Private _Column10 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column11")>
        Private _Column11 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

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

        Friend Overridable Property txtCity As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCity
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtCity_TextChanged
                If Me._txtCity IsNot Nothing Then
                    RemoveHandler Me._txtCity.TextChanged, value2
                End If

                Me._txtCity = value
                If Me._txtCity IsNot Nothing Then
                    AddHandler Me._txtCity.TextChanged, value2
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

        Friend Overridable Property txtSupplierName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSupplierName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtSupplierName_TextChanged
                If Me._txtSupplierName IsNot Nothing Then
                    RemoveHandler Me._txtSupplierName.TextChanged, value2
                End If

                Me._txtSupplierName = value
                If Me._txtSupplierName IsNot Nothing Then
                    AddHandler Me._txtSupplierName.TextChanged, value2
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

        Friend Overridable Property Panel6 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel6 = value
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
                Dim value2 As System.EventHandler = AddressOf Me.txtContactNo_TextChanged
                If Me._txtContactNo IsNot Nothing Then
                    RemoveHandler Me._txtContactNo.TextChanged, value2
                End If

                Me._txtContactNo = value
                If Me._txtContactNo IsNot Nothing Then
                    AddHandler Me._txtContactNo.TextChanged, value2
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

        Friend Overridable Property btnClose As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClose
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnClose_Click_2
                If Me._btnClose IsNot Nothing Then
                    RemoveHandler Me._btnClose.Click, value2
                End If

                Me._btnClose = value
                If Me._btnClose IsNot Nothing Then
                    AddHandler Me._btnClose.Click, value2
                End If
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

        Friend Overridable Property btnAdd As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAdd
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
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
            Call RestaurantPOS14.frmSupplierRecord.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSupplierRecord.__ENCList
                If RestaurantPOS14.frmSupplierRecord.__ENCList.Count = RestaurantPOS14.frmSupplierRecord.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSupplierRecord.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSupplierRecord.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSupplierRecord.__ENCList(num) = RestaurantPOS14.frmSupplierRecord.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSupplierRecord.__ENCList.RemoveRange(num, RestaurantPOS14.frmSupplierRecord.__ENCList.Count - num)
                    RestaurantPOS14.frmSupplierRecord.__ENCList.Capacity = RestaurantPOS14.frmSupplierRecord.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSupplierRecord.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Getdata()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(ID),RTRIM(SupplierID),RTRIM([Name]), RTRIM(Address),RTRIM(City),RTRIM(State),RTRIM(ZipCode), RTRIM(ContactNo), RTRIM(EmailID),RTRIM(TIN),RTRIM(STNo),RTRIM(CST),RTRIM(PAN),RTRIM(AccountName),RTRIM(AccountNumber),RTRIM(Bank),RTRIM(Branch),RTRIM(IFSCCode),OpeningBalance,RTRIM(OpeningBalanceType),RTRIM(Remarks) from Supplier order by name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(16)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(17)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(18)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(19)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(20)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
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
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Supplier Entry", TextCompare:=False) = 0 Then
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtSupplierID.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtSupplierName.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtSupName.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtAddress.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtCity.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.cmbState.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtZipCode.Text = dataGridViewRow.Cells(CInt((6))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtContactNo.Text = dataGridViewRow.Cells(CInt((7))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtEmailID.Text = dataGridViewRow.Cells(CInt((8))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtHSTNo.Text = dataGridViewRow.Cells(CInt((9))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtSTNo.Text = dataGridViewRow.Cells(CInt((10))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtCIN.Text = dataGridViewRow.Cells(CInt((11))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtPAN.Text = dataGridViewRow.Cells(CInt((12))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtAccountName.Text = dataGridViewRow.Cells(CInt((13))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtAccountNo.Text = dataGridViewRow.Cells(CInt((14))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtBank.Text = dataGridViewRow.Cells(CInt((15))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtBranch.Text = dataGridViewRow.Cells(CInt((16))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtIFSCcode.Text = dataGridViewRow.Cells(CInt((17))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtOpeningBalance.Text = dataGridViewRow.Cells(CInt((18))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.cmbOpeningBalanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.cmbOpeningBalanceType.Text = dataGridViewRow.Cells(CInt((19))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtRemarks.Text = dataGridViewRow.Cells(CInt((20))).Value.ToString()
                    If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Supplier") Then
                        RestaurantPOS14.My.MyProject.Forms.frmSupplier.btnDelete.Enabled = True
                    Else
                        RestaurantPOS14.My.MyProject.Forms.frmSupplier.btnDelete.Enabled = False
                    End If

                    If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Supplier") Then
                        RestaurantPOS14.My.MyProject.Forms.frmSupplier.btnUpdate.Enabled = True
                    Else
                        RestaurantPOS14.My.MyProject.Forms.frmSupplier.btnUpdate.Enabled = False
                    End If

                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.btnSave.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.cmbOpeningBalanceType.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtOpeningBalance.[ReadOnly] = True
                    RestaurantPOS14.My.MyProject.Forms.frmSupplier.txtSupplierName.Enabled = False
                    Me.lblSet.Text = ""
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Payment", TextCompare:=False) = 0 Then
                    RestaurantPOS14.My.MyProject.Forms.frmPayment.txtSup_ID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayment.txtSupplierID.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayment.txtSupplierName.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayment.txtAddress.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayment.txtCity.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayment.txtContactNo.Text = dataGridViewRow.Cells(CInt((7))).Value.ToString()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPayment.GetSupplierBalance()
                    Me.lblSet.Text = ""
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Purchase", TextCompare:=False) = 0 Then
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.txtSup_ID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.txtSupplierID.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.txtSupplierName.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.txtAddress.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.txtCity.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.txtContactNo.Text = dataGridViewRow.Cells(CInt((7))).Value.ToString()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseEntry.GetSupplierBalance()
                    Me.lblSet.Text = ""
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Purchase Order", TextCompare:=False) = 0 Then
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.txtSup_ID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.txtSupplierID.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.txtSupplierName.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.txtAddress.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.txtCity.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.txtContactNo.Text = dataGridViewRow.Cells(CInt((7))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.txtEmailID.Text = dataGridViewRow.Cells(CInt((8))).Value.ToString()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.GetSupplierBalance()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPurchaseOrder.fillCombo()
                    Me.lblSet.Text = ""
                    MyBase.Close()
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

        Private Sub txtSupplierName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(ID),RTRIM(SupplierID),RTRIM([Name]), RTRIM(Address),RTRIM(City),RTRIM(State),RTRIM(ZipCode), RTRIM(ContactNo), RTRIM(EmailID),RTRIM(TIN),RTRIM(STNo),RTRIM(CST),RTRIM(PAN),RTRIM(AccountName),RTRIM(AccountNumber),RTRIM(Bank),RTRIM(Branch),RTRIM(IFSCCode),OpeningBalance,RTRIM(OpeningBalanceType),RTRIM(Remarks) from Supplier where name like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtSupplierName.Text) & "%' order by name", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(16)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(17)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(18)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(19)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(20)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtCity_TextChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(ID),RTRIM(SupplierID),RTRIM([Name]), RTRIM(Address),RTRIM(City),RTRIM(State),RTRIM(ZipCode), RTRIM(ContactNo), RTRIM(EmailID),RTRIM(TIN),RTRIM(STNo),RTRIM(CST),RTRIM(PAN),RTRIM(AccountName),RTRIM(AccountNumber),RTRIM(Bank),RTRIM(Branch),RTRIM(IFSCCode),OpeningBalance,RTRIM(OpeningBalanceType),RTRIM(Remarks) from Supplier where City like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtCity.Text) & "%' order by city", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(16)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(17)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(18)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(19)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(20)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtSupplierName.Text = ""
            Me.txtContactNo.Text = ""
            Me.txtCity.Text = ""
            Me.Getdata()
        End Sub

        Private Sub txtContactNo_TextChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(ID),RTRIM(SupplierID),RTRIM([Name]), RTRIM(Address),RTRIM(City),RTRIM(State),RTRIM(ZipCode), RTRIM(ContactNo), RTRIM(EmailID),RTRIM(TIN),RTRIM(STNo),RTRIM(CST),RTRIM(PAN),RTRIM(AccountName),RTRIM(AccountNumber),RTRIM(Bank),RTRIM(Branch),RTRIM(IFSCCode),OpeningBalance,RTRIM(OpeningBalanceType),RTRIM(Remarks) from Supplier where ContactNo like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtContactNo.Text) & "%' order by city", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(16)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(17)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(18)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(19)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(20)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnClose_Click_2(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.ExportExcel(Me.dgw)
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmSupplier.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplier.Reset()
            RestaurantPOS14.My.MyProject.Forms.frmSupplier.lblSet.Text = "ANS"
            Call RestaurantPOS14.My.MyProject.Forms.frmSupplier.Show()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSupplierRecord))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.txtCity = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtSupplierName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel6.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnAdd)
            Me.Panel1.Controls.Add(Me.Panel5)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.Panel6)
            Me.Panel1.Controls.Add(Me.Panel4)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(8, 7)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(1000, 618)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.lblUser)
            Me.Panel5.Controls.Add(Me.btnReset)
            Me.Panel5.Controls.Add(Me.btnExportExcel)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel5
            location = New System.Drawing.Point(666, 46)
            panel3.Location = location
            Me.Panel5.Name = "Panel5"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel5
            size = New System.Drawing.Size(207, 70)
            panel4.Size = size
            Me.Panel5.TabIndex = 52
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(13, 14)
            button.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button2 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(76, 37)
            button2.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(95, 14)
            button3.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button4 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(104, 37)
            button4.Size = size
            Me.btnExportExcel.TabIndex = 5
            Me.btnExportExcel.Text = "Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(919, 4)
            button5.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button6 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(75, 39)
            button6.Size = size
            Me.btnClose.TabIndex = 51
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel6.Controls.Add(Me.txtContactNo)
            Me.Panel6.Controls.Add(Me.Label4)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel6
            location = New System.Drawing.Point(447, 46)
            panel5.Location = location
            Me.Panel6.Name = "Panel6"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel6
            size = New System.Drawing.Size(213, 70)
            panel6.Size = size
            Me.Panel6.TabIndex = 50
            Me.txtContactNo.BackColor = System.Drawing.Color.White
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(13, 30)
            textBox.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(183, 21)
            textBox2.Size = size
            Me.txtContactNo.TabIndex = 13
            Me.Label4.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(10, 10)
            label.Location = location
            Me.Label4.Name = "Label4"
            Dim label2 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(122, 13)
            label2.Size = size
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "Search By Contact No. :"
            Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel4.Controls.Add(Me.txtCity)
            Me.Panel4.Controls.Add(Me.Label2)
            Dim panel7 As System.Windows.Forms.Panel = Me.Panel4
            location = New System.Drawing.Point(228, 46)
            panel7.Location = location
            Me.Panel4.Name = "Panel4"
            Dim panel8 As System.Windows.Forms.Panel = Me.Panel4
            size = New System.Drawing.Size(213, 70)
            panel8.Size = size
            Me.Panel4.TabIndex = 49
            Me.txtCity.BackColor = System.Drawing.Color.White
            Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtCity
            location = New System.Drawing.Point(13, 30)
            textBox3.Location = location
            Me.txtCity.Name = "txtCity"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtCity
            size = New System.Drawing.Size(183, 21)
            textBox4.Size = size
            Me.txtCity.TabIndex = 13
            Me.Label2.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(10, 10)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(82, 13)
            label4.Size = size
            Me.Label2.TabIndex = 12
            Me.Label2.Text = "Search By City :"
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.txtSupplierName)
            Me.Panel3.Controls.Add(Me.Label3)
            Dim panel9 As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(9, 46)
            panel9.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel10 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(213, 70)
            panel10.Size = size
            Me.Panel3.TabIndex = 48
            Me.txtSupplierName.BackColor = System.Drawing.Color.White
            Me.txtSupplierName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtSupplierName
            location = New System.Drawing.Point(13, 30)
            textBox5.Location = location
            Me.txtSupplierName.Name = "txtSupplierName"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtSupplierName
            size = New System.Drawing.Size(183, 21)
            textBox6.Size = size
            Me.txtSupplierName.TabIndex = 13
            Me.Label3.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(10, 10)
            label5.Location = location
            Me.Label3.Name = "Label3"
            Dim label6 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(134, 13)
            label6.Size = size
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Search By Supplier Name :"
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
            Me.dgw.ColumnHeadersHeight = 30
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3, Me.Column8, Me.Column4, Me.Column6, Me.Column7, Me.Column9, Me.Column10, Me.Column5, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column11)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(9, 122)
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
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
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
            Me.dgw.RowTemplate.Height = 20
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(985, 484)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 43
            Me.Column1.HeaderText = "ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.Column2.HeaderText = "Supplier ID"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column3.HeaderText = "Supplier Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 150
            Me.Column8.HeaderText = "Address"
            Me.Column8.Name = "Column8"
            Me.Column8.[ReadOnly] = True
            Me.Column8.Width = 150
            Me.Column4.HeaderText = "City"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column6.HeaderText = "State"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column7.HeaderText = "Postal Code"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column9.HeaderText = "Contact No."
            Me.Column9.Name = "Column9"
            Me.Column9.[ReadOnly] = True
            Me.Column10.HeaderText = "Email ID"
            Me.Column10.Name = "Column10"
            Me.Column10.[ReadOnly] = True
            Me.Column5.HeaderText = "TRN/VAT No."
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column12.HeaderText = "ST No."
            Me.Column12.Name = "Column12"
            Me.Column12.[ReadOnly] = True
            Me.Column12.Visible = False
            Me.Column13.HeaderText = "CIN"
            Me.Column13.Name = "Column13"
            Me.Column13.[ReadOnly] = True
            Me.Column13.Visible = False
            Me.Column14.HeaderText = "PAN"
            Me.Column14.Name = "Column14"
            Me.Column14.[ReadOnly] = True
            Me.Column14.Visible = False
            Me.Column15.HeaderText = "Account Name"
            Me.Column15.Name = "Column15"
            Me.Column15.[ReadOnly] = True
            Me.Column16.HeaderText = "Account No."
            Me.Column16.Name = "Column16"
            Me.Column16.[ReadOnly] = True
            Me.Column17.HeaderText = "Bank"
            Me.Column17.Name = "Column17"
            Me.Column17.[ReadOnly] = True
            Me.Column18.HeaderText = "Branch"
            Me.Column18.Name = "Column18"
            Me.Column18.[ReadOnly] = True
            Me.Column19.HeaderText = "Swift/IBAN Code"
            Me.Column19.Name = "Column19"
            Me.Column19.[ReadOnly] = True
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column20.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column20.HeaderText = "Opening Balance"
            Me.Column20.Name = "Column20"
            Me.Column20.[ReadOnly] = True
            Me.Column21.HeaderText = "Opening Balance Type"
            Me.Column21.Name = "Column21"
            Me.Column21.[ReadOnly] = True
            Me.Column11.HeaderText = "Remarks"
            Me.Column11.Name = "Column11"
            Me.Column11.[ReadOnly] = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.lblSet)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel11 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel11.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel12 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(909, 34)
            panel12.Size = size
            Me.Panel2.TabIndex = 0
            Me.lblSet.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(250, 30)
            label7.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label8 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label8.Size = size
            Me.lblSet.TabIndex = 44
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label9 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(402, 6)
            label9.Location = location
            Me.Label1.Name = "Label1"
            Dim label10 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(162, 24)
            label10.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "List Of Suppliers"
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Dim button7 As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(879, 57)
            button7.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button8 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(92, 52)
            button8.Size = size
            Me.btnAdd.TabIndex = 313
            Me.btnAdd.Text = "Add New" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Supplier"
            Me.btnAdd.UseVisualStyleBackColor = True
            Me.lblUser.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(92, -2)
            label11.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label12 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(29, 13)
            label12.Size = size
            Me.lblUser.TabIndex = 314
            Me.lblUser.Text = "User"
            Me.lblUser.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1015, 632)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmSupplierRecord"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel5.PerformLayout()
            Me.Panel6.ResumeLayout(False)
            Me.Panel6.PerformLayout()
            Me.Panel4.ResumeLayout(False)
            Me.Panel4.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
