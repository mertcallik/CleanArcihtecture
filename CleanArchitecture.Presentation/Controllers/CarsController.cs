using CleanArchitecture.Application.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Presentation.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

public sealed class CarsController : ApiController
{
    public CarsController(IMediator mediator) : base(mediator) { }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateCar(string? Name, string? Model, int EnginePower,
        CancellationToken cancellationToken)
    { 
        var request = new CreateCarCommand(Model, Name, EnginePower);
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}