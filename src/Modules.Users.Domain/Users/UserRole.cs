﻿namespace Modules.Users.Domain.Users;

/// <summary>
/// Represents the user role join entity
/// </summary>
public sealed class UserRole
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRole"/>
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="roleId"></param>
    public UserRole(UserId userId, int roleId)
    {
        UserId = userId;
        RoleId = roleId;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private UserRole() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    
    /// <summary>
    /// Gets the user identifier
    /// </summary>
    public UserId UserId { get; private set; }

    /// <summary>
    /// Gets the user identifier
    /// </summary>
    public int RoleId { get; private set; }
}
