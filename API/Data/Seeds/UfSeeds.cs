using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Seeds
{
    public static class UfSeeds
    {
        public static void Ufs(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UfEntity>().HasData(
                    new UfEntity { Id = 1, Acronym = "AC", Name = "Acre" },
                    new UfEntity { Id = 2, Acronym = "AL", Name = "Alagoas" },
                    new UfEntity { Id = 3, Acronym = "AP", Name = "Amapá" },
                    new UfEntity { Id = 4, Acronym = "AM", Name = "Amazonas" },
                    new UfEntity { Id = 5, Acronym = "BA", Name = "Bahia" },
                    new UfEntity { Id = 6, Acronym = "CE", Name = "Ceará" },
                    new UfEntity { Id = 7, Acronym = "DF", Name = "Distrito Federal" },
                    new UfEntity { Id = 8, Acronym = "ES", Name = "Espírito Santo" },
                    new UfEntity { Id = 9, Acronym = "GO", Name = "Goiás" },
                    new UfEntity { Id = 10, Acronym = "MA", Name = "Maranhão" },
                    new UfEntity { Id = 11, Acronym = "MT", Name = "Mato Grosso" },
                    new UfEntity { Id = 12, Acronym = "MS", Name = "Mato Grosso do Sul" },
                    new UfEntity { Id = 13, Acronym = "MG", Name = "Minas Gerais" },
                    new UfEntity { Id = 14, Acronym = "PA", Name = "Pará" },
                    new UfEntity { Id = 15, Acronym = "PB", Name = "Paraíba" },
                    new UfEntity { Id = 16, Acronym = "PR", Name = "Paraná" },
                    new UfEntity { Id = 17, Acronym = "PE", Name = "Pernambuco" },
                    new UfEntity { Id = 18, Acronym = "PI", Name = "Piauí" },
                    new UfEntity { Id = 19, Acronym = "RJ", Name = "Rio de Janeiro" },
                    new UfEntity { Id = 20, Acronym = "RN", Name = "Rio Grande do Norte" },
                    new UfEntity { Id = 21, Acronym = "RS", Name = "Rio Grande do Sul" },
                    new UfEntity { Id = 22, Acronym = "RO", Name = "Rondônia" },
                    new UfEntity { Id = 23, Acronym = "RR", Name = "Roraima" },
                    new UfEntity { Id = 24, Acronym = "SC", Name = "Santa Catarina" },
                    new UfEntity { Id = 25, Acronym = "SP", Name = "São Paulo" },
                    new UfEntity { Id = 26, Acronym = "SE", Name = "Sergipe" },
                    new UfEntity { Id = 27, Acronym = "TO", Name = "Tocantins" }
            );
        }
    }
}
