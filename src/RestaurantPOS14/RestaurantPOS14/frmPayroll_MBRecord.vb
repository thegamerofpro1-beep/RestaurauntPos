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
    Public Class frmPayroll_MBRecord
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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel5")>
        Private _Panel5 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("groupBox5")>
        Private _groupBox5 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("groupBox3")>
        Private _groupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTo")>
        Private _DateTo As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateFrom")>
        Private _DateFrom As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("label7")>
        Private _label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("label9")>
        Private _label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmployeeName")>
        Private _txtEmployeeName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

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

        Friend Overridable Property groupBox5 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._groupBox5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._groupBox5 = value
            End Set
        End Property

        Friend Overridable Property groupBox3 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._groupBox3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._groupBox3 = value
            End Set
        End Property

        Friend Overridable Property DateTo As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTo = value
            End Set
        End Property

        Friend Overridable Property DateFrom As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateFrom
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateFrom = value
            End Set
        End Property

        Friend Overridable Property label7 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._label7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._label7 = value
            End Set
        End Property

        Friend Overridable Property label9 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._label9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._label9 = value
            End Set
        End Property

        Friend Overridable Property txtEmployeeName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmployeeName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtEmployeeName_TextChanged
                If Me._txtEmployeeName IsNot Nothing Then
                    RemoveHandler Me._txtEmployeeName.TextChanged, value2
                End If

                Me._txtEmployeeName = value
                If Me._txtEmployeeName IsNot Nothing Then
                    AddHandler Me._txtEmployeeName.TextChanged, value2
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
            Call RestaurantPOS14.frmPayroll_MBRecord.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPayroll_MBRecord.__ENCList
                If RestaurantPOS14.frmPayroll_MBRecord.__ENCList.Count = RestaurantPOS14.frmPayroll_MBRecord.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPayroll_MBRecord.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmPayroll_MBRecord.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPayroll_MBRecord.__ENCList(num) = RestaurantPOS14.frmPayroll_MBRecord.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmPayroll_MBRecord.__ENCList.RemoveRange(num, RestaurantPOS14.frmPayroll_MBRecord.__ENCList.Count - num)
                    RestaurantPOS14.frmPayroll_MBRecord.__ENCList.Capacity = RestaurantPOS14.frmPayroll_MBRecord.__ENCList.Count
                End If

                Call RestaurantPOS14.frmPayroll_MBRecord.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Payroll_MB.ID as [ID],RTRIM(PaymentID) as [Payment ID],RTRIM(Month) as [Month],Year as [Year],RTRIM(Registration.UserID) as [Employee ID],RTRIM(Name) as [Employee Name],RTRIM(SSN) as [SIN],GrossSalary as [Gross Pay],CPPPer as [CPP %],CPP as [CPP],EIPer as [EI %],EI as [EI],FedTaxPer as [FedTax %],FedTax as [Fed Tax],VPPer as [VP %],VP as [VP],Convert(DateTime,paymentdate,131) as [Payment Date],RTRIM(PaymentMode) as [Payment Mode],RTRIM(Remarks) as [Payment Mode Details],NetPay as [Net Pay] from Payroll_MB,Registration where Registration.UserID=Payroll_MB.UserID order by paymentdate", RestaurantPOS14.ModClasses.con)
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlDataAdapter.Fill(dataSet, "Payroll_MB")
                sqlDataAdapter.Fill(dataSet, "Registration")
                Me.dgw.DataSource = dataSet.Tables(CStr(("Payroll_MB"))).DefaultView
                Me.dgw.DataSource = dataSet.Tables(CStr(("Registration"))).DefaultView
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtEmployeeName.Text = ""
            Me.DateFrom.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTo.Value = Microsoft.VisualBasic.DateAndTime.Today
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
                If Me.dgw.Rows.Count > 0 AndAlso Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Payment", TextCompare:=False) = 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    MyBase.Hide()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtPaymentID.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.cmbMonth.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.cmbYear.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtEmployeeID.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtEmployeeName.Text = dataGridViewRow.Cells(CInt((5))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtSIN.Text = dataGridViewRow.Cells(CInt((6))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtMonthlySalary.Text = dataGridViewRow.Cells(CInt((7))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtCPPPer.Text = dataGridViewRow.Cells(CInt((8))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtCPP.Text = dataGridViewRow.Cells(CInt((9))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtEIPer.Text = dataGridViewRow.Cells(CInt((10))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtEI.Text = dataGridViewRow.Cells(CInt((11))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtFedTaxPer.Text = dataGridViewRow.Cells(CInt((12))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtFedTax.Text = dataGridViewRow.Cells(CInt((13))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtVPPer.Text = dataGridViewRow.Cells(CInt((14))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtVP.Text = dataGridViewRow.Cells(CInt((15))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.dtpPaymentDate.Value = Microsoft.VisualBasic.CompilerServices.Conversions.ToDate(dataGridViewRow.Cells(CInt((16))).Value)
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.cmbPaymentmode.Text = dataGridViewRow.Cells(CInt((17))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtPaymentModeDetails.Text = dataGridViewRow.Cells(CInt((18))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.txtNetPay.Text = dataGridViewRow.Cells(CInt((19))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.btnSave.Enabled = False
                    If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Payment") Then
                        RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.btnDelete.Enabled = True
                    Else
                        RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.btnDelete.Enabled = False
                    End If

                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.btnPrint.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.dtpPaymentDate.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPayroll_MB.dgw.Enabled = False
                    Me.lblSet.Text = ""
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

        Private Sub txtEmployeeName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Payroll_MB.ID as [ID],RTRIM(PaymentID) as [Payment ID],RTRIM(Month) as [Month],Year as [Year],RTRIM(Registration.UserID) as [Employee ID],RTRIM(Name) as [Employee Name],RTRIM(SSN) as [SIN],GrossSalary as [Gross Pay],CPPPer as [CPP %],CPP as [CPP],EIPer as [EI %],EI as [EI],FedTaxPer as [FedTax %],FedTax as [Fed Tax],VPPer as [VP %],VP as [VP],Convert(DateTime,paymentdate,131) as [Payment Date],RTRIM(PaymentMode) as [Payment Mode],RTRIM(Remarks) as [Payment Mode Details],NetPay as [Net Pay] from Payroll_MB,Registration where Registration.UserID=Payroll_MB.UserID and Name like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtEmployeeName.Text) & "%' order by paymentdate", RestaurantPOS14.ModClasses.con)
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlDataAdapter.Fill(dataSet, "Payroll_MB")
                sqlDataAdapter.Fill(dataSet, "Registration")
                Me.dgw.DataSource = dataSet.Tables(CStr(("Payroll_MB"))).DefaultView
                Me.dgw.DataSource = dataSet.Tables(CStr(("Registration"))).DefaultView
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select Payroll_MB.ID as [ID],RTRIM(PaymentID) as [Payment ID],RTRIM(Month) as [Month],Year as [Year],RTRIM(Registration.UserID) as [Employee ID],RTRIM(Name) as [Employee Name],RTRIM(SSN) as [SIN],GrossSalary as [Gross Pay],CPPPer as [CPP %],CPP as [CPP],EIPer as [EI %],EI as [EI],FedTaxPer as [FedTax %],FedTax as [Fed Tax],VPPer as [VP %],VP as [VP],Convert(DateTime,paymentdate,131) as [Payment Date],RTRIM(PaymentMode) as [Payment Mode],RTRIM(Remarks) as [Payment Mode Details],NetPay as [Net Pay] from Payroll_MB,Registration where Registration.UserID=Payroll_MB.UserID and PaymentDate >=@d1 and PaymentDate < @d2 order by paymentdate", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateFrom.Value.[Date]
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.DateTo.Value.[Date].AddDays(1.0)
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                sqlDataAdapter.Fill(dataSet, "Payroll_MB")
                sqlDataAdapter.Fill(dataSet, "Registration")
                Me.dgw.DataSource = dataSet.Tables(CStr(("Payroll_MB"))).DefaultView
                Me.dgw.DataSource = dataSet.Tables(CStr(("Registration"))).DefaultView
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPayroll_MBRecord))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.DateTo = New System.Windows.Forms.DateTimePicker()
            Me.DateFrom = New System.Windows.Forms.DateTimePicker()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.groupBox5 = New System.Windows.Forms.GroupBox()
            Me.txtEmployeeName = New System.Windows.Forms.TextBox()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.groupBox5.SuspendLayout()
            Me.Panel5.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.groupBox3)
            Me.Panel1.Controls.Add(Me.groupBox5)
            Me.Panel1.Controls.Add(Me.Panel5)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(4, 4)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(1008, 571)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.groupBox3.Controls.Add(Me.Button1)
            Me.groupBox3.Controls.Add(Me.DateTo)
            Me.groupBox3.Controls.Add(Me.DateFrom)
            Me.groupBox3.Controls.Add(Me.label7)
            Me.groupBox3.Controls.Add(Me.label9)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.groupBox3
            location = New System.Drawing.Point(204, 42)
            groupBox.Location = location
            Me.groupBox3.Name = "groupBox3"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.groupBox3
            size = New System.Drawing.Size(383, 77)
            groupBox2.Size = size
            Me.groupBox3.TabIndex = 44
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Payment Date"
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.Image = CType(componentResourceManager.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(289, 26)
            button.Location = location
            Me.Button1.Name = "Button1"
            Dim button2 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(82, 36)
            button2.Size = size
            Me.Button1.TabIndex = 46
            Me.Button1.Text = "Search"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            Me.DateTo.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTo.CustomFormat = "dd/MM/yyyy"
            Me.DateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTo As System.Windows.Forms.DateTimePicker = Me.DateTo
            location = New System.Drawing.Point(166, 42)
            dateTo.Location = location
            Me.DateTo.Name = "DateTo"
            Dim dateTo2 As System.Windows.Forms.DateTimePicker = Me.DateTo
            size = New System.Drawing.Size(117, 20)
            dateTo2.Size = size
            Me.DateTo.TabIndex = 12
            Me.DateFrom.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateFrom.CustomFormat = "dd/MM/yyyy"
            Me.DateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateFrom As System.Windows.Forms.DateTimePicker = Me.DateFrom
            location = New System.Drawing.Point(30, 42)
            dateFrom.Location = location
            Me.DateFrom.Name = "DateFrom"
            Dim dateFrom2 As System.Windows.Forms.DateTimePicker = Me.DateFrom
            size = New System.Drawing.Size(124, 20)
            dateFrom2.Size = size
            Me.DateFrom.TabIndex = 11
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.label7
            location = New System.Drawing.Point(27, 21)
            label.Location = location
            Me.label7.Name = "label7"
            Dim label2 As System.Windows.Forms.Label = Me.label7
            size = New System.Drawing.Size(30, 13)
            label2.Size = size
            Me.label7.TabIndex = 9
            Me.label7.Text = "From"
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.label9
            location = New System.Drawing.Point(163, 21)
            label3.Location = location
            Me.label9.Name = "label9"
            Dim label4 As System.Windows.Forms.Label = Me.label9
            size = New System.Drawing.Size(20, 13)
            label4.Size = size
            Me.label9.TabIndex = 10
            Me.label9.Text = "To"
            Me.groupBox5.Controls.Add(Me.txtEmployeeName)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.groupBox5
            location = New System.Drawing.Point(6, 42)
            groupBox3.Location = location
            Me.groupBox5.Name = "groupBox5"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.groupBox5
            size = New System.Drawing.Size(192, 77)
            groupBox4.Size = size
            Me.groupBox5.TabIndex = 43
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Employee Name"
            Dim textBox As System.Windows.Forms.TextBox = Me.txtEmployeeName
            location = New System.Drawing.Point(17, 31)
            textBox.Location = location
            Me.txtEmployeeName.Name = "txtEmployeeName"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtEmployeeName
            size = New System.Drawing.Size(166, 20)
            textBox2.Size = size
            Me.txtEmployeeName.TabIndex = 0
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.btnExportExcel)
            Me.Panel5.Controls.Add(Me.btnClose)
            Me.Panel5.Controls.Add(Me.btnReset)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel5
            location = New System.Drawing.Point(593, 48)
            panel3.Location = location
            Me.Panel5.Name = "Panel5"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel5
            size = New System.Drawing.Size(315, 70)
            panel4.Size = size
            Me.Panel5.TabIndex = 42
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(101, 16)
            button3.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button4 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(106, 36)
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
            location = New System.Drawing.Point(213, 16)
            button5.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button6 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(82, 36)
            button6.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(13, 16)
            button7.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button8 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(82, 36)
            button8.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
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
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(6, 124)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(994, 441)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 40
            Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.lblUser)
            Me.Panel2.Controls.Add(Me.lblSet)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(6, 5)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(997, 33)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.lblSet.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(73, 17)
            label5.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label6 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label6.Size = size
            Me.lblSet.TabIndex = 1
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(0, 4)
            label7.Location = location
            Me.Label1.Name = "Label1"
            Dim label8 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(997, 24)
            label8.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Payroll Record"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblUser.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(153, 12)
            label9.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label10 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label10.Size = size
            Me.lblUser.TabIndex = 294
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1017, 578)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmPayrollRecord"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            Me.groupBox5.ResumeLayout(False)
            Me.groupBox5.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
