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
Imports Trestan

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmTableLayoutSettings
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbTableNo")>
        Private _cmbTableNo As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnCreateTable")>
        Private _btnCreateTable As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("pnlTables")>
        Private _pnlTables As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbFloorNo")>
        Private _cmbFloorNo As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnReset")>
        Private _btnReset As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbShape")>
        Private _cmbShape As System.Windows.Forms.ComboBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        Private previousLocation As System.Drawing.Point

        Public acControl As System.Windows.Forms.Control

        Public Cshape As Object

        Private components As System.ComponentModel.IContainer

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

        Friend Overridable Property cmbTableNo As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbTableNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Me._cmbTableNo = value
            End Set
        End Property

        Friend Overridable Property btnCreateTable As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnCreateTable
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._btnCreateTable IsNot Nothing Then
                    RemoveHandler Me._btnCreateTable.Click, value2
                End If

                Me._btnCreateTable = value
                If Me._btnCreateTable IsNot Nothing Then
                    AddHandler Me._btnCreateTable.Click, value2
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

        Friend Overridable Property cmbFloorNo As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbFloorNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbFloorNo_SelectedIndexChanged
                If Me._cmbFloorNo IsNot Nothing Then
                    RemoveHandler Me._cmbFloorNo.SelectedIndexChanged, value2
                End If

                Me._cmbFloorNo = value
                If Me._cmbFloorNo IsNot Nothing Then
                    AddHandler Me._cmbFloorNo.SelectedIndexChanged, value2
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
            AddHandler MyBase.Load, AddressOf Me.Form1_Load
            Call RestaurantPOS14.frmTableLayoutSettings.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmTableLayoutSettings.__ENCList
                If RestaurantPOS14.frmTableLayoutSettings.__ENCList.Count = RestaurantPOS14.frmTableLayoutSettings.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmTableLayoutSettings.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmTableLayoutSettings.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmTableLayoutSettings.__ENCList(num) = RestaurantPOS14.frmTableLayoutSettings.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmTableLayoutSettings.__ENCList.RemoveRange(num, RestaurantPOS14.frmTableLayoutSettings.__ENCList.Count - num)
                    RestaurantPOS14.frmTableLayoutSettings.__ENCList.Capacity = RestaurantPOS14.frmTableLayoutSettings.__ENCList.Count
                End If

                Call RestaurantPOS14.frmTableLayoutSettings.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub fillFloorNo()
            Try
                Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                sqlConnection.Open()
                RestaurantPOS14.ModClasses.adp = New System.Data.SqlClient.SqlDataAdapter()
                RestaurantPOS14.ModClasses.adp.SelectCommand = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(FloorNo) FROM R_Table Order by 1", sqlConnection)
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

        Public Sub fillTableNo()
            Try
                Me.cmbTableNo.Enabled = True
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT distinct RTRIM(R_Table.TableNo) FROM R_Table where Status='Activate' and TableNo not in(Select TableNo from TableLayout where TableNo is not Null and TableNo <>'') and FloorNo=@d1 order by 1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbFloorNo.Text)
                Me.cmbTableNo.Items.Clear()
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Me.cmbTableNo.Items.Add(RestaurantPOS14.ModClasses.rdr.GetValue(CInt((0))).ToString())
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbTableNo.Text, "", TextCompare:=False) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please select table no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.cmbTableNo.Focus()
                Return
            End If

            For Each control As CButtonLib.CButton In Me.pnlTables.Controls
                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Text, Me.cmbTableNo.Text, TextCompare:=False) = 0 Then
                    Call System.Windows.Forms.MessageBox.Show("Same table no. is already added", "Selection Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    Return
                End If
            Next

            Dim cbutton As CButtonLib.CButton = New CButtonLib.CButton()
            Dim location As System.Drawing.Point = New System.Drawing.Point(50, 50)
            cbutton.Location = location
            Dim size As System.Drawing.Size = New System.Drawing.Size(150, 100)
            cbutton.Size = size
            cbutton.Text = Me.cmbTableNo.Text
            cbutton.ForeColor = System.Drawing.Color.Black
            cbutton.BackColor = System.Drawing.Color.White
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbShape.Text, "Ellipse", TextCompare:=False) = 0 Then
                Me.Cshape = CButtonLib.CButton.eShape.Ellipse
            ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbShape.Text, "Rectangle", TextCompare:=False) = 0 Then
                Me.Cshape = CButtonLib.CButton.eShape.Rectangle
                cbutton.Corners.All = 5
                cbutton.Corners.LowerLeft = 5
                cbutton.Corners.LowerRight = 5
                cbutton.Corners.UpperLeft = 5
                cbutton.Corners.UpperRight = 5
            ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbShape.Text, "Triangle Up", TextCompare:=False) = 0 Then
                Me.Cshape = CButtonLib.CButton.eShape.TriangleUp
            ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbShape.Text, "Triangle Down", TextCompare:=False) = 0 Then
                Me.Cshape = CButtonLib.CButton.eShape.TriangleDown
            ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbShape.Text, "Triangle Left", TextCompare:=False) = 0 Then
                Me.Cshape = CButtonLib.CButton.eShape.TriangleLeft
            ElseIf Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbShape.Text, "Triangle Right", TextCompare:=False) = 0 Then
                Me.Cshape = CButtonLib.CButton.eShape.TriangleRight
            End If

            cbutton.Shape = CType(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Me.Cshape), CButtonLib.CButton.eShape)
            cbutton.Font = New System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.pnlTables.Controls.Add(cbutton)
            AddHandler cbutton.MouseDown, AddressOf Me.btn_MouseDown
            AddHandler cbutton.MouseMove, AddressOf Me.btn_MouseMove
            AddHandler cbutton.MouseUp, AddressOf Me.btn_MouseUp
        End Sub

        Public Sub GetData()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select TableLayout.TableNo,Lx,Ly,FontSize,Px,Py,RTRIM(Shape) from TableLayout,R_Table where TableLayout.TableNo=R_Table.TableNo and FloorNo=@d1 order by 1")
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.cmbFloorNo.Text)
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                Me.pnlTables.Controls.Clear()
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                While RestaurantPOS14.ModClasses.rdr.Read()
                    Dim cbutton As CButtonLib.CButton = New CButtonLib.CButton()
                    Dim size As System.Drawing.Size = New System.Drawing.Size(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(4)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(5)))
                    cbutton.Size = size
                    Dim location As System.Drawing.Point = New System.Drawing.Point(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(1)), Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(RestaurantPOS14.ModClasses.rdr.GetValue(2)))
                    cbutton.Location = location
                    If Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(6), 0, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.Ellipse
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(6), 1, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.Rectangle
                        cbutton.Corners.All = 5
                        cbutton.Corners.LowerLeft = 5
                        cbutton.Corners.LowerRight = 5
                        cbutton.Corners.UpperLeft = 5
                        cbutton.Corners.UpperRight = 5
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(6), 2, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleUp
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(6), 3, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleDown
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(6), 4, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleLeft
                    ElseIf Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(RestaurantPOS14.ModClasses.rdr.GetValue(6), 5, TextCompare:=False) Then
                        Me.Cshape = CButtonLib.CButton.eShape.TriangleRight
                    End If

                    cbutton.Shape = CType(Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Me.Cshape), CButtonLib.CButton.eShape)
                    cbutton.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(RestaurantPOS14.ModClasses.rdr.GetValue(0))
                    cbutton.Font = New System.Drawing.Font("Segoe UI Semibold", Microsoft.VisualBasic.CompilerServices.Conversions.ToSingle(RestaurantPOS14.ModClasses.rdr.GetValue(3)), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
                    cbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    cbutton.ForeColor = System.Drawing.Color.Black
                    cbutton.BackColor = System.Drawing.Color.White
                    Me.pnlTables.Controls.Add(cbutton)
                    AddHandler cbutton.MouseDown, AddressOf Me.btn_MouseDown
                    AddHandler cbutton.MouseMove, AddressOf Me.btn_MouseMove
                    AddHandler cbutton.MouseUp, AddressOf Me.btn_MouseUp
                End While

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Form1_Load(sender As Object, e As System.EventArgs)
            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Settings") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsDeleteAllowed(Me.lblUser.Text, "Settings") Then
                Me.btnDelete.Enabled = True
            Else
                Me.btnDelete.Enabled = False
            End If

            Me.fillFloorNo()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            Try
                For Each cbutton As CButtonLib.CButton In Me.pnlTables.Controls
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                    RestaurantPOS14.ModClasses.con.Open()
                    RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select TableNo from TableLayout where TableNo=@d1")
                    RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", cbutton.Text)
                    RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                    RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                    If RestaurantPOS14.ModClasses.rdr.Read() Then
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Update TableLayout set Lx=@d2,Ly=@d3,FontSize=@d4,Px=@d5,Py=@d6,Shape=@d7 where TableNo=@d1")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", cbutton.Text)
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(cbutton.Location.X))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(cbutton.Location.Y))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(cbutton.Font.Size))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(cbutton.Size.Width))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(cbutton.Size.Height))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Microsoft.VisualBasic.Conversion.Val(cbutton.Shape))
                        RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                        RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        RestaurantPOS14.ModClasses.con.Close()
                    Else
                        RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                        RestaurantPOS14.ModClasses.con.Open()
                        RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into TableLayout(TableNo,Lx,Ly,FontSize,Px,Py,Shape) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7)")
                        RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", cbutton.Text)
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Microsoft.VisualBasic.Conversion.Val(cbutton.Location.X))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Microsoft.VisualBasic.Conversion.Val(cbutton.Location.Y))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Microsoft.VisualBasic.Conversion.Val(cbutton.Font.Size))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Microsoft.VisualBasic.Conversion.Val(cbutton.Size.Width))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Microsoft.VisualBasic.Conversion.Val(cbutton.Size.Height))
                        RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Microsoft.VisualBasic.Conversion.Val(cbutton.Shape))
                        RestaurantPOS14.ModClasses.cmd.CommandTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                        RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                        RestaurantPOS14.ModClasses.con.Close()
                    End If
                Next

                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Layout Data", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.Reset()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Public Sub DeleteRecord()
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("Delete from TableLayout")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            RestaurantPOS14.ModClasses.cmd.ExecuteReader()
            RestaurantPOS14.ModClasses.con.Close()
            Me.pnlTables.Controls.Clear()
            Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Layout Data", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
            Me.Reset()
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As System.EventArgs)
            Try
                If System.Windows.Forms.MessageBox.Show("Do you really want to delete all records?", "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation) = System.Windows.Forms.DialogResult.Yes Then
                    Me.DeleteRecord()
                End If
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btn_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Me.acControl = TryCast(sender, System.Windows.Forms.Control)
            Me.previousLocation = e.Location
            MyBase.Cursor = System.Windows.Forms.Cursors.Hand
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                Call RestaurantPOS14.My.MyProject.Forms.frmDelete.ShowDialog()
            End If

            Dim resizeController As Trestan.TCResize = New Trestan.TCResize(Me.acControl)
        End Sub

        Private Sub btn_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            Me.acControl = Nothing
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
        End Sub

        Private Sub btn_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
            If Me.acControl IsNot Nothing Then
                Dim location As System.Drawing.Point = Me.acControl.Location
                location.Offset(e.Location.X - Me.previousLocation.X, e.Location.Y - Me.previousLocation.Y)
                Me.acControl.Location = location
            End If
        End Sub

        Public Sub Reset()
            Me.cmbFloorNo.SelectedIndex = -1
            Me.cmbTableNo.SelectedIndex = -1
            Me.cmbTableNo.Enabled = False
            Me.cmbShape.SelectedIndex = 1
        End Sub

        Private Sub cmbFloorNo_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Me.GetData()
            Me.fillTableNo()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmTableLayoutSettings))
            Me.Label1 = New System.Windows.Forms.Label()
            Me.cmbTableNo = New System.Windows.Forms.ComboBox()
            Me.btnCreateTable = New System.Windows.Forms.Button()
            Me.pnlTables = New System.Windows.Forms.Panel()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.cmbFloorNo = New System.Windows.Forms.ComboBox()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.cmbShape = New System.Windows.Forms.ComboBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.pnlTables.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.Label1
            Dim location As System.Drawing.Point = New System.Drawing.Point(134, 5)
            label.Location = location
            Me.Label1.Name = "Label1"
            Dim label2 As System.Windows.Forms.Label = Me.Label1
            Dim size As System.Drawing.Size = New System.Drawing.Size(57, 15)
            label2.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Table No."
            Me.cmbTableNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbTableNo.Enabled = False
            Me.cmbTableNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbTableNo.FormattingEnabled = True
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbTableNo
            location = New System.Drawing.Point(137, 23)
            comboBox.Location = location
            Me.cmbTableNo.Name = "cmbTableNo"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbTableNo
            size = New System.Drawing.Size(121, 28)
            comboBox2.Size = size
            Me.cmbTableNo.TabIndex = 1
            Dim button As System.Windows.Forms.Button = Me.btnCreateTable
            location = New System.Drawing.Point(406, 12)
            button.Location = location
            Me.btnCreateTable.Name = "btnCreateTable"
            Dim button2 As System.Windows.Forms.Button = Me.btnCreateTable
            size = New System.Drawing.Size(105, 41)
            button2.Size = size
            Me.btnCreateTable.TabIndex = 3
            Me.btnCreateTable.Text = "Create Table"
            Me.btnCreateTable.UseVisualStyleBackColor = True
            Me.pnlTables.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            Me.pnlTables.BackColor = System.Drawing.SystemColors.Info
            Me.pnlTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTables.Controls.Add(Me.lblUser)
            Dim panel As System.Windows.Forms.Panel = Me.pnlTables
            location = New System.Drawing.Point(2, 57)
            panel.Location = location
            Me.pnlTables.Name = "pnlTables"
            Dim panel2 As System.Windows.Forms.Panel = Me.pnlTables
            size = New System.Drawing.Size(864, 370)
            panel2.Size = size
            Me.pnlTables.TabIndex = 7
            Me.lblUser.AutoSize = True
            Dim label3 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(412, 178)
            label3.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label4 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label4.Size = size
            Me.lblUser.TabIndex = 44
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(656, 9)
            button3.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button4 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(104, 40)
            button4.Size = size
            Me.btnDelete.TabIndex = 5
            Me.btnDelete.Text = "Delete All"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(560, 9)
            button5.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button6 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(90, 41)
            button6.Size = size
            Me.btnSave.TabIndex = 4
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label5 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(7, 5)
            label5.Location = location
            Me.Label2.Name = "Label2"
            Dim label6 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(56, 15)
            label6.Size = size
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "Floor No."
            Me.cmbFloorNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbFloorNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbFloorNo.FormattingEnabled = True
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbFloorNo
            location = New System.Drawing.Point(10, 23)
            comboBox3.Location = location
            Me.cmbFloorNo.Name = "cmbFloorNo"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbFloorNo
            size = New System.Drawing.Size(121, 28)
            comboBox4.Size = size
            Me.cmbFloorNo.TabIndex = 0
            Me.btnReset.BackColor = System.Drawing.SystemColors.Control
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnReset.Image = CType(componentResourceManager.GetObject("btnReset.Image"), System.Drawing.Image)
            Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnReset
            location = New System.Drawing.Point(766, 9)
            button7.Location = location
            Me.btnReset.Name = "btnReset"
            Dim button8 As System.Windows.Forms.Button = Me.btnReset
            size = New System.Drawing.Size(90, 40)
            button8.Size = size
            Me.btnReset.TabIndex = 6
            Me.btnReset.Text = "Reset"
            Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReset.UseVisualStyleBackColor = False
            Me.cmbShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbShape.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.cmbShape.FormattingEnabled = True
            Me.cmbShape.Items.AddRange(New Object(5) {"Ellipse", "Rectangle", "Triangle Up", "Triangle Down", "Triangle Left", "Triangle Right"})
            Dim comboBox5 As System.Windows.Forms.ComboBox = Me.cmbShape
            location = New System.Drawing.Point(264, 23)
            comboBox5.Location = location
            Me.cmbShape.Name = "cmbShape"
            Dim comboBox6 As System.Windows.Forms.ComboBox = Me.cmbShape
            size = New System.Drawing.Size(136, 28)
            comboBox6.Size = size
            Me.cmbShape.TabIndex = 2
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(261, 5)
            label7.Location = location
            Me.Label3.Name = "Label3"
            Dim label8 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(71, 15)
            label8.Size = size
            Me.Label3.TabIndex = 1
            Me.Label3.Text = "Table Shape"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            size = New System.Drawing.Size(866, 427)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Label3)
            MyBase.Controls.Add(Me.cmbShape)
            MyBase.Controls.Add(Me.btnReset)
            MyBase.Controls.Add(Me.cmbFloorNo)
            MyBase.Controls.Add(Me.Label2)
            MyBase.Controls.Add(Me.btnDelete)
            MyBase.Controls.Add(Me.pnlTables)
            MyBase.Controls.Add(Me.btnSave)
            MyBase.Controls.Add(Me.btnCreateTable)
            MyBase.Controls.Add(Me.cmbTableNo)
            MyBase.Controls.Add(Me.Label1)
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmTableLayoutSettings"
            Me.Text = "Table Layout Setup"
            MyBase.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.pnlTables.ResumeLayout(False)
            Me.pnlTables.PerformLayout()
            MyBase.ResumeLayout(False)
            MyBase.PerformLayout()
        End Sub
    End Class
End Namespace
