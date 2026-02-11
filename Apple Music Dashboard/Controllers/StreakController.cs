using Apple_Music_Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Apple_Music_Dashboard.Controllers;

[ApiController]
[Route("api/streaks")]
public class StreakController : ControllerBase
{
    private readonly StreakService _streakService;

    public StreakController(StreakService streakService)
    {
        _streakService = streakService;
    }

    [HttpGet]
    public IActionResult GetStreakStats()
    {
        return Ok(_streakService.GetStreakStats());
    }
}
