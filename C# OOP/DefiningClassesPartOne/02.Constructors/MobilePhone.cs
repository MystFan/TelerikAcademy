
namespace _02.Constructors
{

    class MobilePhone
    {
        public MobilePhone(string model, string manufacturer, decimal price = 0,string owner = "")
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal? Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }

    }
}
