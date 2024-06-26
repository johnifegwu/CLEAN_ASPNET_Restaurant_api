﻿
using CLEANASPNETRestaurant.Infrastructure.Persistence;
using CLEANASPNETRestaurant.Infrastructure.Repositories;
using CLEANASPNETRestaurant.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CLEANASPNETRestaurant.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RestaurantDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("RestaurantDbConnection")));
            services.AddScoped<IUnitOfWorkRestaurant, UnitOfWorkRestaurant>();
            services.AddScoped<IRestaurantSeeder, RestaurantSeeder>();
        }
    }
}
