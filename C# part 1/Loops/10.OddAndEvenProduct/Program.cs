using System;
/*
Problem 10. Odd and Even Product

    You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

 */

namespace _10.OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integer numbers separated by a space.");
            string line = Console.ReadLine();

            string[] numbers = line.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number;
                bool isNumber = int.TryParse(numbers[i], out number);
                if (isNumber)
                {
                    if (i % 2 == 0)
                    {
                        evenProduct *= number;
                    }
                    else if (i % 2 != 0)
                    {
                        oddProduct *= number;
                    }
                }
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
