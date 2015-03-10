
namespace _04.ToString
{
    using System.Text;
    class MobilePhone
    {
        public MobilePhone(string model, string manufacturer, decimal price = 0, string owner = "")
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

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Mobile phone info");
            info.AppendLine(" *Model: " + this.Model);
            info.AppendLine(" *Manufacturer: " + this.Manufacturer);
            info.AppendLine(" *Price: " + this.Price);
            if (this.Owner == "")
            {
                info.AppendLine(" *Owner: " + this.Owner);
            }
            else
            {
                info.AppendLine(" *Owner: None");
            }
            return info.ToString();
        }
    }
}
