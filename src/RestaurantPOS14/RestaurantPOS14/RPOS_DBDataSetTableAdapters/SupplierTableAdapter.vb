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

    <System.ComponentModel.DataObjectAttribute(True)>
    <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
    <System.ComponentModel.DesignerCategoryAttribute("code")>
    <System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")>
    <System.ComponentModel.ToolboxItemAttribute(True)>
    Public Class SupplierTableAdapter
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

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
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
            SyncLock RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList
                If RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList.Count = RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList.Capacity Then
                    Dim num As Integer = 0
                    Dim num2 As Integer = RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList.Count - 1
                    Dim num3 As Integer = 0
                    While True
                        Dim num4 As Integer = num3
                        Dim num5 As Integer = num2
                        If num4 > num5 Then
                            Exit While
                        End If

                        If RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList(CInt((num3))).IsAlive Then
                            If num3 <> num Then
                                RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList(num) = RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList(num3)
                            End If

                            num += 1
                        End If

                        num3 += 1
                    End While

                    Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList.RemoveRange(num, RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList.Count - num)
                    RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList.Capacity = RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList.Count
                End If

                Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCList.Add(New System.WeakReference(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(value)))
            End SyncLock
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Sub New()
            Call RestaurantPOS14.RPOS_DBDataSetTableAdapters.SupplierTableAdapter.__ENCAddToList(Me)
            Me.ClearBeforeFill = True
        End Sub

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Private Sub InitAdapter()
            Me._adapter = New System.Data.SqlClient.SqlDataAdapter()
            Dim dataTableMapping As System.Data.Common.DataTableMapping = New System.Data.Common.DataTableMapping()
            dataTableMapping.SourceTable = "Table"
            dataTableMapping.DataSetTable = "Supplier"
            dataTableMapping.ColumnMappings.Add("ID", "ID")
            dataTableMapping.ColumnMappings.Add("SupplierID", "SupplierID")
            dataTableMapping.ColumnMappings.Add("Name", "Name")
            dataTableMapping.ColumnMappings.Add("Address", "Address")
            dataTableMapping.ColumnMappings.Add("City", "City")
            dataTableMapping.ColumnMappings.Add("State", "State")
            dataTableMapping.ColumnMappings.Add("ZipCode", "ZipCode")
            dataTableMapping.ColumnMappings.Add("ContactNo", "ContactNo")
            dataTableMapping.ColumnMappings.Add("EmailID", "EmailID")
            dataTableMapping.ColumnMappings.Add("Remarks", "Remarks")
            dataTableMapping.ColumnMappings.Add("TIN", "TIN")
            dataTableMapping.ColumnMappings.Add("STNo", "STNo")
            dataTableMapping.ColumnMappings.Add("CST", "CST")
            dataTableMapping.ColumnMappings.Add("PAN", "PAN")
            dataTableMapping.ColumnMappings.Add("AccountName", "AccountName")
            dataTableMapping.ColumnMappings.Add("AccountNumber", "AccountNumber")
            dataTableMapping.ColumnMappings.Add("Bank", "Bank")
            dataTableMapping.ColumnMappings.Add("Branch", "Branch")
            dataTableMapping.ColumnMappings.Add("IFSCCode", "IFSCCode")
            dataTableMapping.ColumnMappings.Add("OpeningBalance", "OpeningBalance")
            dataTableMapping.ColumnMappings.Add("OpeningBalanceType", "OpeningBalanceType")
            Me._adapter.TableMappings.Add(dataTableMapping)
            Me._adapter.DeleteCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.DeleteCommand.Connection = Me.Connection
            Me._adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[Supplier] WHERE (([ID] = @Original_ID) AND ([SupplierID] = @Original_SupplierID) AND ((@IsNull_Name = 1 AND [Name] IS NULL) OR ([Name] = @Original_Name)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_City = 1 AND [City] IS NULL) OR ([City] = @Original_City)) AND ((@IsNull_State = 1 AND [State] IS NULL) OR ([State] = @Original_State)) AND ((@IsNull_ZipCode = 1 AND [ZipCode] IS NULL) OR ([ZipCode] = @Original_ZipCode)) AND ((@IsNull_ContactNo = 1 AND [ContactNo] IS NULL) OR ([ContactNo] = @Original_ContactNo)) AND ((@IsNull_EmailID = 1 AND [EmailID] IS NULL) OR ([EmailID] = @Original_EmailID)) AND ((@IsNull_TIN = 1 AND [TIN] IS NULL) OR ([TIN] = @Original_TIN)) AND ((@IsNull_STNo = 1 AND [STNo] IS NULL) OR ([STNo] = @Original_STNo)) AND ((@IsNull_CST = 1 AND [CST] IS NULL) OR ([CST] = @Original_CST)) AND ((@IsNull_PAN = 1 AND [PAN] IS NULL) OR ([PAN] = @Original_PAN)) AND ((@IsNull_AccountName = 1 AND [AccountName] IS NULL) OR ([AccountName] = @Original_AccountName)) AND ((@IsNull_AccountNumber = 1 AND [AccountNumber] IS NULL) OR ([AccountNumber] = @Original_AccountNumber)) AND ((@IsNull_Bank = 1 AND [Bank] IS NULL) OR ([Bank] = @Original_Bank)) AND ((@IsNull_Branch = 1 AND [Branch] IS NULL) OR ([Branch] = @Original_Branch)) AND ((@IsNull_IFSCCode = 1 AND [IFSCCode] IS NULL) OR ([IFSCCode] = @Original_IFSCCode)) AND ((@IsNull_OpeningBalance = 1 AND [OpeningBalance] IS NULL) OR ([OpeningBalance] = @Original_OpeningBalance)) AND ((@IsNull_OpeningBalanceType = 1 AND [OpeningBalanceType] IS NULL) OR ([OpeningBalanceType] = @Original_OpeningBalanceType)))"
            Me._adapter.DeleteCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "SupplierID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_City", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_State", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "State", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_State", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "State", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ZipCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ZipCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ZipCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ZipCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ContactNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_EmailID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmailID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TIN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TIN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TIN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TIN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_STNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "STNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_STNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "STNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CST", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PAN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PAN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PAN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PAN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_AccountName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_AccountNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNumber", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountNumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNumber", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Bank", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Bank", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Bank", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Bank", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Branch", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Branch", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Branch", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Branch", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_IFSCCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "IFSCCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IFSCCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IFSCCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningBalance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalance", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningBalance", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OpeningBalance", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningBalanceType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.DeleteCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningBalanceType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.InsertCommand.Connection = Me.Connection
            Me._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Supplier] ([ID], [SupplierID], [Name], [Address], [City], [State], [ZipCode], [ContactNo], [EmailID], [Remarks], [TIN], [STNo], [CST], [PAN], [AccountName], [AccountNumber], [Bank], [Branch], [IFSCCode], [OpeningBalance], [OpeningBalanceType]) VALUES (@ID, @SupplierID, @Name, @Address, @City, @State, @ZipCode, @ContactNo, @EmailID, @Remarks, @TIN, @STNo, @CST, @PAN, @AccountName, @AccountNumber, @Bank, @Branch, @IFSCCode, @OpeningBalance, @OpeningBalanceType);" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT ID, SupplierID, Name, Address, City, State, ZipCode, ContactNo, EmailID, Remarks, TIN, STNo, CST, PAN, AccountName, AccountNumber, Bank, Branch, IFSCCode, OpeningBalance, OpeningBalanceType FROM Supplier WHERE (ID = @ID)"
            Me._adapter.InsertCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "SupplierID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@State", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "State", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ZipCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ZipCode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmailID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remarks", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Remarks", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TIN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TIN", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@STNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "STNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CST", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CST", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PAN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PAN", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountNumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNumber", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Bank", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Bank", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Branch", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Branch", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IFSCCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IFSCCode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningBalance", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OpeningBalance", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.InsertCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningBalanceType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand = New System.Data.SqlClient.SqlCommand()
            Me._adapter.UpdateCommand.Connection = Me.Connection
            Me._adapter.UpdateCommand.CommandText = "UPDATE [dbo].[Supplier] SET [ID] = @ID, [SupplierID] = @SupplierID, [Name] = @Name, [Address] = @Address, [City] = @City, [State] = @State, [ZipCode] = @ZipCode, [ContactNo] = @ContactNo, [EmailID] = @EmailID, [Remarks] = @Remarks, [TIN] = @TIN, [STNo] = @STNo, [CST] = @CST, [PAN] = @PAN, [AccountName] = @AccountName, [AccountNumber] = @AccountNumber, [Bank] = @Bank, [Branch] = @Branch, [IFSCCode] = @IFSCCode, [OpeningBalance] = @OpeningBalance, [OpeningBalanceType] = @OpeningBalanceType WHERE (([ID] = @Original_ID) AND ([SupplierID] = @Original_SupplierID) AND ((@IsNull_Name = 1 AND [Name] IS NULL) OR ([Name] = @Original_Name)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_City = 1 AND [City] IS NULL) OR ([City] = @Original_City)) AND ((@IsNull_State = 1 AND [State] IS NULL) OR ([State] = @Original_State)) AND ((@IsNull_ZipCode = 1 AND [ZipCode] IS NULL) OR ([ZipCode] = @Original_ZipCode)) AND ((@IsNull_ContactNo = 1 AND [ContactNo] IS NULL) OR ([ContactNo] = @Original_ContactNo)) AND ((@IsNull_EmailID = 1 AND [EmailID] IS NULL) OR ([EmailID] = @Original_EmailID)) AND ((@IsNull_TIN = 1 AND [TIN] IS NULL) OR ([TIN] = @Original_TIN)) AND ((@IsNull_STNo = 1 AND [STNo] IS NULL) OR ([STNo] = @Original_STNo)) AND ((@IsNull_CST = 1 AND [CST] IS NULL) OR ([CST] = @Original_CST)) AND ((@IsNull_PAN = 1 AND [PAN] IS NULL) OR ([PAN] = @Original_PAN)) AND ((@IsNull_AccountName = 1 AND [AccountName] IS NULL) OR ([AccountName] = @Original_AccountName)) AND ((@IsNull_AccountNumber = 1 AND [AccountNumber] IS NULL) OR ([AccountNumber] = @Original_AccountNumber)) AND ((@IsNull_Bank = 1 AND [Bank] IS NULL) OR ([Bank] = @Original_Bank)) AND ((@IsNull_Branch = 1 AND [Branch] IS NULL) OR ([Branch] = @Original_Branch)) AND ((@IsNull_IFSCCode = 1 AND [IFSCCode] IS NULL) OR ([IFSCCode] = @Original_IFSCCode)) AND ((@IsNull_OpeningBalance = 1 AND [OpeningBalance] IS NULL) OR ([OpeningBalance] = @Original_OpeningBalance)) AND ((@IsNull_OpeningBalanceType = 1 AND [OpeningBalanceType] IS NULL) OR ([OpeningBalanceType] = @Original_OpeningBalanceType)));" & Global.Microsoft.VisualBasic.Constants.vbCrLf & "SELECT ID, SupplierID, Name, Address, City, State, ZipCode, ContactNo, EmailID, Remarks, TIN, STNo, CST, PAN, AccountName, AccountNumber, Bank, Branch, IFSCCode, OpeningBalance, OpeningBalanceType FROM Supplier WHERE (ID = @ID)"
            Me._adapter.UpdateCommand.CommandType = System.Data.CommandType.Text
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "SupplierID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@State", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "State", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ZipCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ZipCode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@EmailID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remarks", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Remarks", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TIN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TIN", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@STNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "STNo", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CST", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CST", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PAN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PAN", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AccountNumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNumber", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Bank", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Bank", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Branch", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Branch", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IFSCCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IFSCCode", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningBalance", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OpeningBalance", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OpeningBalanceType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Current, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "SupplierID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Name", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Address", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Address", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_City", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "City", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_State", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "State", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_State", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "State", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ZipCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ZipCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ZipCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ZipCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_ContactNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "ContactNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_EmailID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_EmailID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "EmailID", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_TIN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "TIN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TIN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "TIN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_STNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "STNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_STNo", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "STNo", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_CST", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "CST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CST", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "CST", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_PAN", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "PAN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PAN", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "PAN", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_AccountName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountName", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_AccountNumber", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNumber", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AccountNumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "AccountNumber", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Bank", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Bank", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Bank", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Bank", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_Branch", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "Branch", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Branch", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "Branch", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_IFSCCode", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "IFSCCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IFSCCode", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "IFSCCode", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningBalance", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalance", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningBalance", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, 18, 2, "OpeningBalance", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IsNull_OpeningBalanceType", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=True, Nothing, "", "", ""))
            Me._adapter.UpdateCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OpeningBalanceType", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, 0, 0, "OpeningBalanceType", System.Data.DataRowVersion.Original, sourceColumnNullMapping:=False, Nothing, "", "", ""))
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
            Me._commandCollection(CInt((0))).CommandText = "SELECT ID, SupplierID, Name, Address, City, State, ZipCode, ContactNo, EmailID, Remarks, TIN, STNo, CST, PAN, AccountName, AccountNumber, Bank, Branch, IFSCCode, OpeningBalance, OpeningBalanceType FROM dbo.Supplier"
            Me._commandCollection(CInt((0))).CommandType = System.Data.CommandType.Text
        End Sub

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Fill(dataTable As RestaurantPOS14.RPOS_DBDataSet.SupplierDataTable) As Integer
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            If Me.ClearBeforeFill Then
                dataTable.Clear()
            End If

            Return Me.Adapter.Fill(dataTable)
        End Function

        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.[Select], True)>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function GetData() As RestaurantPOS14.RPOS_DBDataSet.SupplierDataTable
            Me.Adapter.SelectCommand = Me.CommandCollection(0)
            Dim supplierDataTable As RestaurantPOS14.RPOS_DBDataSet.SupplierDataTable = New RestaurantPOS14.RPOS_DBDataSet.SupplierDataTable()
            Me.Adapter.Fill(supplierDataTable)
            Return supplierDataTable
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        Public Overridable Function Update(dataTable As RestaurantPOS14.RPOS_DBDataSet.SupplierDataTable) As Integer
            Return Me.Adapter.Update(dataTable)
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(dataSet As RestaurantPOS14.RPOS_DBDataSet) As Integer
            Return Me.Adapter.Update(dataSet, "Supplier")
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
        Public Overridable Function Delete(Original_ID As Integer, Original_SupplierID As String, Original_Name As String, Original_Address As String, Original_City As String, Original_State As String, Original_ZipCode As String, Original_ContactNo As String, Original_EmailID As String, Original_TIN As String, Original_STNo As String, Original_CST As String, Original_PAN As String, Original_AccountName As String, Original_AccountNumber As String, Original_Bank As String, Original_Branch As String, Original_IFSCCode As String, Original_OpeningBalance As Decimal?, Original_OpeningBalanceType As String) As Integer
            Me.Adapter.DeleteCommand.Parameters(CInt((0))).Value = Original_ID
            If Equals(Original_SupplierID, Nothing) Then
                Throw New System.ArgumentNullException("Original_SupplierID")
            End If

            Me.Adapter.DeleteCommand.Parameters(CInt((1))).Value = Original_SupplierID
            If Equals(Original_Name, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((2))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((3))).Value = Original_Name
            End If

            If Equals(Original_Address, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((4))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((5))).Value = Original_Address
            End If

            If Equals(Original_City, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((6))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((7))).Value = Original_City
            End If

            If Equals(Original_State, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((8))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((9))).Value = Original_State
            End If

            If Equals(Original_ZipCode, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((10))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((11))).Value = Original_ZipCode
            End If

            If Equals(Original_ContactNo, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((12))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((13))).Value = Original_ContactNo
            End If

            If Equals(Original_EmailID, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((14))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((15))).Value = Original_EmailID
            End If

            If Equals(Original_TIN, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((16))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((17))).Value = Original_TIN
            End If

            If Equals(Original_STNo, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((18))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((19))).Value = Original_STNo
            End If

            If Equals(Original_CST, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((20))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((21))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((20))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((21))).Value = Original_CST
            End If

            If Equals(Original_PAN, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((22))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((23))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((22))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((23))).Value = Original_PAN
            End If

            If Equals(Original_AccountName, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((24))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((25))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((24))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((25))).Value = Original_AccountName
            End If

            If Equals(Original_AccountNumber, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((26))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((27))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((26))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((27))).Value = Original_AccountNumber
            End If

            If Equals(Original_Bank, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((28))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((29))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((28))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((29))).Value = Original_Bank
            End If

            If Equals(Original_Branch, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((30))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((31))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((30))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((31))).Value = Original_Branch
            End If

            If Equals(Original_IFSCCode, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((32))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((33))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((32))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((33))).Value = Original_IFSCCode
            End If

            If Original_OpeningBalance.HasValue Then
                Me.Adapter.DeleteCommand.Parameters(CInt((34))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((35))).Value = Original_OpeningBalance.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((34))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((35))).Value = System.DBNull.Value
            End If

            If Equals(Original_OpeningBalanceType, Nothing) Then
                Me.Adapter.DeleteCommand.Parameters(CInt((36))).Value = 1
                Me.Adapter.DeleteCommand.Parameters(CInt((37))).Value = System.DBNull.Value
            Else
                Me.Adapter.DeleteCommand.Parameters(CInt((36))).Value = 0
                Me.Adapter.DeleteCommand.Parameters(CInt((37))).Value = Original_OpeningBalanceType
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
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        Public Overridable Function Insert(ID As Integer, SupplierID As String, Name As String, Address As String, City As String, State As String, ZipCode As String, ContactNo As String, EmailID As String, Remarks As String, TIN As String, STNo As String, CST As String, PAN As String, AccountName As String, AccountNumber As String, Bank As String, Branch As String, IFSCCode As String, OpeningBalance As Decimal?, OpeningBalanceType As String) As Integer
            Me.Adapter.InsertCommand.Parameters(CInt((0))).Value = ID
            If Equals(SupplierID, Nothing) Then
                Throw New System.ArgumentNullException("SupplierID")
            End If

            Me.Adapter.InsertCommand.Parameters(CInt((1))).Value = SupplierID
            If Equals(Name, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((2))).Value = Name
            End If

            If Equals(Address, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((3))).Value = Address
            End If

            If Equals(City, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((4))).Value = City
            End If

            If Equals(State, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((5))).Value = State
            End If

            If Equals(ZipCode, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((6))).Value = ZipCode
            End If

            If Equals(ContactNo, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((7))).Value = ContactNo
            End If

            If Equals(EmailID, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((8))).Value = EmailID
            End If

            If Equals(Remarks, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((9))).Value = Remarks
            End If

            If Equals(TIN, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((10))).Value = TIN
            End If

            If Equals(STNo, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((11))).Value = STNo
            End If

            If Equals(CST, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((12))).Value = CST
            End If

            If Equals(PAN, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((13))).Value = PAN
            End If

            If Equals(AccountName, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((14))).Value = AccountName
            End If

            If Equals(AccountNumber, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((15))).Value = AccountNumber
            End If

            If Equals(Bank, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((16))).Value = Bank
            End If

            If Equals(Branch, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((17))).Value = Branch
            End If

            If Equals(IFSCCode, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((18))).Value = IFSCCode
            End If

            If OpeningBalance.HasValue Then
                Me.Adapter.InsertCommand.Parameters(CInt((19))).Value = OpeningBalance.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            End If

            If Equals(OpeningBalanceType, Nothing) Then
                Me.Adapter.InsertCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            Else
                Me.Adapter.InsertCommand.Parameters(CInt((20))).Value = OpeningBalanceType
            End If

            Dim lState As System.Data.ConnectionState = Me.Adapter.InsertCommand.Connection.State
            If(Me.Adapter.InsertCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open Then
                Me.Adapter.InsertCommand.Connection.Open()
            End If

            Try
                Return Me.Adapter.InsertCommand.ExecuteNonQuery()
            Finally
                If lState = System.Data.ConnectionState.Closed Then
                    Me.Adapter.InsertCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        Public Overridable Function Update(ID As Integer, SupplierID As String, Name As String, Address As String, City As String, State As String, ZipCode As String, ContactNo As String, EmailID As String, Remarks As String, TIN As String, STNo As String, CST As String, PAN As String, AccountName As String, AccountNumber As String, Bank As String, Branch As String, IFSCCode As String, OpeningBalance As Decimal?, OpeningBalanceType As String, Original_ID As Integer, Original_SupplierID As String, Original_Name As String, Original_Address As String, Original_City As String, Original_State As String, Original_ZipCode As String, Original_ContactNo As String, Original_EmailID As String, Original_TIN As String, Original_STNo As String, Original_CST As String, Original_PAN As String, Original_AccountName As String, Original_AccountNumber As String, Original_Bank As String, Original_Branch As String, Original_IFSCCode As String, Original_OpeningBalance As Decimal?, Original_OpeningBalanceType As String) As Integer
            Me.Adapter.UpdateCommand.Parameters(CInt((0))).Value = ID
            If Equals(SupplierID, Nothing) Then
                Throw New System.ArgumentNullException("SupplierID")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((1))).Value = SupplierID
            If Equals(Name, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((2))).Value = Name
            End If

            If Equals(Address, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((3))).Value = Address
            End If

            If Equals(City, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((4))).Value = City
            End If

            If Equals(State, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((5))).Value = State
            End If

            If Equals(ZipCode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((6))).Value = ZipCode
            End If

            If Equals(ContactNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((7))).Value = ContactNo
            End If

            If Equals(EmailID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((8))).Value = EmailID
            End If

            If Equals(Remarks, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((9))).Value = Remarks
            End If

            If Equals(TIN, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((10))).Value = TIN
            End If

            If Equals(STNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((11))).Value = STNo
            End If

            If Equals(CST, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((12))).Value = CST
            End If

            If Equals(PAN, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((13))).Value = PAN
            End If

            If Equals(AccountName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((14))).Value = AccountName
            End If

            If Equals(AccountNumber, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((15))).Value = AccountNumber
            End If

            If Equals(Bank, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((16))).Value = Bank
            End If

            If Equals(Branch, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((17))).Value = Branch
            End If

            If Equals(IFSCCode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((18))).Value = IFSCCode
            End If

            If OpeningBalance.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = OpeningBalance.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((19))).Value = System.DBNull.Value
            End If

            If Equals(OpeningBalanceType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((20))).Value = OpeningBalanceType
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((21))).Value = Original_ID
            If Equals(Original_SupplierID, Nothing) Then
                Throw New System.ArgumentNullException("Original_SupplierID")
            End If

            Me.Adapter.UpdateCommand.Parameters(CInt((22))).Value = Original_SupplierID
            If Equals(Original_Name, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((23))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((24))).Value = Original_Name
            End If

            If Equals(Original_Address, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((25))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((26))).Value = Original_Address
            End If

            If Equals(Original_City, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((27))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((28))).Value = Original_City
            End If

            If Equals(Original_State, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((29))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((30))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((29))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((30))).Value = Original_State
            End If

            If Equals(Original_ZipCode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((31))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((32))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((31))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((32))).Value = Original_ZipCode
            End If

            If Equals(Original_ContactNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((33))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((34))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((33))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((34))).Value = Original_ContactNo
            End If

            If Equals(Original_EmailID, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((35))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((36))).Value = Original_EmailID
            End If

            If Equals(Original_TIN, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((37))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((38))).Value = Original_TIN
            End If

            If Equals(Original_STNo, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((39))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((40))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((39))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((40))).Value = Original_STNo
            End If

            If Equals(Original_CST, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((41))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((42))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((41))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((42))).Value = Original_CST
            End If

            If Equals(Original_PAN, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((43))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((44))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((43))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((44))).Value = Original_PAN
            End If

            If Equals(Original_AccountName, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((45))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((46))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((45))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((46))).Value = Original_AccountName
            End If

            If Equals(Original_AccountNumber, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((47))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((48))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((47))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((48))).Value = Original_AccountNumber
            End If

            If Equals(Original_Bank, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((49))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((50))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((49))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((50))).Value = Original_Bank
            End If

            If Equals(Original_Branch, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((51))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((52))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((51))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((52))).Value = Original_Branch
            End If

            If Equals(Original_IFSCCode, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((53))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((54))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((53))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((54))).Value = Original_IFSCCode
            End If

            If Original_OpeningBalance.HasValue Then
                Me.Adapter.UpdateCommand.Parameters(CInt((55))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((56))).Value = Original_OpeningBalance.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((55))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((56))).Value = System.DBNull.Value
            End If

            If Equals(Original_OpeningBalanceType, Nothing) Then
                Me.Adapter.UpdateCommand.Parameters(CInt((57))).Value = 1
                Me.Adapter.UpdateCommand.Parameters(CInt((58))).Value = System.DBNull.Value
            Else
                Me.Adapter.UpdateCommand.Parameters(CInt((57))).Value = 0
                Me.Adapter.UpdateCommand.Parameters(CInt((58))).Value = Original_OpeningBalanceType
            End If

            Dim lState As System.Data.ConnectionState = Me.Adapter.UpdateCommand.Connection.State
            If(Me.Adapter.UpdateCommand.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open Then
                Me.Adapter.UpdateCommand.Connection.Open()
            End If

            Try
                Return Me.Adapter.UpdateCommand.ExecuteNonQuery()
            Finally
                If lState = System.Data.ConnectionState.Closed Then
                    Me.Adapter.UpdateCommand.Connection.Close()
                End If
            End Try
        End Function

        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")>
        <System.ComponentModel.Design.HelpKeywordAttribute("vs.data.TableAdapter")>
        <System.Diagnostics.DebuggerNonUserCodeAttribute>
        <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)>
        Public Overridable Function Update(SupplierID As String, Name As String, Address As String, City As String, State As String, ZipCode As String, ContactNo As String, EmailID As String, Remarks As String, TIN As String, STNo As String, CST As String, PAN As String, AccountName As String, AccountNumber As String, Bank As String, Branch As String, IFSCCode As String, OpeningBalance As Decimal?, OpeningBalanceType As String, Original_ID As Integer, Original_SupplierID As String, Original_Name As String, Original_Address As String, Original_City As String, Original_State As String, Original_ZipCode As String, Original_ContactNo As String, Original_EmailID As String, Original_TIN As String, Original_STNo As String, Original_CST As String, Original_PAN As String, Original_AccountName As String, Original_AccountNumber As String, Original_Bank As String, Original_Branch As String, Original_IFSCCode As String, Original_OpeningBalance As Decimal?, Original_OpeningBalanceType As String) As Integer
            Return Me.Update(Original_ID, SupplierID, Name, Address, City, State, ZipCode, ContactNo, EmailID, Remarks, TIN, STNo, CST, PAN, AccountName, AccountNumber, Bank, Branch, IFSCCode, OpeningBalance, OpeningBalanceType, Original_ID, Original_SupplierID, Original_Name, Original_Address, Original_City, Original_State, Original_ZipCode, Original_ContactNo, Original_EmailID, Original_TIN, Original_STNo, Original_CST, Original_PAN, Original_AccountName, Original_AccountNumber, Original_Bank, Original_Branch, Original_IFSCCode, Original_OpeningBalance, Original_OpeningBalanceType)
        End Function
    End Class
End Namespace
