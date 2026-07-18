using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController:ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(("Hello World"));
    }
}