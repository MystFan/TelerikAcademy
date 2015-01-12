using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 7. Point in a Circle

//    -Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

namespace _07.PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputX = Console.ReadLine();
            string inputY = Console.ReadLine();
            double x;
            double y;
            bool xIsNumber = double.TryParse(inputX, out x);
            bool yIsNumber = double.TryParse(inputY, out y);

            if (xIsNumber && yIsNumber)
            {
                double radius = 2;
                double xPow = Math.Pow(x, 2);
                double yPow = Math.Pow(y, 2);
                double rPow = Math.Pow(radius, 2);
                if (xPow + yPow < rPow)
                {
                    Console.WriteLine("Point in circle --> {0}",xPow + yPow < rPow);
                }
                else
                {
                    Console.WriteLine("Point in circle --> {0}", xPow + yPow < rPow);
                }
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
