using MediatR;

namespace BandBeacon.Core.Notifications
{
    public class BandProfileUpdated : INotification
    {
        public int BandId { get; set; }

        public string BandName { get; set; }

        public string BandDescription { get; set; }
    }
}
