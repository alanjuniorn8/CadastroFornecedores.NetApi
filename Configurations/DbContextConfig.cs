using CadastroDeFornecedoresApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CadastroDeFornecedoresApi.Configurations
{
    public static class DbContextConfig
    {
        public static IServiceCollection AddDbContextConfig(this IServiceCollection services, IConfiguration configuration)
        {

            var connection = configuration.GetConnectionString("Default");
            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

            return services;
        }

        public static IServiceProvider UseDbContextProvider(this IServiceProvider serviceProvider)
        {
            serviceProvider.GetService<ApplicationDbContext>().Database.Migrate();

            return serviceProvider;
        }

    }
}
