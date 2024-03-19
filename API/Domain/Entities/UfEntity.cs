using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class UfEntity : BaseEntity
    {
        [Required]
        [MaxLength(2)]
        public string Acronym { get; set; }

        [Required]
        [MaxLength(45)]
        public string Name { get; set; }

        public IEnumerable<CityEntity> Cities { get; set; }
    }
}
