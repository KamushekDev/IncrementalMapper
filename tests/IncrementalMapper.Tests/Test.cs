using System.Linq.Expressions;
using FluentAssertions;
using Microsoft.CodeAnalysis;

namespace IncrementalMapper.Tests;

[UsesVerify]
public class Test
{
    [Fact]
    public async Task Lddfol()
    {
        var source = $@"
using System;
using IncrementalMapper;

public class Person
{{
    public long Id {{ get; init; }}
    public string Fullname {{ get; init; }}
    public byte Age {{ get; init; }}
}}

public class AnotherPerson
{{
    public long Id {{ get; init; }}
    public string Name {{ get; init; }}
    public string Surname {{ get; init; }}
}}

public class AnotherOtherPerson
{{
    public long Id {{ get; init; }}
    public string NickName {{ get; init; }}
}}

public interface ITest{{}}

public class ConfigClass: IncrementalMapperConfig 
{{
    public ConfigClass()
    {{
        ConfigureMap<AnotherPerson, Person>()
                  .ForMember(dest => dest.Id, src => src.Id)
                  .ForMember(dest => dest.Fullname, src => $""{{src.Name}} {{src.Surname}}"")
            .ForAllOtherMembers(OtherMembersBehaviour.Ignore);

        ConfigureMap<AnotherPerson, long, int, int, int, string, Person>()
                  .ForMember(dest => dest.Id, (src, _, _, _, _, _) => src.Id)
                  .ForMember(dest => dest.Fullname, (src, _, _, _, _, _) => $""{{src.Name}} {{src.Surname}}"")
            .ForAllOtherMembers(OtherMembersBehaviour.Ignore);

        ConfigureMap<Person, AnotherOtherPerson>()
                  .ForMember(dest => dest.Id, src => src.Id)
                  .ForMember(dest => dest.NickName, src => src.Fullname)
            .ForAllOtherMembers(OtherMembersBehaviour.Ignore);
        ConfigureMap<Person, long, AnotherOtherPerson>()
                  .ForMember(dest => dest.Id, (_, id) => id)
                  .ForMember(dest => dest.NickName, (src, _) => src.Fullname)
            .ForAllOtherMembers(OtherMembersBehaviour.Ignore);
    }}
}}
public class RandomClass {{ }}
public class RandomClassWithInterface: ITest{{ }}
public class RandomClassWithBase: object {{ }}
";
        var assemblies = new[]
        {
            MetadataReference.CreateFromFile(typeof(Expression<>).Assembly.Location)
        };
        
        var result = await TestHelper.Verify(source, assemblies);

        result.Diagnostics.Should().BeEmpty();
    }
}