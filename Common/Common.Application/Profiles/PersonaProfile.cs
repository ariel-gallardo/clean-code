using AutoMapper;
using Common.Domain.DTOS.Entities;
using Common.Domain.Entities;

namespace Base.Application.Profiles
{
    public class PersonaProfile : Profile
    {
        public PersonaProfile()
        {
            CreateMap<Persona,PersonaDTO>().ReverseMap();
        }
    }
}
