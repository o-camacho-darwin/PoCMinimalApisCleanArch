using Carter;
using Femsa.Darwin.Users.Application.Users.Queries;
using MediatR;

namespace Femsa.Darwin.Users.Api.Modules;

public class UsersModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("api/users", (IMediator mediator) => mediator.Send(new GetUsersQuery()));
    }
}