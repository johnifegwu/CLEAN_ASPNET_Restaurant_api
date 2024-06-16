using CLEANASPNETRestaurant.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CLEANASPNETRestaurant.Infrastructure.Persistence
{
    internal class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options):base(options)
        {
        }

        internal DbSet<Restaurant> Restaurants { get; set; }
        internal DbSet<Dish> Dishes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Dish>().Property(d => d.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Restaurant>().OwnsOne(r => r.Address);
            modelBuilder.Entity<Restaurant>().HasMany(r => r.Dishes)
                .WithOne().HasForeignKey(f => f.RestaurantId);
        }
    }
}
