Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmReport
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("CrystalReportViewer1")>
        Private _CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmailID")>
        Private _txtEmailID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSendMail")>
        Private _btnSendMail As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

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

        Friend Overridable Property txtEmailID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmailID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEmailID = value
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

        Friend Overridable Property btnSendMail As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSendMail
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSendMail_Click
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmReport.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmReport.__ENCList
                If RestaurantPOS14.frmReport.__ENCList.Count = RestaurantPOS14.frmReport.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmReport.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmReport.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmReport.__ENCList(num) = RestaurantPOS14.frmReport.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmReport.__ENCList.RemoveRange(num, RestaurantPOS14.frmReport.__ENCList.Count - num)
                    RestaurantPOS14.frmReport.__ENCList.Capacity = RestaurantPOS14.frmReport.__ENCList.Count
                End If

                Call RestaurantPOS14.frmReport.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnSendMail_Click(sender As Object, e As System.EventArgs)
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
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.ReadCS())
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select RTRIM(Username),RTRIM(Password),RTRIM(SMTPAddress),(Port) from EmailSetting where IsDefault='Yes' and IsActive='Yes'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If sqlDataReader.Read() Then
                    Dim reportSource As Object = Me.CrystalReportViewer1.ReportSource
                    Dim text As String = RestaurantPOS14.Customization.CrystalReportExporter.Export(reportSource, reportSource.GetType().Name, "Report")

                    RestaurantPOS14.ModFunc.SendMail1(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0)), Me.txtEmailID.Text, "Please find the attachment below", text, "Restaurant POS Report", Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(2)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(sqlDataReader.GetValue(3)), Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(0)), RestaurantPOS14.ModFunc.Decrypt(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(sqlDataReader.GetValue(1))))
                    sqlDataReader?.Close()
                    Call System.Windows.Forms.MessageBox.Show("Successfully Sent", "Mail", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmReport))
            Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
            Me.txtEmailID = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.btnSendMail = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            MyBase.SuspendLayout()
            Me.CrystalReportViewer1.ActiveViewIndex = -1
            Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Dim crystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer = Me.CrystalReportViewer1
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 0)
            crystalReportViewer.Location = location
            Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
            Me.CrystalReportViewer1.ShowLogo = False
            Dim crystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer = Me.CrystalReportViewer1
            Dim size As System.Drawing.Size = New System.Drawing.Size(960, 468)
            crystalReportViewer2.Size = size
            Me.CrystalReportViewer1.TabIndex = 0
            Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            Me.txtEmailID.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.txtEmailID.BackColor = System.Drawing.Color.White
            Me.txtEmailID.Font = New System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtEmailID
            location = New System.Drawing.Point(502, 22)
            textBox.Location = location
            Me.txtEmailID.Name = "txtEmailID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtEmailID
            size = New System.Drawing.Size(270, 29)
            textBox2.Size = size
            Me.txtEmailID.TabIndex = 8
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim label As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(499, 4)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(115, 15)
            label2.Size = size
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Enter Your Email ID :"
            Me.btnSendMail.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnSendMail.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.btnSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSendMail.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnSendMail
            location = New System.Drawing.Point(778, 22)
            button.Location = location
            Me.btnSendMail.Name = "btnSendMail"
            Dim button2 As System.Windows.Forms.Button = Me.btnSendMail
            size = New System.Drawing.Size(150, 29)
            button2.Size = size
            Me.btnSendMail.TabIndex = 10
            Me.btnSendMail.Text = "&Send Report as PDF"
            Me.btnSendMail.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            size = New System.Drawing.Size(960, 468)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnSendMail)
            MyBase.Controls.Add(Me.txtEmailID)
            MyBase.Controls.Add(Me.Label1)
            MyBase.Controls.Add(Me.CrystalReportViewer1)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmReport"
            Me.Text = "Report"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
