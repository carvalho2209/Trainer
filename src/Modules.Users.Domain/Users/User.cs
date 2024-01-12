using Domain.Primitives;

namespace Modules.Users.Domain.Users;

/// <summary>
/// Represents the user entity
/// </summary>
public sealed class User : Entity<UserId>, IAuditable 
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="identityProviderId"></param>
    /// <param name="email"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    public User(UserId id, string identityProviderId, string email, string firstName, string lastName)
        : base(id)
    {
        IdentityProviderId = identityProviderId;
        Email = email;
        FirstName = firstName;
        LastName = lastName; 
    }

    /// <summary>
    /// Gets the identity provider identifier
    /// </summary>
    public string IdentityProviderId { get; private set; }
    
    /// <summary>
    /// Gets the email.
    /// </summary>
    public string Email { get; private set; }
    
    /// <summary>
    /// Gets the first name.
    /// </summary>
    public string FirstName { get; private set; }
    
    /// <summary>
    /// Gets the last name
    /// </summary>
    public string LastName { get; private set; }
    
    /// <inheritdoc cref="CreatedOnUtc"/> />
    public DateTime CreatedOnUtc { get; private set; }
    
    /// <inheritdoc cref="ModifiedOnUtc"/>
    public DateTime? ModifiedOnUtc { get; private set; }
}
