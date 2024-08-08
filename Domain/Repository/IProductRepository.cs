using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Repository
{
    public interface IProductRepository : IRepository<ProductEntity>
    {
        Task<IEnumerable<ProductEntity>> SelectCompleteAsync();
    }
}
