Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf
Imports System
Imports System.Collections.ObjectModel

Namespace FilterDuplicateRecords_UnboundEditable

    Public Class MainViewModel
        Inherits ViewModelBase

        Public ReadOnly Property Source As ObservableCollection(Of Item) = New ObservableCollection(Of Item)(Item.GetData(1000))

        <Command>
        Public Sub UnboundColumnDataCommand(ByVal e As UnboundColumnRowArgs)
            Dim number As Decimal = Nothing
            If Equals(e.FieldName, "GrowthUnbound") Then
                If e.IsGetData Then
                    e.Value = Math.Round(Source(e.SourceIndex).Growth, 2)
                    Return
                End If

                If e.IsSetData AndAlso CSharpImpl.__Assign(number, TryCast(e.Value, Decimal)) IsNot Nothing Then
                    Source(e.SourceIndex).Growth = number
                End If
            End If
        End Sub

        Private Class CSharpImpl

            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
