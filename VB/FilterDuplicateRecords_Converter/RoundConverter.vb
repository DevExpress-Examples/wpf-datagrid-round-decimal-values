Imports System
Imports System.Globalization
Imports System.Windows.Data

Namespace FilterDuplicateRecords_Converter

    Friend Class RoundConverter
        Implements IValueConverter

        Private Const decimals As Integer = 2

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim number As Decimal = Nothing
            If CSharpImpl.__Assign(number, TryCast(value, Decimal)) IsNot Nothing Then
                Return Math.Round(number, decimals)
            End If

            Throw New ArgumentException()
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return value
        End Function

        Private Class CSharpImpl

            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
