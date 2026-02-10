using Apple_Music_Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Apple_Music_Dashboard.Controllers;

[ApiController]
[Route("api/wrapped")]
public class WrappedController : ControllerBase
{
    private readonly WrappedService _wrappedService;

    public WrappedController(WrappedService wrappedService)
    {
        _wrappedService = wrappedService;
    }

    [HttpGet("weekly")]
    public IActionResult GetWeeklyWrapped()
    {
        return Ok(_wrappedService.GetWeeklyWrapped());
    }
}
