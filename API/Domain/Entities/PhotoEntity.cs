namespace Domain.Entities
{
    public class PhotoEntity : BaseEntity
    {
        public string Src { get; set; }
        public IEnumerable<ProductEntity> Products { get; set; }
    }
}
