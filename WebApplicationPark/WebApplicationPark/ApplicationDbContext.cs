using Microsoft.EntityFrameworkCore;
using WebApplicationPark.Models;

namespace WebApplicationPark
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<TicketSales> TicketSales { get; set; }
    }
}
