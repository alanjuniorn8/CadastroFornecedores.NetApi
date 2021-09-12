using CadastroFornecedores.Data;
using CadastroFornecedores.Repositories;
using CadastroFornecedores.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroDeFornecedoresApi.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection ResolveDependecies(this IServiceCollection services)
        {

            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            
            return services;
        }
    }
}