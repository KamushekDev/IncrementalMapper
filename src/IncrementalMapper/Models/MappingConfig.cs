using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace IncrementalMapper.Models;

public struct MappingConfig
{
    public ImmutableArray<INamedTypeSymbol> InTypes { get; init; }
    public INamedTypeSymbol OutType { get; init; }
    public SimpleLambdaExpressionSyntax Target { get; init; }
    public LambdaExpressionSyntax Mapping { get; init; }
}