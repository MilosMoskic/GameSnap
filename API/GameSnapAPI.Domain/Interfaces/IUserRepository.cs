using GameSnapAPI.Domain.Models;

namespace GameSnapAPI.Domain.Interfaces;

public interface IUserRepository
{
    void Update(AppUser user);
    Task<IEnumerable<AppUser>> GetUsers();
    Task<AppUser?> GetUserById(int id);
    Task<AppUser?> GetUserByUsername(string username);
}
