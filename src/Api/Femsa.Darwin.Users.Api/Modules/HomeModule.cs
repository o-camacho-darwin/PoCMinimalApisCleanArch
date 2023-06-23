using Carter;

namespace Femsa.Darwin.Users.Api.Modules;

public class HomeModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/", () => "Hello World!");
    }
}