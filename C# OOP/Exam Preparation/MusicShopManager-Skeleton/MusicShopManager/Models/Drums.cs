
namespace MusicShop.Models
{
    using System;
    using MusicShopManager.Interfaces;
    using System.Text;
    public class Drums : Instrument, IDrums
    {
        private int width;
        private int height;
        public Drums(string make, string model, decimal price, string color, int width, int height)
            : base(make, model, price, color)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width
        {
            get 
            {
                return this.width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Drums width should have positiv value");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get 
            {
                return this.height;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Drums height should have positiv value");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("= {0} {1} =", this.Make, this.Model));
            sb.AppendLine(string.Format("Price: ${0:F2}", this.Price));
            sb.AppendLine(string.Format("Color: {0}", this.Color));
            sb.AppendLine(string.Format("Electronic: {0}", this.IsElectronic ? "yes" : "no"));
            sb.AppendLine(string.Format("Size: {0}cm x {1}cm", this.Width, this.Height));
            return sb.ToString();
        }
    }
}
