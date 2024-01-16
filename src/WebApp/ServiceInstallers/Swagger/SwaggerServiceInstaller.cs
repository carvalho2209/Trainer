using Infrastructure.Configuration;

namespace WebApp.ServiceInstallers.Swagger;

internal sealed class SwaggerServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureOptions<SwaggerGenOptionsSetup>();
        services.ConfigureOptions<SwaggerUiOptionsSetup>();
        services.AddSwaggerGen();
    }
}
