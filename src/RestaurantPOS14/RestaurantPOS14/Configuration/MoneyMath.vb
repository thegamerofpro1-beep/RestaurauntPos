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

        ' Apply only after all bill charges and deductions. Never use this for
        ' item prices, tax amounts, tendered cash, change, or historical reprints.
        Public Shared Function RoundPayableTotal(value As Decimal) As Decimal
            Return Decimal.Round(value, 1, MidpointRounding.AwayFromZero)
        End Function

        Public Shared Function FormatPayableTotal(value As Double) As String
            Return RoundPayableTotal(Convert.ToDecimal(value)).ToString("F2", CultureInfo.InvariantCulture)
        End Function

        Public Shared Function RoundCurrency(value As Decimal) As Decimal
            Return RoundCurrency(value, SettingsHost.Current.Tax)
        End Function

        Public Shared Function RoundCurrency(value As Decimal, settings As TaxSettings) As Decimal
            If settings Is Nothing Then Throw New ArgumentNullException(NameOf(settings))

            Dim decimalPlaces = Math.Max(0, Math.Min(6, settings.DecimalPlaces))
            Dim mode = ParseRoundingMode(settings.RoundingMode)
            Dim decimalStep As Decimal = 1D
            For index = 1 To decimalPlaces
                decimalStep /= 10D
            Next

            Dim roundingIncrement = If(settings.RoundingIncrement > 0D, settings.RoundingIncrement, decimalStep)
            If roundingIncrement = decimalStep Then
                Return Decimal.Round(value, decimalPlaces, mode)
            End If

            Dim incrementRounded = Decimal.Round(value / roundingIncrement, 0, mode) * roundingIncrement
            Return Decimal.Round(incrementRounded, decimalPlaces, mode)
        End Function

        Public Shared Function FormatCurrency(value As Decimal) As String
            Dim settings = SettingsHost.Current.Tax
            Dim decimalPlaces = Math.Max(0, Math.Min(6, settings.DecimalPlaces))
            Return RoundCurrency(value, settings).ToString("F" & decimalPlaces.ToString(CultureInfo.InvariantCulture), CultureInfo.CurrentCulture)
        End Function

        Private Shared Function ParseRoundingMode(value As String) As MidpointRounding
            If String.Equals(value, "AwayFromZero", StringComparison.OrdinalIgnoreCase) Then
                Return MidpointRounding.AwayFromZero
            End If
            Return MidpointRounding.ToEven
        End Function
    End Class

End Namespace
