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
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    Public Class PosGrouping1TableAdapter
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
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
            SyncLock RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.PosGrouping1TableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "PosGrouping1"
            dataTableMapping.ColumnMappings.Add("id", "id")
            dataTableMapping.ColumnMappings.Add("Col1", "Col1")
            dataTableMapping.ColumnMappings.Add("Col2", "Col2")
            dataTableMapping.ColumnMappings.Add("Col3", "Col3")
            dataTableMapping.ColumnMappings.Add("Col4", "Col4")
            dataTableMapping.ColumnMappings.Add("Col5", "Col5")
            dataTableMapping.ColumnMappings.Add("Col6", "Col6")
            dataTableMapping.ColumnMappings.Add("Col7", "Col7")
            dataTableMapping.ColumnMappings.Add("Col8", "Col8")
            dataTableMapping.ColumnMappings.Add("Col9", "Col9")
            dataTableMapping.ColumnMappings.Add("Col10", "Col10")
            dataTableMapping.ColumnMappings.Add("Col11", "Col11")
            dataTableMapping.ColumnMappings.Add("Col12", "Col12")
            dataTableMapping.ColumnMappings.Add("Col13", "Col13")
            dataTableMapping.ColumnMappings.Add("Col14", "Col14")
            dataTableMapping.ColumnMappings.Add("Col15", "Col15")
            dataTableMapping.ColumnMappings.Add("Col16", "Col16")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[PosGrouping1] WHERE (([id] = @Original_id) AND ((@IsNull_Col1 = 1 AND [Col1] IS NULL) OR ([Col1] = @Original_Col1)) AND ((@IsNull_Col2 = 1 AND [Col2] IS NULL) OR ([Col2] = @Original_Col2)) AND ((@IsNull_Col3 = 1 AND [Col3] IS NULL) OR ([Col3] = @Original_Col3)) AND ((@IsNull_Col4 = 1 AND [Col4] IS NULL) OR ([Col4] = @Original_Col4)) AND ((@IsNull_Col5 = 1 AND [Col5] IS NULL) OR ([Col5] = @Original_Col5)) AND ((@IsNull_Col6 = 1 AND [Col6] IS NULL) OR ([Col6] = @Original_Col6)) AND ((@IsNull_Col7 = 1 AND [Col7] IS NULL) OR ([Col7] = @Original_Col7)) AND ((@IsNull_Col8 = 1 AND [Col8] IS NULL) OR ([Col8] = @Original_Col8)) AND ((@IsNull_Col9 = 1 AND [Col9] IS NULL) OR ([Col9] = @Original_Col9)) AND ((@IsNull_Col10 = 1 AND [Col10] IS NULL) OR ([Col10] = @Original_Col10)) AND ((@IsNull_Col11 = 1 AND [Col11] IS NULL) OR ([Col11] = @Original_Col11)) AND ((@IsNull_Col12 = 1 AND [Col12] IS NULL) OR ([Col12] = @Original_Col12)) AND ((@IsNull_Col13 = 1 AND [Col13] IS NULL) OR ([Col13] = @Original_Col13)) AND ((@IsNull_Col15 = 1 AND [Col15] IS NULL) OR ([Col15] = @Original_Col15)) AND ((@IsNull_Col16 = 1 AND [Col16] IS NULL) OR ([Col16] = @Original_Col16)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col1", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col1", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col2", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col2", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col2", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col3", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col3", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col4", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col4", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col4", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col5", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col5", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col5", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col6", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col6", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col6", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col7", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col7", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col7", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col8", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col8", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col8", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col9", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col9", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col9", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col10", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col10", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col10", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col11", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col11", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col11", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col12", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col12", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col12", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col13", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col13", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col13", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col15", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col15", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col16", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col16", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col16", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col16", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[PosGrouping1] ([Col1], [Col2], [Col3], [Col4], [Col5], [Col6], [Col7], [Col8], [Col9], [Col10], [Col11], [Col12], [Col13], [Col14], [Col15], [Col16]) VALUES (@Col1, @Col2, @Col3, @Col4, @Col5, @Col6, @Col7, @Col8, @Col9, @Col10, @Col11, @Col12, @Col13, @Col14, @Col15, @Col16);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT id, Col1, Col2, Col3, Col4, Col5, Col6, Col7, Col8, Col9, Col10, Col11, Col12, Col13, Col14, Col15, Col16 FROM PosGrouping1 WHERE (id = SCOPE_IDENTITY())"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col1", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col2", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col2", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col3", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col4", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col4", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col5", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col5", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col6", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col6", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col7", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col7", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col8", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col8", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col9", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col9", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col10", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col10", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col11", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col11", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col12", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col12", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col13", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col13", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col14", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col14", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col15", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col16", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col16", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[PosGrouping1] SET [Col1] = @Col1, [Col2] = @Col2, [Col3] = @Col3, [Col4] = @Col4, [Col5] = @Col5, [Col6] = @Col6, [Col7] = @Col7, [Col8] = @Col8, [Col9] = @Col9, [Col10] = @Col10, [Col11] = @Col11, [Col12] = @Col12, [Col13] = @Col13, [Col14] = @Col14, [Col15] = @Col15, [Col16] = @Col16 WHERE (([id] = @Original_id) AND ((@IsNull_Col1 = 1 AND [Col1] IS NULL) OR ([Col1] = @Original_Col1)) AND ((@IsNull_Col2 = 1 AND [Col2] IS NULL) OR ([Col2] = @Original_Col2)) AND ((@IsNull_Col3 = 1 AND [Col3] IS NULL) OR ([Col3] = @Original_Col3)) AND ((@IsNull_Col4 = 1 AND [Col4] IS NULL) OR ([Col4] = @Original_Col4)) AND ((@IsNull_Col5 = 1 AND [Col5] IS NULL) OR ([Col5] = @Original_Col5)) AND ((@IsNull_Col6 = 1 AND [Col6] IS NULL) OR ([Col6] = @Original_Col6)) AND ((@IsNull_Col7 = 1 AND [Col7] IS NULL) OR ([Col7] = @Original_Col7)) AND ((@IsNull_Col8 = 1 AND [Col8] IS NULL) OR ([Col8] = @Original_Col8)) AND ((@IsNull_Col9 = 1 AND [Col9] IS NULL) OR ([Col9] = @Original_Col9)) AND ((@IsNull_Col10 = 1 AND [Col10] IS NULL) OR ([Col10] = @Original_Col10)) AND ((@IsNull_Col11 = 1 AND [Col11] IS NULL) OR ([Col11] = @Original_Col11)) AND ((@IsNull_Col12 = 1 AND [Col12] IS NULL) OR ([Col12] = @Original_Col12)) AND ((@IsNull_Col13 = 1 AND [Col13] IS NULL) OR ([Col13] = @Original_Col13)) AND ((@IsNull_Col15 = 1 AND [Col15] IS NULL) OR ([Col15] = @Original_Col15)) AND ((@IsNull_Col16 = 1 AND [Col16] IS NULL) OR ([Col16] = @Original_Col16)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT id, Col1, Col2, Col3, Col4, Col5, Col6, Col7, Col8, Col9, Col10, Col11, Col12, Col13, Col14, Col15, Col16 FROM PosGrouping1 WHERE (id = @id)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col1", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col2", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col2", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col3", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col4", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col4", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col5", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col5", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col6", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col6", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col7", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col7", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col8", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col8", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col9", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col9", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col10", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col10", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col11", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col11", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col12", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col12", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col13", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col13", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col14", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col14", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col15", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Col16", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col16", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col1", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col1", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col1", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col2", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col2", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col2", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col3", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col3", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col4", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col4", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col4", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col5", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col5", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col5", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col6", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col6", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col6", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col6", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col7", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col7", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col7", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col7", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col8", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col8", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col8", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col8", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col9", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col9", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col9", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col9", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col10", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col10", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col10", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col11", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col11", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col11", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col12", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col12", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col12", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col12", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col13", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col13", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col13", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Col13", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col15", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col15", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Col16", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Col16", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Col16", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Col16", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, 0, 0, "id", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitConnection()
            Me._connection = New System.Data.SqlClient.SqlConnection()
            Me._connection.ConnectionString = RestaurantPOS14.ConnectionString.cs
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitCommandCollection()
            Me._commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            Me._commandCollection(0) = New System.Data.SqlClient.SqlCommand()
            Me._commandCollection(CInt((0))).Connection = Me.Connection
            Me._commandCollection(CInt((0))).CommandText = "SELECT id, Col1, Col2, Col3, Col4, Col5, Col6, Col7, Col8, Col9, Col10, Col11, Col12, Col13, Col14, Col15, Col16 FROM dbo.PosGrouping1"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet.PosGrouping1DataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet.PosGrouping1DataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim posGrouping1DataTable As RestaurantPOS14.RPOS_DBDataSet.PosGrouping1DataTable = New RestaurantPOS14.RPOS_DBDataSet.PosGrouping1DataTable()
            Me.Adapter.Fill(posGrouping1DataTable)
            Return posGrouping1DataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet.PosGrouping1DataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "PosGrouping1")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        Public Overridable Function Delete(Original_id As Integer, Original_Col1 As String, Original_Col2 As Decimal?, Original_Col3 As Integer?, Original_Col4 As Decimal?, Original_Col5 As Decimal?, Original_Col6 As Decimal?, Original_Col7 As Decimal?, Original_Col8 As Decimal?, Original_Col9 As Decimal?, Original_Col10 As Decimal?, Original_Col11 As Decimal?, Original_Col12 As Decimal?, Original_Col13 As Decimal?, Original_Col15 As Integer?, Original_Col16 As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_id
            If Equals(Original_Col1, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_Col1
            End If

            If Original_Col2.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_Col2.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Original_Col3.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_Col3.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Original_Col4.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_Col4.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Original_Col5.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = Original_Col5.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            End If

            If Original_Col6.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = Original_Col6.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            End If

            If Original_Col7.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = Original_Col7.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            End If

            If Original_Col8.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = Original_Col8.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            End If

            If Original_Col9.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = Original_Col9.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            End If

            If Original_Col10.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((20))).Value = Original_Col10.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            End If

            If Original_Col11.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((21))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((22))).Value = Original_Col11.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((21))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((22))).Value = System.DBNull.Value
            End If

            If Original_Col12.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((23))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((24))).Value = Original_Col12.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((23))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((24))).Value = System.DBNull.Value
            End If

            If Original_Col13.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((25))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((26))).Value = Original_Col13.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((25))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((26))).Value = System.DBNull.Value
            End If

            If Original_Col15.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((27))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((28))).Value = Original_Col15.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((27))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((28))).Value = System.DBNull.Value
            End If

            If Equals(Original_Col16, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((29))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((30))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((29))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((30))).Value = Original_Col16
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Insert(Col1 As String, Col2 As Decimal?, Col3 As Integer?, Col4 As Decimal?, Col5 As Decimal?, Col6 As Decimal?, Col7 As Decimal?, Col8 As Decimal?, Col9 As Decimal?, Col10 As Decimal?, Col11 As Decimal?, Col12 As Decimal?, Col13 As Decimal?, Col14 As String, Col15 As Integer?, Col16 As String) As Integer
            If Equals(Col1, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = Col1
            End If

            If Col2.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = Col2.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If Col3.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = Col3.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Col4.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = Col4.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If Col5.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = Col5.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Col6.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = Col6.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If Col7.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = Col7.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Col8.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = Col8.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If Col9.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = Col9.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Col10.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = Col10.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            End If

            If Col11.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((10))).Value = Col11.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            End If

            If Col12.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((11))).Value = Col12.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            End If

            If Col13.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((12))).Value = Col13.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            End If

            If Equals(Col14, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((13))).Value = Col14
            End If

            If Col15.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((14))).Value = Col15.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            End If

            If Equals(Col16, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((15))).Value = Col16
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

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(Col1 As String, Col2 As Decimal?, Col3 As Integer?, Col4 As Decimal?, Col5 As Decimal?, Col6 As Decimal?, Col7 As Decimal?, Col8 As Decimal?, Col9 As Decimal?, Col10 As Decimal?, Col11 As Decimal?, Col12 As Decimal?, Col13 As Decimal?, Col14 As String, Col15 As Integer?, Col16 As String, Original_id As Integer, Original_Col1 As String, Original_Col2 As Decimal?, Original_Col3 As Integer?, Original_Col4 As Decimal?, Original_Col5 As Decimal?, Original_Col6 As Decimal?, Original_Col7 As Decimal?, Original_Col8 As Decimal?, Original_Col9 As Decimal?, Original_Col10 As Decimal?, Original_Col11 As Decimal?, Original_Col12 As Decimal?, Original_Col13 As Decimal?, Original_Col15 As Integer?, Original_Col16 As String, id As Integer) As Integer
            If Equals(Col1, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = Col1
            End If

            If Col2.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = Col2.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If Col3.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = Col3.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Col4.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = Col4.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If Col5.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = Col5.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Col6.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = Col6.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If Col7.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = Col7.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Col8.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = Col8.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If Col9.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Col9.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Col10.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = Col10.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            End If

            If Col11.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = Col11.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            End If

            If Col12.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = Col12.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            End If

            If Col13.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = Col13.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            End If

            If Equals(Col14, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = Col14
            End If

            If Col15.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = Col15.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            End If

            If Equals(Col16, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = Col16
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = Original_id
            If Equals(Original_Col1, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = Original_Col1
            End If

            If Original_Col2.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = Original_Col2.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            End If

            If Original_Col3.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = Original_Col3.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = System.DBNull.Value
            End If

            If Original_Col4.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = Original_Col4.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = System.DBNull.Value
            End If

            If Original_Col5.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = Original_Col5.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = System.DBNull.Value
            End If

            If Original_Col6.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = Original_Col6.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = System.DBNull.Value
            End If

            If Original_Col7.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((29))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((30))).Value = Original_Col7.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((29))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((30))).Value = System.DBNull.Value
            End If

            If Original_Col8.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((31))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((32))).Value = Original_Col8.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((31))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((32))).Value = System.DBNull.Value
            End If

            If Original_Col9.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((33))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((34))).Value = Original_Col9.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((33))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((34))).Value = System.DBNull.Value
            End If

            If Original_Col10.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = Original_Col10.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = System.DBNull.Value
            End If

            If Original_Col11.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = Original_Col11.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = System.DBNull.Value
            End If

            If Original_Col12.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((39))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((40))).Value = Original_Col12.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((39))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((40))).Value = System.DBNull.Value
            End If

            If Original_Col13.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((41))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((42))).Value = Original_Col13.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((41))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((42))).Value = System.DBNull.Value
            End If

            If Original_Col15.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((43))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((44))).Value = Original_Col15.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((43))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((44))).Value = System.DBNull.Value
            End If

            If Equals(Original_Col16, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((45))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((46))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((45))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((46))).Value = Original_Col16
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((47))).Value = id
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

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(Col1 As String, Col2 As Decimal?, Col3 As Integer?, Col4 As Decimal?, Col5 As Decimal?, Col6 As Decimal?, Col7 As Decimal?, Col8 As Decimal?, Col9 As Decimal?, Col10 As Decimal?, Col11 As Decimal?, Col12 As Decimal?, Col13 As Decimal?, Col14 As String, Col15 As Integer?, Col16 As String, Original_id As Integer, Original_Col1 As String, Original_Col2 As Decimal?, Original_Col3 As Integer?, Original_Col4 As Decimal?, Original_Col5 As Decimal?, Original_Col6 As Decimal?, Original_Col7 As Decimal?, Original_Col8 As Decimal?, Original_Col9 As Decimal?, Original_Col10 As Decimal?, Original_Col11 As Decimal?, Original_Col12 As Decimal?, Original_Col13 As Decimal?, Original_Col15 As Integer?, Original_Col16 As String) As Integer
            Return Me.Update(Col1, Col2, Col3, Col4, Col5, Col6, Col7, Col8, Col9, Col10, Col11, Col12, Col13, Col14, Col15, Col16, Original_id, Original_Col1, Original_Col2, Original_Col3, Original_Col4, Original_Col5, Original_Col6, Original_Col7, Original_Col8, Original_Col9, Original_Col10, Original_Col11, Original_Col12, Original_Col13, Original_Col15, Original_Col16, Original_id)
        End Function
    End Class
End Namespace
