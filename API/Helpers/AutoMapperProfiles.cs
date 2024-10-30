

namespace API.Helpers;

using API.DataEntities;
using API.DTOs;
using API.Extensions;
using AutoMapper;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<AppsUser, MemberResponse>()
        .ForMember(d => d.Age,
            o => o.MapFrom(s => s.BirthDay.CalculateAge()))
            .ForMember(dest => dest.PhotoUrl, ori => ori.MapFrom(
                s => s.Photos.FirstOrDefault(p => p.IsMain)!.Url));
        CreateMap<Photo, PhotoResponse>();

    }

}