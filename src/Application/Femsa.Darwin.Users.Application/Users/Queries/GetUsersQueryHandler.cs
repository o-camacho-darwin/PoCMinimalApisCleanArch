using AutoMapper;
using Femsa.Darwin.Users.Domain.IRepositories;
using MediatR;

namespace Femsa.Darwin.Users.Application.Users.Queries;

public class GetUsersQueryHandler: IRequestHandler<GetUsersQuery, List<UserDto>>
{
    
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;
    
    public GetUsersQueryHandler(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public async Task<List<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var users = await _repository.GetUsersAsync();
            return _mapper.Map<List<UserDto>>(users);
            //return Task.Run(() => 1, cancellationToken);
        }
        finally
        {
            // _logger.Trace($"End {nameof(Handle)}");
        }
    }
}