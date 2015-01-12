using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 3. Divide by 7 and 5

//    -Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

namespace _03.DivideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double number;
            bool isNumber = double.TryParse(input, out number);
            if (isNumber)
            {
                Console.Write("Number can be divided (without remainder) by 7 and 5 at the same time. --> ");

                if (number % 5 == 0 && number % 7 == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
