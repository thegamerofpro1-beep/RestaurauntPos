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
    Public Class frmCustomersRecord
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dgw")>
        Private _dgw As System.Windows.Forms.DataGridView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnExportExcel")>
        Private _btnExportExcel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column1")>
        Private _Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column2")>
        Private _Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column3")>
        Private _Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox4")>
        Private _GroupBox4 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddress")>
        Private _txtAddress As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox3")>
        Private _GroupBox3 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCustomerName")>
        Private _txtCustomerName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button3")>
        Private _Button3 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button2")>
        Private _Button2 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button4")>
        Private _Button4 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnAddNew")>
        Private _btnAddNew As System.Windows.Forms.Button

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

        Friend Overridable Property GroupBox2 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox2 = value
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

        Friend Overridable Property GroupBox4 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox4 = value
            End Set
        End Property

        Friend Overridable Property txtAddress As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAddress
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtCustomerName_Leave
                Dim value3 As System.EventHandler = AddressOf Me.txtAddress_Enter
                If Me._txtAddress IsNot Nothing Then
                    RemoveHandler Me._txtAddress.Leave, value2
                    RemoveHandler Me._txtAddress.Enter, value3
                End If

                Me._txtAddress = value
                If Me._txtAddress IsNot Nothing Then
                    AddHandler Me._txtAddress.Leave, value2
                    AddHandler Me._txtAddress.Enter, value3
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox3 As System.Windows.Forms.GroupBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._GroupBox3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.GroupBox)
                Me._GroupBox3 = value
            End Set
        End Property

        Friend Overridable Property txtContactNo As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtContactNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtContactNo_Enter
                Dim value3 As System.EventHandler = AddressOf Me.txtCustomerName_Leave
                If Me._txtContactNo IsNot Nothing Then
                    RemoveHandler Me._txtContactNo.Enter, value2
                    RemoveHandler Me._txtContactNo.Leave, value3
                End If

                Me._txtContactNo = value
                If Me._txtContactNo IsNot Nothing Then
                    AddHandler Me._txtContactNo.Enter, value2
                    AddHandler Me._txtContactNo.Leave, value3
                End If
            End Set
        End Property

        Friend Overridable Property txtCustomerName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCustomerName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtCustomerName_Leave
                Dim value3 As System.EventHandler = AddressOf Me.txtCustomerName_Enter
                If Me._txtCustomerName IsNot Nothing Then
                    RemoveHandler Me._txtCustomerName.Leave, value2
                    RemoveHandler Me._txtCustomerName.Enter, value3
                End If

                Me._txtCustomerName = value
                If Me._txtCustomerName IsNot Nothing Then
                    AddHandler Me._txtCustomerName.Leave, value2
                    AddHandler Me._txtCustomerName.Enter, value3
                End If
            End Set
        End Property

        Friend Overridable Property lblSet As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblSet
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblSet = value
            End Set
        End Property

        Friend Overridable Property Button3 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button3_Click
                If Me._Button3 IsNot Nothing Then
                    RemoveHandler Me._Button3.Click, value2
                End If

                Me._Button3 = value
                If Me._Button3 IsNot Nothing Then
                    AddHandler Me._Button3.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Button2 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button2_Click
                If Me._Button2 IsNot Nothing Then
                    RemoveHandler Me._Button2.Click, value2
                End If

                Me._Button2 = value
                If Me._Button2 IsNot Nothing Then
                    AddHandler Me._Button2.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Button1 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, value2
                End If

                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Button4 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button4_Click
                If Me._Button4 IsNot Nothing Then
                    RemoveHandler Me._Button4.Click, value2
                End If

                Me._Button4 = value
                If Me._Button4 IsNot Nothing Then
                    AddHandler Me._Button4.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnAddNew As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnAddNew
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnAddNew_Click
                If Me._btnAddNew IsNot Nothing Then
                    RemoveHandler Me._btnAddNew.Click, value2
                End If

                Me._btnAddNew = value
                If Me._btnAddNew IsNot Nothing Then
                    AddHandler Me._btnAddNew.Click, value2
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
            AddHandler MyBase.Load, AddressOf Me.frmCustomersRecord_Load
            Call RestaurantPOS14.frmCustomersRecord.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmCustomersRecord.__ENCList
                If RestaurantPOS14.frmCustomersRecord.__ENCList.Count = RestaurantPOS14.frmCustomersRecord.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmCustomersRecord.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmCustomersRecord.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmCustomersRecord.__ENCList(num) = RestaurantPOS14.frmCustomersRecord.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmCustomersRecord.__ENCList.RemoveRange(num, RestaurantPOS14.frmCustomersRecord.__ENCList.Count - num)
                    RestaurantPOS14.frmCustomersRecord.__ENCList.Capacity = RestaurantPOS14.frmCustomersRecord.__ENCList.Count
                End If

                Call RestaurantPOS14.frmCustomersRecord.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub GetData()
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from RestaurantPOS_BillingInfoHD UNION Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from HDCustomer order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtCustomerName.Text = ""
            Me.txtContactNo.Text = ""
            Me.txtAddress.Text = ""
            Me.dgw.Rows.Clear()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnExportExcel_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.ModFunc.ExportExcel(Me.dgw)
        End Sub

        Private Sub dgw_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Try
                If Me.dgw.Rows.Count > 0 Then
                    If Me.dgw.SelectedRows.Count = 0 Then Return
                    Dim dataGridViewRow As System.Windows.Forms.DataGridViewRow = Me.dgw.SelectedRows(0)
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "HD", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtCustomerName.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtAddress.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtContactNo.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                        MyBase.Close()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TA", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTACustomerName.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTAContactNo.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                        MyBase.Close()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "EB", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBCustomerName.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtEBContactNo.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                        MyBase.Close()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "DIB", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDICustomerName.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.txtDIContactNo.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                        MyBase.Close()
                    End If

                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "TR", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmTableReservation.txtCustomerName.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                        RestaurantPOS14.My.MyProject.Forms.frmTableReservation.txtContactNo.Text = dataGridViewRow.Cells(CInt((2))).Value.ToString()
                        MyBase.Close()
                    End If
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

        Private Sub frmCustomersRecord_Load(sender As Object, e As System.EventArgs)
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from RestaurantPOS_BillingInfoHD where CustomerName like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtCustomerName.Text) & "%' UNION Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from HDCustomer where CustomerName like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtCustomerName.Text) & "%' order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from RestaurantPOS_BillingInfoHD where ContactNo like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtContactNo.Text) & "%' UNION Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from HDCustomer where ContactNo like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtContactNo.Text) & "%' order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button3_Click(sender As Object, e As System.EventArgs)
            Try
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from RestaurantPOS_BillingInfoHD where Address like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtAddress.Text) & "%' UNION Select distinct RTRIM(Customername),RTRIM(Address),RTRIM(ContactNo) from HDCustomer where Address like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtAddress.Text) & "%'  order by 1", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button4_Click(sender As Object, e As System.EventArgs)
            Me.GetData()
        End Sub

        Private Sub txtCustomerName_Leave(sender As Object, e As System.EventArgs)
            Call RestaurantPOS14.My.MyProject.Forms.frmOnscreenKeyboard.Close()
        End Sub

        Private Sub txtCustomerName_Enter(sender As Object, e As System.EventArgs)
            If RestaurantPOS14.My.MyProject.Forms.frmPOS.chkOSK.Checked Then
                RestaurantPOS14.My.MyProject.Forms.frmOnscreenKeyboard.lblSet.Text = "CRC"
                Call RestaurantPOS14.My.MyProject.Forms.frmOnscreenKeyboard.ShowDialog()
                Me.Button1.Focus()
            End If
        End Sub

        Private Sub txtContactNo_Enter(sender As Object, e As System.EventArgs)
            If RestaurantPOS14.My.MyProject.Forms.frmPOS.chkOSK.Checked Then
                RestaurantPOS14.My.MyProject.Forms.frmOnscreenKeyboard.lblSet.Text = "CRCN"
                Call RestaurantPOS14.My.MyProject.Forms.frmOnscreenKeyboard.ShowDialog()
                Me.Button2.Focus()
            End If
        End Sub

        Private Sub txtAddress_Enter(sender As Object, e As System.EventArgs)
            If RestaurantPOS14.My.MyProject.Forms.frmPOS.chkOSK.Checked Then
                RestaurantPOS14.My.MyProject.Forms.frmOnscreenKeyboard.lblSet.Text = "CRA"
                Call RestaurantPOS14.My.MyProject.Forms.frmOnscreenKeyboard.ShowDialog()
                Me.Button3.Focus()
            End If
        End Sub

        Private Sub btnAddNew_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmCustomer.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmCustomer.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmCustomer.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmCustomersRecord))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnAddNew = New System.Windows.Forms.Button()
            Me.Button4 = New System.Windows.Forms.Button()
            Me.GroupBox4 = New System.Windows.Forms.GroupBox()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.txtAddress = New System.Windows.Forms.TextBox()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.txtCustomerName = New System.Windows.Forms.TextBox()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.btnAddNew)
            Me.Panel1.Controls.Add(Me.Button4)
            Me.Panel1.Controls.Add(Me.GroupBox4)
            Me.Panel1.Controls.Add(Me.GroupBox3)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Label5)
            Me.Panel1.Controls.Add(Me.dgw)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(4, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(1021, 580)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnAddNew.ForeColor = System.Drawing.Color.Black
            Me.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnAddNew
            location = New System.Drawing.Point(763, 4)
            button.Location = location
            Me.btnAddNew.Name = "btnAddNew"
            Dim button2 As System.Windows.Forms.Button = Me.btnAddNew
            size = New System.Drawing.Size(107, 36)
            button2.Size = size
            Me.btnAddNew.TabIndex = 115
            Me.btnAddNew.Text = "Add New"
            Me.btnAddNew.UseVisualStyleBackColor = True
            Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button4.ForeColor = System.Drawing.Color.Black
            Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.Button4
            location = New System.Drawing.Point(876, 4)
            button3.Location = location
            Me.Button4.Name = "Button4"
            Dim button4 As System.Windows.Forms.Button = Me.Button4
            size = New System.Drawing.Size(128, 36)
            button4.Size = size
            Me.Button4.TabIndex = 114
            Me.Button4.Text = "Show All Data"
            Me.Button4.UseVisualStyleBackColor = True
            Me.GroupBox4.Controls.Add(Me.Button3)
            Me.GroupBox4.Controls.Add(Me.txtAddress)
            Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox4.ForeColor = System.Drawing.Color.White
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox4
            location = New System.Drawing.Point(506, 41)
            groupBox.Location = location
            Me.GroupBox4.Name = "GroupBox4"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox4
            size = New System.Drawing.Size(236, 83)
            groupBox2.Size = size
            Me.GroupBox4.TabIndex = 113
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "Search By Address"
            Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button3.ForeColor = System.Drawing.Color.Black
            Dim button5 As System.Windows.Forms.Button = Me.Button3
            location = New System.Drawing.Point(163, 34)
            button5.Location = location
            Me.Button3.Name = "Button3"
            Dim button6 As System.Windows.Forms.Button = Me.Button3
            size = New System.Drawing.Size(67, 32)
            button6.Size = size
            Me.Button3.TabIndex = 343
            Me.Button3.Text = "Get Data"
            Me.Button3.UseVisualStyleBackColor = True
            Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtAddress
            location = New System.Drawing.Point(10, 34)
            textBox.Location = location
            Me.txtAddress.Multiline = True
            Me.txtAddress.Name = "txtAddress"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtAddress
            size = New System.Drawing.Size(147, 32)
            textBox2.Size = size
            Me.txtAddress.TabIndex = 342
            Me.GroupBox3.Controls.Add(Me.Button2)
            Me.GroupBox3.Controls.Add(Me.txtContactNo)
            Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox3.ForeColor = System.Drawing.Color.White
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox3
            location = New System.Drawing.Point(272, 41)
            groupBox3.Location = location
            Me.GroupBox3.Name = "GroupBox3"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox3
            size = New System.Drawing.Size(228, 83)
            groupBox4.Size = size
            Me.GroupBox3.TabIndex = 112
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Search By Contact No."
            Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button2.ForeColor = System.Drawing.Color.Black
            Dim button7 As System.Windows.Forms.Button = Me.Button2
            location = New System.Drawing.Point(155, 35)
            button7.Location = location
            Me.Button2.Name = "Button2"
            Dim button8 As System.Windows.Forms.Button = Me.Button2
            size = New System.Drawing.Size(67, 32)
            button8.Size = size
            Me.Button2.TabIndex = 343
            Me.Button2.Text = "Get Data"
            Me.Button2.UseVisualStyleBackColor = True
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtContactNo
            location = New System.Drawing.Point(10, 34)
            textBox3.Location = location
            Me.txtContactNo.Multiline = True
            Me.txtContactNo.Name = "txtContactNo"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtContactNo
            size = New System.Drawing.Size(139, 32)
            textBox4.Size = size
            Me.txtContactNo.TabIndex = 342
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(8, 4)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(749, 34)
            label2.Size = size
            Me.Label1.TabIndex = 111
            Me.Label1.Text = "List of Customers"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.GroupBox2.Controls.Add(Me.Button1)
            Me.GroupBox2.Controls.Add(Me.txtCustomerName)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox2.ForeColor = System.Drawing.Color.White
            Dim groupBox5 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(4, 41)
            groupBox5.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox6 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(262, 83)
            groupBox6.Size = size
            Me.GroupBox2.TabIndex = 110
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search By Customer Name :"
            Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.ForeColor = System.Drawing.Color.Black
            Dim button9 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(192, 34)
            button9.Location = location
            Me.Button1.Name = "Button1"
            Dim button10 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(67, 32)
            button10.Size = size
            Me.Button1.TabIndex = 114
            Me.Button1.Text = "Get Data"
            Me.Button1.UseVisualStyleBackColor = True
            Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtCustomerName
            location = New System.Drawing.Point(10, 34)
            textBox5.Location = location
            Me.txtCustomerName.Multiline = True
            Me.txtCustomerName.Name = "txtCustomerName"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtCustomerName
            size = New System.Drawing.Size(179, 32)
            textBox6.Size = size
            Me.txtCustomerName.TabIndex = 342
            Me.GroupBox1.Controls.Add(Me.lblUser)
            Me.GroupBox1.Controls.Add(Me.lblSet)
            Me.GroupBox1.Controls.Add(Me.btnExportExcel)
            Me.GroupBox1.Controls.Add(Me.btnReset)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox7 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(748, 41)
            groupBox7.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox8 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(256, 83)
            groupBox8.Size = size
            Me.GroupBox1.TabIndex = 109
            Me.GroupBox1.TabStop = False
            Me.lblUser.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(94, 0)
            label3.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label4 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(68, 25)
            label4.Size = size
            Me.lblUser.TabIndex = 344
            Me.lblUser.Text = "Label2"
            Me.lblUser.Visible = False
            Me.lblSet.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(-17, -19)
            label5.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label6 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(68, 25)
            label6.Size = size
            Me.lblSet.TabIndex = 343
            Me.lblSet.Text = "Label2"
            Me.lblSet.Visible = False
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.ForeColor = System.Drawing.Color.Black
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(119, 21)
            button11.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button12 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(129, 56)
            button12.Size = size
            Me.btnExportExcel.TabIndex = 5
            Me.btnExportExcel.Text = "Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.ForeColor = System.Drawing.Color.Black
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button13 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(7, 21)
            button13.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button14 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(106, 56)
            button14.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.Label5.AutoSize = True
            Dim label7 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(339, 75)
            label7.Location = location
            Me.Label5.Name = "Label5"
            Dim label8 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(0, 13)
            label8.Size = size
            Me.Label5.TabIndex = 12
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgw.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 44
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(4, 130)
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
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 40
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(1006, 442)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 40
            Me.Column1.HeaderText = "Customer Name"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column2.HeaderText = "Address"
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            Me.Column3.HeaderText = "Contact No."
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1027, 588)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            Me.ForeColor = System.Drawing.Color.White
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MinimizeBox = False
            MyBase.Name = "frmCustomersRecord"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox4.ResumeLayout(False)
            Me.GroupBox4.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
