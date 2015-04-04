
namespace Estates.Data.Models
{
    using System;
    using Estates.Interfaces;
    public class SaleOffer : Offer, ISaleOffer
    {
        private decimal price;
        public SaleOffer()
            : base(OfferType.Sale)
        {

        }

        public SaleOffer(OfferType initType, IEstate initEstate, decimal price)
            : base(initType, initEstate)
        {
            this.Price = price;
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Sale offer price cannot be negativ value");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            string price = string.Format("Price = {0}", this.Price);
            return base.ToString() + price;
        }
    }
}
