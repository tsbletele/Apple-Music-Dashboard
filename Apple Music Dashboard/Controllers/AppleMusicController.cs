using Microsoft.AspNetCore.Mvc;

namespace Apple_Music_Dashboard.Controllers
{
    public class AppleMusicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
