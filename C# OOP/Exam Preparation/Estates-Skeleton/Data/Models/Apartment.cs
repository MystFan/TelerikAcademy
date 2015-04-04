
namespace Estates.Data.Models
{
    using System;
    using Estates.Interfaces;
    using System.Text;
    public class Apartment : BuildingEstate, IApartment
    {
        public Apartment()
            : base()
        {

        }
        public Apartment(string initName, EstateType initType, double initArea, string initLocation, bool initIsFurnished, int numberOfRooms, bool hasElevator)
            : base(initName, initType, initArea, initLocation, initIsFurnished, numberOfRooms, hasElevator)
        {

        }

    }
}
