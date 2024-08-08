using Data.Context;
using Data.Repository;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Data.Implementations
{
    public class ProductImplementation : BaseRepository<ProductEntity>, IProductRepository
    {
        private DbSet<ProductEntity> _dataset;

        public ProductImplementation(EcommContext context) : base(context)
        {
            _dataset = _context.Set<ProductEntity>();
        }

        public async Task<IEnumerable<ProductEntity>> SelectCompleteAsync()
        {
            return await _dataset.Include(x => x.City).ThenInclude(x => x.Uf).ToListAsync();
        }
    }
}
