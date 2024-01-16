using Infrastructure.Configuration;
using WebApp.StartupTasks;

namespace WebApp.ServiceInstallers.StartupTasks;

public class StartupTasksServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration)
        => services.AddHostedService<MigrateDatabaseStartupTask>();
}
