Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports MetroFramework
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmAssignedTablesList_Waiter
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpTables")>
        Private _flpTables As System.Windows.Forms.FlowLayoutPanel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        Private UserButtons As System.Collections.Generic.List(Of CButtonLib.CButton)

        Public Cshape As Object

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property btnClose As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClose
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnLogout_Click
                If Me._btnClose IsNot Nothing Then
                    RemoveHandler Me._btnClose.Click, value2
                End If

                Me._btnClose = value
                If Me._btnClose IsNot Nothing Then
                    AddHandler Me._btnClose.Click, value2
                End If
            End Set
        End Property

        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmAssignedTablesList_Waiter_Load
            Call RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCAddToList(Me)
            Me.UserButtons = New System.Collections.Generic.List(Of CButtonLib.CButton)()
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList
                If RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList.Count = RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList(num) = RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList.RemoveRange(num, RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList.Count - num)
                    RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList.Capacity = RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList.Count
                End If

                Call RestaurantPOS14.frmAssignedTablesList_Waiter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Fill(st As String)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(R_Table.TableNo),BkColor,RTRIM(ShapeX),Sum(Case when KOT_Status not in ('Closed','Void') then GrandTotal else NULL end),Max(Case when KOT_Status not in ('Closed','Void') then DateDiff(Minute,(BillDate),GetDate()) else NULL end) from R_Table left Join RestaurantPOS_OrderInfoKOT on R_Table.TableNo=RestaurantPOS_OrderInfoKOT.TableNo left Join TableMapping on R_Table.TableNo=TableMapping.TableNo where Status='Activate' and TableMapping.UserID=@d1 group By R_Table.TableNo,BkColor,ShapeX ORDER BY LEFT(R_Table.TableNo, PATINDEX('%[0-9]%', R_Table.TableNo)-1),CONVERT(INT, SUBSTRING(R_Table.TableNo, PATINDEX('%[0-9]%', R_Table.TableNo), LEN(R_Table.TableNo))) ")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", st)
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
                    If Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(1))) = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble("-65536") Then
                        cbutton.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(RestaurantPOS14.ModClasses.rdr.GetValue(0), System.Environment.NewLine), RestaurantPOS14.ModClasses.rdr.GetValue(3)), System.Environment.NewLine), RestaurantPOS14.ModClasses.rdr.GetValue(4)), " "), "Minutes"))
                    Else
                        cbutton.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

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
                    AddHandler cbutton.Click, AddressOf Me.button1_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub button1_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTableNo.Text = ""
                Dim array As String() = Microsoft.VisualBasic.Strings.Split(CType(sender, CButtonLib.CButton).Text.Trim(), Global.Microsoft.VisualBasic.Constants.vbCrLf)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTableNo.Text = array(0)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbGroup.Enabled = True
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.FillGroup()
                MyBase.Close()
            Catch ex As System.Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub frmAssignedTablesList_Waiter_Load(sender As Object, e As System.EventArgs)
            Me.flpTables.HorizontalScroll.Maximum = 0
            Me.flpTables.AutoScroll = False
            Me.flpTables.VerticalScroll.Visible = False
            Me.flpTables.AutoScroll = True
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmAssignedTablesList_Waiter))
            Me.flpTables = New System.Windows.Forms.FlowLayoutPanel()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            MyBase.SuspendLayout()
            Me.flpTables.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpTables.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpTables
            Dim location As System.Drawing.Point = New System.Drawing.Point(2, 54)
            flowLayoutPanel.Location = location
            Me.flpTables.Name = "flpTables"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpTables
            Dim size As System.Drawing.Size = New System.Drawing.Size(688, 379)
            flowLayoutPanel2.Size = size
            Me.flpTables.TabIndex = 4
            Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(1, 1)
            label.Location = location
            Me.Label5.Name = "Label5"
            Dim label2 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(631, 50)
            label2.Size = size
            Me.Label5.TabIndex = 390
            Me.Label5.Text = "List of Assigned Tables"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Dim button As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(638, 2)
            button.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button2 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(52, 49)
            button2.Size = size
            Me.btnClose.TabIndex = 392
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(694, 433)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.Label5)
            MyBase.Controls.Add(Me.flpTables)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.KeyPreview = True
            MyBase.Name = "frmAssignedTablesList_Waiter"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Tables"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
