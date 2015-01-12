using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 5. Third Digit is 7?

//    -Write an expression that checks for given integer if its third digit from right-to-left is 7.

namespace _05.ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                int digit = 0;
                if (input.Length <= 3)
                {
                    digit = number / 100;
                }
                else
                {
                    digit = number % 1000;
                    digit = digit / 100;
                }
                Console.WriteLine("Third digit is Seven --> {0}", digit == 7);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
