using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        person.Interests = new List<Interest>();
      }

      this.SaveChanges();

      foreach (var person in People)
      {
        var colors = person.Colors.Split();

        if (colors.Any())
        {
          foreach (var color in colors)
          {
            var interest = Interests.FirstOrDefault(i => i.Color == color);

            if (interest != null)
              person.Interests.Add(interest);
          }
        }
      }

      this.SaveChanges();
    }
  }
}
