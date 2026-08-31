Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace RestaurantPOS14.RPOS_DBDataSetTableAdapters

    ''' <summary>
    ''' Represents the connection and commands used to retrieve and save data.
    ''' </summary>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    Public Class EmailSettingTableAdapter
        Inherits System.ComponentModel.Component

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("_adapter")>
        Private __adapter As System.Data.SqlClient.SqlDataAdapter

        Private _connection As System.Data.SqlClient.SqlConnection

        Private _commandCollection As System.Data.SqlClient.SqlCommand()

        Private _clearBeforeFill As Boolean

        Private Property _adapter As System.Data.SqlClient.SqlDataAdapter
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Get
                Return Me.__adapter
            End Get

            <System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)>
            <System.Diagnostics.DebuggerNonUserCodeAttribute>
            Set(value As System.Data.SqlClient.SqlDataAdapter)
                Me.__adapter = value
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private ReadOnly Property Adapter As System.Data.SqlClient.SqlDataAdapter
            Get
                If Me._adapter Is Nothing Then
                    Me.InitAdapter()
                End If

                Return Me._adapter
            End Get
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Friend Property Connection As System.Data.SqlClient.SqlConnection
            Get
                If Me._connection Is Nothing Then
                    Me.InitConnection()
                End If

                Return Me._connection
            End Get

            Set(value As System.Data.SqlClient.SqlConnection)
                Me._connection = value
                If Me.Adapter.InsertCommand IsNot Nothing Then
                    Me.Adapter.InsertCommand.Connection = value
                End If

                If Me.Adapter.DeleteCommand IsNot Nothing Then
                    Me.Adapter.DeleteCommand.Connection = value
                End If

                If Me.Adapter.UpdateCommand IsNot Nothing Then
                    Me.Adapter.UpdateCommand.Connection = value
                End If

                Dim i As Integer = 0
                While i < Me.CommandCollection.Length
                    If Me.CommandCollection(i) IsNot Nothing Then
                        Me.CommandCollection(CInt((i))).Connection = value
                    End If

                    i = i + 1
                End While
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Protected ReadOnly Property CommandCollection As System.Data.SqlClient.SqlCommand()
            Get
                If Me._commandCollection Is Nothing Then
                    Me.InitCommandCollection()
                End If

                Return Me._commandCollection
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Property ClearBeforeFill As Boolean
            Get
                Return Me._clearBeforeFill
            End Get

            Set(value As Boolean)
                Me._clearBeforeFill = value
            End Set
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Shared Sub __ENCAddToList(value As Object)
            SyncLock RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.EmailSettingTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "EmailSetting"
            dataTableMapping.ColumnMappings.Add("Id", "Id")
            dataTableMapping.ColumnMappings.Add("ServerName", "ServerName")
            dataTableMapping.ColumnMappings.Add("SMTPAddress", "SMTPAddress")
            dataTableMapping.ColumnMappings.Add("Username", "Username")
            dataTableMapping.ColumnMappings.Add("Password", "Password")
            dataTableMapping.ColumnMappings.Add("Port", "Port")
            dataTableMapping.ColumnMappings.Add("TLS_SSL_Required", "TLS_SSL_Required")
            dataTableMapping.ColumnMappings.Add("IsDefault", "IsDefault")
            dataTableMapping.ColumnMappings.Add("IsActive", "IsActive")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[EmailSetting] WHERE (([Id] = @Original_Id) AND ([ServerName] = @Original_ServerName) AND ([SMTPAddress] = @Original_SMTPAddress) AND ([Username] = @Original_Username) AND ([Password] = @Original_Password) AND ([Port] = @Original_Port) AND ([TLS_SSL_Required] = @Original_TLS_SSL_Required) AND ([IsDefault] = @Original_IsDefault) AND ([IsActive] = @Original_IsActive))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ServerName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ServerName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SMTPAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "SMTPAddress", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Username", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Password", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Port", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Port", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TLS_SSL_Required", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TLS_SSL_Required", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IsDefault", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IsDefault", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IsActive", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IsActive", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[EmailSetting] ([ServerName], [SMTPAddress], [Username], [Password], [Port], [TLS_SSL_Required], [IsDefault], [IsActive]) VALUES (@ServerName, @SMTPAddress, @Username, @Password, @Port, @TLS_SSL_Required, @IsDefault, @IsActive);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT Id, ServerName, SMTPAddress, Username, Password, Port, TLS_SSL_Required, IsDefault, IsActive FROM EmailSetting WHERE (Id = SCOPE_IDENTITY())"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ServerName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ServerName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SMTPAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "SMTPAddress", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Username", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Password", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Port", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Port", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TLS_SSL_Required", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TLS_SSL_Required", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsDefault", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IsDefault", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsActive", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IsActive", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[EmailSetting] SET [ServerName] = @ServerName, [SMTPAddress] = @SMTPAddress, [Username] = @Username, [Password] = @Password, [Port] = @Port, [TLS_SSL_Required] = @TLS_SSL_Required, [IsDefault] = @IsDefault, [IsActive] = @IsActive WHERE (([Id] = @Original_Id) AND ([ServerName] = @Original_ServerName) AND ([SMTPAddress] = @Original_SMTPAddress) AND ([Username] = @Original_Username) AND ([Password] = @Original_Password) AND ([Port] = @Original_Port) AND ([TLS_SSL_Required] = @Original_TLS_SSL_Required) AND ([IsDefault] = @Original_IsDefault) AND ([IsActive] = @Original_IsActive));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT Id, ServerName, SMTPAddress, Username, Password, Port, TLS_SSL_Required, IsDefault, IsActive FROM EmailSetting WHERE (Id = @Id)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ServerName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ServerName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SMTPAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "SMTPAddress", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Username", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Password", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Password", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Port", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Port", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TLS_SSL_Required", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TLS_SSL_Required", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsDefault", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IsDefault", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsActive", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IsActive", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ServerName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ServerName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SMTPAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "SMTPAddress", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Username", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Password", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Password", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Port", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Port", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TLS_SSL_Required", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TLS_SSL_Required", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IsDefault", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IsDefault", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IsActive", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IsActive", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitConnection()
            Me._connection = New System.Data.SqlClient.SqlConnection()
            Me._connection.ConnectionString = RestaurantPOS14.ConnectionString.cs
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitCommandCollection()
            Me._commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            Me._commandCollection(0) = New System.Data.SqlClient.SqlCommand()
            Me._commandCollection(CInt((0))).Connection = Me.Connection
            Me._commandCollection(CInt((0))).CommandText = "SELECT Id, ServerName, SMTPAddress, Username, Password, Port, TLS_SSL_Required, IsDefault, IsActive FROM dbo.EmailSetting"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet.EmailSettingDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet.EmailSettingDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim emailSettingDataTable As RestaurantPOS14.RPOS_DBDataSet.EmailSettingDataTable = New RestaurantPOS14.RPOS_DBDataSet.EmailSettingDataTable()
            Me.Adapter.Fill(emailSettingDataTable)
            Return emailSettingDataTable
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet.EmailSettingDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "EmailSetting")
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Delete(Original_Id As Integer, Original_ServerName As String, Original_SMTPAddress As String, Original_Username As String, Original_Password As String, Original_Port As Integer, Original_TLS_SSL_Required As String, Original_IsDefault As String, Original_IsActive As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_Id
            If Equals(Original_ServerName, Nothing) Then
                Throw New System.ArgumentNullException("Original_ServerName")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = Original_ServerName
            If Equals(Original_SMTPAddress, Nothing) Then
                Throw New System.ArgumentNullException("Original_SMTPAddress")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_SMTPAddress
            If Equals(Original_Username, Nothing) Then
                Throw New System.ArgumentNullException("Original_Username")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = Original_Username
            If Equals(Original_Password, Nothing) Then
                Throw New System.ArgumentNullException("Original_Password")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_Password
            Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = Original_Port
            If Equals(Original_TLS_SSL_Required, Nothing) Then
                Throw New System.ArgumentNullException("Original_TLS_SSL_Required")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_TLS_SSL_Required
            If Equals(Original_IsDefault, Nothing) Then
                Throw New System.ArgumentNullException("Original_IsDefault")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = Original_IsDefault
            If Equals(Original_IsActive, Nothing) Then
                Throw New System.ArgumentNullException("Original_IsActive")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_IsActive
            Dim state As System.Data.ConnectionState = Me.Adapter.DeleteCommand.Connection.State
            If(Me.Adapter.DeleteCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open Then
                Me.Adapter.DeleteCommand.Connection.Open()
            End If

            Try
                Return Me.Adapter.DeleteCommand.ExecuteNonQuery()
            Finally
                If state = System.Data.ConnectionState.Closed Then
                    Me.Adapter.DeleteCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        Public Overridable Function Insert(ServerName As String, SMTPAddress As String, Username As String, Password As String, Port As Integer, TLS_SSL_Required As String, IsDefault As String, IsActive As String) As Integer
            If Equals(ServerName, Nothing) Then
                Throw New System.ArgumentNullException("ServerName")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = ServerName
            If Equals(SMTPAddress, Nothing) Then
                Throw New System.ArgumentNullException("SMTPAddress")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = SMTPAddress
            If Equals(Username, Nothing) Then
                Throw New System.ArgumentNullException("Username")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = Username
            If Equals(Password, Nothing) Then
                Throw New System.ArgumentNullException("Password")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = Password
            Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = Port
            If Equals(TLS_SSL_Required, Nothing) Then
                Throw New System.ArgumentNullException("TLS_SSL_Required")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = TLS_SSL_Required
            If Equals(IsDefault, Nothing) Then
                Throw New System.ArgumentNullException("IsDefault")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = IsDefault
            If Equals(IsActive, Nothing) Then
                Throw New System.ArgumentNullException("IsActive")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = IsActive
            Dim state As System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If(Me.Adapter.InsertCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If

            Try
                Return Me.Adapter.InsertCommand.ExecuteNonQuery()
            Finally
                If state = System.Data.ConnectionState.Closed Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(ServerName As String, SMTPAddress As String, Username As String, Password As String, Port As Integer, TLS_SSL_Required As String, IsDefault As String, IsActive As String, Original_Id As Integer, Original_ServerName As String, Original_SMTPAddress As String, Original_Username As String, Original_Password As String, Original_Port As Integer, Original_TLS_SSL_Required As String, Original_IsDefault As String, Original_IsActive As String, Id As Integer) As Integer
            If Equals(ServerName, Nothing) Then
                Throw New System.ArgumentNullException("ServerName")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = ServerName
            If Equals(SMTPAddress, Nothing) Then
                Throw New System.ArgumentNullException("SMTPAddress")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = SMTPAddress
            If Equals(Username, Nothing) Then
                Throw New System.ArgumentNullException("Username")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = Username
            If Equals(Password, Nothing) Then
                Throw New System.ArgumentNullException("Password")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = Password
            Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = Port
            If Equals(TLS_SSL_Required, Nothing) Then
                Throw New System.ArgumentNullException("TLS_SSL_Required")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = TLS_SSL_Required
            If Equals(IsDefault, Nothing) Then
                Throw New System.ArgumentNullException("IsDefault")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = IsDefault
            If Equals(IsActive, Nothing) Then
                Throw New System.ArgumentNullException("IsActive")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = IsActive
            Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Original_Id
            If Equals(Original_ServerName, Nothing) Then
                Throw New System.ArgumentNullException("Original_ServerName")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = Original_ServerName
            If Equals(Original_SMTPAddress, Nothing) Then
                Throw New System.ArgumentNullException("Original_SMTPAddress")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = Original_SMTPAddress
            If Equals(Original_Username, Nothing) Then
                Throw New System.ArgumentNullException("Original_Username")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = Original_Username
            If Equals(Original_Password, Nothing) Then
                Throw New System.ArgumentNullException("Original_Password")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = Original_Password
            Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = Original_Port
            If Equals(Original_TLS_SSL_Required, Nothing) Then
                Throw New System.ArgumentNullException("Original_TLS_SSL_Required")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = Original_TLS_SSL_Required
            If Equals(Original_IsDefault, Nothing) Then
                Throw New System.ArgumentNullException("Original_IsDefault")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = Original_IsDefault
            If Equals(Original_IsActive, Nothing) Then
                Throw New System.ArgumentNullException("Original_IsActive")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = Original_IsActive
            Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = Id
            Dim state As System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
            If(Me.Adapter.UpdateCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open Then
                Me.Adapter.UpdateCommand.Connection.Open()
            End If

            Try
                Return Me.Adapter.UpdateCommand.ExecuteNonQuery()
            Finally
                If state = System.Data.ConnectionState.Closed Then
                    Me.Adapter.UpdateCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        Public Overridable Function Update(ServerName As String, SMTPAddress As String, Username As String, Password As String, Port As Integer, TLS_SSL_Required As String, IsDefault As String, IsActive As String, Original_Id As Integer, Original_ServerName As String, Original_SMTPAddress As String, Original_Username As String, Original_Password As String, Original_Port As Integer, Original_TLS_SSL_Required As String, Original_IsDefault As String, Original_IsActive As String) As Integer
            Return Me.Update(ServerName, SMTPAddress, Username, Password, Port, TLS_SSL_Required, IsDefault, IsActive, Original_Id, Original_ServerName, Original_SMTPAddress, Original_Username, Original_Password, Original_Port, Original_TLS_SSL_Required, Original_IsDefault, Original_IsActive, Original_Id)
        End Function
    End Class
End Namespace
