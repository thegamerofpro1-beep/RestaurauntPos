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
Imports CButtonLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmToppingsList1
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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDone")>
        Private _btnDone As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As CButtonLib.CButton

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove")>
        Private _btnRemove As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblPizzaSize")>
        Private _lblPizzaSize As System.Windows.Forms.Label

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

        Friend Overridable Property DataGridView1 As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DataGridView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.EventHandler = AddressOf Me.DataGridView1_Click
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.Click, value2
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.Click, value2
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

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmTables_Load
            Call RestaurantPOS14.frmToppingsList1.__ENCAddToList(Me)
            Me.UserButtons = New System.Collections.Generic.List(Of System.Windows.Forms.Button)()
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmToppingsList1.__ENCList
                If RestaurantPOS14.frmToppingsList1.__ENCList.Count = RestaurantPOS14.frmToppingsList1.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmToppingsList1.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmToppingsList1.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmToppingsList1.__ENCList(num) = RestaurantPOS14.frmToppingsList1.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmToppingsList1.__ENCList.RemoveRange(num, RestaurantPOS14.frmToppingsList1.__ENCList.Count - num)
                    RestaurantPOS14.frmToppingsList1.__ENCList.Capacity = RestaurantPOS14.frmToppingsList1.__ENCList.Count
                End If

                Call RestaurantPOS14.frmToppingsList1.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub FillToppingSize()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select distinct RTRIM(ToppingSize) from PizzaTopping where PizzaSize=@d1 order by 1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblPizzaSize.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpToppingSize.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim button As System.Windows.Forms.Button = New System.Windows.Forms.Button()
                    button.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim crimson As System.Drawing.Color = System.Drawing.Color.Crimson
                    button.BackColor = crimson
                    button.ForeColor = System.Drawing.Color.White
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    button.Width = 130
                    button.Height = 60
                    button.UseMnemonic = False
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
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(ToppingName),BackColor from PizzaTopping where ToppingSize=@d1 and PizzaSize=@d2 order by 1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblPizzaSize.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
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
                    button.UseMnemonic = False
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
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Distinct RTRIM(ToppingName) from PizzaTopping order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
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
                    button.UseMnemonic = False
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
            Me.FillToppingSize()
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
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((0))).Value, text, TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((1))).Value, Me.lblToppingSize.Text, TextCompare:=False))) Then
                        Call System.Windows.Forms.MessageBox.Show("Selected topping of " & Me.lblToppingSize.Text & " size is already added", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                        Return
                    End If
                Next

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Rate FROM PizzaTopping WHERE ToppingName=@d1 and PizzaSize=@d2 and ToppingSize=@d3"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblPizzaSize.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.lblToppingSize.Text)
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
                Me.DataGridView1.Rows.Add(text, Me.lblToppingSize.Text, 0, 1, 0, 0, 0, Me.HSTPer, 0, 0, "Topping")
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

        Public Sub Reset()
            Me.FillToppingSize()
            Me.FillToppings()
            Me.GetTaxType()
            Me.lblToppingSize.Text = ""
            Me.DataGridView1.Rows.Clear()
            Me.btnRemove.Enabled = False
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnDone_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.DataGridView1.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry, No topping is added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((0))).Value), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((1))).Value), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((2))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((3))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((4))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((5))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((6))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((7))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((8))).Value)), Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((9))).Value)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(CInt((10))).Value))
                Next

                Dim value As Double = RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.GrandTotal_Food()
                value = System.Math.Round(value, 2)
                RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                MyBase.Hide()
                Call RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.Show()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnRemove_Click(sender As Object, e As System.EventArgs)
            Try
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In Me.DataGridView1.SelectedRows
                    Me.DataGridView1.Rows.Remove(dataGridViewRow)
                Next

                Me.btnRemove.Enabled = False
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DataGridView1_Click(sender As Object, e As System.EventArgs)
            If Me.DataGridView1.Rows.Count > 0 Then
                Me.btnRemove.Enabled = True
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
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmToppingsList1))
            Me.flpToppings = New System.Windows.Forms.FlowLayoutPanel()
            Me.txtTaxType = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.flpToppingSize = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.lblToppingSize = New System.Windows.Forms.Label()
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
            Me.btnDone = New CButtonLib.CButton()
            Me.btnReset = New CButtonLib.CButton()
            Me.btnRemove = New CButtonLib.CButton()
            Me.lblPizzaSize = New System.Windows.Forms.Label()
            Me.flpToppings.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.flpToppings.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpToppings.AutoScroll = True
            Me.flpToppings.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.flpToppings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.flpToppings.Controls.Add(Me.txtTaxType)
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpToppings
            Dim location As System.Drawing.Point = New System.Drawing.Point(156, 196)
            flowLayoutPanel.Location = location
            Me.flpToppings.Name = "flpToppings"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpToppings
            Dim size As System.Drawing.Size = New System.Drawing.Size(661, 520)
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
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
            Me.Label5.Text = "List of Free Toppings"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.flpToppingSize.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
            Me.flpToppingSize.AutoScroll = True
            Me.flpToppingSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.flpToppingSize.ForeColor = System.Drawing.Color.White
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
            Me.Label32.ForeColor = System.Drawing.Color.White
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
            Me.lblToppingSize.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.lblToppingSize
            location = New System.Drawing.Point(4, 75)
            label5.Location = location
            Me.lblToppingSize.Name = "lblToppingSize"
            Dim label6 As System.Windows.Forms.Label = Me.lblToppingSize
            size = New System.Drawing.Size(18, 21)
            label6.Size = size
            Me.lblToppingSize.TabIndex = 393
            Me.lblToppingSize.Text = ".."
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
            location = New System.Drawing.Point(156, 54)
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
            size = New System.Drawing.Size(520, 136)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 395
            Me.DataGridViewTextBoxColumn34.HeaderText = "Topping Name"
            Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
            Me.DataGridViewTextBoxColumn34.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn34.Width = 300
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
            Me.DataGridViewTextBoxColumn36.Visible = False
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn37.DefaultCellStyle = dataGridViewCellStyle8
            Me.DataGridViewTextBoxColumn37.HeaderText = "Amount"
            Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
            Me.DataGridViewTextBoxColumn37.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn37.Visible = False
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn38.DefaultCellStyle = dataGridViewCellStyle9
            Me.DataGridViewTextBoxColumn38.HeaderText = "Discount %"
            Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
            Me.DataGridViewTextBoxColumn38.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn38.Visible = False
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn39.DefaultCellStyle = dataGridViewCellStyle10
            Me.DataGridViewTextBoxColumn39.HeaderText = "Discount"
            Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
            Me.DataGridViewTextBoxColumn39.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn39.Visible = False
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn42.DefaultCellStyle = dataGridViewCellStyle11
            Me.DataGridViewTextBoxColumn42.HeaderText = "VAT %"
            Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
            Me.DataGridViewTextBoxColumn42.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn42.Visible = False
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn43.DefaultCellStyle = dataGridViewCellStyle12
            Me.DataGridViewTextBoxColumn43.HeaderText = "VAT Amt"
            Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
            Me.DataGridViewTextBoxColumn43.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn43.Visible = False
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.DataGridViewTextBoxColumn44.DefaultCellStyle = dataGridViewCellStyle13
            Me.DataGridViewTextBoxColumn44.HeaderText = "Total Amt."
            Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
            Me.DataGridViewTextBoxColumn44.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn44.Visible = False
            Me.Column1.HeaderText = "Item Type"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.btnDone.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnDone.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnDone.ColorFillBlend = cBlendItems
            Me.btnDone.Corners.All = 3
            Me.btnDone.Corners.LowerLeft = 3
            Me.btnDone.Corners.LowerRight = 3
            Me.btnDone.Corners.UpperLeft = 3
            Me.btnDone.Corners.UpperRight = 3
            Me.btnDone.DesignerSelected = False
            Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnDone.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnDone
            location = New System.Drawing.Point(682, 54)
            cButton.Location = location
            Me.btnDone.Name = "btnDone"
            Dim cButton2 As CButtonLib.CButton = Me.btnDone
            size = New System.Drawing.Size(89, 42)
            cButton2.Size = size
            Me.btnDone.TabIndex = 412
            Me.btnDone.Text = "Done"
            Me.btnReset.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnReset.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnReset.ColorFillBlend = cBlendItems2
            Me.btnReset.Corners.All = 3
            Me.btnReset.Corners.LowerLeft = 3
            Me.btnReset.Corners.LowerRight = 3
            Me.btnReset.Corners.UpperLeft = 3
            Me.btnReset.Corners.UpperRight = 3
            Me.btnReset.DesignerSelected = False
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnReset.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnReset
            location = New System.Drawing.Point(682, 148)
            cButton3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim cButton4 As CButtonLib.CButton = Me.btnReset
            size = New System.Drawing.Size(89, 42)
            cButton4.Size = size
            Me.btnReset.TabIndex = 413
            Me.btnReset.Text = "Reset"
            Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnRemove.BorderShow = False
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnRemove.ColorFillBlend = cBlendItems3
            Me.btnRemove.Corners.All = 3
            Me.btnRemove.Corners.LowerLeft = 3
            Me.btnRemove.Corners.LowerRight = 3
            Me.btnRemove.Corners.UpperLeft = 3
            Me.btnRemove.Corners.UpperRight = 3
            Me.btnRemove.DesignerSelected = False
            Me.btnRemove.Enabled = False
            Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnRemove.ImageIndex = 0
            Dim cButton5 As CButtonLib.CButton = Me.btnRemove
            location = New System.Drawing.Point(682, 101)
            cButton5.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim cButton6 As CButtonLib.CButton = Me.btnRemove
            size = New System.Drawing.Size(89, 42)
            cButton6.Size = size
            Me.btnRemove.TabIndex = 417
            Me.btnRemove.Text = "Remove"
            Me.lblPizzaSize.AutoSize = True
            Me.lblPizzaSize.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblPizzaSize.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.lblPizzaSize
            location = New System.Drawing.Point(125, 75)
            label7.Location = location
            Me.lblPizzaSize.Name = "lblPizzaSize"
            Dim label8 As System.Windows.Forms.Label = Me.lblPizzaSize
            size = New System.Drawing.Size(18, 21)
            label8.Size = size
            Me.lblPizzaSize.TabIndex = 419
            Me.lblPizzaSize.Text = ".."
            Me.lblPizzaSize.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(817, 716)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.lblPizzaSize)
            MyBase.Controls.Add(Me.btnRemove)
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.btnDone)
            MyBase.Controls.Add(Me.DataGridView1)
            MyBase.Controls.Add(Me.lblToppingSize)
            MyBase.Controls.Add(Me.Label32)
            MyBase.Controls.Add(Me.flpToppingSize)
            MyBase.Controls.Add(Me.Label5)
            MyBase.Controls.Add(Me.flpToppings)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmToppingsList1"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Toppings"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.flpToppings.ResumeLayout(False)
            Me.flpToppings.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
