using Application.Service;
using Infrastructure;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class DependencyInjection
    {
        public static void Configure(IServiceCollection services)
        {
            StripeConfiguration.ApiKey = "sk_test_51NvGSVB6THHP0CX0uPfJiPFYXE6WRlraGFVqRXNnrc1IV3CuJUBMzuWZvqmkrom8r5ynLmyOtaOOqrr9VEuLkSYf00UHdxN0kR";

            services.AddScoped<StripeHandler>();
            services.AddScoped<BillingService>();
            
        }
    }
}
