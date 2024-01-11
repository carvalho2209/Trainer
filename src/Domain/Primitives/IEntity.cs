namespace Domain.Primitives;

public interface IEntity
{
    /// <summary>
    /// Gets the domain events
    /// </summary>
    /// <returns>The readonly list of domain events</returns>
    IReadOnlyList<IDomainEvent> GetDomainEvents();

    /// <summary>
    /// Clear the list of domain events
    /// </summary>
    void ClearDomainEvents();
}