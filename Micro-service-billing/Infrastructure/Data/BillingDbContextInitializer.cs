using Domain.EntitiesContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class InitialiserExtensions
    {

        public static async Task InitialiseDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var initialiser = scope.ServiceProvider.GetRequiredService<BillingDbContextInitializer>();

            await initialiser.TryInitializeAsync();

            await initialiser.SeedAsync();
        }

    }

    public class BillingDbContextInitializer
    {
        private readonly BillingDbContext _context;
        public BillingDbContextInitializer(BillingDbContext context) { _context = context; }

        public async Task TryInitializeAsync()
        {
            try
            {
                await InitializeAsync();
            }
            catch (Exception) { }
        }

        public async Task InitializeAsync() => await _context.Database.MigrateAsync();

        public async Task SeedAsync()
        {

        }
    }
}
