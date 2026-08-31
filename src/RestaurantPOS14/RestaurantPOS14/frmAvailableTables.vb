Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmAvailableTables
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblTable")>
        Private _lblTable As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpTables")>
        Private _flpTables As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnRefresh")>
        Private _btnRefresh As System.Windows.Forms.Button

        Private UserButtons As System.Collections.Generic.List(Of CButtonLib.CButton)

        Public Cshape As Object

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property btnCancel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCancel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnCancel_Click
                If Me._btnCancel IsNot Nothing Then
                    RemoveHandler Me._btnCancel.Click, value2
                End If

                Me._btnCancel = value
                If Me._btnCancel IsNot Nothing Then
                    AddHandler Me._btnCancel.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property lblTable As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblTable
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblTable = value
            End Set
        End Property

        Friend Overridable Property flpTables As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpTables
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpTables = value
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

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmAvailableTables_Load
            Call RestaurantPOS14.frmAvailableTables.__ENCAddToList(Me)
            Me.UserButtons = New System.Collections.Generic.List(Of CButtonLib.CButton)()
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmAvailableTables.__ENCList
                If RestaurantPOS14.frmAvailableTables.__ENCList.Count = RestaurantPOS14.frmAvailableTables.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmAvailableTables.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmAvailableTables.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmAvailableTables.__ENCList(num) = RestaurantPOS14.frmAvailableTables.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmAvailableTables.__ENCList.RemoveRange(num, RestaurantPOS14.frmAvailableTables.__ENCList.Count - num)
                    RestaurantPOS14.frmAvailableTables.__ENCList.Capacity = RestaurantPOS14.frmAvailableTables.__ENCList.Count
                End If

                Call RestaurantPOS14.frmAvailableTables.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub frmAvailableTables_Load(sender As Object, e As System.EventArgs)
            Me.flpTables.HorizontalScroll.Maximum = 0
            Me.flpTables.AutoScroll = False
            Me.flpTables.VerticalScroll.Visible = False
            Me.flpTables.AutoScroll = True
            Me.AvailableTables()
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            Try
                Dim value As String = CType(sender, CButtonLib.CButton).Text.Trim()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select Operator from RestaurantPOS_BillingInfoKOT,RestaurantPOS_OrderedProductBillKOT where RestaurantPOS_BillingInfoKOT.Id=RestaurantPOS_OrderedProductBillKOT.BillID and DIB_Status='Unpaid' and TableNo=@d1 and BillType='Split Bill'", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblTable.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Bill is already generated for selected table using split bill, Table can't be changed.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Call Microsoft.VisualBasic.FileSystem.Reset()
                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update RestaurantPOS_OrderInfoKOT set TableNo=@d1 where TableNo=@d2 and KOT_Status in ('Open','Prepared')")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", value)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblTable.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("UPDATE A  SET T_Number=@d1 from RestaurantPOS_OrderedProductKOT A  INNER JOIN RestaurantPOS_OrderInfoKOT B ON A.TicketID=B.ID where T_Number=@d2 and KOT_Status in ('Open','Prepared')")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", value)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblTable.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("UPDATE A  SET TableNo=@d1 from RestaurantPOS_OrderedProductBillKOT A  INNER JOIN RestaurantPOS_BillingInfoKOT B ON A.BillID=B.ID where TableNo=@d2 and DIB_Status='Unpaid' and BillType='Normal Bill'")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", value)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.lblTable.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update R_Table set BkColor=@d2 where TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", value)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Drawing.Color.Red.ToArgb())
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update R_Table set BkColor=@d2 where TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.lblTable.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Drawing.Color.LightGreen.ToArgb())
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Call RestaurantPOS14.My.MyProject.Forms.frmCustomDialog5.ShowDialog()
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.fillTableNo()
                RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTableNo.Text = ""
                MyBase.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub AvailableTables()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(R_Table.TableNo),BkColor,RTRIM(ShapeX) from R_Table where BkColor=@d1 and Status='Activate' order by LEFT(R_Table.TableNo, PATINDEX('%[0-9]%', R_Table.TableNo)-1),CONVERT(INT, SUBSTRING(R_Table.TableNo, PATINDEX('%[0-9]%', R_Table.TableNo), LEN(R_Table.TableNo)))")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", System.Drawing.Color.LightGreen.ToArgb())
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpTables.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim cbutton As CButtonLib.CButton = New CButtonLib.CButton()
                    cbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(1))))))
                    cbutton.ColorFillBlend = New CButtonLib.cBlendItems With {.iColor = New System.Drawing.Color(2) {color, color, color}, .iPoint = New Single(2) {0F, 0.5F, 1F}}
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString(), "Ellipse", TextCompare:=False) = 0 Then
                        Me.Cshape = CButtonLib.CButton.eShape.Ellipse
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString(), "Rectangle", TextCompare:=False) = 0 Then
                        Me.Cshape = CButtonLib.CButton.eShape.Rectangle
                        cbutton.Corners.All = 3
                        cbutton.Corners.LowerLeft = 3
                        cbutton.Corners.LowerRight = 3
                        cbutton.Corners.UpperLeft = 3
                        cbutton.Corners.UpperRight = 3
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString(), "Triangle Up", TextCompare:=False) = 0 Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleUp
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString(), "Triangle Down", TextCompare:=False) = 0 Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleDown
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString(), "Triangle Left", TextCompare:=False) = 0 Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleLeft
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((2))).ToString(), "Triangle Right", TextCompare:=False) = 0 Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleRight
                    End If

                    cbutton.Shape = CType(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Me.Cshape), CButtonLib.CButton.eShape)
                    cbutton.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                    cbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    cbutton.Width = 190
                    cbutton.Height = 150
                    cbutton.TextShadowShow = False
                    cbutton.ForeColor = System.Drawing.Color.White
                    cbutton.BackColor = System.Drawing.Color.Transparent
                    cbutton.UseMnemonic = False
                    cbutton.BorderShow = False
                    cbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.UserButtons.Add(cbutton)
                    Me.flpTables.Controls.Add(cbutton)
                    AddHandler cbutton.Click, AddressOf Me.Button2_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub btnRefresh_Click(sender As Object, e As System.EventArgs)
            Me.AvailableTables()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmAvailableTables))
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lblTable = New System.Windows.Forms.Label()
            Me.flpTables = New System.Windows.Forms.FlowLayoutPanel()
            Me.btnRefresh = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label5
            Dim location As System.Drawing.Point = New System.Drawing.Point(0, 1)
            label.Location = location
            Me.Label5.Name = "Label5"
            Dim label2 As System.Windows.Forms.Label = Me.Label5
            Dim size As System.Drawing.Size = New System.Drawing.Size(689, 50)
            label2.Size = size
            Me.Label5.TabIndex = 20
            Me.Label5.Text = "Available Tables"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblTable.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblTable
            location = New System.Drawing.Point(87, 13)
            label3.Location = location
            Me.lblTable.Name = "lblTable"
            Dim label4 As System.Windows.Forms.Label = Me.lblTable
            size = New System.Drawing.Size(44, 13)
            label4.Size = size
            Me.lblTable.TabIndex = 63
            Me.lblTable.Text = "lblTable"
            Me.lblTable.Visible = False
            Me.flpTables.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpTables.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpTables
            location = New System.Drawing.Point(2, 54)
            flowLayoutPanel.Location = location
            Me.flpTables.Name = "flpTables"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpTables
            size = New System.Drawing.Size(802, 402)
            flowLayoutPanel2.Size = size
            Me.flpTables.TabIndex = 64
            Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
            Me.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnRefresh.FlatAppearance.BorderSize = 0
            Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnRefresh.Image = CType(componentResourceManager.GetObject("btnRefresh.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnRefresh
            location = New System.Drawing.Point(695, 2)
            button.Location = location
            Me.btnRefresh.Name = "btnRefresh"
            Dim button2 As System.Windows.Forms.Button = Me.btnRefresh
            size = New System.Drawing.Size(52, 49)
            button2.Size = size
            Me.btnRefresh.TabIndex = 65
            Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRefresh.UseVisualStyleBackColor = False
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button3 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(752, 2)
            button3.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button4 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 49)
            button4.Size = size
            Me.btnCancel.TabIndex = 61
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(804, 456)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnRefresh)
            MyBase.Controls.Add(Me.flpTables)
            MyBase.Controls.Add(Me.lblTable)
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Label5)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmAvailableTables"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Available Tables"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
