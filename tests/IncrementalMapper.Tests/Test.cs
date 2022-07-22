using FluentAssertions;

namespace IncrementalMapper.Tests;

[UsesVerify]
public class Test
{
    [Fact]
    public async Task Lddfol()
    {
        var source = @"
using IncrementalMapper;

public class Person
{
    public long Id { get; init; }
    public string Fullname { get; init; }
    public byte Age { get; init; }
}

public class AnotherPerson
{
    public long Id { get; init; }
    public string Name { get; init; }
    public string Surname { get; init; }
}

public interface ITest{}

public class ConfigClass: IncrementalMapperConfig 
{
    public ConfigClass()
    {
         ConfigureMap<AnotherPerson, Person>()
                  .ForMember(dest => dest.Id, src => src.Id)
                  .ForMember(dest => dest.Fullname, src => $""{src.Name} {src.Surname}"")
            .ForAllOtherMembers(OtherMembersBehaviour.Ignore);
    }
}
public class RandomClass { }
public class RandomClassWithInterface: ITest{ }
public class RandomClassWithBase: object { }
";
        var result = await TestHelper.Verify(source);

        result.Diagnostics.Should().BeEmpty();
    }
}