Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic

Namespace FilterDuplicateRecords_Unbound

    Public Class Item
        Inherits BindableBase

        Public ReadOnly Property Name As String

        Public Property Growth As Decimal

        Public Sub New(ByVal name As String, ByVal growth As Decimal)
            Me.Name = name
            Me.Growth = growth
        End Sub

        Public Shared Iterator Function GetData(ByVal quantity As Integer) As IEnumerable(Of Item)
            Dim gen = New Random(42)
            For i As Integer = 0 To quantity - 1
                Dim name = $"Name# {i}"
                Dim growth = 1 + 1D / gen.Next(1, 1000)
                Yield New Item(name, growth)
            Next
        End Function
    End Class
End Namespace
