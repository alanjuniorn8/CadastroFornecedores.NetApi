using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace CadastroDeFornecedoresApi.Configurations
{
    public static class  WebApiConfig
    {   
        public static IServiceCollection AddConfigurations(this IServiceCollection services)
        {   

            services.AddAutoMapper(typeof(Startup));

            services.AddControllers();

            services.Configure<ApiBehaviorOptions>(options =>
                options.SuppressModelStateInvalidFilter = true
            );

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CadastroDeFornecedoresApi", Version = "v1" });
            });

            return services;
        }
        public static IApplicationBuilder useConfigurations(this IApplicationBuilder app)
        {   

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            return app;
        }
    }
}