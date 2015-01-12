using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 4. Number Comparer

//    -Write a program that gets two numbers from the console and prints the greater of them.
//    -Try to implement this without if statements.

namespace _04.NumberComparer
{
    class Program
    {
        static void Main()
        {
            Console.Write("First number: ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Second number: ");
            string inputSecondNumber = Console.ReadLine();

            double firstNumber;
            double secondNumber;
            bool isFirstNumber = double.TryParse(inputFirstNumber, out firstNumber);
            bool isSecondNumber = double.TryParse(inputSecondNumber, out secondNumber);

            if (isFirstNumber && isSecondNumber)
            {
                Console.WriteLine("Greater: {0}",firstNumber > secondNumber ?  firstNumber : secondNumber);
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
