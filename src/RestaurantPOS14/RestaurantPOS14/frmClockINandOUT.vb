Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmClockINandOUT
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClockIN")>
        Private _btnClockIN As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClockOUT")>
        Private _btnClockOUT As CButtonLib.CButton

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCurrentClockInID")>
        Private _txtCurrentClockInID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property btnClockIN As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClockIN
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnClockIN_Click
                If Me._btnClockIN IsNot Nothing Then
                    RemoveHandler Me._btnClockIN.Click, value2
                End If

                Me._btnClockIN = value
                If Me._btnClockIN IsNot Nothing Then
                    AddHandler Me._btnClockIN.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnClockOUT As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClockOUT
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnClockOUT_Click
                If Me._btnClockOUT IsNot Nothing Then
                    RemoveHandler Me._btnClockOUT.Click, value2
                End If

                Me._btnClockOUT = value
                If Me._btnClockOUT IsNot Nothing Then
                    AddHandler Me._btnClockOUT.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._OpenFileDialog1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.OpenFileDialog)
                Me._OpenFileDialog1 = value
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

        Friend Overridable Property txtCurrentClockInID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCurrentClockInID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCurrentClockInID = value
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmClockINandOUT_Load
            Call RestaurantPOS14.frmClockINandOUT.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmClockINandOUT.__ENCList
                If RestaurantPOS14.frmClockINandOUT.__ENCList.Count = RestaurantPOS14.frmClockINandOUT.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmClockINandOUT.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmClockINandOUT.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmClockINandOUT.__ENCList(num) = RestaurantPOS14.frmClockINandOUT.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmClockINandOUT.__ENCList.RemoveRange(num, RestaurantPOS14.frmClockINandOUT.__ENCList.Count - num)
                    RestaurantPOS14.frmClockINandOUT.__ENCList.Capacity = RestaurantPOS14.frmClockINandOUT.__ENCList.Count
                End If

                Call RestaurantPOS14.frmClockINandOUT.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnClockOUT_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCustomDialogX1.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialogX1.ShowDialog()
        End Sub

        Private Sub btnClockIN_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCustomDialogX2.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialogX2.ShowDialog()
        End Sub

        Public Sub CheckFirstTimeClockIn()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT * from ClockIN where UserID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblUser.Text)
                Dim sqlDataReader As System.Data.SqlClient.SqlDataReader = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If sqlDataReader.Read() Then
                    Me.DisableClockIN()
                    Me.DisableClockOUT()
                Else
                    Me.btnClockIN.Enabled = True
                    Me.btnClockOUT.Enabled = False
                End If

                sqlDataReader?.Close()
                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub DisableClockIN()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Top 1 ClockIN.ID from ClockIN where UserID=@d1 order by ClockIN.ID Desc"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblUser.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT ClockINID from ClockOUT where ClockInID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtCurrentClockInID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If Not RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.btnClockIN.Enabled = False
                Else
                    Me.btnClockIN.Enabled = True
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub DisableClockOUT()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT Top 1 ClockIN.ID from ClockIN where UserID=@d1 order by ClockIN.ID Desc"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblUser.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                Else
                    Me.txtCurrentClockInID.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(0)
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = RestaurantPOS14.ModClasses.con.CreateCommand()
                RestaurantPOS14.ModClasses.cmd.CommandText = "SELECT ClockINID from ClockOUT where ClockInID=@d1"
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtCurrentClockInID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.btnClockOUT.Enabled = False
                Else
                    Me.btnClockOUT.Enabled = True
                End If

                If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                    RestaurantPOS14.ModClasses.rdr.Close()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmClockINandOUT_Load(sender As Object, e As System.EventArgs)
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            MyBase.Close()
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
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmClockINandOUT))
            Me.lblUser = New System.Windows.Forms.Label()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
            Me.btnClockOUT = New CButtonLib.CButton()
            Me.btnClockIN = New CButtonLib.CButton()
            Me.txtCurrentClockInID = New System.Windows.Forms.TextBox()
            Me.btnClose = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.lblUser.AutoSize = True
            Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUser.ForeColor = System.Drawing.Color.Black
            Dim label As System.Windows.Forms.Label = Me.lblUser
            Dim location As System.Drawing.Point = New System.Drawing.Point(12, 4)
            label.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label2 As System.Windows.Forms.Label = Me.lblUser
            Dim size As System.Drawing.Size = New System.Drawing.Size(43, 13)
            label2.Size = size
            Me.lblUser.TabIndex = 321
            Me.lblUser.Text = "lblUser"
            Me.lblUser.Visible = False
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Me.btnClockOUT.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnClockOUT.BackColor = System.Drawing.Color.Transparent
            Me.btnClockOUT.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnClockOUT.ColorFillBlend = cBlendItems
            Me.btnClockOUT.Corners.All = 3
            Me.btnClockOUT.Corners.LowerLeft = 3
            Me.btnClockOUT.Corners.LowerRight = 3
            Me.btnClockOUT.Corners.UpperLeft = 3
            Me.btnClockOUT.Corners.UpperRight = 3
            Me.btnClockOUT.DesignerSelected = False
            Me.btnClockOUT.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClockOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnClockOUT.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnClockOUT.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnClockOUT
            location = New System.Drawing.Point(238, 36)
            cButton.Location = location
            Me.btnClockOUT.Name = "btnClockOUT"
            Dim cButton2 As CButtonLib.CButton = Me.btnClockOUT
            size = New System.Drawing.Size(217, 87)
            cButton2.Size = size
            Me.btnClockOUT.TabIndex = 324
            Me.btnClockOUT.Text = "Clock OUT"
            Me.btnClockOUT.TextShadowShow = False
            Me.btnClockOUT.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnClockIN.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.btnClockIN.BackColor = System.Drawing.Color.Transparent
            Me.btnClockIN.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnClockIN.ColorFillBlend = cBlendItems2
            Me.btnClockIN.Corners.All = 3
            Me.btnClockIN.Corners.LowerLeft = 3
            Me.btnClockIN.Corners.LowerRight = 3
            Me.btnClockIN.Corners.UpperLeft = 3
            Me.btnClockIN.Corners.UpperRight = 3
            Me.btnClockIN.DesignerSelected = False
            Me.btnClockIN.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClockIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
            Me.btnClockIN.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btnClockIN.ImageIndex = 0
            Dim cButton3 As CButtonLib.CButton = Me.btnClockIN
            location = New System.Drawing.Point(15, 36)
            cButton3.Location = location
            Me.btnClockIN.Name = "btnClockIN"
            Dim cButton4 As CButtonLib.CButton = Me.btnClockIN
            size = New System.Drawing.Size(217, 87)
            cButton4.Size = size
            Me.btnClockIN.TabIndex = 323
            Me.btnClockIN.Text = "Clock IN"
            Me.btnClockIN.TextShadowShow = False
            Me.btnClockIN.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Dim textBox As System.Windows.Forms.TextBox = Me.txtCurrentClockInID
            location = New System.Drawing.Point(132, 4)
            textBox.Location = location
            Me.txtCurrentClockInID.Name = "txtCurrentClockInID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtCurrentClockInID
            size = New System.Drawing.Size(100, 20)
            textBox2.Size = size
            Me.txtCurrentClockInID.TabIndex = 325
            Me.txtCurrentClockInID.Visible = False
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(425, -1)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(37, 36)
            button2.Size = size
            Me.btnClose.TabIndex = 344
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(462, 133)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.txtCurrentClockInID)
            MyBase.Controls.Add(Me.btnClockOUT)
            MyBase.Controls.Add(Me.btnClockIN)
            MyBase.Controls.Add(Me.lblUser)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Name = "frmClockINandOUT"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "frmSettings"
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
