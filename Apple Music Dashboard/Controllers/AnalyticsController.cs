using Apple_Music_Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Apple_Music_Dashboard.Controllers;

[ApiController]
[Route("api/analytics")]
public class AnalyticsController : ControllerBase
{
    private readonly AnalyticsService _analyticsService;

    public AnalyticsController(AnalyticsService analyticsService) 
    {
        _analyticsService = analyticsService;
    }

    [HttpGet("summary")]
    public IActionResult GetSummary()
    {
        return Ok(_analyticsService.GetOverallSummary());
    }
}
