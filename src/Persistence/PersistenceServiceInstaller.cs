using Infrastructure.Configuration;
using Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Options;

namespace Persistence;

internal sealed class PersistenceServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration) =>
        services
            .ConfigureOptions<ConnectionStringSetup>()
            .AddTransientAsMatchingInterfaces(AssemblyReference.Assembly);
}
