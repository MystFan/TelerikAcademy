namespace CohesionAndCoupling
{
    using System;

    public class Dimension3D : Dimension, IDimension3D
    {
        private double depth;

        public Dimension3D(double width, double height, double depth)
            : base(width, height)
        {
            this.Depth = depth;
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Dimension3D depth must be positive");
                }

                this.depth = value;
            }
        }

        public double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public double CalcVolume()
        {
            double volume = base.Width * base.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, base.Width, base.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = Math.Sqrt((0 - 0) * (0 - 0) + (this.Depth - base.Width) * (this.Depth - base.Width));
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = Math.Sqrt((0 - 0) * (0 - 0) + (this.Depth - base.Width) * (this.Depth - base.Width));
            return distance;
        }
    }
}
