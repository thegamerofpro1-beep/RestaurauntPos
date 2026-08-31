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

    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    Public Class OtherSettingTableAdapter
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.OtherSettingTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
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
            dataTableMapping.ColumnMappings.Add("TaxType", "TaxType")
            dataTableMapping.ColumnMappings.Add("PDP", "PDP")
            dataTableMapping.ColumnMappings.Add("TL", "TL")
            dataTableMapping.ColumnMappings.Add("ECDI", "ECDI")
            dataTableMapping.ColumnMappings.Add("ECDB", "ECDB")
            dataTableMapping.ColumnMappings.Add("ECTA", "ECTA")
            dataTableMapping.ColumnMappings.Add("ECHD", "ECHD")
            dataTableMapping.ColumnMappings.Add("ECEB", "ECEB")
            dataTableMapping.ColumnMappings.Add("A1", "A1")
            dataTableMapping.ColumnMappings.Add("ANB", "ANB")
            dataTableMapping.ColumnMappings.Add("TLAP", "TLAP")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[OtherSetting] WHERE (([ID] = @Original_ID) AND ((@IsNull_ParcelCharges = 1 AND [ParcelCharges] IS NULL) OR ([ParcelCharges] = @Original_ParcelCharges)) AND ((@IsNull_HomeDeliveryCharges = 1 AND [HomeDeliveryCharges] IS NULL) OR ([HomeDeliveryCharges] = @Original_HomeDeliveryCharges)) AND ((@IsNull_VAT = 1 AND [VAT] IS NULL) OR ([VAT] = @Original_VAT)) AND ((@IsNull_ServiceTax = 1 AND [ServiceTax] IS NULL) OR ([ServiceTax] = @Original_ServiceTax)) AND ((@IsNull_ServiceCharges = 1 AND [ServiceCharges] IS NULL) OR ([ServiceCharges] = @Original_ServiceCharges)) AND ((@IsNull_TA = 1 AND [TA] IS NULL) OR ([TA] = @Original_TA)) AND ((@IsNull_HD = 1 AND [HD] IS NULL) OR ([HD] = @Original_HD)) AND ((@IsNull_EB = 1 AND [EB] IS NULL) OR ([EB] = @Original_EB)) AND ((@IsNull_KG = 1 AND [KG] IS NULL) OR ([KG] = @Original_KG)) AND ((@IsNull_TaxType = 1 AND [TaxType] IS NULL) OR ([TaxType] = @Original_TaxType)) AND ((@IsNull_PDP = 1 AND [PDP] IS NULL) OR ([PDP] = @Original_PDP)) AND ((@IsNull_TL = 1 AND [TL] IS NULL) OR ([TL] = @Original_TL)) AND ((@IsNull_ECDI = 1 AND [ECDI] IS NULL) OR ([ECDI] = @Original_ECDI)) AND ((@IsNull_ECDB = 1 AND [ECDB] IS NULL) OR ([ECDB] = @Original_ECDB)) AND ((@IsNull_ECTA = 1 AND [ECTA] IS NULL) OR ([ECTA] = @Original_ECTA)) AND ((@IsNull_ECHD = 1 AND [ECHD] IS NULL) OR ([ECHD] = @Original_ECHD)) AND ((@IsNull_ECEB = 1 AND [ECEB] IS NULL) OR ([ECEB] = @Original_ECEB)) AND ((@IsNull_A1 = 1 AND [A1] IS NULL) OR ([A1] = @Original_A1)) AND ((@IsNull_ANB = 1 AND [ANB] IS NULL) OR ([ANB] = @Original_ANB)) AND ((@IsNull_TLAP = 1 AND [TLAP] IS NULL) OR ([TLAP] = @Original_TLAP)))"
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
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TaxType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PDP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PDP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PDP", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PDP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TL", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TL", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TL", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECDI", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDI", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECDI", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDI", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECDB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECDB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECTA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECTA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECTA", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECTA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECHD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECHD", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECHD", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECHD", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECEB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECEB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECEB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECEB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_A1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "A1", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_A1", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "A1", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ANB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ANB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ANB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TLAP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TLAP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TLAP", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TLAP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[OtherSetting] ([ParcelCharges], [HomeDeliveryCharges], [VAT], [ServiceTax], [ServiceCharges], [TA], [HD], [EB], [KG], [TaxType], [PDP], [TL], [ECDI], [ECDB], [ECTA], [ECHD], [ECEB], [A1], [ANB], [TLAP]) VALUES (@ParcelCharges, @HomeDeliveryCharges, @VAT, @ServiceTax, @ServiceCharges, @TA, @HD, @EB, @KG, @TaxType, @PDP, @TL, @ECDI, @ECDB, @ECTA, @ECHD, @ECEB, @A1, @ANB, @TLAP); SELECT ID, ParcelCharges, HomeDeliveryCharges, VAT, ServiceTax, ServiceCharges, TA, HD, EB, KG, TaxType, PDP, TL, ECDI, ECDB, ECTA, ECHD, ECEB, A1, ANB, TLAP FROM OtherSetting WHERE (ID = SCOPE_IDENTITY())"
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
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PDP", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PDP", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TL", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TL", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECDI", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDI", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECDB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDB", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECTA", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECTA", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECHD", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECHD", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECEB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECEB", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@A1", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "A1", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ANB", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TLAP", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TLAP", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[OtherSetting] SET [ParcelCharges] = @ParcelCharges, [HomeDeliveryCharges] = @HomeDeliveryCharges, [VAT] = @VAT, [ServiceTax] = @ServiceTax, [ServiceCharges] = @ServiceCharges, [TA] = @TA, [HD] = @HD, [EB] = @EB, [KG] = @KG, [TaxType] = @TaxType, [PDP] = @PDP, [TL] = @TL, [ECDI] = @ECDI, [ECDB] = @ECDB, [ECTA] = @ECTA, [ECHD] = @ECHD, [ECEB] = @ECEB, [A1] = @A1, [ANB] = @ANB, [TLAP] = @TLAP WHERE (([ID] = @Original_ID) AND ((@IsNull_ParcelCharges = 1 AND [ParcelCharges] IS NULL) OR ([ParcelCharges] = @Original_ParcelCharges)) AND ((@IsNull_HomeDeliveryCharges = 1 AND [HomeDeliveryCharges] IS NULL) OR ([HomeDeliveryCharges] = @Original_HomeDeliveryCharges)) AND ((@IsNull_VAT = 1 AND [VAT] IS NULL) OR ([VAT] = @Original_VAT)) AND ((@IsNull_ServiceTax = 1 AND [ServiceTax] IS NULL) OR ([ServiceTax] = @Original_ServiceTax)) AND ((@IsNull_ServiceCharges = 1 AND [ServiceCharges] IS NULL) OR ([ServiceCharges] = @Original_ServiceCharges)) AND ((@IsNull_TA = 1 AND [TA] IS NULL) OR ([TA] = @Original_TA)) AND ((@IsNull_HD = 1 AND [HD] IS NULL) OR ([HD] = @Original_HD)) AND ((@IsNull_EB = 1 AND [EB] IS NULL) OR ([EB] = @Original_EB)) AND ((@IsNull_KG = 1 AND [KG] IS NULL) OR ([KG] = @Original_KG)) AND ((@IsNull_TaxType = 1 AND [TaxType] IS NULL) OR ([TaxType] = @Original_TaxType)) AND ((@IsNull_PDP = 1 AND [PDP] IS NULL) OR ([PDP] = @Original_PDP)) AND ((@IsNull_TL = 1 AND [TL] IS NULL) OR ([TL] = @Original_TL)) AND ((@IsNull_ECDI = 1 AND [ECDI] IS NULL) OR ([ECDI] = @Original_ECDI)) AND ((@IsNull_ECDB = 1 AND [ECDB] IS NULL) OR ([ECDB] = @Original_ECDB)) AND ((@IsNull_ECTA = 1 AND [ECTA] IS NULL) OR ([ECTA] = @Original_ECTA)) AND ((@IsNull_ECHD = 1 AND [ECHD] IS NULL) OR ([ECHD] = @Original_ECHD)) AND ((@IsNull_ECEB = 1 AND [ECEB] IS NULL) OR ([ECEB] = @Original_ECEB)) AND ((@IsNull_A1 = 1 AND [A1] IS NULL) OR ([A1] = @Original_A1)) AND ((@IsNull_ANB = 1 AND [ANB] IS NULL) OR ([ANB] = @Original_ANB)) AND ((@IsNull_TLAP = 1 AND [TLAP] IS NULL) OR ([TLAP] = @Original_TLAP))); SELECT ID, ParcelCharges, HomeDeliveryCharges, VAT, ServiceTax, ServiceCharges, TA, HD, EB, KG, TaxType, PDP, TL, ECDI, ECDB, ECTA, ECHD, ECEB, A1, ANB, TLAP FROM OtherSetting WHERE (ID = @ID)"
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
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PDP", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PDP", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TL", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TL", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECDI", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDI", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECDB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDB", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECTA", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECTA", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECHD", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECHD", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ECEB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECEB", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@A1", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "A1", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ANB", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TLAP", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TLAP", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
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
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TaxType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TaxType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TaxType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PDP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PDP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PDP", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PDP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TL", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TL", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TL", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TL", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECDI", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDI", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECDI", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDI", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECDB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECDB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECDB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECTA", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECTA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECTA", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECTA", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECHD", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECHD", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECHD", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECHD", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ECEB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ECEB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ECEB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ECEB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_A1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "A1", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_A1", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "A1", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ANB", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ANB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANB", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ANB", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TLAP", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TLAP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TLAP", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TLAP", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT ID, ParcelCharges, HomeDeliveryCharges, VAT, ServiceTax, ServiceCharges, TA, HD, EB, KG, TaxType, PDP, TL, ECDI, ECDB, ECTA, ECHD, ECEB, A1, ANB, TLAP FROM dbo.OtherSetting"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.OtherSettingDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.OtherSettingDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim otherSettingDataTable As RestaurantPOS14.RPOS_DBDataSet1.OtherSettingDataTable = New RestaurantPOS14.RPOS_DBDataSet1.OtherSettingDataTable()
            Me.Adapter.Fill(otherSettingDataTable)
            Return otherSettingDataTable
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.OtherSettingDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "OtherSetting")
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

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        Public Overridable Function Delete(Original_ID As Integer, Original_ParcelCharges As Decimal?, Original_HomeDeliveryCharges As Decimal?, Original_VAT As Decimal?, Original_ServiceTax As Decimal?, Original_ServiceCharges As Decimal?, Original_TA As String, Original_HD As String, Original_EB As String, Original_KG As String, Original_TaxType As String, Original_PDP As String, Original_TL As String, Original_ECDI As String, Original_ECDB As String, Original_ECTA As String, Original_ECHD As String, Original_ECEB As String, Original_A1 As String, Original_ANB As String, Original_TLAP As String) As Integer
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

            If Equals(Original_TaxType, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((20))).Value = Original_TaxType
            End If

            If Equals(Original_PDP, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((21))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((22))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((21))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((22))).Value = Original_PDP
            End If

            If Equals(Original_TL, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((23))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((24))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((23))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((24))).Value = Original_TL
            End If

            If Equals(Original_ECDI, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((25))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((26))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((25))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((26))).Value = Original_ECDI
            End If

            If Equals(Original_ECDB, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((27))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((28))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((27))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((28))).Value = Original_ECDB
            End If

            If Equals(Original_ECTA, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((29))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((30))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((29))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((30))).Value = Original_ECTA
            End If

            If Equals(Original_ECHD, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((31))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((32))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((31))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((32))).Value = Original_ECHD
            End If

            If Equals(Original_ECEB, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((33))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((34))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((33))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((34))).Value = Original_ECEB
            End If

            If Equals(Original_A1, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((35))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((36))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((35))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((36))).Value = Original_A1
            End If

            If Equals(Original_ANB, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((37))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((38))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((37))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((38))).Value = Original_ANB
            End If

            If Equals(Original_TLAP, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((39))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((40))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((39))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((40))).Value = Original_TLAP
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
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Insert(ParcelCharges As Decimal?, HomeDeliveryCharges As Decimal?, VAT As Decimal?, ServiceTax As Decimal?, ServiceCharges As Decimal?, TA As String, HD As String, EB As String, KG As String, TaxType As String, PDP As String, TL As String, ECDI As String, ECDB As String, ECTA As String, ECHD As String, ECEB As String, A1 As String, ANB As String, TLAP As String) As Integer
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

            If Equals(TaxType, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = TaxType
            End If

            If Equals(PDP, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((10))).Value = PDP
            End If

            If Equals(TL, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((11))).Value = TL
            End If

            If Equals(ECDI, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((12))).Value = ECDI
            End If

            If Equals(ECDB, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((13))).Value = ECDB
            End If

            If Equals(ECTA, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((14))).Value = ECTA
            End If

            If Equals(ECHD, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((15))).Value = ECHD
            End If

            If Equals(ECEB, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((16))).Value = ECEB
            End If

            If Equals(A1, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((17))).Value = A1
            End If

            If Equals(ANB, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((18))).Value = ANB
            End If

            If Equals(TLAP, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((19))).Value = TLAP
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
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        Public Overridable Function Update(ParcelCharges As Decimal?, HomeDeliveryCharges As Decimal?, VAT As Decimal?, ServiceTax As Decimal?, ServiceCharges As Decimal?, TA As String, HD As String, EB As String, KG As String, TaxType As String, PDP As String, TL As String, ECDI As String, ECDB As String, ECTA As String, ECHD As String, ECEB As String, A1 As String, ANB As String, TLAP As String, Original_ID As Integer, Original_ParcelCharges As Decimal?, Original_HomeDeliveryCharges As Decimal?, Original_VAT As Decimal?, Original_ServiceTax As Decimal?, Original_ServiceCharges As Decimal?, Original_TA As String, Original_HD As String, Original_EB As String, Original_KG As String, Original_TaxType As String, Original_PDP As String, Original_TL As String, Original_ECDI As String, Original_ECDB As String, Original_ECTA As String, Original_ECHD As String, Original_ECEB As String, Original_A1 As String, Original_ANB As String, Original_TLAP As String, ID As Integer) As Integer
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

            If Equals(TaxType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = TaxType
            End If

            If Equals(PDP, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = PDP
            End If

            If Equals(TL, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = TL
            End If

            If Equals(ECDI, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = ECDI
            End If

            If Equals(ECDB, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = ECDB
            End If

            If Equals(ECTA, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = ECTA
            End If

            If Equals(ECHD, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = ECHD
            End If

            If Equals(ECEB, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = ECEB
            End If

            If Equals(A1, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = A1
            End If

            If Equals(ANB, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = ANB
            End If

            If Equals(TLAP, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = TLAP
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = Original_ID
            If Original_ParcelCharges.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = Original_ParcelCharges.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = System.DBNull.Value
            End If

            If Original_HomeDeliveryCharges.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = Original_HomeDeliveryCharges.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = System.DBNull.Value
            End If

            If Original_VAT.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = Original_VAT.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = System.DBNull.Value
            End If

            If Original_ServiceTax.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = Original_ServiceTax.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = System.DBNull.Value
            End If

            If Original_ServiceCharges.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((29))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((30))).Value = Original_ServiceCharges.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((29))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((30))).Value = System.DBNull.Value
            End If

            If Equals(Original_TA, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((31))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((32))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((31))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((32))).Value = Original_TA
            End If

            If Equals(Original_HD, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((33))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((34))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((33))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((34))).Value = Original_HD
            End If

            If Equals(Original_EB, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = Original_EB
            End If

            If Equals(Original_KG, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = Original_KG
            End If

            If Equals(Original_TaxType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((39))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((40))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((39))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((40))).Value = Original_TaxType
            End If

            If Equals(Original_PDP, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((41))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((42))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((41))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((42))).Value = Original_PDP
            End If

            If Equals(Original_TL, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((43))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((44))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((43))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((44))).Value = Original_TL
            End If

            If Equals(Original_ECDI, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((45))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((46))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((45))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((46))).Value = Original_ECDI
            End If

            If Equals(Original_ECDB, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((47))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((48))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((47))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((48))).Value = Original_ECDB
            End If

            If Equals(Original_ECTA, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((49))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((50))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((49))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((50))).Value = Original_ECTA
            End If

            If Equals(Original_ECHD, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((51))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((52))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((51))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((52))).Value = Original_ECHD
            End If

            If Equals(Original_ECEB, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((53))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((54))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((53))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((54))).Value = Original_ECEB
            End If

            If Equals(Original_A1, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((55))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((56))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((55))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((56))).Value = Original_A1
            End If

            If Equals(Original_ANB, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((57))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((58))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((57))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((58))).Value = Original_ANB
            End If

            If Equals(Original_TLAP, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((59))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((60))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((59))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((60))).Value = Original_TLAP
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((61))).Value = ID
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
        Public Overridable Function Update(ParcelCharges As Decimal?, HomeDeliveryCharges As Decimal?, VAT As Decimal?, ServiceTax As Decimal?, ServiceCharges As Decimal?, TA As String, HD As String, EB As String, KG As String, TaxType As String, PDP As String, TL As String, ECDI As String, ECDB As String, ECTA As String, ECHD As String, ECEB As String, A1 As String, ANB As String, TLAP As String, Original_ID As Integer, Original_ParcelCharges As Decimal?, Original_HomeDeliveryCharges As Decimal?, Original_VAT As Decimal?, Original_ServiceTax As Decimal?, Original_ServiceCharges As Decimal?, Original_TA As String, Original_HD As String, Original_EB As String, Original_KG As String, Original_TaxType As String, Original_PDP As String, Original_TL As String, Original_ECDI As String, Original_ECDB As String, Original_ECTA As String, Original_ECHD As String, Original_ECEB As String, Original_A1 As String, Original_ANB As String, Original_TLAP As String) As Integer
            Return Me.Update(ParcelCharges, HomeDeliveryCharges, VAT, ServiceTax, ServiceCharges, TA, HD, EB, KG, TaxType, PDP, TL, ECDI, ECDB, ECTA, ECHD, ECEB, A1, ANB, TLAP, Original_ID, Original_ParcelCharges, Original_HomeDeliveryCharges, Original_VAT, Original_ServiceTax, Original_ServiceCharges, Original_TA, Original_HD, Original_EB, Original_KG, Original_TaxType, Original_PDP, Original_TL, Original_ECDI, Original_ECDB, Original_ECTA, Original_ECHD, Original_ECEB, Original_A1, Original_ANB, Original_TLAP, Original_ID)
        End Function
    End Class
End Namespace
