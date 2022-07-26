namespace IncrementalMapper.Sample;

public class MappingConfig : IncrementalMapperConfig
{
      public MappingConfig()
      {
            ConfigureMap<AnotherPerson, Person>()
                  .ForMember(dest => dest.Id, src => src.Id)
                  .ForMember(dest => dest.Fullname, src => $"{src.Name} {src.Surname}")
                  .ForAllOtherMembers(OtherMembersBehaviour.Ignore);

            ConfigureMap<AnotherPerson, long, Person>()
                  .ForMember(x => x.Id, (person, l) => l)
                  .ForMember(dest => dest.Fullname, (src, _) => $"{src.Name} {src.Surname}")
                  .ForAllOtherMembers(OtherMembersBehaviour.Ignore);
            
            ConfigureMap<AnotherPerson, long, int, int, string, Person>()
                  .ForMember(x => x.Id, (person, l, _, _, _) => l)
                  .ForMember(dest => dest.Fullname, (src, _, _, _, _) => $"{src.Name} {src.Surname}")
                  .ForAllOtherMembers(OtherMembersBehaviour.Ignore);  
      }
}