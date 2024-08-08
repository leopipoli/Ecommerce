using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Type);

            builder.Property(x => x.Value)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.TradeFor)
                   .HasMaxLength(50);

            builder.Property(x => x.Lat);

            builder.Property(x => x.Lng);

            builder.Property(x => x.Address)
                   .IsRequired()
                   .HasMaxLength(26);

            builder.Property(x => x.LimitDate)
                   .IsRequired();

            builder.Property(x => x.UrgencyType)
                   .IsRequired();

            builder.HasOne(x => x.City)
                   .WithMany(y => y.Products);

            builder.HasMany(x => x.Photos)
                    .WithMany(y => y.Products);
        }
    }
}
