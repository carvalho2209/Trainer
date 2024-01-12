using Domain.Primitives;

namespace Modules.Users.Domain.UserRegistrations;

/// <summary>
/// Represents the user registration entity.
/// </summary>
public sealed class UserRegistration : Entity<UserRegistrationId>, IAuditable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserRegistration"/> class.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="email">The email.</param>
    /// <param name="status">The status.</param>
    public UserRegistration(UserRegistrationId id, string email, UserRegistrationStatus status)
        :base((id))
    {
        Email = email;
        Status = status;
    }


    /// <summary>
    /// Gets the email.
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// Gets the identity provider identifier.
    /// </summary>
    public string? IdentityProviderId { get; private set; }

    /// <summary>
    /// Gets the first name.
    /// </summary>
    public string? FirstName { get; private set; }

    /// <summary>
    /// Gets the last name.
    /// </summary>
    public string? LastName { get; private set; }

    /// <summary>
    /// Gets the status.
    /// </summary>
    public UserRegistrationStatus Status { get; private set; }

    /// <summary>
    /// Gets the confirmed on date and time.
    /// </summary>
    public DateTime? ConfirmedOnUtc { get; private set; }

    /// <inheritdoc />
    public DateTime CreatedOnUtc { get; private set; }

    /// <inheritdoc />
    public DateTime? ModifiedOnUtc { get; private set; }
}