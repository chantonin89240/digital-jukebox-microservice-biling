using Domain.EntitiesContext;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DependencyInjection
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddDbContext<BilingDbContext>();

            services.AddTransient<StripeHandler>();
        }
    }
}
