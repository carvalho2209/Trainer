namespace Modules.Users.Domain.Roles;

public sealed class RolePermission
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RolePermission"/> class.
    /// </summary>
    /// <param name="role"></param>
    /// <param name="permission"></param>
    public RolePermission(Role role, Permission permission)
    {
        RoleId = role.Id;
        PermissionId = permission.Id;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RolePermission"/> class.
    /// </summary>
    /// <remarks>
    ///  Required by EF Core.
    /// </remarks>
    public RolePermission() { }

    /// <summary>
    /// Gets the role identifier.
    /// </summary>
    public int RoleId { get; private set; }

    /// <summary>
    /// Gets the permission identifier.
    /// </summary>
    public int PermissionId { get; private set; }
}