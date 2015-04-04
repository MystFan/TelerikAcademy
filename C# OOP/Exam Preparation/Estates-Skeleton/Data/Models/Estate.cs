
namespace Estates.Data.Models
{
    using System;
    using Estates.Interfaces;
    using System.Text;
    public abstract class Estate : IEstate
    {
        private const int MaxArea = 10000;
        private string name;
        private double area;
        private string location;

        public Estate()
        {

        }
        public Estate(string initName, EstateType initType, double initArea, string initLocation, bool initIsFurnished)
        {
            this.Name = initName;
            this.Type = initType;
            this.Area = initArea;
            this.Location = initLocation;
            this.IsFurnished = initIsFurnished;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Estate name cannot be null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Estate name cannot be empty string");
                }
                this.name = value;
            }
        }

        public EstateType Type { get; set; }

        public double Area
        {
            get
            {
                return this.area;
            }
            set
            {
                if (value < 0 || value > Estate.MaxArea)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Estate area must be between 0 and {0}", Estate.MaxArea));
                }
                this.area = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Estate location cannot be null");
                }
                if (value == String.Empty)
                {
                    throw new ArgumentException("Estate location cannot be empty string");
                }
                this.location = value;
            }
        }

        public bool IsFurnished { get; set; }

        public override string ToString()
        {
            StringBuilder estateInfo = new StringBuilder();
            string type = this.GetType().Name;
            string name = this.Name;
            double area = this.Area;
            string location = this.Location;
            string furnished = this.IsFurnished ? "Yes" : "No";
            estateInfo.AppendFormat("{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}, ", type, name, area, location, furnished);
            return estateInfo.ToString();
        }
    }
}
