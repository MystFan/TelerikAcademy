using System;
using System.Globalization;
using System.Threading;

//Problem 10. Point Inside a Circle & Outside of a Rectangle

//    -Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

namespace _10.PointInCircle_OutsideFromRectangle
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                                 CultureInfo.InvariantCulture;

            Console.Write("Enter x: ");
            string inputX = Console.ReadLine();
            Console.Write("Enter y: ");
            string inputY = Console.ReadLine();

            double x;
            double y;

            bool xIsNumber = double.TryParse(inputX, out x);
            bool yIsNumber = double.TryParse(inputY, out y);

            if (xIsNumber && yIsNumber)
            {
                Console.Write("Point Inside a Circle & Outside of a Rectangle --> ");
                double radius = 1.5;
                double radiusPow = Math.Pow(radius + 1, 2);
                double xPow = Math.Pow(x , 2) -1;
                double yPow = Math.Pow(y, 2)-1 ;
                bool inCircle = xPow + yPow < radiusPow;
                bool isOutsideRect = (x < -1 || x > 6) || (y < -1 || y > 1);
                if (inCircle && isOutsideRect)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
