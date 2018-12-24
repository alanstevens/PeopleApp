using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using PeopleApp.Shared;

namespace PeopleApp.Controllers
{
  public class SearchHandler : IRequestHandler<SearchRequest, IEnumerable<PersonDTO>>
  {
    private readonly ApiContext _context;
    public SearchHandler(ApiContext context) { _context = context; }

    public Task<IEnumerable<PersonDTO>> Handle(SearchRequest request, CancellationToken cancellationToken)
    {
      var ignoreCase = StringComparison.OrdinalIgnoreCase;
      var searchTerm = request.SearchTerm;

      List<Person> results;
      results = _context.People
        .Where(p => p.FirstName.Contains(searchTerm, ignoreCase) || p.LastName.Contains(searchTerm, ignoreCase))
        .OrderBy(p => p.LastName)
        .ToList();

      AddLatency();

      var response = Mapper.Map<IEnumerable<PersonDTO>>(results);

      return Task.FromResult(response);
    }

    private static void AddLatency()
    {
      var rand = new Random();
      var sleep = rand.Next(0, 31);
      Thread.Sleep(sleep * 100);
    }
  }
}
