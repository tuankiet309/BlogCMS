using Blog.Core.Domain.Identity;
using Blog.Core.SeedWorks;

namespace Blog.Core.Repositories;

public interface IUserRepository : IRepository<AppUser, Guid>
{
    Task RemoveUserFromRoles(Guid userId, string[] roles);
}