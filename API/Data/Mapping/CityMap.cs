using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Data.Mapping
{
    public class CityMap : IEntityTypeConfiguration<CityEntity>
    {
        public void Configure(EntityTypeBuilder<CityEntity> builder)
        {
            builder.ToTable("City");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Name);

            builder.HasOne(x => x.Uf)
                   .WithMany(y => y.Cities);
        }
    }
}
