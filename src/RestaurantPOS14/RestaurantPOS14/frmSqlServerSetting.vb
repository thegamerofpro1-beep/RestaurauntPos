Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CButtonLib
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports RestaurantPOS14.My.Resources

Namespace RestaurantPOS14

    <Microsoft.VisualBasic.CompilerServices.DesignerGeneratedAttribute>
    Public Class frmSqlServerSetting
        Inherits System.Windows.Forms.Form
        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel1")>
        Private _Panel1 As System.Windows.Forms.Panel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Panel2")>
        Private _Panel2 As System.Windows.Forms.Panel
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label1")>
        Private _Label1 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnDemoDB")>
        Private _btnDemoDB As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("GroupBox1")>
        Private _GroupBox1 As System.Windows.Forms.GroupBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnClose")>
        Private _btnClose As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbServerName")>
        Private _cmbServerName As System.Windows.Forms.ComboBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtPassword")>
        Private _txtPassword As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("txtUserName")>
        Private _txtUserName As System.Windows.Forms.TextBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label3")>
        Private _Label3 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label2")>
        Private _Label2 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label4")>
        Private _Label4 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label5")>
        Private _Label5 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label7")>
        Private _Label7 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbAuthentication")>
        Private _cmbAuthentication As System.Windows.Forms.ComboBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer1")>
        Private _Timer1 As System.Windows.Forms.Timer
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("lblSet")>
        Private _lblSet As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnTestConnection")>
        Private _btnTestConnection As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer2")>
        Private _Timer2 As System.Windows.Forms.Timer
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnBlankDB")>
        Private _btnBlankDB As CButtonLib.CButton
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Label6")>
        Private _Label6 As System.Windows.Forms.Label
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("cmbInstallationType")>
        Private _cmbInstallationType As System.Windows.Forms.ComboBox
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer3")>
        Private _Timer3 As System.Windows.Forms.Timer
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("Timer4")>
        Private _Timer4 As System.Windows.Forms.Timer
        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("btnSearchServers")>
        Private _btnSearchServers As CButtonLib.CButton
        Private st As String
        Private SqlConnStr As String
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

        Friend Overridable Property btnDemoDB As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnDemoDB
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnSave_Click
                If Me._btnDemoDB IsNot Nothing Then
                    RemoveHandler Me._btnDemoDB.Click, value2
                End If

                Me._btnDemoDB = value
                If Me._btnDemoDB IsNot Nothing Then
                    AddHandler Me._btnDemoDB.Click, value2
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

        Friend Overridable Property btnClose As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnClose
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
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

        Friend Overridable Property cmbServerName As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbServerName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbServerName_SelectedIndexChanged
                If Me._cmbServerName IsNot Nothing Then
                    RemoveHandler Me._cmbServerName.SelectedIndexChanged, value2
                End If

                Me._cmbServerName = value
                If Me._cmbServerName IsNot Nothing Then
                    AddHandler Me._cmbServerName.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property txtPassword As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtPassword
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtPassword = value
            End Set
        End Property

        Friend Overridable Property txtUserName As System.Windows.Forms.TextBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._txtUserName
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.TextBox)
                Me._txtUserName = value
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

        Friend Overridable Property Label7 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label7
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label7 = value
            End Set
        End Property

        Friend Overridable Property cmbAuthentication As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbAuthentication
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbAuthentication_SelectedIndexChanged
                If Me._cmbAuthentication IsNot Nothing Then
                    RemoveHandler Me._cmbAuthentication.SelectedIndexChanged, value2
                End If

                Me._cmbAuthentication = value
                If Me._cmbAuthentication IsNot Nothing Then
                    AddHandler Me._cmbAuthentication.SelectedIndexChanged, value2
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
                Me._Timer1 = value
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

        Friend Overridable Property btnTestConnection As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnTestConnection
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnTestConnection_Click_1
                If Me._btnTestConnection IsNot Nothing Then
                    RemoveHandler Me._btnTestConnection.Click, value2
                End If

                Me._btnTestConnection = value
                If Me._btnTestConnection IsNot Nothing Then
                    AddHandler Me._btnTestConnection.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Timer2 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer2
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Me._Timer2 = value
            End Set
        End Property

        Friend Overridable Property btnBlankDB As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnBlankDB
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.Button1_Click
                If Me._btnBlankDB IsNot Nothing Then
                    RemoveHandler Me._btnBlankDB.Click, value2
                End If

                Me._btnBlankDB = value
                If Me._btnBlankDB IsNot Nothing Then
                    AddHandler Me._btnBlankDB.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Label6 As System.Windows.Forms.Label
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Label6
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Label)
                Me._Label6 = value
            End Set
        End Property

        Friend Overridable Property cmbInstallationType As System.Windows.Forms.ComboBox
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._cmbInstallationType
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.ComboBox)
                Dim value2 As System.EventHandler = AddressOf Me.cmbInstallationType_SelectedIndexChanged
                If Me._cmbInstallationType IsNot Nothing Then
                    RemoveHandler Me._cmbInstallationType.SelectedIndexChanged, value2
                End If

                Me._cmbInstallationType = value
                If Me._cmbInstallationType IsNot Nothing Then
                    AddHandler Me._cmbInstallationType.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property Timer3 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer3
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Me._Timer3 = value
            End Set
        End Property

        Friend Overridable Property Timer4 As System.Windows.Forms.Timer
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._Timer4
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Windows.Forms.Timer)
                Dim value2 As System.EventHandler = AddressOf Me.Timer4_Tick
                If Me._Timer4 IsNot Nothing Then
                    RemoveHandler Me._Timer4.Tick, value2
                End If

                Me._Timer4 = value
                If Me._Timer4 IsNot Nothing Then
                    AddHandler Me._Timer4.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property btnSearchServers As CButtonLib.CButton
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me._btnSearchServers
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As CButtonLib.CButton)
                Dim value2 As System.EventHandler = AddressOf Me.btnSearchServers_Click
                If Me._btnSearchServers IsNot Nothing Then
                    RemoveHandler Me._btnSearchServers.Click, value2
                End If

                Me._btnSearchServers = value
                If Me._btnSearchServers IsNot Nothing Then
                    AddHandler Me._btnSearchServers.Click, value2
                End If
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            AddHandler MyBase.Load, AddressOf Me.frmSqlServerSetting_Load
            Call RestaurantPOS14.frmSqlServerSetting.__ENCAddToList(Me)
            Me.InitializeComponent()
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.frmSqlServerSetting.__ENCList
                If RestaurantPOS14.frmSqlServerSetting.__ENCList.Count = RestaurantPOS14.frmSqlServerSetting.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.frmSqlServerSetting.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.frmSqlServerSetting.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.frmSqlServerSetting.__ENCList(num) = RestaurantPOS14.frmSqlServerSetting.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.frmSqlServerSetting.__ENCList.RemoveRange(num, RestaurantPOS14.frmSqlServerSetting.__ENCList.Count - num)
                    RestaurantPOS14.frmSqlServerSetting.__ENCList.Capacity = RestaurantPOS14.frmSqlServerSetting.__ENCList.Count
                End If

                Call RestaurantPOS14.frmSqlServerSetting.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub btnSave_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.cmbInstallationType.SelectedIndex = 0 Then
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbServerName.Text, "", TextCompare:=False) = 0 Then
                        Call Microsoft.VisualBasic.Interaction.MsgBox("Please Select/Enter Server Name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                        Me.cmbServerName.Focus()
                        Return
                    End If

                    If Me.cmbAuthentication.SelectedIndex = 1 Then
                        If Me.txtUserName.Text.Length = 0 Then
                            Call Microsoft.VisualBasic.Interaction.MsgBox("please enter user name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                            Me.txtUserName.Focus()
                            Return
                        End If

                        If Me.txtPassword.Text.Length = 0 Then
                            Call Microsoft.VisualBasic.Interaction.MsgBox("please enter password", Microsoft.VisualBasic.MsgBoxStyle.Information)
                            Me.txtPassword.Focus()
                            Return
                        End If
                    End If

                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer4.Enabled = True
                    Using connection As New System.Data.SqlClient.SqlConnection(Me.BuildDatabaseConnectionString("master"))
                        connection.Open()
                    End Using

                    If Microsoft.VisualBasic.Interaction.MsgBox("It will create the DB and configure the sql server, Do you want to proceed?", Microsoft.VisualBasic.MsgBoxStyle.YesNo Or Microsoft.VisualBasic.MsgBoxStyle.Information) <> Microsoft.VisualBasic.MsgBoxResult.Yes Then
                        Return
                    End If

                    Dim createDatabaseConnectionString = RestaurantPOS14.Configuration.DatabaseConnectionSettings.Build(Me.cmbServerName.Text.Trim(), RestaurantPOS14.Configuration.SettingsHost.Current.Database.DefaultCatalog, Me.cmbAuthentication.SelectedIndex = 0, Me.txtUserName.Text.Trim(), Me.txtPassword.Text)
                    If Not Me.CreateDB() Then
                        Return
                    End If

                    RestaurantPOS14.Configuration.DatabaseConnectionSettings.Save(createDatabaseConnectionString)
                    Call System.Windows.Forms.MessageBox.Show("DB has been created and SQL Server setting has been saved successfully..." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Application will be closed,Please start it again", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
                    Return
                End If

                If Me.cmbInstallationType.SelectedIndex <> 1 Then
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbServerName.Text, "", TextCompare:=False) = 0 Then
                    Call Microsoft.VisualBasic.Interaction.MsgBox("Please Select/Enter Server Name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                    Me.cmbServerName.Focus()
                    Return
                End If

                If Me.cmbAuthentication.SelectedIndex = 1 Then
                    If Me.txtUserName.Text.Length = 0 Then
                        Call Microsoft.VisualBasic.Interaction.MsgBox("please enter user name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                        Me.txtUserName.Focus()
                        Return
                    End If

                    If Me.txtPassword.Text.Length = 0 Then
                        Call Microsoft.VisualBasic.Interaction.MsgBox("please enter password", Microsoft.VisualBasic.MsgBoxStyle.Information)
                        Me.txtPassword.Focus()
                        Return
                    End If
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer4.Enabled = True
                If Microsoft.VisualBasic.Interaction.MsgBox("It will configure the sql server, Do you want to proceed?", Microsoft.VisualBasic.MsgBoxStyle.YesNo Or Microsoft.VisualBasic.MsgBoxStyle.Information) <> Microsoft.VisualBasic.MsgBoxResult.Yes Then
                    Return
                End If

                Dim configureExistingConnectionString = RestaurantPOS14.Configuration.DatabaseConnectionSettings.Build(Me.cmbServerName.Text.Trim(), RestaurantPOS14.Configuration.SettingsHost.Current.Database.DefaultCatalog, Me.cmbAuthentication.SelectedIndex = 0, Me.txtUserName.Text.Trim(), Me.txtPassword.Text)
                RestaurantPOS14.Configuration.DatabaseConnectionSettings.Save(configureExistingConnectionString)
                Call System.Windows.Forms.MessageBox.Show("SQL Server setting has been saved successfully..." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Application will be closed,Please start it again", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
            Catch ex As System.Exception
                Me.ShowDatabaseError("Unable to create or configure the database.", ex)
            End Try
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub btnClose_Click(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.lblSet.Text, "Main Form", TextCompare:=False) = 0 Then
                MyBase.Close()
            ElseIf Microsoft.VisualBasic.Interaction.MsgBox("Do you want to close the application....", Microsoft.VisualBasic.MsgBoxStyle.YesNo Or Microsoft.VisualBasic.MsgBoxStyle.Information) = Microsoft.VisualBasic.MsgBoxResult.Yes Then
                RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
            End If
        End Sub

        Public Function CreateDB() As Boolean
            Return Me.CreateDatabaseFromScript("DBScript.sql")
        End Function

        Private Function BuildDatabaseConnectionString(catalog As String) As String
            Return RestaurantPOS14.Configuration.DatabaseConnectionSettings.Build(Me.cmbServerName.Text.Trim(), catalog, Me.cmbAuthentication.SelectedIndex = 0, Me.txtUserName.Text.Trim(), Me.txtPassword.Text)
        End Function

        Private Function CreateDatabaseFromScript(scriptFileName As String) As Boolean
            Dim scriptPath As String = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, scriptFileName)
            If Not System.IO.File.Exists(scriptPath) Then
                Throw New System.IO.FileNotFoundException("The database setup script was not found: " & scriptPath, scriptPath)
            End If

            Me.st = RestaurantPOS14.Configuration.DatabaseMaintenance.PrepareDatabaseScript(System.IO.File.ReadAllText(scriptPath))
            Dim masterConnectionString As String = Me.BuildDatabaseConnectionString("master")
            Dim databaseCreated As Boolean = False

            Try
                Using connection As New System.Data.SqlClient.SqlConnection(masterConnectionString)
                    connection.Open()

                    Using permissionCommand As System.Data.SqlClient.SqlCommand = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateDatabasePermissionCommand(connection)
                        If Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(permissionCommand.ExecuteScalar()) <> 1 Then
                            Throw New System.UnauthorizedAccessException("The selected SQL Server login does not have permission to create databases. Grant it the dbcreator role or use an administrator login, then try again.")
                        End If
                    End Using

                    Dim databaseExists As Boolean
                    Using existsCommand As System.Data.SqlClient.SqlCommand = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateDatabaseExistsCommand(connection)
                        databaseExists = existsCommand.ExecuteScalar() IsNot Nothing
                    End Using

                    If databaseExists Then
                        Dim replaceMessage As String = "Database '" & RestaurantPOS14.Configuration.DatabaseMaintenance.GetCatalogName() & "' already exists." & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Continuing will permanently delete it and create a new database. Do you want to continue?"
                        If System.Windows.Forms.MessageBox.Show(replaceMessage, "Replace Existing Database", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning, System.Windows.Forms.MessageBoxDefaultButton.Button2) <> System.Windows.Forms.DialogResult.Yes Then
                            Return False
                        End If

                        Using dropCommand As System.Data.SqlClient.SqlCommand = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateDropDatabaseCommand(connection)
                            dropCommand.ExecuteNonQuery()
                        End Using
                    End If

                    Using createCommand As System.Data.SqlClient.SqlCommand = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateDatabaseCommand(connection)
                        createCommand.ExecuteNonQuery()
                    End Using

                    databaseCreated = True
                End Using

                Using scriptConnection As New System.Data.SqlClient.SqlConnection(masterConnectionString)
                    scriptConnection.Open()
                    Dim serverConnection As New Microsoft.SqlServer.Management.Common.ServerConnection(scriptConnection)
                    serverConnection.StatementTimeout = RestaurantPOS14.Configuration.SettingsHost.Current.Database.CommandTimeoutSeconds
                    Dim server As New Microsoft.SqlServer.Management.Smo.Server(serverConnection)
                    server.ConnectionContext.ExecuteNonQuery(Me.st)
                End Using

                Using verificationConnection As New System.Data.SqlClient.SqlConnection(Me.BuildDatabaseConnectionString(RestaurantPOS14.Configuration.DatabaseMaintenance.GetCatalogName()))
                    verificationConnection.Open()
                    RestaurantPOS14.Configuration.DatabaseMaintenance.EnsureCompatibleSchema(verificationConnection)
                    Using verificationCommand As System.Data.SqlClient.SqlCommand = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateDatabaseProvisionedCommand(verificationConnection)
                        If Microsoft.VisualBasic.CompilerServices.Conversions.ToInteger(verificationCommand.ExecuteScalar()) <> 1 Then
                            Throw New System.InvalidOperationException("The database script ended before all required tables, defaults, and relationships were created.")
                        End If
                    End Using
                End Using

                Return True
            Catch ex As System.Exception
                If databaseCreated Then
                    Try
                        Me.DropDatabaseIfExists(masterConnectionString)
                    Catch cleanupException As System.Exception
                        Throw New System.InvalidOperationException(ex.Message & Global.Microsoft.VisualBasic.Constants.vbCrLf & "The incomplete database could not be removed: " & cleanupException.Message, ex)
                    End Try
                End If

                Throw
            End Try
        End Function

        Private Sub DropDatabaseIfExists(masterConnectionString As String)
            Using connection As New System.Data.SqlClient.SqlConnection(masterConnectionString)
                connection.Open()
                Using existsCommand As System.Data.SqlClient.SqlCommand = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateDatabaseExistsCommand(connection)
                    If existsCommand.ExecuteScalar() Is Nothing Then
                        Return
                    End If
                End Using

                Using dropCommand As System.Data.SqlClient.SqlCommand = RestaurantPOS14.Configuration.DatabaseMaintenance.CreateDropDatabaseCommand(connection)
                    dropCommand.ExecuteNonQuery()
                End Using
            End Using
        End Sub

        Private Sub ShowDatabaseError(summary As String, ex As System.Exception)
            Me.Timer4.Enabled = False
            MyBase.Cursor = System.Windows.Forms.Cursors.Default
            Dim message As String = summary & Global.Microsoft.VisualBasic.Constants.vbCrLf & Global.Microsoft.VisualBasic.Constants.vbCrLf & Me.GetDatabaseErrorDetails(ex)
            Call System.Windows.Forms.MessageBox.Show(message, "Database Setup Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
        End Sub

        Private Function GetDatabaseErrorDetails(ex As System.Exception) As String
            Dim details As New System.Collections.Generic.List(Of String)()
            Dim current As System.Exception = ex
            While current IsNot Nothing
                Dim sqlException As System.Data.SqlClient.SqlException = TryCast(current, System.Data.SqlClient.SqlException)
                If sqlException IsNot Nothing Then
                    For Each sqlError As System.Data.SqlClient.SqlError In sqlException.Errors
                        Dim location As String = "SQL error " & sqlError.Number.ToString()
                        If Not System.String.IsNullOrWhiteSpace(sqlError.Procedure) Then
                            location &= " in " & sqlError.Procedure
                        End If

                        If sqlError.LineNumber > 0 Then
                            location &= " at line " & sqlError.LineNumber.ToString()
                        End If

                        Dim sqlDetail As String = location & ": " & sqlError.Message
                        If Not details.Contains(sqlDetail) Then
                            details.Add(sqlDetail)
                        End If
                    Next
                ElseIf Not System.String.IsNullOrWhiteSpace(current.Message) AndAlso Microsoft.VisualBasic.CompilerServices.Operators.CompareString(current.Message, "An exception occurred while executing a Transact-SQL statement or batch.", TextCompare:=False) <> 0 AndAlso Not details.Contains(current.Message) Then
                    details.Add(current.Message)
                End If

                current = current.InnerException
            End While

            If details.Count = 0 Then
                Return "An unknown database setup error occurred."
            End If

            Return System.String.Join(Global.Microsoft.VisualBasic.Constants.vbCrLf, details.ToArray())
        End Function

        Private Sub cmbAuthentication_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            If Me.cmbAuthentication.SelectedIndex = 0 Then
                Me.txtUserName.[ReadOnly] = True
                Me.txtPassword.[ReadOnly] = True
                Me.txtUserName.Text = ""
                Me.txtPassword.Text = ""
            End If

            If Me.cmbAuthentication.SelectedIndex = 1 Then
                Me.txtUserName.[ReadOnly] = False
                Me.txtPassword.[ReadOnly] = False
            End If
        End Sub

        Private Sub cmbServerName_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            Me.cmbAuthentication.Enabled = True
        End Sub

        Public Sub Reset()
            Me.txtPassword.Text = ""
            Me.txtUserName.Text = ""
            Me.cmbServerName.Text = ""
            Me.cmbAuthentication.SelectedIndex = 0
            Me.cmbInstallationType.SelectedIndex = 0
        End Sub

        Private Sub btnTestConnection_Click_1(sender As Object, e As System.EventArgs)
            If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbServerName.Text, "", TextCompare:=False) = 0 Then
                Call Microsoft.VisualBasic.Interaction.MsgBox("Please select/enter Server Name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                Me.cmbServerName.Focus()
                Return
            End If

            If Me.cmbAuthentication.SelectedIndex = 1 Then
                If Me.txtUserName.Text.Length = 0 Then
                    Call Microsoft.VisualBasic.Interaction.MsgBox("please enter user name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                    Me.txtUserName.Focus()
                    Return
                End If

                If Me.txtPassword.Text.Length = 0 Then
                    Call Microsoft.VisualBasic.Interaction.MsgBox("please enter password", Microsoft.VisualBasic.MsgBoxStyle.Information)
                    Me.txtPassword.Focus()
                    Return
                End If
            End If

            MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.Timer4.Enabled = True
            Dim sqlConnection As System.Data.SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection()
            If Me.cmbAuthentication.SelectedIndex = 0 Then
                Me.SqlConnStr = "Data Source=" & Me.cmbServerName.Text.Trim() & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True"
            End If

            If Me.cmbAuthentication.SelectedIndex = 1 Then
                Me.SqlConnStr = "Data Source=" & Me.cmbServerName.Text.Trim() & ";Initial Catalog=master;User ID=" & Me.txtUserName.Text.Trim() & ";Password=" & Me.txtPassword.Text & ";MultipleActiveResultSets=True"
            End If

            If sqlConnection.State <> System.Data.ConnectionState.Closed Then
                Return
            End If

            sqlConnection.ConnectionString = Me.SqlConnStr
            Try
                sqlConnection.Open()
                Call System.Windows.Forms.MessageBox.Show("Succsessfull DB Connnection", "DB Connection Test", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
            Catch __unusedException1__ As System.Exception
                Call System.Windows.Forms.MessageBox.Show("Invalid DB SqlConnnection" & Global.Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Information.Err().Description, "DB Connection Test", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Hand)
            End Try
        End Sub

        <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining Or System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)>
        Private Sub Button1_Click(sender As Object, e As System.EventArgs)
            Try
                If Me.cmbInstallationType.SelectedIndex = 0 Then
                    If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbServerName.Text, "", TextCompare:=False) = 0 Then
                        Call Microsoft.VisualBasic.Interaction.MsgBox("Please Select/Enter Server Name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                        Me.cmbServerName.Focus()
                        Return
                    End If

                    If Me.cmbAuthentication.SelectedIndex = 1 Then
                        If Me.txtUserName.Text.Length = 0 Then
                            Call Microsoft.VisualBasic.Interaction.MsgBox("please enter user name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                            Me.txtUserName.Focus()
                            Return
                        End If

                        If Me.txtPassword.Text.Length = 0 Then
                            Call Microsoft.VisualBasic.Interaction.MsgBox("please enter password", Microsoft.VisualBasic.MsgBoxStyle.Information)
                            Me.txtPassword.Focus()
                            Return
                        End If
                    End If

                    MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    Me.Timer4.Enabled = True
                    Using connection As New System.Data.SqlClient.SqlConnection(Me.BuildDatabaseConnectionString("master"))
                        connection.Open()
                    End Using

                    If Microsoft.VisualBasic.Interaction.MsgBox("It will create the DB and configure the sql server, Do you want to proceed?", Microsoft.VisualBasic.MsgBoxStyle.YesNo Or Microsoft.VisualBasic.MsgBoxStyle.Information) <> Microsoft.VisualBasic.MsgBoxResult.Yes Then
                        Return
                    End If

                    Dim createBlankDatabaseConnectionString = RestaurantPOS14.Configuration.DatabaseConnectionSettings.Build(Me.cmbServerName.Text.Trim(), RestaurantPOS14.Configuration.SettingsHost.Current.Database.DefaultCatalog, Me.cmbAuthentication.SelectedIndex = 0, Me.txtUserName.Text.Trim(), Me.txtPassword.Text)
                    If Not Me.CreateBlankDB() Then
                        Return
                    End If

                    RestaurantPOS14.Configuration.DatabaseConnectionSettings.Save(createBlankDatabaseConnectionString)
                    Call System.Windows.Forms.MessageBox.Show("DB has been created and SQL Server setting has been saved successfully..." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Application will be closed,Please start it again", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                    RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
                    Return
                End If

                If Me.cmbInstallationType.SelectedIndex <> 1 Then
                    Return
                End If

                If Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Me.cmbServerName.Text, "", TextCompare:=False) = 0 Then
                    Call Microsoft.VisualBasic.Interaction.MsgBox("Please Select/Enter Server Name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                    Me.cmbServerName.Focus()
                    Return
                End If

                If Me.cmbAuthentication.SelectedIndex = 1 Then
                    If Me.txtUserName.Text.Length = 0 Then
                        Call Microsoft.VisualBasic.Interaction.MsgBox("please enter user name", Microsoft.VisualBasic.MsgBoxStyle.Information)
                        Me.txtUserName.Focus()
                        Return
                    End If

                    If Me.txtPassword.Text.Length = 0 Then
                        Call Microsoft.VisualBasic.Interaction.MsgBox("please enter password", Microsoft.VisualBasic.MsgBoxStyle.Information)
                        Me.txtPassword.Focus()
                        Return
                    End If
                End If

                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer4.Enabled = True
                If Me.cmbAuthentication.SelectedIndex = 0 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection("Data source=" & Me.cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                End If

                If Me.cmbAuthentication.SelectedIndex = 1 Then
                    RestaurantPOS14.ModClasses.con = New System.Data.SqlClient.SqlConnection("Data Source=" & Me.cmbServerName.Text.Trim() & ";Initial Catalog=master;User ID=" & Me.txtUserName.Text.Trim() & ";Password=" & Me.txtPassword.Text & ";MultipleActiveResultSets=True")
                End If

                If Microsoft.VisualBasic.Interaction.MsgBox("It will configure the sql server, Do you want to proceed?", Microsoft.VisualBasic.MsgBoxStyle.YesNo Or Microsoft.VisualBasic.MsgBoxStyle.Information) <> Microsoft.VisualBasic.MsgBoxResult.Yes Then
                    Return
                End If

                Dim configureBlankExistingConnectionString = RestaurantPOS14.Configuration.DatabaseConnectionSettings.Build(Me.cmbServerName.Text.Trim(), RestaurantPOS14.Configuration.SettingsHost.Current.Database.DefaultCatalog, Me.cmbAuthentication.SelectedIndex = 0, Me.txtUserName.Text.Trim(), Me.txtPassword.Text)
                RestaurantPOS14.Configuration.DatabaseConnectionSettings.Save(configureBlankExistingConnectionString)
                Call System.Windows.Forms.MessageBox.Show("SQL Server setting has been saved successfully..." & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Application will be closed,Please start it again", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
                RestaurantPOS14.Diagnostics.ApplicationLifecycle.ExitApplication()
            Catch ex As System.Exception
                Me.ShowDatabaseError("Unable to create or configure the database.", ex)
            End Try
        End Sub

        Public Function CreateBlankDB() As Boolean
            Return Me.CreateDatabaseFromScript("BlankDBscript.sql")
        End Function

        Private Sub frmSqlServerSetting_Load(sender As Object, e As System.EventArgs)
            Me.Reset()
        End Sub

        Private Sub cmbInstallationType_SelectedIndexChanged(sender As Object, e As System.EventArgs)
            If Me.cmbInstallationType.SelectedIndex = 1 Then
                Me.cmbAuthentication.SelectedIndex = 1
                Me.cmbAuthentication.Enabled = False
                Me.btnTestConnection.Visible = True
                Me.btnSearchServers.Visible = False
                Me.btnBlankDB.Visible = False
                Me.btnDemoDB.Text = "Save Setting"
            End If

            If Me.cmbInstallationType.SelectedIndex = 0 Then
                Me.cmbAuthentication.SelectedIndex = 0
                Me.cmbAuthentication.Enabled = True
                Me.btnTestConnection.Visible = True
                Me.btnSearchServers.Visible = True
                Me.btnBlankDB.Visible = True
                Me.btnDemoDB.Text = "Create Demo DB " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "and Proceed"
            End If
        End Sub

        Private Sub Timer4_Tick(sender As Object, e As System.EventArgs)
            MyBase.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.Timer4.Enabled = False
        End Sub

        Private Sub btnSearchServers_Click(sender As Object, e As System.EventArgs)
            Try
                MyBase.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Me.Timer4.Enabled = True
                Dim dataSource As System.Data.DataTable = Microsoft.SqlServer.Management.Smo.SmoApplication.EnumAvailableSqlServers(localOnly:=True)
                Me.cmbServerName.ValueMember = "Name"
                Me.cmbServerName.DataSource = dataSource
                Dim unusedServer As Microsoft.SqlServer.Management.Smo.Server = New Microsoft.SqlServer.Management.Smo.Server(Me.cmbServerName.SelectedValue.ToString())
            Catch __unusedException1__ As System.Exception
                Call System.Windows.Forms.MessageBox.Show("Sorry unable to find SQL Server instance" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "If you have installed SQL Server then enter name of SQL Server instance manually", "Info", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk)
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
            Dim cBlendItems As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim componentResourceManager As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurantPOS14.frmSqlServerSetting))
            Dim cBlendItems2 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems3 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems4 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Dim cBlendItems5 As CButtonLib.cBlendItems = New CButtonLib.cBlendItems()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.btnSearchServers = New CButtonLib.CButton()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.cmbInstallationType = New System.Windows.Forms.ComboBox()
            Me.btnBlankDB = New CButtonLib.CButton()
            Me.btnTestConnection = New CButtonLib.CButton()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.cmbAuthentication = New System.Windows.Forms.ComboBox()
            Me.cmbServerName = New System.Windows.Forms.ComboBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.txtUserName = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btnClose = New CButtonLib.CButton()
            Me.btnDemoDB = New CButtonLib.CButton()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.lblSet = New System.Windows.Forms.Label()
            Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
            Me.Panel1.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            MyBase.SuspendLayout()
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Controls.Add(Me.GroupBox1)
            Me.Panel1.Controls.Add(Me.Panel2)
            Dim panel As System.Windows.Forms.Panel = Me.Panel1
            Dim location As System.Drawing.Point = New System.Drawing.Point(3, 3)
            panel.Location = location
            Me.Panel1.Name = "Panel1"
            Dim panel2 As System.Windows.Forms.Panel = Me.Panel1
            Dim size As System.Drawing.Size = New System.Drawing.Size(545, 255)
            panel2.Size = size
            Me.Panel1.TabIndex = 2
            Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.GroupBox1.Controls.Add(Me.btnSearchServers)
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.cmbInstallationType)
            Me.GroupBox1.Controls.Add(Me.btnBlankDB)
            Me.GroupBox1.Controls.Add(Me.btnTestConnection)
            Me.GroupBox1.Controls.Add(Me.Label7)
            Me.GroupBox1.Controls.Add(Me.cmbAuthentication)
            Me.GroupBox1.Controls.Add(Me.cmbServerName)
            Me.GroupBox1.Controls.Add(Me.txtPassword)
            Me.GroupBox1.Controls.Add(Me.txtUserName)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Controls.Add(Me.btnClose)
            Me.GroupBox1.Controls.Add(Me.btnDemoDB)
            Me.GroupBox1.ForeColor = System.Drawing.Color.White
            Dim groupBox As System.Windows.Forms.GroupBox = Me.GroupBox1
            location = New System.Drawing.Point(6, 48)
            groupBox.Location = location
            Me.GroupBox1.Name = "GroupBox1"
            Dim groupBox2 As System.Windows.Forms.GroupBox = Me.GroupBox1
            size = New System.Drawing.Size(532, 201)
            groupBox2.Size = size
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "SQL Server Configuration"
            Me.btnSearchServers.BackColor = System.Drawing.Color.Transparent
            Me.btnSearchServers.BorderShow = False
            cBlendItems.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Green, System.Drawing.Color.Green, System.Drawing.Color.Green}
            cBlendItems.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnSearchServers.ColorFillBlend = cBlendItems
            Me.btnSearchServers.Corners.All = 3
            Me.btnSearchServers.Corners.LowerLeft = 3
            Me.btnSearchServers.Corners.LowerRight = 3
            Me.btnSearchServers.Corners.UpperLeft = 3
            Me.btnSearchServers.Corners.UpperRight = 3
            Me.btnSearchServers.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSearchServers.DesignerSelected = False
            Me.btnSearchServers.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnSearchServers.Image = CType(componentResourceManager.GetObject("btnSearchServers.Image"), System.Drawing.Image)
            Me.btnSearchServers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSearchServers.ImageIndex = 0
            Dim cButton As CButtonLib.CButton = Me.btnSearchServers
            size = New System.Drawing.Size(32, 32)
            cButton.ImageSize = size
            Dim cButton2 As CButtonLib.CButton = Me.btnSearchServers
            location = New System.Drawing.Point(421, 24)
            cButton2.Location = location
            Me.btnSearchServers.Name = "btnSearchServers"
            Dim cButton3 As CButtonLib.CButton = Me.btnSearchServers
            size = New System.Drawing.Size(104, 47)
            cButton3.Size = size
            Me.btnSearchServers.TabIndex = 23
            Me.btnSearchServers.Text = "Search" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "Servers"
            Me.btnSearchServers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSearchServers.TextShadowShow = False
            Me.btnSearchServers.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label As System.Windows.Forms.Label = Me.Label6
            location = New System.Drawing.Point(11, 50)
            label.Location = location
            Dim label2 As System.Windows.Forms.Label = Me.Label6
            Dim margin As System.Windows.Forms.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label2.Margin = margin
            Me.Label6.Name = "Label6"
            Dim label3 As System.Windows.Forms.Label = Me.Label6
            size = New System.Drawing.Size(100, 15)
            label3.Size = size
            Me.Label6.TabIndex = 21
            Me.Label6.Text = "Installation Type :"
            Me.cmbInstallationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbInstallationType.FormattingEnabled = True
            Me.cmbInstallationType.Items.AddRange(New Object(1) {"Server Installation", "Client Installation"})
            Dim comboBox As System.Windows.Forms.ComboBox = Me.cmbInstallationType
            location = New System.Drawing.Point(156, 50)
            comboBox.Location = location
            Me.cmbInstallationType.Name = "cmbInstallationType"
            Dim comboBox2 As System.Windows.Forms.ComboBox = Me.cmbInstallationType
            size = New System.Drawing.Size(259, 21)
            comboBox2.Size = size
            Me.cmbInstallationType.TabIndex = 1
            Me.btnBlankDB.BackColor = System.Drawing.Color.Transparent
            Me.btnBlankDB.BorderShow = False
            cBlendItems2.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems2.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnBlankDB.ColorFillBlend = cBlendItems2
            Me.btnBlankDB.Corners.All = 3
            Me.btnBlankDB.Corners.LowerLeft = 3
            Me.btnBlankDB.Corners.LowerRight = 3
            Me.btnBlankDB.Corners.UpperLeft = 3
            Me.btnBlankDB.Corners.UpperRight = 3
            Me.btnBlankDB.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnBlankDB.DesignerSelected = False
            Me.btnBlankDB.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnBlankDB.Image = CType(componentResourceManager.GetObject("btnBlankDB.Image"), System.Drawing.Image)
            Me.btnBlankDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnBlankDB.ImageIndex = 0
            Dim cButton4 As CButtonLib.CButton = Me.btnBlankDB
            size = New System.Drawing.Size(32, 32)
            cButton4.ImageSize = size
            Dim cButton5 As CButtonLib.CButton = Me.btnBlankDB
            location = New System.Drawing.Point(156, 155)
            cButton5.Location = location
            Me.btnBlankDB.Name = "btnBlankDB"
            Dim cButton6 As CButtonLib.CButton = Me.btnBlankDB
            size = New System.Drawing.Size(136, 40)
            cButton6.Size = size
            Me.btnBlankDB.TabIndex = 7
            Me.btnBlankDB.Text = "Create Blank DB " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "and Proceed"
            Me.btnBlankDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnBlankDB.TextShadowShow = False
            Me.btnBlankDB.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnTestConnection.BackColor = System.Drawing.Color.Transparent
            Me.btnTestConnection.BorderShow = False
            cBlendItems3.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems3.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnTestConnection.ColorFillBlend = cBlendItems3
            Me.btnTestConnection.Corners.All = 3
            Me.btnTestConnection.Corners.LowerLeft = 3
            Me.btnTestConnection.Corners.LowerRight = 3
            Me.btnTestConnection.Corners.UpperLeft = 3
            Me.btnTestConnection.Corners.UpperRight = 3
            Me.btnTestConnection.DesignerSelected = False
            Me.btnTestConnection.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnTestConnection.Image = RestaurantPOS14.My.Resources.Resources.Database_Active_icon1
            Me.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnTestConnection.ImageIndex = 0
            Dim cButton7 As CButtonLib.CButton = Me.btnTestConnection
            size = New System.Drawing.Size(24, 24)
            cButton7.ImageSize = size
            Dim cButton8 As CButtonLib.CButton = Me.btnTestConnection
            location = New System.Drawing.Point(14, 155)
            cButton8.Location = location
            Me.btnTestConnection.Name = "btnTestConnection"
            Dim cButton9 As CButtonLib.CButton = Me.btnTestConnection
            size = New System.Drawing.Size(136, 39)
            cButton9.Size = size
            Me.btnTestConnection.TabIndex = 6
            Me.btnTestConnection.Text = "Test DB Connection"
            Me.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnTestConnection.TextShadowShow = False
            Me.btnTestConnection.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Label7.AutoSize = True
            Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label4 As System.Windows.Forms.Label = Me.Label7
            location = New System.Drawing.Point(11, 75)
            label4.Location = location
            Dim label5 As System.Windows.Forms.Label = Me.Label7
            margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label5.Margin = margin
            Me.Label7.Name = "Label7"
            Dim label6 As System.Windows.Forms.Label = Me.Label7
            size = New System.Drawing.Size(92, 15)
            label6.Size = size
            Me.Label7.TabIndex = 17
            Me.Label7.Text = "Authentication :"
            Me.cmbAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbAuthentication.FormattingEnabled = True
            Me.cmbAuthentication.Items.AddRange(New Object(1) {"Windows Authentication", "SQL Server Authentication"})
            Dim comboBox3 As System.Windows.Forms.ComboBox = Me.cmbAuthentication
            location = New System.Drawing.Point(156, 75)
            comboBox3.Location = location
            Me.cmbAuthentication.Name = "cmbAuthentication"
            Dim comboBox4 As System.Windows.Forms.ComboBox = Me.cmbAuthentication
            size = New System.Drawing.Size(259, 21)
            comboBox4.Size = size
            Me.cmbAuthentication.TabIndex = 2
            Me.cmbServerName.FormattingEnabled = True
            Dim comboBox5 As System.Windows.Forms.ComboBox = Me.cmbServerName
            location = New System.Drawing.Point(156, 24)
            comboBox5.Location = location
            Me.cmbServerName.Name = "cmbServerName"
            Dim comboBox6 As System.Windows.Forms.ComboBox = Me.cmbServerName
            size = New System.Drawing.Size(259, 21)
            comboBox6.Size = size
            Me.cmbServerName.TabIndex = 0
            Dim textBox As System.Windows.Forms.TextBox = Me.txtPassword
            location = New System.Drawing.Point(156, 128)
            textBox.Location = location
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = "*"c
            Dim textBox2 As System.Windows.Forms.TextBox = Me.txtPassword
            size = New System.Drawing.Size(259, 20)
            textBox2.Size = size
            Me.txtPassword.TabIndex = 4
            Dim textBox3 As System.Windows.Forms.TextBox = Me.txtUserName
            location = New System.Drawing.Point(156, 102)
            textBox3.Location = location
            Me.txtUserName.Name = "txtUserName"
            Dim textBox4 As System.Windows.Forms.TextBox = Me.txtUserName
            size = New System.Drawing.Size(259, 20)
            textBox4.Size = size
            Me.txtUserName.TabIndex = 3
            Me.Label3.AutoSize = True
            Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label7 As System.Windows.Forms.Label = Me.Label3
            location = New System.Drawing.Point(11, 102)
            label7.Location = location
            Dim label8 As System.Windows.Forms.Label = Me.Label3
            margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label8.Margin = margin
            Me.Label3.Name = "Label3"
            Dim label9 As System.Windows.Forms.Label = Me.Label3
            size = New System.Drawing.Size(132, 15)
            label9.Size = size
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "SQL Server User Name :"
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label10 As System.Windows.Forms.Label = Me.Label2
            location = New System.Drawing.Point(11, 128)
            label10.Location = location
            Dim label11 As System.Windows.Forms.Label = Me.Label2
            margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label11.Margin = margin
            Me.Label2.Name = "Label2"
            Dim label12 As System.Windows.Forms.Label = Me.Label2
            size = New System.Drawing.Size(114, 15)
            label12.Size = size
            Me.Label2.TabIndex = 7
            Me.Label2.Text = "SQL User Password :"
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Dim label13 As System.Windows.Forms.Label = Me.Label5
            location = New System.Drawing.Point(11, 24)
            label13.Location = location
            Dim label14 As System.Windows.Forms.Label = Me.Label5
            margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            label14.Margin = margin
            Me.Label5.Name = "Label5"
            Dim label15 As System.Windows.Forms.Label = Me.Label5
            size = New System.Drawing.Size(106, 15)
            label15.Size = size
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "SQL Server Name :"
            Me.btnClose.BackColor = System.Drawing.Color.Transparent
            Me.btnClose.BorderShow = False
            cBlendItems4.iColor = New System.Drawing.Color(2) {System.Drawing.Color.Crimson, System.Drawing.Color.Crimson, System.Drawing.Color.Crimson}
            cBlendItems4.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnClose.ColorFillBlend = cBlendItems4
            Me.btnClose.Corners.All = 3
            Me.btnClose.Corners.LowerLeft = 3
            Me.btnClose.Corners.LowerRight = 3
            Me.btnClose.Corners.UpperLeft = 3
            Me.btnClose.Corners.UpperRight = 3
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.DesignerSelected = False
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnClose.Image = CType(componentResourceManager.GetObject("btnClose.Image"), System.Drawing.Image)
            Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnClose.ImageIndex = 0
            Dim cButton10 As CButtonLib.CButton = Me.btnClose
            size = New System.Drawing.Size(32, 32)
            cButton10.ImageSize = size
            Dim cButton11 As CButtonLib.CButton = Me.btnClose
            location = New System.Drawing.Point(442, 156)
            cButton11.Location = location
            Me.btnClose.Name = "btnClose"
            Dim cButton12 As CButtonLib.CButton = Me.btnClose
            size = New System.Drawing.Size(82, 39)
            cButton12.Size = size
            Me.btnClose.TabIndex = 9
            Me.btnClose.Text = "Close"
            Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnClose.TextShadowShow = False
            Me.btnClose.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.btnDemoDB.BackColor = System.Drawing.Color.Transparent
            Me.btnDemoDB.BorderShow = False
            cBlendItems5.iColor = New System.Drawing.Color(2) {System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105), System.Drawing.Color.FromArgb(102, 106, 105)}
            cBlendItems5.iPoint = New Single(2) {0F, 0.5F, 1F}
            Me.btnDemoDB.ColorFillBlend = cBlendItems5
            Me.btnDemoDB.Corners.All = 3
            Me.btnDemoDB.Corners.LowerLeft = 3
            Me.btnDemoDB.Corners.LowerRight = 3
            Me.btnDemoDB.Corners.UpperLeft = 3
            Me.btnDemoDB.Corners.UpperRight = 3
            Me.btnDemoDB.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDemoDB.DesignerSelected = False
            Me.btnDemoDB.Font = New System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.btnDemoDB.Image = CType(componentResourceManager.GetObject("btnDemoDB.Image"), System.Drawing.Image)
            Me.btnDemoDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnDemoDB.ImageIndex = 0
            Dim cButton13 As CButtonLib.CButton = Me.btnDemoDB
            size = New System.Drawing.Size(32, 32)
            cButton13.ImageSize = size
            Dim cButton14 As CButtonLib.CButton = Me.btnDemoDB
            location = New System.Drawing.Point(296, 155)
            cButton14.Location = location
            Me.btnDemoDB.Name = "btnDemoDB"
            Dim cButton15 As CButtonLib.CButton = Me.btnDemoDB
            size = New System.Drawing.Size(141, 40)
            cButton15.Size = size
            Me.btnDemoDB.TabIndex = 8
            Me.btnDemoDB.Text = "Create Demo DB " & Global.Microsoft.VisualBasic.Constants.vbCrLf & "and Proceed"
            Me.btnDemoDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnDemoDB.TextShadowShow = False
            Me.btnDemoDB.TextSmoothingMode = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel2.Controls.Add(Me.Label1)
            Me.Panel2.Controls.Add(Me.lblSet)
            Dim panel3 As System.Windows.Forms.Panel = Me.Panel2
            location = New System.Drawing.Point(6, 5)
            panel3.Location = location
            Me.Panel2.Name = "Panel2"
            Dim panel4 As System.Windows.Forms.Panel = Me.Panel2
            size = New System.Drawing.Size(532, 37)
            panel4.Size = size
            Me.Panel2.TabIndex = 1
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0)
            Me.Label1.ForeColor = System.Drawing.Color.White
            Dim label16 As System.Windows.Forms.Label = Me.Label1
            location = New System.Drawing.Point(158, 6)
            label16.Location = location
            Me.Label1.Name = "Label1"
            Dim label17 As System.Windows.Forms.Label = Me.Label1
            size = New System.Drawing.Size(187, 24)
            label17.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "SQL Server Setting"
            Me.lblSet.AutoSize = True
            Dim label18 As System.Windows.Forms.Label = Me.lblSet
            location = New System.Drawing.Point(80, 15)
            label18.Location = location
            Me.lblSet.Name = "lblSet"
            Dim label19 As System.Windows.Forms.Label = Me.lblSet
            size = New System.Drawing.Size(23, 13)
            label19.Size = size
            Me.lblSet.TabIndex = 21
            Me.lblSet.Text = "Set"
            Me.lblSet.Visible = False
            MyBase.AcceptButton = Me.btnDemoDB
            Dim autoScaleDimensions As System.Drawing.SizeF = New System.Drawing.SizeF(6F, 13F)
            MyBase.AutoScaleDimensions = autoScaleDimensions
            MyBase.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(58, 58, 56)
            size = New System.Drawing.Size(552, 261)
            MyBase.ClientSize = size
            MyBase.Controls.Add(Me.Panel1)
            MyBase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), System.Drawing.Icon)
            MyBase.MaximizeBox = False
            MyBase.MinimizeBox = False
            MyBase.Name = "frmSqlServerSetting"
            MyBase.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Panel1.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.Panel2.ResumeLayout(False)
            Me.Panel2.PerformLayout()
            MyBase.ResumeLayout(False)
        End Sub
    End Class
End Namespace
