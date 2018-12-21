using System;
using System.Diagnostics;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace PeopleApp.Shared
{
  public class SeedDataTests
  {
    private readonly ApiContext _context;
    private Startup _startup;

    public SeedDataTests()
    {
      _context = new ApiContext(ApiContext.SqliteOptions);
      _startup = new Startup(null);
    }

    [Fact]
    public void should_seed_database()
    {
      _startup.SeedData(_context);

      _context.Interests.Count().Should().Be(7);

      _context.People.Count().Should().Be(200);

      foreach (var person in _context.People)
      {
        if (String.IsNullOrWhiteSpace(person.Colors)) continue;

        var colors = person.Colors.Split(',');
        //Debug.Assert(person.Interests.Count == 0);
        //Debug.WriteLine($"Interest count: {person.Interests.Count}, Colors length: {colors.Length}");

        person.Interests.Count.Should().Be(colors.Length);
      }
    }
  }
} 
