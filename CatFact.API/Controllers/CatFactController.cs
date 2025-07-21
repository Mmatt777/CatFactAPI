using CatFact.API.CatFact;
using CatFact.API.CatFact.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CatFact.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CatFactController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<CatFacts>> GetCatFact()
    {
        var catFact = await mediator.Send(new CatFactQuery());
        return Ok(catFact);
    }
}
