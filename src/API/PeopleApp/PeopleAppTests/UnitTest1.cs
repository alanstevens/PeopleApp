//
//using System.Linq;
//using FluentAssertions;
//using Microsoft.EntityFrameworkCore;
//using Xunit;
//
//namespace PeopleApp.Shared
//{
//  public class ApiContextSeedTests
//  {
//    public ApiContextSeedTests()
//    {
//      var dbContextOptions = new DbContextOptionsBuilder<ApiContext>()
//        .UseInMemoryDatabase("People")
//        .Options;
//
//      _context = new ApiContext(dbContextOptions);
//    }
//
//    private ApiContext _context;
//
//    [Fact]
//    public void should_seed_database()
//    {
//      _context.Seed();
//
//      _context.Interests.Count().Should().Be(7);
//    }
//  }
//}
