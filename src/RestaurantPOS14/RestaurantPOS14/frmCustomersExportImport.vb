Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmCustomersExportImport
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnImportExcel")>
        Private _btnImportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByCustomer")>
        Private _txtSearchByCustomer As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DataGridView1")>
        Private _DataGridView1 As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSearchByContactNo")>
        Private _txtSearchByContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

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
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.RowPostPaint, value2
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.RowPostPaint, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnImportExcel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnImportExcel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._btnImportExcel IsNot Nothing Then
                    RemoveHandler Me._btnImportExcel.Click, value2
                End If

                Me._btnImportExcel = value
                If Me._btnImportExcel IsNot Nothing Then
                    AddHandler Me._btnImportExcel.Click, value2
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

        Friend Overridable Property txtSearchByCustomer As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSearchByCustomer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtSearchByCustomer_TextChanged
                If Me._txtSearchByCustomer IsNot Nothing Then
                    RemoveHandler Me._txtSearchByCustomer.TextChanged, value2
                End If

                Me._txtSearchByCustomer = value
                If Me._txtSearchByCustomer IsNot Nothing Then
                    AddHandler Me._txtSearchByCustomer.TextChanged, value2
                End If
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
                Dim value2 As System.EventHandler = AddressOf Me.Timer1_Tick
                If Me._Timer1 IsNot Nothing Then
                    RemoveHandler Me._Timer1.Tick, value2
                End If

                Me._Timer1 = value
                If Me._Timer1 IsNot Nothing Then
                    AddHandler Me._Timer1.Tick, value2
                End If
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
                Dim value2 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.DataGridView1_RowPostPaint
                If Me._DataGridView1 IsNot Nothing Then
                    RemoveHandler Me._DataGridView1.RowPostPaint, value2
                End If

                Me._DataGridView1 = value
                If Me._DataGridView1 IsNot Nothing Then
                    AddHandler Me._DataGridView1.RowPostPaint, value2
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox2 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox2 = value
            End Set
        End Property

        Friend Overridable Property txtSearchByContactNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSearchByContactNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtCategory_TextChanged
                If Me._txtSearchByContactNo IsNot Nothing Then
                    RemoveHandler Me._txtSearchByContactNo.TextChanged, value2
                End If

                Me._txtSearchByContactNo = value
                If Me._txtSearchByContactNo IsNot Nothing Then
                    AddHandler Me._txtSearchByContactNo.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnSave As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSave
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSave_Click
                If Me._btnSave IsNot Nothing Then
                    RemoveHandler Me._btnSave.Click, value2
                End If

                Me._btnSave = value
                If Me._btnSave IsNot Nothing Then
                    AddHandler Me._btnSave.Click, value2
                End If
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
            AddHandler MyBase.FormClosing, AddressOf Me.frmMenuItemsExportImport_FormClosing
            Call RestaurantPOS14.frmCustomersExportImport.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCustomersExportImport.__ENCList
                If RestaurantPOS14.frmCustomersExportImport.__ENCList.Count = RestaurantPOS14.frmCustomersExportImport.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCustomersExportImport.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCustomersExportImport.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCustomersExportImport.__ENCList(num) = RestaurantPOS14.frmCustomersExportImport.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCustomersExportImport.__ENCList.RemoveRange(num, RestaurantPOS14.frmCustomersExportImport.__ENCList.Count - num)
                    RestaurantPOS14.frmCustomersExportImport.__ENCList.Capacity = RestaurantPOS14.frmCustomersExportImport.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCustomersExportImport.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Getdata()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(CustomerName), RTRIM(Address), RTRIM(ContactNo) from HDCustomer order by CustomerName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
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

        Public Sub Reset()
            Me.txtSearchByCustomer.Text = ""
            Me.txtSearchByContactNo.Text = ""
            Me.DataGridView1.DataSource = Nothing
            Me.DataGridView1.Visible = False
            Me.Getdata()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.ExportExcel(Me.dgw)
        End Sub

        Private Sub txtSearchByCustomer_TextChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(CustomerName), RTRIM(Address), RTRIM(ContactNo) from HDCustomer where CustomerName like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtSearchByCustomer.Text) & "%' order by CustomerName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
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

        Private Sub dgw_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
            Dim text As String =(e.RowIndex + 1).ToString()
            Dim sizeF As System.Drawing.SizeF = e.Graphics.MeasureString(text, MyBase.Font)
            If Me.dgw.RowHeadersWidth < System.Convert.ToInt32(sizeF.Width + 20F) Then
                Me.dgw.RowHeadersWidth = System.Convert.ToInt32(sizeF.Width + 20F)
            End If

            Dim controlText As System.Drawing.Brush = System.Drawing.SystemBrushes.ControlText
            e.Graphics.DrawString(text, MyBase.Font, controlText, e.RowBounds.Location.X + 15, CSng(e.RowBounds.Location.Y) + (CSng(e.RowBounds.Height) - sizeF.Height) / 2F)
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                Dim openFileDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
                openFileDialog.Filter = "Excel Files | *.xlsx; *.xls;| All Files (*.*)| *.*"
                If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso Microsoft.VisualBasic.CompilerServices.Operators.CompareString(openFileDialog.FileName, "", TextCompare:=False) <> 0 Then
                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer1.Enabled = True
                    Dim fileName As String = openFileDialog.FileName
                    Dim oleDbConnection As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & fileName & ";Extended Properties=Excel 8.0;")
                    Dim oleDbDataAdapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", oleDbConnection)
                    oleDbConnection.Open()
                    Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                    oleDbDataAdapter.Fill(dataSet)
                    Me.DataGridView1.Visible = True
                    Me.DataGridView1.DataSource = dataSet.Tables(0)
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub frmMenuItemsExportImport_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmCustomer.Getdata()
        End Sub

        Private Sub txtCategory_TextChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(CustomerName), RTRIM(Address), RTRIM(ContactNo) from HDCustomer where ContactNo like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtSearchByContactNo.Text) & "%' order by CustomerName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
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

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.DataGridView1.RowCount = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry nothing to save.." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Please retrieve data in datagridview", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Return
                End If

                For Each dataGridViewRow As System.Windows.Forms.DataGridViewRow In CType(Me.DataGridView1.Rows, System.Collections.IEnumerable)
                    If Not dataGridViewRow.IsNewRow Then
                        Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select CustomerName,Address,ContactNo from HDCustomer Where CustomerName=@d1 and Address=@d2 and ContactNo=@d3")
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", dataGridViewRow.Cells(CInt((0))).Value.ToString())
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow.Cells(CInt((1))).Value.ToString())
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", dataGridViewRow.Cells(CInt((2))).Value.ToString())
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                        RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                            MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                            Me.Timer1.Enabled = True
                            Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                            RestaurantPOS14.ModClasses.con.Open()
                            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Insert Into HDCustomer(CustomerName,Address,ContactNo) Values(@d1,@d2,@d3)")
                            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", dataGridViewRow.Cells(CInt((0))).Value.ToString())
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", dataGridViewRow.Cells(CInt((1))).Value.ToString())
                            RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", dataGridViewRow.Cells(CInt((2))).Value.ToString())
                            RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                            RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                            RestaurantPOS14.ModClasses.con.Close()
                            RestaurantPOS14.ModClasses.con.Dispose()
                        End If

                        RestaurantPOS14.ModClasses.con.Close()
                        RestaurantPOS14.ModClasses.con.Dispose()
                    End If
                Next

                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.DataGridView1.DataSource = Nothing
                Me.Reset()
            Catch ex As System.Data.SqlClient.SqlException
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                RestaurantPOS14.ModClasses.con.Close()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCustomersExportImport))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.txtSearchByContactNo = New System.Windows.Forms.TextBox()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.btnImportExcel = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtSearchByCustomer = New System.Windows.Forms.TextBox()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnSave)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.DataGridView1)
            Me.Panel1.Controls.Add(Me.btnImportExcel)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.btnExportExcel)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.btnReset)
            Me.Panel1.Controls.Add(Me.Label5)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(4, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(985, 580)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(695, 60)
            button.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button2 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(90, 64)
            button2.Size = size
            Me.btnSave.TabIndex = 118
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.GroupBox2.Controls.Add(Me.txtSearchByContactNo)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(254, 45)
            groupBox.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(233, 79)
            groupBox2.Size = size
            Me.GroupBox2.TabIndex = 117
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search By Contact No. :"
            Me.txtSearchByContactNo.BackColor = System.Drawing.Color.White
            Me.txtSearchByContactNo.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtSearchByContactNo
            location = New System.Drawing.Point(19, 31)
            textBox.Location = location
            Me.txtSearchByContactNo.Name = "txtSearchByContactNo"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtSearchByContactNo
            size = New System.Drawing.Size(208, 29)
            textBox2.Size = size
            Me.txtSearchByContactNo.TabIndex = 0
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
            Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.DataGridView1.ColumnHeadersHeight = 24
            Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.DataGridView1.EnableHeadersVisualStyles = False
            Me.DataGridView1.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.DataGridView1
            location = New System.Drawing.Point(6, 130)
            dataGridView.Location = location
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.[ReadOnly] = True
            Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
            Me.DataGridView1.RowHeadersWidth = 25
            Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4
            Me.DataGridView1.RowTemplate.Height = 18
            Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.DataGridView1
            size = New System.Drawing.Size(971, 442)
            dataGridView2.Size = size
            Me.DataGridView1.TabIndex = 116
            Me.DataGridView1.Visible = False
            Me.btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnImportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnImportExcel.Image = CType(componentResourceManager.GetObject("btnImportExcel.Image"), System.Drawing.Image)
            Me.btnImportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnImportExcel
            location = New System.Drawing.Point(596, 59)
            button3.Location = location
            Me.btnImportExcel.Name = "btnImportExcel"
            Dim button4 As System.Windows.Forms.Button = Me.btnImportExcel
            size = New System.Drawing.Size(92, 64)
            button4.Size = size
            Me.btnImportExcel.TabIndex = 114
            Me.btnImportExcel.Text = "Import " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Excel"
            Me.btnImportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnImportExcel.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.txtSearchByCustomer)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(7, 45)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(241, 79)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 113
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Customer Name :"
            Me.txtSearchByCustomer.BackColor = System.Drawing.Color.White
            Me.txtSearchByCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtSearchByCustomer
            location = New System.Drawing.Point(19, 31)
            textBox3.Location = location
            Me.txtSearchByCustomer.Name = "txtSearchByCustomer"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtSearchByCustomer
            size = New System.Drawing.Size(212, 29)
            textBox4.Size = size
            Me.txtSearchByCustomer.TabIndex = 0
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgw.BackgroundColor = System.Drawing.Color.White
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6
            Me.dgw.ColumnHeadersHeight = 24
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView3 As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(4, 130)
            dataGridView3.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle7
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle8
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView4 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(971, 442)
            dataGridView4.Size = size
            Me.dgw.TabIndex = 112
            Me.Column1.FillWeight = 105.9322F
            Me.Column1.HeaderText = "Customer Name"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column2.FillWeight = 116.509F
            Me.Column2.HeaderText = "Address"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column3.FillWeight = 78.84892F
            Me.Column3.HeaderText = "Contact No."
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(493, 59)
            button5.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button6 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(97, 64)
            button6.Size = size
            Me.btnExportExcel.TabIndex = 5
            Me.btnExportExcel.Text = "Export" & Global.Microsoft.VisualBasic.Constants.vbCrLf & " Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(8, 4)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(967, 34)
            label2.Size = size
            Me.Label1.TabIndex = 111
            Me.Label1.Text = "Customers Export/Import"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(791, 60)
            button7.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button8 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(91, 64)
            button8.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.Label5.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(339, 75)
            label3.Location = location
            Me.Label5.Name = "Label5"
            Dim label4 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(0, 13)
            label4.Size = size
            Me.Label5.TabIndex = 12
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(992, 588)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmCustomersExportImport"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
