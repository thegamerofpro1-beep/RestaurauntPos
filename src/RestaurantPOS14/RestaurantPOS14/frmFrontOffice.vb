Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmFrontOffice
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label30")>
        Private _Label30 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblDateTime")>
        Private _lblDateTime As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMinimize")>
        Private _btnMinimize As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TableLayoutPanel1")>
        Private _TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnMaximise")>
        Private _btnMaximise As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnKeyboard")>
        Private _btnKeyboard As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnWorkPeriod")>
        Private _btnWorkPeriod As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPOS")>
        Private _btnPOS As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnKitchenDisplay")>
        Private _btnKitchenDisplay As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReport")>
        Private _btnReport As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnLogout")>
        Private _btnLogout As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnOpenCashDrawer")>
        Private _btnOpenCashDrawer As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTillID")>
        Private _txtTillID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClockOut")>
        Private _btnClockOut As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnPrinterStatus")>
        Private _btnPrinterStatus As CButtonLib.CButton

        Private Filename As String

        Private s4 As String

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

        Friend Overridable Property Label30 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label30
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label30 = value
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

        Friend Overridable Property lblDateTime As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblDateTime
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblDateTime = value
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

        Friend Overridable Property Timer2 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Me._Timer2 = value
            End Set
        End Property

        Friend Overridable Property btnMinimize As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMinimize
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnMinimize_Click
                If Me._btnMinimize IsNot Nothing Then
                    RemoveHandler Me._btnMinimize.Click, value2
                End If

                Me._btnMinimize = value
                If Me._btnMinimize IsNot Nothing Then
                    AddHandler Me._btnMinimize.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TableLayoutPanel1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TableLayoutPanel)
                Me._TableLayoutPanel1 = value
            End Set
        End Property

        Friend Overridable Property btnMaximise As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnMaximise
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnMaximise_Click
                If Me._btnMaximise IsNot Nothing Then
                    RemoveHandler Me._btnMaximise.Click, value2
                End If

                Me._btnMaximise = value
                If Me._btnMaximise IsNot Nothing Then
                    AddHandler Me._btnMaximise.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnKeyboard As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnKeyboard
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnKeyboard_Click
                If Me._btnKeyboard IsNot Nothing Then
                    RemoveHandler Me._btnKeyboard.Click, value2
                End If

                Me._btnKeyboard = value
                If Me._btnKeyboard IsNot Nothing Then
                    AddHandler Me._btnKeyboard.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnWorkPeriod As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnWorkPeriod
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnWorkPeriod_Click
                If Me._btnWorkPeriod IsNot Nothing Then
                    RemoveHandler Me._btnWorkPeriod.Click, value2
                End If

                Me._btnWorkPeriod = value
                If Me._btnWorkPeriod IsNot Nothing Then
                    AddHandler Me._btnWorkPeriod.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPOS As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPOS
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPOS_Click
                If Me._btnPOS IsNot Nothing Then
                    RemoveHandler Me._btnPOS.Click, value2
                End If

                Me._btnPOS = value
                If Me._btnPOS IsNot Nothing Then
                    AddHandler Me._btnPOS.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnKitchenDisplay As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnKitchenDisplay
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnKithcenDisplay_Click
                If Me._btnKitchenDisplay IsNot Nothing Then
                    RemoveHandler Me._btnKitchenDisplay.Click, value2
                End If

                Me._btnKitchenDisplay = value
                If Me._btnKitchenDisplay IsNot Nothing Then
                    AddHandler Me._btnKitchenDisplay.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnReport As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnReport
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnReport_Click
                If Me._btnReport IsNot Nothing Then
                    RemoveHandler Me._btnReport.Click, value2
                End If

                Me._btnReport = value
                If Me._btnReport IsNot Nothing Then
                    AddHandler Me._btnReport.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnLogout As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnLogout
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnLogout_Click
                If Me._btnLogout IsNot Nothing Then
                    RemoveHandler Me._btnLogout.Click, value2
                End If

                Me._btnLogout = value
                If Me._btnLogout IsNot Nothing Then
                    AddHandler Me._btnLogout.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnOpenCashDrawer As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnOpenCashDrawer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnOpenCashDrawer_Click
                If Me._btnOpenCashDrawer IsNot Nothing Then
                    RemoveHandler Me._btnOpenCashDrawer.Click, value2
                End If

                Me._btnOpenCashDrawer = value
                If Me._btnOpenCashDrawer IsNot Nothing Then
                    AddHandler Me._btnOpenCashDrawer.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblUserType As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUserType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUserType = value
            End Set
        End Property

        Friend Overridable Property txtTillID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTillID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTillID = value
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

        Friend Overridable Property btnClockOut As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClockOut
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnClockOut_Click
                If Me._btnClockOut IsNot Nothing Then
                    RemoveHandler Me._btnClockOut.Click, value2
                End If

                Me._btnClockOut = value
                If Me._btnClockOut IsNot Nothing Then
                    AddHandler Me._btnClockOut.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnPrinterStatus As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnPrinterStatus
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnPrinterStatus_Click
                If Me._btnPrinterStatus IsNot Nothing Then
                    RemoveHandler Me._btnPrinterStatus.Click, value2
                End If

                Me._btnPrinterStatus = value
                If Me._btnPrinterStatus IsNot Nothing Then
                    AddHandler Me._btnPrinterStatus.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmFrontOffice_Load
            Call RestaurantPOS14.frmFrontOffice.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmFrontOffice.__ENCList
                If RestaurantPOS14.frmFrontOffice.__ENCList.Count = RestaurantPOS14.frmFrontOffice.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmFrontOffice.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmFrontOffice.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmFrontOffice.__ENCList(num) = RestaurantPOS14.frmFrontOffice.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmFrontOffice.__ENCList.RemoveRange(num, RestaurantPOS14.frmFrontOffice.__ENCList.Count - num)
                    RestaurantPOS14.frmFrontOffice.__ENCList.Capacity = RestaurantPOS14.frmFrontOffice.__ENCList.Count
                End If

                Call RestaurantPOS14.frmFrontOffice.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnCategories_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmMenuItemsCategory.ShowDialog()
        End Sub

        Private Sub btnMinimize_Click(sender As Object, e As System.EventArgs)
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Minimized
        End Sub

        Private Sub btnMaximise_Click(sender As Object, e As System.EventArgs)
            If MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized Then
                MyBase.WindowState = System.Windows.Forms.FormWindowState.Normal
                MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Else
                MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            End If
        End Sub

        Private Sub btnKeyboard_Click(sender As Object, e As System.EventArgs)
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            Me.lblDateTime.Text = Microsoft.VisualBasic.DateAndTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt")
        End Sub

        Public Sub Check()
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Change Price(POS)") Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeRate.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeRate1.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeRate2.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeRate3.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeRate.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeRate1.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeRate2.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeRate3.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Bill Discount(POS)") Then
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbKOTDiscountType.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbTADiscountType.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbHDDiscountType.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbEBDiscountType.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtKOTDiscPer.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTADiscountPer.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtHDDiscountPer.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBDiscountPer.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.Button11.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.Button12.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.Button13.Enabled = True
                RestaurantPOS14.My.MyProject.Forms.frmPOS.Button14.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbKOTDiscountType.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbTADiscountType.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbHDDiscountType.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbEBDiscountType.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtKOTDiscPer.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTADiscountPer.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtHDDiscountPer.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBDiscountPer.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.Button11.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.Button12.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.Button13.Enabled = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.Button14.Enabled = False
            End If
        End Sub

        Private Sub btnPOS_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * from Hotel")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog18.ShowDialog()
                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * from Dish")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog12.ShowDialog()
                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT * from WorkPeriodStart where Status='Active'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog3.ShowDialog()
                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                If(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Admin", TextCompare:=False) = 0) Or (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Super Admin", TextCompare:=False) = 0) Then
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnOpenCashDrawer.Enabled = True
                Else
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnOpenCashDrawer.Enabled = False
                End If

                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.GetExtraCopyBillSetting()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ReadCMISetting()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.chkOSK.Checked = False
                RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.SelectedIndex = 0
                RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserType.Text = Me.lblUserType.Text
                RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text = Me.lblUser.Text
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.ResetX()
                If(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Admin", TextCompare:=False) = 0) Or (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Super Admin", TextCompare:=False) = 0) Or (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Cashier", TextCompare:=False) = 0) Then
                    MyBase.Hide()
                    For Each tabPage As System.Windows.Forms.TabPage In RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.TabPages
                        tabPage.Enabled = True
                    Next

                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.GetSMIISetting()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.LoadData()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.GetTaxType()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.IsEnabledCallerID()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.IsEnableWS()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.GetHotelName()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Visible = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustName.Visible = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSettleEB.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSettleTA.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnGetData2.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnGetData4.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUnpaidBills.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUnpaidBillsTA.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeTable.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnItemTransfer.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnTR.Enabled = True
                    Me.Check()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.chkThemeType.Checked = True
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                Else
                    MyBase.Hide()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.TabPages(CInt((0))).Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.TabPages(CInt((1))).Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.TabPages(CInt((2))).Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.TabPages(CInt((3))).Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.TabPages(CInt((4))).Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.TabPages(CInt((5))).Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSettleEB.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSettleTA.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnGetData2.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnGetData4.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUnpaidBills.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnUnpaidBillsTA.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnChangeTable.Enabled = False
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.IsEnableWS()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.GetSMIISetting()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.GetHotelName()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.LoadData()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.GetTaxType()
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.IsEnabledCallerID()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustNameVAL.Visible = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblCustName.Visible = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnItemTransfer.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnTR.Enabled = False
                    Me.Check()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.chkThemeType.Checked = True
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.Show()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCustomDialog8.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog8.ShowDialog()
        End Sub

        Private Sub btnWorkPeriod_Click(sender As Object, e As System.EventArgs)
            MyBase.Hide()
            RestaurantPOS14.My.MyProject.Forms.frmWorkPeriod.lblUserType.Text = Me.lblUserType.Text
            RestaurantPOS14.My.MyProject.Forms.frmWorkPeriod.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmWorkPeriod.Show()
        End Sub

        Private Sub btnOpenCashDrawer_Click(sender As Object, e As System.EventArgs)
            Try
                Dim errorMessage As String = String.Empty
                If RestaurantPOS14.ModCashDrawer.TryOpenConfiguredDrawer(Me.txtTillID.Text, errorMessage) Then
                    Return
                End If

                If String.IsNullOrWhiteSpace(errorMessage) Then
                    Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog11.ShowDialog()
                Else
                    Call System.Windows.Forms.MessageBox.Show(errorMessage, "Cash Drawer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                End If
            Catch ex As System.Exception
                RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Open Cash Drawer from Front Office", ex)
                Call System.Windows.Forms.MessageBox.Show("Cash Drawer could not be opened. " & ex.GetBaseException().Message, "Cash Drawer", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnReport_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmFrontOffice_Report.lblUser.Text = Me.lblUser.Text
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "POS Report") Then
                RestaurantPOS14.My.MyProject.Forms.frmFrontOffice_Report.btnPOSReport.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmFrontOffice_Report.btnPOSReport.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Work Period Report") Then
                RestaurantPOS14.My.MyProject.Forms.frmFrontOffice_Report.btnWorkPeriodReport.Enabled = True
            Else
                RestaurantPOS14.My.MyProject.Forms.frmFrontOffice_Report.btnWorkPeriodReport.Enabled = False
            End If

            RestaurantPOS14.My.MyProject.Forms.frmFrontOffice_Report.lblUserType.Text = Me.lblUserType.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmFrontOffice_Report.ShowDialog()
        End Sub

        Private Sub btnKithcenDisplay_Click(sender As Object, e As System.EventArgs)
            MyBase.Hide()
            RestaurantPOS14.My.MyProject.Forms.frmKDS.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmKDS.lblUserType.Text = Me.lblUserType.Text
            RestaurantPOS14.My.MyProject.Forms.frmKDS.MetroToggle1.Checked = True
            Call RestaurantPOS14.My.MyProject.Forms.frmKDS.Show()
        End Sub

        Private Sub frmFrontOffice_Load(sender As Object, e As System.EventArgs)
            Me.txtTillID.Text = System.Net.Dns.GetHostName()
        End Sub

        Private Sub btnClockOut_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmClockINandOUT.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmClockINandOUT.CheckFirstTimeClockIn()
            Call RestaurantPOS14.My.MyProject.Forms.frmClockINandOUT.ShowDialog()
        End Sub

        Private Sub btnPrinterStatus_Click(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmPrinterStatus.ShowDialog()
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
            Dim cBlendItems As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmFrontOffice))
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems6 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label30 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.lblDateTime = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.btnClockOut = New CButtonLib.CButton()
            Me.btnReport = New CButtonLib.CButton()
            Me.btnWorkPeriod = New CButtonLib.CButton()
            Me.btnPOS = New CButtonLib.CButton()
            Me.btnKitchenDisplay = New CButtonLib.CButton()
            Me.btnLogout = New CButtonLib.CButton()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.txtTillID = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btnPrinterStatus = New CButtonLib.CButton()
            Me.btnOpenCashDrawer = New CButtonLib.CButton()
            Me.btnKeyboard = New CButtonLib.CButton()
            Me.btnMaximise = New CButtonLib.CButton()
            Me.btnMinimize = New CButtonLib.CButton()
            Me.Panel1.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Label30)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.lblUser)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(1, 1)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(726, 51)
            panel2.Size = size
            Me.Panel1.TabIndex = 3
            Me.Label30.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label30.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label30
            location = New System.Drawing.Point(267, 5)
            label.Location = location
            Me.Label30.Name = "Label30"
            Dim label2 As System.Windows.Forms.Label = Me.Label30
            size = New System.Drawing.Size(178, 37)
            label2.Size = size
            Me.Label30.TabIndex = 321
            Me.Label30.Text = "Operator ID :"
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(3, 5)
            label3.Location = location
            Me.Label1.Name = "Label1"
            Dim label4 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(162, 37)
            label4.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Front Office"
            Me.lblUser.AutoSize = True
            Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUser.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(438, 5)
            label5.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label6 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(102, 37)
            label6.Size = size
            Me.lblUser.TabIndex = 320
            Me.lblUser.Text = "lblUser"
            Me.lblDateTime.AutoSize = True
            Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblDateTime.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.lblDateTime
            location = New System.Drawing.Point(5, 53)
            label7.Location = location
            Me.lblDateTime.Name = "lblDateTime"
            Dim label8 As System.Windows.Forms.Label = Me.lblDateTime
            size = New System.Drawing.Size(134, 37)
            label8.Size = size
            Me.lblDateTime.TabIndex = 3
            Me.lblDateTime.Text = "DateTime"
            Me.Timer1.Enabled = True
            Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.TableLayoutPanel1.ColumnCount = 3
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.Controls.Add(Me.btnClockOut, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btnReport, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.btnWorkPeriod, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btnPOS, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btnKitchenDisplay, 2, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btnLogout, 2, 1)
            Dim tableLayoutPanel As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            location = New System.Drawing.Point(12, 93)
            tableLayoutPanel.Location = location
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
            Dim tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel = Me.TableLayoutPanel1
            size = New System.Drawing.Size(989, 602)
            tableLayoutPanel2.Size = size
            Me.TableLayoutPanel1.TabIndex = 56
            Me.btnClockOut.BackColor = System.Drawing.Color.Transparent
            Me.btnClockOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnClockOut.BorderColor = System.Drawing.Color.Transparent
            Me.btnClockOut.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnClockOut.ColorFillBlend = cBlendItems
            Me.btnClockOut.Corners.All = 10
            Me.btnClockOut.Corners.LowerLeft = 10
            Me.btnClockOut.Corners.LowerRight = 10
            Me.btnClockOut.Corners.UpperLeft = 10
            Me.btnClockOut.Corners.UpperRight = 10
            Me.btnClockOut.DesignerSelected = False
            Me.btnClockOut.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnClockOut.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClockOut.Image = CType(componentResourceManager.GetObject("btnClockOut.Image"), System.Drawing.Image)
            Me.btnClockOut.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnClockOut
            size = New System.Drawing.Size(256, 256)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnClockOut
            location = New System.Drawing.Point(330, 302)
            cButton2.Location = location
            Dim cButton3 As CButtonLib.CButton = Me.btnClockOut
            Dim margin As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(1)
            cButton3.Margin = margin
            Me.btnClockOut.Name = "btnClockOut"
            Dim cButton4 As CButtonLib.CButton = Me.btnClockOut
            size = New System.Drawing.Size(327, 299)
            cButton4.Size = size
            Me.btnClockOut.TabIndex = 6
            Me.btnClockOut.Text = "Clock IN and OUT"
            Me.btnClockOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnClockOut.TextShadowShow = False
            Me.btnClockOut.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnReport.BackColor = System.Drawing.Color.Transparent
            Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnReport.BorderColor = System.Drawing.Color.Transparent
            Me.btnReport.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnReport.ColorFillBlend = cBlendItems2
            Me.btnReport.Corners.All = 10
            Me.btnReport.Corners.LowerLeft = 10
            Me.btnReport.Corners.LowerRight = 10
            Me.btnReport.Corners.UpperLeft = 10
            Me.btnReport.Corners.UpperRight = 10
            Me.btnReport.DesignerSelected = False
            Me.btnReport.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnReport.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReport.Image = CType(componentResourceManager.GetObject("btnReport.Image"), System.Drawing.Image)
            Me.btnReport.ImageIndex = 0
            Dim cButton5 As CButtonLib.CButton = Me.btnReport
            size = New System.Drawing.Size(256, 256)
            cButton5.ImageSize = size
            Dim cButton6 As CButtonLib.CButton = Me.btnReport
            location = New System.Drawing.Point(1, 302)
            cButton6.Location = location
            Dim cButton7 As CButtonLib.CButton = Me.btnReport
            margin = New System.Windows.Forms.Padding(1)
            cButton7.Margin = margin
            Me.btnReport.Name = "btnReport"
            Dim cButton8 As CButtonLib.CButton = Me.btnReport
            size = New System.Drawing.Size(327, 299)
            cButton8.Size = size
            Me.btnReport.TabIndex = 4
            Me.btnReport.Text = "Report"
            Me.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnReport.TextShadowShow = False
            Me.btnReport.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnWorkPeriod.BackColor = System.Drawing.Color.Transparent
            Me.btnWorkPeriod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnWorkPeriod.BorderColor = System.Drawing.Color.Transparent
            Me.btnWorkPeriod.BorderShow = False
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnWorkPeriod.ColorFillBlend = cBlendItems3
            Me.btnWorkPeriod.Corners.All = 10
            Me.btnWorkPeriod.Corners.LowerLeft = 10
            Me.btnWorkPeriod.Corners.LowerRight = 10
            Me.btnWorkPeriod.Corners.UpperLeft = 10
            Me.btnWorkPeriod.Corners.UpperRight = 10
            Me.btnWorkPeriod.DesignerSelected = False
            Me.btnWorkPeriod.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnWorkPeriod.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnWorkPeriod.Image = CType(componentResourceManager.GetObject("btnWorkPeriod.Image"), System.Drawing.Image)
            Me.btnWorkPeriod.ImageIndex = 0
            Dim cButton9 As CButtonLib.CButton = Me.btnWorkPeriod
            size = New System.Drawing.Size(256, 256)
            cButton9.ImageSize = size
            Dim cButton10 As CButtonLib.CButton = Me.btnWorkPeriod
            location = New System.Drawing.Point(1, 1)
            cButton10.Location = location
            Dim cButton11 As CButtonLib.CButton = Me.btnWorkPeriod
            margin = New System.Windows.Forms.Padding(1)
            cButton11.Margin = margin
            Me.btnWorkPeriod.Name = "btnWorkPeriod"
            Dim cButton12 As CButtonLib.CButton = Me.btnWorkPeriod
            size = New System.Drawing.Size(327, 299)
            cButton12.Size = size
            Me.btnWorkPeriod.TabIndex = 0
            Me.btnWorkPeriod.Text = "Work Period"
            Me.btnWorkPeriod.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnWorkPeriod.TextShadowShow = False
            Me.btnWorkPeriod.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnPOS.BackColor = System.Drawing.Color.Transparent
            Me.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnPOS.BorderColor = System.Drawing.Color.Transparent
            Me.btnPOS.BorderShow = False
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnPOS.ColorFillBlend = cBlendItems4
            Me.btnPOS.Corners.All = 10
            Me.btnPOS.Corners.LowerLeft = 10
            Me.btnPOS.Corners.LowerRight = 10
            Me.btnPOS.Corners.UpperLeft = 10
            Me.btnPOS.Corners.UpperRight = 10
            Me.btnPOS.DesignerSelected = True
            Me.btnPOS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnPOS.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPOS.Image = CType(componentResourceManager.GetObject("btnPOS.Image"), System.Drawing.Image)
            Me.btnPOS.ImageIndex = 0
            Dim cButton13 As CButtonLib.CButton = Me.btnPOS
            size = New System.Drawing.Size(256, 256)
            cButton13.ImageSize = size
            Dim cButton14 As CButtonLib.CButton = Me.btnPOS
            location = New System.Drawing.Point(330, 1)
            cButton14.Location = location
            Dim cButton15 As CButtonLib.CButton = Me.btnPOS
            margin = New System.Windows.Forms.Padding(1)
            cButton15.Margin = margin
            Me.btnPOS.Name = "btnPOS"
            Dim cButton16 As CButtonLib.CButton = Me.btnPOS
            size = New System.Drawing.Size(327, 299)
            cButton16.Size = size
            Me.btnPOS.TabIndex = 1
            Me.btnPOS.Text = "POS"
            Me.btnPOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnPOS.TextShadowShow = False
            Me.btnPOS.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnKitchenDisplay.BackColor = System.Drawing.Color.Transparent
            Me.btnKitchenDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnKitchenDisplay.BorderColor = System.Drawing.Color.Transparent
            Me.btnKitchenDisplay.BorderShow = False
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnKitchenDisplay.ColorFillBlend = cBlendItems5
            Me.btnKitchenDisplay.Corners.All = 10
            Me.btnKitchenDisplay.Corners.LowerLeft = 10
            Me.btnKitchenDisplay.Corners.LowerRight = 10
            Me.btnKitchenDisplay.Corners.UpperLeft = 10
            Me.btnKitchenDisplay.Corners.UpperRight = 10
            Me.btnKitchenDisplay.DesignerSelected = False
            Me.btnKitchenDisplay.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnKitchenDisplay.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnKitchenDisplay.Image = CType(componentResourceManager.GetObject("btnKitchenDisplay.Image"), System.Drawing.Image)
            Me.btnKitchenDisplay.ImageIndex = 0
            Dim cButton17 As CButtonLib.CButton = Me.btnKitchenDisplay
            size = New System.Drawing.Size(256, 256)
            cButton17.ImageSize = size
            Dim cButton18 As CButtonLib.CButton = Me.btnKitchenDisplay
            location = New System.Drawing.Point(659, 1)
            cButton18.Location = location
            Dim cButton19 As CButtonLib.CButton = Me.btnKitchenDisplay
            margin = New System.Windows.Forms.Padding(1)
            cButton19.Margin = margin
            Me.btnKitchenDisplay.Name = "btnKitchenDisplay"
            Dim cButton20 As CButtonLib.CButton = Me.btnKitchenDisplay
            size = New System.Drawing.Size(329, 299)
            cButton20.Size = size
            Me.btnKitchenDisplay.TabIndex = 5
            Me.btnKitchenDisplay.Text = "Kitchen Display"
            Me.btnKitchenDisplay.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnKitchenDisplay.TextShadowShow = False
            Me.btnKitchenDisplay.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.btnLogout.BackColor = System.Drawing.Color.Transparent
            Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.btnLogout.BorderColor = System.Drawing.Color.Transparent
            Me.btnLogout.BorderShow = False
            cBlendItems6.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems6.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnLogout.ColorFillBlend = cBlendItems6
            Me.btnLogout.Corners.All = 10
            Me.btnLogout.Corners.LowerLeft = 10
            Me.btnLogout.Corners.LowerRight = 10
            Me.btnLogout.Corners.UpperLeft = 10
            Me.btnLogout.Corners.UpperRight = 10
            Me.btnLogout.DesignerSelected = False
            Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnLogout.Image = CType(componentResourceManager.GetObject("btnLogout.Image"), System.Drawing.Image)
            Me.btnLogout.ImageIndex = 0
            Dim cButton21 As CButtonLib.CButton = Me.btnLogout
            size = New System.Drawing.Size(256, 256)
            cButton21.ImageSize = size
            Dim cButton22 As CButtonLib.CButton = Me.btnLogout
            location = New System.Drawing.Point(659, 302)
            cButton22.Location = location
            Dim cButton23 As CButtonLib.CButton = Me.btnLogout
            margin = New System.Windows.Forms.Padding(1)
            cButton23.Margin = margin
            Me.btnLogout.Name = "btnLogout"
            Dim cButton24 As CButtonLib.CButton = Me.btnLogout
            size = New System.Drawing.Size(329, 299)
            cButton24.Size = size
            Me.btnLogout.TabIndex = 3
            Me.btnLogout.Text = "Logout"
            Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnLogout.TextShadowShow = False
            Me.btnLogout.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Me.lblUserType.AutoSize = True
            Me.lblUserType.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUserType.ForeColor = System.Drawing.Color.PaleGoldenrod
            Dim label9 As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(703, 53)
            label9.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label10 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(130, 37)
            label10.Size = size
            Me.lblUserType.TabIndex = 322
            Me.lblUserType.Text = "UserType"
            Me.lblUserType.Visible = False
            Dim textBox As System.Windows.Forms.TextBox = Me.txtTillID
            location = New System.Drawing.Point(436, 329)
            textBox.Location = location
            Me.txtTillID.Name = "txtTillID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtTillID
            size = New System.Drawing.Size(45, 20)
            textBox2.Size = size
            Me.txtTillID.TabIndex = 449
            Me.txtTillID.Visible = False
            Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label2.ForeColor = System.Drawing.Color.Crimson
            Dim label11 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(579, 53)
            label11.Location = location
            Me.Label2.Name = "Label2"
            Dim label12 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(421, 37)
            label12.Size = size
            Me.Label2.TabIndex = 450
            Me.Label2.Text = "Don't Forget to End Work Period."
            Me.btnPrinterStatus.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnPrinterStatus.BackColor = System.Drawing.Color.Transparent
            Me.btnPrinterStatus.BorderColor = System.Drawing.Color.Transparent
            Me.btnPrinterStatus.Corners.All = 5
            Me.btnPrinterStatus.Corners.LowerLeft = 5
            Me.btnPrinterStatus.Corners.LowerRight = 5
            Me.btnPrinterStatus.Corners.UpperLeft = 5
            Me.btnPrinterStatus.Corners.UpperRight = 5
            Me.btnPrinterStatus.DesignerSelected = False
            Me.btnPrinterStatus.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnPrinterStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnPrinterStatus.Image = CType(componentResourceManager.GetObject("btnPrinterStatus.Image"), System.Drawing.Image)
            Me.btnPrinterStatus.ImageIndex = 0
            Dim cButton25 As CButtonLib.CButton = Me.btnPrinterStatus
            size = New System.Drawing.Size(64, 64)
            cButton25.ImageSize = size
            Dim cButton26 As CButtonLib.CButton = Me.btnPrinterStatus
            location = New System.Drawing.Point(733, 2)
            cButton26.Location = location
            Me.btnPrinterStatus.Name = "btnPrinterStatus"
            Dim cButton27 As CButtonLib.CButton = Me.btnPrinterStatus
            size = New System.Drawing.Size(52, 51)
            cButton27.Size = size
            Me.btnPrinterStatus.TabIndex = 323
            Me.btnPrinterStatus.Text = ""
            Me.btnOpenCashDrawer.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnOpenCashDrawer.BackColor = System.Drawing.Color.Transparent
            Me.btnOpenCashDrawer.Corners.All = 5
            Me.btnOpenCashDrawer.Corners.LowerLeft = 5
            Me.btnOpenCashDrawer.Corners.LowerRight = 5
            Me.btnOpenCashDrawer.Corners.UpperLeft = 5
            Me.btnOpenCashDrawer.Corners.UpperRight = 5
            Me.btnOpenCashDrawer.DesignerSelected = False
            Me.btnOpenCashDrawer.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnOpenCashDrawer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnOpenCashDrawer.Image = CType(componentResourceManager.GetObject("btnOpenCashDrawer.Image"), System.Drawing.Image)
            Me.btnOpenCashDrawer.ImageIndex = 0
            Dim cButton28 As CButtonLib.CButton = Me.btnOpenCashDrawer
            size = New System.Drawing.Size(64, 64)
            cButton28.ImageSize = size
            Dim cButton29 As CButtonLib.CButton = Me.btnOpenCashDrawer
            location = New System.Drawing.Point(790, 1)
            cButton29.Location = location
            Me.btnOpenCashDrawer.Name = "btnOpenCashDrawer"
            Dim cButton30 As CButtonLib.CButton = Me.btnOpenCashDrawer
            size = New System.Drawing.Size(52, 51)
            cButton30.Size = size
            Me.btnOpenCashDrawer.TabIndex = 322
            Me.btnOpenCashDrawer.Text = ""
            Me.btnKeyboard.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnKeyboard.BackColor = System.Drawing.Color.Transparent
            Me.btnKeyboard.Corners.All = 5
            Me.btnKeyboard.Corners.LowerLeft = 5
            Me.btnKeyboard.Corners.LowerRight = 5
            Me.btnKeyboard.Corners.UpperLeft = 5
            Me.btnKeyboard.Corners.UpperRight = 5
            Me.btnKeyboard.DesignerSelected = False
            Me.btnKeyboard.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnKeyboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnKeyboard.Image = CType(componentResourceManager.GetObject("btnKeyboard.Image"), System.Drawing.Image)
            Me.btnKeyboard.ImageIndex = 0
            Dim cButton31 As CButtonLib.CButton = Me.btnKeyboard
            size = New System.Drawing.Size(64, 64)
            cButton31.ImageSize = size
            Dim cButton32 As CButtonLib.CButton = Me.btnKeyboard
            location = New System.Drawing.Point(846, 1)
            cButton32.Location = location
            Me.btnKeyboard.Name = "btnKeyboard"
            Dim cButton33 As CButtonLib.CButton = Me.btnKeyboard
            size = New System.Drawing.Size(52, 49)
            cButton33.Size = size
            Me.btnKeyboard.TabIndex = 58
            Me.btnKeyboard.Text = ""
            Me.btnMaximise.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnMaximise.BackColor = System.Drawing.Color.Transparent
            Me.btnMaximise.Corners.All = 5
            Me.btnMaximise.Corners.LowerLeft = 5
            Me.btnMaximise.Corners.LowerRight = 5
            Me.btnMaximise.Corners.UpperLeft = 5
            Me.btnMaximise.Corners.UpperRight = 5
            Me.btnMaximise.DesignerSelected = False
            Me.btnMaximise.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnMaximise.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMaximise.Image = CType(componentResourceManager.GetObject("btnMaximise.Image"), System.Drawing.Image)
            Me.btnMaximise.ImageIndex = 0
            Dim cButton34 As CButtonLib.CButton = Me.btnMaximise
            size = New System.Drawing.Size(64, 64)
            cButton34.ImageSize = size
            Dim cButton35 As CButtonLib.CButton = Me.btnMaximise
            location = New System.Drawing.Point(957, 1)
            cButton35.Location = location
            Me.btnMaximise.Name = "btnMaximise"
            Dim cButton36 As CButtonLib.CButton = Me.btnMaximise
            size = New System.Drawing.Size(52, 49)
            cButton36.Size = size
            Me.btnMaximise.TabIndex = 57
            Me.btnMaximise.Text = ""
            Me.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
            Me.btnMinimize.Corners.All = 5
            Me.btnMinimize.Corners.LowerLeft = 5
            Me.btnMinimize.Corners.LowerRight = 5
            Me.btnMinimize.Corners.UpperLeft = 5
            Me.btnMinimize.Corners.UpperRight = 5
            Me.btnMinimize.DesignerSelected = False
            Me.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnMinimize.Image = CType(componentResourceManager.GetObject("btnMinimize.Image"), System.Drawing.Image)
            Me.btnMinimize.ImageIndex = 0
            Dim cButton37 As CButtonLib.CButton = Me.btnMinimize
            size = New System.Drawing.Size(64, 64)
            cButton37.ImageSize = size
            Dim cButton38 As CButtonLib.CButton = Me.btnMinimize
            location = New System.Drawing.Point(902, 1)
            cButton38.Location = location
            Me.btnMinimize.Name = "btnMinimize"
            Dim cButton39 As CButtonLib.CButton = Me.btnMinimize
            size = New System.Drawing.Size(52, 49)
            cButton39.Size = size
            Me.btnMinimize.TabIndex = 35
            Me.btnMinimize.Text = ""
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1013, 706)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnPrinterStatus)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.txtTillID)
            MyBase.Controls.Add(Me.lblUserType)
            MyBase.Controls.Add(Me.btnOpenCashDrawer)
            MyBase.Controls.Add(Me.btnKeyboard)
            MyBase.Controls.Add(Me.btnMaximise)
            MyBase.Controls.Add(Me.TableLayoutPanel1)
            MyBase.Controls.Add(Me.btnMinimize)
            MyBase.Controls.Add(Me.lblDateTime)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmFrontOffice"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
