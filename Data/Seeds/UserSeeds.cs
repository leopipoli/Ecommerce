using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeds
{
    public static class UserSeeds
    {
        public static void Users(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity { Id = 1, Name = "Administrador", Email = "administrador.ecommerce@vibbra.com", Password = "12345" }           
            );
        }
    }
}
