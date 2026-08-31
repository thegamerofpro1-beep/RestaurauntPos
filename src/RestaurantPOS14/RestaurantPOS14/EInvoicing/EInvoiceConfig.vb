Namespace RestaurantPOS14.EInvoicing

    Public Class EInvoiceConfig
        Public Property BaseUrl As String

        Public Property ClientId As String

        Public Property ClientSecret As String

        Public Property Environment As RestaurantPOS14.EInvoicing.EInvoiceEnvironment

        Public Shared Function LoadDefault() As RestaurantPOS14.EInvoicing.EInvoiceConfig
            Dim settings = RestaurantPOS14.Configuration.SettingsHost.Current.EInvoice
            Return New RestaurantPOS14.EInvoicing.EInvoiceConfig With {
        .BaseUrl = settings.BaseUrl,
        .ClientId = settings.ClientId,
        .ClientSecret = settings.ClientSecret,
        .Environment = If(String.Equals(settings.Environment, "Production", StringComparison.OrdinalIgnoreCase), RestaurantPOS14.EInvoicing.EInvoiceEnvironment.Production, RestaurantPOS14.EInvoicing.EInvoiceEnvironment.Sandbox)
    }
        End Function
    End Class
End Namespace
