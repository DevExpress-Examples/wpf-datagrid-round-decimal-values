Imports System
Imports System.Globalization
Imports System.Windows.Data

Namespace FilterDuplicateRecords_Converter

    Friend Class RoundConverter
        Implements IValueConverter

        Private Const decimals As Integer = 2

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If TypeOf value Is Decimal Then
                Return Math.Round(CDec(value), decimals)
            End If

            Throw New ArgumentException()
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return value
        End Function
    End Class
End Namespace
