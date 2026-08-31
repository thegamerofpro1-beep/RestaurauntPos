Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmWPReport_CRViewer
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("CrystalReportViewer1")>
        Private _CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmailID")>
        Private _txtEmailID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSendMail")>
        Private _btnSendMail As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPrint")>
        Private _btnPrint As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateTo")>
        Private _dtpDateTo As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateFrom")>
        Private _dtpDateFrom As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        Private a As Double

        Private b As Double

        Private b1 As Double

        Private b2 As Double

        Private b3 As Double

        Private b4 As Double

        Private b5 As Double

        Private Z1 As Double

        Private Z2 As Double

        Private G1 As Double

        Private G2 As Double

        Private G3 As Double

        Private G4 As Double

        Private T1 As Double

        Private G5 As Double

        Private D1 As Double

        Private M3 As Double

        Private M4 As Double

        Private CX As Double

        Private S1 As Double

        Private S2 As Double

        Private S3 As Double

        Private S4 As Double

        Private S5 As Double

        Private M1 As Integer

        Private M2 As Integer

        Private TC As Integer

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._CrystalReportViewer1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CrystalDecisions.Windows.Forms.CrystalReportViewer)
                Me._CrystalReportViewer1 = value
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

        Friend Overridable Property txtEmailID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmailID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtEmailID_KeyPress
                Dim value3 As System.ComponentModel.CancelEventHandler = AddressOf Me.txtEmailID_Validating
                If Me._txtEmailID IsNot Nothing Then
                    RemoveHandler Me._txtEmailID.KeyPress, value2
                    RemoveHandler Me._txtEmailID.Validating, value3
                End If

                Me._txtEmailID = value
                If Me._txtEmailID IsNot Nothing Then
                    AddHandler Me._txtEmailID.KeyPress, value2
                    AddHandler Me._txtEmailID.Validating, value3
                End If
            End Set
        End Property

        Friend Overridable Property btnSendMail As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSendMail
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._btnSendMail IsNot Nothing Then
                    RemoveHandler Me._btnSendMail.Click, value2
                End If

                Me._btnSendMail = value
                If Me._btnSendMail IsNot Nothing Then
                    AddHandler Me._btnSendMail.Click, value2
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

        Friend Overridable Property btnPrint As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPrint
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnPrint_Click
                If Me._btnPrint IsNot Nothing Then
                    RemoveHandler Me._btnPrint.Click, value2
                End If

                Me._btnPrint = value
                If Me._btnPrint IsNot Nothing Then
                    AddHandler Me._btnPrint.Click, value2
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

        Friend Overridable Property Button1 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click_1
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, value2
                End If

                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmWPReport_CRViewer_Load
            Call RestaurantPOS14.frmWPReport_CRViewer.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmWPReport_CRViewer.__ENCList
                If RestaurantPOS14.frmWPReport_CRViewer.__ENCList.Count = RestaurantPOS14.frmWPReport_CRViewer.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmWPReport_CRViewer.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmWPReport_CRViewer.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmWPReport_CRViewer.__ENCList(num) = RestaurantPOS14.frmWPReport_CRViewer.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmWPReport_CRViewer.__ENCList.RemoveRange(num, RestaurantPOS14.frmWPReport_CRViewer.__ENCList.Count - num)
                    RestaurantPOS14.frmWPReport_CRViewer.__ENCList.Capacity = RestaurantPOS14.frmWPReport_CRViewer.__ENCList.Count
                End If

                Call RestaurantPOS14.frmWPReport_CRViewer.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub txtEmailID_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            Dim text As String = "@"
            If e.KeyChar <> Global.Microsoft.VisualBasic.Strings.ChrW(8) AndAlso ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 97) Or (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 122)) AndAlso ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) <> 46) And (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) <> 95)) AndAlso ((Microsoft.VisualBasic.Strings.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Strings.Asc(e.KeyChar) > 57)) Then
                If text.IndexOf(e.KeyChar) = -1 Then
                    e.Handled = True
                ElseIf Me.txtEmailID.Text.Contains("@") And (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(e.KeyChar), "@", TextCompare:=False) = 0) Then
                    e.Handled = True
                End If
            End If
        End Sub

        Private Sub txtEmailID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
            Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
            If Not System.Text.RegularExpressions.Regex.Match(CStr((Me.txtEmailID.Text.Trim())), CStr((pattern)), CType((System.Text.RegularExpressions.RegexOptions.IgnoreCase), System.Text.RegularExpressions.RegexOptions)).Success Then
                Call System.Windows.Forms.MessageBox.Show("Please enter a valid email id", "Checking", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.txtEmailID.Clear()
            End If
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtEmailID.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter Email ID", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtEmailID.Focus()
                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select count(*) from EmailSetting Having count(*) <=0")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog15.ShowDialog()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                If Not RestaurantPOS14.ModFunc.CheckForInternetConnection() Then
                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select RTRIM(Username),RTRIM(Password),RTRIM(SMTPAddress),(Port) from EmailSetting where IsDefault='Yes' and IsActive='Yes'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If sqlDataReader.Read() Then
                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer1.Enabled = True
                    Dim reportSource As Object = Me.CrystalReportViewer1.ReportSource
                    Dim text As String = RestaurantPOS14.Customization.CrystalReportExporter.Export(reportSource, reportSource.GetType().Name, "WorkPeriodReport")

                    RestaurantPOS14.ModFunc.SendMail1(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0)), Me.txtEmailID.Text, "Please find the attachment below", text, "Work Period Report", Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(2)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(sqlDataReader.GetValue(3)), Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0)), RestaurantPOS14.ModFunc.Decrypt(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(1))))
                    sqlDataReader?.Close()
                    Call System.Windows.Forms.MessageBox.Show("Successfully send", "Mail", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub frmWPReport_CRViewer_Load(sender As Object, e As System.EventArgs)
        End Sub

        Private Sub btnPrint_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim value As System.DateTime = Me.dtpDateFrom.Value
                Dim value2 As System.DateTime = Me.dtpDateTo.Value
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT * from Hotel", RestaurantPOS14.ModClasses.con)
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlCommand3 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Operator,Sum(GrandTotal) as [GrandTotal] from(Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select Operator,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Operator order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand3.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand3.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand3.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand3)
                Dim sqlCommand4 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(TotalAmount) as Total from (Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,(TotalAmount) as [TotalAmount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand4.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand4.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand4.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand4)
                Dim sqlCommand5 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(Quantity) as TotalQuantity from (Select category,Quantity from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d5 and BillDate < @d6 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d5 and BillDate < @d6 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d5 and BillDate < @d6 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,Quantity from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d5 and BillDate < @d6 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand5.Parameters.Add(CStr(("@d5")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand5.Parameters.Add(CStr(("@d6")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand5.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand5)
                Dim sqlCommand6 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Dish order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand6.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand6.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand6.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand6)
                Dim sqlCommand7 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT PaymentMode,IsNull(Sum(Card),0) as [Card] from (Select PaymentMode,Card as [Card] from RestaurantPOS_BillingInfoKOT where BillDate >=@d11 and BillDate < @d12 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,GrandTotal as [Card] from RestaurantPOS_BillingInfoHD where BillDate >=@d11 and BillDate < @d12 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union all Select PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoEB where BillDate >=@d11 and BillDate < @d12 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card'))G  group by PaymentMode order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand7.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand7.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand7.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand7)
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand8 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(HomeDeliveryCharges),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d9 and BillDate < @d10 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand8.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand8.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand8.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand8.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand8.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand9 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(ParcelCharges*ExchangeRate),0) from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand9.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand9.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand9.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand9.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand9.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand10 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoKOT where BillDate >=@d13 and BillDate < @d14 and DIB_Status not in ('Unpaid','Changed to Split Bill')")
                sqlCommand10.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand10.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand10.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand10.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand10.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand11 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoTA where BillDate >=@d13 and BillDate < @d14 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand11.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand11.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand11.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand11.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand11.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand12 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal),0)  from RestaurantPOS_BillingInfoHD where BillDate >=@d13 and BillDate < @d14 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand12.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand12.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand12.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand12.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand12.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand13 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoEB where BillDate >=@d13 and BillDate < @d14 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand13.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand13.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand13.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand13.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand13.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand14 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(TotalVAT) as TotalVAT,SUM(TotalDiscount) as TotalDicount from (Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand14.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand14.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand14.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand14.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand14.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.D1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand15 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(LA) as [LA] from(Select LA as [LA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select LA as [LA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select LA as [LA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select LA as [LA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand15.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand15.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand15.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand15.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand15.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand16 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(GCA) as [GCA] from(Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand16.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand16.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand16.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand16.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand16.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand17 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Cash' Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand17.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand17.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand17.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand17.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand17.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand18 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card')G")
                sqlCommand18.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand18.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand18.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand18.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand18.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand19 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Debit Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Debit Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card')G")
                sqlCommand19.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand19.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand19.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand19.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand19.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand20 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='VIP Member Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='VIP Member Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card')G")
                sqlCommand20.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand20.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand20.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand20.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand20.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand21 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(GrandTotal),0) as [GrandTotal] from(Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Customer'  Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer')G")
                sqlCommand21.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand21.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand21.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand21.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand21.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand22 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(TIP),0) as [TIP] from(Select Tip as [TIP] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') )G")
                sqlCommand22.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand22.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand22.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand22.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand22.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.T1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand23 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(NoOfPerson),0) from RestaurantPOS_OrderInfoKOT where BillDate >=@d9 and BillDate < @d10 and KOT_Status <> 'Void'")
                sqlCommand23.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand23.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand23.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand23.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand23.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.TC = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand24 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNULL(Count(Case when Canceled_Deleted ='Canceled' then 1 else NULL end),0),IsNULL(Count(Case when Canceled_Deleted ='Deleted' then 1 else NULL end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Canceled') then GrandTotal else 0 end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Deleted') then GrandTotal else 0 end),0) from DeletedInvoices where deletedDate >=@d13 and DeletedDate < @d14")
                sqlCommand24.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand24.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand24.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand24.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand24.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.M1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.M2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.M3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.M4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand25 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT iSNULL(SUM(TotalDiscount),0) as TotalDiscount from (Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand25.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand25.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand25.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand25.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand25.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.CX = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Me.S1 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from Payment where Date >=@d1 and Date < @d2", value, value2)
                Me.S2 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from CreditCustomerPayment where Date >=@d1 and Date < @d2", value, value2)
                Me.S3 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from Voucher where Date >=@d1 and Date < @d2", value, value2)
                Me.S4 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", value, value2)
                Me.S5 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0)-IsNull(Sum(AmtReceived),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", value, value2)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable3 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable4 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable5 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable6 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                sqlDataAdapter3.Fill(dataTable3)
                sqlDataAdapter4.Fill(dataTable4)
                sqlDataAdapter5.Fill(dataTable5)
                sqlDataAdapter6.Fill(dataTable6)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.Tables.Add(dataTable3)
                dataSet.Tables.Add(dataTable4)
                dataSet.Tables.Add(dataTable5)
                dataSet.Tables.Add(dataTable6)
                dataSet.WriteXmlSchema("RPOSLatest.xml")
                Dim rptRPOS3 As RestaurantPOS14.rptRPOS1 = New RestaurantPOS14.rptRPOS1()
                rptRPOS3.Subreports(CInt((0))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((1))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((2))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((3))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((4))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((5))).SetDataSource(dataSet)
                rptRPOS3.SetDataSource(dataSet)
                rptRPOS3.SetParameterValue("p1", value.ToString("dd/MM/yyyy hh:mm:ss tt"))
                rptRPOS3.SetParameterValue("p2", value2.ToString("dd/MM/yyyy hh:mm:ss tt"))
                rptRPOS3.SetParameterValue("p3", Me.a)
                rptRPOS3.SetParameterValue("p4", Me.b)
                rptRPOS3.SetParameterValue("p5", Me.a)
                rptRPOS3.SetParameterValue("p6", Me.b)
                rptRPOS3.SetParameterValue("b1", Me.b1)
                rptRPOS3.SetParameterValue("b2", Me.b2)
                rptRPOS3.SetParameterValue("b3", Me.b3)
                rptRPOS3.SetParameterValue("b4", Me.b4)
                rptRPOS3.SetParameterValue("b1x", Me.b1)
                rptRPOS3.SetParameterValue("b2x", Me.b2)
                rptRPOS3.SetParameterValue("b3x", Me.b3)
                rptRPOS3.SetParameterValue("b4x", Me.b4)
                rptRPOS3.SetParameterValue("b5", Me.b5)
                rptRPOS3.SetParameterValue("Z1", Me.Z1)
                rptRPOS3.SetParameterValue("Z2", Me.Z2)
                rptRPOS3.SetParameterValue("Z3", Me.Z1)
                rptRPOS3.SetParameterValue("Z4", Me.Z2)
                rptRPOS3.SetParameterValue("G1", Me.G1)
                rptRPOS3.SetParameterValue("G2", Me.G2)
                rptRPOS3.SetParameterValue("G3", Me.G3)
                rptRPOS3.SetParameterValue("G4", Me.G4)
                rptRPOS3.SetParameterValue("G5", Me.G5)
                rptRPOS3.SetParameterValue("T1", Me.T1)
                rptRPOS3.SetParameterValue("T2", Me.T1)
                rptRPOS3.SetParameterValue("T3", Me.T1)
                rptRPOS3.SetParameterValue("CS", Me.TC)
                rptRPOS3.SetParameterValue("D1", Me.D1)
                rptRPOS3.SetParameterValue("M1", Me.M1)
                rptRPOS3.SetParameterValue("M2", Me.M2)
                rptRPOS3.SetParameterValue("M3", Me.M3)
                rptRPOS3.SetParameterValue("M4", Me.M4)
                rptRPOS3.SetParameterValue("CX", Me.CX)
                rptRPOS3.SetParameterValue("S1", Me.S1)
                rptRPOS3.SetParameterValue("S2", Me.S2)
                rptRPOS3.SetParameterValue("S3", Me.S3)
                rptRPOS3.SetParameterValue("S4", Me.S4)
                rptRPOS3.SetParameterValue("S5", Me.S5)
                RestaurantPOS14.ModFunc.GetPrinterName(System.Net.Dns.GetHostName(), rptRPOS3)
                rptRPOS3.Close()
                rptRPOS3.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button1_Click_1(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim value As System.DateTime = Me.dtpDateFrom.Value
                Dim value2 As System.DateTime = Me.dtpDateTo.Value
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Sorry..No record found between selected dates", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand2 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT * from Hotel", RestaurantPOS14.ModClasses.con)
                Dim sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand2)
                sqlCommand2.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlCommand3 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Operator,Sum(GrandTotal) as [GrandTotal] from(Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select Operator,GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Operator,(GrandTotal*ExchangeRate) as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Operator order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand3.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand3.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand3.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand3)
                Dim sqlCommand4 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(TotalAmount) as Total from (Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,(TotalAmount) as [TotalAmount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand4.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand4.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand4.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand4)
                Dim sqlCommand5 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(Quantity) as TotalQuantity from (Select category,Quantity from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d5 and BillDate < @d6 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d5 and BillDate < @d6 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d5 and BillDate < @d6 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,Quantity from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d5 and BillDate < @d6 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand5.Parameters.Add(CStr(("@d5")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand5.Parameters.Add(CStr(("@d6")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand5.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand5)
                Dim sqlCommand6 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Dish order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand6.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand6.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand6.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand6)
                Dim sqlCommand7 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT PaymentMode,IsNull(Sum(Card),0) as [Card] from (Select PaymentMode,Card as [Card] from RestaurantPOS_BillingInfoKOT where BillDate >=@d11 and BillDate < @d12 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,GrandTotal as [Card] from RestaurantPOS_BillingInfoHD where BillDate >=@d11 and BillDate < @d12 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union all Select PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoEB where BillDate >=@d11 and BillDate < @d12 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card'))G  group by PaymentMode order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand7.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand7.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand7.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand7)
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand8 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(HomeDeliveryCharges),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d9 and BillDate < @d10 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand8.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand8.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand8.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand8.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand8.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.a = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand9 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(ParcelCharges*ExchangeRate),0) from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand9.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand9.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand9.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand9.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand9.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand10 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoKOT where BillDate >=@d13 and BillDate < @d14 and DIB_Status not in ('Unpaid','Changed to Split Bill')")
                sqlCommand10.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand10.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand10.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand10.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand10.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand11 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoTA where BillDate >=@d13 and BillDate < @d14 and TA_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand11.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand11.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand11.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand11.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand11.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand12 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal),0)  from RestaurantPOS_BillingInfoHD where BillDate >=@d13 and BillDate < @d14 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand12.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand12.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand12.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand12.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand12.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand13 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(GrandTotal*ExchangeRate),0)  from RestaurantPOS_BillingInfoEB where BillDate >=@d13 and BillDate < @d14 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand13.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand13.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand13.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand13.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand13.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand14 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(TotalVAT) as TotalVAT,SUM(TotalDiscount) as TotalDicount from (Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select VATAmount as [TotalVAT],DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand14.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand14.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand14.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand14.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand14.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.b5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.D1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand15 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(LA) as [LA] from(Select LA as [LA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select LA as [LA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select LA as [LA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select LA as [LA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand15.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand15.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand15.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand15.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand15.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand16 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Sum(GCA) as [GCA] from(Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select GiftCardAmount as [GCA] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand16.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand16.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand16.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand16.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand16.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.Z2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand17 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from(Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill')  Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Cash' Union all Select Cash - Change as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))G")
                sqlCommand17.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand17.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand17.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand17.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand17.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand18 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Card')G")
                sqlCommand18.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand18.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand18.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand18.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand18.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand19 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("Select IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Debit Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Debit Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Debit Card')G")
                sqlCommand19.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand19.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand19.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand19.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand19.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand20 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(Cash),0) as [Cash] from( Select Card as [Cash] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='VIP Member Card'  Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card' Union all Select GrandTotal as [Cash] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='VIP Member Card' Union all  Select Card as [Cash] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='VIP Member Card')G")
                sqlCommand20.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand20.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand20.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand20.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand20.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand21 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(GrandTotal),0) as [GrandTotal] from(Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode='Credit Customer'  Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode='Credit Customer' Union all Select GrandTotal as [GrandTotal] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode='Credit Customer')G")
                sqlCommand21.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand21.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand21.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand21.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand21.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.G5 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand22 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNull(Sum(TIP),0) as [TIP] from(Select Tip as [TIP] from RestaurantPOS_BillingInfoKOT where BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoTA where BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoHD where BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')  Union all Select TIP as [TIP] from RestaurantPOS_BillingInfoEB where BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared') )G")
                sqlCommand22.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand22.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand22.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand22.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand22.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.T1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand23 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(NoOfPerson),0) from RestaurantPOS_OrderInfoKOT where BillDate >=@d9 and BillDate < @d10 and KOT_Status <> 'Void'")
                sqlCommand23.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand23.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand23.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand23.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand23.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.TC = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand24 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT IsNULL(Count(Case when Canceled_Deleted ='Canceled' then 1 else NULL end),0),IsNULL(Count(Case when Canceled_Deleted ='Deleted' then 1 else NULL end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Canceled') then GrandTotal else 0 end),0),IsNULL(Sum(Case when Canceled_Deleted in ('Deleted') then GrandTotal else 0 end),0) from DeletedInvoices where deletedDate >=@d13 and DeletedDate < @d14")
                sqlCommand24.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand24.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand24.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand24.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand24.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.M1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    Me.M2 = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(1))
                    Me.M3 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(2))
                    Me.M4 = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(3))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand25 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT iSNULL(SUM(TotalDiscount),0) as TotalDiscount from (Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select DiscountAmount as [TotalDiscount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and PaymentMode='Complimentary' and EB_Status not in ('Void','Unpaid','Prepared'))C")
                sqlCommand25.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value
                sqlCommand25.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = value2
                sqlCommand25.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand25.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand25.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.CX = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Me.S1 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from Payment where Date >=@d1 and Date < @d2", value, value2)
                Me.S2 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from CreditCustomerPayment where Date >=@d1 and Date < @d2", value, value2)
                Me.S3 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from Voucher where Date >=@d1 and Date < @d2", value, value2)
                Me.S4 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", value, value2)
                Me.S5 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0)-IsNull(Sum(AmtReceived),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", value, value2)
                Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable2 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable3 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable4 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable5 As System.Data.DataTable = New System.Data.DataTable()
                Dim dataTable6 As System.Data.DataTable = New System.Data.DataTable()
                sqlDataAdapter.Fill(dataTable)
                sqlDataAdapter2.Fill(dataTable2)
                sqlDataAdapter3.Fill(dataTable3)
                sqlDataAdapter4.Fill(dataTable4)
                sqlDataAdapter5.Fill(dataTable5)
                sqlDataAdapter6.Fill(dataTable6)
                Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
                dataSet.Tables.Add(dataTable)
                dataSet.Tables.Add(dataTable2)
                dataSet.Tables.Add(dataTable3)
                dataSet.Tables.Add(dataTable4)
                dataSet.Tables.Add(dataTable5)
                dataSet.Tables.Add(dataTable6)
                dataSet.WriteXmlSchema("RPOSLatest.xml")
                Dim rptRPOS3 As RestaurantPOS14.rptRPOS2 = New RestaurantPOS14.rptRPOS2()
                rptRPOS3.Subreports(CInt((0))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((1))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((2))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((3))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((4))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((5))).SetDataSource(dataSet)
                rptRPOS3.SetDataSource(dataSet)
                rptRPOS3.SetParameterValue("p1", value.ToString("dd/MM/yyyy hh:mm:ss tt"))
                rptRPOS3.SetParameterValue("p2", value2.ToString("dd/MM/yyyy hh:mm:ss tt"))
                rptRPOS3.SetParameterValue("p3", Me.a)
                rptRPOS3.SetParameterValue("p4", Me.b)
                rptRPOS3.SetParameterValue("p5", Me.a)
                rptRPOS3.SetParameterValue("p6", Me.b)
                rptRPOS3.SetParameterValue("b1", Me.b1)
                rptRPOS3.SetParameterValue("b2", Me.b2)
                rptRPOS3.SetParameterValue("b3", Me.b3)
                rptRPOS3.SetParameterValue("b4", Me.b4)
                rptRPOS3.SetParameterValue("b1x", Me.b1)
                rptRPOS3.SetParameterValue("b2x", Me.b2)
                rptRPOS3.SetParameterValue("b3x", Me.b3)
                rptRPOS3.SetParameterValue("b4x", Me.b4)
                rptRPOS3.SetParameterValue("b5", Me.b5)
                rptRPOS3.SetParameterValue("Z1", Me.Z1)
                rptRPOS3.SetParameterValue("Z2", Me.Z2)
                rptRPOS3.SetParameterValue("Z3", Me.Z1)
                rptRPOS3.SetParameterValue("Z4", Me.Z2)
                rptRPOS3.SetParameterValue("G1", Me.G1)
                rptRPOS3.SetParameterValue("G2", Me.G2)
                rptRPOS3.SetParameterValue("G3", Me.G3)
                rptRPOS3.SetParameterValue("G4", Me.G4)
                rptRPOS3.SetParameterValue("G5", Me.G5)
                rptRPOS3.SetParameterValue("T1", Me.T1)
                rptRPOS3.SetParameterValue("T2", Me.T1)
                rptRPOS3.SetParameterValue("T3", Me.T1)
                rptRPOS3.SetParameterValue("CS", Me.TC)
                rptRPOS3.SetParameterValue("D1", Me.D1)
                rptRPOS3.SetParameterValue("M1", Me.M1)
                rptRPOS3.SetParameterValue("M2", Me.M2)
                rptRPOS3.SetParameterValue("M3", Me.M3)
                rptRPOS3.SetParameterValue("M4", Me.M4)
                rptRPOS3.SetParameterValue("CX", Me.CX)
                rptRPOS3.SetParameterValue("S1", Me.S1)
                rptRPOS3.SetParameterValue("S2", Me.S2)
                rptRPOS3.SetParameterValue("S3", Me.S3)
                rptRPOS3.SetParameterValue("S4", Me.S4)
                rptRPOS3.SetParameterValue("S5", Me.S5)
                RestaurantPOS14.ModFunc.GetPrinterName(System.Net.Dns.GetHostName(), rptRPOS3)
                rptRPOS3.Close()
                rptRPOS3.Dispose()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmWPReport_CRViewer))
            Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.txtEmailID = New System.Windows.Forms.TextBox()
            Me.btnSendMail = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
            Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
            Me.Button1 = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.CrystalReportViewer1.ActiveViewIndex = -1
            Me.CrystalReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.[Default]
            Dim crystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer = Me.CrystalReportViewer1
            Dim location As System.Drawing.Point = New System.Drawing.Point(2, 68)
            crystalReportViewer.Location = location
            Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
            Me.CrystalReportViewer1.ShowLogo = False
            Me.CrystalReportViewer1.ShowPrintButton = False
            Dim crystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer = Me.CrystalReportViewer1
            Dim size As System.Drawing.Size = New System.Drawing.Size(855, 448)
            crystalReportViewer2.Size = size
            Me.CrystalReportViewer1.TabIndex = 0
            Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(8, 4)
            label.Location = location
            Me.Label4.Name = "Label4"
            Dim label2 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(139, 24)
            label2.Size = size
            Me.Label4.TabIndex = 19
            Me.Label4.Text = "Enter Email ID :"
            Me.txtEmailID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
            Me.txtEmailID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.txtEmailID.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtEmailID
            location = New System.Drawing.Point(12, 33)
            textBox.Location = location
            Me.txtEmailID.Name = "txtEmailID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtEmailID
            size = New System.Drawing.Size(265, 29)
            textBox2.Size = size
            Me.txtEmailID.TabIndex = 18
            Me.btnSendMail.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnSendMail.FlatAppearance.BorderSize = 0
            Me.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSendMail.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSendMail.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnSendMail
            location = New System.Drawing.Point(589, 3)
            button.Location = location
            Me.btnSendMail.Name = "btnSendMail"
            Dim button2 As System.Windows.Forms.Button = Me.btnSendMail
            size = New System.Drawing.Size(147, 58)
            button2.Size = size
            Me.btnSendMail.TabIndex = 20
            Me.btnSendMail.Text = "&Send Email"
            Me.btnSendMail.UseVisualStyleBackColor = False
            Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnPrint.FlatAppearance.BorderSize = 0
            Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPrint.ForeColor = System.Drawing.Color.White
            Dim button3 As System.Windows.Forms.Button = Me.btnPrint
            location = New System.Drawing.Point(436, 4)
            button3.Location = location
            Me.btnPrint.Name = "btnPrint"
            Dim button4 As System.Windows.Forms.Button = Me.btnPrint
            size = New System.Drawing.Size(147, 57)
            button4.Size = size
            Me.btnPrint.TabIndex = 111
            Me.btnPrint.Text = "&Print with Items Ordered"
            Me.btnPrint.UseVisualStyleBackColor = False
            Me.dtpDateTo.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
            Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            location = New System.Drawing.Point(717, 30)
            dateTimePicker.Location = location
            Me.dtpDateTo.Name = "dtpDateTo"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            size = New System.Drawing.Size(156, 20)
            dateTimePicker2.Size = size
            Me.dtpDateTo.TabIndex = 113
            Me.dtpDateTo.Visible = False
            Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
            Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker3 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            location = New System.Drawing.Point(705, 4)
            dateTimePicker3.Location = location
            Me.dtpDateFrom.Name = "dtpDateFrom"
            Dim dateTimePicker4 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            size = New System.Drawing.Size(152, 20)
            dateTimePicker4.Size = size
            Me.dtpDateFrom.TabIndex = 112
            Me.dtpDateFrom.Visible = False
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.ForeColor = System.Drawing.Color.White
            Dim button5 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(283, 4)
            button5.Location = location
            Me.Button1.Name = "Button1"
            Dim button6 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(147, 57)
            button6.Size = size
            Me.Button1.TabIndex = 114
            Me.Button1.Text = "&Print without Items Ordered"
            Me.Button1.UseVisualStyleBackColor = False
            MyBase.AcceptButton = Me.btnSendMail
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(855, 528)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Button1)
            MyBase.Controls.Add(Me.dtpDateTo)
            MyBase.Controls.Add(Me.dtpDateFrom)
            MyBase.Controls.Add(Me.btnPrint)
            MyBase.Controls.Add(Me.btnSendMail)
            MyBase.Controls.Add(Me.Label4)
            MyBase.Controls.Add(Me.txtEmailID)
            MyBase.Controls.Add(Me.CrystalReportViewer1)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmWPReport_CRViewer"
            Me.Text = "Work Period Report"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
