﻿namespace Domain.Primitives;

/// <summary>
/// Represents the abstract value object primitive.
/// </summary>
public abstract class ValueObject : IEquatable<ValueObject>
{
    public static bool operator ==(ValueObject? a, ValueObject? b)
    {
        if (a is null && b is null)
        {
            return true;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.Equals(b);
    }

    public static bool operator !=(ValueObject a, ValueObject b) => !(a == b);

    public bool Equals(ValueObject? other) => other is not null && ValuesAreEqual(other);
    
    public override bool Equals(object? obj) => obj is ValueObject valueObject && ValuesAreEqual(valueObject);

    public override int GetHashCode() =>
        GetAtomicValues().Aggregate(default(int), (hashcode, value) => HashCode.Combine(hashcode, value.GetHashCode()));
    
    private bool ValuesAreEqual(ValueObject valueObject) => GetAtomicValues().SequenceEqual(valueObject.GetAtomicValues());

    /// <summary>
    /// Gets the atomic values of the value object.
    /// </summary>
    /// <returns>The collection of objects representing the value object values.</returns>
    protected abstract IEnumerable<object> GetAtomicValues();
}
