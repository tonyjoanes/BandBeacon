using Microsoft.AspNetCore.Mvc;

namespace BandBeacon.BandProfiles
{
    [ApiController]
    [Route("api/bandprofiles")]
    public class BandProfileController : ControllerBase
    {
        [HttpGet("health")]
        public ActionResult<string> Health()
        {
            return "BandProfile API is up and running!";
        }
    }
}
