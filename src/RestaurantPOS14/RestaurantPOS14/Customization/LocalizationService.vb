Imports System
Imports System.Globalization
Imports System.Resources

Namespace RestaurantPOS14.Customization

    Public Interface ILocalizationService
        Function GetText(key As String, culture As CultureInfo, fallback As String) As String
    End Interface

    ''' <summary>
    ''' Resource-manager-backed localization seam. Missing keys preserve the caller's
    ''' recovered text so adopting localization cannot blank an existing caption.
    ''' </summary>
    Public NotInheritable Class ResourceLocalizationService
        Implements ILocalizationService

        Private ReadOnly _resources As ResourceManager

        Public Sub New(resources As ResourceManager)
            If resources Is Nothing Then Throw New ArgumentNullException(NameOf(resources))
            _resources = resources
        End Sub

        Public Function GetText(key As String, culture As CultureInfo, fallback As String) As String Implements ILocalizationService.GetText
            If String.IsNullOrWhiteSpace(key) Then Throw New ArgumentException("A resource key is required.", NameOf(key))
            Dim effectiveCulture = If(culture, CultureInfo.CurrentUICulture)
            Dim value = _resources.GetString(key, effectiveCulture)
            Return If(String.IsNullOrEmpty(value), If(fallback, String.Empty), value)
        End Function
    End Class

End Namespace
