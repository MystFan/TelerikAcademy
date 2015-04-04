
namespace Estates.Data.Models
{
    using System;
    using Estates.Interfaces;
    using System.Text;
    public abstract class BuildingEstate : Estate, IBuildingEstate
    {
        private const int MaxRoomsCount = 20;
        private int rooms;

        public BuildingEstate():base()
        {

        }
        public BuildingEstate(string initName, EstateType initType, double initArea, string initLocation, bool initIsFurnished, int numberOfRooms, bool hasElevator)
            : base(initName, initType, initArea, initLocation, initIsFurnished)
        {
            this.Rooms = numberOfRooms;
            this.HasElevator = hasElevator;
        }

        public int Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                if (value < 0 || value > BuildingEstate.MaxRoomsCount)
                {
                    throw new ArgumentOutOfRangeException(String.Format("Apartment number of rooms cannot be negativ value or greater by {0}", BuildingEstate.MaxRoomsCount));
                }
                this.rooms = value;
            }
        }

        public bool HasElevator { get; set; }

        public override string ToString()
        {
            StringBuilder buildingEstateInfo = new StringBuilder();
            buildingEstateInfo.Append(base.ToString());
            buildingEstateInfo.AppendFormat("Rooms: {0}, Elevator: {1}", this.Rooms, this.HasElevator ? "Yes" : "No");
            return buildingEstateInfo.ToString();
        }
    }
}
