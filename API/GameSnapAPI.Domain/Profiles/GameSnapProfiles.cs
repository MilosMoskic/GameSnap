using AutoMapper;
using GameSnapAPI.Domain.Dtos;
using GameSnapAPI.Domain.Models;

namespace GameSnapAPI.Domain.Profiles;

public class GameSnapProfiles : Profile
{
    public GameSnapProfiles()
    {
        CreateMap<AppUser, MemberDto>();
        CreateMap<Post, PostDto>()
            .ForMember(dest => dest.Text, opt => opt.MapFrom<PostContentResolver<PostDto>>())
            .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom<PostPhotoResolver<PostDto>>())
            .ForMember(dest => dest.VideoUrl, opt => opt.MapFrom<PostVideoResolver<PostDto>>());
        CreateMap<Post, UserPostDto>()
            .ForMember(dest => dest.Text, opt => opt.MapFrom<PostContentResolver<UserPostDto>>())
            .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom<PostPhotoResolver<UserPostDto>>())
            .ForMember(dest => dest.VideoUrl, opt => opt.MapFrom<PostVideoResolver<UserPostDto>>())
            .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.AppUser.UserName))
            .ForMember(dest => dest.ProfilePictureUrl, opt => opt.MapFrom(src => src.AppUser.ProfilePictureUrl));
    }
}
