Imports System
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
    Public Class frmVoucherRecord
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateTo")>
        Private _dtpDateTo As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateFrom")>
        Private _dtpDateFrom As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbVoucherNo")>
        Private _cmbVoucherNo As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

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

        Friend Overridable Property btnClose As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClose
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnClose_Click_1
                If Me._btnClose IsNot Nothing Then
                    RemoveHandler Me._btnClose.Click, value2
                End If

                Me._btnClose = value
                If Me._btnClose IsNot Nothing Then
                    AddHandler Me._btnClose.Click, value2
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

        Friend Overridable Property Button1 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, value2
                End If

                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property dtpDateTo As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateTo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateTo = value
            End Set
        End Property

        Friend Overridable Property dtpDateFrom As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateFrom
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateFrom = value
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

        Friend Overridable Property cmbVoucherNo As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbVoucherNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.Windows.Forms.ListControlConvertEventHandler = AddressOf Me.cmbVoucherNo_Format
                Dim value3 As System.EventHandler = AddressOf Me.cmbBillNo_SelectedIndexChanged
                If Me._cmbVoucherNo IsNot Nothing Then
                    RemoveHandler Me._cmbVoucherNo.Format, value2
                    RemoveHandler Me._cmbVoucherNo.SelectedIndexChanged, value3
                End If

                Me._cmbVoucherNo = value
                If Me._cmbVoucherNo IsNot Nothing Then
                    AddHandler Me._cmbVoucherNo.Format, value2
                    AddHandler Me._cmbVoucherNo.SelectedIndexChanged, value3
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox3 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox3 = value
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
            AddHandler MyBase.Load, AddressOf Me.frmVoucherRecord_Load
            Call RestaurantPOS14.frmVoucherRecord.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmVoucherRecord.__ENCList
                If RestaurantPOS14.frmVoucherRecord.__ENCList.Count = RestaurantPOS14.frmVoucherRecord.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmVoucherRecord.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmVoucherRecord.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmVoucherRecord.__ENCList(num) = RestaurantPOS14.frmVoucherRecord.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmVoucherRecord.__ENCList.RemoveRange(num, RestaurantPOS14.frmVoucherRecord.__ENCList.Count - num)
                    RestaurantPOS14.frmVoucherRecord.__ENCList.Capacity = RestaurantPOS14.frmVoucherRecord.__ENCList.Count
                End If

                Call RestaurantPOS14.frmVoucherRecord.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub fillVoucherNo()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(VoucherNo) FROM Voucher", sqlConnection)
                RestaurantPOS14.ModClasses.adp.SelectCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                RestaurantPOS14.ModClasses.dtable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbVoucherNo.Items.Clear()
                For Each dataRow As System.Data.DataRow In RestaurantPOS14.ModClasses.dtable.Rows
                    Me.cmbVoucherNo.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetData()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(Voucher.Id) as [Voucher ID], RTRIM(VoucherNo) as [Voucher No.],Convert(DateTime,Date,103) as [Voucher Date], RTRIM(Name) as [Name],RTRIM(Details) as [Details],RTRIM(PaymentMode) as [Payment Mode],RTRIM(Voucher.GrandTotal) as [Grand Total] from Voucher order by Date", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlDataAdapter.Fill(dataSet, "Voucher")
                Me.dgw.DataSource = dataSet.Tables(CStr(("Voucher"))).DefaultView
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.cmbVoucherNo.Text = ""
            Me.dtpDateFrom.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.dtpDateTo.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.GetData()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.ExportExcel(Me.dgw)
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.SelectedRows.Count = 0 Then Return
                Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.txtVoucherID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.txtVoucherNo.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.dtpDate.Value = Microsoft.VisualBasic.CompilerServices.Conversions.ToDate(dataGridViewRow.Cells(CInt((2))).Value.ToString())
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.txtName.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.txtDetails.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.cmbPaymentMode.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.txtGrandTotal.Text = dataGridViewRow.Cells(CInt((6))).Value.ToString()
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.btnSave.Enabled = False
                If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Voucher") Then
                    RestaurantPOS14.My.MyProject.Forms.frmVoucher.btnDelete.Enabled = True
                Else
                    RestaurantPOS14.My.MyProject.Forms.frmVoucher.btnDelete.Enabled = False
                End If

                If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Voucher") Then
                    RestaurantPOS14.My.MyProject.Forms.frmVoucher.btnUpdate.Enabled = True
                Else
                    RestaurantPOS14.My.MyProject.Forms.frmVoucher.btnUpdate.Enabled = False
                End If

                RestaurantPOS14.My.MyProject.Forms.frmVoucher.btnPrint.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.btnRemove.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmVoucher.cmbPaymentMode.Enabled = False
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject("Select RTRIM(Particulars),RTRIM(Amount),RTRIM(Note) from Voucher,Voucher_OtherDetails where Voucher.Id=Voucher_OtherDetails.VoucherID and Voucher.ID=", dataGridViewRow.Cells(CInt((0))).Value), "")), RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Call RestaurantPOS14.My.MyProject.Forms.frmVoucher.DataGridView1.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Call RestaurantPOS14.My.MyProject.Forms.frmVoucher.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
                MyBase.Close()
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
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(Voucher.Id) as [Voucher ID], RTRIM(VoucherNo) as [Voucher No.],Convert(DateTime,Date,103) as [Voucher Date], RTRIM(Name) as [Name],RTRIM(Details) as [Details],RTRIM(PaymentMode) as [Payment Mode],RTRIM(Voucher.GrandTotal) as [Grand Total] from Voucher where Date >=@d1 and Date < @d2 order by Date", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value.[Date].AddDays(1.0)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlDataAdapter.Fill(dataSet, "Voucher")
                Me.dgw.DataSource = dataSet.Tables(CStr(("Voucher"))).DefaultView
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbBillNo_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(Voucher.Id) as [Voucher ID], RTRIM(VoucherNo) as [Voucher No.],Convert(DateTime,Date,103) as [Voucher Date], RTRIM(Name) as [Name],RTRIM(Details) as [Details],RTRIM(PaymentMode) as [Payment Mode],RTRIM(Voucher.GrandTotal) as [Grand Total] from Voucher where VoucherNo='" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.cmbVoucherNo.Text) & "' order by Date", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlDataAdapter.Fill(dataSet, "Voucher")
                Me.dgw.DataSource = dataSet.Tables(CStr(("Voucher"))).DefaultView
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub cmbVoucherNo_Format(sender As Object, e As System.Windows.Forms.ListControlConvertEventArgs)
            If e.DesiredType Is GetType(String) Then
                e.Value = e.Value.ToString().Trim()
            End If
        End Sub

        Private Sub frmVoucherRecord_Load(sender As Object, e As System.EventArgs)
            Me.fillVoucherNo()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmVoucherRecord))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbVoucherNo = New System.Windows.Forms.ComboBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
            Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(742, 583)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox3.Controls.Add(Me.btnExportExcel)
            Me.GroupBox3.Controls.Add(Me.btnReset)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(519, 40)
            groupBox.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(137, 118)
            groupBox2.Size = size
            Me.GroupBox3.TabIndex = 48
            Me.GroupBox3.TabStop = False
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(13, 66)
            button.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button2 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(107, 40)
            button2.Size = size
            Me.btnExportExcel.TabIndex = 5
            Me.btnExportExcel.Text = "Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(32, 17)
            button3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button4 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(78, 40)
            button4.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(658, 3)
            button5.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button6 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(78, 39)
            button6.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.cmbVoucherNo)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(4, 65)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(144, 61)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 47
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Voucher No. :"
            Me.cmbVoucherNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbVoucherNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbVoucherNo.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbVoucherNo
            location = New System.Drawing.Point(18, 23)
            comboBox.Location = location
            Me.cmbVoucherNo.Name = "cmbVoucherNo"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbVoucherNo
            size = New System.Drawing.Size(103, 21)
            comboBox2.Size = size
            Me.cmbVoucherNo.TabIndex = 1
            Me.GroupBox2.Controls.Add(Me.Button1)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.dtpDateTo)
            Me.GroupBox2.Controls.Add(Me.dtpDateFrom)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(156, 45)
            groupBox5.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(334, 100)
            groupBox6.Size = size
            Me.GroupBox2.TabIndex = 43
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search By Voucher Date :"
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.Image = CType(componentResourceManager.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
            Dim button7 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(244, 44)
            button7.Location = location
            Me.Button1.Name = "Button1"
            Dim button8 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(78, 39)
            button8.Size = size
            Me.Button1.TabIndex = 108
            Me.Button1.Text = "Search"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(6, 42)
            label.Location = location
            Me.Label2.Name = "Label2"
            Dim label2 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(36, 13)
            label2.Size = size
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "From :"
            Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
            Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            location = New System.Drawing.Point(138, 61)
            dateTimePicker.Location = location
            Me.dtpDateTo.Name = "dtpDateTo"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            size = New System.Drawing.Size(100, 20)
            dateTimePicker2.Size = size
            Me.dtpDateTo.TabIndex = 107
            Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
            Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker3 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            location = New System.Drawing.Point(9, 61)
            dateTimePicker3.Location = location
            Me.dtpDateFrom.Name = "dtpDateFrom"
            Dim dateTimePicker4 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            size = New System.Drawing.Size(100, 20)
            dateTimePicker4.Size = size
            Me.dtpDateFrom.TabIndex = 106
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(135, 42)
            label3.Location = location
            Me.Label4.Name = "Label4"
            Dim label4 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(26, 13)
            label4.Size = size
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "To :"
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
            Me.dgw.ColumnHeadersHeight = 24
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
            location = New System.Drawing.Point(4, 168)
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
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(730, 410)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 40
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 4)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(646, 30)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(242, 2)
            label5.Location = location
            Me.Label1.Name = "Label1"
            Dim label6 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(164, 24)
            label6.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "List Of Vouchers"
            Me.lblUser.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(351, 284)
            label7.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label8 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label8.Size = size
            Me.lblUser.TabIndex = 49
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(751, 590)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmVoucherRecord"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
