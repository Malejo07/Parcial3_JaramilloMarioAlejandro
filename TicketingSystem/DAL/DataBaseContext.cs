using Microsoft.EntityFrameworkCore;
using TicketingSystem.DAL.Entities;

namespace TicketingSystem.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Tickets> Tickets { get; set; }
    }
}
