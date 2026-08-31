Imports System
Imports System.Globalization

Namespace RestaurantPOS14.Configuration

    ''' <summary>
    ''' Applies the configured currency precision and cash-rounding increment.
    ''' The built-in defaults reproduce Decimal.Round(value, 2) banker's rounding.
    ''' </summary>
    Public NotInheritable Class MoneyMath
        Private Sub New()
        End Sub

        Public Shared Function RoundCurrency(value As Decimal) As Decimal
            Return RoundCurrency(value, SettingsHost.Current.Tax)
        End Function

        Public Shared Function RoundCurrency(value As Decimal, settings As TaxSettings) As Decimal
            If settings Is Nothing Then Throw New ArgumentNullException(NameOf(settings))

            Dim mode = ParseRoundingMode(settings.RoundingMode)
            Dim decimalStep As Decimal = 1D
            For index = 1 To settings.DecimalPlaces
                decimalStep /= 10D
            Next

            If settings.RoundingIncrement = decimalStep Then
                Return Decimal.Round(value, settings.DecimalPlaces, mode)
            End If

            Dim incrementRounded = Decimal.Round(value / settings.RoundingIncrement, 0, mode) * settings.RoundingIncrement
            Return Decimal.Round(incrementRounded, settings.DecimalPlaces, mode)
        End Function

        Public Shared Function FormatCurrency(value As Decimal) As String
            Dim settings = SettingsHost.Current.Tax
            Return RoundCurrency(value, settings).ToString("F" & settings.DecimalPlaces.ToString(CultureInfo.InvariantCulture), CultureInfo.CurrentCulture)
        End Function

        Private Shared Function ParseRoundingMode(value As String) As MidpointRounding
            If String.Equals(value, "AwayFromZero", StringComparison.OrdinalIgnoreCase) Then
                Return MidpointRounding.AwayFromZero
            End If
            Return MidpointRounding.ToEven
        End Function
    End Class

End Namespace
