using Serilog;

namespace WebApp.Extensions;

internal static class HostBuilderExtensions
{
    internal static void UseSerilogWithConfiguration(
        this IHostBuilder hostBuilder) =>
        hostBuilder.UseSerilog((context, logger) =>
            logger.ReadFrom.Configuration(context.Configuration));
}
