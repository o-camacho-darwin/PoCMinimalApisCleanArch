using Femsa.Darwin.Users.Domain.IRepositories;
using Femsa.Darwin.Users.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Femsa.Darwin.Users.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}