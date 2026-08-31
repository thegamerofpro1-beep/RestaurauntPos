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
    Public Class frmDeliveryPersonLedger
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateTo")>
        Private _dtpDateTo As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateFrom")>
        Private _dtpDateFrom As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDPName")>
        Private _txtDPName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDPID")>
        Private _txtDPID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSelection")>
        Private _btnSelection As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button3")>
        Private _Button3 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker1")>
        Private _DateTimePicker1 As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("DateTimePicker2")>
        Private _DateTimePicker2 As System.Windows.Forms.DateTimePicker

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

        Friend Overridable Property Label3 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label3 = value
            End Set
        End Property

        Friend Overridable Property txtDPName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDPName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDPName = value
            End Set
        End Property

        Friend Overridable Property txtDPID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDPID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDPID = value
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

        Friend Overridable Property btnSelection As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSelection
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSelection_Click
                If Me._btnSelection IsNot Nothing Then
                    RemoveHandler Me._btnSelection.Click, value2
                End If

                Me._btnSelection = value
                If Me._btnSelection IsNot Nothing Then
                    AddHandler Me._btnSelection.Click, value2
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

        Friend Overridable Property DateTimePicker1 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker1 = value
            End Set
        End Property

        Friend Overridable Property Label8 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label8 = value
            End Set
        End Property

        Friend Overridable Property Label9 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label9 = value
            End Set
        End Property

        Friend Overridable Property DateTimePicker2 As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._DateTimePicker2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._DateTimePicker2 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmDeliveryPersonLedger.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmDeliveryPersonLedger.__ENCList
                If RestaurantPOS14.frmDeliveryPersonLedger.__ENCList.Count = RestaurantPOS14.frmDeliveryPersonLedger.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmDeliveryPersonLedger.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmDeliveryPersonLedger.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmDeliveryPersonLedger.__ENCList(num) = RestaurantPOS14.frmDeliveryPersonLedger.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmDeliveryPersonLedger.__ENCList.RemoveRange(num, RestaurantPOS14.frmDeliveryPersonLedger.__ENCList.Count - num)
                    RestaurantPOS14.frmDeliveryPersonLedger.__ENCList.Capacity = RestaurantPOS14.frmDeliveryPersonLedger.__ENCList.Count
                End If

                Call RestaurantPOS14.frmDeliveryPersonLedger.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.dtpDateFrom.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.dtpDateTo.Value = Microsoft.VisualBasic.DateAndTime.Now
            Me.DateTimePicker2.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.DateTimePicker1.Value = Microsoft.VisualBasic.DateAndTime.Now
            Me.txtDPName.Text = ""
            Me.txtDPID.Text = ""
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtDPName.Text)) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please retrieve delivery person information", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtDPName.Focus()
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.CustomerName, RestaurantPOS_BillingInfoHD.ContactNo,RestaurantPOS_BillingInfoHD.GrandTotal FROM RestaurantPOS_BillingInfoHD INNER JOIN EmployeeRegistration ON RestaurantPOS_BillingInfoHD.Employee_ID = EmployeeRegistration.EmpId where EmployeeID=@d1 and BillDate >=@d2 and BillDate < @d3 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtDPID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.CustomerName, RestaurantPOS_BillingInfoHD.ContactNo,RestaurantPOS_BillingInfoHD.GrandTotal,HD_Status,AmtReceived FROM RestaurantPOS_BillingInfoHD INNER JOIN EmployeeRegistration ON RestaurantPOS_BillingInfoHD.Employee_ID = EmployeeRegistration.EmpId where EmployeeID=@d1 and BillDate >=@d2 and BillDate < @d3 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash') order by BillDate", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateFrom.Value
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.dtpDateTo.Value
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtDPID.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("CollectionsByDPX1.xml")
                Dim rptCollectionsByDP2 As RestaurantPOS14.rptCollectionsByDP = New RestaurantPOS14.rptCollectionsByDP()
                rptCollectionsByDP2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptCollectionsByDP2.SetParameterValue("p1", Me.dtpDateFrom.Value)
                rptCollectionsByDP2.SetParameterValue("p2", Me.dtpDateTo.Value)
                rptCollectionsByDP2.SetParameterValue("p3", Me.txtDPID.Text)
                rptCollectionsByDP2.SetParameterValue("p4", Me.txtDPName.Text)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptCollectionsByDP2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnSelection_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmEmployeesRecord.lblSet.Text = "Collections Report"
            Call RestaurantPOS14.My.MyProject.Forms.frmEmployeesRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmEmployeesRecord.ShowDialog()
        End Sub

        Private Sub Button3_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.CustomerName, RestaurantPOS_BillingInfoHD.ContactNo,RestaurantPOS_BillingInfoHD.GrandTotal FROM RestaurantPOS_BillingInfoHD INNER JOIN EmployeeRegistration ON RestaurantPOS_BillingInfoHD.Employee_ID = EmployeeRegistration.EmpId where BillDate >=@d2 and BillDate < @d3 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker2.Value
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker1.Value
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry...No record found", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RestaurantPOS_BillingInfoHD.BillNo, RestaurantPOS_BillingInfoHD.BillDate, RestaurantPOS_BillingInfoHD.CustomerName, RestaurantPOS_BillingInfoHD.ContactNo,EmployeeRegistration.EmployeeName,RestaurantPOS_BillingInfoHD.GrandTotal,HD_Status,AmtReceived FROM RestaurantPOS_BillingInfoHD INNER JOIN EmployeeRegistration ON RestaurantPOS_BillingInfoHD.Employee_ID = EmployeeRegistration.EmpId where BillDate >=@d2 and BillDate < @d3 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash') order by BillDate", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker2.Value
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("Date"))).Value = Me.DateTimePicker1.Value
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("CollectionsByDP1X1.xml")
                Dim rptCollectionsByDP2 As RestaurantPOS14.rptCollectionsByDP1 = New RestaurantPOS14.rptCollectionsByDP1()
                rptCollectionsByDP2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptCollectionsByDP2.SetParameterValue("p1", Me.dtpDateFrom.Value)
                rptCollectionsByDP2.SetParameterValue("p2", Me.dtpDateTo.Value)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptCollectionsByDP2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmDeliveryPersonLedger))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.btnSelection = New System.Windows.Forms.Button()
            Me.txtDPName = New System.Windows.Forms.TextBox()
            Me.txtDPID = New System.Windows.Forms.TextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(7, 7)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(919, 238)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox1.Controls.Add(Me.Button3)
            Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(9, 156)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(435, 75)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search by Date"
            Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button As System.Windows.Forms.Button = Me.Button3
            location = New System.Drawing.Point(331, 39)
            button.Location = location
            Me.Button3.Name = "Button3"
            Dim button2 As System.Windows.Forms.Button = Me.Button3
            size = New System.Drawing.Size(94, 20)
            button2.Size = size
            Me.Button3.TabIndex = 3
            Me.Button3.Text = "View Report"
            Me.Button3.UseVisualStyleBackColor = True
            Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt"
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.DateTimePicker1
            location = New System.Drawing.Point(175, 39)
            dateTimePicker.Location = location
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker1
            size = New System.Drawing.Size(150, 20)
            dateTimePicker2.Size = size
            Me.DateTimePicker1.TabIndex = 2
            Me.Label8.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(172, 20)
            label.Location = location
            Me.Label8.Name = "Label8"
            Dim label2 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(26, 13)
            label2.Size = size
            Me.Label8.TabIndex = 13
            Me.Label8.Text = "To :"
            Me.Label9.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(16, 20)
            label3.Location = location
            Me.Label9.Name = "Label9"
            Dim label4 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(36, 13)
            label4.Size = size
            Me.Label9.TabIndex = 12
            Me.Label9.Text = "From :"
            Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm tt"
            Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker3 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker2
            location = New System.Drawing.Point(19, 39)
            dateTimePicker3.Location = location
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Dim dateTimePicker4 As System.Windows.Forms.DateTimePicker = Me.DateTimePicker2
            size = New System.Drawing.Size(150, 20)
            dateTimePicker4.Size = size
            Me.DateTimePicker2.TabIndex = 1
            Me.GroupBox2.Controls.Add(Me.btnSelection)
            Me.GroupBox2.Controls.Add(Me.txtDPName)
            Me.GroupBox2.Controls.Add(Me.txtDPID)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.Label3)
            Me.GroupBox2.Controls.Add(Me.Button1)
            Me.GroupBox2.Controls.Add(Me.dtpDateTo)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.dtpDateFrom)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(9, 75)
            groupBox3.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(701, 75)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 0
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search by Delivery Person and Date"
            Dim button3 As System.Windows.Forms.Button = Me.btnSelection
            location = New System.Drawing.Point(216, 18)
            button3.Location = location
            Me.btnSelection.Name = "btnSelection"
            Dim button4 As System.Windows.Forms.Button = Me.btnSelection
            size = New System.Drawing.Size(29, 21)
            button4.Size = size
            Me.btnSelection.TabIndex = 0
            Me.btnSelection.Text = "..."
            Me.btnSelection.UseVisualStyleBackColor = True
            Dim textBox As System.Windows.Forms.TextBox = Me.txtDPName
            location = New System.Drawing.Point(110, 45)
            textBox.Location = location
            Me.txtDPName.Name = "txtDPName"
            Me.txtDPName.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtDPName
            size = New System.Drawing.Size(159, 20)
            textBox2.Size = size
            Me.txtDPName.TabIndex = 5
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtDPID
            location = New System.Drawing.Point(110, 19)
            textBox3.Location = location
            Me.txtDPID.Name = "txtDPID"
            Me.txtDPID.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtDPID
            size = New System.Drawing.Size(100, 20)
            textBox4.Size = size
            Me.txtDPID.TabIndex = 4
            Me.Label5.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(16, 45)
            label5.Location = location
            Me.Label5.Name = "Label5"
            Dim label6 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(59, 13)
            label6.Size = size
            Me.Label5.TabIndex = 17
            Me.Label5.Text = "DP Name :"
            Me.Label3.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(16, 19)
            label7.Location = location
            Me.Label3.Name = "Label3"
            Dim label8 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(42, 13)
            label8.Size = size
            Me.Label3.TabIndex = 16
            Me.Label3.Text = "DP ID :"
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button5 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(595, 44)
            button5.Location = location
            Me.Button1.Name = "Button1"
            Dim button6 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(94, 20)
            button6.Size = size
            Me.Button1.TabIndex = 3
            Me.Button1.Text = "View Report"
            Me.Button1.UseVisualStyleBackColor = True
            Me.dtpDateTo.CustomFormat = "dd/MM/yyyy hh:mm tt"
            Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker5 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            location = New System.Drawing.Point(439, 45)
            dateTimePicker5.Location = location
            Me.dtpDateTo.Name = "dtpDateTo"
            Dim dateTimePicker6 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            size = New System.Drawing.Size(150, 20)
            dateTimePicker6.Size = size
            Me.dtpDateTo.TabIndex = 2
            Me.Label2.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(436, 26)
            label9.Location = location
            Me.Label2.Name = "Label2"
            Dim label10 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(26, 13)
            label10.Size = size
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "To :"
            Me.Label4.AutoSize = True
            Dim label11 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(272, 26)
            label11.Location = location
            Me.Label4.Name = "Label4"
            Dim label12 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(36, 13)
            label12.Size = size
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "From :"
            Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy hh:mm tt"
            Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker7 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            location = New System.Drawing.Point(275, 45)
            dateTimePicker7.Location = location
            Me.dtpDateFrom.Name = "dtpDateFrom"
            Dim dateTimePicker8 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            size = New System.Drawing.Size(158, 20)
            dateTimePicker8.Size = size
            Me.dtpDateFrom.TabIndex = 1
            Me.GroupBox3.Controls.Add(Me.btnClose)
            Me.GroupBox3.Controls.Add(Me.btnReset)
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(716, 75)
            groupBox5.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(193, 75)
            groupBox6.Size = size
            Me.GroupBox3.TabIndex = 1
            Me.GroupBox3.TabStop = False
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button7 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(100, 33)
            button7.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button8 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(82, 31)
            button8.Size = size
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "&Close"
            Me.btnClose.UseVisualStyleBackColor = True
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button9 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(12, 33)
            button9.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button10 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(82, 32)
            button10.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "&Reset"
            Me.btnReset.UseVisualStyleBackColor = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(900, 62)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label13 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(294, 15)
            label13.Location = location
            Me.Label1.Name = "Label1"
            Dim label14 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(295, 24)
            label14.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Collections By Delivery Person"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(930, 249)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmDeliveryPersonLedger"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
