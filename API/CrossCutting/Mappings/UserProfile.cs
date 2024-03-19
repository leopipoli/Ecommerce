using AutoMapper;
using Domain.Dtos.User;
using Domain.Entities;
using Domain.Models;

namespace CrossCutting.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel, UserDto>()
                .ReverseMap();

            CreateMap<UserDto, UserEntity>()
                .ReverseMap();

            CreateMap<UserEntity, UserModel>()
                .ReverseMap();
        }
    }
}
