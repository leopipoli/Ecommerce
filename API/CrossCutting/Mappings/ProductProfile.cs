using AutoMapper;
using Domain.Dtos.Product;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            //CreateMap<ProductModel, ProductDto>()
            //    .ReverseMap();

            CreateMap<ProductDto, ProductEntity>()
                .ReverseMap();

            //CreateMap<ProductEntity, ProductModel>()
            //    .ReverseMap();
        }
    }
}
