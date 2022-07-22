namespace IncrementalMapper.Sample;

public class MappingConfig : IncrementalMapperConfig
{
      public MappingConfig()
      {
            ConfigureMap<AnotherPerson, Person>()
                  .ForMember(dest => dest.Id, src => src.Id)
                  .ForMember(dest => dest.Fullname, src => $"{src.Name} {src.Surname}")
                  .ForAllOtherMembers(OtherMembersBehaviour.Ignore);
      }
}