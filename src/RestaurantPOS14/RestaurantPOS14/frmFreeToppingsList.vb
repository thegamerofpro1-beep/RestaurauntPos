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
    Public Class frmFreeToppingsList
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpToppings")>
        Private _flpToppings As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTaxType")>
        Private _txtTaxType As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpToppingSize")>
        Private _flpToppingSize As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label32")>
        Private _Label32 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblToppingSize")>
        Private _lblToppingSize As System.Windows.Forms.Label

        Private UserButtons As System.Collections.Generic.List(Of System.Windows.Forms.Button)

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

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property flpToppings As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpToppings
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpToppings = value
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
                Me._Timer1 = value
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

        Friend Overridable Property flpToppingSize As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpToppingSize
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpToppingSize = value
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

        Friend Overridable Property lblToppingSize As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblToppingSize
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblToppingSize = value
            End Set
        End Property

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmTables_Load
            Call RestaurantPOS14.frmFreeToppingsList.__ENCAddToList(Me)
            Me.UserButtons = New System.Collections.Generic.List(Of System.Windows.Forms.Button)()
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmFreeToppingsList.__ENCList
                If RestaurantPOS14.frmFreeToppingsList.__ENCList.Count = RestaurantPOS14.frmFreeToppingsList.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmFreeToppingsList.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmFreeToppingsList.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmFreeToppingsList.__ENCList(num) = RestaurantPOS14.frmFreeToppingsList.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmFreeToppingsList.__ENCList.RemoveRange(num, RestaurantPOS14.frmFreeToppingsList.__ENCList.Count - num)
                    RestaurantPOS14.frmFreeToppingsList.__ENCList.Capacity = RestaurantPOS14.frmFreeToppingsList.__ENCList.Count
                End If

                Call RestaurantPOS14.frmFreeToppingsList.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub FillPizzaSize()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select distinct RTRIM(Size) from PizzaSize,PizzaTopping where PizzaSize.Size=PizzaTopping.PizzaSize order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpToppingSize.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim button As System.Windows.Forms.Button = New System.Windows.Forms.Button()
                    button.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim steelBlue As System.Drawing.Color = System.Drawing.Color.SteelBlue
                    button.BackColor = steelBlue
                    button.ForeColor = System.Drawing.Color.White
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    button.Width = 130
                    button.Height = 60
                    button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(button)
                    Me.flpToppingSize.Controls.Add(button)
                    AddHandler button.Click, AddressOf Me.btnSize_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSize_Click(sender As Object, e As System.EventArgs)
            Try
                Dim text As String = CType(sender, System.Windows.Forms.Button).Text.Trim()
                Me.lblToppingSize.Text = text
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(ToppingName),BackColor from PizzaTopping where PizzaSize=@d1 order by 1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpToppings.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim button As System.Windows.Forms.Button = New System.Windows.Forms.Button()
                    button.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim backColor As System.Drawing.Color = System.Drawing.Color.FromArgb(CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(1))))))
                    button.BackColor = backColor
                    button.ForeColor = System.Drawing.Color.White
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    button.Width = 130
                    button.Height = 60
                    button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(button)
                    Me.flpToppings.Controls.Add(button)
                    AddHandler button.Click, AddressOf Me.btnTopping_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub FillToppings()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Distinct RTRIM(ToppingName) from PizzaTopping order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpToppings.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim button As System.Windows.Forms.Button = New System.Windows.Forms.Button()
                    button.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim backColor As System.Drawing.Color = System.Drawing.Color.FromArgb(102, 106, 105)
                    button.BackColor = backColor
                    button.ForeColor = System.Drawing.Color.White
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    button.Width = 130
                    button.Height = 60
                    button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(button)
                    Me.flpToppings.Controls.Add(button)
                    AddHandler button.Click, AddressOf Me.btnTopping_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmTables_Load(sender As Object, e As System.EventArgs)
            Me.lblToppingSize.Text = ""
            Me.FillPizzaSize()
            Me.FillToppings()
            Me.GetTaxType()
        End Sub

        Private Sub btnTopping_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblToppingSize.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please select topping size", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                Dim text As String = CType(sender, System.Windows.Forms.Button).Text
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((0))).Value, text, TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((1))).Value, Me.lblToppingSize.Text, TextCompare:=False)), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((10))).Value, "Topping", TextCompare:=False))) Then
                        Call System.Windows.Forms.MessageBox.Show("Selected topping of " & Me.lblToppingSize.Text & " size is already added", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                        Return
                    End If
                Next

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Rate FROM PizzaTopping WHERE ToppingName=@d1 and PizzaSize=@d2"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblToppingSize.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Rate = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
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
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Discount FROM PizzaMaster WHERE PizzaName=@d1 and PizzaSize=@d2"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.lblPizzaName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.lblPizzaSize.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.DiscountPer = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
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

                Me.Compute()
                Call RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.DataGridView1.Rows.Add(text, Me.lblToppingSize.Text, 0, 1, 0, 0, 0, Me.HSTPer, 0, 0, "Topping")
                Dim value As Double = RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.GrandTotal_Food()
                value = System.Math.Round(value, 2)
                RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.Show()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
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
                    Me.txtTaxType.Text = ""
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmFreeToppingsList))
            Me.flpToppings = New System.Windows.Forms.FlowLayoutPanel()
            Me.txtTaxType = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.flpToppingSize = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.lblToppingSize = New System.Windows.Forms.Label()
            Me.flpToppings.SuspendLayout()
            MyBase.SuspendLayout()
            Me.flpToppings.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpToppings.AutoScroll = True
            Me.flpToppings.BackColor = System.Drawing.Color.White
            Me.flpToppings.Controls.Add(Me.txtTaxType)
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpToppings
            Dim location As System.Drawing.Point = New System.Drawing.Point(156, 54)
            flowLayoutPanel.Location = location
            Me.flpToppings.Name = "flpToppings"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpToppings
            Dim size As System.Drawing.Size = New System.Drawing.Size(661, 662)
            flowLayoutPanel2.Size = size
            Me.flpToppings.TabIndex = 4
            Dim textBox As System.Windows.Forms.TextBox = Me.txtTaxType
            location = New System.Drawing.Point(3, 3)
            textBox.Location = location
            Me.txtTaxType.Name = "txtTaxType"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtTaxType
            size = New System.Drawing.Size(53, 20)
            textBox2.Size = size
            Me.txtTaxType.TabIndex = 454
            Me.txtTaxType.Visible = False
            Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(1, 1)
            label.Location = location
            Me.Label5.Name = "Label5"
            Dim label2 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(816, 50)
            label2.Size = size
            Me.Label5.TabIndex = 390
            Me.Label5.Text = "List of Toppings"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.flpToppingSize.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.flpToppingSize.AutoScroll = True
            Dim flowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel = Me.flpToppingSize
            location = New System.Drawing.Point(5, 99)
            flowLayoutPanel3.Location = location
            Me.flpToppingSize.Name = "flpToppingSize"
            Dim flowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel = Me.flpToppingSize
            size = New System.Drawing.Size(145, 617)
            flowLayoutPanel4.Size = size
            Me.flpToppingSize.TabIndex = 391
            Me.Label32.AutoSize = True
            Me.Label32.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label32.ForeColor = System.Drawing.Color.Black
            Dim label3 As System.Windows.Forms.Label = Me.Label32
            location = New System.Drawing.Point(4, 54)
            label3.Location = location
            Me.Label32.Name = "Label32"
            Dim label4 As System.Windows.Forms.Label = Me.Label32
            size = New System.Drawing.Size(115, 21)
            label4.Size = size
            Me.Label32.TabIndex = 392
            Me.Label32.Text = "Topping Size : "
            Me.lblToppingSize.AutoSize = True
            Me.lblToppingSize.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblToppingSize.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label5 As System.Windows.Forms.Label = Me.lblToppingSize
            location = New System.Drawing.Point(4, 75)
            label5.Location = location
            Me.lblToppingSize.Name = "lblToppingSize"
            Dim label6 As System.Windows.Forms.Label = Me.lblToppingSize
            size = New System.Drawing.Size(18, 21)
            label6.Size = size
            Me.lblToppingSize.TabIndex = 393
            Me.lblToppingSize.Text = ".."
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(817, 716)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.lblToppingSize)
            MyBase.Controls.Add(Me.Label32)
            MyBase.Controls.Add(Me.flpToppingSize)
            MyBase.Controls.Add(Me.Label5)
            MyBase.Controls.Add(Me.flpToppings)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmFreeToppingsList"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Toppings"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.flpToppings.ResumeLayout(False)
            Me.flpToppings.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
