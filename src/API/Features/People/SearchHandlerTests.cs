using System.Linq;
using System.Threading;
using FluentAssertions;
using PeopleApp.Controllers;
using PeopleApp.Shared;
using Xunit;

namespace PeopleApp.Features.People
{
  public class SearchHandlerTests
  {
    private ApiContext _context;
    private SearchHandler _handler;

    public SearchHandlerTests()
    {
      _context = new ApiContext(ApiContext.InMemoryOptions);
      _context.People.AddRange(new[]
      {
        new Person{FirstName = "Lana", LastName = "Turner"},
        new Person{FirstName = "Jimmy", LastName = "Durante"},
        new Person{FirstName = "Monty", LastName = "Wooley"},
        new Person{FirstName = "Carey", LastName = "Grant"},
        new Person{FirstName = "Betty", LastName = "Davis"},
        new Person{FirstName = "Katheryn", LastName = "Hepburn"}
      });
      _handler = new SearchHandler(_context);
    }

    [Fact]
    public void should_return_empty()
    {
      var actual = _handler.Handle(new SearchRequest {SearchTerm = "  "}, default(CancellationToken));
      actual.Result.Count().Should().Be(0);
    }
  }
}
