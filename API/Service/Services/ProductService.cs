using AutoMapper;
using Domain.Dtos.Product;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Repository;

namespace Service.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        public readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ProductDto>(entity);
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var entity = await _repository.SelectCompleteAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(entity);
        }

        public async Task<ProductDto> GetByLocation(LocationDto location)
        {
            //var model = _mapper.Map<ProductModel>(product);
            //var entity = _mapper.Map<ProductEntity>(model);
            //var result = await _repository.UpdateAsync(entity);

            //return _mapper.Map<ProductUpdateResultDto>(result);
            return null;
        }

        public async Task<ProductCreateResultDto> Post(ProductCreateDto product)
        {
            var model = _mapper.Map<ProductModel>(product);
            var entity = _mapper.Map<ProductEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ProductCreateResultDto>(result);
        }

        public async Task<ProductUpdateResultDto> Put(ProductUpdateDto product)
        {
            var model = _mapper.Map<ProductModel>(product);
            var entity = _mapper.Map<ProductEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ProductUpdateResultDto>(result);
        }
    }
}
