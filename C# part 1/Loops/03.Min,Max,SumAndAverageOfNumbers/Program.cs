using System;
/*
 Problem 3. Min, Max, Sum and Average of N Numbers

    -Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    -The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    -The output is like in the examples below.
 */

namespace _03.Min_Max_SumAndAverageOfNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter n = ");
            string inputN = Console.ReadLine();

            int n;
            bool isValidN = int.TryParse(inputN, out n);
            if (isValidN)
            {
                int minNumber = int.MaxValue;
                int maxNumber = int.MinValue;
                int sum = 0;
                double average = 0;
                for (int i = 0; i < n; i++)
                {
                    string inputNumber = Console.ReadLine();
                    int number;
                    bool isValidNumber = int.TryParse(inputNumber, out number);
                    if (isValidNumber)
                    {
                        if (number > maxNumber)
                        {
                            maxNumber = number;
                        }
                        if (number < minNumber)
                        {
                            minNumber = number;
                        }
                        sum += number;
                    }
                }
                average = (double) sum / n;
                Console.WriteLine("min = {0}", minNumber);
                Console.WriteLine("max = {0}", maxNumber);
                Console.WriteLine("sum = {0}", sum);
                Console.WriteLine("average = {0:0.00}", average);
            }
            else
            {
                Console.WriteLine("Input string was not in correct format");
            }
        }
    }
}
