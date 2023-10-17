using Microsoft.EntityFrameworkCore;
using WebApplicationPark.Models;

namespace WebApplicationPark
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Login> Logins { get; set; }
    }
}
