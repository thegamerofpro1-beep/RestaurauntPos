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
    Public Class frmBarcodeLabelPrinting
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnGenerateBarcode")>
        Private _btnGenerateBarcode As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCategory")>
        Private _txtCategory As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtItemName")>
        Private _txtItemName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("listView1")>
        Private _listView1 As System.Windows.Forms.ListView

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("columnHeader3")>
        Private _columnHeader3 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Category")>
        Private _Category As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader2")>
        Private _ColumnHeader2 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader4")>
        Private _ColumnHeader4 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox2")>
        Private _GroupBox2 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtNoOfCopies")>
        Private _txtNoOfCopies As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader7")>
        Private _ColumnHeader7 As System.Windows.Forms.ColumnHeader

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCancel")>
        Private _btnCancel As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtRestaurantName")>
        Private _txtRestaurantName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("ColumnHeader1")>
        Private _ColumnHeader1 As System.Windows.Forms.ColumnHeader

        Private st As String

        Private components As System.ComponentModel.IContainer

        Friend Overridable Property btnGenerateBarcode As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnGenerateBarcode
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnGenerateBarcode_Click
                If Me._btnGenerateBarcode IsNot Nothing Then
                    RemoveHandler Me._btnGenerateBarcode.Click, value2
                End If

                Me._btnGenerateBarcode = value
                If Me._btnGenerateBarcode IsNot Nothing Then
                    AddHandler Me._btnGenerateBarcode.Click, value2
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

        Friend Overridable Property txtCategory As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCategory
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtCategory_TextChanged
                If Me._txtCategory IsNot Nothing Then
                    RemoveHandler Me._txtCategory.TextChanged, value2
                End If

                Me._txtCategory = value
                If Me._txtCategory IsNot Nothing Then
                    AddHandler Me._txtCategory.TextChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtItemName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtItemName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.EventHandler = AddressOf Me.txtProductName_TextChanged
                If Me._txtItemName IsNot Nothing Then
                    RemoveHandler Me._txtItemName.TextChanged, value2
                End If

                Me._txtItemName = value
                If Me._txtItemName IsNot Nothing Then
                    AddHandler Me._txtItemName.TextChanged, value2
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

        Friend Overridable Property listView1 As System.Windows.Forms.ListView
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._listView1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ListView)
                Me._listView1 = value
            End Set
        End Property

        Friend Overridable Property columnHeader3 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._columnHeader3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._columnHeader3 = value
            End Set
        End Property

        Friend Overridable Property Category As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Category
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._Category = value
            End Set
        End Property

        Friend Overridable Property ColumnHeader2 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColumnHeader2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._ColumnHeader2 = value
            End Set
        End Property

        Friend Overridable Property ColumnHeader4 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColumnHeader4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._ColumnHeader4 = value
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

        Friend Overridable Property txtNoOfCopies As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtNoOfCopies
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Dim value2 As System.Windows.Forms.KeyPressEventHandler = AddressOf Me.txtNoOfCopies_KeyPress
                If Me._txtNoOfCopies IsNot Nothing Then
                    RemoveHandler Me._txtNoOfCopies.KeyPress, value2
                End If

                Me._txtNoOfCopies = value
                If Me._txtNoOfCopies IsNot Nothing Then
                    AddHandler Me._txtNoOfCopies.KeyPress, value2
                End If
            End Set
        End Property

        Friend Overridable Property ColumnHeader7 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColumnHeader7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._ColumnHeader7 = value
            End Set
        End Property

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

        Friend Overridable Property txtRestaurantName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtRestaurantName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtRestaurantName = value
            End Set
        End Property

        Friend Overridable Property ColumnHeader1 As System.Windows.Forms.ColumnHeader
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._ColumnHeader1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ColumnHeader)
                Me._ColumnHeader1 = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmBarcodeLabelPrinting_Load
            Call RestaurantPOS14.frmBarcodeLabelPrinting.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList
                If RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList.Count = RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList(num) = RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList.RemoveRange(num, RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList.Count - num)
                    RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList.Capacity = RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList.Count
                End If

                Call RestaurantPOS14.frmBarcodeLabelPrinting.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub FillCompany()
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(HotelName) from Hotel", RestaurantPOS14.ModClasses.con)
            RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            If RestaurantPOS14.ModClasses.rdr.Read() Then
                Me.txtRestaurantName.Text = RestaurantPOS14.ModClasses.rdr.GetString(0)
            End If

            RestaurantPOS14.ModClasses.con.Close()
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(DishName),RTRIM(Category),RTRIM(Barcode),DIRate,TARate,HDRate from Dish order by DishName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.listView1.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.Text = RestaurantPOS14.ModClasses.rdr(CInt((0))).ToString().Trim()
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((1))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((2))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((3))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((4))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((5))).ToString().Trim())
                    Me.listView1.Items.Add(listViewItem)
                End While

                Dim num As Integer = Me.listView1.Items.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    Me.listView1.Items(CInt((num2))).Checked = True
                    num2 += 1
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnGenerateBarcode_Click(sender As Object, e As System.EventArgs)
            If Me.listView1.Items.Count = 0 Then
                Call System.Windows.Forms.MessageBox.Show("There is no product in listview to generate barcode ", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Return
            End If

            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.txtNoOfCopies.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter no. of copies", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtNoOfCopies.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Conversion.Val(Me.txtNoOfCopies.Text) = 0.0 Then
                Call System.Windows.Forms.MessageBox.Show("No. of copies must be greater than zero", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtNoOfCopies.Focus()
                Return
            End If

            Try
                If Me.listView1.CheckedItems.Count <= 0 Then
                    Return
                End If

                Dim text As String = ""
                Dim num As Integer = Me.listView1.CheckedItems.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    text = text & "'" & Me.listView1.CheckedItems(CInt((num2))).SubItems(CInt((2))).Text & "',"
                    num2 += 1
                End While

                text = text.Substring(0, text.Length - 1)
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer1.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                Dim text2 As String = "Select RTRIM(DishName),RTRIM(Category),RTRIM(Barcode),DIRate,TARate,HDRate from Dish Where Barcode in (" & text & ")"
                Dim num5 As Integer = Integer.Parse(Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.Conversion.Val(Me.txtNoOfCopies.Text))) - 1
                Dim num6 As Integer = 1
                While True
                    Dim num7 As Integer = num6
                    Dim num8 As Integer = num5
                    If num7 > num8 Then
                        Exit While
                    End If

                    text2 = text2 & "Union all Select RTRIM(DishName),RTRIM(Category),RTRIM(Barcode),DIRate,TARate,HDRate from Dish Where Barcode in (" & text & ")"
                    num6 += 1
                End While

                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand(text2, RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter(RestaurantPOS14.ModClasses.cmd)
                RestaurantPOS14.ModClasses.dtable = New System.Data.DataTable()
                RestaurantPOS14.ModClasses.adp.Fill(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.ds = New System.Data.DataSet()
                RestaurantPOS14.ModClasses.ds.Tables.Add(RestaurantPOS14.ModClasses.dtable)
                RestaurantPOS14.ModClasses.ds.WriteXmlSchema("BarcodeLabelPrinting.xml")
                Dim rptBarcodeLabelPrinting2 As RestaurantPOS14.rptBarcodeLabelPrinting = New RestaurantPOS14.rptBarcodeLabelPrinting()
                rptBarcodeLabelPrinting2.SetDataSource(RestaurantPOS14.ModClasses.ds)
                rptBarcodeLabelPrinting2.SetParameterValue("p1", Me.txtRestaurantName.Text)
                RestaurantPOS14.My.MyProject.Forms.frmReport.CrystalReportViewer1.ReportSource = rptBarcodeLabelPrinting2
                Call RestaurantPOS14.My.MyProject.Forms.frmReport.ShowDialog()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub Reset()
            Me.txtCategory.Text = ""
            Me.txtItemName.Text = ""
            Me.txtNoOfCopies.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(1)
            Me.GetData()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub frmBarcodeLabelPrinting_Load(sender As Object, e As System.EventArgs)
            Me.GetData()
            Me.FillCompany()
        End Sub

        Private Sub txtNoOfCopies_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If((e.KeyChar < "0"c) Or (e.KeyChar > "9"c)) And (e.KeyChar <> Global.Microsoft.VisualBasic.Strings.ChrW(8)) Then
                e.Handled = True
            End If
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer1.Enabled = False
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As System.EventArgs)
            MyBase.Close()
        End Sub

        Private Sub txtProductName_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(DishName),RTRIM(Category),RTRIM(Barcode),DIRate,TARate,HDRate from Dish where DishName like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtItemName.Text) & "%' order by DishName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.listView1.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.Text = RestaurantPOS14.ModClasses.rdr(CInt((0))).ToString().Trim()
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((1))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((2))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((3))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((4))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((5))).ToString().Trim())
                    Me.listView1.Items.Add(listViewItem)
                End While

                Dim num As Integer = Me.listView1.Items.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    Me.listView1.Items(CInt((num2))).Checked = True
                    num2 += 1
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub txtCategory_TextChanged(sender As Object, e As System.EventArgs)
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Select RTRIM(DishName),RTRIM(Category),RTRIM(Barcode),DIRate,TARate,HDRate from Dish Where Category like N'%" & RestaurantPOS14.Security.SqlInput.EscapeLiteral(Me.txtCategory.Text) & "%' order by DishName", RestaurantPOS14.ModClasses.con)
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                Me.listView1.Items.Clear()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim listViewItem As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem()
                    listViewItem.Text = RestaurantPOS14.ModClasses.rdr(CInt((0))).ToString().Trim()
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((1))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((2))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((3))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((4))).ToString().Trim())
                    listViewItem.SubItems.Add(RestaurantPOS14.ModClasses.rdr(CInt((5))).ToString().Trim())
                    Me.listView1.Items.Add(listViewItem)
                End While

                Dim num As Integer = Me.listView1.Items.Count - 1
                Dim num2 As Integer = 0
                While True
                    Dim num3 As Integer = num2
                    Dim num4 As Integer = num
                    If num3 > num4 Then
                        Exit While
                    End If

                    Me.listView1.Items(CInt((num2))).Checked = True
                    num2 += 1
                End While

                RestaurantPOS14.ModClasses.con.Close()
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
            Me.components = New System.ComponentModel.Container()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmBarcodeLabelPrinting))
            Me.btnGenerateBarcode = New System.Windows.Forms.Button()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.txtRestaurantName = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtCategory = New System.Windows.Forms.TextBox()
            Me.txtItemName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.columnHeader3 = New System.Windows.Forms.ColumnHeader()
            Me.Category = New System.Windows.Forms.ColumnHeader()
            Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
            Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
            Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
            Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.txtNoOfCopies = New System.Windows.Forms.TextBox()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.GroupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.btnGenerateBarcode.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnGenerateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnGenerateBarcode.ForeColor = System.Drawing.Color.White
            Dim button As System.Windows.Forms.Button = Me.btnGenerateBarcode
            Dim location As System.Drawing.Point = New System.Drawing.Point(134, 35)
            button.Location = location
            Me.btnGenerateBarcode.Name = "btnGenerateBarcode"
            Dim button2 As System.Windows.Forms.Button = Me.btnGenerateBarcode
            Dim size As System.Drawing.Size = New System.Drawing.Size(130, 43)
            button2.Size = size
            Me.btnGenerateBarcode.TabIndex = 23
            Me.btnGenerateBarcode.Text = "Generate Barcode"
            Me.btnGenerateBarcode.UseVisualStyleBackColor = False
            Me.GroupBox1.Controls.Add(Me.txtRestaurantName)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtCategory)
            Me.GroupBox1.Controls.Add(Me.txtItemName)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(3, 3)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(360, 96)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 26
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Search By"
            Dim textBox As System.Windows.Forms.TextBox = Me.txtRestaurantName
            location = New System.Drawing.Point(288, 24)
            textBox.Location = location
            Me.txtRestaurantName.Name = "txtRestaurantName"
            Me.txtRestaurantName.[ReadOnly] = True
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtRestaurantName
            size = New System.Drawing.Size(22, 25)
            textBox2.Size = size
            Me.txtRestaurantName.TabIndex = 71
            Me.txtRestaurantName.Visible = False
            Me.Label2.AutoSize = True
            Dim label As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(199, 34)
            label.Location = location
            Me.Label2.Name = "Label2"
            Dim label2 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(71, 17)
            label2.Size = size
            Me.Label2.TabIndex = 26
            Me.Label2.Text = "Category :"
            Me.txtCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtCategory
            location = New System.Drawing.Point(202, 53)
            textBox3.Location = location
            Me.txtCategory.Name = "txtCategory"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtCategory
            size = New System.Drawing.Size(148, 25)
            textBox4.Size = size
            Me.txtCategory.TabIndex = 25
            Me.txtItemName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtItemName
            location = New System.Drawing.Point(19, 53)
            textBox5.Location = location
            Me.txtItemName.Name = "txtItemName"
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtItemName
            size = New System.Drawing.Size(177, 25)
            textBox6.Size = size
            Me.txtItemName.TabIndex = 24
            Me.Label3.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(16, 34)
            label3.Location = location
            Me.Label3.Name = "Label3"
            Dim label4 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(83, 17)
            label4.Size = size
            Me.Label3.TabIndex = 22
            Me.Label3.Text = "Item Name :"
            Me.listView1.CheckBoxes = True
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader(5) {Me.columnHeader3, Me.Category, Me.ColumnHeader2, Me.ColumnHeader7, Me.ColumnHeader4, Me.ColumnHeader1})
            Me.listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.listView1.GridLines = True
            Dim listView As System.Windows.Forms.ListView = Me.listView1
            location = New System.Drawing.Point(4, 105)
            listView.Location = location
            Me.listView1.Name = "listView1"
            Dim listView2 As System.Windows.Forms.ListView = Me.listView1
            size = New System.Drawing.Size(866, 426)
            listView2.Size = size
            Me.listView1.TabIndex = 67
            Me.listView1.UseCompatibleStateImageBehavior = False
            Me.listView1.View = System.Windows.Forms.View.Details
            Me.columnHeader3.Text = "Item Name"
            Me.columnHeader3.Width = 250
            Me.Category.Text = "Category"
            Me.Category.Width = 160
            Me.ColumnHeader2.Text = "Barcode"
            Me.ColumnHeader2.Width = 120
            Me.ColumnHeader7.Text = "Dine In Rate"
            Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.ColumnHeader7.Width = 100
            Me.ColumnHeader4.Text = "Take Away Rate"
            Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.ColumnHeader4.Width = 100
            Me.ColumnHeader1.Text = "Home Delivery Rate"
            Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader1.Width = 130
            Me.btnReset.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnReset.ForeColor = System.Drawing.Color.White
            Dim button3 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(268, 35)
            button3.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button4 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(102, 43)
            button4.Size = size
            Me.btnReset.TabIndex = 69
            Me.btnReset.Text = "Reset"
            Me.btnReset.UseVisualStyleBackColor = False
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.btnReset)
            Me.GroupBox2.Controls.Add(Me.txtNoOfCopies)
            Me.GroupBox2.Controls.Add(Me.btnGenerateBarcode)
            Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox3 As System.Windows.Forms.GroupBox = Me.GroupBox2
            location = New System.Drawing.Point(369, 3)
            groupBox3.Location = location
            Me.GroupBox2.Name = "GroupBox2"
            Dim groupBox4 As System.Windows.Forms.GroupBox = Me.GroupBox2
            size = New System.Drawing.Size(381, 96)
            groupBox4.Size = size
            Me.GroupBox2.TabIndex = 70
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Generate Barcode"
            Me.Label1.AutoSize = True
            Dim label5 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(15, 34)
            label5.Location = location
            Me.Label1.Name = "Label1"
            Dim label6 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(98, 17)
            label6.Size = size
            Me.Label1.TabIndex = 28
            Me.Label1.Text = "No. Of Copies :"
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtNoOfCopies
            location = New System.Drawing.Point(18, 53)
            textBox7.Location = location
            Me.txtNoOfCopies.Name = "txtNoOfCopies"
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtNoOfCopies
            size = New System.Drawing.Size(106, 25)
            textBox8.Size = size
            Me.txtNoOfCopies.TabIndex = 27
            Me.txtNoOfCopies.Text = "1"
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.GroupBox2)
            Me.Panel1.Controls.Add(Me.listView1)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(4, 52)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(877, 534)
            panel2.Size = size
            Me.Panel1.TabIndex = 71
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.Label4)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(0, 0)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(827, 48)
            panel4.Size = size
            Me.Panel2.TabIndex = 72
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label4.ForeColor = System.Drawing.Color.White
            Dim label7 As System.Windows.Forms.Label = Me.Label4
            location = New System.Drawing.Point(297, 9)
            label7.Location = location
            Me.Label4.Name = "Label4"
            Dim label8 As System.Windows.Forms.Label = Me.Label4
            size = New System.Drawing.Size(229, 30)
            label8.Size = size
            Me.Label4.TabIndex = 0
            Me.Label4.Text = "Barcode Label Printing"
            Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            Me.btnCancel.BackColor = System.Drawing.Color.Transparent
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatAppearance.BorderSize = 0
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnCancel.Image = CType(componentResourceManager.GetObject("btnCancel.Image"), System.Drawing.Image)
            Dim button5 As System.Windows.Forms.Button = Me.btnCancel
            location = New System.Drawing.Point(833, 1)
            button5.Location = location
            Me.btnCancel.Name = "btnCancel"
            Dim button6 As System.Windows.Forms.Button = Me.btnCancel
            size = New System.Drawing.Size(52, 50)
            button6.Size = size
            Me.btnCancel.TabIndex = 391
            Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCancel.UseVisualStyleBackColor = False
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(886, 590)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.btnCancel)
            MyBase.Controls.Add(Me.Panel2)
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmBarcodeLabelPrinting"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Barcode Label Printing"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.Panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
