using AutoMapper;
using GameSnapAPI.Domain.Dtos;
using GameSnapAPI.Domain.Models;

namespace GameSnapAPI.Domain.Profiles;

public class GameSnapProfiles : Profile
{
    public GameSnapProfiles()
    {
        CreateMap<AppUser, MemberDto>();
    }
}
