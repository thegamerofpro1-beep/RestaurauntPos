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

    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.DataObjectAttribute(True)>
    Public Class PurchaseOrder_JoinTableAdapter
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.PurchaseOrder_JoinTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "PurchaseOrder_Join"
            dataTableMapping.ColumnMappings.Add("POJ_ID", "POJ_ID")
            dataTableMapping.ColumnMappings.Add("PurchaseOrderID", "PurchaseOrderID")
            dataTableMapping.ColumnMappings.Add("ProductID", "ProductID")
            dataTableMapping.ColumnMappings.Add("Qty", "Qty")
            dataTableMapping.ColumnMappings.Add("PricePerUnit", "PricePerUnit")
            dataTableMapping.ColumnMappings.Add("Amount", "Amount")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[PurchaseOrder_Join] WHERE (([POJ_ID] = @Original_POJ_ID) AND ([PurchaseOrderID] = @Original_PurchaseOrderID) AND ([ProductID] = @Original_ProductID) AND ([Qty] = @Original_Qty) AND ((@IsNull_PricePerUnit = 1 AND [PricePerUnit] IS NULL) OR ([PricePerUnit] = @Original_PricePerUnit)) AND ((@IsNull_Amount = 1 AND [Amount] IS NULL) OR ([Amount] = @Original_Amount)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_POJ_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "POJ_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PurchaseOrderID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PurchaseOrderID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ProductID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Qty", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Qty", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PricePerUnit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PricePerUnit", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PricePerUnit", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PricePerUnit", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Amount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Amount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[PurchaseOrder_Join] ([PurchaseOrderID], [ProductID], [Qty], [PricePerUnit], [Amount]) VALUES (@PurchaseOrderID, @ProductID, @Qty, @PricePerUnit, @Amount);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT POJ_ID, PurchaseOrderID, ProductID, Qty, PricePerUnit, Amount FROM PurchaseOrder_Join WHERE (POJ_ID = SCOPE_IDENTITY())"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PurchaseOrderID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PurchaseOrderID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ProductID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Qty", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Qty", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PricePerUnit", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PricePerUnit", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Amount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[PurchaseOrder_Join] SET [PurchaseOrderID] = @PurchaseOrderID, [ProductID] = @ProductID, [Qty] = @Qty, [PricePerUnit] = @PricePerUnit, [Amount] = @Amount WHERE (([POJ_ID] = @Original_POJ_ID) AND ([PurchaseOrderID] = @Original_PurchaseOrderID) AND ([ProductID] = @Original_ProductID) AND ([Qty] = @Original_Qty) AND ((@IsNull_PricePerUnit = 1 AND [PricePerUnit] IS NULL) OR ([PricePerUnit] = @Original_PricePerUnit)) AND ((@IsNull_Amount = 1 AND [Amount] IS NULL) OR ([Amount] = @Original_Amount)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT POJ_ID, PurchaseOrderID, ProductID, Qty, PricePerUnit, Amount FROM PurchaseOrder_Join WHERE (POJ_ID = @POJ_ID)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PurchaseOrderID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PurchaseOrderID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ProductID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Qty", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Qty", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PricePerUnit", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PricePerUnit", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Amount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_POJ_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "POJ_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PurchaseOrderID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PurchaseOrderID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ProductID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Qty", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Qty", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PricePerUnit", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PricePerUnit", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PricePerUnit", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "PricePerUnit", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Amount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "Amount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@POJ_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, 0, 0, "POJ_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT POJ_ID, PurchaseOrderID, ProductID, Qty, PricePerUnit, Amount FROM dbo.PurchaseOrder_Join"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrder_JoinDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrder_JoinDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim purchaseOrder_JoinDataTable As RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrder_JoinDataTable = New RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrder_JoinDataTable()
            Me.Adapter.Fill(purchaseOrder_JoinDataTable)
            Return purchaseOrder_JoinDataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.PurchaseOrder_JoinDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "PurchaseOrder_Join")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Delete(Original_POJ_ID As Integer, Original_PurchaseOrderID As Integer, Original_ProductID As Integer, Original_Qty As Decimal, Original_PricePerUnit As Decimal?, Original_Amount As Decimal?) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_POJ_ID
            Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = Original_PurchaseOrderID
            Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_ProductID
            Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = Original_Qty
            If Original_PricePerUnit.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = Original_PricePerUnit.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If Original_Amount.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = Original_Amount.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = System.DBNull.Value
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
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        Public Overridable Function Insert(PurchaseOrderID As Integer, ProductID As Integer, Qty As Decimal, PricePerUnit As Decimal?, Amount As Decimal?) As Integer
            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = PurchaseOrderID
            Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = ProductID
            Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = Qty
            If PricePerUnit.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = PricePerUnit.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If Amount.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = Amount.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
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
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(PurchaseOrderID As Integer, ProductID As Integer, Qty As Decimal, PricePerUnit As Decimal?, Amount As Decimal?, Original_POJ_ID As Integer, Original_PurchaseOrderID As Integer, Original_ProductID As Integer, Original_Qty As Decimal, Original_PricePerUnit As Decimal?, Original_Amount As Decimal?, POJ_ID As Integer) As Integer
            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = PurchaseOrderID
            Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = ProductID
            Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = Qty
            If PricePerUnit.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = PricePerUnit.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If Amount.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = Amount.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = Original_POJ_ID
            Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = Original_PurchaseOrderID
            Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = Original_ProductID
            Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Original_Qty
            If Original_PricePerUnit.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = Original_PricePerUnit.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            End If

            If Original_Amount.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = Original_Amount.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = POJ_ID
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

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        Public Overridable Function Update(PurchaseOrderID As Integer, ProductID As Integer, Qty As Decimal, PricePerUnit As Decimal?, Amount As Decimal?, Original_POJ_ID As Integer, Original_PurchaseOrderID As Integer, Original_ProductID As Integer, Original_Qty As Decimal, Original_PricePerUnit As Decimal?, Original_Amount As Decimal?) As Integer
            Return Me.Update(PurchaseOrderID, ProductID, Qty, PricePerUnit, Amount, Original_POJ_ID, Original_PurchaseOrderID, Original_ProductID, Original_Qty, Original_PricePerUnit, Original_Amount, Original_POJ_ID)
        End Function
    End Class
End Namespace
