
namespace Estates.Data.Models
{
    using System;
    using Estates.Interfaces;
    using System.Text;
    public abstract class Offer : IOffer
    {
        private IEstate estate;
        public Offer(OfferType initType)
        {
            this.Type = initType;
        }
        public Offer(OfferType initType, IEstate initEstate)
        {
            this.Type = initType;
            this.Estate = initEstate;
        }
        public OfferType Type { get; set; }
        
        public IEstate Estate
        {
            get
            {
                return this.estate;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Offer estate is null");
                }
                this.estate = value;
            }
        }

        public override string ToString()
        {
            StringBuilder offerInfo = new StringBuilder();
            string type = this.Type.ToString();
            string estateName = this.Estate.Name;
            string location = this.Estate.Location;
            offerInfo.AppendFormat("{0}: Estate = {1}, Location = {2}, ", type, estateName, location);
            return offerInfo.ToString();
        }
    }
}
