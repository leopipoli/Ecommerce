using AutoMapper;
using Domain.Dtos.City;
using Domain.Dtos.Product;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            //CreateMap<ProductModel, ProductDto>()
            //    .ReverseMap();

            CreateMap<CityDto, CityEntity>()
                .ReverseMap();

            //CreateMap<ProductEntity, ProductModel>()
            //    .ReverseMap();
        }
    }
}
