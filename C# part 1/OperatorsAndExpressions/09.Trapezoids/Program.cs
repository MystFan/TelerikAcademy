using System;
using System.Globalization;
using System.Threading;

//Problem 9. Trapezoids

//    -Write an expression that calculates trapezoid's area by given sides a and b and height h.

namespace _09.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                                 CultureInfo.InvariantCulture;

            Console.Write("Enter side a: ");
            string inputA = Console.ReadLine();
            Console.Write("Enter side b: ");
            string inputB = Console.ReadLine();
            Console.Write("Enter height h: ");
            string inputH = Console.ReadLine();

            double sideA;
            double sideB;
            double height;
            bool sideAisNumber = double.TryParse(inputA,out sideA);
            bool sideBisNumber = double.TryParse(inputB, out sideB);
            bool heightIsNumber = double.TryParse(inputH, out height);

            if (sideAisNumber && sideBisNumber && heightIsNumber)
            {
                double trapezoidArea = ((sideA + sideB) / 2) * height;
                Console.WriteLine("Trapezoid area = {0}",trapezoidArea);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
