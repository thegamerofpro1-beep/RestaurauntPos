Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmWorkPeriodReport
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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnViewReport")>
        Private _btnViewReport As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbWorkPeriodEndTime")>
        Private _cmbWorkPeriodEndTime As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbWorkPeriodStartTime")>
        Private _cmbWorkPeriodStartTime As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbKitchen")>
        Private _cmbKitchen As System.Windows.Forms.ComboBox

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

        Private G5 As Double

        Private T1 As Double

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
                Dim value2 As System.EventHandler = AddressOf Me.btnClose_Click
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

        Friend Overridable Property btnViewReport As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnViewReport
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnExportExcel_Click
                If Me._btnViewReport IsNot Nothing Then
                    RemoveHandler Me._btnViewReport.Click, value2
                End If

                Me._btnViewReport = value
                If Me._btnViewReport IsNot Nothing Then
                    AddHandler Me._btnViewReport.Click, value2
                End If
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

        Friend Overridable Property cmbWorkPeriodEndTime As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbWorkPeriodEndTime
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbWorkPeriodEndTime = value
            End Set
        End Property

        Friend Overridable Property cmbWorkPeriodStartTime As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbWorkPeriodStartTime
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbWorkPeriodStartTime_SelectedIndexChanged
                If Me._cmbWorkPeriodStartTime IsNot Nothing Then
                    RemoveHandler Me._cmbWorkPeriodStartTime.SelectedIndexChanged, value2
                End If

                Me._cmbWorkPeriodStartTime = value
                If Me._cmbWorkPeriodStartTime IsNot Nothing Then
                    AddHandler Me._cmbWorkPeriodStartTime.SelectedIndexChanged, value2
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

        Friend Overridable Property Label7 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label7 = value
            End Set
        End Property

        Friend Overridable Property cmbKitchen As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbKitchen
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbKitchen = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmWorkPeriodReport_Load
            Call RestaurantPOS14.frmWorkPeriodReport.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmWorkPeriodReport.__ENCList
                If RestaurantPOS14.frmWorkPeriodReport.__ENCList.Count = RestaurantPOS14.frmWorkPeriodReport.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmWorkPeriodReport.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmWorkPeriodReport.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmWorkPeriodReport.__ENCList(num) = RestaurantPOS14.frmWorkPeriodReport.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmWorkPeriodReport.__ENCList.RemoveRange(num, RestaurantPOS14.frmWorkPeriodReport.__ENCList.Count - num)
                    RestaurantPOS14.frmWorkPeriodReport.__ENCList.Capacity = RestaurantPOS14.frmWorkPeriodReport.__ENCList.Count
                End If

                Call RestaurantPOS14.frmWorkPeriodReport.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.cmbWorkPeriodStartTime.SelectedIndex = -1
            Me.cmbWorkPeriodEndTime.Text = ""
            Me.cmbWorkPeriodEndTime.Enabled = False
            Me.cmbKitchen.SelectedIndex = -1
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbWorkPeriodStartTime.Text, "", TextCompare:=False) = 0 Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog7.ShowDialog()
                    Me.cmbWorkPeriodStartTime.Focus()
                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim dateTime As System.DateTime = System.DateTime.ParseExact(Me.cmbWorkPeriodStartTime.Text, "dd/MM/yyyy hh:mm:ss tt", Nothing)
                Dim dateTime2 As System.DateTime = System.DateTime.ParseExact(Me.cmbWorkPeriodEndTime.Text, "dd/MM/yyyy hh:mm:ss tt", Nothing)
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select Operator from RestaurantPOS_BillingInfoKOT where BillDate >=@d1 and BillDate < @d2 and DIB_Status not in ('Unpaid','Changed to Split Bill') union select Operator from RestaurantPOS_BillingInfoTA where BillDate >=@d1 and BillDate < @d2 and TA_Status not in ('Void','Unpaid','Prepared') union select Operator from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union select Operator from RestaurantPOS_BillingInfoEB where BillDate >=@d1 and BillDate < @d2 and EB_Status not in ('Void','Unpaid','Prepared')")
                sqlCommand.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand3.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand3.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
                sqlCommand3.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand3)
                Dim sqlCommand4 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(TotalAmount) as Total from (Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d3 and BillDate < @d4 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d3 and BillDate < @d4 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,(TotalAmount) as [TotalAmount] from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d3 and BillDate < @d4 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d3 and BillDate < @d4 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand4.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand4.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
                sqlCommand4.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand4)
                Dim sqlCommand5 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Category,Sum(Quantity) as TotalQuantity from (Select category,Quantity from RestaurantPOS_OrderedProductBillKOT, RestaurantPOS_BillingInfoKOT where RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and BillDate >=@d5 and BillDate < @d6 and DIB_Status not in ('Unpaid','Changed to Split Bill') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillTA, RestaurantPOS_BillingInfoTA where RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and BillDate >=@d5 and BillDate < @d6 and TA_Status not in ('Void','Unpaid','Prepared') UNION ALL Select category,Quantity from RestaurantPOS_OrderedProductBillHD, RestaurantPOS_BillingInfoHD where RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and BillDate >=@d5 and BillDate < @d6 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select category,Quantity from RestaurantPOS_OrderedProductBillEB, RestaurantPOS_BillingInfoEB where RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and BillDate >=@d5 and BillDate < @d6 and EB_Status not in ('Void','Unpaid','Prepared'))C group by Category order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand5.Parameters.Add(CStr(("@d5")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand5.Parameters.Add(CStr(("@d6")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
                sqlCommand5.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter4 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand5)
                Dim sqlCommand6 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared'))G  group by Dish order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand6.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand6.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
                sqlCommand6.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter5 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand6)
                Dim sqlCommand7 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("SELECT PaymentMode,IsNull(Sum(Card),0) as [Card] from (Select PaymentMode,Card as [Card] from RestaurantPOS_BillingInfoKOT where BillDate >=@d11 and BillDate < @d12 and DIB_Status not in ('Unpaid','Changed to Split Bill') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoTA where BillDate >=@d11 and BillDate < @d12 and TA_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union All Select  PaymentMode,GrandTotal as [Card] from RestaurantPOS_BillingInfoHD where BillDate >=@d11 and BillDate < @d12 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card') Union all Select PaymentMode,(Card) as [Card] from RestaurantPOS_BillingInfoEB where BillDate >=@d11 and BillDate < @d12 and EB_Status not in ('Void','Unpaid','Prepared') and PaymentMode Not in ('Cash','Credit Card','Debit Card','Credit Customer','VIP Member Card'))G  group by PaymentMode order by 1", RestaurantPOS14.ModClasses.con)
                sqlCommand7.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand7.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
                sqlCommand7.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                Dim sqlDataAdapter6 As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(sqlCommand7)
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim sqlCommand8 As System.Data.SqlClient.SqlCommand = New System.Data.SqlClient.SqlCommand("select IsNull(Sum(HomeDeliveryCharges),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d9 and BillDate < @d10 and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched')")
                sqlCommand8.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand8.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand9.Parameters.Add(CStr(("@d11")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand9.Parameters.Add(CStr(("@d12")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand10.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand10.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand11.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand11.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand12.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand12.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand13.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand13.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand14.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand14.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand15.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand15.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand16.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand16.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand17.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand17.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand18.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand18.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand19.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand19.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand20.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand20.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand21.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand21.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand22.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand22.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand23.Parameters.Add(CStr(("@d9")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand23.Parameters.Add(CStr(("@d10")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand24.Parameters.Add(CStr(("@d13")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand24.Parameters.Add(CStr(("@d14")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
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
                sqlCommand25.Parameters.Add(CStr(("@d3")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                sqlCommand25.Parameters.Add(CStr(("@d4")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
                sqlCommand25.Connection = RestaurantPOS14.ModClasses.con
                sqlCommand25.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = sqlCommand25.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.CX = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Me.S1 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from Payment where Date >=@d1 and Date < @d2", dateTime, dateTime2)
                Me.S2 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(Amount),0) from CreditCustomerPayment where Date >=@d1 and Date < @d2", dateTime, dateTime2)
                Me.S3 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from Voucher where Date >=@d1 and Date < @d2", dateTime, dateTime2)
                Me.S4 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", dateTime, dateTime2)
                Me.S5 = RestaurantPOS14.ModFunc.GetParamValue("select IsNull(Sum(GrandTotal),0)-IsNull(Sum(AmtReceived),0) from RestaurantPOS_BillingInfoHD where BillDate >=@d1 and BillDate < @d2 and HD_Status not in ('Cancelled') and PaymentMode in ('Cash')", dateTime, dateTime2)
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
                Dim rptRPOS3 As RestaurantPOS14.rptRPOS = New RestaurantPOS14.rptRPOS()
                rptRPOS3.Subreports(CInt((0))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((1))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((2))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((3))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((4))).SetDataSource(dataSet)
                rptRPOS3.Subreports(CInt((5))).SetDataSource(dataSet)
                rptRPOS3.SetDataSource(dataSet)
                rptRPOS3.SetParameterValue("p1", Me.cmbWorkPeriodStartTime.Text)
                rptRPOS3.SetParameterValue("p2", Me.cmbWorkPeriodEndTime.Text)
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
                RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.CrystalReportViewer1.ReportSource = rptRPOS3
                RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.dtpDateFrom.Value = dateTime
                RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.dtpDateTo.Value = dateTime2
                RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.txtEmailID.Text = ""
                Call RestaurantPOS14.My.MyProject.Forms.frmWPReport_CRViewer.ShowDialog()
                rptRPOS3.Close()
                rptRPOS3.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Public Sub fillWPStart()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT WpStart FROM WorkPeriodStart order by Wpstart desc")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.cmbWorkPeriodStartTime.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim dateTime As System.DateTime = RestaurantPOS14.ModClasses.rdr.GetDateTime(0)
                    Me.cmbWorkPeriodStartTime.Items.Add(dateTime.ToString("dd/MM/yyyy hh:mm:ss tt"))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmWorkPeriodReport_Load(sender As Object, e As System.EventArgs)
            Me.fillWPStart()
            Me.fillKitchen()
        End Sub

        Private Sub cmbWorkPeriodStartTime_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbWorkPeriodStartTime.Text, "", TextCompare:=False) <> 0 Then
                    Dim dateTime As System.DateTime = System.DateTime.ParseExact(Me.cmbWorkPeriodStartTime.Text, "dd/MM/yyyy hh:mm:ss tt", Nothing)
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT WpEnd FROM WorkPeriodStart,WorkPeriodEnd where WorkPeriodStart.ID=WorkPeriodEnd.ID and WPStart like @d1")
                    RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType)).Value = dateTime
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        Me.cmbWorkPeriodEndTime.Text = RestaurantPOS14.ModClasses.rdr.GetDateTime(CInt((0))).ToString("dd/MM/yyyy hh:mm:ss tt")
                    Else
                        Me.cmbWorkPeriodEndTime.Text = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
                    End If

                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbWorkPeriodStartTime.Text, "", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog7.ShowDialog()
                Me.cmbWorkPeriodStartTime.Focus()
                Return
            End If

            Try
                If Me.cmbKitchen.SelectedIndex < 0 Then
                    Return
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Dim dateTime As System.DateTime = System.DateTime.ParseExact(Me.cmbWorkPeriodStartTime.Text, "dd/MM/yyyy hh:mm:ss tt", Nothing)
                Dim dateTime2 As System.DateTime = System.DateTime.ParseExact(Me.cmbWorkPeriodEndTime.Text, "dd/MM/yyyy hh:mm:ss tt", Nothing)
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and Category.CategoryName=RestaurantPOS_OrderedProductBillKOT.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') and Category.CategoryName=RestaurantPOS_OrderedProductBillTA.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and Category.CategoryName=RestaurantPOS_OrderedProductBillHD.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared') and Category.CategoryName=RestaurantPOS_OrderedProductBillEB.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9)G  group by Dish order by 1")
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d9", Me.cmbKitchen.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
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
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * from Hotel", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.cmd1 = New System.Data.SqlClient.SqlCommand("SELECT Dish,Sum(Quantity) as [Quantity],Sum(TotalAmount) as [Amount] from (Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillKOT,RestaurantPOS_BillingInfoKOT,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and DIB_Status not in ('Unpaid','Changed to Split Bill') and RestaurantPOS_BillingInfoKOT.ID=RestaurantPOS_OrderedProductBillKOT.BillID and Category.CategoryName=RestaurantPOS_OrderedProductBillKOT.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union All Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillTA,RestaurantPOS_BillingInfoTA,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoTA.ID=RestaurantPOS_OrderedProductBillTA.BillID and TA_Status not in ('Void','Unpaid','Prepared') and Category.CategoryName=RestaurantPOS_OrderedProductBillTA.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union All Select Dish,Quantity,TotalAmount as [TotalAmount] from RestaurantPOS_OrderedProductBillHD,RestaurantPOS_BillingInfoHD,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoHD.ID=RestaurantPOS_OrderedProductBillHD.BillID and HD_Status not in ('Cancelled','Confirmed','Prepared','Dispatched') and Category.CategoryName=RestaurantPOS_OrderedProductBillHD.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9 Union all Select Dish,Quantity,(TotalAmount*ExchangeRate) as [TotalAmount] from RestaurantPOS_OrderedProductBillEB,RestaurantPOS_BillingInfoEB,Category,Kitchen where BillDate >=@d7 and BillDate < @d8 and RestaurantPOS_BillingInfoEB.ID=RestaurantPOS_OrderedProductBillEB.BillID and EB_Status not in ('Void','Unpaid','Prepared') and Category.CategoryName=RestaurantPOS_OrderedProductBillEB.Category and Category.Kitchen=Kitchen.KitchenName and KitchenName=@d9)G  group by Dish order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd1.Parameters.Add(CStr(("@d7")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime
                RestaurantPOS14.ModClasses.cmd1.Parameters.Add(CStr(("@d8")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = dateTime2
                RestaurantPOS14.ModClasses.cmd1.Parameters.AddWithValue("@d9", Me.cmbKitchen.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.adp1 = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd1)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.dtable1 = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.adp1.Fill(RestaurantPOS14.ModClasses.dtable1)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable1)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("RPOSByKitchen.xml")
                Dim rptWPByKitchen2 As RestaurantPOS14.rptWPByKitchen = New RestaurantPOS14.rptWPByKitchen()
                rptWPByKitchen2.Subreports(CInt((0))).SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptWPByKitchen2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptWPByKitchen2.SetParameterValue("p1", dateTime)
                rptWPByKitchen2.SetParameterValue("p2", dateTime2)
                rptWPByKitchen2.SetParameterValue("T1", Me.cmbKitchen.Text)
                RestaurantPOS14.ModFunc.GetPrinterName(System.Net.Dns.GetHostName(), rptWPByKitchen2)
                rptWPByKitchen2.Close()
                rptWPByKitchen2.Dispose()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillKitchen()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(KitchenName) FROM Kitchen order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbKitchen.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbKitchen.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmWorkPeriodReport))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cmbWorkPeriodEndTime = New System.Windows.Forms.ComboBox()
            Me.cmbKitchen = New System.Windows.Forms.ComboBox()
            Me.btnViewReport = New System.Windows.Forms.Button()
            Me.cmbWorkPeriodStartTime = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.btnReset)
            Me.Panel1.Controls.Add(Me.Panel2)
            Me.Panel1.Controls.Add(Me.btnClose)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(5, 4)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(712, 233)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox1.Controls.Add(Me.Button1)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.cmbWorkPeriodEndTime)
            Me.GroupBox1.Controls.Add(Me.cmbKitchen)
            Me.GroupBox1.Controls.Add(Me.btnViewReport)
            Me.GroupBox1.Controls.Add(Me.cmbWorkPeriodStartTime)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox1.ForeColor = System.Drawing.Color.White
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(5, 45)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(699, 178)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 3
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Work Period Start and End Time :"
            Me.Button1.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.FlatAppearance.BorderSize = 0
            Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.ForeColor = System.Drawing.Color.White
            Me.Button1.Image = CType(componentResourceManager.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(292, 115)
            button.Location = location
            Me.Button1.Name = "Button1"
            Dim button2 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(141, 50)
            button2.Size = size
            Me.Button1.TabIndex = 30
            Me.Button1.Text = "View Report"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = False
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(22, 110)
            label.Location = location
            Me.Label7.Name = "Label7"
            Dim label2 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(195, 20)
            label2.Size = size
            Me.Label7.TabIndex = 29
            Me.Label7.Text = "Search By Kitchen/Section :"
            Me.cmbWorkPeriodEndTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbWorkPeriodEndTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbWorkPeriodEndTime.BackColor = System.Drawing.SystemColors.Control
            Me.cmbWorkPeriodEndTime.Enabled = False
            Me.cmbWorkPeriodEndTime.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbWorkPeriodEndTime
            location = New System.Drawing.Point(293, 67)
            comboBox.Location = location
            Me.cmbWorkPeriodEndTime.Name = "cmbWorkPeriodEndTime"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbWorkPeriodEndTime
            size = New System.Drawing.Size(252, 33)
            comboBox2.Size = size
            Me.cmbWorkPeriodEndTime.TabIndex = 12
            Me.cmbKitchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbKitchen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbKitchen.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbKitchen
            location = New System.Drawing.Point(22, 133)
            comboBox3.Location = location
            Me.cmbKitchen.Name = "cmbKitchen"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbKitchen
            size = New System.Drawing.Size(264, 32)
            comboBox4.Size = size
            Me.cmbKitchen.TabIndex = 28
            Me.btnViewReport.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnViewReport.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewReport.FlatAppearance.BorderSize = 0
            Me.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnViewReport.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnViewReport.ForeColor = System.Drawing.Color.White
            Me.btnViewReport.Image = CType(componentResourceManager.GetObject("btnViewReport.Image"), System.Drawing.Image)
            Me.btnViewReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnViewReport
            location = New System.Drawing.Point(551, 56)
            button3.Location = location
            Me.btnViewReport.Name = "btnViewReport"
            Dim button4 As System.Windows.Forms.Button = Me.btnViewReport
            size = New System.Drawing.Size(141, 50)
            button4.Size = size
            Me.btnViewReport.TabIndex = 5
            Me.btnViewReport.Text = "View Report"
            Me.btnViewReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnViewReport.UseVisualStyleBackColor = False
            Me.cmbWorkPeriodStartTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbWorkPeriodStartTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbWorkPeriodStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbWorkPeriodStartTime.FormattingEnabled = True
            Dim comboBox5 As System.Windows.Forms.ComboBox = Me.cmbWorkPeriodStartTime
            location = New System.Drawing.Point(22, 67)
            comboBox5.Location = location
            Me.cmbWorkPeriodStartTime.Name = "cmbWorkPeriodStartTime"
            Dim comboBox6 As System.Windows.Forms.ComboBox = Me.cmbWorkPeriodStartTime
            size = New System.Drawing.Size(264, 33)
            comboBox6.Size = size
            Me.cmbWorkPeriodStartTime.TabIndex = 11
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(289, 34)
            label3.Location = location
            Me.Label3.Name = "Label3"
            Dim label4 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(179, 21)
            label4.Size = size
            Me.Label3.TabIndex = 10
            Me.Label3.Text = "Work Period End Time :"
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(18, 34)
            label5.Location = location
            Me.Label2.Name = "Label2"
            Dim label6 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(187, 21)
            label6.Size = size
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "Work Period Start Time :"
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.FlatAppearance.BorderSize = 0
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Dim button5 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(619, 3)
            button5.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button6 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(39, 41)
            button6.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(5, 5)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(608, 41)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(197, 5)
            label7.Location = location
            Me.Label1.Name = "Label1"
            Dim label8 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(203, 30)
            label8.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Work Period Report"
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button7 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(662, 3)
            button7.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button8 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(40, 41)
            button8.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(722, 244)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmWorkPeriodReport"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
