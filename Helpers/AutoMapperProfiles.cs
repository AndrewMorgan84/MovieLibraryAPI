using AutoMapper;
using MovieLibraryAPI.DTOs;
using MovieLibraryAPI.Entities;
using NetTopologySuite.Geometries;

namespace MovieLibraryAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles(GeometryFactory geometryFactory)
        {
            CreateMap<GenreDTO, Genre>().ReverseMap();
            CreateMap<GenreCreationDTO, Genre>();

            CreateMap<ActorDTO, Actor>().ReverseMap();
            CreateMap<ActorCreationDTO, Actor>()
                .ForMember(a => a.Picture, options => options.Ignore());

            CreateMap<MovieTheater, MovieTheaterDTO>()
                .ForMember(mt => mt.Latitude, dto => dto.MapFrom(prop => prop.Location.Y))
                .ForMember(mt => mt.Longitude, dto => dto.MapFrom(prop => prop.Location.X));

            CreateMap<MovieTheaterCreationDTO, MovieTheater>()
                .ForMember(x => x.Location, x => x.MapFrom(dto =>
                geometryFactory.CreatePoint(new Coordinate(dto.Longitude, dto.Latitude))));
        }
    }
}
