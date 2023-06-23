using AutoMapper;
using Femsa.Darwin.Users.Application.Users.Queries;
using Femsa.Darwin.Users.Domain.Entities;

namespace Femsa.Darwin.Users.Application.Configurations;

public class MapperConfig : Profile
{
    public MapperConfig()
    {   
        CreateMap<User, UserDto>().ReverseMap();
    }
}