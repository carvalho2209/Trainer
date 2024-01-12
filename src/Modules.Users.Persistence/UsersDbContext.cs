using Microsoft.EntityFrameworkCore;
using Modules.Users.Persistence.Constants;

namespace Modules.Users.Persistence;

public sealed class UsersDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UsersDbContext"/> class.
    /// </summary>
    /// <param name="options">The database context options.</param>
    public UsersDbContext(DbContextOptions<UsersDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema(Schemas.Users);

        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
    }
}