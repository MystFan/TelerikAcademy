
namespace MusicShop.Models
{
    using System;
    using MusicShopManager.Interfaces;
    using System.Text;
    public class ElectricGuitar : Guitar, IElectricGuitar
    {
        private int numberOfAdapters;
        private int numberOfFrets;
        public ElectricGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood,int numberOfAdapters, int numberOfFrets)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.NumberOfAdapters = numberOfAdapters;
            this.NumberOfFrets = numberOfFrets;
            this.IsElectronic = true;
        }
        public int NumberOfAdapters 
        {
            get
            {
                return this.numberOfAdapters;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Electric guitar number of adapters must be non-negative");
                }
                this.numberOfAdapters = value;
            }
        }
        public int NumberOfFrets
        {
            get 
            {
                return this.numberOfFrets; 
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Electric guitar number of frets must be positive");
                }
                this.numberOfFrets = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine(string.Format("Adapters: {0}", this.NumberOfAdapters));
            sb.AppendLine(string.Format("Frets: {0}", this.NumberOfFrets));
            return sb.ToString();
        }
    }
}
