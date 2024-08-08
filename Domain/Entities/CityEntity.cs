using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class CityEntity : BaseEntity
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        public int UfId { get; set; }
        public UfEntity Uf { get; set; }
        public IEnumerable<ProductEntity> Products { get; set; }
    }
}
