using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modules.Users.Application.Users.GetUserById;
using Modules.Users.Endpoints.Routes;
using Swashbuckle.AspNetCore.Annotations;

namespace Modules.Users.Endpoints.Users;

public sealed class GetUserByIdEndpoint : EndpointBaseAsync
    .WithRequest<Guid>
    .WithActionResult<UserResponse>
{
    [HttpGet(UsersRoutes.GetById, Name = nameof(GetUserByIdEndpoint))]
    [ProducesResponseType(typeof(UserResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [SwaggerOperation(
        Summary = "Gets the user by id.",
        Description = "Gets the user with the specified identifier.",
        Tags = new[] { UsersRoutes.Tag })]
    public override Task<ActionResult<UserResponse>> HandleAsync(Guid request, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}
