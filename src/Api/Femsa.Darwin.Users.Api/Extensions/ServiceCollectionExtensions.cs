using System.Reflection;

namespace Femsa.Darwin.Users.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddMediator(this IServiceCollection services)
    {
        //services.AddAutoMapper(typeof(MapperConfig));
        //services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}