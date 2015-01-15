using System;
using System.Globalization;
using System.Threading;

//Problem 3. Circle Perimeter and Area

//    -Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

namespace _03.CirclePerimeterAndArea
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                                 CultureInfo.InvariantCulture;

            Console.Write("Radius: ");
            string inputRadius = Console.ReadLine();

            double radius;
            bool isNumber = double.TryParse(inputRadius, out radius);
            if (isNumber)
            {
                double area = Math.PI * radius * radius;
                double perimeter = 2 * Math.PI * radius;
                Console.WriteLine("Area: {0:0.00}",area);
                Console.WriteLine("Perimeter: {0:0.00}", perimeter);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
