using AutoMapper;
using GameSnapAPI.Application.Exceptions;
using GameSnapAPI.Application.Interfaces;
using GameSnapAPI.Domain.Dtos;
using GameSnapAPI.Domain.Interfaces;

namespace GameSnapAPI.Application.Services;

public class UserService(IUserRepository userRepository, IMapper mapper) : IUserService
{
    public async Task<MemberDto> GetUserByUsername(string username)
    {
        var user = await userRepository.GetUserByUsername(username);

        if (user == null)
        {
            throw new NotFoundException("User Not Found.");
        }

        var mappedUser = mapper.Map<MemberDto>(user);

        return mappedUser;
    }

    public async Task<IEnumerable<MemberDto>> GetAllUsers()
    {
        var users = await userRepository.GetUsers();

        if (users == null)
        {
            throw new NotFoundException("There are no users.");
        }

        var mappedUsers = mapper.Map<IEnumerable<MemberDto>>(users);

        return mappedUsers;
    }
}
