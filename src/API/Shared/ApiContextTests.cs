using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace PeopleApp.Shared
{
  public class ApiContextTests
  {
    private readonly ApiContext _context;

    public ApiContextTests()
    {
      _context = new ApiContext(ApiContext.SqliteOptions);
    }

    [Fact]
    public void should_seed_database()
    {
      _context.Seed();

      _context.Interests.Count().Should().Be(7);

      _context.People.Count().Should().Be(200);

      foreach (var person in _context.People)
      {
        if (String.IsNullOrWhiteSpace(person.Colors)) continue;

        var colors = person.Colors.Split(',');

        person.Interests.Count.Should().Be(colors.Length);
      }
    }
  }
} 
