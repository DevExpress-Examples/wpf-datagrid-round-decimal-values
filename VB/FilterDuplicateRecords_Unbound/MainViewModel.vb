Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace FilterDuplicateRecords_Unbound

    Public Class MainViewModel
        Inherits ViewModelBase

        Public ReadOnly Property Source As ObservableCollection(Of Item) = New ObservableCollection(Of Item)(Item.GetData(1000))
    End Class
End Namespace
