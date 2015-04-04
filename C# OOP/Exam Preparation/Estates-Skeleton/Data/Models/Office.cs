
namespace Estates.Data.Models
{
    using Estates.Interfaces;
    using System.Text;
    public class Office : BuildingEstate, IOffice
    {
        public Office()
            : base()
        {

        }
        public Office(string initName, EstateType initType, double initArea, string initLocation, bool initIsFurnished, int numberOfRooms, bool hasElevator)
            : base(initName, initType, initArea, initLocation, initIsFurnished, numberOfRooms, hasElevator)
        {

        }
    }
}
