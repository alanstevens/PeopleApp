using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PeopleApp.Shared.Entities;

namespace PeopleApp.Shared
{
  public class ApiContext : DbContext
  {
    public ApiContext(DbContextOptions<ApiContext> options)
      : base(options)
    {
    }

    public DbSet<Person> People { get; set; }
    public DbSet<Interest> Interests { get; set; }

    public void Seed()
    {
      foreach (var interest in SampleData.Interests)
      {
        Interests.Add(interest);
      }
      
      this.SaveChanges();

      foreach (var person in SampleData.People)
      {
        People.Add(person);
      }
      
      this.SaveChanges();

      foreach (var person in People)
      {
        var colors = person.Colors.Split();
        foreach (var color in colors)
        {
          person.Interests.Add(Interests.Single(i => i.Color == color));
        }
      }

      this.SaveChanges();
    }
  }
}
