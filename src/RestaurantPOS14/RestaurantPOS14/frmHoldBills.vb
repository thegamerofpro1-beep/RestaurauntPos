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
    Public Class frmHoldBills
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property DataGridView1 As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.DataGridView1_MouseClick
                Dim value3 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.DataGridView1_RowPostPaint
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.MouseClick, value2
                    RemoveHandler Me._DataGridView1.RowPostPaint, value3
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.MouseClick, value2
                    AddHandler Me._DataGridView1.RowPostPaint, value3
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmHoldBills.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmHoldBills.__ENCList
                If RestaurantPOS14.frmHoldBills.__ENCList.Count = RestaurantPOS14.frmHoldBills.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmHoldBills.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmHoldBills.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmHoldBills.__ENCList(num) = RestaurantPOS14.frmHoldBills.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmHoldBills.__ENCList.RemoveRange(num, RestaurantPOS14.frmHoldBills.__ENCList.Count - num)
                    RestaurantPOS14.frmHoldBills.__ENCList.Capacity = RestaurantPOS14.frmHoldBills.__ENCList.Count
                End If

                Call RestaurantPOS14.frmHoldBills.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub GetData()
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(HoldID),Date,RTRIM(UserID),RTRIM(TaxType),RTRIM(CName),RTRIM(CNo) from HoldBill where BillType='Take Away' order by 2", RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    Me.DataGridView1.Rows.Clear()
                    While RestaurantPOS14.ModClasses.rdr.Read()
                        Me.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)))
                    End While

                    RestaurantPOS14.ModClasses.con.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(HoldID),Date,RTRIM(UserID),RTRIM(TaxType),RTRIM(CName),RTRIM(CNo) from HoldBill where BillType='Express' order by 2", RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    Me.DataGridView1.Rows.Clear()
                    While RestaurantPOS14.ModClasses.rdr.Read()
                        Me.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)))
                    End While

                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 AndAlso Me.DataGridView1.Rows.Count > 0 Then
                    If Me.DataGridView1.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.DataGridView1.SelectedRows(0)
                    MyBase.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Reset2()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.SelectedIndex = 2
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtHoldID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTaxType.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTACustomerName.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTAContactNo.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSubTotal1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModFunc.GetHoldBillTotal(dataGridViewRow.Cells(CInt((0))).Value.ToString()))
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModFunc.GetHoldBillTotal(dataGridViewRow.Cells(CInt((0))).Value.ToString()))
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModFunc.GetHoldBillTotal(dataGridViewRow.Cells(CInt((0))).Value.ToString()))
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(Dish),RTRIM(Rate),RTRIM(Quantity),RTRIM(Amount),RTRIM(DiscountPer), RTRIM(DiscountAmount), RTRIM(STPer), RTRIM(STAmount), RTRIM(VATPer), RTRIM(VATAmount),SCPer,SCAmount,RTRIM(TotalAmount),RTRIM(Notes),RTRIM(Category),RTRIM(DishNameArabic) from HoldBill INNER JOIN HoldItems ON HoldBill.HoldID=HoldItems.BillID where HoldID=@d1 order by Dish", RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", dataGridViewRow.Cells(CInt((0))).Value.ToString())
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows.Clear()
                    While RestaurantPOS14.ModClasses.rdr.Read()
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), 0, System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)))
                    End While

                    RestaurantPOS14.ModClasses.con.Close()
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(Dish),RTRIM(Rate),RTRIM(Quantity),RTRIM(Amount),RTRIM(DiscountPer), RTRIM(DiscountAmount), RTRIM(STPer), RTRIM(STAmount), RTRIM(VATPer), RTRIM(VATAmount),SCPer,SCAmount,RTRIM(TotalAmount),RTRIM(Notes),RTRIM(Category),RTRIM(DishNameArabic) from HoldBill INNER JOIN HoldItems ON HoldBill.HoldID=HoldItems.BillID where HoldID=@d1 order by Dish", RestaurantPOS14.ModClasses.con)
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", dataGridViewRow.Cells(CInt((0))).Value.ToString())
                        Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                        Dim screen As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location As System.Drawing.Point = screen.Bounds.Location
                        Dim p As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj.Location = location + CType(p, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Clear()
                        While sqlDataReader.Read()
                            Dim screen2 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                            RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                            Dim obj2 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                            Dim location2 As System.Drawing.Point = screen2.Bounds.Location
                            p = New System.Drawing.Point(100, 100)
                            obj2.Location = location2 + CType(p, System.Drawing.Size)
                            Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.AddItem(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader(12)))
                            Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                        End While

                        RestaurantPOS14.ModClasses.con.Close()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CalcItemsAndQty()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.SelectedIndex = 2
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) <> 0 OrElse Me.DataGridView1.Rows.Count <= 0 Then
                    Return
                End If

                If Me.DataGridView1.SelectedRows.Count = 0 Then Return
                Dim dataGridViewRow2 As System.Windows.Forms.DataGridViewRow = Me.DataGridView1.SelectedRows(0)
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Reset4()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.SelectedIndex = 4
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtHoldID.Text = dataGridViewRow2.Cells(CInt((0))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTaxType.Text = dataGridViewRow2.Cells(CInt((3))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBCustomerName.Text = dataGridViewRow2.Cells(CInt((4))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBContactNo.Text = dataGridViewRow2.Cells(CInt((5))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModFunc.GetHoldBillTotal(dataGridViewRow2.Cells(CInt((0))).Value.ToString()))
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModFunc.GetHoldBillTotal(dataGridViewRow2.Cells(CInt((0))).Value.ToString()))
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(Dish),RTRIM(Rate),RTRIM(Quantity),RTRIM(Amount),RTRIM(DiscountPer), RTRIM(DiscountAmount), RTRIM(STPer), RTRIM(STAmount), RTRIM(VATPer), RTRIM(VATAmount),SCPer,SCAmount,RTRIM(TotalAmount),RTRIM(Notes),RTRIM(Category),RTRIM(DishNameArabic) from HoldBill INNER JOIN HoldItems ON HoldBill.HoldID=HoldItems.BillID where HoldID=@d1 order by Dish", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", dataGridViewRow2.Cells(CInt((0))).Value.ToString())
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), 0, System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(Dish),RTRIM(Rate),RTRIM(Quantity),RTRIM(Amount),RTRIM(DiscountPer), RTRIM(DiscountAmount), RTRIM(STPer), RTRIM(STAmount), RTRIM(VATPer), RTRIM(VATAmount),SCPer,SCAmount,RTRIM(TotalAmount),RTRIM(Notes),RTRIM(Category),RTRIM(DishNameArabic) from HoldBill INNER JOIN HoldItems ON HoldBill.HoldID=HoldItems.BillID where HoldID=@d1 order by Dish", RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", dataGridViewRow2.Cells(CInt((0))).Value.ToString())
                    Dim sqlDataReader2 As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    Dim screen3 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                    RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                    Dim obj3 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                    Dim location3 As System.Drawing.Point = screen3.Bounds.Location
                    Dim p2 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                    obj3.Location = location3 + CType(p2, System.Drawing.Size)
                    Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Clear()
                    While sqlDataReader2.Read()
                        Dim screen4 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj4 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location4 As System.Drawing.Point = screen4.Bounds.Location
                        p2 = New System.Drawing.Point(100, 100)
                        obj4.Location = location4 + CType(p2, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.AddItem(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader2(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader2(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader2(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader2(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader2(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(sqlDataReader2(12)))
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End While

                    RestaurantPOS14.ModClasses.con.Close()
                End If

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CalcItemsAndQty()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.SelectedIndex = 4
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DataGridView1_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
            Dim text As String =(e.RowIndex + 1).ToString()
            Dim sizeF As System.Drawing.SizeF = e.Graphics.MeasureString(text, MyBase.Font)
            If Me.DataGridView1.RowHeadersWidth < System.Convert.ToInt32(sizeF.Width + 20F) Then
                Me.DataGridView1.RowHeadersWidth = System.Convert.ToInt32(sizeF.Width + 20F)
            End If

            Dim controlText As System.Drawing.Brush = System.Drawing.SystemBrushes.ControlText
            e.Graphics.DrawString(text, MyBase.Font, controlText, e.RowBounds.Location.X + 15, CSng(e.RowBounds.Location.Y) + (CSng(e.RowBounds.Height) - sizeF.Height) / 2F)
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmHoldBills))
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.lblSet = New System.Windows.Forms.Label()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.DataGridView1.ColumnHeadersHeight = 24
            Me.DataGridView1.Columns.AddRange(Me.Column1, Me.Column5, Me.Column4, Me.Column6, Me.Column2, Me.Column7)
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            Dim location As System.Drawing.Point = New System.Drawing.Point(1, 53)
            dataGridView.Location = location
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.DataGridView1.RowTemplate.Height = 30
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            Dim size As System.Drawing.Size = New System.Drawing.Size(834, 320)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 11
            Me.Column1.HeaderText = "Hold ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            dataGridViewCellStyle6.Format = "dd/MM/yyyy hh:mm:ss tt"
            Me.Column5.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column5.HeaderText = "Date"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column5.Width = 200
            Me.Column4.HeaderText = "Operator ID"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column4.Width = 165
            Me.Column6.HeaderText = "Tax Type"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column6.Visible = False
            Me.Column2.HeaderText = "Customer Name"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Width = 150
            Me.Column7.HeaderText = "Contact No."
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column7.Width = 190
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.Controls.Add(Me.Label2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(1, 1)
            panel.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(777, 46)
            panel2.Size = size
            Me.Panel2.TabIndex = 387
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(358, 8)
            label.Location = location
            Me.Label2.Name = "Label2"
            Dim label2 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(117, 32)
            label2.Size = size
            Me.Label2.TabIndex = 0
            Me.Label2.Text = "Hold Bills"
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(784, 2)
            button.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button2 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 49)
            button2.Size = size
            Me.btnCancel.TabIndex = 388
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Me.lblSet.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(598, 149)
            label3.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label4 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(0, 13)
            label4.Size = size
            Me.lblSet.TabIndex = 389
            Me.lblSet.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(837, 374)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.lblSet)
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Panel2)
            MyBase.Controls.Add(Me.DataGridView1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmHoldBills"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Hold Bills"
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
