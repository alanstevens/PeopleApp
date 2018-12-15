using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Shared
{
  public class Person
  {
    [Key]
    public int Id { get; set; }
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
    public List<Interest> Interests { get; set; }
  }
}
