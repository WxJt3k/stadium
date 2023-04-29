using Microsoft.EntityFrameworkCore;
using BarkeysPlace.Shared.Entities;

namespace BarkeysPlace.API.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           modelBuilder.Entity<Ticket>().HasIndex(x => x.Porteria);
        }
    }
}
