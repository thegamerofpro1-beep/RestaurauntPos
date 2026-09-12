Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmDeliveryPersonRecord
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel5")>
        Private _Panel5 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmployeeName")>
        Private _txtEmployeeName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column4")>
        Private _Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column5")>
        Private _Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column6")>
        Private _Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column7")>
        Private _Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column8")>
        Private _Column8 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAdd")>
        Private _btnAdd As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

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

        Friend Overridable Property Panel3 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel3 = value
            End Set
        End Property

        Friend Overridable Property dgw As System.Windows.Forms.DataGridView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dgw
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridView)
                Dim value2 As System.Windows.Forms.MouseEventHandler = AddressOf Me.dgw_MouseClick
                Dim value3 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.dgw_RowPostPaint
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.MouseClick, value2
                    RemoveHandler Me._dgw.RowPostPaint, value3
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.MouseClick, value2
                    AddHandler Me._dgw.RowPostPaint, value3
                End If
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

        Friend Overridable Property Panel5 As System.Windows.Forms.Panel
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Panel5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Panel)
                Me._Panel5 = value
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

        Friend Overridable Property txtEmployeeName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmployeeName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtEmployeeName_TextChanged
                If Me._txtEmployeeName IsNot Nothing Then
                    RemoveHandler Me._txtEmployeeName.TextChanged, value2
                End If

                Me._txtEmployeeName = value
                If Me._txtEmployeeName IsNot Nothing Then
                    AddHandler Me._txtEmployeeName.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column1 = value
            End Set
        End Property

        Friend Overridable Property Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column2 = value
            End Set
        End Property

        Friend Overridable Property Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column3 = value
            End Set
        End Property

        Friend Overridable Property Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column4 = value
            End Set
        End Property

        Friend Overridable Property Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column5 = value
            End Set
        End Property

        Friend Overridable Property Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column6 = value
            End Set
        End Property

        Friend Overridable Property Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column7 = value
            End Set
        End Property

        Friend Overridable Property Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column8 = value
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

        Friend Overridable Property btnExportExcel As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnExportExcel
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnExportExcel_Click
                If Me._btnExportExcel IsNot Nothing Then
                    RemoveHandler Me._btnExportExcel.Click, value2
                End If

                Me._btnExportExcel = value
                If Me._btnExportExcel IsNot Nothing Then
                    AddHandler Me._btnExportExcel.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnAdd As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAdd
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAdd_Click
                If Me._btnAdd IsNot Nothing Then
                    RemoveHandler Me._btnAdd.Click, value2
                End If

                Me._btnAdd = value
                If Me._btnAdd IsNot Nothing Then
                    AddHandler Me._btnAdd.Click, value2
                End If
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmDeliveryPersonRecord.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmDeliveryPersonRecord.__ENCList
                If RestaurantPOS14.frmDeliveryPersonRecord.__ENCList.Count = RestaurantPOS14.frmDeliveryPersonRecord.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmDeliveryPersonRecord.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmDeliveryPersonRecord.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmDeliveryPersonRecord.__ENCList(num) = RestaurantPOS14.frmDeliveryPersonRecord.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmDeliveryPersonRecord.__ENCList.RemoveRange(num, RestaurantPOS14.frmDeliveryPersonRecord.__ENCList.Count - num)
                    RestaurantPOS14.frmDeliveryPersonRecord.__ENCList.Capacity = RestaurantPOS14.frmDeliveryPersonRecord.__ENCList.Count
                End If

                Call RestaurantPOS14.frmDeliveryPersonRecord.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select EmpID,RTRIM(EmployeeID),RTRIM(EmployeeName),RTRIM(Address),RTRIM(City),RTRIM(ContactNo),RTRIM(Email),DateofJoining from EmployeeRegistration where Active='Yes' order by EmployeeName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtEmployeeName.Text = ""
            Me.GetData()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnClose_Click_1(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDeliveryPersonID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDeliveryPerson.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                    MyBase.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub dgw_RowPostPaint(sender As Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
            Dim text As String =(e.RowIndex + 1).ToString()
            Dim sizeF As System.Drawing.SizeF = e.Graphics.MeasureString(text, MyBase.Font)
            If Me.dgw.RowHeadersWidth < System.Convert.ToInt32(sizeF.Width + 20F) Then
                Me.dgw.RowHeadersWidth = System.Convert.ToInt32(sizeF.Width + 20F)
            End If

            Dim controlText As System.Drawing.Brush = System.Drawing.SystemBrushes.ControlText
            e.Graphics.DrawString(text, MyBase.Font, controlText, e.RowBounds.Location.X + 15, CSng(e.RowBounds.Location.Y) + (CSng(e.RowBounds.Height) - sizeF.Height) / 2F)
        End Sub

        Private Sub txtEmployeeName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select EmpID,RTRIM(EmployeeID),RTRIM(EmployeeName),RTRIM(Address),RTRIM(City),RTRIM(ContactNo),RTRIM(Email),DateofJoining from EmployeeRegistration where Employeename like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtEmployeeName.Text) & "%' and Active='Yes' order by EmployeeName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.ExportExcel(Me.dgw)
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmEmployeeRegistration.lblUser.Text = Me.lblUser.Text
            RestaurantPOS14.My.MyProject.Forms.frmEmployeeRegistration.lblSet.Text = "POS"
            Call RestaurantPOS14.My.MyProject.Forms.frmEmployeeRegistration.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmEmployeeRegistration.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmDeliveryPersonRecord))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnAdd = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.txtEmployeeName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.btnAdd)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.Panel5)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.dgw)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(5, 5)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(891, 582)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.lblUser.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(774, 98)
            label.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label2 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label2.Size = size
            Me.lblUser.TabIndex = 315
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnAdd.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnAdd
            location = New System.Drawing.Point(625, 62)
            button.Location = location
            Me.btnAdd.Name = "btnAdd"
            Dim button2 As System.Windows.Forms.Button = Me.btnAdd
            size = New System.Drawing.Size(92, 52)
            button2.Size = size
            Me.btnAdd.TabIndex = 314
            Me.btnAdd.Text = "Add New" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Delivery Person"
            Me.btnAdd.UseVisualStyleBackColor = False
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(3, 3)
            label3.Location = location
            Me.Label1.Name = "Label1"
            Dim label4 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(880, 34)
            label4.Size = size
            Me.Label1.TabIndex = 112
            Me.Label1.Text = "List of Delivery Persons"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel5.Controls.Add(Me.btnExportExcel)
            Me.Panel5.Controls.Add(Me.btnClose)
            Me.Panel5.Controls.Add(Me.btnReset)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel5
            location = New System.Drawing.Point(288, 44)
            panel3.Location = location
            Me.Panel5.Name = "Panel5"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel5
            size = New System.Drawing.Size(319, 83)
            panel4.Size = size
            Me.Panel5.TabIndex = 42
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(177, 17)
            button3.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button4 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(129, 49)
            button4.Size = size
            Me.btnExportExcel.TabIndex = 6
            Me.btnExportExcel.Text = "Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(96, 17)
            button5.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button6 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(75, 49)
            button6.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(8, 17)
            button7.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button8 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(82, 49)
            button8.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.txtEmployeeName)
            Me.Panel3.Controls.Add(Me.Label3)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(5, 44)
            panel5.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(277, 83)
            panel6.Size = size
            Me.Panel3.TabIndex = 1
            Me.txtEmployeeName.BackColor = System.Drawing.Color.White
            Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtEmployeeName
            location = New System.Drawing.Point(14, 37)
            textBox.Location = location
            Me.txtEmployeeName.Name = "txtEmployeeName"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtEmployeeName
            size = New System.Drawing.Size(248, 29)
            textBox2.Size = size
            Me.txtEmployeeName.TabIndex = 13
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label3.ForeColor = System.Drawing.Color.White
            Dim label5 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(10, 10)
            label5.Location = location
            Me.Label3.Name = "Label3"
            Dim label6 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(210, 20)
            label6.Size = size
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Search By Employee Name :"
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
            Me.dgw.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 24
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(5, 133)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(878, 441)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 40
            Me.Column1.HeaderText = "Emp ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.Column2.FillWeight = 82.25616F
            Me.Column2.HeaderText = "Employee ID"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column3.FillWeight = 127.602F
            Me.Column3.HeaderText = "Employee Name"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column4.FillWeight = 123.827F
            Me.Column4.HeaderText = "Address"
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            Me.Column5.FillWeight = 120.7174F
            Me.Column5.HeaderText = "City"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column6.FillWeight = 78.77056F
            Me.Column6.HeaderText = "Contact No."
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column7.FillWeight = 81.99199F
            Me.Column7.HeaderText = "Email"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            dataGridViewCellStyle6.Format = "dd/MM/yyyy"
            Me.Column8.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column8.FillWeight = 84.8349F
            Me.Column8.HeaderText = "Joining Date"
            Me.Column8.Name = "Column8"
            Me.Column8.[ReadOnly] = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(898, 591)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmDeliveryPersonRecord"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel5.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
            Me.Panel3.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
