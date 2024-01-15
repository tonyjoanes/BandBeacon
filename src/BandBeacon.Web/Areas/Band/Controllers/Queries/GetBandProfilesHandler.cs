using MediatR;

namespace BandBeacon.Web.Areas.Band.Controllers.Queries
{
    public class GetBandProfilesHandler : IRequestHandler<GetBandProfiles, string>
    {
        private readonly ILogger<GetBandProfilesHandler> logger;

        public GetBandProfilesHandler(ILogger<GetBandProfilesHandler> logger)
        {
            this.logger = logger;
        }
        public Task<string> Handle(GetBandProfiles request, CancellationToken cancellationToken)
        {
            var bands = "Stone Temple Pilots, Nirvana, Pearl Jam";
            logger.LogInformation($"Found some bands: {bands}");
            return Task.FromResult("Stone Temple Pilots, Nirvana, Pearl Jam");
        }
    }
}
