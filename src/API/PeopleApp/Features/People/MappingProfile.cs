using AutoMapper;
using PeopleApp.Shared;
using PeopleApp.Shared.Entities;

namespace PeopleApp.Controllers
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Person, PersonDTO>(MemberList.Source);
      CreateMap<Interest, InterestDTO>(MemberList.Source);
    }
  }
}
