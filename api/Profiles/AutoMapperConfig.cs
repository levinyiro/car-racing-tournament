using AutoMapper;
using api.DTO;
using api.Models;

namespace api.Profiles
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Race, RaceDto>().ReverseMap();
            CreateMap<Result, ResultDto>().ReverseMap();
            CreateMap<Season, SeasonCreateDto>().ReverseMap();
        }
    }
}
