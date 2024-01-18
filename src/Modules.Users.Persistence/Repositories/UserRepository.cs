using Application.ServiceLifetimes;
using Microsoft.EntityFrameworkCore;
using Modules.Users.Domain.Users;
using Shared.Results;

namespace Modules.Users.Persistence.Repositories;

internal sealed class UserRepository : IUserRepository, IScoped
{
    private readonly UsersDbContext _context;

    public UserRepository(UsersDbContext context) => _context = context;

    public async Task<Result<User>> GetByIdAsync(UserId id, CancellationToken cancellationToken = default) =>
        Result.Create(await _context.Set<User>()
            .Include(user => user.Roles).FirstOrDefaultAsync(user => user.Id == id, cancellationToken));

    public async Task<Result> IsEmailUniqueAsync(string email, CancellationToken cancellationToken = default) =>
        Result.Create(!await _context.Set<User>()
            .AnyAsync(user => user.Email == email, cancellationToken));

    public void Add(User user)
    {
        _context.Set<User>().Add(user);

        _context.AttachRange(user.Roles);
    }
}
