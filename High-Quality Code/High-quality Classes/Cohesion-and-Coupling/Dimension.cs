namespace CohesionAndCoupling
{
    using System;

    public abstract class Dimension : IDimension
    {
        private double width;
        private double height;

        protected Dimension(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Dimension width must be positive");
                }

                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Dimension height must be positive");
                }

                this.height = value;
            }
        }
    }
}
