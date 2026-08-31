Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports RestaurantPOS14.My
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmSoftwareLicenceRenewal
        Inherits System.Windows.Forms.Form
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExtendLicence")>
        Private _btnExtendLicence As System.Windows.Forms.Button
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtActivationID")>
        Private _txtActivationID As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtSerialNo")>
        Private _txtSerialNo As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("TextBox1")>
        Private _TextBox1 As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblDays")>
        Private _lblDays As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbESC")>
        Private _cmbESC As System.Windows.Forms.ComboBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpCustomTimePeriod")>
        Private _dtpCustomTimePeriod As System.Windows.Forms.DateTimePicker
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label
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

        Friend Overridable Property btnExtendLicence As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnExtendLicence
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSave_Click
                If Me._btnExtendLicence IsNot Nothing Then
                    RemoveHandler Me._btnExtendLicence.Click, value2
                End If

                Me._btnExtendLicence = value
                If Me._btnExtendLicence IsNot Nothing Then
                    AddHandler Me._btnExtendLicence.Click, value2
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

        Friend Overridable Property txtActivationID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtActivationID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtActivationID = value
            End Set
        End Property

        Friend Overridable Property txtSerialNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtSerialNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtSerialNo = value
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

        Friend Overridable Property TextBox1 As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._TextBox1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._TextBox1 = value
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

        Friend Overridable Property lblDays As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblDays
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblDays = value
            End Set
        End Property

        Friend Overridable Property Label6 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label6 = value
            End Set
        End Property

        Friend Overridable Property cmbESC As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbESC
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbESC_SelectedIndexChanged
                If Me._cmbESC IsNot Nothing Then
                    RemoveHandler Me._cmbESC.SelectedIndexChanged, value2
                End If

                Me._cmbESC = value
                If Me._cmbESC IsNot Nothing Then
                    AddHandler Me._cmbESC.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property dtpCustomTimePeriod As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpCustomTimePeriod
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpCustomTimePeriod = value
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.FormClosing, AddressOf Me.frmSoftwareLicenceRenewal_FormClosing
            AddHandler MyBase.Load, AddressOf Me.frmActivation_Load
            Call RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList
                If RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList.Count = RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList(num) = RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList.RemoveRange(num, RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList.Count - num)
                    RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList.Capacity = RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSoftwareLicenceRenewal.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Shared Function GetUniqueKey(maxSize As Integer) As String
            Dim array As Char() = New Char(61) {}
            array = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
            Dim array2 As Byte() = New Byte(0) {}
            Dim rNGCryptoServiceProvider As System.Security.Cryptography.RNGCryptoServiceProvider = New System.Security.Cryptography.RNGCryptoServiceProvider()
            rNGCryptoServiceProvider.GetNonZeroBytes(array2)
            array2 = New Byte(maxSize - 1 + 1 - 1) {}
            rNGCryptoServiceProvider.GetNonZeroBytes(array2)
            Dim stringBuilder As System.Text.StringBuilder = New System.Text.StringBuilder(maxSize)
            Dim array3 As Byte() = array2
            For Each b As Byte In array3
                stringBuilder.Append(array(b Mod array.Length))
            Next

            Return stringBuilder.ToString()
        End Function

        Private Sub frmActivation_Load(sender As Object, e As System.EventArgs)
            Me.txtSerialNo.Text = RestaurantPOS14.frmSoftwareLicenceRenewal.GetUniqueKey(25)
            Me.txtActivationID.Text = ""
            Me.cmbESC.SelectedIndex = 0
            Me.dtpCustomTimePeriod.Value = Microsoft.VisualBasic.DateAndTime.Today
            Me.dtpCustomTimePeriod.Enabled = False
            Me.dtpCustomTimePeriod.Value = Microsoft.VisualBasic.DateAndTime.Today.AddYears(1)
            If Not System.IO.File.Exists(System.Windows.Forms.Application.StartupPath & "\LC.txt") Then
                Using streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(System.Windows.Forms.Application.StartupPath & "\LC.txt")
                    streamWriter.WriteLine(0)
                End Using
            End If

            If Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModFunc.ReadLC()) = 0.0 Then
                Dim d As System.DateTime = Microsoft.VisualBasic.CompilerServices.Conversions.ToDate(RestaurantPOS14.My.MyProject.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DotNetFramework45", "Set", Nothing))
                Dim num As Integer = 15 - (Microsoft.VisualBasic.DateAndTime.Today - d).Days
                If num > 0 Then
                    Me.lblDays.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(num) & " days left for trial expiry."
                Else
                    Me.lblDays.Text = "Trial Expired...."
                End If
            End If

            If Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble(RestaurantPOS14.ModFunc.ReadLC()) = 1.0 Then
                Dim days As Integer = (Microsoft.VisualBasic.CompilerServices.Conversions.ToDate(CObj((RestaurantPOS14.My.MyProject.Computer.Registry.GetValue(CStr(("HKEY_LOCAL_MACHINE\SOFTWARE\DotNetFramework45")), CStr(("Set")), CObj((Nothing)))))) - Microsoft.VisualBasic.DateAndTime.Today).Days
                If days > 0 Then
                    Me.lblDays.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(days) & " days left for license expiry."
                Else
                    Me.lblDays.Text = "License Expired...."
                End If
            End If
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            Try
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtActivationID.Text, "", TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Please enter activation id", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                    Me.txtActivationID.Focus()
                    Return
                End If

                If System.DateTime.Compare(Me.dtpCustomTimePeriod.Value.[Date], Microsoft.VisualBasic.DateAndTime.Today) <= 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Extended date must be greater than today's date.", "Selection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Return
                End If

                Dim text As String = Me.txtSerialNo.Text
                Me.TextBox1.Text = RestaurantPOS14.Encryption.MakePassword(text, Microsoft.VisualBasic.CompilerServices.Conversions.ToString(865))
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtActivationID.Text, Me.TextBox1.Text, TextCompare:=False) = 0 Then
                    Dim registryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE", writable:=True)
                    registryKey.DeleteSubKeyTree("DotNetFramework45")
                    registryKey.Close()
                    Dim dateTime As System.DateTime = DirectCast(Nothing, System.DateTime)
                    If Me.cmbESC.SelectedIndex = 0 Then
                        dateTime = Microsoft.VisualBasic.DateAndTime.Today.AddYears(1)
                    End If

                    If Me.cmbESC.SelectedIndex = 1 Then
                        dateTime = Me.dtpCustomTimePeriod.Value.[Date]
                    End If

                    Call RestaurantPOS14.My.MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\DotNetFramework45", "Set", dateTime)
                    Call System.IO.File.WriteAllText(System.Windows.Forms.Application.StartupPath & "\LC.txt", "")
                    Using streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(System.Windows.Forms.Application.StartupPath & "\LC.txt")
                        streamWriter.WriteLine(1)
                        streamWriter.Close()
                    End Using

                    Call System.Windows.Forms.MessageBox.Show("Successfully renewal", "Software License", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Call Microsoft.VisualBasic.CompilerServices.ProjectData.EndApp()
                Else
                    Call System.Windows.Forms.MessageBox.Show("Invalid activation id", "Input Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            Call Microsoft.VisualBasic.CompilerServices.ProjectData.EndApp()
        End Sub

        Private Sub cmbESC_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            If Me.cmbESC.SelectedIndex = 0 Then
                Me.dtpCustomTimePeriod.Enabled = False
                Me.dtpCustomTimePeriod.Value = Microsoft.VisualBasic.DateAndTime.Now.AddDays(365.0)
            ElseIf Me.cmbESC.SelectedIndex = 1 Then
                Me.dtpCustomTimePeriod.Enabled = True
                Me.dtpCustomTimePeriod.Value = Microsoft.VisualBasic.DateAndTime.Today
            End If
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub frmSoftwareLicenceRenewal_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
            Call Microsoft.VisualBasic.CompilerServices.ProjectData.EndApp()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSoftwareLicenceRenewal))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblDays = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.dtpCustomTimePeriod = New System.Windows.Forms.DateTimePicker()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cmbESC = New System.Windows.Forms.ComboBox()
            Me.txtActivationID = New System.Windows.Forms.TextBox()
            Me.txtSerialNo = New System.Windows.Forms.TextBox()
            Me.btnExtendLicence = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblDays)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(4, 4)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(557, 495)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.lblDays.AutoSize = True
            Me.lblDays.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblDays.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0)
            Dim label As System.Windows.Forms.Label = Me.lblDays
            location = New System.Drawing.Point(8, 75)
            label.Location = location
            Me.lblDays.Name = "lblDays"
            Dim label2 As System.Windows.Forms.Label = Me.lblDays
            size = New System.Drawing.Size(281, 25)
            label2.Size = size
            Me.lblDays.TabIndex = 2
            Me.lblDays.Text = "Software Renewal/Trial Expiry"
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(9, 110)
            label3.Location = location
            Me.Label4.Name = "Label4"
            Dim label4 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(379, 125)
            label4.Size = size
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "Contact us for renewing software licence." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Hitech Computer Centre" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Contact No - +6011-1143 3830" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Whatsapp - +6011-1143 3830" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Email - hitechcomputercentre.jayaraj@gmail.com"
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.btnClose)
            Me.GroupBox1.Controls.Add(Me.dtpCustomTimePeriod)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.cmbESC)
            Me.GroupBox1.Controls.Add(Me.txtActivationID)
            Me.GroupBox1.Controls.Add(Me.txtSerialNo)
            Me.GroupBox1.Controls.Add(Me.btnExtendLicence)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.ForeColor = System.Drawing.Color.White
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(14, 248)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(532, 242)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Software License Renewal"
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(47, 128)
            label5.Location = location
            Me.Label5.Name = "Label5"
            Dim label6 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(119, 16)
            label6.Size = size
            Me.Label5.TabIndex = 9
            Me.Label5.Text = "Extend up to Date :"
            Me.btnClose.BackColor = System.Drawing.Color.Crimson
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.ForeColor = System.Drawing.Color.White
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(355, 174)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(84, 52)
            button2.Size = size
            Me.btnClose.TabIndex = 5
            Me.btnClose.Text = "Exit"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Me.dtpCustomTimePeriod.CustomFormat = "dd/MM/yyyy"
            Me.dtpCustomTimePeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpCustomTimePeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpCustomTimePeriod
            location = New System.Drawing.Point(202, 128)
            dateTimePicker.Location = location
            Me.dtpCustomTimePeriod.Name = "dtpCustomTimePeriod"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpCustomTimePeriod
            size = New System.Drawing.Size(140, 26)
            dateTimePicker2.Size = size
            Me.dtpCustomTimePeriod.TabIndex = 3
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(16, 93)
            label7.Location = location
            Me.Label6.Name = "Label6"
            Dim label8 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(160, 16)
            label8.Size = size
            Me.Label6.TabIndex = 6
            Me.Label6.Text = "Extend Software License :"
            Me.cmbESC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbESC.FormattingEnabled = True
            Me.cmbESC.Items.AddRange(New Object(1) {"1 Year", "Custom Time Period"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbESC
            location = New System.Drawing.Point(202, 93)
            comboBox.Location = location
            Me.cmbESC.Name = "cmbESC"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbESC
            size = New System.Drawing.Size(215, 28)
            comboBox2.Size = size
            Me.cmbESC.TabIndex = 2
            Me.txtActivationID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtActivationID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtActivationID
            location = New System.Drawing.Point(202, 61)
            textBox.Location = location
            Me.txtActivationID.Name = "txtActivationID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtActivationID
            size = New System.Drawing.Size(324, 26)
            textBox2.Size = size
            Me.txtActivationID.TabIndex = 1
            Me.txtSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtSerialNo
            location = New System.Drawing.Point(202, 29)
            textBox3.Location = location
            Me.txtSerialNo.Name = "txtSerialNo"
            Me.txtSerialNo.[ReadOnly] = True
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtSerialNo
            size = New System.Drawing.Size(324, 26)
            textBox4.Size = size
            Me.txtSerialNo.TabIndex = 0
            Me.btnExtendLicence.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnExtendLicence.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExtendLicence.FlatAppearance.BorderSize = 0
            Me.btnExtendLicence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExtendLicence.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExtendLicence.ForeColor = System.Drawing.Color.White
            Me.btnExtendLicence.Image = RestaurantPOS14.My.Resources.Resources.Activate
            Me.btnExtendLicence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnExtendLicence
            location = New System.Drawing.Point(202, 174)
            button3.Location = location
            Me.btnExtendLicence.Name = "btnExtendLicence"
            Dim button4 As System.Windows.Forms.Button = Me.btnExtendLicence
            size = New System.Drawing.Size(147, 52)
            button4.Size = size
            Me.btnExtendLicence.TabIndex = 4
            Me.btnExtendLicence.Text = "Extend Licence"
            Me.btnExtendLicence.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExtendLicence.UseVisualStyleBackColor = False
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label9 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(78, 61)
            label9.Location = location
            Me.Label2.Name = "Label2"
            Dim label10 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(88, 16)
            label10.Size = size
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "Activation ID :"
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label11 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(93, 29)
            label11.Location = location
            Me.Label3.Name = "Label3"
            Dim label12 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(73, 16)
            label12.Size = size
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Serial No. :"
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(9, 7)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(543, 62)
            panel4.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label13 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(159, 17)
            label13.Location = location
            Me.Label1.Name = "Label1"
            Dim label14 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(256, 24)
            label14.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Software License Renewal"
            Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.TextBox1
            location = New System.Drawing.Point(260, -16)
            textBox5.Location = location
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.[ReadOnly] = True
            Dim textBox6 As System.Windows.Forms.TextBox = Me.TextBox1
            size = New System.Drawing.Size(227, 22)
            textBox6.Size = size
            Me.TextBox1.TabIndex = 5
            Me.TextBox1.Visible = False
            MyBase.AcceptButton = Me.btnExtendLicence
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            MyBase.CancelButton = Me.btnClose
            size = New System.Drawing.Size(563, 504)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.Controls.Add(Me.TextBox1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmSoftwareLicenceRenewal"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            MyBase.TopMost = True
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
