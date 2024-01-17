using Infrastructure.Extensions;
using Serilog;
using WebApp.Extensions;
using WebApp.Utility;

namespace WebApp;

public class Program
{
    public static void Main(string[] args)
    {
        LoggingUtility.Run(() =>
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
                .InstallServicesFromAssemblies(
                    builder.Configuration,
                    AssemblyReference.Assembly,
                    Authorization.AssemblyReference.Assembly,
                    Persistence.AssemblyReference.Assembly)
                .InstallModulesFromAssemblies(
                    builder.Configuration,
                    Modules.Users.Infrastructure.AssemblyReference.Assembly);

            builder.Host.UseSerilogWithConfiguration();

            var webApplication = builder.Build();

            webApplication
                .UseSwagger()
                .UseSwaggerUI()
                .UseCors(corsPolicyBuilder =>
                    corsPolicyBuilder
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin());

            webApplication.UseSerilogRequestLogging()
                .UseHttpsRedirection()
                .UseAuthentication()
                .UseAuthorization();

            webApplication.MapControllers();

            webApplication.Run();
        });
    }
}