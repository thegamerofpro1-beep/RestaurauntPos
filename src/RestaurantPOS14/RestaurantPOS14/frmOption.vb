Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.IO.Ports
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports MetroFramework
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmOption
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("StatusStrip1")>
        Private _StatusStrip1 As System.Windows.Forms.StatusStrip

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.ToolStripStatusLabel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ToolStripStatusLabel2")>
        Private _ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.ToolStripStatusLabel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ToolStripStatusLabel3")>
        Private _ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtDisplayPort")>
        Private _txtDisplayPort As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBackOffice")>
        Private _btnBackOffice As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnFrontOffice")>
        Private _btnFrontOffice As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property StatusStrip1 As System.Windows.Forms.StatusStrip
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._StatusStrip1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.StatusStrip)
                Me._StatusStrip1 = value
            End Set
        End Property

        Friend Overridable Property lblUserType As System.Windows.Forms.ToolStripStatusLabel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUserType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolStripStatusLabel)
                Me._lblUserType = value
            End Set
        End Property

        Friend Overridable Property ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ToolStripStatusLabel2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolStripStatusLabel)
                Me._ToolStripStatusLabel2 = value
            End Set
        End Property

        Friend Overridable Property lblUser As System.Windows.Forms.ToolStripStatusLabel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUser
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolStripStatusLabel)
                Me._lblUser = value
            End Set
        End Property

        Friend Overridable Property ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ToolStripStatusLabel3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ToolStripStatusLabel)
                Me._ToolStripStatusLabel3 = value
            End Set
        End Property

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

        Friend Overridable Property txtDisplayPort As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtDisplayPort
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtDisplayPort = value
            End Set
        End Property

        Friend Overridable Property btnBackOffice As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBackOffice
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnBackOffice_Click
                If Me._btnBackOffice IsNot Nothing Then
                    RemoveHandler Me._btnBackOffice.Click, value2
                End If

                Me._btnBackOffice = value
                If Me._btnBackOffice IsNot Nothing Then
                    AddHandler Me._btnBackOffice.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnFrontOffice As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnFrontOffice
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnFrontOffice_Click
                If Me._btnFrontOffice IsNot Nothing Then
                    RemoveHandler Me._btnFrontOffice.Click, value2
                End If

                Me._btnFrontOffice = value
                If Me._btnFrontOffice IsNot Nothing Then
                    AddHandler Me._btnFrontOffice.Click, value2
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
                Me._Button1 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmOption_Load
            Call RestaurantPOS14.frmOption.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmOption.__ENCList
                If RestaurantPOS14.frmOption.__ENCList.Count = RestaurantPOS14.frmOption.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmOption.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmOption.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmOption.__ENCList(num) = RestaurantPOS14.frmOption.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmOption.__ENCList.RemoveRange(num, RestaurantPOS14.frmOption.__ENCList.Count - num)
                    RestaurantPOS14.frmOption.__ENCList.Capacity = RestaurantPOS14.frmOption.__ENCList.Count
                End If

                Call RestaurantPOS14.frmOption.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub GetCustomerDisplayPort()
            Try
                Me.txtDisplayPort.Text = RestaurantPOS14.Configuration.SettingsHost.Current.Printing.CustomerDisplayPort
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub ClearCustomerDisplay()
            Try
                Me.GetCustomerDisplayPort()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT * from POSPrinterSetting where TillID=@d1 and CustomerDisplay='Yes'"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Net.Dns.GetHostName())
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Dim serialPort As System.IO.Ports.SerialPort = RestaurantPOS14.Configuration.SerialPortFactory.CreateCustomerDisplay(Me.txtDisplayPort.Text)
                    serialPort.Open()
                    serialPort.Write(Global.Microsoft.VisualBasic.Constants.vbFormFeed)
                    serialPort.Close()
                    serialPort.Dispose()
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmOption_Load(sender As Object, e As System.EventArgs)
            MyBase.BackColor = System.Drawing.Color.Coral
            MyBase.TransparencyKey = MyBase.BackColor
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            Me.ClearCustomerDisplay()
            RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
        End Sub

        Private Sub btnBackOffice_Click(sender As Object, e As System.EventArgs)
            Dim backOffice = RestaurantPOS14.My.MyProject.Forms.frmBackOffice
            backOffice.lblUser.Text = Me.lblUser.Text
            backOffice.lblUserType.Text = Me.lblUserType.Text
            Me.ConfigureBackOfficePermissions(backOffice)

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Super Admin", TextCompare:=False) = 0 Then
                backOffice.btnRegistration.Enabled = True
                backOffice.btnAttendance.Enabled = True
                backOffice.btnEmployeeSession.Enabled = True
                backOffice.btnLogs.Enabled = True
            Else
                backOffice.btnRegistration.Enabled = False
                backOffice.btnAttendance.Enabled = False
                backOffice.btnEmployeeSession.Enabled = False
                backOffice.btnLogs.Enabled = False
            End If

            MyBase.Hide()
            backOffice.Show()
        End Sub

        Private Sub btnFrontOffice_Click(sender As Object, e As System.EventArgs)
            Dim frontOffice = RestaurantPOS14.My.MyProject.Forms.frmFrontOffice
            frontOffice.lblUserType.Text = Me.lblUserType.Text
            frontOffice.lblUser.Text = Me.lblUser.Text
            frontOffice.btnOpenCashDrawer.Enabled = True
            frontOffice.btnPOS.Enabled = True
            frontOffice.btnClockOut.Enabled = True
            frontOffice.btnKitchenDisplay.Enabled = True
            frontOffice.btnWorkPeriod.Enabled = True
            frontOffice.btnReport.Enabled = True
            MyBase.Hide()
            frontOffice.Show()
        End Sub

        Public Sub Check()
            Me.ConfigureBackOfficePermissions(RestaurantPOS14.My.MyProject.Forms.frmBackOffice)
        End Sub

        Private Sub ConfigureBackOfficePermissions(backOffice As RestaurantPOS14.frmBackOffice)
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "POS Report") Then
                backOffice.btnPOSReport.Enabled = True
            Else
                backOffice.btnPOSReport.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Work Period Report") Then
                backOffice.btnWorkPeriodReport.Enabled = True
            Else
                backOffice.btnWorkPeriodReport.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Accounting Report") Then
                backOffice.btnAccountingReports.Enabled = True
            Else
                backOffice.btnAccountingReports.Enabled = False
            End If
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmOption))
            Dim cBlendItems As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.lblUserType = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
            Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.btnFrontOffice = New CButtonLib.CButton()
            Me.btnBackOffice = New CButtonLib.CButton()
            Me.txtDisplayPort = New System.Windows.Forms.TextBox()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.StatusStrip1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            MyBase.SuspendLayout()
            Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem(3) {Me.lblUserType, Me.ToolStripStatusLabel2, Me.lblUser, Me.ToolStripStatusLabel3})
            Dim statusStrip As System.Windows.Forms.StatusStrip = Me.StatusStrip1
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 250)
            statusStrip.Location = location
            Me.StatusStrip1.Name = "StatusStrip1"
            Dim statusStrip2 As System.Windows.Forms.StatusStrip = Me.StatusStrip1
            Dim size As System.Drawing.Size = New System.Drawing.Size(349, 22)
            statusStrip2.Size = size
            Me.StatusStrip1.TabIndex = 7
            Me.StatusStrip1.Text = "StatusStrip1"
            Me.StatusStrip1.Visible = False
            Me.lblUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUserType.Image = CType(componentResourceManager.GetObject("lblUserType.Image"), System.Drawing.Image)
            Me.lblUserType.Name = "lblUserType"
            Dim toolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel = Me.lblUserType
            size = New System.Drawing.Size(78, 17)
            toolStripStatusLabel.Size = size
            Me.lblUserType.Text = "User Type"
            Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
            Dim toolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel = Me.ToolStripStatusLabel2
            size = New System.Drawing.Size(11, 17)
            toolStripStatusLabel2.Size = size
            Me.ToolStripStatusLabel2.Text = ":"
            Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUser.ForeColor = System.Drawing.Color.Black
            Me.lblUser.Name = "lblUser"
            Dim toolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel = Me.lblUser
            size = New System.Drawing.Size(70, 17)
            toolStripStatusLabel3.Size = size
            Me.lblUser.Text = "User Name"
            Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
            Dim toolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel = Me.ToolStripStatusLabel3
            size = New System.Drawing.Size(175, 17)
            toolStripStatusLabel4.Size = size
            Me.ToolStripStatusLabel3.Spring = True
            Me.ToolStripStatusLabel3.Visible = False
            Me.Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Panel1.Controls.Add(Me.Button1)
            Me.Panel1.Controls.Add(Me.btnFrontOffice)
            Me.Panel1.Controls.Add(Me.btnBackOffice)
            Me.Panel1.Controls.Add(Me.txtDisplayPort)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(0, 0)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(874, 441)
            panel2.Size = size
            Me.Panel1.TabIndex = 0
            Dim button As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(35, 3)
            button.Location = location
            Me.Button1.Name = "Button1"
            Dim button2 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(10, 10)
            button2.Size = size
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Button1"
            Me.Button1.UseVisualStyleBackColor = True
            Me.btnFrontOffice.BackColor = System.Drawing.Color.Transparent
            Me.btnFrontOffice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnFrontOffice.BorderColor = System.Drawing.Color.Transparent
            Me.btnFrontOffice.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnFrontOffice.ColorFillBlend = cBlendItems
            Me.btnFrontOffice.Corners.All = 10
            Me.btnFrontOffice.Corners.LowerLeft = 10
            Me.btnFrontOffice.Corners.LowerRight = 10
            Me.btnFrontOffice.Corners.UpperLeft = 10
            Me.btnFrontOffice.Corners.UpperRight = 10
            Me.btnFrontOffice.DesignerSelected = False
            Me.btnFrontOffice.Font = New System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnFrontOffice.Image = CType(componentResourceManager.GetObject("btnFrontOffice.Image"), System.Drawing.Image)
            Me.btnFrontOffice.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnFrontOffice
            size = New System.Drawing.Size(256, 256)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnFrontOffice
            location = New System.Drawing.Point(443, 79)
            cButton2.Location = location
            Me.btnFrontOffice.Name = "btnFrontOffice"
            Dim cButton3 As CButtonLib.CButton = Me.btnFrontOffice
            size = New System.Drawing.Size(415, 342)
            cButton3.Size = size
            Me.btnFrontOffice.TabIndex = 2
            Me.btnFrontOffice.Text = "Front Office"
            Me.btnFrontOffice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnFrontOffice.TextShadowShow = False
            Me.btnFrontOffice.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAlias
            Me.btnBackOffice.BackColor = System.Drawing.Color.Transparent
            Me.btnBackOffice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnBackOffice.BorderColor = System.Drawing.Color.Transparent
            Me.btnBackOffice.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56), System.Drawing.Color.FromArgb(58, 58, 56)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnBackOffice.ColorFillBlend = cBlendItems2
            Me.btnBackOffice.Corners.All = 10
            Me.btnBackOffice.Corners.LowerLeft = 10
            Me.btnBackOffice.Corners.LowerRight = 10
            Me.btnBackOffice.Corners.UpperLeft = 10
            Me.btnBackOffice.Corners.UpperRight = 10
            Me.btnBackOffice.DesignerSelected = False
            Me.btnBackOffice.Font = New System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBackOffice.Image = CType(componentResourceManager.GetObject("btnBackOffice.Image"), System.Drawing.Image)
            Me.btnBackOffice.ImageIndex = 0
            Dim cButton4 As CButtonLib.CButton = Me.btnBackOffice
            size = New System.Drawing.Size(256, 256)
            cButton4.ImageSize = size
            Dim cButton5 As CButtonLib.CButton = Me.btnBackOffice
            location = New System.Drawing.Point(12, 79)
            cButton5.Location = location
            Me.btnBackOffice.Name = "btnBackOffice"
            Dim cButton6 As CButtonLib.CButton = Me.btnBackOffice
            size = New System.Drawing.Size(415, 342)
            cButton6.Size = size
            Me.btnBackOffice.TabIndex = 1
            Me.btnBackOffice.Text = "Back Office"
            Me.btnBackOffice.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btnBackOffice.TextShadowShow = False
            Me.btnBackOffice.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
            Dim textBox As System.Windows.Forms.TextBox = Me.txtDisplayPort
            location = New System.Drawing.Point(24, 38)
            textBox.Location = location
            Me.txtDisplayPort.Name = "txtDisplayPort"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtDisplayPort
            size = New System.Drawing.Size(100, 20)
            textBox2.Size = size
            Me.txtDisplayPort.TabIndex = 22
            Me.txtDisplayPort.Visible = False
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button3 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(797, 12)
            button3.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button4 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(61, 58)
            button4.Size = size
            Me.btnClose.TabIndex = 3
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(874, 441)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.Controls.Add(Me.StatusStrip1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmOption"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Operations"
            Me.StatusStrip1.ResumeLayout(False)
            Me.StatusStrip1.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
