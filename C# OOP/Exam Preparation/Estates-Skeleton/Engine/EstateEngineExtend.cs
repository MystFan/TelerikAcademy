using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;
using Estates.Data.Models;
namespace Estates.Engine
{
    class EstateEngineExtend : EstateEngine
    {
        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "find-rents-by-location":
                    return ExecuteFindRentsByLocationCommand(cmdArgs[0]);
                case "find-rents-by-price":
                    return ExecuteFindRentsByPriceCommand(int.Parse(cmdArgs[0]), int.Parse(cmdArgs[1]));
                default:
                    return base.ExecuteCommand(cmdName, cmdArgs);
            }
        }

        private string ExecuteFindRentsByLocationCommand(string location)
        {
            var offers = this.Offers
                .Where(o => o.Estate.Location == location && o.Type == OfferType.Rent)
                .OrderBy(o => o.Estate.Name);
            return FormatQueryResults(offers);
        }

        private string ExecuteFindRentsByPriceCommand(int min, int max)
        {
            var rentOffers = this.Offers
                .Where(o => o.Type == OfferType.Rent);
            if (rentOffers.Count() > 0)
            {
                List<IOffer> listOffers = new List<IOffer>();
                foreach (var offer in rentOffers)
                {
                    if ((offer as IRentOffer).PricePerMonth > (decimal)min && (offer as IRentOffer).PricePerMonth <= (decimal)max)
                    {
                        listOffers.Add(offer);
                    }
                }

                listOffers = listOffers.OrderBy(o => (o as IRentOffer).PricePerMonth)
                    .ThenBy(o => o.Estate.Name).ToList();
                return FormatQueryResults(listOffers);
            }
            else
            {
                return "No Results";
            }
        }
    }
}
