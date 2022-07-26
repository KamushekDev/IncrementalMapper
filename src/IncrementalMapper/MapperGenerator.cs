using System.Collections.Immutable;
using IncrementalMapper.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace IncrementalMapper;

[Generator(LanguageNames.CSharp)]
public class MapperGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput((sourceContext) =>
        {
            var arities = Enumerable.Range(1, 16).ToImmutableArray();
            
            sourceContext.AddSource($"{GeneratorHelper.ConfigClassName}.g.cs",
                GeneratorHelper.GetConfigText(arities));
        });

        context.RegisterSourceOutput(GetMappers(context), (sourceContext, mappers) =>
        {
            Console.WriteLine("lox");
        });
    }

    private IncrementalValueProvider<ImmutableArray<int>> GetMapConfigArities(
        IncrementalGeneratorInitializationContext context)
    {
        return context.SyntaxProvider.CreateSyntaxProvider(
                static (node, ct) =>
                    node is InvocationExpressionSyntax
                    {
                        Expression: GenericNameSyntax
                        {
                            Identifier:
                            {
                                Text: "ConfigureMap"
                            },
                            TypeArgumentList:
                            {
                                Arguments: { Count: > 0 }
                            }
                        }
                    }
                ,
                static (context, ct) =>
                {
                    var node = (InvocationExpressionSyntax)context.Node;

                    var typeArgumentsCount = node.DescendantNodes()
                        .OfType<TypeArgumentListSyntax>().First()
                        .Arguments.Count - 1;

                    return typeArgumentsCount;
                })
            .Collect()
            .Select((x, _) => x.Insert(0, 1).Distinct().ToImmutableArray());
    }

    private IncrementalValuesProvider<ImmutableArray<MappingConfig>> GetMappers(IncrementalGeneratorInitializationContext context)
    {
        var a = context.SyntaxProvider.CreateSyntaxProvider(
            static (node, ct) =>
                node is InvocationExpressionSyntax
                {
                    Expression: MemberAccessExpressionSyntax
                    {
                        Name:
                        {
                            Identifier:
                            {
                                Text: "ForMember"
                            }
                        }
                    }
                }
            ,
            static (sc, ct) =>
            {
                var symbol = (IMethodSymbol?)sc.SemanticModel.GetSymbolInfo(sc.Node).Symbol;
                var type = (INamedTypeSymbol)symbol?.ReceiverType;
                var propType = symbol?.TypeArguments.FirstOrDefault();
                var prop = symbol?.Parameters.ElementAtOrDefault(0);
                var mapping = symbol?.Parameters.ElementAtOrDefault(1);

                var args = ((InvocationExpressionSyntax)sc.Node).ArgumentList.Arguments;

                var f = sc.SemanticModel.GetTypeInfo(args[0], ct);
                
                return new MappingConfig()
                {
                     Target = args[0].Expression as SimpleLambdaExpressionSyntax,
                     Mapping = args[1].Expression as LambdaExpressionSyntax,
                     OutType = type.TypeArguments.Last() as INamedTypeSymbol,
                     InTypes = type.TypeArguments.RemoveAt(type.TypeArguments.Length-1).Cast<INamedTypeSymbol>().ToImmutableArray()
                };
            });
        return a.Collect().SelectMany((x, ct) =>
        {                
            return x.GroupBy(y => y.OutType, SymbolEqualityComparer.Default).Select(y => y.ToImmutableArray());
        });
    }
}