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
Imports RestaurantPOS14.My

Namespace RestaurantPOS14.RPOS_DBDataSet1TableAdapters

    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DataObjectAttribute(True)>
    Public Class UserRightsTableAdapter
        Inherits System.ComponentModel.Component

        Private Shared __ENCList As System.Collections.Generic.List(Of System.WeakReference) = New System.Collections.Generic.List(Of System.WeakReference)()

        <System.Runtime.CompilerServices.AccessedThroughPropertyAttribute("_adapter")>
        Private __adapter As System.Data.SqlClient.SqlDataAdapter

        Private _connection As System.Data.SqlClient.SqlConnection

        Private _transaction As System.Data.SqlClient.SqlTransaction

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
        Protected Friend ReadOnly Property Adapter As System.Data.SqlClient.SqlDataAdapter
            Get
                If Me._adapter Is Nothing Then
                    Me.InitAdapter()
                End If

                Return Me._adapter
            End Get
        End Property

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Friend Property Transaction As System.Data.SqlClient.SqlTransaction
            Get
                Return Me._transaction
            End Get

            Set(value As System.Data.SqlClient.SqlTransaction)
                Me._transaction = value
                Dim i As Integer = 0
                While i < Me.CommandCollection.Length
                    Me.CommandCollection(CInt((i))).Transaction = Me._transaction
                    i = i + 1
                End While

                If Me.Adapter IsNot Nothing AndAlso Me.Adapter.DeleteCommand IsNot Nothing Then
                    Me.Adapter.DeleteCommand.Transaction = Me._transaction
                End If

                If Me.Adapter IsNot Nothing AndAlso Me.Adapter.InsertCommand IsNot Nothing Then
                    Me.Adapter.InsertCommand.Transaction = Me._transaction
                End If

                If Me.Adapter IsNot Nothing AndAlso Me.Adapter.UpdateCommand IsNot Nothing Then
                    Me.Adapter.UpdateCommand.Transaction = Me._transaction
                End If
            End Set
        End Property

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.UserRightsTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "UserRights"
            dataTableMapping.ColumnMappings.Add("ID", "ID")
            dataTableMapping.ColumnMappings.Add("ModuleName", "ModuleName")
            dataTableMapping.ColumnMappings.Add("UR_Save", "UR_Save")
            dataTableMapping.ColumnMappings.Add("UR_Update", "UR_Update")
            dataTableMapping.ColumnMappings.Add("UR_Delete", "UR_Delete")
            dataTableMapping.ColumnMappings.Add("UR_View", "UR_View")
            dataTableMapping.ColumnMappings.Add("UserID", "UserID")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[UserRights] WHERE (([ID] = @Original_ID) AND ((@IsNull_ModuleName = 1 AND [ModuleName] IS NULL) OR ([ModuleName] = @Original_ModuleName)) AND ((@IsNull_UR_Save = 1 AND [UR_Save] IS NULL) OR ([UR_Save] = @Original_UR_Save)) AND ((@IsNull_UR_Update = 1 AND [UR_Update] IS NULL) OR ([UR_Update] = @Original_UR_Update)) AND ((@IsNull_UR_Delete = 1 AND [UR_Delete] IS NULL) OR ([UR_Delete] = @Original_UR_Delete)) AND ((@IsNull_UR_View = 1 AND [UR_View] IS NULL) OR ([UR_View] = @Original_UR_View)) AND ((@IsNull_UserID = 1 AND [UserID] IS NULL) OR ([UserID] = @Original_UserID)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ModuleName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ModuleName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModuleName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ModuleName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UR_Save", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Save", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UR_Save", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Save", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UR_Update", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Update", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UR_Update", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Update", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UR_Delete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Delete", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UR_Delete", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Delete", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UR_View", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_View", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UR_View", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_View", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UserID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UserID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[UserRights] ([ModuleName], [UR_Save], [UR_Update], [UR_Delete], [UR_View], [UserID]) VALUES (@ModuleName, @UR_Save, @UR_Update, @UR_Delete, @UR_View, @UserID);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT ID, ModuleName, UR_Save, UR_Update, UR_Delete, UR_View, UserID FROM UserRights WHERE (ID = SCOPE_IDENTITY())"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModuleName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ModuleName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UR_Save", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Save", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UR_Update", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Update", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UR_Delete", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Delete", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UR_View", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_View", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UserID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[UserRights] SET [ModuleName] = @ModuleName, [UR_Save] = @UR_Save, [UR_Update] = @UR_Update, [UR_Delete] = @UR_Delete, [UR_View] = @UR_View, [UserID] = @UserID WHERE (([ID] = @Original_ID) AND ((@IsNull_ModuleName = 1 AND [ModuleName] IS NULL) OR ([ModuleName] = @Original_ModuleName)) AND ((@IsNull_UR_Save = 1 AND [UR_Save] IS NULL) OR ([UR_Save] = @Original_UR_Save)) AND ((@IsNull_UR_Update = 1 AND [UR_Update] IS NULL) OR ([UR_Update] = @Original_UR_Update)) AND ((@IsNull_UR_Delete = 1 AND [UR_Delete] IS NULL) OR ([UR_Delete] = @Original_UR_Delete)) AND ((@IsNull_UR_View = 1 AND [UR_View] IS NULL) OR ([UR_View] = @Original_UR_View)) AND ((@IsNull_UserID = 1 AND [UserID] IS NULL) OR ([UserID] = @Original_UserID)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT ID, ModuleName, UR_Save, UR_Update, UR_Delete, UR_View, UserID FROM UserRights WHERE (ID = @ID)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ModuleName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ModuleName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UR_Save", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Save", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UR_Update", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Update", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UR_Delete", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Delete", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UR_View", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_View", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UserID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ModuleName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ModuleName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ModuleName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ModuleName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UR_Save", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Save", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UR_Save", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Save", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UR_Update", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Update", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UR_Update", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Update", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UR_Delete", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Delete", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UR_Delete", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_Delete", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UR_View", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_View", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UR_View", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, 0, 0, "UR_View", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_UserID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UserID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "UserID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitConnection()
            Me._connection = New System.Data.SqlClient.SqlConnection()
            Me._connection.ConnectionString = RestaurantPOS14.My.MySettings.[Default].RPOS_DBConnectionString
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitCommandCollection()
            Me._commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            Me._commandCollection(0) = New System.Data.SqlClient.SqlCommand()
            Me._commandCollection(CInt((0))).Connection = Me.Connection
            Me._commandCollection(CInt((0))).CommandText = "SELECT ID, ModuleName, UR_Save, UR_Update, UR_Delete, UR_View, UserID FROM dbo.UserRights"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.UserRightsDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.UserRightsDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim userRightsDataTable As RestaurantPOS14.RPOS_DBDataSet1.UserRightsDataTable = New RestaurantPOS14.RPOS_DBDataSet1.UserRightsDataTable()
            Me.Adapter.Fill(userRightsDataTable)
            Return userRightsDataTable
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.UserRightsDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "UserRights")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        Public Overridable Function Delete(Original_ID As Integer, Original_ModuleName As String, Original_UR_Save As Boolean?, Original_UR_Update As Boolean?, Original_UR_Delete As Boolean?, Original_UR_View As Boolean?, Original_UserID As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_ID
            If Equals(Original_ModuleName, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_ModuleName
            End If

            If Original_UR_Save.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_UR_Save.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Original_UR_Update.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_UR_Update.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Original_UR_Delete.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_UR_Delete.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Original_UR_View.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = Original_UR_View.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            End If

            If Equals(Original_UserID, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = Original_UserID
            End If

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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        Public Overridable Function Insert(ModuleName As String, UR_Save As Boolean?, UR_Update As Boolean?, UR_Delete As Boolean?, UR_View As Boolean?, UserID As String) As Integer
            If Equals(ModuleName, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = ModuleName
            End If

            If UR_Save.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = UR_Save.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If UR_Update.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = UR_Update.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If UR_Delete.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = UR_Delete.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If UR_View.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = UR_View.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Equals(UserID, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = UserID
            End If

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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        Public Overridable Function Update(ModuleName As String, UR_Save As Boolean?, UR_Update As Boolean?, UR_Delete As Boolean?, UR_View As Boolean?, UserID As String, Original_ID As Integer, Original_ModuleName As String, Original_UR_Save As Boolean?, Original_UR_Update As Boolean?, Original_UR_Delete As Boolean?, Original_UR_View As Boolean?, Original_UserID As String, ID As Integer) As Integer
            If Equals(ModuleName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = ModuleName
            End If

            If UR_Save.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = UR_Save.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If UR_Update.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = UR_Update.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If UR_Delete.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = UR_Delete.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If UR_View.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = UR_View.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Equals(UserID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = UserID
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = Original_ID
            If Equals(Original_ModuleName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Original_ModuleName
            End If

            If Original_UR_Save.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = Original_UR_Save.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            End If

            If Original_UR_Update.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = Original_UR_Update.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            End If

            If Original_UR_Delete.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = Original_UR_Delete.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            End If

            If Original_UR_View.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = Original_UR_View.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            End If

            If Equals(Original_UserID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = Original_UserID
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = ID
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(ModuleName As String, UR_Save As Boolean?, UR_Update As Boolean?, UR_Delete As Boolean?, UR_View As Boolean?, UserID As String, Original_ID As Integer, Original_ModuleName As String, Original_UR_Save As Boolean?, Original_UR_Update As Boolean?, Original_UR_Delete As Boolean?, Original_UR_View As Boolean?, Original_UserID As String) As Integer
            Return Me.Update(ModuleName, UR_Save, UR_Update, UR_Delete, UR_View, UserID, Original_ID, Original_ModuleName, Original_UR_Save, Original_UR_Update, Original_UR_Delete, Original_UR_View, Original_UserID, Original_ID)
        End Function
    End Class
End Namespace
