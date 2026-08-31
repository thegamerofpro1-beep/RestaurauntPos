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
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    Public Class BankAccountRegistrationTableAdapter
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
            SyncLock RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSet1TableAdapters.BankAccountRegistrationTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "BankAccountRegistration"
            dataTableMapping.ColumnMappings.Add("AccountNo", "AccountNo")
            dataTableMapping.ColumnMappings.Add("AccountName", "AccountName")
            dataTableMapping.ColumnMappings.Add("AccountType", "AccountType")
            dataTableMapping.ColumnMappings.Add("OpeningDate", "OpeningDate")
            dataTableMapping.ColumnMappings.Add("BalanceAmount", "BalanceAmount")
            dataTableMapping.ColumnMappings.Add("Active", "Active")
            dataTableMapping.ColumnMappings.Add("BranchID", "BranchID")
            dataTableMapping.ColumnMappings.Add("Id", "Id")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[BankAccountRegistration] WHERE (([AccountNo] = @Original_AccountNo) AND ((@IsNull_AccountName = 1 AND [AccountName] IS NULL) OR ([AccountName] = @Original_AccountName)) AND ((@IsNull_AccountType = 1 AND [AccountType] IS NULL) OR ([AccountType] = @Original_AccountType)) AND ((@IsNull_OpeningDate = 1 AND [OpeningDate] IS NULL) OR ([OpeningDate] = @Original_OpeningDate)) AND ((@IsNull_BalanceAmount = 1 AND [BalanceAmount] IS NULL) OR ([BalanceAmount] = @Original_BalanceAmount)) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)) AND ((@IsNull_BranchID = 1 AND [BranchID] IS NULL) OR ([BranchID] = @Original_BranchID)) AND ((@IsNull_Id = 1 AND [Id] IS NULL) OR ([Id] = @Original_Id)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_AccountName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_AccountType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BalanceAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BalanceAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BalanceAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "BalanceAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BranchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BranchID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BranchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BranchID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[BankAccountRegistration] ([AccountNo], [AccountName], [AccountType], [OpeningDate], [BalanceAmount], [Active], [BranchID], [Id]) VALUES (@AccountNo, @AccountName, @AccountType, @OpeningDate, @BalanceAmount, @Active, @BranchID, @Id);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT AccountNo, AccountName, AccountType, OpeningDate, BalanceAmount, Active, BranchID, Id FROM BankAccountRegistration WHERE (AccountNo = @AccountNo)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BalanceAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "BalanceAmount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BranchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BranchID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[BankAccountRegistration] SET [AccountNo] = @AccountNo, [AccountName] = @AccountName, [AccountType] = @AccountType, [OpeningDate] = @OpeningDate, [BalanceAmount] = @BalanceAmount, [Active] = @Active, [BranchID] = @BranchID, [Id] = @Id WHERE (([AccountNo] = @Original_AccountNo) AND ((@IsNull_AccountName = 1 AND [AccountName] IS NULL) OR ([AccountName] = @Original_AccountName)) AND ((@IsNull_AccountType = 1 AND [AccountType] IS NULL) OR ([AccountType] = @Original_AccountType)) AND ((@IsNull_OpeningDate = 1 AND [OpeningDate] IS NULL) OR ([OpeningDate] = @Original_OpeningDate)) AND ((@IsNull_BalanceAmount = 1 AND [BalanceAmount] IS NULL) OR ([BalanceAmount] = @Original_BalanceAmount)) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)) AND ((@IsNull_BranchID = 1 AND [BranchID] IS NULL) OR ([BranchID] = @Original_BranchID)) AND ((@IsNull_Id = 1 AND [Id] IS NULL) OR ([Id] = @Original_Id)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT AccountNo, AccountName, AccountType, OpeningDate, BalanceAmount, Active, BranchID, Id FROM BankAccountRegistration WHERE (AccountNo = @AccountNo)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningDate", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BalanceAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "BalanceAmount", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BranchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BranchID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_AccountName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_AccountType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningDate", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BalanceAmount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BalanceAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BalanceAmount", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "BalanceAmount", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Active", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Active", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Active", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_BranchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BranchID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_BranchID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "BranchID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Id", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT AccountNo, AccountName, AccountType, OpeningDate, BalanceAmount, Active, BranchID, Id FROM dbo.BankAccountRegistration"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet1.BankAccountRegistrationDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet1.BankAccountRegistrationDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim bankAccountRegistrationDataTable As RestaurantPOS14.RPOS_DBDataSet1.BankAccountRegistrationDataTable = New RestaurantPOS14.RPOS_DBDataSet1.BankAccountRegistrationDataTable()
            Me.Adapter.Fill(bankAccountRegistrationDataTable)
            Return bankAccountRegistrationDataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet1.BankAccountRegistrationDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet1) As Integer
            Return Me.Adapter.Update(dataSet, "BankAccountRegistration")
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRow As System.Data.DataRow) As Integer
            Return Me.Adapter.Update(New System.Data.DataRow(0) {dataRow})
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataRows As System.Data.DataRow()) As Integer
            Return Me.Adapter.Update(dataRows)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Delete(Original_AccountNo As String, Original_AccountName As String, Original_AccountType As String, Original_OpeningDate As System.DateTime?, Original_BalanceAmount As Decimal?, Original_Active As String, Original_BranchID As Integer?, Original_Id As Integer?) As Integer
            If Equals(Original_AccountNo, Nothing) Then
                Throw New System.ArgumentNullException("Original_AccountNo")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_AccountNo
            If Equals(Original_AccountName, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = Original_AccountName
            End If

            If Equals(Original_AccountType, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = Original_AccountType
            End If

            If Original_OpeningDate.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = Original_OpeningDate.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Original_BalanceAmount.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = Original_BalanceAmount.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            End If

            If Equals(Original_Active, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = Original_Active
            End If

            If Original_BranchID.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = Original_BranchID.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            End If

            If Original_Id.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = Original_Id.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = System.DBNull.Value
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
        Public Overridable Function Insert(AccountNo As String, AccountName As String, AccountType As String, OpeningDate As System.DateTime?, BalanceAmount As Decimal?, Active As String, BranchID As Integer?, Id As Integer?) As Integer
            If Equals(AccountNo, Nothing) Then
                Throw New System.ArgumentNullException("AccountNo")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = AccountNo
            If Equals(AccountName, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = AccountName
            End If

            If Equals(AccountType, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = AccountType
            End If

            If OpeningDate.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = OpeningDate.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If BalanceAmount.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = BalanceAmount.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Equals(Active, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = Active
            End If

            If BranchID.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = BranchID.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Id.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = Id.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = System.DBNull.Value
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
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(AccountNo As String, AccountName As String, AccountType As String, OpeningDate As System.DateTime?, BalanceAmount As Decimal?, Active As String, BranchID As Integer?, Id As Integer?, Original_AccountNo As String, Original_AccountName As String, Original_AccountType As String, Original_OpeningDate As System.DateTime?, Original_BalanceAmount As Decimal?, Original_Active As String, Original_BranchID As Integer?, Original_Id As Integer?) As Integer
            If Equals(AccountNo, Nothing) Then
                Throw New System.ArgumentNullException("AccountNo")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = AccountNo
            If Equals(AccountName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = AccountName
            End If

            If Equals(AccountType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = AccountType
            End If

            If OpeningDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = OpeningDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            End If

            If BalanceAmount.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = BalanceAmount.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            End If

            If Equals(Active, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = Active
            End If

            If BranchID.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = BranchID.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            End If

            If Id.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = Id.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            End If

            If Equals(Original_AccountNo, Nothing) Then
                Throw New System.ArgumentNullException("Original_AccountNo")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = Original_AccountNo
            If Equals(Original_AccountName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = Original_AccountName
            End If

            If Equals(Original_AccountType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = Original_AccountType
            End If

            If Original_OpeningDate.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = Original_OpeningDate.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            End If

            If Original_BalanceAmount.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = Original_BalanceAmount.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            End If

            If Equals(Original_Active, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = Original_Active
            End If

            If Original_BranchID.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = Original_BranchID.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            End If

            If Original_Id.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = Original_Id.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = System.DBNull.Value
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

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Update(AccountName As String, AccountType As String, OpeningDate As System.DateTime?, BalanceAmount As Decimal?, Active As String, BranchID As Integer?, Id As Integer?, Original_AccountNo As String, Original_AccountName As String, Original_AccountType As String, Original_OpeningDate As System.DateTime?, Original_BalanceAmount As Decimal?, Original_Active As String, Original_BranchID As Integer?, Original_Id As Integer?) As Integer
            Return Me.Update(Original_AccountNo, AccountName, AccountType, OpeningDate, BalanceAmount, Active, BranchID, Id, Original_AccountNo, Original_AccountName, Original_AccountType, Original_OpeningDate, Original_BalanceAmount, Original_Active, Original_BranchID, Original_Id)
        End Function
    End Class
End Namespace
