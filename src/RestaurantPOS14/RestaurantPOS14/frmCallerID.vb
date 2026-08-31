Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO.Ports
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmCallerID
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtInfo")>
        Private _txtInfo As System.Windows.Forms.RichTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCallerIDComPort")>
        Private _txtCallerIDComPort As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTillID")>
        Private _txtTillID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnOkay")>
        Private _btnOkay As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblCustomer")>
        Private _lblCustomer As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPhoneNo")>
        Private _txtPhoneNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("com1")>
        Private _com1 As System.IO.Ports.SerialPort

        Private st As String

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property txtInfo As System.Windows.Forms.RichTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtInfo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.RichTextBox)
                Me._txtInfo = value
            End Set
        End Property

        Friend Overridable Property txtCallerIDComPort As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCallerIDComPort
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCallerIDComPort = value
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

        Friend Overridable Property btnOkay As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnOkay
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnOkay_Click
                If Me._btnOkay IsNot Nothing Then
                    RemoveHandler Me._btnOkay.Click, value2
                End If

                Me._btnOkay = value
                If Me._btnOkay IsNot Nothing Then
                    AddHandler Me._btnOkay.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblCustomer As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblCustomer
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblCustomer = value
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

        Friend Overridable Property txtPhoneNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPhoneNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPhoneNo = value
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

        Friend Overridable Property com1 As System.IO.Ports.SerialPort
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._com1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.IO.Ports.SerialPort)
                Dim value2 As System.IO.Ports.SerialDataReceivedEventHandler = AddressOf Me.com1_DataReceived
                If Me._com1 IsNot Nothing Then
                    RemoveHandler Me._com1.DataReceived, value2
                End If

                Me._com1 = value
                If Me._com1 IsNot Nothing Then
                    AddHandler Me._com1.DataReceived, value2
                End If
            End Set
        End Property

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.Form1_Load
            Call RestaurantPOS14.frmCallerID.__ENCAddToList(Me)
            Me.com1 = New System.IO.Ports.SerialPort()
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCallerID.__ENCList
                If RestaurantPOS14.frmCallerID.__ENCList.Count = RestaurantPOS14.frmCallerID.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCallerID.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCallerID.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCallerID.__ENCList(num) = RestaurantPOS14.frmCallerID.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCallerID.__ENCList.RemoveRange(num, RestaurantPOS14.frmCallerID.__ENCList.Count - num)
                    RestaurantPOS14.frmCallerID.__ENCList.Capacity = RestaurantPOS14.frmCallerID.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCallerID.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub Form1_Load(sender As Object, e As System.EventArgs)
            Dim serialPort As System.IO.Ports.SerialPort = Me.com1
            Dim settings = RestaurantPOS14.Configuration.SettingsHost.Current.Printing
            serialPort.PortName = If(String.IsNullOrWhiteSpace(settings.CallerIdPort), settings.CallerIdDiagnosticPort, settings.CallerIdPort)
            serialPort.BaudRate = 9600
            serialPort.Parity = System.IO.Ports.Parity.Even
            serialPort.DataBits = 7
            serialPort.StopBits = System.IO.Ports.StopBits.One
            serialPort.RtsEnable = True
            serialPort.DtrEnable = True
            serialPort.Handshake = System.IO.Ports.Handshake.XOnXOff
            RestaurantPOS14.Configuration.SerialPortFactory.ApplyTimeouts(serialPort)
            AddHandler Me.com1.DataReceived, AddressOf Me.com1_DataReceived
            Me.com1.Open()
            Me.com1.WriteLine("W" & System.Environment.NewLine)
        End Sub

        Private Sub com1_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs)
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
            Me.txtInfo.Text += Me.com1.ReadExisting()
        End Sub

        Private Sub btnOkay_Click(sender As Object, e As System.EventArgs)
            Me.Timer1.[Stop]()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            AddHandler Me.com1.DataReceived, AddressOf Me.com1_DataReceived
            Me.com1.WriteLine("W" & System.Environment.NewLine)
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.txtInfo.Text = ""
            Me.lblCustomer.Text = ""
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCallerID))
            Me.txtInfo = New System.Windows.Forms.RichTextBox()
            Me.txtCallerIDComPort = New System.Windows.Forms.TextBox()
            Me.txtTillID = New System.Windows.Forms.TextBox()
            Me.btnOkay = New System.Windows.Forms.Button()
            Me.lblCustomer = New System.Windows.Forms.Label()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.txtPhoneNo = New System.Windows.Forms.TextBox()
            Me.btnReset = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Dim richTextBox As System.Windows.Forms.RichTextBox = Me.txtInfo
            Dim location As System.Drawing.Point = New System.Drawing.Point(2, 24)
            richTextBox.Location = location
            Me.txtInfo.Name = "txtInfo"
            Me.txtInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
            Dim richTextBox2 As System.Windows.Forms.RichTextBox = Me.txtInfo
            Dim size As System.Drawing.Size = New System.Drawing.Size(224, 128)
            richTextBox2.Size = size
            Me.txtInfo.TabIndex = 0
            Me.txtInfo.Text = ""
            Dim textBox As System.Windows.Forms.TextBox = Me.txtCallerIDComPort
            location = New System.Drawing.Point(229, 82)
            textBox.Location = location
            Me.txtCallerIDComPort.Name = "txtCallerIDComPort"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtCallerIDComPort
            size = New System.Drawing.Size(26, 20)
            textBox2.Size = size
            Me.txtCallerIDComPort.TabIndex = 1
            Me.txtCallerIDComPort.Visible = False
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtTillID
            location = New System.Drawing.Point(261, 82)
            textBox3.Location = location
            Me.txtTillID.Name = "txtTillID"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtTillID
            size = New System.Drawing.Size(25, 20)
            textBox4.Size = size
            Me.txtTillID.TabIndex = 2
            Me.txtTillID.Visible = False
            Me.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button As System.Windows.Forms.Button = Me.btnOkay
            location = New System.Drawing.Point(232, 13)
            button.Location = location
            Me.btnOkay.Name = "btnOkay"
            Dim button2 As System.Windows.Forms.Button = Me.btnOkay
            size = New System.Drawing.Size(56, 63)
            button2.Size = size
            Me.btnOkay.TabIndex = 3
            Me.btnOkay.Text = "&Ok"
            Me.btnOkay.UseVisualStyleBackColor = True
            Me.lblCustomer.AutoSize = True
            Me.lblCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.lblCustomer
            location = New System.Drawing.Point(5, 4)
            label.Location = location
            Me.lblCustomer.Name = "lblCustomer"
            Dim label2 As System.Windows.Forms.Label = Me.lblCustomer
            size = New System.Drawing.Size(81, 17)
            label2.Size = size
            Me.lblCustomer.TabIndex = 4
            Me.lblCustomer.Text = "lblCustomer"
            Me.Timer1.Interval = 50
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtPhoneNo
            location = New System.Drawing.Point(232, 121)
            textBox5.Location = location
            Me.txtPhoneNo.Name = "txtPhoneNo"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtPhoneNo
            size = New System.Drawing.Size(53, 20)
            textBox6.Size = size
            Me.txtPhoneNo.TabIndex = 5
            Me.txtPhoneNo.Visible = False
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim button3 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(232, 82)
            button3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button4 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(56, 63)
            button4.Size = size
            Me.btnReset.TabIndex = 6
            Me.btnReset.Text = "&Reset"
            Me.btnReset.UseVisualStyleBackColor = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(288, 153)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.txtPhoneNo)
            MyBase.Controls.Add(Me.lblCustomer)
            MyBase.Controls.Add(Me.btnOkay)
            MyBase.Controls.Add(Me.txtTillID)
            MyBase.Controls.Add(Me.txtCallerIDComPort)
            MyBase.Controls.Add(Me.txtInfo)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmCallerID"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Caller ID"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
