using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Hotal.Model
{
    public class HotalDbContext : DbContext
    {
        public HotalDbContext(DbContextOptions<HotalDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Availability> Availabilities { get; set; }

        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             // Configure the database provider and connection string
             optionsBuilder.UseSqlServer("data source=DESKTOP-BQF0PSQ\\SQLEXPRESS;database=Hotal;integrated security=true;trustservercertificate=true;");
         }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             // Define the foreign key relationships

         }*/
    }

}
