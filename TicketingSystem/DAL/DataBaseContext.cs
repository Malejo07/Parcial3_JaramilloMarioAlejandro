using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using TicketingSystem.DAL.Entities;

namespace TicketingSystem.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(t => t.TicketId).IsUnique();
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
