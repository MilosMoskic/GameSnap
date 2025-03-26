using GameSnapAPI.Domain.Dtos;
using GameSnapAPI.Domain.Models;

namespace GameSnapAPI.Application.Interfaces;

public interface IPostService
{
    Task<PostDto> CreatePostAsync(PostDto postDto, int appUserId);
    Task<IEnumerable<PostDto>> GetAllPosts();
    Task<IEnumerable<UserPostDto>> GetUserPosts(int id);
}
