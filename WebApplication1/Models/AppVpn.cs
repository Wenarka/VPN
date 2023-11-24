using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VPN.Models.Data;

namespace VPN.Models
{
    public class AppCtx : IdentityDbContext<User>
    {
        public AppCtx(DbContextOptions<AppCtx> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}