using BandBeacon.BandProfiles.Queries;
using MediatR;

namespace BandBeacon.BandProfiles.Handlers
{
    public class GetBandByIdHandler : IRequestHandler<GetBandByIdQuery, string>
    {
        public Task<string> Handle(GetBandByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Stone Temple Pilots: {request.Id}");
        }
    }
}