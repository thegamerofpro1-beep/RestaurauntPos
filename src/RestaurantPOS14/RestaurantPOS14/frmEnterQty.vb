Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
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
    Public Class frmEnterQty
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtQty")>
        Private _txtQty As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnOkay")>
        Private _btnOkay As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDOT")>
        Private _btnDOT As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA0")>
        Private _btnTA0 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA8")>
        Private _btnTA8 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA4")>
        Private _btnTA4 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA6")>
        Private _btnTA6 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA5")>
        Private _btnTA5 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA7")>
        Private _btnTA7 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA3")>
        Private _btnTA3 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA1")>
        Private _btnTA1 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA2")>
        Private _btnTA2 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnX")>
        Private _btnX As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btn00")>
        Private _btn00 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTA9")>
        Private _btnTA9 As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtNotes")>
        Private _txtNotes As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtQ")>
        Private _txtQ As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtItemStatus")>
        Private _txtItemStatus As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDishNameArabic")>
        Private _txtDishNameArabic As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCategory")>
        Private _txtCategory As System.Windows.Forms.TextBox

        Private sign_Indicator As Integer

        Private variable1 As Double

        Private variable2 As Double

        Private fl As Boolean

        Private s As String

        Private x As String

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property txtQty As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtQty
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtRate_KeyPress
                If Me._txtQty IsNot Nothing Then
                    RemoveHandler Me._txtQty.KeyPress, value2
                End If

                Me._txtQty = value
                If Me._txtQty IsNot Nothing Then
                    AddHandler Me._txtQty.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnOkay As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnOkay
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnOkay_Click
                If Me._btnOkay IsNot Nothing Then
                    RemoveHandler Me._btnOkay.Click, value2
                End If

                Me._btnOkay = value
                If Me._btnOkay IsNot Nothing Then
                    AddHandler Me._btnOkay.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnDOT As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDOT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnDOT_Click
                If Me._btnDOT IsNot Nothing Then
                    RemoveHandler Me._btnDOT.Click, value2
                End If

                Me._btnDOT = value
                If Me._btnDOT IsNot Nothing Then
                    AddHandler Me._btnDOT.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA0 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA0
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA0_Click
                If Me._btnTA0 IsNot Nothing Then
                    RemoveHandler Me._btnTA0.Click, value2
                End If

                Me._btnTA0 = value
                If Me._btnTA0 IsNot Nothing Then
                    AddHandler Me._btnTA0.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA8 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA8_Click
                If Me._btnTA8 IsNot Nothing Then
                    RemoveHandler Me._btnTA8.Click, value2
                End If

                Me._btnTA8 = value
                If Me._btnTA8 IsNot Nothing Then
                    AddHandler Me._btnTA8.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA4 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA4_Click
                If Me._btnTA4 IsNot Nothing Then
                    RemoveHandler Me._btnTA4.Click, value2
                End If

                Me._btnTA4 = value
                If Me._btnTA4 IsNot Nothing Then
                    AddHandler Me._btnTA4.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA6 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA6_Click
                If Me._btnTA6 IsNot Nothing Then
                    RemoveHandler Me._btnTA6.Click, value2
                End If

                Me._btnTA6 = value
                If Me._btnTA6 IsNot Nothing Then
                    AddHandler Me._btnTA6.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA5 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA5_Click
                If Me._btnTA5 IsNot Nothing Then
                    RemoveHandler Me._btnTA5.Click, value2
                End If

                Me._btnTA5 = value
                If Me._btnTA5 IsNot Nothing Then
                    AddHandler Me._btnTA5.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA7 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA7_Click
                If Me._btnTA7 IsNot Nothing Then
                    RemoveHandler Me._btnTA7.Click, value2
                End If

                Me._btnTA7 = value
                If Me._btnTA7 IsNot Nothing Then
                    AddHandler Me._btnTA7.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA3 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA3_Click
                If Me._btnTA3 IsNot Nothing Then
                    RemoveHandler Me._btnTA3.Click, value2
                End If

                Me._btnTA3 = value
                If Me._btnTA3 IsNot Nothing Then
                    AddHandler Me._btnTA3.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA1 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA1_Click
                If Me._btnTA1 IsNot Nothing Then
                    RemoveHandler Me._btnTA1.Click, value2
                End If

                Me._btnTA1 = value
                If Me._btnTA1 IsNot Nothing Then
                    AddHandler Me._btnTA1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA2 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA2_Click
                If Me._btnTA2 IsNot Nothing Then
                    RemoveHandler Me._btnTA2.Click, value2
                End If

                Me._btnTA2 = value
                If Me._btnTA2 IsNot Nothing Then
                    AddHandler Me._btnTA2.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnX As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnX
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnX_Click
                If Me._btnX IsNot Nothing Then
                    RemoveHandler Me._btnX.Click, value2
                End If

                Me._btnX = value
                If Me._btnX IsNot Nothing Then
                    AddHandler Me._btnX.Click, value2
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

        Friend Overridable Property btnCancel As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnCancel_Click_1
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, value2
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btn00 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btn00
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btn00_Click
                If Me._btn00 IsNot Nothing Then
                    RemoveHandler Me._btn00.Click, value2
                End If

                Me._btn00 = value
                If Me._btn00 IsNot Nothing Then
                    AddHandler Me._btn00.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnTA9 As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTA9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTA9_Click
                If Me._btnTA9 IsNot Nothing Then
                    RemoveHandler Me._btnTA9.Click, value2
                End If

                Me._btnTA9 = value
                If Me._btnTA9 IsNot Nothing Then
                    AddHandler Me._btnTA9.Click, value2
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

        Friend Overridable Property txtQ As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtQ
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtQ = value
            End Set
        End Property

        Friend Overridable Property txtItemStatus As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtItemStatus
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtItemStatus = value
            End Set
        End Property

        Friend Overridable Property txtDishNameArabic As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDishNameArabic
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDishNameArabic = value
            End Set
        End Property

        Friend Overridable Property txtCategory As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCategory
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCategory = value
            End Set
        End Property

        Public Sub New()
            AddHandler MyBase.Shown, AddressOf Me.frmEnterRate_Shown
            Call RestaurantPOS14.frmEnterQty.__ENCAddToList(Me)
            Me.sign_Indicator = 0
            Me.fl = False
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmEnterQty.__ENCList
                If RestaurantPOS14.frmEnterQty.__ENCList.Count = RestaurantPOS14.frmEnterQty.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmEnterQty.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmEnterQty.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmEnterQty.__ENCList(num) = RestaurantPOS14.frmEnterQty.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmEnterQty.__ENCList.RemoveRange(num, RestaurantPOS14.frmEnterQty.__ENCList.Count - num)
                    RestaurantPOS14.frmEnterQty.__ENCList.Capacity = RestaurantPOS14.frmEnterQty.__ENCList.Count
                End If

                Call RestaurantPOS14.frmEnterQty.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnOkay_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtQty.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter the quantity", "Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.txtQty.Focus()
                ElseIf Microsoft.VisualBasic.Conversion.Val(Me.txtQ.Text) < Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text) Then
                    Call System.Windows.Forms.MessageBox.Show("You can't enter more quantity than ordered qty.", "Selection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtQty.Focus()
                    Me.txtQty.Text = ""
                Else
                    If RestaurantPOS14.My.MyProject.Forms.frmBillSplit.dgw.Rows.Count <= 0 Then
                        Return
                    End If

                    For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmBillSplit.DataGridView2.Rows, System.Collections.IEnumerable)
                        Dim dataGridViewRow2 As System.Windows.Forms.DataGridViewRow = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.dgw.SelectedRows(0)
                        If Not((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((1))).Value.ToString(), dataGridViewRow2.Cells(CInt((1))).Value.ToString(), TextCompare:=False) = 0) And (Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)) = Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((2))).Value)))) Then
                            Continue For
                        End If

                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text = dataGridViewRow2.Cells(CInt((1))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text = dataGridViewRow2.Cells(CInt((2))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = dataGridViewRow2.Cells(CInt((9))).Value.ToString()
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                        dataGridViewRow.Cells(CInt((0))).Value = dataGridViewRow2.Cells(CInt((0))).Value.ToString()
                        dataGridViewRow.Cells(CInt((1))).Value = dataGridViewRow2.Cells(CInt((1))).Value.ToString()
                        dataGridViewRow.Cells(CInt((2))).Value = dataGridViewRow2.Cells(CInt((2))).Value.ToString()
                        Dim dataGridViewCell As System.Windows.Forms.DataGridViewCell = dataGridViewRow.Cells(3)
                        dataGridViewCell.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(dataGridViewCell.Value, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text))
                        Dim dataGridViewCell2 As System.Windows.Forms.DataGridViewCell = dataGridViewRow.Cells(4)
                        dataGridViewCell2.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(dataGridViewCell2.Value, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text))
                        Dim dataGridViewCell3 As System.Windows.Forms.DataGridViewCell = dataGridViewRow.Cells(10)
                        dataGridViewCell3.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(dataGridViewCell3.Value, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text))
                        Dim dataGridViewCell4 As System.Windows.Forms.DataGridViewCell = dataGridViewRow.Cells(13)
                        dataGridViewCell4.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(dataGridViewCell4.Value, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text))
                        Dim value As Double = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.GrandTotal_Food1X()
                        value = System.Math.Round(value, 2)
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.DataGridView2.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.DataGridView2.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmBillSplit.DataGridView2.Rows.Count - 1))).Cells(1)
                        Dim dataGridViewCell5 As System.Windows.Forms.DataGridViewCell = dataGridViewRow2.Cells(3)
                        dataGridViewCell5.Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(dataGridViewCell5.Value, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text))
                        If Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells(CInt((3))).Value)) = 0.0 Then
                            For Each dataGridViewRow3 As System.Windows.Forms.DataGridViewRow In RestaurantPOS14.My.MyProject.Forms.frmBillSplit.dgw.SelectedRows
                                Call RestaurantPOS14.My.MyProject.Forms.frmBillSplit.dgw.Rows.Remove(dataGridViewRow3)
                            Next
                        End If

                        Dim value2 As Double = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.GrandTotal_Food1()
                        value2 = System.Math.Round(value2, 2)
                        RestaurantPOS14.My.MyProject.Forms.frmBillSplit.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                        Return
                    Next

                    Dim dataGridViewRow4 As System.Windows.Forms.DataGridViewRow = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.dgw.SelectedRows(0)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text = dataGridViewRow4.Cells(CInt((1))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text = dataGridViewRow4.Cells(CInt((2))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text))
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = dataGridViewRow4.Cells(CInt((9))).Value.ToString()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Call RestaurantPOS14.My.MyProject.Forms.frmBillSplit.DataGridView2.Rows.Add(RestaurantPOS14.My.MyProject.Forms.frmBillSplit.lblTableNo.Text, RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCPer.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCAmount.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtGroupName.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTempDiscountPer.Text), Me.txtCategory.Text, Me.txtDishNameArabic.Text)
                    Dim value3 As Double = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.GrandTotal_Food1X()
                    value3 = System.Math.Round(value3, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtGrandTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value3)
                    RestaurantPOS14.My.MyProject.Forms.frmBillSplit.DataGridView2.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.DataGridView2.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmBillSplit.DataGridView2.Rows.Count - 1))).Cells(1)
                    Dim dataGridViewCell6 As System.Windows.Forms.DataGridViewCell = dataGridViewRow4.Cells(3)
                    dataGridViewCell6.Value = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(dataGridViewCell6.Value, Microsoft.VisualBasic.Conversion.Val(Me.txtQty.Text))
                    If Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow4.Cells(CInt((3))).Value)) = 0.0 Then
                        For Each dataGridViewRow5 As System.Windows.Forms.DataGridViewRow In RestaurantPOS14.My.MyProject.Forms.frmBillSplit.dgw.SelectedRows
                            Call RestaurantPOS14.My.MyProject.Forms.frmBillSplit.dgw.Rows.Remove(dataGridViewRow5)
                        Next
                    End If

                    Dim value4 As Double = RestaurantPOS14.My.MyProject.Forms.frmBillSplit.GrandTotal_Food1()
                    value4 = System.Math.Round(value4, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmBillSplit.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value4)
                    MyBase.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtRate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim keyChar As Char = e.KeyChar
            If Char.IsControl(keyChar) Then
                Return
            End If

            If Char.IsDigit(keyChar) OrElse keyChar = "."c Then
                Dim text As String = Me.txtQty.Text
                Dim selectionStart As Integer = Me.txtQty.SelectionStart
                Dim selectionLength As Integer = Me.txtQty.SelectionLength
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

        Private Sub btnTA1_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(1)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(1)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnTA2_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(2)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(2)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnTA3_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(3)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(3)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnTA4_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(4)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(4)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnTA5_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(5)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(5)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnTA6_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(6)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(6)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnTA7_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(7)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(7)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnTA8_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(8)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(8)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnTA9_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(9)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(9)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnTA0_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString(0)
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString(0)
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnX_Click(sender As Object, e As System.EventArgs)
            Me.s = Me.txtQty.Text
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

            Me.txtQty.Text = Me.x
            Me.x = ""
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnDOT_Click(sender As Object, e As System.EventArgs)
            Dim num As Integer = 0
            Dim num2 As Integer = Me.txtQty.Text.Length - 1
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

                If Me.txtQty.Text(num4) = "."c Then
                    num = 1
                End If

                num4 += 1
            End While

            If num <> 1 Then
                Me.txtQty.Text += System.Convert.ToString(".")
            End If
        End Sub

        Private Sub btn00_Click(sender As Object, e As System.EventArgs)
            If Me.sign_Indicator = 0 Then
                Me.txtQty.Text += System.Convert.ToString("00")
            ElseIf Me.sign_Indicator = 1 Then
                Me.txtQty.Text = System.Convert.ToString("00")
                Me.sign_Indicator = 0
            End If

            Me.fl = True
        End Sub

        Private Sub btnCancel_Click_1(sender As Object, e As System.EventArgs)
            Me.txtQty.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
            MyBase.Close()
        End Sub

        Private Sub frmEnterRate_Shown(sender As Object, e As System.EventArgs)
            Me.txtQty.Focus()
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
            Dim cBlendItems As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems7 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems8 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems9 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems10 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems11 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems12 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems13 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems14 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems15 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmEnterQty))
            Me.txtQty = New System.Windows.Forms.TextBox()
            Me.btnOkay = New CButtonLib.CButton()
            Me.btnTA8 = New CButtonLib.CButton()
            Me.btnTA4 = New CButtonLib.CButton()
            Me.btnTA6 = New CButtonLib.CButton()
            Me.btnTA5 = New CButtonLib.CButton()
            Me.btnTA7 = New CButtonLib.CButton()
            Me.btnTA3 = New CButtonLib.CButton()
            Me.btnTA1 = New CButtonLib.CButton()
            Me.btnTA2 = New CButtonLib.CButton()
            Me.btnDOT = New CButtonLib.CButton()
            Me.btnTA0 = New CButtonLib.CButton()
            Me.btnX = New CButtonLib.CButton()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnCancel = New CButtonLib.CButton()
            Me.btn00 = New CButtonLib.CButton()
            Me.btnTA9 = New CButtonLib.CButton()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.txtNotes = New System.Windows.Forms.TextBox()
            Me.txtQ = New System.Windows.Forms.TextBox()
            Me.txtItemStatus = New System.Windows.Forms.TextBox()
            Me.txtDishNameArabic = New System.Windows.Forms.TextBox()
            Me.txtCategory = New System.Windows.Forms.TextBox()
            MyBase.SuspendLayout()
            Me.txtQty.BackColor = System.Drawing.Color.White
            Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.txtQty.Font = New System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.txtQty.ForeColor = System.Drawing.Color.Black
            Dim textBox As System.Windows.Forms.TextBox = Me.txtQty
            Dim location As System.Drawing.Point = New System.Drawing.Point(14, 52)
            textBox.Location = location
            Me.txtQty.Name = "txtQty"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtQty
            Dim size As System.Drawing.Size = New System.Drawing.Size(489, 50)
            textBox2.Size = size
            Me.txtQty.TabIndex = 0
            Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.btnOkay.BackColor = System.Drawing.Color.Transparent
            Me.btnOkay.BorderColor = System.Drawing.Color.Transparent
            Me.btnOkay.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnOkay.ColorFillBlend = cBlendItems
            Me.btnOkay.Corners.All = 3
            Me.btnOkay.Corners.LowerLeft = 3
            Me.btnOkay.Corners.LowerRight = 3
            Me.btnOkay.Corners.UpperLeft = 3
            Me.btnOkay.Corners.UpperRight = 3
            Me.btnOkay.DesignerSelected = False
            Me.btnOkay.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnOkay.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnOkay
            location = New System.Drawing.Point(312, 194)
            cButton.Location = location
            Me.btnOkay.Name = "btnOkay"
            Dim cButton2 As CButtonLib.CButton = Me.btnOkay
            size = New System.Drawing.Size(192, 224)
            cButton2.Size = size
            Me.btnOkay.TabIndex = 1
            Me.btnOkay.Text = "&ENTER"
            Me.btnOkay.TextShadowShow = False
            Me.btnOkay.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA8.BackColor = System.Drawing.Color.Transparent
            Me.btnTA8.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA8.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA8.ColorFillBlend = cBlendItems2
            Me.btnTA8.Corners.All = 3
            Me.btnTA8.Corners.LowerLeft = 3
            Me.btnTA8.Corners.LowerRight = 3
            Me.btnTA8.Corners.UpperLeft = 3
            Me.btnTA8.Corners.UpperRight = 3
            Me.btnTA8.DesignerSelected = False
            Me.btnTA8.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA8.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnTA8
            location = New System.Drawing.Point(113, 270)
            cButton3.Location = location
            Me.btnTA8.Name = "btnTA8"
            Dim cButton4 As CButtonLib.CButton = Me.btnTA8
            size = New System.Drawing.Size(93, 70)
            cButton4.Size = size
            Me.btnTA8.TabIndex = 14
            Me.btnTA8.Text = "8"
            Me.btnTA8.TextShadowShow = False
            Me.btnTA8.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA4.BackColor = System.Drawing.Color.Transparent
            Me.btnTA4.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA4.BorderShow = False
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA4.ColorFillBlend = cBlendItems3
            Me.btnTA4.Corners.All = 3
            Me.btnTA4.Corners.LowerLeft = 3
            Me.btnTA4.Corners.LowerRight = 3
            Me.btnTA4.Corners.UpperLeft = 3
            Me.btnTA4.Corners.UpperRight = 3
            Me.btnTA4.DesignerSelected = False
            Me.btnTA4.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA4.ImageIndex = 0
            Dim cButton5 As CButtonLib.CButton = Me.btnTA4
            location = New System.Drawing.Point(14, 194)
            cButton5.Location = location
            Me.btnTA4.Name = "btnTA4"
            Dim cButton6 As CButtonLib.CButton = Me.btnTA4
            size = New System.Drawing.Size(93, 70)
            cButton6.Size = size
            Me.btnTA4.TabIndex = 30
            Me.btnTA4.Text = "4"
            Me.btnTA4.TextShadowShow = False
            Me.btnTA4.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA6.BackColor = System.Drawing.Color.Transparent
            Me.btnTA6.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA6.BorderShow = False
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA6.ColorFillBlend = cBlendItems4
            Me.btnTA6.Corners.All = 3
            Me.btnTA6.Corners.LowerLeft = 3
            Me.btnTA6.Corners.LowerRight = 3
            Me.btnTA6.Corners.UpperLeft = 3
            Me.btnTA6.Corners.UpperRight = 3
            Me.btnTA6.DesignerSelected = False
            Me.btnTA6.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA6.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.btnTA6
            location = New System.Drawing.Point(212, 194)
            cButton7.Location = location
            Me.btnTA6.Name = "btnTA6"
            Dim cButton8 As CButtonLib.CButton = Me.btnTA6
            size = New System.Drawing.Size(93, 70)
            cButton8.Size = size
            Me.btnTA6.TabIndex = 12
            Me.btnTA6.Text = "6"
            Me.btnTA6.TextShadowShow = False
            Me.btnTA6.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA5.BackColor = System.Drawing.Color.Transparent
            Me.btnTA5.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA5.BorderShow = False
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA5.ColorFillBlend = cBlendItems5
            Me.btnTA5.Corners.All = 3
            Me.btnTA5.Corners.LowerLeft = 3
            Me.btnTA5.Corners.LowerRight = 3
            Me.btnTA5.Corners.UpperLeft = 3
            Me.btnTA5.Corners.UpperRight = 3
            Me.btnTA5.DesignerSelected = False
            Me.btnTA5.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA5.ImageIndex = 0
            Dim cButton9 As CButtonLib.CButton = Me.btnTA5
            location = New System.Drawing.Point(113, 194)
            cButton9.Location = location
            Me.btnTA5.Name = "btnTA5"
            Dim cButton10 As CButtonLib.CButton = Me.btnTA5
            size = New System.Drawing.Size(93, 70)
            cButton10.Size = size
            Me.btnTA5.TabIndex = 11
            Me.btnTA5.Text = "5"
            Me.btnTA5.TextShadowShow = False
            Me.btnTA5.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA7.BackColor = System.Drawing.Color.Transparent
            Me.btnTA7.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA7.BorderShow = False
            cBlendItems6.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems6.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA7.ColorFillBlend = cBlendItems6
            Me.btnTA7.Corners.All = 3
            Me.btnTA7.Corners.LowerLeft = 3
            Me.btnTA7.Corners.LowerRight = 3
            Me.btnTA7.Corners.UpperLeft = 3
            Me.btnTA7.Corners.UpperRight = 3
            Me.btnTA7.DesignerSelected = False
            Me.btnTA7.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA7.ImageIndex = 0
            Dim cButton11 As CButtonLib.CButton = Me.btnTA7
            location = New System.Drawing.Point(14, 270)
            cButton11.Location = location
            Me.btnTA7.Name = "btnTA7"
            Dim cButton12 As CButtonLib.CButton = Me.btnTA7
            size = New System.Drawing.Size(93, 70)
            cButton12.Size = size
            Me.btnTA7.TabIndex = 13
            Me.btnTA7.Text = "7"
            Me.btnTA7.TextShadowShow = False
            Me.btnTA7.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA3.BackColor = System.Drawing.Color.Transparent
            Me.btnTA3.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA3.BorderShow = False
            cBlendItems7.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems7.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA3.ColorFillBlend = cBlendItems7
            Me.btnTA3.Corners.All = 3
            Me.btnTA3.Corners.LowerLeft = 3
            Me.btnTA3.Corners.LowerRight = 3
            Me.btnTA3.Corners.UpperLeft = 3
            Me.btnTA3.Corners.UpperRight = 3
            Me.btnTA3.DesignerSelected = False
            Me.btnTA3.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA3.ImageIndex = 0
            Dim cButton13 As CButtonLib.CButton = Me.btnTA3
            location = New System.Drawing.Point(212, 118)
            cButton13.Location = location
            Me.btnTA3.Name = "btnTA3"
            Dim cButton14 As CButtonLib.CButton = Me.btnTA3
            size = New System.Drawing.Size(93, 70)
            cButton14.Size = size
            Me.btnTA3.TabIndex = 9
            Me.btnTA3.Text = "3"
            Me.btnTA3.TextShadowShow = False
            Me.btnTA3.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA1.BackColor = System.Drawing.Color.Transparent
            Me.btnTA1.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA1.BorderShow = False
            cBlendItems8.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems8.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA1.ColorFillBlend = cBlendItems8
            Me.btnTA1.Corners.All = 3
            Me.btnTA1.Corners.LowerLeft = 3
            Me.btnTA1.Corners.LowerRight = 3
            Me.btnTA1.Corners.UpperLeft = 3
            Me.btnTA1.Corners.UpperRight = 3
            Me.btnTA1.DesignerSelected = False
            Me.btnTA1.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA1.ImageIndex = 0
            Dim cButton15 As CButtonLib.CButton = Me.btnTA1
            location = New System.Drawing.Point(14, 118)
            cButton15.Location = location
            Me.btnTA1.Name = "btnTA1"
            Dim cButton16 As CButtonLib.CButton = Me.btnTA1
            size = New System.Drawing.Size(93, 70)
            cButton16.Size = size
            Me.btnTA1.TabIndex = 1
            Me.btnTA1.Text = "1"
            Me.btnTA1.TextShadowShow = False
            Me.btnTA1.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA2.BackColor = System.Drawing.Color.Transparent
            Me.btnTA2.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA2.BorderShow = False
            cBlendItems9.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems9.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA2.ColorFillBlend = cBlendItems9
            Me.btnTA2.Corners.All = 3
            Me.btnTA2.Corners.LowerLeft = 3
            Me.btnTA2.Corners.LowerRight = 3
            Me.btnTA2.Corners.UpperLeft = 3
            Me.btnTA2.Corners.UpperRight = 3
            Me.btnTA2.DesignerSelected = False
            Me.btnTA2.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA2.ImageIndex = 0
            Dim cButton17 As CButtonLib.CButton = Me.btnTA2
            location = New System.Drawing.Point(113, 118)
            cButton17.Location = location
            Me.btnTA2.Name = "btnTA2"
            Dim cButton18 As CButtonLib.CButton = Me.btnTA2
            size = New System.Drawing.Size(93, 70)
            cButton18.Size = size
            Me.btnTA2.TabIndex = 8
            Me.btnTA2.Text = "2"
            Me.btnTA2.TextShadowShow = False
            Me.btnTA2.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnDOT.BackColor = System.Drawing.Color.Transparent
            Me.btnDOT.BorderColor = System.Drawing.Color.Transparent
            Me.btnDOT.BorderShow = False
            cBlendItems10.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems10.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnDOT.ColorFillBlend = cBlendItems10
            Me.btnDOT.Corners.All = 3
            Me.btnDOT.Corners.LowerLeft = 3
            Me.btnDOT.Corners.LowerRight = 3
            Me.btnDOT.Corners.UpperLeft = 3
            Me.btnDOT.Corners.UpperRight = 3
            Me.btnDOT.DesignerSelected = False
            Me.btnDOT.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDOT.ImageIndex = 0
            Dim cButton19 As CButtonLib.CButton = Me.btnDOT
            location = New System.Drawing.Point(212, 348)
            cButton19.Location = location
            Me.btnDOT.Name = "btnDOT"
            Dim cButton20 As CButtonLib.CButton = Me.btnDOT
            size = New System.Drawing.Size(93, 70)
            cButton20.Size = size
            Me.btnDOT.TabIndex = 18
            Me.btnDOT.Text = "."
            Me.btnDOT.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnDOT.TextShadowShow = False
            Me.btnDOT.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA0.BackColor = System.Drawing.Color.Transparent
            Me.btnTA0.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA0.BorderShow = False
            cBlendItems11.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems11.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA0.ColorFillBlend = cBlendItems11
            Me.btnTA0.Corners.All = 3
            Me.btnTA0.Corners.LowerLeft = 3
            Me.btnTA0.Corners.LowerRight = 3
            Me.btnTA0.Corners.UpperLeft = 3
            Me.btnTA0.Corners.UpperRight = 3
            Me.btnTA0.DesignerSelected = False
            Me.btnTA0.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA0.ImageIndex = 0
            Dim cButton21 As CButtonLib.CButton = Me.btnTA0
            location = New System.Drawing.Point(14, 346)
            cButton21.Location = location
            Me.btnTA0.Name = "btnTA0"
            Dim cButton22 As CButtonLib.CButton = Me.btnTA0
            size = New System.Drawing.Size(93, 70)
            cButton22.Size = size
            Me.btnTA0.TabIndex = 17
            Me.btnTA0.Text = "0"
            Me.btnTA0.TextShadowShow = False
            Me.btnTA0.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnX.BackColor = System.Drawing.Color.Transparent
            Me.btnX.BorderColor = System.Drawing.Color.Transparent
            Me.btnX.BorderShow = False
            cBlendItems12.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems12.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnX.ColorFillBlend = cBlendItems12
            Me.btnX.Corners.All = 3
            Me.btnX.Corners.LowerLeft = 3
            Me.btnX.Corners.LowerRight = 3
            Me.btnX.Corners.UpperLeft = 3
            Me.btnX.Corners.UpperRight = 3
            Me.btnX.DesignerSelected = False
            Me.btnX.Font = New System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnX.ImageIndex = 0
            Dim cButton23 As CButtonLib.CButton = Me.btnX
            location = New System.Drawing.Point(311, 118)
            cButton23.Location = location
            Me.btnX.Name = "btnX"
            Dim cButton24 As CButtonLib.CButton = Me.btnX
            size = New System.Drawing.Size(93, 70)
            cButton24.Size = size
            Me.btnX.TabIndex = 31
            Me.btnX.Text = "-->"
            Me.btnX.TextShadowShow = False
            Me.btnX.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(136, 8)
            label.Location = location
            Me.Label2.Name = "Label2"
            Dim label2 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(268, 32)
            label2.Size = size
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "ENTER ITEM QUANTITY"
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.BorderColor = System.Drawing.Color.Transparent
            Me.btnCancel.BorderShow = False
            cBlendItems13.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems13.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnCancel.ColorFillBlend = cBlendItems13
            Me.btnCancel.Corners.All = 3
            Me.btnCancel.Corners.LowerLeft = 3
            Me.btnCancel.Corners.LowerRight = 3
            Me.btnCancel.Corners.UpperLeft = 3
            Me.btnCancel.Corners.UpperRight = 3
            Me.btnCancel.DesignerSelected = False
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.ImageIndex = 0
            Dim cButton25 As CButtonLib.CButton = Me.btnCancel
            location = New System.Drawing.Point(410, 118)
            cButton25.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim cButton26 As CButtonLib.CButton = Me.btnCancel
            size = New System.Drawing.Size(93, 70)
            cButton26.Size = size
            Me.btnCancel.TabIndex = 32
            Me.btnCancel.Text = "CLOSE"
            Me.btnCancel.TextShadowShow = False
            Me.btnCancel.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btn00.BackColor = System.Drawing.Color.Transparent
            Me.btn00.BorderColor = System.Drawing.Color.Transparent
            Me.btn00.BorderShow = False
            cBlendItems14.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems14.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btn00.ColorFillBlend = cBlendItems14
            Me.btn00.Corners.All = 3
            Me.btn00.Corners.LowerLeft = 3
            Me.btn00.Corners.LowerRight = 3
            Me.btn00.Corners.UpperLeft = 3
            Me.btn00.Corners.UpperRight = 3
            Me.btn00.DesignerSelected = False
            Me.btn00.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btn00.ImageIndex = 0
            Dim cButton27 As CButtonLib.CButton = Me.btn00
            location = New System.Drawing.Point(113, 348)
            cButton27.Location = location
            Me.btn00.Name = "btn00"
            Dim cButton28 As CButtonLib.CButton = Me.btn00
            size = New System.Drawing.Size(93, 70)
            cButton28.Size = size
            Me.btn00.TabIndex = 33
            Me.btn00.Text = "00"
            Me.btn00.TextShadowShow = False
            Me.btn00.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnTA9.BackColor = System.Drawing.Color.Transparent
            Me.btnTA9.BorderColor = System.Drawing.Color.Transparent
            Me.btnTA9.BorderShow = False
            cBlendItems15.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems15.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTA9.ColorFillBlend = cBlendItems15
            Me.btnTA9.Corners.All = 3
            Me.btnTA9.Corners.LowerLeft = 3
            Me.btnTA9.Corners.LowerRight = 3
            Me.btnTA9.Corners.UpperLeft = 3
            Me.btnTA9.Corners.UpperRight = 3
            Me.btnTA9.DesignerSelected = False
            Me.btnTA9.Font = New System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTA9.ImageIndex = 0
            Dim cButton29 As CButtonLib.CButton = Me.btnTA9
            location = New System.Drawing.Point(212, 270)
            cButton29.Location = location
            Me.btnTA9.Name = "btnTA9"
            Dim cButton30 As CButtonLib.CButton = Me.btnTA9
            size = New System.Drawing.Size(93, 70)
            cButton30.Size = size
            Me.btnTA9.TabIndex = 15
            Me.btnTA9.Text = "9"
            Me.btnTA9.TextShadowShow = False
            Me.btnTA9.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.lblSet.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(463, 27)
            label3.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label4 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(39, 13)
            label4.Size = size
            Me.lblSet.TabIndex = 34
            Me.lblSet.Text = "Label1"
            Me.lblSet.Visible = False
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtNotes
            location = New System.Drawing.Point(410, 43)
            textBox3.Location = location
            Me.txtNotes.Name = "txtNotes"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtNotes
            size = New System.Drawing.Size(72, 20)
            textBox4.Size = size
            Me.txtNotes.TabIndex = 38
            Me.txtNotes.Visible = False
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtQ
            location = New System.Drawing.Point(365, 38)
            textBox5.Location = location
            Me.txtQ.Name = "txtQ"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtQ
            size = New System.Drawing.Size(72, 20)
            textBox6.Size = size
            Me.txtQ.TabIndex = 37
            Me.txtQ.Visible = False
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtItemStatus
            location = New System.Drawing.Point(228, 64)
            textBox7.Location = location
            Me.txtItemStatus.Name = "txtItemStatus"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtItemStatus
            size = New System.Drawing.Size(72, 20)
            textBox8.Size = size
            Me.txtItemStatus.TabIndex = 42
            Me.txtItemStatus.Visible = False
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtDishNameArabic
            location = New System.Drawing.Point(239, 88)
            textBox9.Location = location
            Me.txtDishNameArabic.Name = "txtDishNameArabic"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtDishNameArabic
            size = New System.Drawing.Size(72, 20)
            textBox10.Size = size
            Me.txtDishNameArabic.TabIndex = 41
            Me.txtDishNameArabic.Visible = False
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtCategory
            location = New System.Drawing.Point(332, 64)
            textBox11.Location = location
            Me.txtCategory.Name = "txtCategory"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtCategory
            size = New System.Drawing.Size(72, 20)
            textBox12.Size = size
            Me.txtCategory.TabIndex = 40
            Me.txtCategory.Visible = False
            MyBase.AcceptButton = Me.btnOkay
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            MyBase.CancelButton = Me.btnCancel
            size = New System.Drawing.Size(516, 433)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.txtItemStatus)
            MyBase.Controls.Add(Me.txtDishNameArabic)
            MyBase.Controls.Add(Me.txtCategory)
            MyBase.Controls.Add(Me.txtNotes)
            MyBase.Controls.Add(Me.txtQ)
            MyBase.Controls.Add(Me.lblSet)
            MyBase.Controls.Add(Me.btn00)
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.btnX)
            MyBase.Controls.Add(Me.btnTA0)
            MyBase.Controls.Add(Me.btnDOT)
            MyBase.Controls.Add(Me.btnTA9)
            MyBase.Controls.Add(Me.btnTA8)
            MyBase.Controls.Add(Me.btnTA7)
            MyBase.Controls.Add(Me.btnTA5)
            MyBase.Controls.Add(Me.btnTA4)
            MyBase.Controls.Add(Me.txtQty)
            MyBase.Controls.Add(Me.btnOkay)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.btnTA6)
            MyBase.Controls.Add(Me.btnTA1)
            MyBase.Controls.Add(Me.btnTA3)
            MyBase.Controls.Add(Me.btnTA2)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmEnterQty"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Change Quantity"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
