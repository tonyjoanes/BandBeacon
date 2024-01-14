using Microsoft.AspNetCore.Mvc;

namespace BandBeacon.Web.Areas.BandProfile.Controllers
{
    [Area("Band")]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
