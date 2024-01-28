using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BandBeacon.UserManager
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) :
        IdentityDbContext<BandBeaconUser>(options)
    {
    }
}
