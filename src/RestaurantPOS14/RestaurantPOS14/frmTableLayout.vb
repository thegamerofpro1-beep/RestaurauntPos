Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
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
    Public Class frmTableLayout
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("pnlTables")>
        Private _pnlTables As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("flpTableType")>
        Private _flpTableType As System.Windows.Forms.FlowLayoutPanel

        Private str1 As String

        Private Cshape As Object

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property pnlTables As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._pnlTables
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._pnlTables = value
            End Set
        End Property

        Friend Overridable Property flpTableType As System.Windows.Forms.FlowLayoutPanel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._flpTableType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.FlowLayoutPanel)
                Me._flpTableType = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmTableLayout.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmTableLayout.__ENCList
                If RestaurantPOS14.frmTableLayout.__ENCList.Count = RestaurantPOS14.frmTableLayout.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmTableLayout.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmTableLayout.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmTableLayout.__ENCList(num) = RestaurantPOS14.frmTableLayout.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmTableLayout.__ENCList.RemoveRange(num, RestaurantPOS14.frmTableLayout.__ENCList.Count - num)
                    RestaurantPOS14.frmTableLayout.__ENCList.Capacity = RestaurantPOS14.frmTableLayout.__ENCList.Count
                End If

                Call RestaurantPOS14.frmTableLayout.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub button1_Click(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTableNo.Text = ""
                Dim array As String() = Microsoft.VisualBasic.Strings.Split(CType(sender, CButtonLib.CButton).Text.Trim(), Global.Microsoft.VisualBasic.Constants.vbCrLf)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTableNo.Text = array(0)
                RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbGroup.Enabled = True
                Call RestaurantPOS14.My.MyProject.Forms.frmPOS.FillGroup()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT IsNULL(NoOfPerson,0) from RestaurantPOS_OrderInfoKOT where TableNo=@d1 and KOT_Status='Open'")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", array(0))
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNoofPeople.Text = RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNoofPeople.Enabled = False
                Else
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNoofPeople.Text = ""
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNoofPeople.Enabled = True
                End If

                RestaurantPOS14.ModClasses.con.Close()
                MyBase.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Fill()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Top 1 RTRIM(FloorNo) from R_Table Order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Me.str1 = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                End If

                RestaurantPOS14.ModClasses.con.Close()
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(R_Table.TableNo),BkColor,Sum(Case when KOT_Status not in ('Closed','Void') then GrandTotal else NULL end),Max(Case when KOT_Status not in ('Closed','Void') then DateDiff(Minute,(BillDate),GetDate()) else NULL end),Lx,Ly,FontSize,Px,Py,RTRIM(Shape) from R_Table left Join RestaurantPOS_OrderInfoKOT on R_Table.TableNo=RestaurantPOS_OrderInfoKOT.TableNo left join TableLayout on R_Table.TableNo=TableLayout.TableNo where Status='Activate' and FloorNo=@d1 group By R_Table.TableNo,BkColor,Lx,Ly,FontSize,Px,Py,Shape ")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.str1)
                Me.pnlTables.Controls.Clear()
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim cbutton As CButtonLib.CButton = New CButtonLib.CButton()
                    Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(1))))))
                    If Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(1))) = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble("-65536") Then
                        cbutton.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(RestaurantPOS14.ModClasses.rdr.GetValue(0), System.Environment.NewLine), RestaurantPOS14.ModClasses.rdr.GetValue(2)), System.Environment.NewLine), RestaurantPOS14.ModClasses.rdr.GetValue(3)), " "), "Minutes"))
                    Else
                        cbutton.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    cbutton.ColorFillBlend = New CButtonLib.cBlendItems With {.iColor = New System.Drawing.Color(2) {color, color, color}, .iPoint = New Single(2) {0F, 0.5F, 1F}}
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 0, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.Ellipse
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 1, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.Rectangle
                        cbutton.Corners.All = 5
                        cbutton.Corners.LowerLeft = 5
                        cbutton.Corners.LowerRight = 5
                        cbutton.Corners.UpperLeft = 5
                        cbutton.Corners.UpperRight = 5
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 2, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleUp
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 3, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleDown
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 4, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleLeft
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 5, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleRight
                    End If

                    cbutton.Shape = CType(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Me.Cshape), CButtonLib.CButton.eShape)
                    cbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim size As System.Drawing.Size = New System.Drawing.Size(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(7)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(8)))
                    cbutton.Size = size
                    Dim location As System.Drawing.Point = New System.Drawing.Point(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(4)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(5)))
                    cbutton.Location = location
                    cbutton.Font = New System.Drawing.Font("Segoe UI Semibold", Microsoft.VisualBasic.CompilerServices.Conversions.ToSingle(RestaurantPOS14.ModClasses.rdr.GetValue(6)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
                    Me.pnlTables.Controls.Add(cbutton)
                    Me.pnlTables.Refresh()
                    AddHandler cbutton.Click, AddressOf Me.button1_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch __unusedException1__ As System.Exception
                Call System.Windows.Forms.MessageBox.Show("All Tables must be added to Table Layout", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub FillFloorNo()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT Distinct RTRIM(FloorNo) from R_Table order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.flpTableType.Controls.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim cbutton As CButtonLib.CButton = New CButtonLib.CButton()
                    cbutton.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    cbutton.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
                    cbutton.ForeColor = System.Drawing.Color.White
                    cbutton.Corners.All = 5
                    cbutton.Shape = CButtonLib.CButton.eShape.Rectangle
                    cbutton.Width = 130
                    cbutton.Height = 37
                    cbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
                    Me.flpTableType.Controls.Add(cbutton)
                    AddHandler cbutton.Click, AddressOf Me.Button_Click
                End While

                Me.Fill()
            Catch __unusedException1__ As System.Exception
                Call System.Windows.Forms.MessageBox.Show("All Tables must be added to Table Layout", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button_Click(sender As Object, e As System.EventArgs)
            Try
                Dim text As String = CType(sender, CButtonLib.CButton).Text
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(R_Table.TableNo),BkColor,Sum(Case when KOT_Status not in ('Closed','Void') then GrandTotal else NULL end),Max(Case when KOT_Status not in ('Closed','Void') then DateDiff(Minute,(BillDate),GetDate()) else NULL end),Lx,Ly,FontSize,Px,Py,RTRIM(Shape) from R_Table left Join RestaurantPOS_OrderInfoKOT on R_Table.TableNo=RestaurantPOS_OrderInfoKOT.TableNo left join TableLayout on R_Table.TableNo=TableLayout.TableNo where Status='Activate' and FloorNo=@d1 group By R_Table.TableNo,BkColor,Lx,Ly,FontSize,Px,Py,Shape ")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", text)
                Me.pnlTables.Controls.Clear()
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim cbutton As CButtonLib.CButton = New CButtonLib.CButton()
                    Dim color As System.Drawing.Color = System.Drawing.Color.FromArgb(CInt(System.Math.Round(Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(1))))))
                    If Microsoft.VisualBasic.Conversion.Val(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr.GetValue(1))) = Microsoft.VisualBasic.CompilerServices.Conversions.ToDouble("-65536") Then
                        cbutton.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(RestaurantPOS14.ModClasses.rdr.GetValue(0), System.Environment.NewLine), RestaurantPOS14.ModClasses.rdr.GetValue(2)), System.Environment.NewLine), RestaurantPOS14.ModClasses.rdr.GetValue(3)), " "), "Minutes"))
                    Else
                        cbutton.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    End If

                    cbutton.ColorFillBlend = New CButtonLib.cBlendItems With {.iColor = New System.Drawing.Color(2) {color, color, color}, .iPoint = New Single(2) {0F, 0.5F, 1F}}
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 0, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.Ellipse
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 1, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.Rectangle
                        cbutton.Corners.All = 5
                        cbutton.Corners.LowerLeft = 5
                        cbutton.Corners.LowerRight = 5
                        cbutton.Corners.UpperLeft = 5
                        cbutton.Corners.UpperRight = 5
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 2, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleUp
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 3, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleDown
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 4, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleLeft
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(9), 5, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleRight
                    End If

                    cbutton.Shape = CType(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Me.Cshape), CButtonLib.CButton.eShape)
                    cbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    Dim size As System.Drawing.Size = New System.Drawing.Size(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(7)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(8)))
                    cbutton.Size = size
                    Dim location As System.Drawing.Point = New System.Drawing.Point(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(4)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(5)))
                    cbutton.Location = location
                    cbutton.Font = New System.Drawing.Font("Segoe UI Semibold", Microsoft.VisualBasic.CompilerServices.Conversions.ToSingle(RestaurantPOS14.ModClasses.rdr.GetValue(6)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
                    Me.pnlTables.Controls.Add(cbutton)
                    Me.pnlTables.Refresh()
                    AddHandler cbutton.Click, AddressOf Me.button1_Click
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch __unusedException1__ As System.Exception
                Call System.Windows.Forms.MessageBox.Show("All Tables must be added to Table Layout", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmTableLayout))
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlTables = New System.Windows.Forms.Panel()
            Me.flpTableType = New System.Windows.Forms.FlowLayoutPanel()
            MyBase.SuspendLayout()
            Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label5
            Dim location As System.Drawing.Point = New System.Drawing.Point(1, 1)
            label.Location = location
            Me.Label5.Name = "Label5"
            Dim label2 As System.Windows.Forms.Label = Me.Label5
            Dim size As System.Drawing.Size = New System.Drawing.Size(631, 50)
            label2.Size = size
            Me.Label5.TabIndex = 390
            Me.Label5.Text = "Tables Layout"
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
            Me.pnlTables.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.pnlTables.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Dim panel As System.Windows.Forms.Panel = Me.pnlTables
            location = New System.Drawing.Point(1, 103)
            panel.Location = location
            Me.pnlTables.Name = "pnlTables"
            Dim panel2 As System.Windows.Forms.Panel = Me.pnlTables
            size = New System.Drawing.Size(689, 327)
            panel2.Size = size
            Me.pnlTables.TabIndex = 393
            Me.flpTableType.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.flpTableType.BackColor = System.Drawing.Color.Transparent
            Me.flpTableType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Dim flowLayoutPanel As System.Windows.Forms.FlowLayoutPanel = Me.flpTableType
            location = New System.Drawing.Point(1, 54)
            flowLayoutPanel.Location = location
            Me.flpTableType.Name = "flpTableType"
            Dim flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel = Me.flpTableType
            size = New System.Drawing.Size(688, 43)
            flowLayoutPanel2.Size = size
            Me.flpTableType.TabIndex = 395
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(694, 433)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.flpTableType)
            MyBase.Controls.Add(Me.pnlTables)
            MyBase.Controls.Add(Me.btnClose)
            MyBase.Controls.Add(Me.Label5)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.KeyPreview = True
            MyBase.Name = "frmTableLayout"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Tables"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
