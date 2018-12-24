using System.Linq;
using System.Threading;
using AutoMapper;
using FluentAssertions;
using PeopleApp.Controllers;
using PeopleApp.Shared;
using Xunit;

namespace PeopleApp.Features.People
{
  public class SearchHandlerTests
  {
    private readonly SearchHandler _handler;

    public SearchHandlerTests()
    {
      Mapper.Reset();
      Mapper.Initialize(cfg => cfg.AddProfiles(GetType().Assembly));
      var context = new ApiContext(ApiContext.InMemoryOptions);
      context.People.AddRange(
        new Person{FirstName = "Lana", LastName = "Turner"},
        new Person{FirstName = "Jimmy", LastName = "Durante"},
        new Person{FirstName = "Monty", LastName = "Wooley"},
        new Person{FirstName = "Cary", LastName = "Grant"},
        new Person{FirstName = "Betty", LastName = "Davis"},
        new Person{FirstName = "Katheryn", LastName = "Hepburn"}
      );
      context.SaveChanges();
      _handler = new SearchHandler(context);
    }

    [Fact]
    public void should_return_none_for_blank_search_term()
    {
      var actual = _handler.Handle(new SearchRequest {SearchTerm = "  "}, default(CancellationToken));
      actual.Result.Count().Should().Be(0);
    }

    [Fact]
    public void should_return_four_for_r()
    {
      var actual = _handler.Handle(new SearchRequest {SearchTerm = "r"}, default(CancellationToken));
      actual.Result.Count().Should().Be(4);
    }
  }
}
