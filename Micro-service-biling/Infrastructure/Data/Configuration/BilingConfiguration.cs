using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class BilingConfiguration : IEntityTypeConfiguration<Biling>
    {
        public void Configure(EntityTypeBuilder<Biling> builder)
        {
            builder.Property(b => b.AppUserId)
                .IsRequired();

            builder.Property(b => b.BarId)
                .IsRequired();
        }
    }
}
