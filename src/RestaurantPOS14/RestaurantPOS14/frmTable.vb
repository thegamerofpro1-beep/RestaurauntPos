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
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmTable
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTableNo")>
        Private _txtTableNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnNew")>
        Private _btnNew As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtTable")>
        Private _txtTable As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtStatus")>
        Private _txtStatus As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnActivate_Deactivate")>
        Private _btnActivate_Deactivate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbFloorNo")>
        Private _cmbFloorNo As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbShape")>
        Private _cmbShape As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Description")>
        Private _Description As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        Friend Overridable Property txtTableNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTableNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTableNo = value
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
                Dim value2 As System.Windows.Forms.DataGridViewRowPostPaintEventHandler = AddressOf Me.dgw_RowPostPaint
                Dim value3 As System.Windows.Forms.MouseEventHandler = AddressOf Me.dgw_MouseClick
                If Me._dgw IsNot Nothing Then
                    RemoveHandler Me._dgw.RowPostPaint, value2
                    RemoveHandler Me._dgw.MouseClick, value3
                End If

                Me._dgw = value
                If Me._dgw IsNot Nothing Then
                    AddHandler Me._dgw.RowPostPaint, value2
                    AddHandler Me._dgw.MouseClick, value3
                End If
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

        Friend Overridable Property btnDelete As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDelete
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnDelete_Click
                If Me._btnDelete IsNot Nothing Then
                    RemoveHandler Me._btnDelete.Click, value2
                End If

                Me._btnDelete = value
                If Me._btnDelete IsNot Nothing Then
                    AddHandler Me._btnDelete.Click, value2
                End If
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

        Friend Overridable Property btnUpdate As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnUpdate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnUpdate_Click
                If Me._btnUpdate IsNot Nothing Then
                    RemoveHandler Me._btnUpdate.Click, value2
                End If

                Me._btnUpdate = value
                If Me._btnUpdate IsNot Nothing Then
                    AddHandler Me._btnUpdate.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnSave As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSave
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnSave_Click
                If Me._btnSave IsNot Nothing Then
                    RemoveHandler Me._btnSave.Click, value2
                End If

                Me._btnSave = value
                If Me._btnSave IsNot Nothing Then
                    AddHandler Me._btnSave.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnNew As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnNew
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnNew_Click
                If Me._btnNew IsNot Nothing Then
                    RemoveHandler Me._btnNew.Click, value2
                End If

                Me._btnNew = value
                If Me._btnNew IsNot Nothing Then
                    AddHandler Me._btnNew.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtTable As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtTable
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtTable = value
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

        Friend Overridable Property txtStatus As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtStatus
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtStatus = value
            End Set
        End Property

        Friend Overridable Property btnActivate_Deactivate As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnActivate_Deactivate
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnDeactivate_Click
                If Me._btnActivate_Deactivate IsNot Nothing Then
                    RemoveHandler Me._btnActivate_Deactivate.Click, value2
                End If

                Me._btnActivate_Deactivate = value
                If Me._btnActivate_Deactivate IsNot Nothing Then
                    AddHandler Me._btnActivate_Deactivate.Click, value2
                End If
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

        Friend Overridable Property cmbFloorNo As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbFloorNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbFloorNo = value
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

        Friend Overridable Property cmbShape As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbShape
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbShape = value
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

        Friend Overridable Property Description As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Description
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Description = value
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmTable.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmTable.__ENCList
                If RestaurantPOS14.frmTable.__ENCList.Count = RestaurantPOS14.frmTable.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmTable.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmTable.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmTable.__ENCList(num) = RestaurantPOS14.frmTable.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmTable.__ENCList.RemoveRange(num, RestaurantPOS14.frmTable.__ENCList.Count - num)
                    RestaurantPOS14.frmTable.__ENCList.Capacity = RestaurantPOS14.frmTable.__ENCList.Count
                End If

                Call RestaurantPOS14.frmTable.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Public Sub fillCombo()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(FloorNo) FROM R_Table where FloorNo is not NULL and FloorNo <> '' order by 1", sqlConnection)
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet("ds")
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.ds)
                Dim dataTable As System.Data.DataTable = RestaurantPOS14.ModClasses.ds.Tables(0)
                Me.cmbFloorNo.Items.Clear()
                For Each dataRow As System.Data.DataRow In dataTable.Rows
                    Me.cmbFloorNo.Items.Add(dataRow(CInt((0))).ToString())
                Next

                sqlConnection.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtTableNo.Text = ""
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Tables") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Tables") Then
                Me.GetData()
            Else
                Me.dgw.Rows.Clear()
            End If

            Me.btnDelete.Enabled = False
            Me.btnUpdate.Enabled = False
            Me.btnActivate_Deactivate.Enabled = False
            Me.btnActivate_Deactivate.Text = "Activate/Deactivate"
            Me.cmbFloorNo.Text = ""
            Me.cmbShape.SelectedIndex = 1
            Me.txtTableNo.Focus()
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTableNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter table no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtTableNo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbFloorNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter/select floor no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbFloorNo.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select TableNo from R_Table where TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Table No. Already Exists", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Me.txtTableNo.Text = ""
                    Me.txtTableNo.Focus()
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into R_Table(TableNo,Status,bkColor,FloorNo,ShapeX) VALUES (@d1,'Activate',@d2,@d3,@d4)")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", System.Drawing.Color.LightGreen.ToArgb())
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbFloorNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.cmbShape.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new table '" & Me.txtTableNo.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully Saved", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTableNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter table no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtTableNo.Focus()
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbFloorNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter/select floor no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbFloorNo.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update RestaurantPOS_OrderedProductKOT set T_Number=@d3 where T_Number=@d2")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtTable.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtTableNo.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update R_Table set TableNo=@d1,BkColor=@d3,FloorNo=@d5,ShapeX=@d4 where TableNo=@d2")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtTable.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", System.Drawing.Color.LightGreen.ToArgb())
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.cmbFloorNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.cmbShape.Text)
                RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "updated the table '" & Me.txtTableNo.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select R_Table.TableNo from TableReservation,R_Table where TableReservation.TableNo=R_Table.TableNo and R_Table.TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Table Reservation", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select R_Table.TableNo from RestaurantPOS_OrderedProductBillKOT,R_Table where RestaurantPOS_OrderedProductBillKOT.TableNo=R_Table.TableNo and R_Table.TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select R_Table.TableNo from RestaurantPOS_OrderInfoKOT,R_Table where RestaurantPOS_OrderInfoKOT.TableNo=R_Table.TableNo and R_Table.TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select R_Table.TableNo from RestaurantPOS_OrderInfoKOT,R_Table where RestaurantPOS_OrderInfoKOT.TableNo=R_Table.TableNo and R_Table.TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from R_Table where TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTable.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "deleted the table '" & Me.txtTableNo.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                Else
                    Call System.Windows.Forms.MessageBox.Show("No Record found", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                End If

                If RestaurantPOS14.ModClasses.con.State = System.Data.ConnectionState.Open Then
                    RestaurantPOS14.ModClasses.con.Close()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As System.EventArgs)
            Try
                If System.Windows.Forms.MessageBox.Show("Do you really want to delete this record?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
                    Me.DeleteRecord()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count <= 0 Then
                    Return
                End If

                If Me.dgw.SelectedRows.Count = 0 Then Return
                Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                Me.txtTable.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                Me.txtTableNo.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                Me.cmbFloorNo.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                Me.cmbShape.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                Me.txtStatus.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((3))).Value, "Activate", TextCompare:=False) Then
                    Me.btnActivate_Deactivate.Text = "Deactivate"
                    If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Tables") Then
                        Me.btnActivate_Deactivate.Enabled = True
                    Else
                        Me.btnActivate_Deactivate.Enabled = False
                    End If
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells(CInt((3))).Value, "Deactivate", TextCompare:=False) Then
                    Me.btnActivate_Deactivate.Text = "Activate"
                    If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Tables") Then
                        Me.btnActivate_Deactivate.Enabled = True
                    Else
                        Me.btnActivate_Deactivate.Enabled = False
                    End If
                End If

                If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Tables") Then
                    Me.btnDelete.Enabled = True
                Else
                    Me.btnDelete.Enabled = False
                End If

                If RestaurantPOS14.ModFunc.IsUpdateAllowed(Me.lblUser.Text, "Tables") Then
                    Me.btnUpdate.Enabled = True
                Else
                    Me.btnUpdate.Enabled = False
                End If

                Me.btnSave.Enabled = False
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

        Public Sub GetData()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT RTRIM(TableNo),RTRIM(FloorNo),RTRIM(ShapeX),RTRIM(Status) from R_Table ORDER BY LEFT(R_Table.TableNo, PATINDEX('%[0-9]%', R_Table.TableNo)-1),CONVERT(INT, SUBSTRING(R_Table.TableNo, PATINDEX('%[0-9]%', R_Table.TableNo), LEN(R_Table.TableNo)))", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
                Me.fillCombo()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnDeactivate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtTableNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter table no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtTableNo.Focus()
                Return
            End If

            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select R_Table.TableNo from RestaurantPOS_OrderInfoKOT,R_Table where RestaurantPOS_OrderInfoKOT.TableNo=R_Table.TableNo and R_Table.TableNo=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to deactivate..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.btnActivate_Deactivate.Text, "Activate", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update R_Table set TableNo=@d1,Status='Activate' where TableNo=@d2")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtTable.Text)
                    RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    RestaurantPOS14.ModClasses.con.Close()
                    Dim st As String = "activated the table '" & Me.txtTableNo.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    Call System.Windows.Forms.MessageBox.Show("Successfully activated", "Table", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.btnActivate_Deactivate.Enabled = False
                    Me.Reset()
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.btnActivate_Deactivate.Text, "Deactivate", TextCompare:=False) = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update R_Table set TableNo=@d1,Status='Deactivate' where TableNo=@d2")
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtTableNo.Text)
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtTable.Text)
                    RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    RestaurantPOS14.ModClasses.con.Close()
                    Dim st2 As String = "deactivated the table '" & Me.txtTableNo.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st2)
                    Call System.Windows.Forms.MessageBox.Show("Successfully deactivated", "Table", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.btnActivate_Deactivate.Enabled = False
                    Me.Reset()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmTable))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.cmbFloorNo = New System.Windows.Forms.ComboBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtTableNo = New System.Windows.Forms.TextBox()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnNew = New System.Windows.Forms.Button()
            Me.btnActivate_Deactivate = New System.Windows.Forms.Button()
            Me.txtStatus = New System.Windows.Forms.TextBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtTable = New System.Windows.Forms.TextBox()
            Me.cmbShape = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.Panel3.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.cmbShape)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.cmbFloorNo)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.txtTableNo)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.btnActivate_Deactivate)
            Me.Panel1.Controls.Add(Me.txtStatus)
            Me.Panel1.Controls.Add(Me.lblUser)
            Me.Panel1.Controls.Add(Me.dgw)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(4, 4)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(631, 580)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(1, 512)
            label.Location = location
            Me.Label4.Name = "Label4"
            Dim label2 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(69, 16)
            label2.Size = size
            Me.Label4.TabIndex = 49
            Me.Label4.Text = "Floor No. :"
            Me.cmbFloorNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbFloorNo.FormattingEnabled = True
            Me.cmbFloorNo.Items.AddRange(New Object(1) {"AC", "Non-AC"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbFloorNo
            location = New System.Drawing.Point(96, 512)
            comboBox.Location = location
            Me.cmbFloorNo.Name = "cmbFloorNo"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbFloorNo
            size = New System.Drawing.Size(121, 24)
            comboBox2.Size = size
            Me.cmbFloorNo.TabIndex = 1
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label3 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(1, 484)
            label3.Location = location
            Me.Label2.Name = "Label2"
            Dim label4 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(74, 16)
            label4.Size = size
            Me.Label2.TabIndex = 46
            Me.Label2.Text = "Table No. :"
            Me.txtTableNo.BackColor = System.Drawing.Color.White
            Me.txtTableNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTableNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtTableNo
            location = New System.Drawing.Point(96, 484)
            textBox.Location = location
            Me.txtTableNo.Name = "txtTableNo"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtTableNo
            size = New System.Drawing.Size(121, 22)
            textBox2.Size = size
            Me.txtTableNo.TabIndex = 0
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.btnDelete)
            Me.Panel3.Controls.Add(Me.btnClose)
            Me.Panel3.Controls.Add(Me.btnSave)
            Me.Panel3.Controls.Add(Me.btnUpdate)
            Me.Panel3.Controls.Add(Me.btnNew)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(521, 37)
            panel3.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(103, 219)
            panel4.Size = size
            Me.Panel3.TabIndex = 41
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(9, 130)
            button.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button2 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(84, 36)
            button2.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(9, 169)
            button3.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button4 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(84, 36)
            button4.Size = size
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(9, 50)
            button5.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button6 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(84, 36)
            button6.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Enabled = False
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(9, 90)
            button7.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button8 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(84, 36)
            button8.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnNew.Image = CType(componentResourceManager.GetObject("btnNew.Image"), System.Drawing.Image)
            Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.btnNew
            location = New System.Drawing.Point(9, 3)
            button9.Location = location
            Me.btnNew.Name = "btnNew"
            Dim button10 As System.Windows.Forms.Button = Me.btnNew
            size = New System.Drawing.Size(84, 43)
            button10.Size = size
            Me.btnNew.TabIndex = 0
            Me.btnNew.Text = "New"
            Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnNew.UseVisualStyleBackColor = True
            Me.btnActivate_Deactivate.BackColor = System.Drawing.SystemColors.Control
            Me.btnActivate_Deactivate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnActivate_Deactivate.Enabled = False
            Me.btnActivate_Deactivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnActivate_Deactivate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnActivate_Deactivate.Image = RestaurantPOS14.My.Resources.Resources.Activate
            Me.btnActivate_Deactivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnActivate_Deactivate
            location = New System.Drawing.Point(248, 484)
            button11.Location = location
            Me.btnActivate_Deactivate.Name = "btnActivate_Deactivate"
            Dim button12 As System.Windows.Forms.Button = Me.btnActivate_Deactivate
            size = New System.Drawing.Size(149, 43)
            button12.Size = size
            Me.btnActivate_Deactivate.TabIndex = 3
            Me.btnActivate_Deactivate.Text = "Activate/Deactivate"
            Me.btnActivate_Deactivate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnActivate_Deactivate.UseVisualStyleBackColor = False
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtStatus
            location = New System.Drawing.Point(24, 211)
            textBox3.Location = location
            Me.txtStatus.Name = "txtStatus"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtStatus
            size = New System.Drawing.Size(10, 20)
            textBox4.Size = size
            Me.txtStatus.TabIndex = 45
            Me.txtStatus.Visible = False
            Me.lblUser.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(21, 243)
            label5.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label6 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label6.Size = size
            Me.lblUser.TabIndex = 43
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.BackgroundColor = System.Drawing.Color.White
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 24
            Me.dgw.Columns.AddRange(Me.Description, Me.Column3, Me.Column2, Me.Column1)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(4, 37)
            dataGridView.Location = location
            Me.dgw.MultiSelect = False
            Me.dgw.Name = "dgw"
            Me.dgw.[ReadOnly] = True
            Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 18
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(511, 441)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 40
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.txtTable)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 4)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(620, 27)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(240, 0)
            label7.Location = location
            Me.Label1.Name = "Label1"
            Dim label8 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(133, 24)
            label8.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "List of Tables"
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtTable
            location = New System.Drawing.Point(3, 0)
            textBox5.Location = location
            Me.txtTable.Name = "txtTable"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtTable
            size = New System.Drawing.Size(11, 20)
            textBox6.Size = size
            Me.txtTable.TabIndex = 44
            Me.txtTable.Visible = False
            Me.cmbShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbShape.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbShape.FormattingEnabled = True
            Me.cmbShape.Items.AddRange(New Object(5) {"Ellipse", "Rectangle", "Triangle Up", "Triangle Down", "Triangle Left", "Triangle Right"})
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbShape
            location = New System.Drawing.Point(96, 542)
            comboBox3.Location = location
            Me.cmbShape.Name = "cmbShape"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbShape
            size = New System.Drawing.Size(161, 28)
            comboBox4.Size = size
            Me.cmbShape.TabIndex = 2
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label9 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(1, 542)
            label9.Location = location
            Me.Label3.Name = "Label3"
            Dim label10 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(93, 16)
            label10.Size = size
            Me.Label3.TabIndex = 51
            Me.Label3.Text = "Table Shape :"
            Me.Description.HeaderText = "Table No."
            Me.Description.Name = "Description"
            Me.Description.[ReadOnly] = True
            Me.Description.Width = 130
            Me.Column3.HeaderText = "Floor No."
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column3.Width = 150
            Me.Column2.HeaderText = "Table Shape"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column1.HeaderText = "Status"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label5.ForeColor = System.Drawing.Color.Red
            Dim label11 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(384, 530)
            label11.Location = location
            Me.Label5.Name = "Label5"
            Dim label12 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(240, 45)
            label12.Size = size
            Me.Label5.TabIndex = 52
            Me.Label5.Text = "Note : Table No. must be ends with number" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "T1 or 1 is correct" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "1T or T is wrong"
            MyBase.AcceptButton = Me.btnSave
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(640, 588)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmTable"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.Panel3.ResumeLayout(False)
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
