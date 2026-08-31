Imports System
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Customization

    Public Enum PosButtonKind
        Category
        ItemWithImage
        ItemWithRate
        ItemText
        Action
    End Enum

    Public NotInheritable Class PosButtonLayout
        Public Property Key As String = String.Empty
        Public Property Width As Integer
        Public Property Height As Integer
        Public Property BackColorArgb As Integer?
        Public Property ForeColor As String = String.Empty
        Public Property SortOrder As Integer?
        Public Property Row As Integer?
        Public Property Column As Integer?
        Public Property Visible As Boolean = True
    End Class

    ''' <summary>
    ''' Combines the recovered database-driven category/item style with JSON or
    ''' dbo.ApplicationSettings overrides. The service does not alter a form until
    ''' its resolved values are applied by that form's existing button builder.
    ''' </summary>
    Public NotInheritable Class PosButtonLayoutResolver
        Private ReadOnly _settings As PosLayoutSettings

        Public Sub New(settings As PosLayoutSettings)
            If settings Is Nothing Then Throw New ArgumentNullException(NameOf(settings))
            _settings = settings
        End Sub

        Public Function Resolve(key As String, kind As PosButtonKind, databaseBackColorArgb As Integer?, databaseForeColor As String) As PosButtonLayout
            If String.IsNullOrWhiteSpace(key) Then Throw New ArgumentException("A POS button key is required.", NameOf(key))

            Dim width As Integer
            Dim height As Integer
            Select Case kind
                Case PosButtonKind.Category
                    width = _settings.CategoryButtonWidth
                    height = _settings.CategoryButtonHeight
                Case PosButtonKind.ItemWithImage
                    width = _settings.ImageButtonWidth
                    height = _settings.ImageButtonHeight
                Case PosButtonKind.ItemWithRate
                    width = _settings.RateButtonWidth
                    height = _settings.RateButtonHeight
                Case Else
                    width = _settings.RatePanelWidth
                    height = _settings.RatePanelHeight
            End Select

            Dim result As New PosButtonLayout With {
                .Key = key,
                .Width = width,
                .Height = height,
                .BackColorArgb = databaseBackColorArgb,
                .ForeColor = If(databaseForeColor, String.Empty),
                .Visible = True
            }

            Dim configured As PosButtonOverrideSettings = Nothing
            If _settings.ButtonOverrides IsNot Nothing AndAlso _settings.ButtonOverrides.TryGetValue(key, configured) AndAlso configured IsNot Nothing Then
                If configured.Width.HasValue Then result.Width = configured.Width.Value
                If configured.Height.HasValue Then result.Height = configured.Height.Value
                If configured.BackColorArgb.HasValue Then result.BackColorArgb = configured.BackColorArgb
                If Not String.IsNullOrWhiteSpace(configured.ForeColor) Then result.ForeColor = configured.ForeColor
                result.SortOrder = configured.SortOrder
                result.Row = configured.Row
                result.Column = configured.Column
                If configured.Visible.HasValue Then result.Visible = configured.Visible.Value
            End If
            Return result
        End Function
    End Class

End Namespace
