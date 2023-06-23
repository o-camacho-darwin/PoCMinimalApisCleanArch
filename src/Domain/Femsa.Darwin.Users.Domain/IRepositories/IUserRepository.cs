using Femsa.Darwin.Users.Domain.Entities;

namespace Femsa.Darwin.Users.Domain.IRepositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
}