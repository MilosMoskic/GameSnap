using AutoMapper;
using GameSnapAPI.Domain.Dtos;
using GameSnapAPI.Domain.Models;

public class PostContentResolver<TDestination> : IValueResolver<Post, TDestination, string?>
    where TDestination : class
{
    public string? Resolve(Post source, TDestination destination, string? destMember, ResolutionContext context)
    {
        return source.GetPostContent()?.Text;
    }
}

public class PostPhotoResolver<TDestination> : IValueResolver<Post, TDestination, string?>
    where TDestination : class
{
    public string? Resolve(Post source, TDestination destination, string? destMember, ResolutionContext context)
    {
        return source.GetPostContent()?.PhotoUrl;
    }
}

public class PostVideoResolver<TDestination> : IValueResolver<Post, TDestination, string?>
    where TDestination : class
{
    public string? Resolve(Post source, TDestination destination, string? destMember, ResolutionContext context)
    {
        return source.GetPostContent()?.VideoUrl;
    }
}
