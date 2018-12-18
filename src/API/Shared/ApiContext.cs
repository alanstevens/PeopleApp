using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PeopleApp.Shared.Entities;

namespace PeopleApp.Shared
{
  public class ApiContext : DbContext
  {
    public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

    public DbSet<Person> People { get; set; }
    public DbSet<Interest> Interests { get; set; }

    public static DbContextOptions<ApiContext> InMemoryOptions => new DbContextOptionsBuilder<ApiContext>()
                                                                       .UseInMemoryDatabase("People")
                                                                       .Options;

    public static DbContextOptions<ApiContext> SqliteOptions
    {
      get
      {
        var connection = new SqliteConnection("DataSource=:memory:");
        connection.Open();

        return new DbContextOptionsBuilder<ApiContext>()
          .UseSqlite(connection)
          .Options;
      }
    }

    public void Seed()
    {
      Database.EnsureCreated();

      foreach (var interest in SampleData.Interests)
      {
        Interests.Add(interest);
      }

      SaveChanges();

      foreach (var person in SampleData.People)
      {
        person.Interests = new List<Interest>();
        People.Add(person);
      }

      SaveChanges();

      foreach (var person in People)
      {
        if (String.IsNullOrWhiteSpace(person.Colors)) continue;

        var colors = person.Colors.Split(',');

        foreach (var color in colors)
        {
          var interest = Interests.First(i => i.Color == color.Trim());

          person.Interests.Add(interest);
        }
      }
      SaveChanges();
    }
  }
}
