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
    Public Class frmPizzaModifiersList
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference)

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpModifiers")>
        Private _flpModifiers As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTaxType")>
        Private _txtTaxType As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDone")>
        Private _btnDone As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove")>
        Private _btnRemove As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPizzaName")>
        Private _txtPizzaName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPizzaSize")>
        Private _txtPizzaSize As System.Windows.Forms.TextBox

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

        Friend Overridable Property flpModifiers As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpModifiers
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpModifiers = value
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

        Friend Overridable Property btnDone As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDone
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
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

        Friend Overridable Property btnRemove As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnRemove
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
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

        Friend Overridable Property txtPizzaName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPizzaName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPizzaName = value
            End Set
        End Property

        Friend Overridable Property txtPizzaSize As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPizzaSize
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPizzaSize = value
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
            MyBase.Hide()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPizzaModifiersList.__ENCList
                If RestaurantPOS14.frmPizzaModifiersList.__ENCList.Count = RestaurantPOS14.frmPizzaModifiersList.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPizzaModifiersList.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPizzaModifiersList.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPizzaModifiersList.__ENCList(num) = RestaurantPOS14.frmPizzaModifiersList.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPizzaModifiersList.__ENCList.RemoveRange(num, RestaurantPOS14.frmPizzaModifiersList.__ENCList.Count - num)
                    RestaurantPOS14.frmPizzaModifiersList.__ENCList.Capacity = RestaurantPOS14.frmPizzaModifiersList.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPizzaModifiersList.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub FillModifiers()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select distinct RTRIM(ModifierName),PizzaModifier.BackColor from PizzaModifier,PizzaMaster where PizzaMaster.Pizza_ID=PizzaModifier.PizzaID and PizzaName=@d1 and PizzaSize=@d2 order by 1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtPizzaName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtPizzaSize.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpModifiers.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim button As System.Windows.Forms.Button = New System.Windows.Forms.Button()
                    Dim t As String =(If(RestaurantPOS14.ModClasses.rdr.IsDBNull(0), "", Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))))
                    button.Text = t
                    button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim argb As Integer = 3978092
                    If Not RestaurantPOS14.ModClasses.rdr.IsDBNull(1) Then
                        Try
                            argb = CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(1)))))
                        Catch
                        End Try
                    End If

                    Dim backColor As System.Drawing.Color = System.Drawing.Color.FromArgb(argb)
                    button.BackColor = backColor
                    button.ForeColor = System.Drawing.Color.White
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    button.Width = 130
                    button.Height = 60
                    button.UseMnemonic = False
                    button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(button)
                    Me.flpModifiers.Controls.Add(button)
                    AddHandler button.Click, AddressOf Me.btnModifier_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.FillModifiers()
            Me.GetTaxType()
            Me.DataGridView1.Rows.Clear()
            Me.btnRemove.Enabled = False
        End Sub

        Private Sub btnModifier_Click(sender As Object, e As System.EventArgs)
            Try
                Dim text As String = CType(sender, System.Windows.Forms.Button).Text
                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(RestaurantPOS14.My.MyProject.Forms.frmPizzaPOS.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((0))).Value, text, TextCompare:=False), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(dataGridViewRow.Cells(CInt((10))).Value, "Modifier", TextCompare:=False))) Then
                        Call System.Windows.Forms.MessageBox.Show("Selected modifier is already added", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                        Return
                    End If
                Next

                For Each item As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(item.Cells(CInt((0))).Value, text, TextCompare:=False) Then
                        Call System.Windows.Forms.MessageBox.Show("Selected modifier is already added", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                        Return
                    End If
                Next

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "select PizzaModifier.Rate from PizzaModifier,PizzaMaster where PizzaMaster.Pizza_ID=PizzaModifier.PizzaID and PizzaName=@d1 and PizzaSize=@d2 and ModifierName=@d3"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtPizzaName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtPizzaSize.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    If RestaurantPOS14.ModClasses.rdr.IsDBNull(0) Then
                        Me.Rate = 0.0
                    Else
                        Me.Rate = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If
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
                    If RestaurantPOS14.ModClasses.rdr.IsDBNull(0) Then
                        Me.HSTPer = 0.0
                    Else
                        Me.HSTPer = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If
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
                Me.DataGridView1.Rows.Add(text, "", Me.Rate, 1, Me.Amount, Me.DiscountPer, Me.Discount, Me.HSTPer, Me.HST, Me.TotalAmount, "Modifier")
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

        Private Sub btnDone_Click(sender As Object, e As System.EventArgs)
            Try
                Try
                    If Me.DataGridView1.Rows.Count = 0 Then
                        Call System.Windows.Forms.MessageBox.Show("Sorry, No modifier is added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
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
            Catch ex2 As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex2.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
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

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPizzaModifiersList))
            Me.flpModifiers = New System.Windows.Forms.FlowLayoutPanel()
            Me.txtTaxType = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
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
            Me.btnDone = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.txtPizzaName = New System.Windows.Forms.TextBox()
            Me.txtPizzaSize = New System.Windows.Forms.TextBox()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.flpModifiers.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpModifiers.AutoScroll = True
            Me.flpModifiers.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.flpModifiers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpModifiers
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 196)
            flowLayoutPanel.Location = location
            Me.flpModifiers.Name = "flpModifiers"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpModifiers
            Dim size As System.Drawing.Size = New System.Drawing.Size(814, 520)
            flowLayoutPanel2.Size = size
            Me.flpModifiers.TabIndex = 4
            Dim textBox As System.Windows.Forms.TextBox = Me.txtTaxType
            location = New System.Drawing.Point(12, 24)
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
            Me.Label5.Text = "List of Modifiers"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            location = New System.Drawing.Point(3, 54)
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
            size = New System.Drawing.Size(404, 136)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 395
            Me.DataGridViewTextBoxColumn34.HeaderText = "Modifier Name"
            Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
            Me.DataGridViewTextBoxColumn34.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn34.Width = 300
            Me.Column2.HeaderText = "Size"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Visible = False
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
            Me.btnDone.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnDone.FlatAppearance.BorderSize = 0
            Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button As System.Windows.Forms.Button = Me.btnDone
            location = New System.Drawing.Point(413, 54)
            button.Location = location
            Me.btnDone.Name = "btnDone"
            Dim button2 As System.Windows.Forms.Button = Me.btnDone
            size = New System.Drawing.Size(89, 42)
            button2.Size = size
            Me.btnDone.TabIndex = 412
            Me.btnDone.Text = "Done"
            Me.btnDone.UseVisualStyleBackColor = False
            Me.btnReset.BackColor = System.Drawing.Color.Crimson
            Me.btnReset.FlatAppearance.BorderSize = 0
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button3 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(413, 148)
            button3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button4 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(89, 42)
            button4.Size = size
            Me.btnReset.TabIndex = 413
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
            Me.btnRemove.BackColor = System.Drawing.Color.Crimson
            Me.btnRemove.Enabled = False
            Me.btnRemove.FlatAppearance.BorderSize = 0
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button5 As System.Windows.Forms.Button = Me.btnRemove
            location = New System.Drawing.Point(413, 102)
            button5.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim button6 As System.Windows.Forms.Button = Me.btnRemove
            size = New System.Drawing.Size(89, 42)
            button6.Size = size
            Me.btnRemove.TabIndex = 417
            Me.btnRemove.Text = "Remove"
            Me.btnRemove.UseVisualStyleBackColor = False
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtPizzaName
            location = New System.Drawing.Point(71, 24)
            textBox3.Location = location
            Me.txtPizzaName.Name = "txtPizzaName"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtPizzaName
            size = New System.Drawing.Size(53, 20)
            textBox4.Size = size
            Me.txtPizzaName.TabIndex = 455
            Me.txtPizzaName.Visible = False
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtPizzaSize
            location = New System.Drawing.Point(130, 24)
            textBox5.Location = location
            Me.txtPizzaSize.Name = "txtPizzaSize"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtPizzaSize
            size = New System.Drawing.Size(53, 20)
            textBox6.Size = size
            Me.txtPizzaSize.TabIndex = 456
            Me.txtPizzaSize.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(817, 716)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.txtPizzaSize)
            MyBase.Controls.Add(Me.txtPizzaName)
            MyBase.Controls.Add(Me.txtTaxType)
            MyBase.Controls.Add(Me.btnRemove)
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.btnDone)
            MyBase.Controls.Add(Me.DataGridView1)
            MyBase.Controls.Add(Me.Label5)
            MyBase.Controls.Add(Me.flpModifiers)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmPizzaModifiersList"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Modifiers"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
