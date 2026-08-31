Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Reflection
Imports System.Windows.Forms
Imports RestaurantPOS14.Configuration

Namespace RestaurantPOS14.Customization

    ''' <summary>
    ''' Applies the configured UI profile without taking a compile-time dependency on
    ''' a specific Telerik control generation. Existing forms remain unchanged until
    ''' this service is called by a composition root.
    ''' </summary>
    Public NotInheritable Class ThemeService
        Private Sub New()
        End Sub

        Public Shared Function Apply(root As Control, settings As UiSettings) As ThemeApplicationResult
            If root Is Nothing Then Throw New ArgumentNullException(NameOf(root))
            If settings Is Nothing Then Throw New ArgumentNullException(NameOf(settings))

            Dim result As New ThemeApplicationResult()
            ApplyCulture(settings.CultureName, result)
            ApplyControl(root, settings, result)
            Return result
        End Function

        Private Shared Sub ApplyControl(control As Control, settings As UiSettings, result As ThemeApplicationResult)
            ApplyThemeName(control, settings.ThemeName, result)

            If settings.FontSizePoints > 0.0F Then
                control.Font = New Font(control.Font.FontFamily, settings.FontSizePoints, control.Font.Style, GraphicsUnit.Point)
            End If

            If settings.TouchScale <> 1.0F AndAlso TypeOf control Is ButtonBase Then
                control.Width = CInt(Math.Round(control.Width * settings.TouchScale, MidpointRounding.AwayFromZero))
                control.Height = CInt(Math.Round(control.Height * settings.TouchScale, MidpointRounding.AwayFromZero))
            End If

            Dim button = TryCast(control, ButtonBase)
            If button IsNot Nothing Then
                If settings.ButtonWidth > 0 Then button.Width = settings.ButtonWidth
                If settings.ButtonHeight > 0 Then button.Height = settings.ButtonHeight
            End If

            ApplyColorOverride(control, settings.ColorOverrides, result)
            result.ControlsVisited += 1

            For Each child As Control In control.Controls
                ApplyControl(child, settings, result)
            Next
        End Sub

        Private Shared Sub ApplyThemeName(control As Control, themeName As String, result As ThemeApplicationResult)
            If String.IsNullOrWhiteSpace(themeName) Then Return

            Dim propertyInfo = control.GetType().GetProperty("ThemeName", BindingFlags.Instance Or BindingFlags.Public)
            If propertyInfo Is Nothing OrElse Not propertyInfo.CanWrite OrElse propertyInfo.PropertyType IsNot GetType(String) Then Return

            Try
                propertyInfo.SetValue(control, themeName, Nothing)
                result.ThemeAwareControls += 1
            Catch ex As Exception
                result.Warnings.Add(String.Format(CultureInfo.InvariantCulture, "Could not set theme on {0}: {1}", control.Name, ex.Message))
            End Try
        End Sub

        Private Shared Sub ApplyColorOverride(control As Control, colorOverrides As IDictionary(Of String, String), result As ThemeApplicationResult)
            If colorOverrides Is Nothing Then Return

            Dim colorText As String = Nothing
            If String.IsNullOrWhiteSpace(control.Name) OrElse Not colorOverrides.TryGetValue(control.Name, colorText) Then Return

            Try
                Dim converter As New ColorConverter()
                control.BackColor = DirectCast(converter.ConvertFromInvariantString(colorText), Color)
            Catch ex As Exception
                result.Warnings.Add(String.Format(CultureInfo.InvariantCulture, "Invalid color override for {0}: {1}", control.Name, ex.Message))
            End Try
        End Sub

        Private Shared Sub ApplyCulture(cultureName As String, result As ThemeApplicationResult)
            If String.IsNullOrWhiteSpace(cultureName) Then Return

            Try
                Dim culture = CultureInfo.GetCultureInfo(cultureName)
                Globalization.CultureInfo.CurrentCulture = culture
                Globalization.CultureInfo.CurrentUICulture = culture
            Catch ex As CultureNotFoundException
                result.Warnings.Add("Configured UI culture is not installed: " & cultureName)
            End Try
        End Sub
    End Class

    Public NotInheritable Class ThemeApplicationResult
        Public Property ControlsVisited As Integer
        Public Property ThemeAwareControls As Integer
        Public ReadOnly Property Warnings As List(Of String)

        Public Sub New()
            Warnings = New List(Of String)()
        End Sub
    End Class

End Namespace
