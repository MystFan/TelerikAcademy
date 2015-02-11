/*Problem 4. Triangle surface

    Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
    Use System.Math.
*/
namespace _04.TriangleSurface
{
    using System;
    class TriangleSurface
    {
        static void Main()
        {
            TriangleSurfaceCalculator calculator = new TriangleSurfaceCalculator();
            Console.WriteLine("Calculate the surface of a triangle by given two sides and angle between");
            Console.WriteLine("Enter two sides");
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter angle between them");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("The surface of a triangle = {0}", calculator.ByTwoSidesAndAngleBetween(firstSide,secondSide,angle));
            Console.WriteLine();
            Console.WriteLine("Calculate the surface of a triangle by given,three sides");
            Console.WriteLine("Enter three sides");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());
            Console.WriteLine("The surface of a triangle = {0}", calculator.ByThreeSides(sideA,sideB,sideC));
            Console.WriteLine();
            Console.WriteLine("Calculate the surface of a triangle by given,side and an altitude to it");
            Console.Write("Enter side:");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude:");
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("The surface of a triangle = {0}", calculator.BySideAndAltitude(side,altitude));
        }
    }
}
