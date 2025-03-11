using GameSnapAPI.Domain.Dtos;

namespace GameSnapAPI.Application.Interfaces;

public interface IPostService
{
    Task<PostDto> CreatePostAsync(PostDto postDto, int appUserId);
}
