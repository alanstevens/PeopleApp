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
      const StringComparison ignoreCase = StringComparison.OrdinalIgnoreCase;
      var searchTerm = request.SearchTerm.Trim();

      if (searchTerm.IsBlank()) return Task.FromResult(new PersonDTO[0].AsEnumerable());

      var results = _context.People
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
      var latency = rand.Next(0, 31);
      Thread.Sleep(latency * 100);
    }
  }
}
