using BandBeacon.Domain.Notifications;
using MediatR;

namespace BandBeacon.Notifications
{
    public class NotifyUsersOfBandUpdateHandler : INotificationHandler<BandProfileUpdated>
    {
        public async Task Handle(BandProfileUpdated notification, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Notify users: {notification.BandName}", cancellationToken);
            });
        }
    }
}
