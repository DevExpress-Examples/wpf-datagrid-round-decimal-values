Imports DevExpress.Mvvm

Namespace FilterDuplicateRecords_Converter

    Public Class MainViewModel
        Inherits ViewModelBase

         ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.ExpressionSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node)
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping)
''' 
''' Input:
'''         public ObservableCollection<FilterDuplicateRecords_Converter.Item> Source { get; } = new(FilterDuplicateRecords_Converter.Item.GetData(1000));
''' 
'''  End Class
End Namespace
