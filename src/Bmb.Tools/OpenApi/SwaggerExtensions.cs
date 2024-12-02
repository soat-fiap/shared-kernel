using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Bmb.Tools.OpenApi;

public static class SwaggerExtensions
{
  
    public static IApplicationBuilder UseBmbSwaggerUi(this IApplicationBuilder app)
    {
        var version = Assembly.GetCallingAssembly().GetName().Version.Major;
        return app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint($"/swagger/v{version}/swagger.yaml", $"v{version}");
        });
    }
    
    public static IServiceCollection ConfigBmbSwaggerGen(this IServiceCollection services)
    {
        var productName = Assembly.GetCallingAssembly()
            .GetCustomAttribute<AssemblyProductAttribute>();
        var assemblyName = Assembly.GetCallingAssembly().GetName().Name;
        var version = Assembly.GetCallingAssembly().GetName().Version;
        
        return services.AddSwaggerGen(c =>
        {
            c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
            {
                Description = "Standard Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                In = ParameterLocation.Header,
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey
            });

            c.OperationFilter<SecurityRequirementsOperationFilter>();
            c.SwaggerDoc($"v{version.Major}", new OpenApiInfo
            {
                Title = productName.Product, Version = $"v{version.Major}.{version.Minor}.{version.Build}",
                Extensions =
                {
                    {
                        "x-logo",
                        new OpenApiObject
                        {
                            {
                                "url",
                                new OpenApiString(
                                    "https://avatars.githubusercontent.com/u/165858718?s=384")
                            },
                            {
                                "background",
                                new OpenApiString(
                                    "#FF0000")
                            }
                        }
                    }
                }
            });

            var xmlFile = $"{assemblyName}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            c.IncludeXmlComments(xmlPath);
        });
    }
}