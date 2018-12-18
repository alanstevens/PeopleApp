using System.Linq;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace PeopleApp.Shared
{
  public class ApiContextTests
  {
    private readonly ApiContext _context;

    public ApiContextTests()
    {
      _context = new ApiContext(ApiContext.InMemoryOptions);
    }


    [Fact]
    public void should_seed_database()
    {
      _context.Seed();

      _context.Interests.Count().Should().Be(7);

      _context.People.Count().Should().Be(200);
    }
  }
}
