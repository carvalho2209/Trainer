using Infrastructure.Configuration;

namespace WebApp.Swagger;

internal sealed class SwaggerServiceInstaller : IServiceInstaller 
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureOptions<SwaggerGenOptionsSetup>();
        services.ConfigureOptions<SwaggerUiOptionsSetup>();
        services.AddSwaggerGen();
    }
}
