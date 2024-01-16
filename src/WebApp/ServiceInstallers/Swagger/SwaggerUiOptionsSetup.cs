using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace WebApp.ServiceInstallers.Swagger;

/// <summary>
/// Represents the <see cref="SwaggerUIOptions"/>
/// </summary>
internal sealed class SwaggerUiOptionsSetup : IConfigureOptions<SwaggerUIOptions>
{
    public void Configure(SwaggerUIOptions options) => options.DisplayRequestDuration();
}
