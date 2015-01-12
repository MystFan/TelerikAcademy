using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 6. Quadratic Equation

//    -Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

namespace _06.QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Console.Write("a: ");
            string inputA = Console.ReadLine();
            Console.Write("b: ");
            string inputB = Console.ReadLine();
            Console.Write("c: ");
            string inputC = Console.ReadLine();

            double a;
            double b;
            double c;
            bool isANumber = double.TryParse(inputA, out a);
            bool isBNumber = double.TryParse(inputB, out b);
            bool isCNumber = double.TryParse(inputC, out c);

            if (isANumber && isBNumber && isCNumber)
            {
                double discriminant = Math.Pow(b, 2) - 4 * a * c;
                if (a != 0)
                {
                    if (discriminant == 0)
                    {
                        double x = - b / (2 * a);
                        Console.WriteLine("Quadratic equation has one real root:");
                        Console.WriteLine("x = {0}", x);
                    }
                    else if (discriminant > 0)
                    {
                        double x1 = (-(b) - Math.Sqrt(discriminant)) / (2 * a);
                        double x2 = (-(b) + Math.Sqrt(discriminant)) / (2 * a);
                        Console.WriteLine("Quadratic equation has two real root:");
                        Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
                    }
                    else if (discriminant < 0)
                    {
                        Console.WriteLine("Quadratic equation has no real roots.");
                    }
                }
                else
                {
                    Console.WriteLine("Quadratic equation has no solution.");
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
