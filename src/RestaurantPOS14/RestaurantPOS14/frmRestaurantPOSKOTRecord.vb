Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmRestaurantPOSKOTRecord
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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateTo")>
        Private _dtpDateTo As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateFrom")>
        Private _dtpDateFrom As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbTicketNo")>
        Private _cmbTicketNo As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUserType")>
        Private _lblUserType As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button2")>
        Private _Button2 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnShowAllBills")>
        Private _btnShowAllBills As System.Windows.Forms.Button

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

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column9")>
        Private _Column9 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column10")>
        Private _Column10 As System.Windows.Forms.DataGridViewTextBoxColumn

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Column11")>
        Private _Column11 As System.Windows.Forms.DataGridViewTextBoxColumn

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

        Friend Overridable Property dtpDateTo As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateTo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateTo = value
            End Set
        End Property

        Friend Overridable Property dtpDateFrom As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateFrom
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateFrom = value
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

        Friend Overridable Property cmbTicketNo As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbTicketNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbTicketNo_SelectedIndexChanged
                If Me._cmbTicketNo IsNot Nothing Then
                    RemoveHandler Me._cmbTicketNo.SelectedIndexChanged, value2
                End If

                Me._cmbTicketNo = value
                If Me._cmbTicketNo IsNot Nothing Then
                    AddHandler Me._cmbTicketNo.SelectedIndexChanged, value2
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

        Friend Overridable Property lblUserType As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._lblUserType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._lblUserType = value
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

        Friend Overridable Property btnShowAllBills As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnShowAllBills
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnShowAllBills_Click
                If Me._btnShowAllBills IsNot Nothing Then
                    RemoveHandler Me._btnShowAllBills.Click, value2
                End If

                Me._btnShowAllBills = value
                If Me._btnShowAllBills IsNot Nothing Then
                    AddHandler Me._btnShowAllBills.Click, value2
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

        Friend Overridable Property Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column9 = value
            End Set
        End Property

        Friend Overridable Property Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column10
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column10 = value
            End Set
        End Property

        Friend Overridable Property Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Column11
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DataGridViewTextBoxColumn)
                Me._Column11 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList
                If RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList.Count = RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList(num) = RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList.RemoveRange(num, RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList.Count - num)
                    RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList.Capacity = RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList.Count
                End If

                Call RestaurantPOS14.frmRestaurantPOSKOTRecord.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub GetData(st As String)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand(st, RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d1")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateFrom.Value
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(CStr(("@d2")), CType((System.Data.SqlDbType.DateTime), System.Data.SqlDbType), CInt((30)), CStr(("DateIN"))).Value = Me.dtpDateTo.Value
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.cmbTicketNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text)
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                Me.dgw.Rows.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.dgw.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)))
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub fillTicketNo(st As String)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                Call System.Data.SqlClient.SqlConnection.ClearAllPools()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand(st)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserVAL.Text)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.cmbTicketNo.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.cmbTicketNo.Items.Add(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString())
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.cmbTicketNo.Text = ""
            Me.dtpDateFrom.Value = Microsoft.VisualBasic.DateAndTime.Now
            Me.dtpDateTo.Value = Microsoft.VisualBasic.DateAndTime.Now
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserType.Text, "Super Admin", TextCompare:=False) = 0 Then
                Me.GetData("Select RTRIM(RestaurantPOS_OrderInfoKOT.Id), RTRIM(TicketNo),BillDate,RTRIM(TableNo),(RestaurantPOS_OrderInfoKOT.GrandTotal),RTRIM(Operator),RTRIM(GroupName),RTRIM(TicketNote),RTRIM(KOT_Status),RTRIM(ODNX),NoOfPerson from RestaurantPOS_OrderInfoKOT where (DATEDIFF(d,BillDate,GetDate())= 0) Order by BillDate Desc")
            Else
                Me.GetData("Select RTRIM(RestaurantPOS_OrderInfoKOT.Id), RTRIM(TicketNo),BillDate,RTRIM(TableNo),(RestaurantPOS_OrderInfoKOT.GrandTotal),RTRIM(Operator),RTRIM(GroupName),RTRIM(TicketNote),RTRIM(KOT_Status),RTRIM(ODNX),NoOfPerson from RestaurantPOS_OrderInfoKOT where (DATEDIFF(d,BillDate,GetDate())= 0) and Operator=@d4 order by BillDate desc")
            End If

            Me.cmbTicketNo.Text = ""
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
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtTicketID.Text = dataGridViewRow.Cells(CInt((0))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTicketNo.Text = dataGridViewRow.Cells(CInt((1))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.dtpBillDate.Value = Microsoft.VisualBasic.CompilerServices.Conversions.ToDate(dataGridViewRow.Cells(CInt((2))).Value)
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblTableNo.Text = dataGridViewRow.Cells(CInt((3))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblBalance.Text = dataGridViewRow.Cells(CInt((4))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbGroup.Text = dataGridViewRow.Cells(CInt((6))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSave.Enabled = False
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblUserType.Text, "Super Admin", TextCompare:=False) = 0 Then
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnDelete.Enabled = True
                    Else
                        RestaurantPOS14.My.MyProject.Forms.frmPOS.btnDelete.Enabled = False
                    End If

                    RestaurantPOS14.My.MyProject.Forms.frmPOS.flpCategoriesKOT.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.flpItemsKOT.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnSettle.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnPrint.Enabled = True
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.cmbGroup.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnKOTUpdate.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.lblSet.Text = "Not Allowed"
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject("Select RTRIM(Dish),RTRIM(Rate),RTRIM(Quantity),RTRIM(Amount),RTRIM(DiscountPer), RTRIM(DiscountAmount), RTRIM(STPer), RTRIM(STAmount), RTRIM(VATPer), RTRIM(VATAmount),SCPer,SCAmount,RTRIM(TotalAmount),RTRIM(Notes),Quantity,RTRIM(Category),RTRIM(DishNameArabic),RTRIM(ItemStatus) from RestaurantPOS_OrderInfoKOT,RestaurantPOS_OrderedProductKOT where RestaurantPOS_OrderInfoKOT.Id=RestaurantPOS_OrderedProductKOT.TicketID and RestaurantPOS_OrderInfoKOT.ID=", dataGridViewRow.Cells(CInt((0))).Value), " order by Dish")), RestaurantPOS14.ModClasses.con)
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows.Clear()
                    While RestaurantPOS14.ModClasses.rdr.Read()
                        Call RestaurantPOS14.My.MyProject.Forms.frmPOS.DataGridView1.Rows.Add(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(0)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(1)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(2)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(3)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(4)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(5)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(6)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(7)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(8)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(9)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(10)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(11)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(12)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(13)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(14)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(15)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(16)), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.rdr(17)))
                    End While

                    RestaurantPOS14.ModClasses.con.Close()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnVoid.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtStatus.Text = dataGridViewRow.Cells(CInt((8))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNoofPeople.Text = dataGridViewRow.Cells(CInt((10))).Value.ToString()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.txtNoofPeople.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnHold1.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnRecall1.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnPizza1.Enabled = False
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.btnOpenFoods1.Enabled = False
                    Call RestaurantPOS14.My.MyProject.Forms.frmPOS.CalcItemsAndQty()
                    RestaurantPOS14.My.MyProject.Forms.frmPOS.TabControl1.SelectedIndex = 0
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

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserType.Text, "Super Admin", TextCompare:=False) = 0 Then
                Me.GetData("Select RTRIM(RestaurantPOS_OrderInfoKOT.Id), RTRIM(TicketNo),BillDate,RTRIM(TableNo),(RestaurantPOS_OrderInfoKOT.GrandTotal),RTRIM(Operator),RTRIM(GroupName),RTRIM(TicketNote),RTRIM(KOT_Status),RTRIM(ODNX),NoOfPerson from RestaurantPOS_OrderInfoKOT where BillDate >=@d1 and BillDate < @d2 Order by BillDate")
            Else
                Me.GetData("Select RTRIM(RestaurantPOS_OrderInfoKOT.Id), RTRIM(TicketNo),BillDate,RTRIM(TableNo),(RestaurantPOS_OrderInfoKOT.GrandTotal),RTRIM(Operator),RTRIM(GroupName),RTRIM(TicketNote),RTRIM(KOT_Status),RTRIM(ODNX),NoOfPerson from RestaurantPOS_OrderInfoKOT where BillDate >=@d1 and BillDate < @d2 and Operator=@d4 order by BillDate")
            End If
        End Sub

        Private Sub cmbTicketNo_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserType.Text, "Super Admin", TextCompare:=False) = 0 Then
                Me.GetData("Select RTRIM(RestaurantPOS_OrderInfoKOT.Id), RTRIM(TicketNo),BillDate,RTRIM(TableNo),(RestaurantPOS_OrderInfoKOT.GrandTotal),RTRIM(Operator),RTRIM(GroupName),RTRIM(TicketNote),RTRIM(KOT_Status),RTRIM(ODNX),NoOfPerson from RestaurantPOS_OrderInfoKOT where TicketNo=@d3 Order by BillDate")
            Else
                Me.GetData("Select RTRIM(RestaurantPOS_OrderInfoKOT.Id), RTRIM(TicketNo),BillDate,RTRIM(TableNo),(RestaurantPOS_OrderInfoKOT.GrandTotal),RTRIM(Operator),RTRIM(GroupName),RTRIM(TicketNote),RTRIM(KOT_Status),RTRIM(ODNX),NoOfPerson from RestaurantPOS_OrderInfoKOT where TicketNo=@d3 and Operator=@d4 order by BillDate")
            End If
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub Button2_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserType.Text, "Super Admin", TextCompare:=False) = 0 Then
                Me.fillTicketNo("SELECT RTRIM(TicketNo) FROM RestaurantPOS_OrderInfoKOT order by 1")
            Else
                Me.fillTicketNo("SELECT RTRIM(TicketNo) FROM RestaurantPOS_OrderInfoKOT where Operator=@d1 order by 1")
            End If
        End Sub

        Private Sub btnShowAllBills_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(RestaurantPOS14.My.MyProject.Forms.frmPOS.lblUserType.Text, "Super Admin", TextCompare:=False) = 0 Then
                Me.GetData("Select RTRIM(RestaurantPOS_OrderInfoKOT.Id), RTRIM(TicketNo),BillDate,RTRIM(TableNo),(RestaurantPOS_OrderInfoKOT.GrandTotal),RTRIM(Operator),RTRIM(GroupName),RTRIM(TicketNote),RTRIM(KOT_Status),RTRIM(ODNX),NoOfPerson from RestaurantPOS_OrderInfoKOT Order by BillDate")
            Else
                Me.GetData("Select RTRIM(RestaurantPOS_OrderInfoKOT.Id), RTRIM(TicketNo),BillDate,RTRIM(TableNo),(RestaurantPOS_OrderInfoKOT.GrandTotal),RTRIM(Operator),RTRIM(GroupName),RTRIM(TicketNote),RTRIM(KOT_Status),RTRIM(ODNX),NoOfPerson from RestaurantPOS_OrderInfoKOT where Operator=@d4 order by BillDate")
            End If
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmRestaurantPOSKOTRecord))
            Dim dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblUserType = New System.Windows.Forms.Label()
            Me.btnShowAllBills = New System.Windows.Forms.Button()
            Me.btnExportExcel = New System.Windows.Forms.Button()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
            Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmbTicketNo = New System.Windows.Forms.ComboBox()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.dgw = New System.Windows.Forms.DataGridView()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Panel1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
            MyBase.SuspendLayout()
            Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblUserType)
            Me.Panel1.Controls.Add(Me.btnShowAllBills)
            Me.Panel1.Controls.Add(Me.btnExportExcel)
            Me.Panel1.Controls.Add(Me.btnReset)
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
            Dim size As System.Drawing.Size = New System.Drawing.Size(1010, 580)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.lblUserType.AutoSize = True
            Me.lblUserType.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.lblUserType.ForeColor = System.Drawing.Color.PaleGoldenrod
            Dim label As System.Windows.Forms.Label = Me.lblUserType
            location = New System.Drawing.Point(168, -1)
            label.Location = location
            Me.lblUserType.Name = "lblUserType"
            Dim label2 As System.Windows.Forms.Label = Me.lblUserType
            size = New System.Drawing.Size(130, 37)
            label2.Size = size
            Me.lblUserType.TabIndex = 325
            Me.lblUserType.Text = "UserType"
            Me.lblUserType.Visible = False
            Me.btnShowAllBills.BackColor = System.Drawing.SystemColors.Control
            Me.btnShowAllBills.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnShowAllBills.FlatAppearance.BorderSize = 0
            Me.btnShowAllBills.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnShowAllBills.ForeColor = System.Drawing.Color.Black
            Me.btnShowAllBills.Image = CType(componentResourceManager.GetObject("btnShowAllBills.Image"), System.Drawing.Image)
            Me.btnShowAllBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.btnShowAllBills
            location = New System.Drawing.Point(245, 155)
            button.Location = location
            Me.btnShowAllBills.Name = "btnShowAllBills"
            Dim button2 As System.Windows.Forms.Button = Me.btnShowAllBills
            size = New System.Drawing.Size(129, 64)
            button2.Size = size
            Me.btnShowAllBills.TabIndex = 121
            Me.btnShowAllBills.Text = "Show All KOTs"
            Me.btnShowAllBills.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnShowAllBills.UseVisualStyleBackColor = False
            Me.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnExportExcel.Image = CType(componentResourceManager.GetObject("btnExportExcel.Image"), System.Drawing.Image)
            Me.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnExportExcel
            location = New System.Drawing.Point(112, 155)
            button3.Location = location
            Me.btnExportExcel.Name = "btnExportExcel"
            Dim button4 As System.Windows.Forms.Button = Me.btnExportExcel
            size = New System.Drawing.Size(129, 64)
            button4.Size = size
            Me.btnExportExcel.TabIndex = 5
            Me.btnExportExcel.Text = "Export Excel"
            Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExportExcel.UseVisualStyleBackColor = True
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(3, 155)
            button5.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button6 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(106, 64)
            button6.Size = size
            Me.btnReset.TabIndex = 0
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = True
            Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.Label1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label3 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(8, 4)
            label3.Location = location
            Me.Label1.Name = "Label1"
            Dim label4 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(991, 34)
            label4.Size = size
            Me.Label1.TabIndex = 111
            Me.Label1.Text = "List of Today's Dine In KOTs"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.dtpDateFrom)
            Me.GroupBox2.Controls.Add(Me.dtpDateTo)
            Me.GroupBox2.Controls.Add(Me.Button1)
            Me.GroupBox2.Controls.Add(Me.Label2)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox2.ForeColor = System.Drawing.Color.White
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(4, 41)
            groupBox.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(684, 109)
            groupBox2.Size = size
            Me.GroupBox2.TabIndex = 110
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Search By Date :"
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(277, 29)
            label5.Location = location
            Me.Label4.Name = "Label4"
            Dim label6 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(35, 20)
            label6.Size = size
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "To :"
            Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
            Me.dtpDateFrom.Font = New System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            location = New System.Drawing.Point(15, 50)
            dateTimePicker.Location = location
            Me.dtpDateFrom.Name = "dtpDateFrom"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDateFrom
            size = New System.Drawing.Size(256, 33)
            dateTimePicker2.Size = size
            Me.dtpDateFrom.TabIndex = 106
            Me.dtpDateTo.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
            Me.dtpDateTo.Font = New System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker3 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            location = New System.Drawing.Point(277, 50)
            dateTimePicker3.Location = location
            Me.dtpDateTo.Name = "dtpDateTo"
            Dim dateTimePicker4 As System.Windows.Forms.DateTimePicker = Me.dtpDateTo
            size = New System.Drawing.Size(257, 33)
            dateTimePicker4.Size = size
            Me.dtpDateTo.TabIndex = 107
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.ForeColor = System.Drawing.Color.Black
            Me.Button1.Image = CType(componentResourceManager.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(549, 32)
            button7.Location = location
            Me.Button1.Name = "Button1"
            Dim button8 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(121, 64)
            button8.Size = size
            Me.Button1.TabIndex = 108
            Me.Button1.Text = "Search"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(11, 27)
            label7.Location = location
            Me.Label2.Name = "Label2"
            Dim label8 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(54, 20)
            label8.Size = size
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "From :"
            Me.GroupBox1.Controls.Add(Me.cmbTicketNo)
            Me.GroupBox1.Controls.Add(Me.Button2)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.GroupBox1.ForeColor = System.Drawing.Color.White
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(696, 40)
            groupBox3.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(285, 109)
            groupBox4.Size = size
            Me.GroupBox1.TabIndex = 109
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By Ticket No. :"
            Me.cmbTicketNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.cmbTicketNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cmbTicketNo.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbTicketNo
            location = New System.Drawing.Point(16, 50)
            comboBox.Location = location
            Me.cmbTicketNo.Name = "cmbTicketNo"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbTicketNo
            size = New System.Drawing.Size(147, 33)
            comboBox2.Size = size
            Me.cmbTicketNo.TabIndex = 1
            Me.Button2.BackColor = System.Drawing.SystemColors.Control
            Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button2.FlatAppearance.BorderSize = 0
            Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button2.ForeColor = System.Drawing.Color.Black
            Dim button9 As System.Windows.Forms.Button = Me.Button2
            location = New System.Drawing.Point(169, 50)
            button9.Location = location
            Me.Button2.Name = "Button2"
            Dim button10 As System.Windows.Forms.Button = Me.Button2
            size = New System.Drawing.Size(108, 33)
            button10.Size = size
            Me.Button2.TabIndex = 120
            Me.Button2.Text = "Load All KOTs"
            Me.Button2.UseVisualStyleBackColor = False
            Me.Label5.AutoSize = True
            Dim label9 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(339, 75)
            label9.Location = location
            Me.Label5.Name = "Label5"
            Dim label10 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(0, 13)
            label10.Size = size
            Me.Label5.TabIndex = 12
            Me.dgw.AllowUserToAddRows = False
            Me.dgw.AllowUserToDeleteRows = False
            dataGridViewCellStyle.BackColor = System.Drawing.Color.FloralWhite
            Me.dgw.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
            Me.dgw.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.dgw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgw.BackgroundColor = System.Drawing.Color.FromArgb(102, 106, 105)
            Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
            Me.dgw.ColumnHeadersHeight = 40
            Me.dgw.Columns.AddRange(Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11)
            Me.dgw.Cursor = System.Windows.Forms.Cursors.Hand
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.DefaultCellStyle = dataGridViewCellStyle3
            Me.dgw.EnableHeadersVisualStyles = False
            Me.dgw.GridColor = System.Drawing.Color.White
            Dim dataGridView As System.Windows.Forms.DataGridView = Me.dgw
            location = New System.Drawing.Point(4, 225)
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
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgw.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
            Me.dgw.RowHeadersWidth = 25
            Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
            Me.dgw.RowsDefaultCellStyle = dataGridViewCellStyle5
            Me.dgw.RowTemplate.Height = 40
            Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Dim dataGridView2 As System.Windows.Forms.DataGridView = Me.dgw
            size = New System.Drawing.Size(995, 347)
            dataGridView2.Size = size
            Me.dgw.TabIndex = 40
            Me.Column1.HeaderText = "ID"
            Me.Column1.Name = "Column1"
            Me.Column1.[ReadOnly] = True
            Me.Column1.Visible = False
            Me.Column2.FillWeight = 76.60879F
            Me.Column2.HeaderText = "Ticket No."
            Me.Column2.Name = "Column2"
            Me.Column2.[ReadOnly] = True
            dataGridViewCellStyle6.Format = "dd/MM/yyyy hh:mm:ss tt"
            Me.Column3.DefaultCellStyle = dataGridViewCellStyle6
            Me.Column3.FillWeight = 144.4618F
            Me.Column3.HeaderText = "Date"
            Me.Column3.Name = "Column3"
            Me.Column3.[ReadOnly] = True
            Me.Column4.FillWeight = 98.01078F
            Me.Column4.HeaderText = "Table No."
            Me.Column4.Name = "Column4"
            Me.Column4.[ReadOnly] = True
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.Column5.DefaultCellStyle = dataGridViewCellStyle7
            Me.Column5.FillWeight = 73.87672F
            Me.Column5.HeaderText = "Grand Total"
            Me.Column5.Name = "Column5"
            Me.Column5.[ReadOnly] = True
            Me.Column6.FillWeight = 107.0419F
            Me.Column6.HeaderText = "Operator"
            Me.Column6.Name = "Column6"
            Me.Column6.[ReadOnly] = True
            Me.Column7.HeaderText = "Group/Customer Name"
            Me.Column7.Name = "Column7"
            Me.Column7.[ReadOnly] = True
            Me.Column7.Visible = False
            Me.Column8.HeaderText = "Ticket Note"
            Me.Column8.Name = "Column8"
            Me.Column8.[ReadOnly] = True
            Me.Column9.HeaderText = "Status"
            Me.Column9.Name = "Column9"
            Me.Column9.[ReadOnly] = True
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.Column10.DefaultCellStyle = dataGridViewCellStyle8
            Me.Column10.HeaderText = "Order No."
            Me.Column10.Name = "Column10"
            Me.Column10.[ReadOnly] = True
            Me.Column11.HeaderText = "NOP"
            Me.Column11.Name = "Column11"
            Me.Column11.[ReadOnly] = True
            Me.Column11.Visible = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(1016, 588)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmRestaurantPOSKOTRecord"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
