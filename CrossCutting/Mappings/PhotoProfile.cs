using AutoMapper;
using Domain.Dtos.Photo;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class PhotoProfile : Profile
    {
        public PhotoProfile()
        {
            CreateMap<PhotoDto, PhotoEntity>()
                .ReverseMap();
        }
    }
}
