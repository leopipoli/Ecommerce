using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class PhotoMap : IEntityTypeConfiguration<PhotoEntity>
    {
        public void Configure(EntityTypeBuilder<PhotoEntity> builder)
        {
            builder.ToTable("Photo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Src)
                   .IsRequired();
        }
    }
}
