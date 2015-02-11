
namespace _04.TriangleSurface
{
    using System;
    public class TriangleSurfaceCalculator
    {
        public double ByTwoSidesAndAngleBetween(double sideOne,double sideTwo,double angle)
        {
            double radians = (Math.PI * angle) / 180.0;
            double surface = ((sideOne * sideTwo) / 2) * Math.Sin(angle);
            double result = Math.Abs(surface);
            return result;
        }

        public double ByThreeSides(double sideOne,double sideTwo,double sideThree)
        {
            double subPerimeter = (sideOne + sideTwo + sideThree) / 2;
            double surface = Math.Sqrt(subPerimeter * (subPerimeter - sideOne) * (subPerimeter - sideTwo) * (subPerimeter - sideThree));
            return surface;
        }

        public double BySideAndAltitude(double side, double alt)
        {
            double surface = (side * alt) / 2;
            return surface;
        }
    }
}
