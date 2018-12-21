using System.Collections.Generic;
using MediatR;
using PeopleApp.Shared;

namespace PeopleApp.Controllers
{
  public class SearchRequest : IRequest<IEnumerable<PersonDTO>>
  {
    public string SearchTerm { get; set; }
  }
  
  public class PersonDTO
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Photo{ get; set; }
    public List<InterestDTO> Interests { get; set; }
  }

  public class InterestDTO
  {
    public string Name { get; set; }
  }
}
