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

    ''' <summary>
    ''' Represents the connection and commands used to retrieve and save data.
    ''' </summary>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    Public Class CategoryTableAdapter
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Protected Friend ReadOnly Property Adapter As System.Data.SqlClient.SqlDataAdapter
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CategoryTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "Category"
            dataTableMapping.ColumnMappings.Add("CategoryName", "CategoryName")
            dataTableMapping.ColumnMappings.Add("VAT", "VAT")
            dataTableMapping.ColumnMappings.Add("ST", "ST")
            dataTableMapping.ColumnMappings.Add("SC", "SC")
            dataTableMapping.ColumnMappings.Add("BackColor", "BackColor")
            dataTableMapping.ColumnMappings.Add("Cat_ID", "Cat_ID")
            dataTableMapping.ColumnMappings.Add("Kitchen", "Kitchen")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[Category] WHERE (([CategoryName] = @Original_CategoryName) AND ((@IsNull_VAT = 1 AND [VAT] IS NULL) OR ([VAT] = @Original_VAT)) AND ((@IsNull_ST = 1 AND [ST] IS NULL) OR ([ST] = @Original_ST)) AND ((@IsNull_SC = 1 AND [SC] IS NULL) OR ([SC] = @Original_SC)) AND ((@IsNull_BackColor = 1 AND [BackColor] IS NULL) OR ([BackColor] = @Original_BackColor)) AND ([Cat_ID] = @Original_Cat_ID) AND ((@IsNull_Kitchen = 1 AND [Kitchen] IS NULL) OR ([Kitchen] = @Original_Kitchen)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CategoryName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_VAT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "VAT", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VAT", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VAT", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_SC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "SC", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SC", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SC", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BackColor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BackColor", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BackColor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BackColor", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cat_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Cat_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Kitchen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Kitchen", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Kitchen", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Kitchen", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Category] ([CategoryName], [VAT], [ST], [SC], [BackColor], [Kitchen]) VALUES (@CategoryName, @VAT, @ST, @SC, @BackColor, @Kitchen);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT CategoryName, VAT, ST, SC, BackColor, Cat_ID, Kitchen FROM Category WHERE (CategoryName = @CategoryName)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CategoryName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VAT", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VAT", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ST", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SC", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SC", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BackColor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BackColor", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Kitchen", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Kitchen", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[Category] SET [CategoryName] = @CategoryName, [VAT] = @VAT, [ST] = @ST, [SC] = @SC, [BackColor] = @BackColor, [Kitchen] = @Kitchen WHERE (([CategoryName] = @Original_CategoryName) AND ((@IsNull_VAT = 1 AND [VAT] IS NULL) OR ([VAT] = @Original_VAT)) AND ((@IsNull_ST = 1 AND [ST] IS NULL) OR ([ST] = @Original_ST)) AND ((@IsNull_SC = 1 AND [SC] IS NULL) OR ([SC] = @Original_SC)) AND ((@IsNull_BackColor = 1 AND [BackColor] IS NULL) OR ([BackColor] = @Original_BackColor)) AND ([Cat_ID] = @Original_Cat_ID) AND ((@IsNull_Kitchen = 1 AND [Kitchen] IS NULL) OR ([Kitchen] = @Original_Kitchen)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT CategoryName, VAT, ST, SC, BackColor, Cat_ID, Kitchen FROM Category WHERE (CategoryName = @CategoryName)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CategoryName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VAT", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VAT", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ST", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SC", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SC", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BackColor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BackColor", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Kitchen", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Kitchen", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CategoryName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_VAT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "VAT", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VAT", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VAT", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_SC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "SC", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SC", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "SC", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BackColor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BackColor", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BackColor", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BackColor", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cat_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Cat_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Kitchen", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Kitchen", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Kitchen", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Kitchen", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitConnection()
            Me._connection = New System.Data.SqlClient.SqlConnection()
            Me._connection.ConnectionString = RestaurantPOS14.My.MySettings.[Default].RPOS_DBConnectionString
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitCommandCollection()
            Me._commandCollection = New System.Data.SqlClient.SqlCommand(0) {}
            Me._commandCollection(0) = New System.Data.SqlClient.SqlCommand()
            Me._commandCollection(CInt((0))).Connection = Me.Connection
            Me._commandCollection(CInt((0))).CommandText = "SELECT CategoryName, VAT, ST, SC, BackColor, Cat_ID, Kitchen FROM dbo.Category"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.CategoryDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.CategoryDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim categoryDataTable As RestaurantPOS14.RPOS_DBDataSet1.CategoryDataTable = New RestaurantPOS14.RPOS_DBDataSet1.CategoryDataTable()
            Me.Adapter.Fill(categoryDataTable)
            Return categoryDataTable
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.CategoryDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "Category")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Delete(Original_CategoryName As String, Original_VAT As Decimal?, Original_ST As Decimal?, Original_SC As Decimal?, Original_BackColor As Integer?, Original_Cat_ID As Integer, Original_Kitchen As String) As Integer
            If Equals(Original_CategoryName, Nothing) Then
                Throw New System.ArgumentNullException("Original_CategoryName")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_CategoryName
            If Original_VAT.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_VAT.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Original_ST.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_ST.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Original_SC.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_SC.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Original_BackColor.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_BackColor.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = Original_Cat_ID
            If Equals(Original_Kitchen, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = Original_Kitchen
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
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Insert(CategoryName As String, VAT As Decimal?, ST As Decimal?, SC As Decimal?, BackColor As Integer?, Kitchen As String) As Integer
            If Equals(CategoryName, Nothing) Then
                Throw New System.ArgumentNullException("CategoryName")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = CategoryName
            If VAT.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = VAT.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If ST.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = ST.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If SC.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = SC.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If BackColor.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = BackColor.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Equals(Kitchen, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = Kitchen
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(CategoryName As String, VAT As Decimal?, ST As Decimal?, SC As Decimal?, BackColor As Integer?, Kitchen As String, Original_CategoryName As String, Original_VAT As Decimal?, Original_ST As Decimal?, Original_SC As Decimal?, Original_BackColor As Integer?, Original_Cat_ID As Integer, Original_Kitchen As String) As Integer
            If Equals(CategoryName, Nothing) Then
                Throw New System.ArgumentNullException("CategoryName")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = CategoryName
            If VAT.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = VAT.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If ST.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = ST.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If SC.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = SC.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If BackColor.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = BackColor.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Equals(Kitchen, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = Kitchen
            End If

            If Equals(Original_CategoryName, Nothing) Then
                Throw New System.ArgumentNullException("Original_CategoryName")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = Original_CategoryName
            If Original_VAT.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Original_VAT.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Original_ST.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = Original_ST.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            End If

            If Original_SC.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = Original_SC.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            End If

            If Original_BackColor.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = Original_BackColor.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = Original_Cat_ID
            If Equals(Original_Kitchen, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = Original_Kitchen
            End If

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
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(VAT As Decimal?, ST As Decimal?, SC As Decimal?, BackColor As Integer?, Kitchen As String, Original_CategoryName As String, Original_VAT As Decimal?, Original_ST As Decimal?, Original_SC As Decimal?, Original_BackColor As Integer?, Original_Cat_ID As Integer, Original_Kitchen As String) As Integer
            Return Me.Update(Original_CategoryName, VAT, ST, SC, BackColor, Kitchen, Original_CategoryName, Original_VAT, Original_ST, Original_SC, Original_BackColor, Original_Cat_ID, Original_Kitchen)
        End Function
    End Class
End Namespace
