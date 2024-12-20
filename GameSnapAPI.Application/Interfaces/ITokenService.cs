using GameSnapAPI.Domain.Models;

namespace GameSnapAPI.Application.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
