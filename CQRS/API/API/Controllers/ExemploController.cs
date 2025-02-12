using Investimentos.Application.Contracts.Exemplo;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Investimentos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExemploController : ControllerBase
{
    private readonly IMediator _mediator;

    public ExemploController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("exemplo/query")]
    public async Task<IActionResult> GetQueryExemplo([FromQuery] ExemploQueryRequest queryRequest)
    {
        var response = await _mediator.Send(queryRequest);

        return Ok(response);
    }
}
