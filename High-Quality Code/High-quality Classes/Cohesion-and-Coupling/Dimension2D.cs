namespace CohesionAndCoupling
{
    using System;

    public class Dimension2D : Dimension , IDimension2D
    {

        public Dimension2D(double width, double height)
            : base(width, height)
        {

        }

        public double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, base.Width, base.Height);
            return distance;
        }
    }
}
