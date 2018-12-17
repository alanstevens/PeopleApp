using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PeopleApp.Shared;

namespace PeopleApp.Controllers
{
  public class SearchHandler : IRequestHandler<SearchRequest, IEnumerable<PersonDTO>>
  {
    public Task<IEnumerable<PersonDTO>> Handle(SearchRequest request, CancellationToken cancellationToken)
    {
      return Task.FromResult(new List<PersonDTO>().AsEnumerable());
    }
  }
}
