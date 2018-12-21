using System.Collections.Generic;

namespace PeopleApp.Shared.Entities
{
  public class Interest
  {
    public int InterestId { get; set; }
    public string Color { get; set; }
    public string Name { get; set; }
    public List<PersonInterest> PersonInterests { get; set; }
  }
}
