Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Management
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmPrinterStatus
        Inherits System.Windows.Forms.Form
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpPrintersList")>
        Private _flpPrintersList As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRefresh")>
        Private _btnRefresh As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        Private UserButtons As System.Collections.Generic.List(Of System.Windows.Forms.Button)

        Private cmbPOSPrinters As System.Windows.Forms.ComboBox

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property flpPrintersList As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpPrintersList
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpPrintersList = value
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
                Me._Timer1 = value
            End Set
        End Property

        Friend Overridable Property btnRefresh As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnRefresh
            End Get
            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnRefresh_Click
                If Me._btnRefresh IsNot Nothing Then
                    RemoveHandler Me._btnRefresh.Click, value2
                End If
                Me._btnRefresh = value
                If Me._btnRefresh IsNot Nothing Then
                    AddHandler Me._btnRefresh.Click, value2
                End If
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

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmPrinterStatus_Load
            Call RestaurantPOS14.frmPrinterStatus.__ENCAddToList(Me)
            Me.UserButtons = New System.Collections.Generic.List(Of System.Windows.Forms.Button)()
            Me.cmbPOSPrinters = New System.Windows.Forms.ComboBox()
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmPrinterStatus.__ENCList
                If RestaurantPOS14.frmPrinterStatus.__ENCList.Count = RestaurantPOS14.frmPrinterStatus.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmPrinterStatus.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If
                        If RestaurantPOS14.frmPrinterStatus.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmPrinterStatus.__ENCList(num) = RestaurantPOS14.frmPrinterStatus.__ENCList(num3)
                            End If
                            num += 1
                        End If
                        num3 += 1
                    End While
                    Call RestaurantPOS14.frmPrinterStatus.__ENCList.RemoveRange(num, RestaurantPOS14.frmPrinterStatus.__ENCList.Count - num)
                    RestaurantPOS14.frmPrinterStatus.__ENCList.Capacity = RestaurantPOS14.frmPrinterStatus.__ENCList.Count
                End If
                Call RestaurantPOS14.frmPrinterStatus.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub GetPOSPrinters()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Distinct RTRIM(Printer) from Kitchen UNION SELECT Distinct RTRIM(PrinterName) from POSPrinterSetting order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.cmbPOSPrinters.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.cmbPOSPrinters.Items.Add(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString())
                End While
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub GetPrinterData()
            Try
                Dim managementObjectSearcher As System.Management.ManagementObjectSearcher = New System.Management.ManagementObjectSearcher("SELECT * from Win32_Printer")
                Me.flpPrintersList.Controls.Clear()
                For Each item As System.Management.ManagementBaseObject In managementObjectSearcher.[Get]()
                    Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
                    Dim size As System.Drawing.Size = New System.Drawing.Size(300, 120)
                    flowLayoutPanel.Size = size
                    flowLayoutPanel.BackColor = System.Drawing.Color.White
                    flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                    flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
                    Dim text As String = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(item.GetPropertyValue("Name"))
                    Dim text2 As String = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(item.GetPropertyValue("Status"))
                    Dim text3 As String = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(item.GetPropertyValue("Default"))
                    Dim text4 As String = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(item.GetPropertyValue("Network"))
                    For Each item2 As Object In Me.cmbPOSPrinters.Items
                        If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(item2), text, TextCompare:=False) Then
                            Dim button As System.Windows.Forms.Button = New System.Windows.Forms.Button()
                            button.Text = "Printer : " & text & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Status : " & text2 & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Default : " & text3 & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Network Printer : " & text4
                            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                            button.Width = 290
                            button.Height = 110
                            button.FlatAppearance.BorderSize = 0
                            button.Font = New System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
                            button.TextAlign = System.Drawing.ContentAlignment.TopLeft
                            button.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
                            button.ForeColor = System.Drawing.Color.White
                            Me.UserButtons.Add(button)
                            flowLayoutPanel.Controls.Add(button)
                            Me.flpPrintersList.Controls.Add(flowLayoutPanel)
                        End If
                    Next
                Next
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmPrinterStatus_Load(sender As Object, e As System.EventArgs)
            Me.GetPOSPrinters()
            Me.GetPrinterData()
        End Sub

        Private Sub btnRefresh_Click(sender As Object, e As System.EventArgs)
            Me.GetPOSPrinters()
            Me.GetPrinterData()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmPrinterStatus))
            Me.flpPrintersList = New System.Windows.Forms.FlowLayoutPanel()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.btnRefresh = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            MyBase.SuspendLayout()
            Me.flpPrintersList.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpPrintersList.BackColor = System.Drawing.Color.White
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpPrintersList
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 68)
            flowLayoutPanel.Location = location
            Me.flpPrintersList.Name = "flpPrintersList"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpPrintersList
            Dim size As System.Drawing.Size = New System.Drawing.Size(902, 399)
            flowLayoutPanel2.Size = size
            Me.flpPrintersList.TabIndex = 0
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 10000
            Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRefresh.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnRefresh
            location = New System.Drawing.Point(7, 2)
            button.Location = location
            Me.btnRefresh.Name = "btnRefresh"
            Dim button2 As System.Windows.Forms.Button = Me.btnRefresh
            size = New System.Drawing.Size(132, 61)
            button2.Size = size
            Me.btnRefresh.TabIndex = 1
            Me.btnRefresh.Text = "Refresh"
            Me.btnRefresh.UseVisualStyleBackColor = False
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(145, 14)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(566, 40)
            label2.Size = size
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "All Kitchens and POS Printers Information"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(904, 469)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Label1)
            MyBase.Controls.Add(Me.btnRefresh)
            MyBase.Controls.Add(Me.flpPrintersList)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.Name = "frmPrinterStatus"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Printer Status"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
