
namespace Estates.Data.Models
{
    using System;
    using Estates.Interfaces;
    public class RentOffer : Offer, IRentOffer
    {
        private decimal pricePerMonth = 0;
        public RentOffer()
            : base(OfferType.Rent)
        {

        }

        public RentOffer(OfferType initType, IEstate initEstate, decimal pricePerMonth)
            : base(initType, initEstate)
        {
            this.PricePerMonth = pricePerMonth;
        }
        public decimal PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Rent offer price per month cannot be negativ value");
                }
                this.pricePerMonth = value;
            }
        }

        public override string ToString()
        {
            string price = string.Format("Price = {0}", this.PricePerMonth);
            return base.ToString() + price;
        }
    }
}
