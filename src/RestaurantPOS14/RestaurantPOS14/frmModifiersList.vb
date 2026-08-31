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
    Public Class frmModifiersList
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpModifiers")>
        Private _flpModifiers As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label32")>
        Private _Label32 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblItemName")>
        Private _lblItemName As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRemove")>
        Private _btnRemove As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDone")>
        Private _btnDone As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ToolTip1")>
        Private _ToolTip1 As System.Windows.Forms.ToolTip

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblTotalRate")>
        Private _lblTotalRate As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCategory")>
        Private _txtCategory As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtNotes")>
        Private _txtNotes As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTempQD")>
        Private _txtTempQD As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblItemRate")>
        Private _lblItemRate As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn34")>
        Private _DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridViewTextBoxColumn35")>
        Private _DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDishNameArabic")>
        Private _txtDishNameArabic As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtItemStatus")>
        Private _txtItemStatus As System.Windows.Forms.TextBox

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

        Private ItemName As String

        Private ModifierName As String

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

        Friend Overridable Property lblItemName As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblItemName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblItemName = value
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

        Friend Overridable Property lblTotalRate As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblTotalRate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblTotalRate = value
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

        Friend Overridable Property txtNotes As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtNotes
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtNotes = value
            End Set
        End Property

        Friend Overridable Property txtTempQD As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTempQD
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTempQD = value
            End Set
        End Property

        Friend Overridable Property lblItemRate As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblItemRate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblItemRate = value
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

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmPizzaPOS_Load
            Call RestaurantPOS14.frmModifiersList.__ENCAddToList(Me)
            Me.UserButtons = New System.Collections.Generic.List(Of System.Windows.Forms.Button)()
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmModifiersList.__ENCList
                If RestaurantPOS14.frmModifiersList.__ENCList.Count = RestaurantPOS14.frmModifiersList.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmModifiersList.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmModifiersList.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmModifiersList.__ENCList(num) = RestaurantPOS14.frmModifiersList.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmModifiersList.__ENCList.RemoveRange(num, RestaurantPOS14.frmModifiersList.__ENCList.Count - num)
                    RestaurantPOS14.frmModifiersList.__ENCList.Capacity = RestaurantPOS14.frmModifiersList.__ENCList.Count
                End If

                Call RestaurantPOS14.frmModifiersList.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Function ModifierRate() As Double
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

        Public Sub FillModifiers()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(ModifierName),BackColor,MIM_ID from Modifiers where Item=@d1 order by 3")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblItemName.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpModifiers.Controls.Clear()
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
                    Me.flpModifiers.Controls.Add(button)
                    AddHandler button.Click, AddressOf Me.btnModifier_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.btnRemove.Enabled = False
            Me.DataGridView1.Rows.Clear()
            Me.ItemName = ""
        End Sub

        Private Sub frmPizzaPOS_Load(sender As Object, e As System.EventArgs)
            Me.FillModifiers()
            Me.DisableHSBar()
        End Sub

        Public Sub DisableHSBar()
            Me.flpModifiers.HorizontalScroll.Maximum = 0
            Me.flpModifiers.AutoScroll = False
            Me.flpModifiers.VerticalScroll.Visible = False
            Me.flpModifiers.AutoScroll = True
        End Sub

        Private Sub btnSize_Click(sender As Object, e As System.EventArgs)
        End Sub

        Private Sub btnModifier_Click(sender As Object, e As System.EventArgs)
            Try
                Dim text As String = CType(sender, System.Windows.Forms.Button).Text
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Rate FROM Modifiers WHERE Item=@d2 and ModifierName=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblItemName.Text)
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

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dataGridViewRow.Cells(CInt((0))).Value.ToString(), text, TextCompare:=False) = 0 Then
                        dataGridViewRow.Cells(CInt((0))).Value = text
                        Dim dataGridViewCell As System.Windows.Forms.DataGridViewCell = dataGridViewRow.Cells(2)
                        dataGridViewCell.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(dataGridViewCell.Value, Me.Rate)
                        Dim dataGridViewCell2 As System.Windows.Forms.DataGridViewCell = dataGridViewRow.Cells(1)
                        dataGridViewCell2.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(dataGridViewCell2.Value, 1)
                        Return
                    End If
                Next

                Me.DataGridView1.Rows.Add(text, 1, Me.Rate)
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

        Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Me.DataGridView1.Rows.Count > 0 Then
                Me.btnRemove.Enabled = True
            End If
        End Sub

        Private Sub btnDone_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.DataGridView1.Rows.Count = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry,No modifier added to grid", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    Me.ModifierName = Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(CObj((Me.ModifierName & Global.Microsoft.VisualBasic.Constants.vbCrLf)), CObj((dataGridViewRow.Cells(CInt((0))).Value))))), CObj(("("))))), CObj((dataGridViewRow.Cells(CInt((1))).Value))))), CObj((")"))).ToString().Trim()
                Next

                If Me.DataGridView1.Rows.Count > 0 Then
                    Me.ItemName = Me.lblItemName.Text & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Add :" & Me.ModifierName
                Else
                    Me.ItemName = Me.lblItemName.Text.Trim()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "KOT", TextCompare:=False) = 0 Then
                    If RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows.Count > 0 Then
                        Me.lblTotalRate.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblItemRate.Text) + Me.ModifierRate())
                        Dim dataGridViewRow2 As System.Windows.Forms.DataGridViewRow = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.SelectedRows(0)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text = dataGridViewRow2.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblTotalRate.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text = dataGridViewRow2.Cells(CInt((2))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text = dataGridViewRow2.Cells(CInt((3))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountPer_Food.Text = dataGridViewRow2.Cells(CInt((4))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountAmount_Food.Text = dataGridViewRow2.Cells(CInt((5))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxPer_Food.Text = dataGridViewRow2.Cells(CInt((6))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxAmount_Food.Text = dataGridViewRow2.Cells(CInt((7))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = dataGridViewRow2.Cells(CInt((8))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text = dataGridViewRow2.Cells(CInt((9))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCPer.Text = dataGridViewRow2.Cells(CInt((10))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCAmount.Text = dataGridViewRow2.Cells(CInt((11))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text = dataGridViewRow2.Cells(CInt((12))).Value.ToString()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Dim rowIndex As Integer = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.CurrentCell.RowIndex
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows.RemoveAt(rowIndex)
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.RemoveAt(rowIndex)
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows.Add(Me.ItemName, Microsoft.VisualBasic.Conversion.Val(Me.lblTotalRate.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCPer.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCAmount.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), Me.txtNotes.Text, Microsoft.VisualBasic.Conversion.Val(Me.txtTempQD.Text), Me.txtCategory.Text, Me.txtDishNameArabic.Text, Me.txtItemStatus.Text)
                    Dim value As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food()
                    value = System.Math.Round(value, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Me.ItemName)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text)), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location As System.Drawing.Point = screen.Bounds.Location
                        Dim p As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj.Location = location + CType(p, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Add(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H1()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.ClearSelection()
                    Me.lblSet.Text = ""
                    Me.ItemName = ""
                    Me.ModifierName = ""
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                    If RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows.Count > 0 Then
                        Me.lblTotalRate.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblItemRate.Text) + Me.ModifierRate())
                        Dim dataGridViewRow3 As System.Windows.Forms.DataGridViewRow = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.SelectedRows(0)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text = dataGridViewRow3.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblTotalRate.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text = dataGridViewRow3.Cells(CInt((2))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text = dataGridViewRow3.Cells(CInt((3))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountPer_Food.Text = dataGridViewRow3.Cells(CInt((4))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountAmount_Food.Text = dataGridViewRow3.Cells(CInt((5))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxPer_Food.Text = dataGridViewRow3.Cells(CInt((6))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxAmount_Food.Text = dataGridViewRow3.Cells(CInt((7))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = dataGridViewRow3.Cells(CInt((8))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text = dataGridViewRow3.Cells(CInt((9))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCPer.Text = dataGridViewRow3.Cells(CInt((10))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCAmount.Text = dataGridViewRow3.Cells(CInt((11))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text = dataGridViewRow3.Cells(CInt((12))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTempDiscountPer.Text = dataGridViewRow3.Cells(CInt((14))).Value.ToString()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Dim rowIndex2 As Integer = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.CurrentCell.RowIndex
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows.RemoveAt(rowIndex2)
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.RemoveAt(rowIndex2)
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.Rows.Add(Me.ItemName, Microsoft.VisualBasic.Conversion.Val(Me.lblTotalRate.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCPer.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCAmount.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), Me.txtNotes.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTempDiscountPer.Text), Me.txtCategory.Text, Me.txtDishNameArabic.Text)
                    Dim value2 As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food3()
                    value2 = System.Math.Round(value2, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSubTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value2)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Calc2()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Me.ItemName)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text)), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen2 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj2 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location2 As System.Drawing.Point = screen2.Bounds.Location
                        Dim p2 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj2.Location = location2 + CType(p2, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Add(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance2.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H3()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear3()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView4.ClearSelection()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtHDDiscountPer.Text = Me.txtTempQD.Text
                    Me.lblSet.Text = ""
                    Me.ItemName = ""
                    Me.ModifierName = ""
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                    If RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows.Count > 0 Then
                        Me.lblTotalRate.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblItemRate.Text) + Me.ModifierRate())
                        Dim dataGridViewRow4 As System.Windows.Forms.DataGridViewRow = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.SelectedRows(0)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text = dataGridViewRow4.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblTotalRate.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text = dataGridViewRow4.Cells(CInt((2))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text = dataGridViewRow4.Cells(CInt((3))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountPer_Food.Text = dataGridViewRow4.Cells(CInt((4))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountAmount_Food.Text = dataGridViewRow4.Cells(CInt((5))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxPer_Food.Text = dataGridViewRow4.Cells(CInt((6))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxAmount_Food.Text = dataGridViewRow4.Cells(CInt((7))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = dataGridViewRow4.Cells(CInt((8))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text = dataGridViewRow4.Cells(CInt((9))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCPer.Text = dataGridViewRow4.Cells(CInt((10))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCAmount.Text = dataGridViewRow4.Cells(CInt((11))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text = dataGridViewRow4.Cells(CInt((12))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTempDiscountPer.Text = dataGridViewRow4.Cells(CInt((14))).Value.ToString()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Dim rowIndex3 As Integer = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.CurrentCell.RowIndex
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows.RemoveAt(rowIndex3)
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.RemoveAt(rowIndex3)
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.Rows.Add(Me.ItemName, Microsoft.VisualBasic.Conversion.Val(Me.lblTotalRate.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCPer.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCAmount.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), Me.txtNotes.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTempDiscountPer.Text), Me.txtCategory.Text, Me.txtDishNameArabic.Text)
                    Dim value3 As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food2()
                    value3 = System.Math.Round(value3, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value3)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSubTotal1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value3)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Calc1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Me.ItemName)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text)), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen3 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj3 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location3 As System.Drawing.Point = screen3.Bounds.Location
                        Dim p3 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj3.Location = location3 + CType(p3, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Add(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance1.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H2()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.fillCurrencyTA()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear2()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView3.ClearSelection()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTADiscountPer.Text = Me.txtTempQD.Text
                    Me.lblSet.Text = ""
                    Me.ItemName = ""
                    Me.ModifierName = ""
                    MyBase.Close()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                    If RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows.Count > 0 Then
                        Me.lblTotalRate.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblItemRate.Text) + Me.ModifierRate())
                        Dim dataGridViewRow5 As System.Windows.Forms.DataGridViewRow = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.SelectedRows(0)
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text = dataGridViewRow5.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.lblTotalRate.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text = dataGridViewRow5.Cells(CInt((2))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text = dataGridViewRow5.Cells(CInt((3))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountPer_Food.Text = dataGridViewRow5.Cells(CInt((4))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountAmount_Food.Text = dataGridViewRow5.Cells(CInt((5))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxPer_Food.Text = dataGridViewRow5.Cells(CInt((6))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxAmount_Food.Text = dataGridViewRow5.Cells(CInt((7))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text = dataGridViewRow5.Cells(CInt((8))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text = dataGridViewRow5.Cells(CInt((9))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCPer.Text = dataGridViewRow5.Cells(CInt((10))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCAmount.Text = dataGridViewRow5.Cells(CInt((11))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text = dataGridViewRow5.Cells(CInt((12))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTempDiscountPer.Text = dataGridViewRow5.Cells(CInt((14))).Value.ToString()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Compute()
                    Dim rowIndex4 As Integer = RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.CurrentCell.RowIndex
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows.RemoveAt(rowIndex4)
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.RemoveAt(rowIndex4)
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.Rows.Add(Me.ItemName, Microsoft.VisualBasic.Conversion.Val(Me.lblTotalRate.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDiscountAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtServiceTaxAmount_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATPer_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtVATAmt_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCPer.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtSCAmount.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text), Me.txtNotes.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTempDiscountPer.Text), Me.txtCategory.Text, Me.txtDishNameArabic.Text)
                    Dim value4 As Double = RestaurantPOS14.My.MyProject.Forms.frmPOS.GrandTotal_Food4()
                    value4 = System.Math.Round(value4, 2)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value4)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGrandTotal3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(value4)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Calc3()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ItemDataSubString(Me.ItemName)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CustomerDisplay(RestaurantPOS14.My.MyProject.Forms.frmPOS.subt, New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text)), New Decimal(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text)))
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtColoredCustomerDisplay.Text, "Yes", TextCompare:=False) = 0 Then
                        Dim screen4 As System.Windows.Forms.Screen = System.Windows.Forms.Screen.AllScreens(1)
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.StartPosition = System.Windows.Forms.FormStartPosition.Manual
                        Dim obj4 As RestaurantPOS14.frmSecondaryDisplay = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay
                        Dim location4 As System.Drawing.Point = screen4.Bounds.Location
                        Dim p4 As System.Drawing.Point = New System.Drawing.Point(100, 100)
                        obj4.Location = location4 + CType(p4, System.Drawing.Size)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Add(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtFoodName.Text, Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtRate_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtQty_Food.Text), Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTotalAmt_Food.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblTotal.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance3.Text))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.lblHST.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(RestaurantPOS14.My.MyProject.Forms.frmPOS.H4()))
                        RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.CurrentCell = RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows(CInt((RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.DataGridView1.Rows.Count - 1))).Cells(0)
                        Call RestaurantPOS14.My.MyProject.Forms.frmSecondaryDisplay.Show()
                    End If

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.fillCurrencyEB()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear1()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Clear4()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView5.ClearSelection()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBDiscountPer.Text = Me.txtTempQD.Text
                    Me.lblSet.Text = ""
                    Me.ItemName = ""
                    Me.ModifierName = ""
                    MyBase.Close()
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
            Me.components = New System.ComponentModel.Container()
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmModifiersList))
            Me.flpModifiers = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label32 = New System.Windows.Forms.Label()
            Me.lblItemName = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnRemove = New System.Windows.Forms.Button()
            Me.btnDone = New System.Windows.Forms.Button()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.lblTotalRate = New System.Windows.Forms.Label()
            Me.txtCategory = New System.Windows.Forms.TextBox()
            Me.txtNotes = New System.Windows.Forms.RichTextBox()
            Me.txtTempQD = New System.Windows.Forms.TextBox()
            Me.lblItemRate = New System.Windows.Forms.Label()
            Me.txtDishNameArabic = New System.Windows.Forms.TextBox()
            Me.txtItemStatus = New System.Windows.Forms.TextBox()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.flpModifiers.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpModifiers.AutoScroll = True
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpModifiers
            Dim location As System.Drawing.Point = New System.Drawing.Point(494, 1)
            flowLayoutPanel.Location = location
            Me.flpModifiers.Name = "flpModifiers"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpModifiers
            Dim size As System.Drawing.Size = New System.Drawing.Size(505, 403)
            flowLayoutPanel2.Size = size
            Me.flpModifiers.TabIndex = 1
            Me.Label32.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label32.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label32
            location = New System.Drawing.Point(12, 9)
            label.Location = location
            Me.Label32.Name = "Label32"
            Dim label2 As System.Windows.Forms.Label = Me.Label32
            size = New System.Drawing.Size(104, 20)
            label2.Size = size
            Me.Label32.TabIndex = 388
            Me.Label32.Text = "Item Name : "
            Me.lblItemName.AutoSize = True
            Me.lblItemName.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblItemName.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.lblItemName
            location = New System.Drawing.Point(112, 8)
            label3.Location = location
            Me.lblItemName.Name = "lblItemName"
            Dim label4 As System.Windows.Forms.Label = Me.lblItemName
            size = New System.Drawing.Size(0, 21)
            label4.Size = size
            Me.lblItemName.TabIndex = 389
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
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
            Me.DataGridView1.Columns.AddRange(Me.DataGridViewTextBoxColumn34, Me.Column1, Me.DataGridViewTextBoxColumn35)
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            location = New System.Drawing.Point(134, 38)
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
            Me.DataGridView1.RowTemplate.Height = 50
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(354, 367)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 394
            Me.DataGridViewTextBoxColumn34.HeaderText = "Modifier Name"
            Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
            Me.DataGridViewTextBoxColumn34.[ReadOnly] = True
            Me.DataGridViewTextBoxColumn34.Width = 180
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column1.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column1.HeaderText = "Qty."
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Width = 70
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DataGridViewTextBoxColumn35.DefaultCellStyle = dataGridViewCellStyle7
            Me.DataGridViewTextBoxColumn35.HeaderText = "Rate"
            Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
            Me.DataGridViewTextBoxColumn35.[ReadOnly] = True
            Me.btnRemove.BackColor = System.Drawing.Color.Crimson
            Me.btnRemove.Enabled = False
            Me.btnRemove.FlatAppearance.BorderSize = 0
            Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button As System.Windows.Forms.Button = Me.btnRemove
            location = New System.Drawing.Point(12, 38)
            button.Location = location
            Me.btnRemove.Name = "btnRemove"
            Dim button2 As System.Windows.Forms.Button = Me.btnRemove
            size = New System.Drawing.Size(116, 47)
            button2.Size = size
            Me.btnRemove.TabIndex = 405
            Me.btnRemove.Text = "Remove"
            Me.btnRemove.UseVisualStyleBackColor = False
            Me.btnDone.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnDone.FlatAppearance.BorderSize = 0
            Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button3 As System.Windows.Forms.Button = Me.btnDone
            location = New System.Drawing.Point(12, 90)
            button3.Location = location
            Me.btnDone.Name = "btnDone"
            Dim button4 As System.Windows.Forms.Button = Me.btnDone
            size = New System.Drawing.Size(116, 47)
            button4.Size = size
            Me.btnDone.TabIndex = 411
            Me.btnDone.Text = "Done"
            Me.btnDone.UseVisualStyleBackColor = False
            Me.lblSet.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(41, 334)
            label5.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label6 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label6.Size = size
            Me.lblSet.TabIndex = 417
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.lblTotalRate.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.lblTotalRate
            location = New System.Drawing.Point(370, 12)
            label7.Location = location
            Me.lblTotalRate.Name = "lblTotalRate"
            Dim label8 As System.Windows.Forms.Label = Me.lblTotalRate
            size = New System.Drawing.Size(64, 13)
            label8.Size = size
            Me.lblTotalRate.TabIndex = 418
            Me.lblTotalRate.Text = "lblTotalRate"
            Me.lblTotalRate.Visible = False
            Dim textBox As System.Windows.Forms.TextBox = Me.txtCategory
            location = New System.Drawing.Point(311, 9)
            textBox.Location = location
            Me.txtCategory.Name = "txtCategory"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtCategory
            size = New System.Drawing.Size(53, 20)
            textBox2.Size = size
            Me.txtCategory.TabIndex = 420
            Me.txtCategory.Visible = False
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtNotes
            location = New System.Drawing.Point(303, 2)
            richTextBox.Location = location
            Me.txtNotes.Name = "txtNotes"
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtNotes
            size = New System.Drawing.Size(61, 30)
            richTextBox2.Size = size
            Me.txtNotes.TabIndex = 419
            Me.txtNotes.Text = ""
            Me.txtNotes.Visible = False
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtTempQD
            location = New System.Drawing.Point(252, 6)
            textBox3.Location = location
            Me.txtTempQD.Name = "txtTempQD"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtTempQD
            size = New System.Drawing.Size(53, 20)
            textBox4.Size = size
            Me.txtTempQD.TabIndex = 421
            Me.txtTempQD.Visible = False
            Me.lblItemRate.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.lblItemRate
            location = New System.Drawing.Point(440, 16)
            label9.Location = location
            Me.lblItemRate.Name = "lblItemRate"
            Dim label10 As System.Windows.Forms.Label = Me.lblItemRate
            size = New System.Drawing.Size(39, 13)
            label10.Size = size
            Me.lblItemRate.TabIndex = 422
            Me.lblItemRate.Text = "Label1"
            Me.lblItemRate.Visible = False
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtDishNameArabic
            location = New System.Drawing.Point(213, 2)
            textBox5.Location = location
            Me.txtDishNameArabic.Name = "txtDishNameArabic"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtDishNameArabic
            size = New System.Drawing.Size(53, 20)
            textBox6.Size = size
            Me.txtDishNameArabic.TabIndex = 423
            Me.txtDishNameArabic.Visible = False
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtItemStatus
            location = New System.Drawing.Point(172, 6)
            textBox7.Location = location
            Me.txtItemStatus.Name = "txtItemStatus"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtItemStatus
            size = New System.Drawing.Size(53, 20)
            textBox8.Size = size
            Me.txtItemStatus.TabIndex = 488
            Me.txtItemStatus.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1000, 416)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.txtItemStatus)
            MyBase.Controls.Add(Me.txtDishNameArabic)
            MyBase.Controls.Add(Me.lblItemRate)
            MyBase.Controls.Add(Me.txtTempQD)
            MyBase.Controls.Add(Me.txtCategory)
            MyBase.Controls.Add(Me.txtNotes)
            MyBase.Controls.Add(Me.lblTotalRate)
            MyBase.Controls.Add(Me.lblSet)
            MyBase.Controls.Add(Me.btnDone)
            MyBase.Controls.Add(Me.btnRemove)
            MyBase.Controls.Add(Me.DataGridView1)
            MyBase.Controls.Add(Me.Label32)
            MyBase.Controls.Add(Me.lblItemName)
            MyBase.Controls.Add(Me.flpModifiers)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmModifiersList"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Item Modifiers"
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
