using Microsoft.EntityFrameworkCore;
using Modules.Users.Persistence;

namespace WebApp.StartupTasks;

/// <summary>
/// Represents the startup task for migrating the database in the development environment only.
/// </summary>
public class MigrateDatabaseStartupTask : BackgroundService
{
    private readonly IHostEnvironment _environment;
    private readonly IServiceProvider _serviceProvider;

    /// <summary>
    /// Initializes a new instance of the <see cref="MigrateDatabaseStartupTask"/> class.
    /// </summary>
    /// <param name="environment">The environment.</param>
    /// <param name="serviceProvider">The service provider.</param>
    public MigrateDatabaseStartupTask(IHostEnvironment environment, IServiceProvider serviceProvider)
    {
        _environment = environment;
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_environment.IsDevelopment())
        {
            return;
        }

        using IServiceScope scope = _serviceProvider.CreateScope();
        
        await MigrateDatabaseAsync<UsersDbContext>(scope, stoppingToken);
    }

    private static async Task MigrateDatabaseAsync<T>(IServiceScope scope, CancellationToken stoppingToken)
        where T : DbContext
    {
        T dbContext = scope.ServiceProvider.GetRequiredService<T>();

        await dbContext.Database.MigrateAsync(stoppingToken);
    }
}