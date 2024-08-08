using Domain.Dtos.Product;

namespace Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAll();
        Task<ProductDto> GetByLocation(LocationDto location);
        Task<ProductCreateResultDto> Post(ProductCreateDto user);
        Task<ProductUpdateResultDto> Put(ProductUpdateDto user);
    }
}
