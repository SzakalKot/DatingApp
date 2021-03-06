using System.Linq;
using AutoMapper;
using DatingApp.Api.Dtos;
using DatingApp.Api.Models;

namespace DatingApp.Api.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User ,UserForListDto>()
                .ForMember(dest => dest.PhotoUrl ,opt => {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.Age , opt =>{
                    opt.ResolveUsing(d => d.DateOfBirth.ClacualteAge());
                });

            CreateMap<User ,UserForDetailedDto>()
             .ForMember(dest => dest.PhotoUrl ,opt => {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.Age , opt =>{
                    opt.ResolveUsing(d => d.DateOfBirth.ClacualteAge());
                });

            CreateMap<Photo ,PhotosForDetailedDto>();
        }
    }
}