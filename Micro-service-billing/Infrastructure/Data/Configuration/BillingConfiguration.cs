using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class BillingConfiguration : IEntityTypeConfiguration<Billing>
    {
        public void Configure(EntityTypeBuilder<Billing> builder)
        {
            builder.Property(b => b.AppUserId)
                .IsRequired();

            builder.Property(b => b.BarId)
                .IsRequired();
        }
    }
}
