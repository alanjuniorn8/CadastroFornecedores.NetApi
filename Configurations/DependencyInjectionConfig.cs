using CadastroDeFornecedoresApi.Data;
using CadastroDeFornecedoresApi.Repositories;
using CadastroDeFornecedoresApi.Repositories.Interfaces;
using CadastroDeFornecedoresApi.Services;
using CadastroDeFornecedoresApi.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroDeFornecedoresApi.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection ResolveDependecies(this IServiceCollection services)
        {

            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            
            return services;
        }
    }
}