Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmEmployeeRegistration
        Inherits System.Windows.Forms.Form

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("OpenFileDialog1")>
        Private _OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtCity")>
        Private _txtCity As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtAddress")>
        Private _txtAddress As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmployeeID")>
        Private _txtEmployeeID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmployeeName")>
        Private _txtEmployeeName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("dtpDateOfJoining")>
        Private _dtpDateOfJoining As System.Windows.Forms.DateTimePicker

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtContactNo")>
        Private _txtContactNo As System.Windows.Forms.MaskedTextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label10")>
        Private _Label10 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label9")>
        Private _Label9 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label14")>
        Private _Label14 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label17")>
        Private _Label17 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label18")>
        Private _Label18 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label19")>
        Private _Label19 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmail")>
        Private _txtEmail As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Picture")>
        Private _Picture As System.Windows.Forms.PictureBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Browse")>
        Private _Browse As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("BRemove")>
        Private _BRemove As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtID")>
        Private _txtID As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblUser")>
        Private _lblUser As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel3")>
        Private _Panel3 As System.Windows.Forms.Panel

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button1")>
        Private _Button1 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDelete")>
        Private _btnDelete As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnUpdate")>
        Private _btnUpdate As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSave")>
        Private _btnSave As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Button5")>
        Private _Button5 As System.Windows.Forms.Button

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtEmpName")>
        Private _txtEmpName As System.Windows.Forms.TextBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label8")>
        Private _Label8 As System.Windows.Forms.Label

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("chkActive")>
        Private _chkActive As System.Windows.Forms.CheckBox

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label

        Private Photoname As String

        Private IsImageChanged As Boolean

        Private st1 As String

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

        Friend Overridable Property txtCity As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtCity
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtCity = value
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

        Friend Overridable Property txtAddress As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtAddress
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtAddress = value
            End Set
        End Property

        Friend Overridable Property txtEmployeeID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmployeeID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEmployeeID = value
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
                Me._txtEmployeeName = value
            End Set
        End Property

        Friend Overridable Property dtpDateOfJoining As System.Windows.Forms.DateTimePicker
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._dtpDateOfJoining
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.DateTimePicker)
                Me._dtpDateOfJoining = value
            End Set
        End Property

        Friend Overridable Property txtContactNo As System.Windows.Forms.MaskedTextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtContactNo
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.MaskedTextBox)
                Me._txtContactNo = value
            End Set
        End Property

        Friend Overridable Property Label10 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label10
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label10 = value
            End Set
        End Property

        Friend Overridable Property Label9 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label9
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label9 = value
            End Set
        End Property

        Friend Overridable Property Label14 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label14
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label14 = value
            End Set
        End Property

        Friend Overridable Property Label17 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label17
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label17 = value
            End Set
        End Property

        Friend Overridable Property Label18 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label18
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label18 = value
            End Set
        End Property

        Friend Overridable Property Label19 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label19
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label19 = value
            End Set
        End Property

        Friend Overridable Property txtEmail As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmail
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEmail = value
            End Set
        End Property

        Public Overridable Property Picture As System.Windows.Forms.PictureBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Picture
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.PictureBox)
                Me._Picture = value
            End Set
        End Property

        Friend Overridable Property Browse As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Browse
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.Browse_Click
                If Me._Browse IsNot Nothing Then
                    RemoveHandler Me._Browse.Click, value2
                End If

                Me._Browse = value
                If Me._Browse IsNot Nothing Then
                    AddHandler Me._Browse.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property BRemove As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._BRemove
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.BRemove_Click
                If Me._BRemove IsNot Nothing Then
                    RemoveHandler Me._BRemove.Click, value2
                End If

                Me._BRemove = value
                If Me._BRemove IsNot Nothing Then
                    AddHandler Me._BRemove.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtID As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtID
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtID = value
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

        Friend Overridable Property Button1 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button1
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnGetData_Click
                If Me._Button1 IsNot Nothing Then
                    RemoveHandler Me._Button1.Click, value2
                End If

                Me._Button1 = value
                If Me._Button1 IsNot Nothing Then
                    AddHandler Me._Button1.Click, value2
                End If
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

        Friend Overridable Property Button5 As System.Windows.Forms.Button
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Button5
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Button)
                Dim value2 As System.EventHandler = AddressOf Me.btnNew_Click
                If Me._Button5 IsNot Nothing Then
                    RemoveHandler Me._Button5.Click, value2
                End If

                Me._Button5 = value
                If Me._Button5 IsNot Nothing Then
                    AddHandler Me._Button5.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtEmpName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtEmpName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtEmpName = value
            End Set
        End Property

        Friend Overridable Property Label8 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label8
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label8 = value
            End Set
        End Property

        Friend Overridable Property chkActive As System.Windows.Forms.CheckBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._chkActive
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.CheckBox)
                Me._chkActive = value
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

        Public Sub New()
            Call RestaurantPOS14.frmEmployeeRegistration.__ENCAddToList(Me)
            Me.Photoname = ""
            Me.IsImageChanged = False
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmEmployeeRegistration.__ENCList
                If RestaurantPOS14.frmEmployeeRegistration.__ENCList.Count = RestaurantPOS14.frmEmployeeRegistration.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmEmployeeRegistration.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmEmployeeRegistration.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmEmployeeRegistration.__ENCList(num) = RestaurantPOS14.frmEmployeeRegistration.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmEmployeeRegistration.__ENCList.RemoveRange(num, RestaurantPOS14.frmEmployeeRegistration.__ENCList.Count - num)
                    RestaurantPOS14.frmEmployeeRegistration.__ENCList.Capacity = RestaurantPOS14.frmEmployeeRegistration.__ENCList.Count
                End If

                Call RestaurantPOS14.frmEmployeeRegistration.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        Public Sub Reset()
            Me.txtEmployeeID.Text = ""
            Me.txtEmployeeName.Text = ""
            Me.txtCity.Text = ""
            Me.txtAddress.Text = ""
            Me.txtContactNo.Text = ""
            Me.txtEmail.Text = ""
            Me.dtpDateOfJoining.Text = Microsoft.VisualBasic.CompilerServices.Conversions.ToString(Microsoft.VisualBasic.DateAndTime.Today)
            Me.btnUpdate.Enabled = False
            Me.btnDelete.Enabled = False
            Me.chkActive.Checked = True
            If RestaurantPOS14.ModFunc.IsViewAllowed(Me.lblUser.Text, "Home Delivery") Then
                Me.Button1.Enabled = True
            Else
                Me.Button1.Enabled = False
            End If

            If RestaurantPOS14.ModFunc.IsSaveAllowed(Me.lblUser.Text, "Home Delivery") Then
                Me.btnSave.Enabled = True
            Else
                Me.btnSave.Enabled = False
            End If

            Me.Picture.Image = RestaurantPOS14.My.Resources.Resources.photo
            Me.auto()
            Me.txtEmployeeName.Focus()
        End Sub

        Private Sub auto()
            RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
            RestaurantPOS14.ModClasses.con.Open()
            RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("SELECT MAX(EmpID) FROM EmployeeRegistration")
            RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
            If Microsoft.VisualBasic.Information.IsDBNull(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(RestaurantPOS14.ModClasses.cmd.ExecuteScalar())) Then
                Dim num As Integer = 1
                Me.txtID.Text = num.ToString()
                Me.txtEmployeeID.Text = "EMP-" & num.ToString()
            Else
                Dim num2 As Integer = Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(RestaurantPOS14.ModClasses.cmd.ExecuteScalar(), 1))
                Me.txtID.Text = num2.ToString()
                Me.txtEmployeeID.Text = "EMP-" & num2.ToString()
            End If

            RestaurantPOS14.ModClasses.cmd.Dispose()
            RestaurantPOS14.ModClasses.con.Close()
            RestaurantPOS14.ModClasses.con.Dispose()
        End Sub

        Private Sub btnNew_Click(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtEmployeeName.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter employee name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtEmployeeName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtAddress.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter address", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddress.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtCity.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter city", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCity.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtContactNo.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter contact no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            Try
                If Me.chkActive.Checked Then
                    Me.st1 = "Yes"
                Else
                    Me.st1 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("insert into employeeregistration(Empid,employeeid,employeename,address,City,contactno,email,dateofjoining,photo,Active) VALUES (" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID") & ",@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,'" & Me.st1 & "')")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtEmployeeID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtEmployeeName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d3", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtCity.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtEmail.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.dtpDateOfJoining.Value.[Date])
                Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
                Call New System.Drawing.Bitmap(CType((Me.Picture.Image), System.Drawing.Image)).Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim buffer As Byte() = memoryStream.GetBuffer()
                Dim sqlParameter As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter("@d8", System.Data.SqlDbType.Image)
                sqlParameter.Value = buffer
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(sqlParameter)
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "added the new delivery person '" & Me.txtEmployeeName.Text & "' having ID='" & Me.txtEmployeeID.Text & "'"
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully saved", "Employee Profile", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnSave.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub Browse_Click(sender As Object, e As System.EventArgs)
            Try
                Dim openFileDialog As System.Windows.Forms.OpenFileDialog = Me.OpenFileDialog1
                openFileDialog.Filter = "Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;"
                openFileDialog.FilterIndex = 4
                Me.OpenFileDialog1.FileName = ""
                If Me.OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Me.Picture.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog1.FileName)
                End If
            Catch ex As System.Exception
                Call Microsoft.VisualBasic.Interaction.MsgBox(ex.ToString())
            End Try
        End Sub

        Private Sub BRemove_Click(sender As Object, e As System.EventArgs)
            Me.Picture.Image = RestaurantPOS14.My.Resources.Resources.photo
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

        Public Sub DeleteRecord()
            Try
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("select EmployeeRegistration.EmpID from EmployeeRegistration,RestaurantPOS_BillingInfoHD where EmployeeRegistration.EmpID=RestaurantPOS_BillingInfoHD.Employee_ID and EmployeeRegistration.EmpID=@d1")
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Microsoft.VisualBasic.Conversion.Val(Me.txtID.Text))
                RestaurantPOS14.ModClasses.rdr = RestaurantPOS14.ModClasses.cmd.ExecuteReader()
                If RestaurantPOS14.ModClasses.rdr.Read() Then
                    Call System.Windows.Forms.MessageBox.Show("Unable to delete..Already in use in Restaurant POS", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
                    If RestaurantPOS14.ModClasses.rdr IsNot Nothing Then
                        RestaurantPOS14.ModClasses.rdr.Close()
                    End If

                    Return
                End If

                RestaurantPOS14.ModClasses.con.Close()
                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("delete from EmployeeRegistration where EmpID=" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID"))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                If RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery() > 0 Then
                    Dim st As String = "deleted the record of employee '" & Me.txtEmployeeName.Text & "' having ID '" & Me.txtEmployeeID.Text & "'"
                    RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                    Call System.Windows.Forms.MessageBox.Show("Successfully deleted", "Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                Else
                    Call System.Windows.Forms.MessageBox.Show("No record found", "Sorry", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    Me.Reset()
                End If

                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnUpdate_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtEmployeeName.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter employee name", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtEmployeeName.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtAddress.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter address", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtAddress.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtCity.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter city", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtCity.Focus()
                Return
            End If

            If Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Trim(Me.txtContactNo.Text)) = 0 Then
                Call System.Windows.Forms.MessageBox.Show("Please enter contact no.", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation)
                Me.txtContactNo.Focus()
                Return
            End If

            Try
                If Me.chkActive.Checked Then
                    Me.st1 = "Yes"
                Else
                    Me.st1 = "No"
                End If

                RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection(RestaurantPOS14.ConnectionString.cs)
                RestaurantPOS14.ModClasses.con.Open()
                RestaurantPOS14.ModClasses.cmd = New System.Data.SqlClient.SqlCommand("update employeeregistration set employeeid=@d1,employeename=@d2,address=@d4,City=@d5,contactno=@d6,email=@d7,dateofjoining=@d11,photo=@d14,Active='" & Me.st1 & "' where Empid=" & RestaurantPOS14.Security.SqlInput.RequireInteger(Me.txtID.Text, "Record ID"))
                RestaurantPOS14.ModClasses.cmd.Connection = RestaurantPOS14.ModClasses.con
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d1", Me.txtEmployeeID.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d2", Me.txtEmployeeName.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d4", Me.txtAddress.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d5", Me.txtCity.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d6", Me.txtContactNo.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d7", Me.txtEmail.Text)
                RestaurantPOS14.ModClasses.cmd.Parameters.AddWithValue("@d11", Me.dtpDateOfJoining.Value.[Date])
                Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
                Call New System.Drawing.Bitmap(CType((Me.Picture.Image), System.Drawing.Image)).Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim buffer As Byte() = memoryStream.GetBuffer()
                Dim sqlParameter As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter("@d14", System.Data.SqlDbType.Image)
                sqlParameter.Value = buffer
                RestaurantPOS14.ModClasses.cmd.Parameters.Add(sqlParameter)
                RestaurantPOS14.ModClasses.cmd.ExecuteNonQuery()
                RestaurantPOS14.ModClasses.con.Close()
                Dim st As String = "updated the record of employee '" & Me.txtEmployeeName.Text & "' having ID '" & Me.txtEmployeeID.Text & "'"""
                RestaurantPOS14.ModFunc.LogFunc(Me.lblUser.Text, st)
                Call System.Windows.Forms.MessageBox.Show("Successfully updated", "Employee Profile", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                Me.btnUpdate.Enabled = False
                RestaurantPOS14.ModClasses.con.Close()
            Catch ex As System.Exception
                Call System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "POS", TextCompare:=False) = 0 Then
                Call RestaurantPOS14.My.MyProject.Forms.frmDeliveryPersonRecord.GetData()
            End If

            MyBase.Close()
        End Sub

        Private Sub btnGetData_Click(sender As Object, e As System.EventArgs)
            RestaurantPOS14.My.MyProject.Forms.frmEmployeesRecord.lblSet.Text = "Employee"
            RestaurantPOS14.My.MyProject.Forms.frmEmployeesRecord.lblUser.Text = Me.lblUser.Text
            Call RestaurantPOS14.My.MyProject.Forms.frmEmployeesRecord.Reset()
            Call RestaurantPOS14.My.MyProject.Forms.frmEmployeesRecord.ShowDialog()
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
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmEmployeeRegistration))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.chkActive = New System.Windows.Forms.CheckBox()
            Me.lblUser = New System.Windows.Forms.Label()
            Me.Picture = New System.Windows.Forms.PictureBox()
            Me.BRemove = New System.Windows.Forms.Button()
            Me.txtID = New System.Windows.Forms.TextBox()
            Me.Browse = New System.Windows.Forms.Button()
            Me.txtEmail = New System.Windows.Forms.TextBox()
            Me.txtAddress = New System.Windows.Forms.TextBox()
            Me.txtEmployeeID = New System.Windows.Forms.TextBox()
            Me.txtEmployeeName = New System.Windows.Forms.TextBox()
            Me.dtpDateOfJoining = New System.Windows.Forms.DateTimePicker()
            Me.txtContactNo = New System.Windows.Forms.MaskedTextBox()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.txtCity = New System.Windows.Forms.TextBox()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnUpdate = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.Button5 = New System.Windows.Forms.Button()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.txtEmpName = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Dim label As System.Windows.Forms.Label = New System.Windows.Forms.Label()
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            label.AutoSize = True
            label.ForeColor = System.Drawing.Color.Black
            Dim location As System.Drawing.Point = New System.Drawing.Point(214, 173)
            label.Location = location
            Dim margin As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
            label.Margin = margin
            label.Name = "Label4"
            Dim size As System.Drawing.Size = New System.Drawing.Size(30, 13)
            label.Size = size
            label.TabIndex = 274
            label.Text = "City :"
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.lblSet)
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Panel3)
            Me.Panel1.Controls.Add(Me.btnClose)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            location = New System.Drawing.Point(4, 4)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            size = New System.Drawing.Size(662, 376)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.lblSet.AutoSize = True
            Dim label2 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(314, 181)
            label2.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label3 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(33, 13)
            label3.Size = size
            Me.lblSet.TabIndex = 316
            Me.lblSet.Text = "lblSet"
            Me.lblSet.Visible = False
            Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
            Me.GroupBox1.Controls.Add(Me.Label8)
            Me.GroupBox1.Controls.Add(Me.chkActive)
            Me.GroupBox1.Controls.Add(Me.lblUser)
            Me.GroupBox1.Controls.Add(Me.Picture)
            Me.GroupBox1.Controls.Add(Me.BRemove)
            Me.GroupBox1.Controls.Add(Me.txtID)
            Me.GroupBox1.Controls.Add(Me.Browse)
            Me.GroupBox1.Controls.Add(Me.txtEmail)
            Me.GroupBox1.Controls.Add(Me.txtAddress)
            Me.GroupBox1.Controls.Add(Me.txtEmployeeID)
            Me.GroupBox1.Controls.Add(Me.txtEmployeeName)
            Me.GroupBox1.Controls.Add(Me.dtpDateOfJoining)
            Me.GroupBox1.Controls.Add(Me.txtContactNo)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.Label9)
            Me.GroupBox1.Controls.Add(Me.Label14)
            Me.GroupBox1.Controls.Add(label)
            Me.GroupBox1.Controls.Add(Me.txtCity)
            Me.GroupBox1.Controls.Add(Me.Label17)
            Me.GroupBox1.Controls.Add(Me.Label18)
            Me.GroupBox1.Controls.Add(Me.Label19)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(4, 40)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(543, 330)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Employee Details"
            Me.Label8.AutoSize = True
            Dim label4 As System.Windows.Forms.Label = Me.Label8
            location = New System.Drawing.Point(214, 276)
            label4.Location = location
            Me.Label8.Name = "Label8"
            Dim label5 As System.Windows.Forms.Label = Me.Label8
            size = New System.Drawing.Size(43, 13)
            label5.Size = size
            Me.Label8.TabIndex = 295
            Me.Label8.Text = "Status :"
            Me.chkActive.AutoSize = True
            Dim checkBox As System.Windows.Forms.CheckBox = Me.chkActive
            location = New System.Drawing.Point(311, 276)
            checkBox.Location = location
            Me.chkActive.Name = "chkActive"
            Dim checkBox2 As System.Windows.Forms.CheckBox = Me.chkActive
            size = New System.Drawing.Size(56, 17)
            checkBox2.Size = size
            Me.chkActive.TabIndex = 7
            Me.chkActive.Text = "Active"
            Me.chkActive.UseVisualStyleBackColor = True
            Me.lblUser.AutoSize = True
            Dim label6 As System.Windows.Forms.Label = Me.lblUser
            location = New System.Drawing.Point(475, 25)
            label6.Location = location
            Me.lblUser.Name = "lblUser"
            Dim label7 As System.Windows.Forms.Label = Me.lblUser
            size = New System.Drawing.Size(39, 13)
            label7.Size = size
            Me.lblUser.TabIndex = 293
            Me.lblUser.Text = "Label8"
            Me.lblUser.Visible = False
            Me.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Picture.Image = RestaurantPOS14.My.Resources.Resources.photo
            Dim picture As System.Windows.Forms.PictureBox = Me.Picture
            location = New System.Drawing.Point(11, 23)
            picture.Location = location
            Me.Picture.Name = "Picture"
            Dim picture2 As System.Windows.Forms.PictureBox = Me.Picture
            size = New System.Drawing.Size(186, 193)
            picture2.Size = size
            Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Picture.TabIndex = 291
            Me.Picture.TabStop = False
            Me.BRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.BRemove.ForeColor = System.Drawing.Color.Black
            Me.BRemove.Image = CType(componentResourceManager.GetObject("BRemove.Image"), System.Drawing.Image)
            Me.BRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim bRemove As System.Windows.Forms.Button = Me.BRemove
            location = New System.Drawing.Point(108, 224)
            bRemove.Location = location
            Me.BRemove.Name = "BRemove"
            Dim bRemove2 As System.Windows.Forms.Button = Me.BRemove
            size = New System.Drawing.Size(89, 35)
            bRemove2.Size = size
            Me.BRemove.TabIndex = 9
            Me.BRemove.Text = "Remove"
            Me.BRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.BRemove.UseVisualStyleBackColor = True
            Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox As System.Windows.Forms.TextBox = Me.txtID
            location = New System.Drawing.Point(392, 21)
            textBox.Location = location
            Me.txtID.Name = "txtID"
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtID
            size = New System.Drawing.Size(71, 20)
            textBox2.Size = size
            Me.txtID.TabIndex = 292
            Me.txtID.Visible = False
            Me.Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Browse.ForeColor = System.Drawing.Color.Black
            Me.Browse.Image = CType(componentResourceManager.GetObject("Browse.Image"), System.Drawing.Image)
            Me.Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim browse As System.Windows.Forms.Button = Me.Browse
            location = New System.Drawing.Point(11, 224)
            browse.Location = location
            Me.Browse.Name = "Browse"
            Dim browse2 As System.Windows.Forms.Button = Me.Browse
            size = New System.Drawing.Size(93, 35)
            browse2.Size = size
            Me.Browse.TabIndex = 8
            Me.Browse.Text = "Browse..."
            Me.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Browse.UseVisualStyleBackColor = True
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtEmail
            location = New System.Drawing.Point(311, 224)
            textBox3.Location = location
            Me.txtEmail.Name = "txtEmail"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtEmail
            size = New System.Drawing.Size(220, 20)
            textBox4.Size = size
            Me.txtEmail.TabIndex = 5
            Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox5 As System.Windows.Forms.TextBox = Me.txtAddress
            location = New System.Drawing.Point(311, 74)
            textBox5.Location = location
            Me.txtAddress.Multiline = True
            Me.txtAddress.Name = "txtAddress"
            Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Dim textBox6 As System.Windows.Forms.TextBox = Me.txtAddress
            size = New System.Drawing.Size(220, 93)
            textBox6.Size = size
            Me.txtAddress.TabIndex = 2
            Me.txtEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox7 As System.Windows.Forms.TextBox = Me.txtEmployeeID
            location = New System.Drawing.Point(311, 21)
            textBox7.Location = location
            Me.txtEmployeeID.Name = "txtEmployeeID"
            Me.txtEmployeeID.[ReadOnly] = True
            Dim textBox8 As System.Windows.Forms.TextBox = Me.txtEmployeeID
            size = New System.Drawing.Size(60, 20)
            textBox8.Size = size
            Me.txtEmployeeID.TabIndex = 0
            Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox9 As System.Windows.Forms.TextBox = Me.txtEmployeeName
            location = New System.Drawing.Point(311, 48)
            textBox9.Location = location
            Me.txtEmployeeName.Name = "txtEmployeeName"
            Dim textBox10 As System.Windows.Forms.TextBox = Me.txtEmployeeName
            size = New System.Drawing.Size(220, 20)
            textBox10.Size = size
            Me.txtEmployeeName.TabIndex = 1
            Me.dtpDateOfJoining.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateOfJoining.CustomFormat = "dd/MM/yyyy"
            Me.dtpDateOfJoining.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.dtpDateOfJoining.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Dim dateTimePicker As System.Windows.Forms.DateTimePicker = Me.dtpDateOfJoining
            location = New System.Drawing.Point(311, 250)
            dateTimePicker.Location = location
            Me.dtpDateOfJoining.Name = "dtpDateOfJoining"
            Dim dateTimePicker2 As System.Windows.Forms.DateTimePicker = Me.dtpDateOfJoining
            size = New System.Drawing.Size(106, 20)
            dateTimePicker2.Size = size
            Me.dtpDateOfJoining.TabIndex = 6
            Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim maskedTextBox As System.Windows.Forms.MaskedTextBox = Me.txtContactNo
            location = New System.Drawing.Point(311, 198)
            maskedTextBox.Location = location
            Me.txtContactNo.Name = "txtContactNo"
            Dim maskedTextBox2 As System.Windows.Forms.MaskedTextBox = Me.txtContactNo
            size = New System.Drawing.Size(137, 20)
            maskedTextBox2.Size = size
            Me.txtContactNo.TabIndex = 4
            Me.Label10.AutoSize = True
            Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label8 As System.Windows.Forms.Label = Me.Label10
            location = New System.Drawing.Point(214, 224)
            label8.Location = location
            Me.Label10.Name = "Label10"
            Dim label9 As System.Windows.Forms.Label = Me.Label10
            size = New System.Drawing.Size(42, 13)
            label9.Size = size
            Me.Label10.TabIndex = 9
            Me.Label10.Text = "E-Mail :"
            Me.Label9.AutoSize = True
            Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label10 As System.Windows.Forms.Label = Me.Label9
            location = New System.Drawing.Point(214, 25)
            label10.Location = location
            Me.Label9.Name = "Label9"
            Dim label11 As System.Windows.Forms.Label = Me.Label9
            size = New System.Drawing.Size(73, 13)
            label11.Size = size
            Me.Label9.TabIndex = 8
            Me.Label9.Text = "Employee ID :"
            Me.Label14.AutoSize = True
            Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label12 As System.Windows.Forms.Label = Me.Label14
            location = New System.Drawing.Point(214, 250)
            label12.Location = location
            Me.Label14.Name = "Label14"
            Dim label13 As System.Windows.Forms.Label = Me.Label14
            size = New System.Drawing.Size(84, 13)
            label13.Size = size
            Me.Label14.TabIndex = 6
            Me.Label14.Text = "Date of Joining :"
            Dim textBox11 As System.Windows.Forms.TextBox = Me.txtCity
            location = New System.Drawing.Point(311, 173)
            textBox11.Location = location
            Me.txtCity.Name = "txtCity"
            Dim textBox12 As System.Windows.Forms.TextBox = Me.txtCity
            size = New System.Drawing.Size(220, 20)
            textBox12.Size = size
            Me.txtCity.TabIndex = 3
            Me.Label17.AutoSize = True
            Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label14 As System.Windows.Forms.Label = Me.Label17
            location = New System.Drawing.Point(214, 96)
            label14.Location = location
            Me.Label17.Name = "Label17"
            Dim label15 As System.Windows.Forms.Label = Me.Label17
            size = New System.Drawing.Size(51, 13)
            label15.Size = size
            Me.Label17.TabIndex = 3
            Me.Label17.Text = "Address :"
            Me.Label18.AutoSize = True
            Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label16 As System.Windows.Forms.Label = Me.Label18
            location = New System.Drawing.Point(214, 198)
            label16.Location = location
            Me.Label18.Name = "Label18"
            Dim label17 As System.Windows.Forms.Label = Me.Label18
            size = New System.Drawing.Size(70, 13)
            label17.Size = size
            Me.Label18.TabIndex = 2
            Me.Label18.Text = "Contact No. :"
            Me.Label19.AutoSize = True
            Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim label18 As System.Windows.Forms.Label = Me.Label19
            location = New System.Drawing.Point(214, 52)
            label18.Location = location
            Me.Label19.Name = "Label19"
            Dim label19 As System.Windows.Forms.Label = Me.Label19
            size = New System.Drawing.Size(90, 13)
            label19.Size = size
            Me.Label19.TabIndex = 1
            Me.Label19.Text = "Employee Name :"
            Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel3.Controls.Add(Me.Button1)
            Me.Panel3.Controls.Add(Me.btnDelete)
            Me.Panel3.Controls.Add(Me.btnUpdate)
            Me.Panel3.Controls.Add(Me.btnSave)
            Me.Panel3.Controls.Add(Me.Button5)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel3
            location = New System.Drawing.Point(553, 45)
            panel3.Location = location
            Me.Panel3.Name = "Panel3"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel3
            size = New System.Drawing.Size(103, 222)
            panel4.Size = size
            Me.Panel3.TabIndex = 1
            Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button1.Image = CType(componentResourceManager.GetObject("Button1.Image"), System.Drawing.Image)
            Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button As System.Windows.Forms.Button = Me.Button1
            location = New System.Drawing.Point(6, 173)
            button.Location = location
            Me.Button1.Name = "Button1"
            Dim button2 As System.Windows.Forms.Button = Me.Button1
            size = New System.Drawing.Size(89, 38)
            button2.Size = size
            Me.Button1.TabIndex = 4
            Me.Button1.Text = "Get Data"
            Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button1.UseVisualStyleBackColor = True
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDelete.Image = CType(componentResourceManager.GetObject("btnDelete.Image"), System.Drawing.Image)
            Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button3 As System.Windows.Forms.Button = Me.btnDelete
            location = New System.Drawing.Point(6, 132)
            button3.Location = location
            Me.btnDelete.Name = "btnDelete"
            Dim button4 As System.Windows.Forms.Button = Me.btnDelete
            size = New System.Drawing.Size(89, 35)
            button4.Size = size
            Me.btnDelete.TabIndex = 3
            Me.btnDelete.Text = "Delete"
            Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDelete.UseVisualStyleBackColor = True
            Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdate.Enabled = False
            Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnUpdate.Image = CType(componentResourceManager.GetObject("btnUpdate.Image"), System.Drawing.Image)
            Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button5 As System.Windows.Forms.Button = Me.btnUpdate
            location = New System.Drawing.Point(6, 91)
            button5.Location = location
            Me.btnUpdate.Name = "btnUpdate"
            Dim button6 As System.Windows.Forms.Button = Me.btnUpdate
            size = New System.Drawing.Size(89, 35)
            button6.Size = size
            Me.btnUpdate.TabIndex = 2
            Me.btnUpdate.Text = "Update"
            Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnUpdate.UseVisualStyleBackColor = True
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSave.Image = CType(componentResourceManager.GetObject("btnSave.Image"), System.Drawing.Image)
            Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button7 As System.Windows.Forms.Button = Me.btnSave
            location = New System.Drawing.Point(6, 50)
            button7.Location = location
            Me.btnSave.Name = "btnSave"
            Dim button8 As System.Windows.Forms.Button = Me.btnSave
            size = New System.Drawing.Size(89, 35)
            button8.Size = size
            Me.btnSave.TabIndex = 1
            Me.btnSave.Text = "Save"
            Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSave.UseVisualStyleBackColor = True
            Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.Button5.Image = CType(componentResourceManager.GetObject("Button5.Image"), System.Drawing.Image)
            Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button9 As System.Windows.Forms.Button = Me.Button5
            location = New System.Drawing.Point(6, 9)
            button9.Location = location
            Me.Button5.Name = "Button5"
            Dim button10 As System.Windows.Forms.Button = Me.Button5
            size = New System.Drawing.Size(89, 35)
            button10.Size = size
            Me.Button5.TabIndex = 0
            Me.Button5.Text = "New"
            Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Button5.UseVisualStyleBackColor = True
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Dim button11 As System.Windows.Forms.Button = Me.btnClose
            location = New System.Drawing.Point(582, 2)
            button11.Location = location
            Me.btnClose.Name = "btnClose"
            Dim button12 As System.Windows.Forms.Button = Me.btnClose
            size = New System.Drawing.Size(75, 40)
            button12.Size = size
            Me.btnClose.TabIndex = 5
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.UseVisualStyleBackColor = True
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.Controls.Add(Me.txtEmpName)
            Me.Panel2.Controls.Add(Me.Label1)
            Dim panel5 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(4, 4)
            panel5.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel6 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(572, 30)
            panel6.Size = size
            Me.Panel2.TabIndex = 0
            Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
            Dim textBox13 As System.Windows.Forms.TextBox = Me.txtEmpName
            location = New System.Drawing.Point(30, 7)
            textBox13.Location = location
            Me.txtEmpName.Name = "txtEmpName"
            Dim textBox14 As System.Windows.Forms.TextBox = Me.txtEmpName
            size = New System.Drawing.Size(30, 20)
            textBox14.Size = size
            Me.txtEmpName.TabIndex = 2
            Me.txtEmpName.Visible = False
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label20 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(194, 2)
            label20.Location = location
            Me.Label1.Name = "Label1"
            Dim label21 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(211, 24)
            label21.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Delivery Person Entry"
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(670, 383)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmEmployeeRegistration"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
