Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf
Imports System

Namespace FilterDuplicateRecords_UnboundEditable

    Public Class MainViewModel
        Inherits ViewModelBase

         ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''         public ObservableCollection<FilterDuplicateRecords_UnboundEditable.Item> Source { get; } = new(FilterDuplicateRecords_UnboundEditable.Item.GetData(1000));
''' 
'''  <Command>
        Public Sub UnboundColumnDataCommand(ByVal e As UnboundColumnRowArgs)
            Dim number As Decimal = Nothing
            If Equals(e.FieldName, "GrowthUnbound") Then
                If e.IsGetData Then
                    e.Value = Math.Round(Me.Source(CInt(e.SourceIndex)).Growth, 2)
                    Return
                End If

                If e.IsSetData AndAlso CSharpImpl.__Assign(number, TryCast(e.Value, Decimal)) IsNot Nothing Then
                    Me.Source(e.SourceIndex).Growth = number
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
