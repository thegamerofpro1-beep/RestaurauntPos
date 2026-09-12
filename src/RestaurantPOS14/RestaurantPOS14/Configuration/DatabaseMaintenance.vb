Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class DatabaseMaintenance
        Private Const MigrationCommandTimeoutSeconds As Integer = 120
        Private Const CurrentDatabaseSchemaVersion As Integer = 6
        Private Const LegacySchemaPredicate As String =
            "OBJECT_ID(N'dbo.Registration', N'U') IS NOT NULL AND " &
            "OBJECT_ID(N'dbo.OtherSetting', N'U') IS NOT NULL AND " &
            "OBJECT_ID(N'dbo.Kitchen', N'U') IS NOT NULL AND " &
            "OBJECT_ID(N'dbo.PosPrinterSetting', N'U') IS NOT NULL AND " &
            "OBJECT_ID(N'dbo.RestaurantPOS_BillingInfoKOT', N'U') IS NOT NULL AND " &
            "OBJECT_ID(N'dbo.RestaurantPOS_BillingInfoEB', N'U') IS NOT NULL AND " &
            "OBJECT_ID(N'dbo.RestaurantPOS_BillingInfoHD', N'U') IS NOT NULL AND " &
            "OBJECT_ID(N'dbo.RestaurantPOS_BillingInfoTA', N'U') IS NOT NULL"
        Private Const CurrentSchemaObjectPredicate As String =
            LegacySchemaPredicate & " AND " &
            "OBJECT_ID(N'dbo.POSSchemaMigrations', N'U') IS NOT NULL AND " &
            "OBJECT_ID(N'dbo.ApplicationSettings', N'U') IS NOT NULL AND " &
            "OBJECT_ID(N'dbo.EInvoiceQueue', N'U') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.DineInBillCancellations', N'SnapshotXml') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.DineInBillCancellations', N'BillId') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.DineInBillCancellations', N'BillNo') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.DineInBillCancellations', N'CancelledBy') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.DineInBillCancellations', N'Reason') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.DineInBillCancellations', N'CancelledAtUtc') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.DineInBillCancellations', N'GrandTotal') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.POSSchemaMigrations', N'MigrationId') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.ApplicationSettings', N'SettingPath') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.ApplicationSettings', N'JsonValue') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.ApplicationSettings', N'IsEnabled') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.OtherSetting', N'EnableChecklist') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.OtherSetting', N'EnableMyInvois') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.OtherSetting', N'MyInvoisBaseUrl') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.OtherSetting', N'MyInvoisClientId') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.OtherSetting', N'MyInvoisClientSecret') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.OtherSetting', N'MyInvoisEnvironment') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.OtherSetting', N'ShowSSTOnSecondaryDisplay') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.Kitchen', N'Printer2') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.Kitchen', N'Printer3') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.PosPrinterSetting', N'DisableColoredDisplaySingleScreen') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'QueueId') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'BillId') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'BillType') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'Payload') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'Status') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'AttemptCount') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'NextAttemptAt') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'LastError') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'SubmissionId') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'UIN') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.EInvoiceQueue', N'QRUrl') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoEB', N'UIN') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoEB', N'EInvoiceStatus') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoEB', N'QRUrl') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoEB', N'LastSyncedAt') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoEB', N'ApiSubmissionId') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoEB', N'ErrorCode') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoEB', N'ErrorMessage') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoHD', N'UIN') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoHD', N'EInvoiceStatus') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoHD', N'QRUrl') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoHD', N'LastSyncedAt') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoHD', N'ApiSubmissionId') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoHD', N'ErrorCode') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoHD', N'ErrorMessage') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoTA', N'UIN') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoTA', N'EInvoiceStatus') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoTA', N'QRUrl') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoTA', N'LastSyncedAt') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoTA', N'ApiSubmissionId') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoTA', N'ErrorCode') IS NOT NULL AND " &
            "COL_LENGTH(N'dbo.RestaurantPOS_BillingInfoTA', N'ErrorMessage') IS NOT NULL"
        Private Const CurrentSchemaPredicate As String =
            CurrentSchemaObjectPredicate & " AND " &
            "EXISTS (SELECT 1 FROM dbo.POSSchemaMigrations WHERE MigrationId=6)"

        Private Sub New()
        End Sub

        Public Shared ReadOnly Property CurrentSchemaVersion As Integer
            Get
                Return CurrentDatabaseSchemaVersion
            End Get
        End Property

        Public Shared Function BuildBackupFileName() As String
            Return GetCatalogFileStem() & " " & DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") & ".bak"
        End Function

        Public Shared Function CreateBackupCommand(connection As SqlConnection, filePath As String) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            If String.IsNullOrWhiteSpace(filePath) Then Throw New ArgumentException("A backup file path is required.", NameOf(filePath))
            Dim command As New SqlCommand("BACKUP DATABASE " & QuoteCatalogName() & " TO DISK=@path WITH INIT, STATS=10", connection)
            command.Parameters.Add("@path", SqlDbType.NVarChar, 4000).Value = filePath
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function CreateRestoreCommand(connection As SqlConnection, filePath As String) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            If String.IsNullOrWhiteSpace(filePath) Then Throw New ArgumentException("A restore file path is required.", NameOf(filePath))
            Dim catalog = QuoteCatalogName()
            Dim commandText = "USE [master]; ALTER DATABASE " & catalog & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " &
                              "RESTORE DATABASE " & catalog & " FROM DISK=@path WITH REPLACE; " &
                              "ALTER DATABASE " & catalog & " SET MULTI_USER;"
            Dim command As New SqlCommand(commandText, connection)
            command.Parameters.Add("@path", SqlDbType.NVarChar, 4000).Value = filePath
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function CreateDatabaseExistsCommand(connection As SqlConnection) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            Dim command As New SqlCommand("SELECT 1 FROM sys.databases WHERE name=@catalog", connection)
            command.Parameters.Add("@catalog", SqlDbType.NVarChar, 128).Value = GetCatalogName()
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function CreateDatabasePermissionCommand(connection As SqlConnection) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            Dim command As New SqlCommand("SELECT ISNULL(HAS_PERMS_BY_NAME(NULL, NULL, 'CREATE ANY DATABASE'), 0)", connection)
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function CreateDatabaseProvisionedCommand(connection As SqlConnection) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            Dim commandText = "SELECT CASE WHEN " & CurrentSchemaPredicate & " THEN 1 ELSE 0 END"
            Dim command As New SqlCommand(commandText, connection)
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Sub EnsureCompatibleSchema(connection As SqlConnection)
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            If connection.State <> ConnectionState.Open Then Throw New InvalidOperationException("The database connection must be open before running the POS database upgrade.")
            If IsCurrentSchema(connection) Then Return

            Using preflightCommand As New SqlCommand("SELECT CASE WHEN " & LegacySchemaPredicate & " THEN 1 ELSE 0 END", connection)
                preflightCommand.CommandTimeout = MigrationCommandTimeoutSeconds
                If Convert.ToInt32(preflightCommand.ExecuteScalar()) <> 1 Then
                    Throw New InvalidOperationException("This database does not contain the complete original Restaurant POS schema. Select a database created by the original application or create a new POS database.")
                End If
            End Using

            Using transaction As SqlTransaction = connection.BeginTransaction()
                Try
                    Using lockCommand As New SqlCommand("DECLARE @result int; EXEC @result=sys.sp_getapplock @Resource=N'RestaurantPOS14.SchemaUpgrade', @LockMode=N'Exclusive', @LockOwner=N'Transaction', @LockTimeout=15000; IF @result < 0 RAISERROR('Another POS terminal is upgrading this database. Try again after it finishes.', 16, 1);", connection, transaction)
                        lockCommand.CommandTimeout = MigrationCommandTimeoutSeconds
                        lockCommand.ExecuteNonQuery()
                    End Using

                    Using historyCommand As New SqlCommand("IF OBJECT_ID(N'dbo.POSSchemaMigrations', N'U') IS NULL EXEC(N'CREATE TABLE [dbo].[POSSchemaMigrations] ([MigrationId] [int] NOT NULL, [Name] [nvarchar](200) NOT NULL, [AppliedAtUtc] [datetime] NOT NULL CONSTRAINT [DF_POSSchemaMigrations_AppliedAtUtc] DEFAULT (GETUTCDATE()), [AppVersion] [nvarchar](50) NULL, CONSTRAINT [PK_POSSchemaMigrations] PRIMARY KEY CLUSTERED ([MigrationId] ASC));');", connection, transaction)
                        historyCommand.CommandTimeout = MigrationCommandTimeoutSeconds
                        historyCommand.ExecuteNonQuery()
                    End Using

                    RunMigration(connection, transaction, 1, "Advanced settings", New String() {
                        "IF COL_LENGTH(N'dbo.OtherSetting', N'EnableChecklist') IS NULL EXEC(N'ALTER TABLE [dbo].[OtherSetting] ADD [EnableChecklist] [nchar](3) NULL;');",
                        "IF COL_LENGTH(N'dbo.OtherSetting', N'EnableMyInvois') IS NULL EXEC(N'ALTER TABLE [dbo].[OtherSetting] ADD [EnableMyInvois] [nchar](3) NULL;');",
                        "IF COL_LENGTH(N'dbo.OtherSetting', N'MyInvoisBaseUrl') IS NULL EXEC(N'ALTER TABLE [dbo].[OtherSetting] ADD [MyInvoisBaseUrl] [nvarchar](512) NULL;');",
                        "IF COL_LENGTH(N'dbo.OtherSetting', N'MyInvoisClientId') IS NULL EXEC(N'ALTER TABLE [dbo].[OtherSetting] ADD [MyInvoisClientId] [nvarchar](128) NULL;');",
                        "IF COL_LENGTH(N'dbo.OtherSetting', N'MyInvoisClientSecret') IS NULL EXEC(N'ALTER TABLE [dbo].[OtherSetting] ADD [MyInvoisClientSecret] [nvarchar](256) NULL;');",
                        "IF COL_LENGTH(N'dbo.OtherSetting', N'MyInvoisEnvironment') IS NULL EXEC(N'ALTER TABLE [dbo].[OtherSetting] ADD [MyInvoisEnvironment] [nchar](20) NULL;');",
                        "IF NOT EXISTS (SELECT 1 FROM [dbo].[OtherSetting]) INSERT INTO [dbo].[OtherSetting] (ParcelCharges,HomeDeliveryCharges,VAT,ServiceTax,ServiceCharges,TA,HD,EB,KG,TaxType,PDP,TL,ECDI,ECDB,ECTA,ECHD,ECEB,A1,ANB,TLAP,EnableChecklist,EnableMyInvois,MyInvoisBaseUrl,MyInvoisClientId,MyInvoisClientSecret,MyInvoisEnvironment) VALUES (0,0,0,0,0,N'Yes',N'No',N'Yes',N'No',N'Inclusive',N'No',N'No',N'No',N'No',N'No',N'No',N'No',N'No',N'No',N'No',N'No',N'No',N'https://preprod-api.myinvois.hasil.gov.my',N'',N'',N'Sandbox');"
                    })

                    RunMigration(connection, transaction, 2, "Terminal and kitchen printers", New String() {
                        "IF COL_LENGTH(N'dbo.PosPrinterSetting', N'DisableColoredDisplaySingleScreen') IS NULL EXEC(N'ALTER TABLE [dbo].[PosPrinterSetting] ADD [DisableColoredDisplaySingleScreen] [nchar](10) NULL;');",
                        "IF COL_LENGTH(N'dbo.Kitchen', N'Printer2') IS NULL EXEC(N'ALTER TABLE [dbo].[Kitchen] ADD [Printer2] [nvarchar](250) NULL;');",
                        "IF COL_LENGTH(N'dbo.Kitchen', N'Printer3') IS NULL EXEC(N'ALTER TABLE [dbo].[Kitchen] ADD [Printer3] [nvarchar](250) NULL;');"
                    })

                    RunMigration(connection, transaction, 3, "MyInvois queue and invoice status", BuildEInvoiceMigrationCommands())

                    RunMigration(connection, transaction, 4, "Layered application settings", New String() {
                        "IF OBJECT_ID(N'dbo.ApplicationSettings', N'U') IS NULL EXEC(N'CREATE TABLE [dbo].[ApplicationSettings] ([SettingPath] [nvarchar](200) NOT NULL, [JsonValue] [nvarchar](max) NOT NULL, [IsEnabled] [bit] NOT NULL CONSTRAINT [DF_ApplicationSettings_IsEnabled] DEFAULT ((1)), CONSTRAINT [PK_ApplicationSettings] PRIMARY KEY CLUSTERED ([SettingPath] ASC));');"
                    })

                    RunMigration(connection, transaction, 5, "Secondary display SST column option", New String() {
                        "IF COL_LENGTH(N'dbo.OtherSetting', N'ShowSSTOnSecondaryDisplay') IS NULL EXEC(N'ALTER TABLE [dbo].[OtherSetting] ADD [ShowSSTOnSecondaryDisplay] [nchar](3) NULL;');",
                        "UPDATE [dbo].[OtherSetting] SET [ShowSSTOnSecondaryDisplay]=N'Yes' WHERE [ShowSSTOnSecondaryDisplay] IS NULL OR LTRIM(RTRIM([ShowSSTOnSecondaryDisplay]))=N'';"
                    })

                    RunMigration(connection, transaction, 6, "Unpaid dine-in bill cancellation audit", New String() {
                        RestaurantPOS14.Billing.UnpaidBillCancellation.SchemaSql
                    })

                    Using verificationCommand As New SqlCommand("SELECT CASE WHEN " & CurrentSchemaPredicate & " THEN 1 ELSE 0 END", connection, transaction)
                        verificationCommand.CommandTimeout = MigrationCommandTimeoutSeconds
                        If Convert.ToInt32(verificationCommand.ExecuteScalar()) <> 1 Then
                            Throw New InvalidOperationException("The POS database upgrade finished without producing the complete current schema.")
                        End If
                    End Using

                    transaction.Commit()
                Catch ex As Exception
                    Try
                        transaction.Rollback()
                    Catch suppressedException As System.Exception
                        RestaurantPOS14.Diagnostics.ApplicationDiagnostics.ReportNonFatal("Suppressed exception in DatabaseMaintenance", suppressedException)
                    End Try
                    Throw New InvalidOperationException("The automatic POS database upgrade failed. Existing sales data was not removed. Ensure this SQL login can alter the database, then restart the application.", ex)
                End Try
            End Using
        End Sub

        Public Shared Sub EnsureAdvancedSettingsSchema(connection As SqlConnection)
            EnsureCompatibleSchema(connection)
        End Sub

        Private Shared Sub RunMigration(connection As SqlConnection, transaction As SqlTransaction, migrationId As Integer, migrationName As String, commandTexts As String())
            For Each commandText As String In commandTexts
                Using command As New SqlCommand(commandText, connection, transaction)
                    command.CommandTimeout = MigrationCommandTimeoutSeconds
                    command.ExecuteNonQuery()
                End Using
            Next

            Const recordSql As String = "IF EXISTS (SELECT 1 FROM dbo.POSSchemaMigrations WHERE MigrationId=@id) UPDATE dbo.POSSchemaMigrations SET Name=@name, AppVersion=@version WHERE MigrationId=@id ELSE INSERT INTO dbo.POSSchemaMigrations(MigrationId,Name,AppVersion) VALUES (@id,@name,@version);"
            Using recordCommand As New SqlCommand(recordSql, connection, transaction)
                recordCommand.CommandTimeout = MigrationCommandTimeoutSeconds
                recordCommand.Parameters.Add("@id", SqlDbType.Int).Value = migrationId
                recordCommand.Parameters.Add("@name", SqlDbType.NVarChar, 200).Value = migrationName
                recordCommand.Parameters.Add("@version", SqlDbType.NVarChar, 50).Value = GetType(DatabaseMaintenance).Assembly.GetName().Version.ToString()
                recordCommand.ExecuteNonQuery()
            End Using
        End Sub

        Private Shared Function IsCurrentSchema(connection As SqlConnection) As Boolean
            Using schemaCommand As New SqlCommand("SELECT CASE WHEN " & CurrentSchemaObjectPredicate & " THEN 1 ELSE 0 END", connection)
                schemaCommand.CommandTimeout = MigrationCommandTimeoutSeconds
                If Convert.ToInt32(schemaCommand.ExecuteScalar()) <> 1 Then Return False
            End Using

            Using versionCommand As New SqlCommand("SELECT CASE WHEN EXISTS (SELECT 1 FROM dbo.POSSchemaMigrations WHERE MigrationId=@version) THEN 1 ELSE 0 END", connection)
                versionCommand.CommandTimeout = MigrationCommandTimeoutSeconds
                versionCommand.Parameters.Add("@version", SqlDbType.Int).Value = CurrentDatabaseSchemaVersion
                Return Convert.ToInt32(versionCommand.ExecuteScalar()) = 1
            End Using
        End Function

        Private Shared Function BuildEInvoiceMigrationCommands() As String()
            Dim commands As New System.Collections.Generic.List(Of String) From {
                "IF OBJECT_ID(N'dbo.EInvoiceQueue', N'U') IS NULL EXEC(N'CREATE TABLE [dbo].[EInvoiceQueue] ([QueueId] [int] IDENTITY(1,1) NOT NULL, [BillId] [int] NOT NULL, [BillType] [nchar](10) NOT NULL, [Payload] [nvarchar](max) NULL, [Status] [nchar](20) NOT NULL, [AttemptCount] [int] NOT NULL CONSTRAINT [DF_EInvoiceQueue_AttemptCount] DEFAULT ((0)), [NextAttemptAt] [datetime] NULL, [LastError] [nvarchar](max) NULL, [SubmissionId] [nchar](128) NULL, [UIN] [nchar](64) NULL, [QRUrl] [nvarchar](512) NULL, CONSTRAINT [PK_EInvoiceQueue] PRIMARY KEY CLUSTERED ([QueueId] ASC));');",
                "IF COL_LENGTH(N'dbo.EInvoiceQueue', N'UIN') IS NULL EXEC(N'ALTER TABLE [dbo].[EInvoiceQueue] ADD [UIN] [nchar](64) NULL;');",
                "IF COL_LENGTH(N'dbo.EInvoiceQueue', N'QRUrl') IS NULL EXEC(N'ALTER TABLE [dbo].[EInvoiceQueue] ADD [QRUrl] [nvarchar](512) NULL;');"
            }

            Dim billTables As String() = {"RestaurantPOS_BillingInfoEB", "RestaurantPOS_BillingInfoHD", "RestaurantPOS_BillingInfoTA"}
            Dim columnDefinitions As String() = {
                "UIN|[nchar](64) NULL",
                "EInvoiceStatus|[nchar](20) NULL",
                "QRUrl|[nvarchar](512) NULL",
                "LastSyncedAt|[datetime] NULL",
                "ApiSubmissionId|[nchar](128) NULL",
                "ErrorCode|[nchar](64) NULL",
                "ErrorMessage|[nvarchar](max) NULL"
            }
            For Each tableName As String In billTables
                For Each definition As String In columnDefinitions
                    Dim parts As String() = definition.Split("|"c)
                    commands.Add("IF COL_LENGTH(N'dbo." & tableName & "', N'" & parts(0) & "') IS NULL EXEC(N'ALTER TABLE [dbo].[" & tableName & "] ADD [" & parts(0) & "] " & parts(1) & ";');")
                Next
            Next
            Return commands.ToArray()
        End Function

        Public Shared Function CreateDropDatabaseCommand(connection As SqlConnection) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            Dim catalog = QuoteCatalogName()
            Dim command As New SqlCommand("USE [master]; ALTER DATABASE " & catalog & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE " & catalog & ";", connection)
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function CreateDatabaseCommand(connection As SqlConnection) As SqlCommand
            If connection Is Nothing Then Throw New ArgumentNullException(NameOf(connection))
            Dim command As New SqlCommand("CREATE DATABASE " & QuoteCatalogName() & ";", connection)
            command.CommandTimeout = SettingsHost.Current.Database.CommandTimeoutSeconds
            Return command
        End Function

        Public Shared Function PrepareDatabaseScript(script As String) As String
            If script Is Nothing Then Throw New ArgumentNullException(NameOf(script))
            Return script.Replace("[RPOS_DB]", QuoteCatalogName())
        End Function

        Public Shared Function GetCatalogName() As String
            Dim value = SettingsHost.Current.Database.DefaultCatalog
            If String.IsNullOrWhiteSpace(value) Then value = "RPOS_DB"
            Return value.Trim()
        End Function

        Public Shared Function GetCatalogFileStem() As String
            Dim value = GetCatalogName()
            For Each invalidCharacter In System.IO.Path.GetInvalidFileNameChars()
                value = value.Replace(invalidCharacter, "_"c)
            Next
            Return value
        End Function

        Private Shared Function QuoteCatalogName() As String
            Return New SqlCommandBuilder().QuoteIdentifier(GetCatalogName())
        End Function
    End Class

End Namespace
