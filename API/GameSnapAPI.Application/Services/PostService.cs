using AutoMapper;
using GameSnapAPI.Application.Exceptions;
using GameSnapAPI.Application.Interfaces;
using GameSnapAPI.Domain.Dtos;
using GameSnapAPI.Domain.Interfaces;
using GameSnapAPI.Domain.Models;

namespace GameSnapAPI.Application.Services;

public class PostService(IPostRepository postRepository, IMapper mapper) : IPostService
{
    public async Task<PostDto> CreatePostAsync(PostDto postDto, int appUserId)
    {
        var content = new PostContent
        {
            Text = postDto.Text,
            PhotoUrl = postDto.PhotoUrl,
            VideoUrl = postDto.VideoUrl
        };

        if (string.IsNullOrEmpty(content.Text))
        {
            throw new ArgumentNullException("Text cannot be null or empty.");
        }

        var post = new Post
        {
            Title = postDto.Title,
            AppUserId = appUserId
        };

        if (string.IsNullOrEmpty (post.Title))
        {
            throw new ArgumentNullException("Title cannot be null or empty.");
        }

        post.SetPostContent(content);
        
        await postRepository.CreatePost(post);

        var mappedPost = mapper.Map<PostDto>(post);

        return mappedPost;
    }

    public async Task<IEnumerable<PostDto>> GetAllPosts()
    {
        var postsInDb = await postRepository.GetAllPosts();

        if (postsInDb == null)
        {
            throw new NotFoundException("There are no posts in database.");
        }

        var mappedPosts = mapper.Map<IEnumerable<PostDto>>(postsInDb);

        return mappedPosts;
    }
}
