using System;

//Problem 11.* Numbers in Interval Dividable by Given Number

//    -Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

namespace _11.NumberslDividableByGivenNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("First number = ");
            string inputFirstNumber = Console.ReadLine();
            Console.Write("Second number = ");
            string inputSecondNumber = Console.ReadLine();

            int firstNumber;
            int secondNumber;
            bool isValidFirstNumber = int.TryParse(inputFirstNumber, out firstNumber);
            bool isValidSecondNumber = int.TryParse(inputSecondNumber, out secondNumber);

            if (isValidFirstNumber && isValidSecondNumber)
            {
                int counter = 0;
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    if (i % 5 == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("{0} numbers.", counter);
            }
            else
            {
                Console.WriteLine("Some input string was not in a correct format");
            }
        }
    }
}
