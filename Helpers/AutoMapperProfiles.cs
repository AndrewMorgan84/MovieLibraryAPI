using AutoMapper;
using MovieLibraryAPI.DTOs;
using MovieLibraryAPI.Entities;

namespace MovieLibraryAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<GenreDTO, Genre>().ReverseMap();
            CreateMap<GenreCreationDTO, Genre>();

            CreateMap<ActorDTO, Actor>().ReverseMap();
            CreateMap<ActorCreationDTO, Actor>()
                .ForMember(a => a.Picture, options => options.Ignore());
        }
    }
}
