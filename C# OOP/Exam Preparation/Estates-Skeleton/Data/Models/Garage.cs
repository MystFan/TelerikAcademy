
namespace Estates.Data.Models
{
    using System;
    using Estates.Interfaces;
    public class Garage : Estate, IGarage
    {
        private const int MaxWidth = 500;
        private const int MaxHeight = 500;
        private int width;
        private int height;
        public Garage()
            : base()
        {

        }
        public Garage(string initName, EstateType initType, double initArea, string initLocation, bool initIsFurnished, int width, int height)
            : base(initName, initType, initArea, initLocation, initIsFurnished)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0 || value > Garage.MaxWidth)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Garage width must be between 0 and {0}", Garage.MaxWidth));
                }
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0 || value > Garage.MaxHeight)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Garage height must be between 0 and {0}", Garage.MaxHeight));
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Width: {0}, Height: {1}", this.Width, this.Height);
        }
    }
}
