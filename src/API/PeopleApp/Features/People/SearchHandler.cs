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
      var results = _context.People.Where(p => p.FirstName.Contains(request.SearchTerm) || p.LastName.Contains(request.SearchTerm));

      var response = Mapper.Map<IEnumerable<PersonDTO>>(results);

      return Task.FromResult(response);
    }
  }
}
