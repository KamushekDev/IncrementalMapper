using System.Collections.Immutable;
using IncrementalMapper.Models;

namespace IncrementalMapper;

public static class GeneratorHelper
{
    public const string ConfigClassName = @"IncrementalMapperConfig";


    public static string GetStaticConfigText()
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
    public IncrementalMapping<TIn, TOut> ConfigureMap<TIn, TOut>()
    {{
        return new IncrementalMapping<TIn, TOut>();    
    }}
    public IncrementalMapping<TIn1, TIn2, TOut> ConfigureMap<TIn1, TIn2, TOut>()
    {{
        return new IncrementalMapping<TIn1, TIn2, TOut>();    
    }}
    public IncrementalMapping<TIn1, TIn2, TIn3, TOut> ConfigureMap<TIn1, TIn2, TIn3, TOut>()
    {{
        return new IncrementalMapping<TIn1, TIn2, TIn3, TOut>();    
    }}
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TOut>()
    {{
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut>();    
    }}
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>()
    {{
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>();    
    }}
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>()
    {{
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>();    
    }}
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>()
    {{
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>();    
    }}
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> ConfigureMap<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>()
    {{
        return new IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut>();    
    }}
}}

public class IncrementalMapping<TIn, TOut> 
{{
    public IncrementalMapping<TIn, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}

public class IncrementalMapping<TIn1, TIn2, TOut> 
{{
    public IncrementalMapping<TIn1, TIn2, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}

public class IncrementalMapping<TIn1, TIn2, TIn3, TOut> 
{{
    public IncrementalMapping<TIn1, TIn2, TIn3, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut> 
{{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> 
{{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> 
{{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> 
{{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> 
{{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}
";

        return string.Format(fileTemplate, ConfigClassName);
    }

    public static string GetConfigFileSource(ImmutableArray<(string m, string c)> usedTypes)
    {
        const string configFileTemplate = @"
using System;
using System.Linq.Expressions;

namespace IncrementalMapper;
public enum OtherMembersBehaviour
{
    TryMapByName,
    Ignore
}

public class {0}} 
{
    public IncrementalMapping<TIn, TOut> ConfigureMap<TIn, TOut>()
    {
        return new IncrementalMapping<TIn, TOut>();    
    }
    
}

public class IncrementalMapping<TIn, TOut> 
{
    public IncrementalMapping<TIn, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

public class IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> 
{
    public IncrementalMapping<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TOut> ForMember<TMember>(Expression<Func<TOut, TMember>> member, Expression<Func<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TIn8, TMember>> mapFunc)
    {
        return this;
    }
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) { }
}

";

        var methods = string.Join(Environment.NewLine, usedTypes.Select(x => x.m));
        var classes = string.Join(Environment.NewLine, usedTypes.Select(x => x.c));


        var configFileText = string.Format(configFileTemplate, ConfigClassName, methods, classes);

        return configFileText;
    }

    public static (string methodSource, string classSource) GetMethodWithClassForTypes(MappingConfigTypes types)
    {
        const string methodTemplate = @"
public IncrementalMapping<{0}, {1}> ConfigureMap<{0}, {1}>()
{{
    return new IncrementalMapping<{0}, {1}>();    
}}
";
        const string classTemplate = @"
public class IncrementalMapping<{0}, {1}> 
{{
    public IncrementalMapping<{0}, {1}> ForMember<TMember>(Expression<Func<{1}, TMember>> member, Expression<Func<{0}, TMember>> mapFunc)
    {{
        return this;
    }}
    public void ForAllOtherMembers(OtherMembersBehaviour behaviour) {{ }}
}}        
";

        var inTypesSeparated = string.Join(", ", types.InTypes.Select(x => x.Name));

        var methodText = string.Format(methodTemplate, inTypesSeparated, types.OutType.Name);

        var classText = string.Format(classTemplate, inTypesSeparated, types.OutType.Name);

        return (methodText, classText);
    }
}