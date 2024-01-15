using BandBeacon.Web.Areas.Band.Controllers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BandBeacon.Web.Areas.BandProfile.Controllers
{
    [Area("Band")]
    public class ProfileController : Controller
    {
        private readonly IMediator mediator;

        public ProfileController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var response = await mediator.Send(new GetBandProfiles());
            return View();
        }
    }
}
