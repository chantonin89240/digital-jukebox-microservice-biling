using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Domain.EntitiesContext
{
    public class BillingDbContext : DbContext
    {
        public DbSet<Billing> Billings { get; set; }

        public BillingDbContext(DbContextOptions<BillingDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Billing>()
            //    .Property(b => b.AppUserId)
            //    .IsRequired();

            //modelBuilder.Entity<Billing>()
            //    .Property(b => b.BarId)
            //    .IsRequired();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
