using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PeopleApp.Controllers;

namespace PeopleApp.Features.People
{
  [Route("api/[controller]")]
  [ApiController]
  public class PeopleController : ControllerBase
  {
    private readonly IMediator _mediator;
    public PeopleController(IMediator mediator) => _mediator = mediator;

    [HttpGet("Search")]
    public async  Task<IEnumerable<PersonDTO>> Search([FromQuery] string searchTerm)
    {
      return await _mediator.Send(new SearchRequest {SearchTerm = searchTerm});
    }
  }
}
