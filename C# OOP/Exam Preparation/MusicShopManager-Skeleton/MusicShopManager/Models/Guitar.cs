
namespace MusicShop.Models
{
    using System;
    using MusicShopManager.Interfaces;
    using System.Text;
    public abstract class Guitar : Instrument, IGuitar
    {
        private const int GenerallyGuitarNumberOfStrings = 6;
        private const int GuitarMinimumNumberOfStrings = 4;
        private int numberOfStrings;
        private string bodyWood;
        private string fingerboardWood;
        public Guitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood, int numberOfStrings = Guitar.GenerallyGuitarNumberOfStrings)
            : base(make, model, price, color)
        {
            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerboardWood;
            this.NumberOfStrings = Guitar.GenerallyGuitarNumberOfStrings;
        }
        public string BodyWood
        {
            get 
            {
                return this.bodyWood;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Guitar body wood is null");
                }
                this.bodyWood = value;
            }
        }

        public string FingerboardWood
        {
            get 
            {
                return this.fingerboardWood;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Guitar body wood is null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Guitar fingerboard wood is empty string");
                }
                this.fingerboardWood = value;
            }
        }

        public int NumberOfStrings
        {
            get 
            {
                return this.numberOfStrings;
            }
            protected set
            {
                if (value < Guitar.GuitarMinimumNumberOfStrings)
                {
                    throw new ArgumentException("Guitar strings should be greater from 4");
                }
                this.numberOfStrings = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format( "= {0} {1} =", this.Make, this.Model));
            sb.AppendLine(string.Format("Price: ${0:F2}", decimal.Round(this.Price, 2)));
            sb.AppendLine(string.Format("Color: {0}", this.Color));
            sb.AppendLine(string.Format("Electronic: {0}", this.IsElectronic ? "yes" : "no"));
            sb.AppendLine(string.Format("Strings: {0}", this.NumberOfStrings));
            sb.AppendLine(string.Format("Body wood: {0}", this.BodyWood));
            sb.AppendLine(string.Format("Fingerboard wood: {0}", this.FingerboardWood));
            return sb.ToString();
        }
    }
}
