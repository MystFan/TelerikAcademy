
namespace Estates.Data.Models
{
    using System;
    using Estates.Interfaces;
    public class House : Estate, IHouse
    {
        private const int MaximumNumberFloors = 10;
        private int floors;

        public House()
            : base()
        {

        }
        public House(string initName, EstateType initType, double initArea, string initLocation, bool initIsFurnished, int numberOfFloors)
            : base(initName, initType, initArea, initLocation, initIsFurnished)
        {
            this.Floors = numberOfFloors;
        }
        public int Floors
        {
            get
            {
                return this.floors;
            }
            set
            {
                if (value < 0 || value > House.MaximumNumberFloors)
                {
                    throw new ArgumentOutOfRangeException(string.Format("House number of floors must be between 0 and {0}", House.MaximumNumberFloors));
                }
                this.floors = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Floors: {0}", this.Floors);
        }
    }
}
