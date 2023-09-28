using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Domain.EntitiesContext
{
    public class BilingDbContext : DbContext
    {
        public DbSet<Biling> Bilings { get; set; }

        public BilingDbContext(DbContextOptions<BilingDbContext> options) : base(options) { }

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
