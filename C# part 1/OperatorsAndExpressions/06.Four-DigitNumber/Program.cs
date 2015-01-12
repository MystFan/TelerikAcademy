using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 6. Four-Digit Number

//    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//        -Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//        -Prints on the console the number in reversed order: dcba (in our example 1102).
//        -Puts the last digit in the first position: dabc (in our example 1201).
//        -Exchanges the second and the third digits: acbd (in our example 2101).
//
// The number has always exactly 4 digits and cannot start with 0.
namespace _06.Four_DigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber && input.Length == 4)
            {
                int currentNumber = number;
                int firstDigit = currentNumber / 1000;
                int secondDigit = (currentNumber / 100) % 10;
                int thirdDigit = (currentNumber / 10) % 10;
                int fourDigit = currentNumber % 10;
                int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourDigit;
                string reverseDigit = fourDigit.ToString() + thirdDigit + secondDigit + firstDigit;
                string firstExchange = fourDigit.ToString() + firstDigit + secondDigit + thirdDigit;
                string secondExchange = firstDigit.ToString() + thirdDigit + secondDigit + fourDigit;

                Console.WriteLine("sum of digits: {0}",sumOfDigits);
                Console.WriteLine("Reverse digit: {0}",reverseDigit);
                Console.WriteLine(firstExchange);
                Console.WriteLine(secondExchange);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
