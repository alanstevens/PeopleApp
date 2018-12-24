using System.Collections.Generic;
using System.Linq;
using PeopleApp.Shared.Entities;

namespace PeopleApp.Shared
{
  public class Person
  {
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Photo{ get; set; }
    public string Colors { get; set; }
    public List<PersonInterest> PersonInterests { get; set; }
    public List<Interest> Interests
    {
      get
      {
        if(PersonInterests.IsNull()) return new List<Interest>();
        return PersonInterests.Select(i => i.Interest).ToList();
      }
    }
  }
}
