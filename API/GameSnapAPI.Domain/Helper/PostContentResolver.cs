using AutoMapper;
using GameSnapAPI.Domain.Dtos;
using GameSnapAPI.Domain.Models;

public class PostContentResolver : IValueResolver<Post, PostDto, string?>
{
    public string? Resolve(Post source, PostDto destination, string? destMember, ResolutionContext context)
    {
        return source.GetPostContent()?.Text;  // No null propagation here
    }
}
public class PostPhotoResolver : IValueResolver<Post, PostDto, string?>
{
    public string? Resolve(Post source, PostDto destination, string? destMember, ResolutionContext context)
    {
        return source.GetPostContent()?.PhotoUrl;
    }
}

public class PostVideoResolver : IValueResolver<Post, PostDto, string?>
{
    public string? Resolve(Post source, PostDto destination, string? destMember, ResolutionContext context)
    {
        return source.GetPostContent()?.VideoUrl;
    }
}
