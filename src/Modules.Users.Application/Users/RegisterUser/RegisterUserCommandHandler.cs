using Application.Messaging;
using Shared.Results;

namespace Modules.Users.Application.Users.RegisterUser;

internal sealed class RegisterUserCommandHandler : ICommandHandler<RegisterUserCommand, Guid>
{
    public Task<Result<Guid>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
