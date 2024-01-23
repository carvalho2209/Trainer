using System.Security.Claims;

namespace EndPoints.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string GetIdentityProviderId(this ClaimsPrincipal principal) =>
        principal.Claims.SingleOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
}
