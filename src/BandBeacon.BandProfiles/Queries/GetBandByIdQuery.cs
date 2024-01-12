using MediatR;

namespace BandBeacon.BandProfiles.Queries
{
    public class GetBandByIdQuery : IRequest<string>
    {
        public int Id { get; set; }
    }
}