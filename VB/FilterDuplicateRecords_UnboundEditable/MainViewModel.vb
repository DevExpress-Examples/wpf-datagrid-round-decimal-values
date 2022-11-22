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
            If Equals(e.FieldName, "GrowthUnbound") Then
                If e.IsGetData Then
                    e.Value = Math.Round(Source(e.SourceIndex).Growth, 2)
                    Return
                End If

                If e.IsSetData AndAlso TypeOf e.Value Is Decimal Then
                    Source(e.SourceIndex).Growth = CDec(e.Value)
                End If
            End If
        End Sub
    End Class
End Namespace
