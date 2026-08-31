Imports System
Imports System.Collections.Generic

Namespace RestaurantPOS14.Configuration

    Public NotInheritable Class ApplicationSettings
        Public Property Database As DatabaseSettings
        Public Property Printing As PrintingSettings
        Public Property Tax As TaxSettings
        Public Property Receipt As ReceiptSettings
        Public Property EInvoice As EInvoiceSettings
        Public Property OnlineOrders As OnlineOrderSettings
        Public Property Features As FeatureFlags
        Public Property Ui As UiSettings
        Public Property Paths As PathSettings
        Public Property Reports As ReportSettings

        Public Sub New()
            Database = New DatabaseSettings()
            Printing = New PrintingSettings()
            Tax = New TaxSettings()
            Receipt = New ReceiptSettings()
            EInvoice = New EInvoiceSettings()
            OnlineOrders = New OnlineOrderSettings()
            Features = New FeatureFlags()
            Ui = New UiSettings()
            Paths = New PathSettings()
            Reports = New ReportSettings()
        End Sub

        Public Shared Function CreateDefaults() As ApplicationSettings
            Return New ApplicationSettings()
        End Function
    End Class

    Public NotInheritable Class DatabaseSettings
        Public Property ConnectionString As String = String.Empty
        Public Property ConnectionStringSecretKey As String = "Database.ConnectionString"
        Public Property DefaultCatalog As String = "RPOS_DB"
        Public Property CommandTimeoutSeconds As Integer = 0
        Public Property ConnectionTimeoutSeconds As Integer = 15
    End Class

    Public NotInheritable Class PrintingSettings
        Public Property DefaultPrinterName As String = String.Empty
        Public Property KitchenPrinterName As String = String.Empty
        Public Property ThermalPaperWidthMm As Integer = 80
        Public Property A4PaperName As String = "A4"
        Public Property CashDrawerPort As String = String.Empty
        Public Property CashDrawerOpenCode As String = String.Empty
        Public Property CustomerDisplayPort As String = String.Empty
        Public Property CallerIdPort As String = String.Empty
        Public Property CallerIdDiagnosticPort As String = "COM5"
        Public Property WeighingScalePort As String = String.Empty
        Public Property PaymentTerminalAddress As String = String.Empty
        Public Property PaymentTerminalPort As Integer = 0
        Public Property SerialReadTimeoutMilliseconds As Integer = 2000
        Public Property SerialWriteTimeoutMilliseconds As Integer = 2000
    End Class

    Public NotInheritable Class TaxSettings
        Public Property SstRatePercent As Decimal = 0D
        Public Property ServiceChargeRatePercent As Decimal = 0D
        Public Property CurrencySymbol As String = "RM"
        Public Property CurrencyCode As String = "MYR"
        Public Property DecimalPlaces As Integer = 2
        Public Property RoundingMode As String = "ToEven"
        Public Property RoundingIncrement As Decimal = 0.01D
    End Class

    Public NotInheritable Class ReceiptSettings
        Public Property BusinessName As String = String.Empty
        Public Property AddressLines As List(Of String) = New List(Of String)()
        Public Property RegistrationNumber As String = String.Empty
        Public Property TaxRegistrationNumber As String = String.Empty
        Public Property HeaderText As String = String.Empty
        Public Property FooterText As String = String.Empty
        Public Property LogoPath As String = String.Empty
        Public Property TemplatePath As String = String.Empty
        Public Property ShowTaxBreakdown As Boolean = True
        Public Property ShowOperator As Boolean = True
    End Class

    Public NotInheritable Class EInvoiceSettings
        Public Property BaseUrl As String = "https://preprod-api.myinvois.hasil.gov.my"
        Public Property Environment As String = "Sandbox"
        Public Property RequestTimeoutSeconds As Integer = 30
        Public Property ClientIdSecretKey As String = "EInvoice.ClientId"
        Public Property ClientSecretSecretKey As String = "EInvoice.ClientSecret"

        <Newtonsoft.Json.JsonIgnore>
        Public Property ClientId As String = String.Empty

        <Newtonsoft.Json.JsonIgnore>
        Public Property ClientSecret As String = String.Empty
    End Class

    Public NotInheritable Class OnlineOrderSettings
        Public Property BaseUrl As String = String.Empty
        Public Property PollIntervalSeconds As Integer = 30
        Public Property RequestTimeoutSeconds As Integer = 30
        Public Property ApiKeySecretKey As String = "OnlineOrders.ApiKey"
        Public Property SharedSecretSecretKey As String = "OnlineOrders.SharedSecret"

        <Newtonsoft.Json.JsonIgnore>
        Public Property ApiKey As String = String.Empty

        <Newtonsoft.Json.JsonIgnore>
        Public Property SharedSecret As String = String.Empty
    End Class

    Public NotInheritable Class FeatureFlags
        Public Property Checklist As Boolean = False
        Public Property Loyalty As Boolean = True
        Public Property GiftCards As Boolean = True
        Public Property Delivery As Boolean = True
        Public Property EInvoicing As Boolean = False
        Public Property OnlineOrders As Boolean = False
        Public Property SecondaryDisplay As Boolean = True
        Public Property CallerId As Boolean = True
        Public Property WeighingScale As Boolean = False
        Public Property IngenicoTerminal As Boolean = True
    End Class

    Public NotInheritable Class UiSettings
        Public Property ThemeName As String = String.Empty
        Public Property FontSizePoints As Single = 0.0F
        Public Property TouchScale As Single = 1.0F
        Public Property ButtonWidth As Integer = 0
        Public Property ButtonHeight As Integer = 0
        Public Property CultureName As String = String.Empty
        Public Property ColorOverrides As Dictionary(Of String, String) = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Public Property PosLayout As PosLayoutSettings = New PosLayoutSettings()
    End Class

    Public NotInheritable Class PosLayoutSettings
        Public Property CategoryButtonWidth As Integer = 115
        Public Property CategoryButtonHeight As Integer = 60
        Public Property ImagePanelWidth As Integer = 110
        Public Property ImagePanelHeight As Integer = 140
        Public Property ImageButtonWidth As Integer = 108
        Public Property ImageButtonHeight As Integer = 90
        Public Property ImageCaptionHeight As Integer = 35
        Public Property RatePanelWidth As Integer = 110
        Public Property RatePanelHeight As Integer = 97
        Public Property RateButtonWidth As Integer = 105
        Public Property RateButtonHeight As Integer = 70
        Public Property RateLabelHeight As Integer = 20
        Public Property ButtonOverrides As Dictionary(Of String, PosButtonOverrideSettings) = New Dictionary(Of String, PosButtonOverrideSettings)(StringComparer.OrdinalIgnoreCase)
    End Class

    Public NotInheritable Class PosButtonOverrideSettings
        Public Property Width As Integer?
        Public Property Height As Integer?
        Public Property BackColorArgb As Integer?
        Public Property ForeColor As String = String.Empty
        Public Property SortOrder As Integer?
        Public Property Row As Integer?
        Public Property Column As Integer?
        Public Property Visible As Boolean?
    End Class

    Public NotInheritable Class PathSettings
        Public Property ReportOutputDirectory As String = "PDF Reports"
        Public Property MenuImageDirectory As String = "Menu Items Image"
        Public Property SecondaryDisplayImageDirectory As String = "Secondary Display Images"
        Public Property ExportDirectory As String = String.Empty
        Public Property BackupDirectory As String = String.Empty
    End Class

    Public NotInheritable Class ReportSettings
        Public Property DefaultExportFormat As String = "PDF"
        Public Property KeepCrystalReportsAsDefault As Boolean = True
        Public Property PrinterAssignments As Dictionary(Of String, String) = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Public Property ExportFormats As Dictionary(Of String, String) = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
    End Class

End Namespace
