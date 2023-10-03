using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Domain.EntitiesContext
{
    public class BillingDbContext : DbContext
    {
        public DbSet<Billing> Bilings { get; set; }

        public BillingDbContext(DbContextOptions<BillingDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Biling>()
            //    .Property(b => b.AppUserId)
            //    .IsRequired();

            //modelBuilder.Entity<Biling>()
            //    .Property(b => b.BarId)
            //    .IsRequired();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

        }

    }
}
