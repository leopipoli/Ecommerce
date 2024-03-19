using Data.Mapping;
using Data.Seeds;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class EcommContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public EcommContext(DbContextOptions<EcommContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<UfEntity>(new UfMap().Configure);
            modelBuilder.Entity<ProductEntity>(new ProductMap().Configure);
            modelBuilder.Entity<PhotoEntity>(new PhotoMap().Configure);
            modelBuilder.Entity<CityEntity>(new CityMap().Configure);

            UserSeeds.Users(modelBuilder);
            UfSeeds.Ufs(modelBuilder);
            CitySeeds.Cities(modelBuilder);
        }
    }
}
