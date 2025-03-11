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
            .ForMember(dest => dest.Text, opt => opt.MapFrom<PostContentResolver>())
            .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom<PostPhotoResolver>())
            .ForMember(dest => dest.VideoUrl, opt => opt.MapFrom<PostVideoResolver>());
    }
}
