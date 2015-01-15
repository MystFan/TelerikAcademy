using System;
using System.Globalization;
using System.Threading;

//Problem 4. Rectangles

//    -Write an expression that calculates rectangle’s perimeter and area by given width and height.

namespace _04.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                                 CultureInfo.InvariantCulture;

            Console.Write("Enter width: ");
            string inputWidth = Console.ReadLine();
            Console.Write("Enter height: ");
            string inputHeight = Console.ReadLine();

            double width;
            double height;
            bool isValidWidth = double.TryParse(inputWidth, out width);
            bool isValidHeight = double.TryParse(inputHeight, out height);

            if (isValidWidth && isValidHeight && width > 0 && height > 0)
            {
                double area = width * height;
                double perimeter = (2 * width) + (2 * height);
                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
