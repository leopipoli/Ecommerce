using Domain.Dtos.City;
using Domain.Dtos.Photo;

namespace Domain.Dtos.Product
{
    public class ProductCreateDto
    {
        public int Type { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public string TradeFor { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Address { get; set; }
        public CityDto City { get; set; }
        public int UrgencyType { get; set; }
        public DateTime LimitDate { get; set; }
        public IEnumerable<PhotoDto> Photos { get; set; }
    }
}
