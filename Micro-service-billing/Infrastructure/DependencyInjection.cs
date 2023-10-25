using Domain.EntitiesContext;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<BillingDbContext>((options) =>
            {
                options.UseSqlServer(connectionString);
            });

            //services.AddScoped<IDomainEventService, DomainEventService>();

            services.AddScoped<BillingDbContextInitializer>();

            var context = services.BuildServiceProvider().GetRequiredService<BillingDbContext>();
            context.Database.MigrateAsync();

            return services;
        }
    }
}
