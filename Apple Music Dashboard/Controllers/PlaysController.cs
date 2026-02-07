using Apple_Music_Dashboard.Models;
using Apple_Music_Dashboard.Models.Enitities;
using Apple_Music_Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Apple_Music_Dashboard.Controllers;

[ApiController]
[Route("api/plays")]
public class PlaysController : ControllerBase
{
    private readonly PlayTrackingService _service;

    public PlaysController(PlayTrackingService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult TrackPlay([FromBody] PlayEvent play)
    {
        _service.TrackPlay(play);
        return Ok(play);
    }

    [HttpGet]
    public IActionResult GetPlays()
    {
        return Ok(_service.GetAllPlays());
    }
}
