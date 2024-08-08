using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Data.Mapping
{
    public class UfMap : IEntityTypeConfiguration<UfEntity>
    {
        public void Configure(EntityTypeBuilder<UfEntity> builder)
        {
            builder.ToTable("Uf");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Acronym)
                   .IsUnique();
        }
    }
}
