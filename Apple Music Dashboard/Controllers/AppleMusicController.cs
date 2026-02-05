using Apple_Music_Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Apple_Music_Dashboard.Controllers
{
    [ApiController]
    [Route("api/apple-music")]
    public class AppleMusicController : ControllerBase
    {
        private readonly AppleMusicApiService _api;

        public AppleMusicController(AppleMusicApiService api)
        {
            _api = api;
        }

        [HttpGet("library/songs")]
        public async Task<IActionResult> GetSongs(
            [FromHeader(Name = "Music-User-Token")] string userToken)
        {
            var devToken = /* generate or fetch */;
            var result = await _api.GetLibrarySongsAsync(devToken, userToken);
            return Ok(result);
        }
    }

}
