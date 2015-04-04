namespace MusicShop.Models
{
    using MusicShopManager.Interfaces;
    using System;
    public abstract class Instrument : Article, IInstrument
    {
        private string color;
        public Instrument(string make, string model, decimal price, string color)
            :base(make, model, price)
        {
            this.Color = color;
        }

        public string Color
        {
            get 
            {
                return this.color;
            }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Instrument color string is null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Instrument color string is empty string");
                }
                this.color = value;
            }
        }

        public bool IsElectronic { get; protected set; }

    }
}
