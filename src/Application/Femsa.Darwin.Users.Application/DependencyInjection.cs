using System.Reflection;
using Femsa.Darwin.Users.Application.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace Femsa.Darwin.Users.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MapperConfig));
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}