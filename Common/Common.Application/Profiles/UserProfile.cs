using AutoMapper;
using Common.Domain.DTOS.Entities.User;
using Common.Domain.Entities;

namespace Base.Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
