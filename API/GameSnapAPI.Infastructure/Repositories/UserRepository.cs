using GameSnapAPI.Domain.Interfaces;
using GameSnapAPI.Domain.Models;
using GameSnapAPI.Infastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace GameSnapAPI.Infastructure.Repositories;

public class UserRepository(DataContext context) : IUserRepository
{
    public async Task<AppUser?> GetUserById(int id)
    {
        return await context.Users.FindAsync(id);
    }

    public async Task<AppUser?> GetUserByUsername(string username)
    {
        return await context.Users.SingleOrDefaultAsync(x => x.UserName == username);
    }

    public async Task<IEnumerable<AppUser>> GetUsers()
    {
        return await context.Users.ToListAsync();
    }

    public void Update(AppUser user)
    {
        context.Entry(user).State = EntityState.Modified;
    }
}
