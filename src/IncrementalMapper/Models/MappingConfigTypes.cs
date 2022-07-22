using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace IncrementalMapper.Models;

public record struct MappingConfigTypes(ImmutableArray<ITypeSymbol> InTypes, ITypeSymbol OutType);