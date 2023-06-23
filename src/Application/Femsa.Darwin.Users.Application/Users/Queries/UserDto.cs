using AutoMapper;
using Femsa.Darwin.Users.Domain.Entities;

namespace Femsa.Darwin.Users.Application.Users.Queries;

public class UserDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
}