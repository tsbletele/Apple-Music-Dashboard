using Apple_Music_Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Apple_Music_Dashboard.Controllers
{
    [ApiController]
    [Route("api/listening")]
    public class ListeningController : ControllerBase
    {
        private readonly PlayTrackingService _tracking;

        public ListeningController(PlayTrackingService tracking)
        {
            _tracking = tracking;
        }

        [HttpPost("play/{songId}")]
        public IActionResult Play(Guid songId)
        {
            _tracking.LogPlay(songId);
            return Ok("Play logged 🎧");
        }
    }

}
