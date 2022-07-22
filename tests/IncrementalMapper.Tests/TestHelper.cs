using FluentAssertions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace IncrementalMapper.Tests;

public class TestHelper
{
    public static async Task<GeneratorDriverRunResult> Verify(string source)
    {                       
        SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(source);

        var references = new[]
        {
            MetadataReference.CreateFromFile(typeof(object).Assembly.Location)
        };

        CSharpCompilation compilation = CSharpCompilation.Create(
            assemblyName: "Tests",
            syntaxTrees: new[] { syntaxTree },
            references: references);

        
        var generator = new MapperGenerator();

        GeneratorDriver driver = CSharpGeneratorDriver.Create(generator);

        driver = driver.RunGeneratorsAndUpdateCompilation(compilation, out var newCompilation, out var diagnostics);

        diagnostics.Should().BeEmpty("Test source code shouldn't contain any diagnostic!");
        
        await Verifier.Verify(driver);

        return driver.GetRunResult();
    }
}