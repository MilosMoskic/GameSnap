using GameSnapAPI.Domain.Dtos;

namespace GameSnapAPI.Application.Interfaces;

public interface IUserService
{
    Task<MemberDto> GetUserByUsername(string username);
    Task<IEnumerable<MemberDto>> GetAllUsers();
}
