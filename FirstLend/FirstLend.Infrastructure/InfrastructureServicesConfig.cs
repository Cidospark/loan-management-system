using FirstLend.Infrastructure.Data;
using FraudGuard.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FraudGuard.Infrastructure
{
    public static class InfrastructureServicesConfig
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FirstLendDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            // {
            //     options.Password.RequiredLength = 8;
            //     options.Password.RequireNonAlphanumeric = false;
            // })
            // .AddEntityFrameworkStores<FirstLendDbContext>()
            // .AddDefaultTokenProviders();

            return services;
        }

    }
}