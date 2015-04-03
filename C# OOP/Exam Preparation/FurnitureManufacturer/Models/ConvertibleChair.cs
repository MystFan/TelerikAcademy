
namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.IsConverted = false;
        }
        public bool IsConverted { get; private set; }
       
        public void Convert()
        {
            if (IsConverted)
            {
                IsConverted = false;
                this.Height = 0.10m;
            }
            else
            {
                IsConverted = true;
            }
        }

        public override string ToString()
        {
            string convertibleChairToString = string.Format("{0}, State: {1}", base.ToString(), this.IsConverted ? "Converted" : "Normal");
            return convertibleChairToString;
        }
    }
}
