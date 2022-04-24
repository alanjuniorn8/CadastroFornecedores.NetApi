using CadastroDeFornecedoresApi.Data;
using CadastroDeFornecedoresApi.Notificacoes;
using CadastroDeFornecedoresApi.Notificacoes.Interfaces;
using CadastroDeFornecedoresApi.Repositories;
using CadastroDeFornecedoresApi.Repositories.Interfaces;
using CadastroDeFornecedoresApi.Services;
using CadastroDeFornecedoresApi.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CadastroDeFornecedoresApi.Configurations
{
    public static class DependencyInjectionConfig 
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {

            services.AddScoped<ApplicationDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            
            return services;
        }
    }
}