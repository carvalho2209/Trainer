using FluentValidation;
using Infrastructure.Configuration;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Extensions;

namespace Modules.Users.Infrastructure.ServiceInstallers;

/// <summary>
/// Represents the users module application service installer.
/// </summary>
internal sealed class ApplicationServiceInstaller : IServiceInstaller
{
    /// <inheritdoc />
    public void Install(IServiceCollection services, IConfiguration configuration) =>
        services
            .AddMediatR(Application.AssemblyReference.Assembly);

}
