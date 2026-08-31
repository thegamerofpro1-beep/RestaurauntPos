Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class SettingsValidationException
        Inherits Exception

        Public ReadOnly Property Errors As IReadOnlyList(Of String)

        Public Sub New(errors As IEnumerable(Of String))
            MyBase.New("Configuration validation failed:" & Environment.NewLine & String.Join(Environment.NewLine, errors))
            Me.Errors = New List(Of String)(errors).AsReadOnly()
        End Sub
    End Class

    Public NotInheritable Class SettingsValidator
        Private Shared ReadOnly SupportedThemes As HashSet(Of String) = New HashSet(Of String)(
            New String() {"Aqua", "Desert", "FluentDark", "HighContrastBlack", "Office2013Dark", "VisualStudio2012Dark"},
            StringComparer.OrdinalIgnoreCase)

        Private Sub New()
        End Sub

        Public Shared Function Validate(settings As ApplicationSettings) As IReadOnlyList(Of String)
            Dim errors As New List(Of String)()
            If settings Is Nothing Then
                errors.Add("The merged configuration is empty.")
                Return errors.AsReadOnly()
            End If

            ValidateDatabase(settings.Database, errors)
            ValidatePrinting(settings.Printing, errors)
            ValidateTax(settings.Tax, errors)
            ValidateEndpoints(settings, errors)
            ValidateUi(settings.Ui, errors)
            ValidateReports(settings.Reports, errors)
            Return errors.AsReadOnly()
        End Function

        Private Shared Sub ValidateDatabase(value As DatabaseSettings, errors As List(Of String))
            If value Is Nothing Then
                errors.Add("Database settings are required.")
                Return
            End If

            If value.CommandTimeoutSeconds < 0 Then errors.Add("Database.CommandTimeoutSeconds cannot be negative.")
            If value.ConnectionTimeoutSeconds <= 0 Then errors.Add("Database.ConnectionTimeoutSeconds must be greater than zero.")
            If String.IsNullOrWhiteSpace(value.DefaultCatalog) Then errors.Add("Database.DefaultCatalog is required.")
            If String.IsNullOrWhiteSpace(value.ConnectionString) Then Return

            Try
                Dim builder As New SqlConnectionStringBuilder(value.ConnectionString)
                If String.IsNullOrWhiteSpace(builder.DataSource) Then errors.Add("Database.ConnectionString must specify a data source.")
                If String.IsNullOrWhiteSpace(builder.InitialCatalog) Then errors.Add("Database.ConnectionString must specify an initial catalog.")
            Catch ex As ArgumentException
                errors.Add("Database.ConnectionString is invalid: " & ex.Message)
            End Try
        End Sub

        Private Shared Sub ValidatePrinting(value As PrintingSettings, errors As List(Of String))
            If value Is Nothing Then
                errors.Add("Printing settings are required.")
                Return
            End If

            If value.ThermalPaperWidthMm < 40 OrElse value.ThermalPaperWidthMm > 200 Then errors.Add("Printing.ThermalPaperWidthMm must be between 40 and 200.")
            If value.PaymentTerminalPort < 0 OrElse value.PaymentTerminalPort > 65535 Then errors.Add("Printing.PaymentTerminalPort must be between 0 and 65535.")
            If value.SerialReadTimeoutMilliseconds <= 0 Then errors.Add("Printing.SerialReadTimeoutMilliseconds must be greater than zero.")
            If value.SerialWriteTimeoutMilliseconds <= 0 Then errors.Add("Printing.SerialWriteTimeoutMilliseconds must be greater than zero.")
        End Sub

        Private Shared Sub ValidateTax(value As TaxSettings, errors As List(Of String))
            If value Is Nothing Then
                errors.Add("Tax settings are required.")
                Return
            End If

            If value.SstRatePercent < 0D OrElse value.SstRatePercent > 100D Then errors.Add("Tax.SstRatePercent must be between 0 and 100.")
            If value.ServiceChargeRatePercent < 0D OrElse value.ServiceChargeRatePercent > 100D Then errors.Add("Tax.ServiceChargeRatePercent must be between 0 and 100.")
            If value.DecimalPlaces < 0 OrElse value.DecimalPlaces > 6 Then errors.Add("Tax.DecimalPlaces must be between 0 and 6.")
            If value.RoundingIncrement <= 0D Then errors.Add("Tax.RoundingIncrement must be greater than zero.")
            If Not String.Equals(value.RoundingMode, "ToEven", StringComparison.OrdinalIgnoreCase) AndAlso
               Not String.Equals(value.RoundingMode, "AwayFromZero", StringComparison.OrdinalIgnoreCase) Then
                errors.Add("Tax.RoundingMode must be ToEven or AwayFromZero.")
            End If
        End Sub

        Private Shared Sub ValidateEndpoints(settings As ApplicationSettings, errors As List(Of String))
            If settings.EInvoice Is Nothing Then
                errors.Add("EInvoice settings are required.")
            Else
                ValidateAbsoluteHttpsUrl(settings.EInvoice.BaseUrl, "EInvoice.BaseUrl", errors)
                If settings.EInvoice.RequestTimeoutSeconds <= 0 Then errors.Add("EInvoice.RequestTimeoutSeconds must be greater than zero.")
                If settings.Features IsNot Nothing AndAlso settings.Features.EInvoicing Then
                    If String.IsNullOrWhiteSpace(settings.EInvoice.ClientId) Then errors.Add("EInvoice.ClientId is required when e-invoicing is enabled.")
                    If String.IsNullOrWhiteSpace(settings.EInvoice.ClientSecret) Then errors.Add("EInvoice.ClientSecret is required when e-invoicing is enabled.")
                End If
            End If

            If settings.OnlineOrders Is Nothing Then
                errors.Add("OnlineOrders settings are required.")
            ElseIf settings.Features IsNot Nothing AndAlso settings.Features.OnlineOrders Then
                ValidateAbsoluteHttpsUrl(settings.OnlineOrders.BaseUrl, "OnlineOrders.BaseUrl", errors)
                If String.IsNullOrWhiteSpace(settings.OnlineOrders.ApiKey) Then errors.Add("OnlineOrders.ApiKey is required when online orders are enabled.")
            End If
        End Sub

        Private Shared Sub ValidateAbsoluteHttpsUrl(value As String, name As String, errors As List(Of String))
            Dim parsed As Uri = Nothing
            If String.IsNullOrWhiteSpace(value) OrElse Not Uri.TryCreate(value, UriKind.Absolute, parsed) Then
                errors.Add(name & " must be an absolute URL.")
            ElseIf Not String.Equals(parsed.Scheme, Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase) Then
                errors.Add(name & " must use HTTPS.")
            End If
        End Sub

        Private Shared Sub ValidateUi(value As UiSettings, errors As List(Of String))
            If value Is Nothing Then
                errors.Add("UI settings are required.")
                Return
            End If

            If Not String.IsNullOrWhiteSpace(value.ThemeName) AndAlso Not SupportedThemes.Contains(value.ThemeName) Then errors.Add("Ui.ThemeName is not one of the shipped themes.")
            If value.FontSizePoints <> 0.0F AndAlso (value.FontSizePoints < 7.0F OrElse value.FontSizePoints > 36.0F) Then errors.Add("Ui.FontSizePoints must be zero (unchanged) or between 7 and 36.")
            If value.TouchScale < 0.75F OrElse value.TouchScale > 2.5F Then errors.Add("Ui.TouchScale must be between 0.75 and 2.5.")
            If value.ButtonWidth <> 0 AndAlso value.ButtonWidth < 40 Then errors.Add("Ui.ButtonWidth must be zero (unchanged) or at least 40.")
            If value.ButtonHeight <> 0 AndAlso value.ButtonHeight < 30 Then errors.Add("Ui.ButtonHeight must be zero (unchanged) or at least 30.")
            ValidatePosLayout(value.PosLayout, errors)
            If Not String.IsNullOrWhiteSpace(value.CultureName) Then
                Try
                    System.Globalization.CultureInfo.GetCultureInfo(value.CultureName)
                Catch ex As System.Globalization.CultureNotFoundException
                    errors.Add("Ui.CultureName is not an installed culture.")
                End Try
            End If
        End Sub

        Private Shared Sub ValidatePosLayout(value As PosLayoutSettings, errors As List(Of String))
            If value Is Nothing Then
                errors.Add("Ui.PosLayout settings are required.")
                Return
            End If

            Dim dimensions = New Integer() {
                value.CategoryButtonWidth, value.CategoryButtonHeight,
                value.ImagePanelWidth, value.ImagePanelHeight,
                value.ImageButtonWidth, value.ImageButtonHeight, value.ImageCaptionHeight,
                value.RatePanelWidth, value.RatePanelHeight,
                value.RateButtonWidth, value.RateButtonHeight, value.RateLabelHeight
            }
            If dimensions.Any(Function(item) item <= 0) Then errors.Add("Ui.PosLayout dimensions must be greater than zero.")

            If value.ButtonOverrides Is Nothing Then Return
            For Each item In value.ButtonOverrides
                If String.IsNullOrWhiteSpace(item.Key) Then errors.Add("Ui.PosLayout button override keys cannot be empty.")
                If item.Value Is Nothing Then
                    errors.Add("Ui.PosLayout button override '" & item.Key & "' is empty.")
                    Continue For
                End If
                If item.Value.Width.HasValue AndAlso item.Value.Width.Value <= 0 Then errors.Add("Ui.PosLayout button override '" & item.Key & "' has an invalid width.")
                If item.Value.Height.HasValue AndAlso item.Value.Height.Value <= 0 Then errors.Add("Ui.PosLayout button override '" & item.Key & "' has an invalid height.")
                If item.Value.Row.HasValue AndAlso item.Value.Row.Value < 0 Then errors.Add("Ui.PosLayout button override '" & item.Key & "' has a negative row.")
                If item.Value.Column.HasValue AndAlso item.Value.Column.Value < 0 Then errors.Add("Ui.PosLayout button override '" & item.Key & "' has a negative column.")
            Next
        End Sub

        Private Shared Sub ValidateReports(value As ReportSettings, errors As List(Of String))
            If value Is Nothing Then
                errors.Add("Report settings are required.")
                Return
            End If

            Dim allowed As New HashSet(Of String)(New String() {"PDF", "Excel", "Word", "Crystal"}, StringComparer.OrdinalIgnoreCase)
            If Not allowed.Contains(value.DefaultExportFormat) Then errors.Add("Reports.DefaultExportFormat must be PDF, Excel, Word, or Crystal.")
            If value.ExportFormats Is Nothing Then Return
            For Each item In value.ExportFormats
                If String.IsNullOrWhiteSpace(item.Key) Then errors.Add("Reports.ExportFormats keys cannot be empty.")
                If Not allowed.Contains(item.Value) Then errors.Add("Reports.ExportFormats['" & item.Key & "'] must be PDF, Excel, Word, or Crystal.")
            Next
        End Sub
    End Class

End Namespace
