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
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    Public Class OtherSettingTableAdapter
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
            SyncLock RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.OtherSettingTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "OtherSetting"
            dataTableMapping.ColumnMappings.Add("ID", "ID")
            dataTableMapping.ColumnMappings.Add("ParcelCharges", "ParcelCharges")
            dataTableMapping.ColumnMappings.Add("HomeDeliveryCharges", "HomeDeliveryCharges")
            dataTableMapping.ColumnMappings.Add("VAT", "VAT")
            dataTableMapping.ColumnMappings.Add("ServiceTax", "ServiceTax")
            dataTableMapping.ColumnMappings.Add("ServiceCharges", "ServiceCharges")
            dataTableMapping.ColumnMappings.Add("TA", "TA")
            dataTableMapping.ColumnMappings.Add("HD", "HD")
            dataTableMapping.ColumnMappings.Add("EB", "EB")
            dataTableMapping.ColumnMappings.Add("KG", "KG")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[OtherSetting] WHERE (([ID] = @Original_ID) AND ((@IsNull_ParcelCharges = 1 AND [ParcelCharges] IS NULL) OR ([ParcelCharges] = @Original_ParcelCharges)) AND ((@IsNull_HomeDeliveryCharges = 1 AND [HomeDeliveryCharges] IS NULL) OR ([HomeDeliveryCharges] = @Original_HomeDeliveryCharges)) AND ((@IsNull_VAT = 1 AND [VAT] IS NULL) OR ([VAT] = @Original_VAT)) AND ((@IsNull_ServiceTax = 1 AND [ServiceTax] IS NULL) OR ([ServiceTax] = @Original_ServiceTax)) AND ((@IsNull_ServiceCharges = 1 AND [ServiceCharges] IS NULL) OR ([ServiceCharges] = @Original_ServiceCharges)) AND ((@IsNull_TA = 1 AND [TA] IS NULL) OR ([TA] = @Original_TA)) AND ((@IsNull_HD = 1 AND [HD] IS NULL) OR ([HD] = @Original_HD)) AND ((@IsNull_EB = 1 AND [EB] IS NULL) OR ([EB] = @Original_EB)) AND ((@IsNull_KG = 1 AND [KG] IS NULL) OR ([KG] = @Original_KG)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ParcelCharges", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ParcelCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ParcelCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ParcelCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_HomeDeliveryCharges", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "HomeDeliveryCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HomeDeliveryCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HomeDeliveryCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_VAT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "VAT", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VAT", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VAT", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ServiceTax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ServiceTax", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ServiceTax", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ServiceTax", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ServiceCharges", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ServiceCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ServiceCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ServiceCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TA", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_HD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "HD", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HD", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "HD", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_EB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_KG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "KG", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KG", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "KG", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[OtherSetting] ([ParcelCharges], [HomeDeliveryCharges], [VAT], [ServiceTax], [ServiceCharges], [TA], [HD], [EB], [KG]) VALUES (@ParcelCharges, @HomeDeliveryCharges, @VAT, @ServiceTax, @ServiceCharges, @TA, @HD, @EB, @KG); SELECT ID, ParcelCharges, HomeDeliveryCharges, VAT, ServiceTax, ServiceCharges, TA, HD, EB, KG FROM OtherSetting WHERE (ID = SCOPE_IDENTITY())"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ParcelCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ParcelCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HomeDeliveryCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HomeDeliveryCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VAT", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VAT", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ServiceTax", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ServiceTax", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ServiceCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ServiceCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TA", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TA", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HD", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "HD", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EB", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KG", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "KG", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[OtherSetting] SET [ParcelCharges] = @ParcelCharges, [HomeDeliveryCharges] = @HomeDeliveryCharges, [VAT] = @VAT, [ServiceTax] = @ServiceTax, [ServiceCharges] = @ServiceCharges, [TA] = @TA, [HD] = @HD, [EB] = @EB, [KG] = @KG WHERE (([ID] = @Original_ID) AND ((@IsNull_ParcelCharges = 1 AND [ParcelCharges] IS NULL) OR ([ParcelCharges] = @Original_ParcelCharges)) AND ((@IsNull_HomeDeliveryCharges = 1 AND [HomeDeliveryCharges] IS NULL) OR ([HomeDeliveryCharges] = @Original_HomeDeliveryCharges)) AND ((@IsNull_VAT = 1 AND [VAT] IS NULL) OR ([VAT] = @Original_VAT)) AND ((@IsNull_ServiceTax = 1 AND [ServiceTax] IS NULL) OR ([ServiceTax] = @Original_ServiceTax)) AND ((@IsNull_ServiceCharges = 1 AND [ServiceCharges] IS NULL) OR ([ServiceCharges] = @Original_ServiceCharges)) AND ((@IsNull_TA = 1 AND [TA] IS NULL) OR ([TA] = @Original_TA)) AND ((@IsNull_HD = 1 AND [HD] IS NULL) OR ([HD] = @Original_HD)) AND ((@IsNull_EB = 1 AND [EB] IS NULL) OR ([EB] = @Original_EB)) AND ((@IsNull_KG = 1 AND [KG] IS NULL) OR ([KG] = @Original_KG))); SELECT ID, ParcelCharges, HomeDeliveryCharges, VAT, ServiceTax, ServiceCharges, TA, HD, EB, KG FROM OtherSetting WHERE (ID = @ID)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ParcelCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ParcelCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HomeDeliveryCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HomeDeliveryCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@VAT", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VAT", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ServiceTax", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ServiceTax", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ServiceCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ServiceCharges", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TA", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TA", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@HD", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "HD", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EB", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KG", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "KG", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ParcelCharges", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ParcelCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ParcelCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ParcelCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_HomeDeliveryCharges", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "HomeDeliveryCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HomeDeliveryCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "HomeDeliveryCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_VAT", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "VAT", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_VAT", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "VAT", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ServiceTax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ServiceTax", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ServiceTax", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ServiceTax", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ServiceCharges", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ServiceCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ServiceCharges", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "ServiceCharges", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TA", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_HD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "HD", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_HD", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "HD", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_EB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_KG", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "KG", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KG", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "KG", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT ID, ParcelCharges, HomeDeliveryCharges, VAT, ServiceTax, ServiceCharges, TA, HD, EB, KG FROM dbo.OtherSetting"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet.OtherSettingDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet.OtherSettingDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim otherSettingDataTable As RestaurantPOS14.RPOS_DBDataSet.OtherSettingDataTable = New RestaurantPOS14.RPOS_DBDataSet.OtherSettingDataTable()
            Me.Adapter.Fill(otherSettingDataTable)
            Return otherSettingDataTable
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet.OtherSettingDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "OtherSetting")
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Delete(Original_ID As Integer, Original_ParcelCharges As Decimal?, Original_HomeDeliveryCharges As Decimal?, Original_VAT As Decimal?, Original_ServiceTax As Decimal?, Original_ServiceCharges As Decimal?, Original_TA As String, Original_HD As String, Original_EB As String, Original_KG As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_ID
            If Original_ParcelCharges.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_ParcelCharges.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If Original_HomeDeliveryCharges.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_HomeDeliveryCharges.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Original_VAT.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_VAT.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Original_ServiceTax.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_ServiceTax.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Original_ServiceCharges.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = Original_ServiceCharges.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            End If

            If Equals(Original_TA, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = Original_TA
            End If

            If Equals(Original_HD, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = Original_HD
            End If

            If Equals(Original_EB, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = Original_EB
            End If

            If Equals(Original_KG, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = Original_KG
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

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Insert(ParcelCharges As Decimal?, HomeDeliveryCharges As Decimal?, VAT As Decimal?, ServiceTax As Decimal?, ServiceCharges As Decimal?, TA As String, HD As String, EB As String, KG As String) As Integer
            If ParcelCharges.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = ParcelCharges.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = System.DBNull.Value
            End If

            If HomeDeliveryCharges.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = HomeDeliveryCharges.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If VAT.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = VAT.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If ServiceTax.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = ServiceTax.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If ServiceCharges.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = ServiceCharges.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Equals(TA, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = TA
            End If

            If Equals(HD, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = HD
            End If

            If Equals(EB, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = EB
            End If

            If Equals(KG, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = KG
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
        Public Overridable Function Update(ParcelCharges As Decimal?, HomeDeliveryCharges As Decimal?, VAT As Decimal?, ServiceTax As Decimal?, ServiceCharges As Decimal?, TA As String, HD As String, EB As String, KG As String, Original_ID As Integer, Original_ParcelCharges As Decimal?, Original_HomeDeliveryCharges As Decimal?, Original_VAT As Decimal?, Original_ServiceTax As Decimal?, Original_ServiceCharges As Decimal?, Original_TA As String, Original_HD As String, Original_EB As String, Original_KG As String, ID As Integer) As Integer
            If ParcelCharges.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = ParcelCharges.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = System.DBNull.Value
            End If

            If HomeDeliveryCharges.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = HomeDeliveryCharges.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            End If

            If VAT.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = VAT.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            End If

            If ServiceTax.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = ServiceTax.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If ServiceCharges.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = ServiceCharges.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Equals(TA, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = TA
            End If

            If Equals(HD, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = HD
            End If

            If Equals(EB, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = EB
            End If

            If Equals(KG, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = KG
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = Original_ID
            If Original_ParcelCharges.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = Original_ParcelCharges.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            End If

            If Original_HomeDeliveryCharges.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = Original_HomeDeliveryCharges.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            End If

            If Original_VAT.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = Original_VAT.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            End If

            If Original_ServiceTax.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = Original_ServiceTax.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            End If

            If Original_ServiceCharges.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = Original_ServiceCharges.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            End If

            If Equals(Original_TA, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = Original_TA
            End If

            If Equals(Original_HD, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = Original_HD
            End If

            If Equals(Original_EB, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = Original_EB
            End If

            If Equals(Original_KG, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = Original_KG
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = ID
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
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(ParcelCharges As Decimal?, HomeDeliveryCharges As Decimal?, VAT As Decimal?, ServiceTax As Decimal?, ServiceCharges As Decimal?, TA As String, HD As String, EB As String, KG As String, Original_ID As Integer, Original_ParcelCharges As Decimal?, Original_HomeDeliveryCharges As Decimal?, Original_VAT As Decimal?, Original_ServiceTax As Decimal?, Original_ServiceCharges As Decimal?, Original_TA As String, Original_HD As String, Original_EB As String, Original_KG As String) As Integer
            Return Me.Update(ParcelCharges, HomeDeliveryCharges, VAT, ServiceTax, ServiceCharges, TA, HD, EB, KG, Original_ID, Original_ParcelCharges, Original_HomeDeliveryCharges, Original_VAT, Original_ServiceTax, Original_ServiceCharges, Original_TA, Original_HD, Original_EB, Original_KG, Original_ID)
        End Function
    End Class
End Namespace
