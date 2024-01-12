using BandBeacon.BandProfiles.Queries;
using BandBeacon.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BandBeacon.BandProfiles
{
    [ApiController]
    [Route("api/bandprofiles")]
    public class BandProfileController : ControllerBase
    {
        private readonly IMediator mediator;

        public BandProfileController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("health")]
        public ActionResult<string> Health()
        {
            mediator.Publish(new BandProfileUpdated
            {
                BandId = 123,
                BandName = "Guns & Roses",
                BandDescription = "Rock and roll"
            });
            return "BandProfile API is up and running!";
        }


        [HttpGet("{id}")] 
        public async Task<string> GetById(int id)
        {
            return await mediator.Send(new GetBandByIdQuery { Id = id });
        }
    }
}
