namespace Domain.Models
{
    public class ProductModel : BaseModel
    {
        private int _type;
        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private double _value;
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _tradeFor;
        public string TradeFor
        {
            get { return _tradeFor; }
            set { _tradeFor = value; }
        }

        private double _lat;
        public double Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }

        private double _lng;
        public double Lng
        {
            get { return _lng; }
            set { _lng = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private int _cityId;
        public int CityId
        {
            get { return _cityId; }
            set { _cityId = value; }
        }

        private string _urgencyType;
        public string UrgencyType
        {
            get { return _urgencyType; }
            set { _urgencyType = value; }
        }
        private DateTime _limitDate;
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
    }
    //public IEnumerable<PhotosEntity> Photos { get; set; }
}
