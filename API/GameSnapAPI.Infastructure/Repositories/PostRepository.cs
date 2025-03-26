using GameSnapAPI.Domain.Interfaces;
using GameSnapAPI.Domain.Models;
using GameSnapAPI.Infastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace GameSnapAPI.Infastructure.Repositories;

public class PostRepository(DataContext context) : IPostRepository
{
    public async Task<Post> CreatePost(Post post)
    {
        await context.Posts.AddAsync(post);
        await context.SaveChangesAsync();
        return post;
    }

    public async Task<IEnumerable<Post>> GetAllPosts()
    {
        return await context.Posts.ToListAsync();
    }

    public async Task<IEnumerable<Post>> GetUserPosts(int id)
    {
        return await context.Posts.Where(u => u.AppUserId == id).Include(p => p.AppUser).ToListAsync();
    }
}
