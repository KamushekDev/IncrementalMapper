using System.Collections.Immutable;
using IncrementalMapper.Models;

namespace IncrementalMapper;

public static class GeneratorHelper
{
    public const string ConfigClassName = @"IncrementalMapperConfig";
    
    public static string GetConfigText(ImmutableArray<int> arities)
    {
        const string fileTemplate = @"
using System;
using System.Linq.Expressions;

namespace IncrementalMapper;

public enum OtherMembersBehaviour
{{
    TryMapByName,
    Ignore
}}

public class {0} 
{{
    {1}
}}

{2}
";

        var methods = new List<string>();
        var classes = new List<string>();

        foreach (var arity in arities)
        {
            methods.Add(GetMethodForNInputs(arity));
            classes.Add(GetClassForNInputs(arity));
        }

        return string.Format(fileTemplate, ConfigClassName, string.Join("", methods), string.Join("", classes));
    }

    private static string GetMethodForNInputs(int inputArgumentsCount)
    {
        const string methodTemplate = @"
    public IncrementalMapping<{0}, TOut> ConfigureMap<{0}, TOut>()
    {{
        return new IncrementalMapping<{0}, TOut>();    
    }}
";
        var result = "TIn";

        for (int i = 2; i <= inputArgumentsCount; i++)
        {
            result += $", TIn{i}";
        }

        return string.Format(methodTemplate, result);
    }

    private static string GetClassForNInputs(int inputArgumentsCount)
    {
        const string methodTemplate = @"
public class IncrementalMapping<{0}, TOut> 
{{
    public IncrementalMapping<{0}, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<{0}, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}
";
        var result = "TIn";

        for (int i = 2; i <= inputArgumentsCount; i++)
        {
            result += $", TIn{i}";
        }

        return string.Format(methodTemplate, result);
    }
}