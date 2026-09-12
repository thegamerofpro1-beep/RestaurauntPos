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
    Public Class frmGiftCardRecord
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtGiftCardID")>
        Private _txtGiftCardID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button3")>
        Private _Button3 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

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
                Dim value3 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.dgw_RowPostPaint
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.MouseClick, value2
                    RemoveHandler Me._dgw.RowPostPaint, value3
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.MouseClick, value2
                    AddHandler Me._dgw.RowPostPaint, value3
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox1 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox1 = value
            End Set
        End Property

        Friend Overridable Property txtGiftCardID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtGiftCardID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtGiftCardID = value
            End Set
        End Property

        Friend Overridable Property Button3 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button3_Click
                If Me._Button3 IsNot Nothing Then
                    RemoveHandler Me._Button3.Click, value2
                End If

                Me._Button3 = value
                If Me._Button3 IsNot Nothing Then
                    AddHandler Me._Button3.Click, value2
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmGiftCardRecord.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmGiftCardRecord.__ENCList
                If RestaurantPOS14.frmGiftCardRecord.__ENCList.Count = RestaurantPOS14.frmGiftCardRecord.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmGiftCardRecord.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmGiftCardRecord.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmGiftCardRecord.__ENCList(num) = RestaurantPOS14.frmGiftCardRecord.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmGiftCardRecord.__ENCList.RemoveRange(num, RestaurantPOS14.frmGiftCardRecord.__ENCList.Count - num)
                    RestaurantPOS14.frmGiftCardRecord.__ENCList.Capacity = RestaurantPOS14.frmGiftCardRecord.__ENCList.Count
                End If

                Call RestaurantPOS14.frmGiftCardRecord.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtGiftCardID.Text = ""
            Me.GetData()
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(ID),Amount,RTRIM(CustomerName) from GiftCard where ID not in (Select GiftCardID from RestaurantPOS_BillingInfoEB where GiftCardID is not null and EB_Status<>'Void' Union Select GiftCardID from RestaurantPOS_BillingInfoTA where GiftCardID is not null and TA_Status<>'Void' union Select GiftCardID from RestaurantPOS_BillingInfoHD where GiftCardID is not null and HD_Status<>'Canceled' Union Select GiftCardID from RestaurantPOS_BillingInfoKOT where GiftCardID is not null) order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    MyBase.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGFID3.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGFA3.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow.Cells(CInt((1))).Value)
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow2 As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    MyBase.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGFID2.Text = dataGridViewRow2.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGFA2.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow2.Cells(CInt((1))).Value)
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow3 As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    MyBase.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGFID1.Text = dataGridViewRow3.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGFA1.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow3.Cells(CInt((1))).Value)
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "KOT", TextCompare:=False) = 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow4 As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    MyBase.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGFID.Text = dataGridViewRow4.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtGFA.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow4.Cells(CInt((1))).Value)
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "BS", TextCompare:=False) = 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow5 As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    MyBase.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmCards_POS.Hide()
                    Call RestaurantPOS14.My.MyProject.Forms.frmBillSplit.Show()
                    RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtGFID.Text = dataGridViewRow5.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmBillSplit.txtGFA.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(dataGridViewRow5.Cells(CInt((1))).Value)
                End If

                Me.lblSet.Text = ""
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

        Private Sub Button3_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(ID),Amount,RTRIM(CustomerName) from GiftCard where ID not in (Select GiftCardID from RestaurantPOS_BillingInfoEB where GiftCardID is not null and EB_Status<>'Void' Union Select GiftCardID from RestaurantPOS_BillingInfoTA where GiftCardID is not null and TA_Status<>'Void' union Select GiftCardID from RestaurantPOS_BillingInfoHD where GiftCardID is not null and HD_Status<>'Canceled' Union Select GiftCardID from RestaurantPOS_BillingInfoKOT where GiftCardID is not null) and ID like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtGiftCardID.Text) & "%' order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
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
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmGiftCardRecord))
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.txtGiftCardID = New System.Windows.Forms.TextBox()
            Me.btnReset = New System.Windows.Forms.Button()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            MyBase.SuspendLayout()
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.BackgroundColor = System.Drawing.Color.White
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 40
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3)
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
            Dim location As System.Drawing.Point = New System.Drawing.Point(1, 79)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 44
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            Dim size As System.Drawing.Size = New System.Drawing.Size(811, 460)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 41
            Me.Column1.FillWeight = 76.53061F
            Me.Column1.HeaderText = "Gift Card ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Width = 200
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column2.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column2.FillWeight = 162.7349F
            Me.Column2.HeaderText = "Amount"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column2.Width = 200
            Me.Column3.FillWeight = 69.71115F
            Me.Column3.HeaderText = "Customer Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 380
            Me.GroupBox1.Controls.Add(Me.lblSet)
            Me.GroupBox1.Controls.Add(Me.Button3)
            Me.GroupBox1.Controls.Add(Me.txtGiftCardID)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(6, 5)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(300, 68)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 42
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Gift Card ID"
            Me.lblSet.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(227, 4)
            label.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(34, 20)
            label2.Size = size
            Me.lblSet.TabIndex = 399
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.Button3.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.Button3.FlatAppearance.BorderSize = 0
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button As System.Windows.Forms.Button = Me.Button3
            location = New System.Drawing.Point(190, 29)
            button.Location = location
            Me.Button3.Name = "Button3"
            Dim button2 As System.Windows.Forms.Button = Me.Button3
            size = New System.Drawing.Size(99, 26)
            button2.Size = size
            Me.Button3.TabIndex = 398
            Me.Button3.Text = "Search"
            Me.Button3.UseVisualStyleBackColor = False
            Me.txtGiftCardID.BackColor = System.Drawing.Color.White
            Me.txtGiftCardID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtGiftCardID
            location = New System.Drawing.Point(22, 29)
            textBox.Location = location
            Me.txtGiftCardID.Name = "txtGiftCardID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtGiftCardID
            size = New System.Drawing.Size(162, 26)
            textBox2.Size = size
            Me.txtGiftCardID.TabIndex = 0
            Me.btnReset.BackColor = System.Drawing.Color.Crimson
            Me.btnReset.FlatAppearance.BorderSize = 0
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Dim button3 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(312, 12)
            button3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button4 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(99, 61)
            button4.Size = size
            Me.btnReset.TabIndex = 398
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(818, 540)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.GroupBox1)
            MyBase.Controls.Add(Me.dgw)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmGiftCardRecord"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Gift Cards Record"
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
