
using AutoMapper;
using Common.Domain.DTOS.Entities;
using Common.Domain.ValueObjects;

namespace Base.Application.Profiles
{
    public class CoordinatesProfile : Profile
    {
        public CoordinatesProfile()
        {
            CreateMap<Coordinates, CoordinatesDTO>().ReverseMap();
        }
    }
}
