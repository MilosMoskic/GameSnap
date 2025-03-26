using GameSnapAPI.Domain.Models;

namespace GameSnapAPI.Domain.Interfaces;

public interface IPostRepository
{
    Task<Post> CreatePost(Post post);
    Task<IEnumerable<Post>> GetAllPosts();
    Task<IEnumerable<Post>> GetUserPosts(int id);
}
