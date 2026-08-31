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
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    <System.ComponentModel.DataObjectAttribute(True)>
    Public Class CreditCustomerTableAdapter
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.CreditCustomerTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "CreditCustomer"
            dataTableMapping.ColumnMappings.Add("CC_ID", "CC_ID")
            dataTableMapping.ColumnMappings.Add("CreditCustomerID", "CreditCustomerID")
            dataTableMapping.ColumnMappings.Add("Name", "Name")
            dataTableMapping.ColumnMappings.Add("ContactNo", "ContactNo")
            dataTableMapping.ColumnMappings.Add("Address", "Address")
            dataTableMapping.ColumnMappings.Add("OpeningBalance", "OpeningBalance")
            dataTableMapping.ColumnMappings.Add("OpeningBalanceType", "OpeningBalanceType")
            dataTableMapping.ColumnMappings.Add("RegistrationDate", "RegistrationDate")
            dataTableMapping.ColumnMappings.Add("Active", "Active")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[CreditCustomer] WHERE (([CC_ID] = @Original_CC_ID) AND ([CreditCustomerID] = @Original_CreditCustomerID) AND ((@IsNull_Name = 1 AND [Name] IS NULL) OR ([Name] = @Original_Name)) AND ((@IsNull_ContactNo = 1 AND [ContactNo] IS NULL) OR ([ContactNo] = @Original_ContactNo)) AND ((@IsNull_OpeningBalance = 1 AND [OpeningBalance] IS NULL) OR ([OpeningBalance] = @Original_OpeningBalance)) AND ((@IsNull_OpeningBalanceType = 1 AND [OpeningBalanceType] IS NULL) OR ([OpeningBalanceType] = @Original_OpeningBalanceType)) AND ((@IsNull_RegistrationDate = 1 AND [RegistrationDate] IS NULL) OR ([RegistrationDate] = @Original_RegistrationDate)) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CC_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CC_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreditCustomerID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CreditCustomerID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ContactNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningBalance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalance", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningBalance", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OpeningBalance", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningBalanceType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningBalanceType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_RegistrationDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "RegistrationDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RegistrationDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "RegistrationDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[CreditCustomer] ([CC_ID], [CreditCustomerID], [Name], [ContactNo], [Address], [OpeningBalance], [OpeningBalanceType], [RegistrationDate], [Active]) VALUES (@CC_ID, @CreditCustomerID, @Name, @ContactNo, @Address, @OpeningBalance, @OpeningBalanceType, @RegistrationDate, @Active);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT CC_ID, CreditCustomerID, Name, ContactNo, Address, OpeningBalance, OpeningBalanceType, RegistrationDate, Active FROM CreditCustomer WHERE (CC_ID = @CC_ID)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CC_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CC_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreditCustomerID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CreditCustomerID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningBalance", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OpeningBalance", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningBalanceType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RegistrationDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "RegistrationDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[CreditCustomer] SET [CC_ID] = @CC_ID, [CreditCustomerID] = @CreditCustomerID, [Name] = @Name, [ContactNo] = @ContactNo, [Address] = @Address, [OpeningBalance] = @OpeningBalance, [OpeningBalanceType] = @OpeningBalanceType, [RegistrationDate] = @RegistrationDate, [Active] = @Active WHERE (([CC_ID] = @Original_CC_ID) AND ([CreditCustomerID] = @Original_CreditCustomerID) AND ((@IsNull_Name = 1 AND [Name] IS NULL) OR ([Name] = @Original_Name)) AND ((@IsNull_ContactNo = 1 AND [ContactNo] IS NULL) OR ([ContactNo] = @Original_ContactNo)) AND ((@IsNull_OpeningBalance = 1 AND [OpeningBalance] IS NULL) OR ([OpeningBalance] = @Original_OpeningBalance)) AND ((@IsNull_OpeningBalanceType = 1 AND [OpeningBalanceType] IS NULL) OR ([OpeningBalanceType] = @Original_OpeningBalanceType)) AND ((@IsNull_RegistrationDate = 1 AND [RegistrationDate] IS NULL) OR ([RegistrationDate] = @Original_RegistrationDate)) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT CC_ID, CreditCustomerID, Name, ContactNo, Address, OpeningBalance, OpeningBalanceType, RegistrationDate, Active FROM CreditCustomer WHERE (CC_ID = @CC_ID)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CC_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CC_ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreditCustomerID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CreditCustomerID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningBalance", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OpeningBalance", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningBalanceType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RegistrationDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "RegistrationDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CC_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CC_ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreditCustomerID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CreditCustomerID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ContactNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningBalance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalance", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningBalance", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OpeningBalance", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningBalanceType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningBalanceType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_RegistrationDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "RegistrationDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_RegistrationDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "RegistrationDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT CC_ID, CreditCustomerID, Name, ContactNo, Address, OpeningBalance, OpeningBalanceType, RegistrationDate, Active FROM dbo.CreditCustomer"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.CreditCustomerDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.CreditCustomerDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim creditCustomerDataTable As RestaurantPOS14.RPOS_DBDataSet1.CreditCustomerDataTable = New RestaurantPOS14.RPOS_DBDataSet1.CreditCustomerDataTable()
            Me.Adapter.Fill(creditCustomerDataTable)
            Return creditCustomerDataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.CreditCustomerDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "CreditCustomer")
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Delete(Original_CC_ID As Integer, Original_CreditCustomerID As String, Original_Name As String, Original_ContactNo As String, Original_OpeningBalance As Decimal?, Original_OpeningBalanceType As String, Original_RegistrationDate As System.DateTime?, Original_Active As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_CC_ID
            If Equals(Original_CreditCustomerID, Nothing) Then
                Throw New System.ArgumentNullException("Original_CreditCustomerID")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = Original_CreditCustomerID
            If Equals(Original_Name, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = Original_Name
            End If

            If Equals(Original_ContactNo, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = Original_ContactNo
            End If

            If Original_OpeningBalance.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = Original_OpeningBalance.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If Equals(Original_OpeningBalanceType, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = Original_OpeningBalanceType
            End If

            If Original_RegistrationDate.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = Original_RegistrationDate.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            End If

            If Equals(Original_Active, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = Original_Active
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
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Insert(CC_ID As Integer, CreditCustomerID As String, Name As String, ContactNo As String, Address As String, OpeningBalance As Decimal?, OpeningBalanceType As String, RegistrationDate As System.DateTime?, Active As String) As Integer
            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = CC_ID
            If Equals(CreditCustomerID, Nothing) Then
                Throw New System.ArgumentNullException("CreditCustomerID")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = CreditCustomerID
            If Equals(Name, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = Name
            End If

            If Equals(ContactNo, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = ContactNo
            End If

            If Equals(Address, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = Address
            End If

            If OpeningBalance.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = OpeningBalance.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If Equals(OpeningBalanceType, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = OpeningBalanceType
            End If

            If RegistrationDate.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = RegistrationDate.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If Equals(Active, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = Active
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
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(CC_ID As Integer, CreditCustomerID As String, Name As String, ContactNo As String, Address As String, OpeningBalance As Decimal?, OpeningBalanceType As String, RegistrationDate As System.DateTime?, Active As String, Original_CC_ID As Integer, Original_CreditCustomerID As String, Original_Name As String, Original_ContactNo As String, Original_OpeningBalance As Decimal?, Original_OpeningBalanceType As String, Original_RegistrationDate As System.DateTime?, Original_Active As String) As Integer
            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = CC_ID
            If Equals(CreditCustomerID, Nothing) Then
                Throw New System.ArgumentNullException("CreditCustomerID")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = CreditCustomerID
            If Equals(Name, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = Name
            End If

            If Equals(ContactNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = ContactNo
            End If

            If Equals(Address, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = Address
            End If

            If OpeningBalance.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = OpeningBalance.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            End If

            If Equals(OpeningBalanceType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = OpeningBalanceType
            End If

            If RegistrationDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = RegistrationDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If Equals(Active, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Active
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = Original_CC_ID
            If Equals(Original_CreditCustomerID, Nothing) Then
                Throw New System.ArgumentNullException("Original_CreditCustomerID")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = Original_CreditCustomerID
            If Equals(Original_Name, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = Original_Name
            End If

            If Equals(Original_ContactNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = Original_ContactNo
            End If

            If Original_OpeningBalance.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = Original_OpeningBalance.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            End If

            If Equals(Original_OpeningBalanceType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = Original_OpeningBalanceType
            End If

            If Original_RegistrationDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = Original_RegistrationDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            End If

            If Equals(Original_Active, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = Original_Active
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

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(CreditCustomerID As String, Name As String, ContactNo As String, Address As String, OpeningBalance As Decimal?, OpeningBalanceType As String, RegistrationDate As System.DateTime?, Active As String, Original_CC_ID As Integer, Original_CreditCustomerID As String, Original_Name As String, Original_ContactNo As String, Original_OpeningBalance As Decimal?, Original_OpeningBalanceType As String, Original_RegistrationDate As System.DateTime?, Original_Active As String) As Integer
            Return Me.Update(Original_CC_ID, CreditCustomerID, Name, ContactNo, Address, OpeningBalance, OpeningBalanceType, RegistrationDate, Active, Original_CC_ID, Original_CreditCustomerID, Original_Name, Original_ContactNo, Original_OpeningBalance, Original_OpeningBalanceType, Original_RegistrationDate, Original_Active)
        End Function
    End Class
End Namespace
