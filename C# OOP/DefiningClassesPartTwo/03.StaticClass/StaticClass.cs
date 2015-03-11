/*Problem 3. Static class

    Write a static class with a static method to calculate the distance between two points in the 3D space.
*/
namespace _03.StaticClass
{
    using _02.StaticReadOnlyField;
    using System;
    class StaticClass
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(10, 13, 15);
            Point3D secondPoint = new Point3D(12, 24, 34);
            double distance = CalculateDistance.CalculateDistanceBetweenPoints(firstPoint, secondPoint);
            Console.WriteLine(distance);
        }
    }

    static class CalculateDistance
    {
        public static double CalculateDistanceBetweenPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double result = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2) + Math.Pow(firstPoint.Z - secondPoint.Z, 2));
            return result;
        }
    }
}
