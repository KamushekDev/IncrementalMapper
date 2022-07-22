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
        context.RegisterPostInitializationOutput(initializationContext =>
        {
            initializationContext.AddSource($"{GeneratorHelper.ConfigClassName}.g.cs",
                GeneratorHelper.GetStaticConfigText());
        });

        var mappingConfigurations = context.SyntaxProvider.CreateSyntaxProvider(
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
                    var nodeType = (INamedTypeSymbol)context.SemanticModel.GetTypeInfo(node, ct).Type;

                    var typeArguments = nodeType.TypeArguments;

                    var inTypes = typeArguments.RemoveAt(typeArguments.Length - 1);
                    var outType = typeArguments.Last();

                    var configTypes = new MappingConfigTypes(inTypes, outType);

                    return configTypes;
                })
            .Collect()
            .Select((x, _) =>
            {
                var types = x.Distinct().Select(GeneratorHelper.GetMethodWithClassForTypes).ToImmutableArray();
                return GeneratorHelper.GetConfigFileSource(types);
            });

        // context.RegisterSourceOutput(mappingConfigurations,
        //     static (context, s) => context.AddSource("", string.Join(", ", s)));

        var configClasses = GetConfigClasses(context.SyntaxProvider);

        var mappings = configClasses.Select((classSymbol, ct) =>
        {
            if (classSymbol.Constructors.Length != 1)
                throw new Exception("Должен быть только конструктор без параметров");
            var constructor = classSymbol.Constructors.First();

            var body = constructor.PartialImplementationPart;

            return constructor.MethodKind.ToString();
        });

        // context.RegisterSourceOutput(mappings.Collect(),
        //     static (productionContext, s) => productionContext.AddSource("lol.txt", string.Join(", ", s))
        // );
    }

    private IncrementalValuesProvider<INamedTypeSymbol> GetConfigClasses(SyntaxValueProvider syntaxProvider)
    {
        var classesWithBase = syntaxProvider.CreateSyntaxProvider(
                    static (node, _) => node is ClassDeclarationSyntax
                    {
                        BaseList:
                        {
                            Types:
                            {
                                Count: > 0
                            }
                        }
                    },
                    static (c, ct) => (INamedTypeSymbol)c.SemanticModel.GetDeclaredSymbol(c.Node, cancellationToken: ct)
                )
                .Where(x => x is not null)
            ;

        var configClasses = classesWithBase
            .Select(static (potentialConfig, _) =>
            {
                return potentialConfig.BaseType.Name == GeneratorHelper.ConfigClassName ? potentialConfig : null;
            })
            .Where(x => x is not null);

        return configClasses;
    }
}