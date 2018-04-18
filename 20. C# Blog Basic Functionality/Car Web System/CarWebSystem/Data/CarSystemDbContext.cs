namespace CarWebSystem.Data
{
    using CarWebSystem.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class CarSystemDbContext : IdentityDbContext<User>
    {
        public DbSet<Car> Cars { get; set; }

        public CarSystemDbContext(DbContextOptions<CarSystemDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Car>()
                .HasOne(c => c.User)
                .WithMany(u => u.Cars)
                .HasForeignKey(c => c.UserId);

            base.OnModelCreating(builder);
        }
    }
}