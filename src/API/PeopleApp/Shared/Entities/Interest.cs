using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Shared.Entities
{
  public class Interest
  {
    [Key]
    public int Id { get; set; }
    public string Color { get; set; }
    public string Name { get; set; }
  }
}
