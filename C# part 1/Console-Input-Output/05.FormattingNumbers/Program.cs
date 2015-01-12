using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 5. Formatting Numbers

//    -Write a program that reads 3 numbers:
//        integer a (0 <= a <= 500)
//        floating-point b
//        floating-point c
//    -The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//        The number a should be printed in hexadecimal, left aligned
//        Then the number a should be printed in binary form, padded with zeroes
//        The number b should be printed with 2 digits after the decimal point, right aligned
//        The number c should be printed with 3 digits after the decimal point, left aligned.

namespace _05.FormattingNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("First number: ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Second number: ");
            string inputSecondNumber = Console.ReadLine();
            Console.Write("Third number: ");
            string inputThirdNumber = Console.ReadLine();

            int firstNumber;
            float secondNumber;
            float thirdNumber;
            bool isFirstNumber = int.TryParse(inputFirstNumber, out firstNumber);
            bool isSecondNumber = float.TryParse(inputSecondNumber, out secondNumber);
            bool isThirdNumber = float.TryParse(inputThirdNumber, out thirdNumber);

            if (isFirstNumber && isSecondNumber && isThirdNumber)
            {
                if (firstNumber >= 0 && firstNumber <= 500)
                {
                    int colWidth = 10;
                    string firstNumberHex = String.Format("{0:X}",firstNumber);
                    string firstNumberBinary = Convert.ToString(firstNumber, 2).PadLeft(10,'0');
                    string secondNumberTwoDigits = String.Format("{0:0.00}", secondNumber);
                    string thirdNumberThreeDigits = String.Format("{0:0.000}", thirdNumber);
                    Console.WriteLine("{0,-" + colWidth + "}|{1}|" + 
                                      "{2," + colWidth + "}|" + 
                                      "{3,-" + colWidth +"}|", 
                                      firstNumberHex, firstNumberBinary, secondNumberTwoDigits, thirdNumberThreeDigits);
                }
                else
                {
                    Console.WriteLine("The first number is outside the permitted values");
                }
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
