

namespace API.Helpers;

using API.DataEntities;
using API.DTOs;
using AutoMapper;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AppsUser, MemberResponse>();
        CreateMap<Photo, PhotoResponse>();

    }

}