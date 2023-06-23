using Femsa.Darwin.Users.Domain.Entities;
using Femsa.Darwin.Users.Domain.IRepositories;

namespace Femsa.Darwin.Users.Infrastructure.Repositories;

public class UserRepository: IUserRepository // BaseRepository
{
    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await Task.Run(() => new List<User>
            { new() { Id = Guid.NewGuid().ToString(), Name = "Test Name", Phone = "123156464" } });
    }
}