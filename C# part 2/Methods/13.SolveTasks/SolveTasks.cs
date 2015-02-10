/*
 Problem 13. Solve tasks

    Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0

 */
namespace _13.SolveTasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    class SolveTasks
    {
        static void Main()
        {
            PrintMenu();
            Console.WriteLine("Enter command № = ");
            string input = Console.ReadLine();
            
            if (isNumber(input))
            {
                int number = int.Parse(input);
                while (number < 1 || number > 3)
                {
                    Console.Clear();
                    PrintMenu();
                    Console.Write("Enter valid command № = ");
                    input = Console.ReadLine();
                    if (isNumber(input))
                    {
                        number = int.Parse(input);
                    }
                }

                if (number == 1)
                {
                    Console.Write("Enter number to reverse: ");
                    string numberInput = Console.ReadLine();
                    BigInteger numberToReverse = 0;
                    if (isNumber(numberInput))
                    {
                        numberToReverse = BigInteger.Parse(numberInput);
                        Console.WriteLine("Reversed number");
                        Console.WriteLine(ReverseDigits(numberToReverse));
                    }
                    else
                    {
                        Console.WriteLine("Input string was not in a correct format");
                    }
                }
                else if (number == 2)
                {
                    List<int> list = new List<int>();
                    Console.Write("Enter sequence length: ");
                    string seq = Console.ReadLine();
                    int length = 0;
                    if (isNumber(seq))
                    {
                        length = int.Parse(seq);
                    }
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write("Sequence[{0}] = ", i);
                        string integerStr = Console.ReadLine();
                        if (isNumber(integerStr))
                        {
                            list.Add(int.Parse(integerStr));
                        }
                    }
                    int average = CalculatesAverage(list.ToArray());
                    Console.WriteLine("Average = {0}", average);
                }
                else if (number == 3)
                {
                    LinearEquation();
                }
            }
        }
        private static bool isNumber(string num)
        {
            BigInteger number;
            return BigInteger.TryParse(num, out number);
        }
        private static void LinearEquation()
        {
            Console.Write("Enter value for coefficients \"a\":");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (a != 0)
            {
                Console.Write("Enter value for coefficients \"b\":");
                double b = double.Parse(Console.ReadLine());
                double x = -b / a;
                Console.WriteLine("X= {0}", x);
            }
            else
            {
                Console.WriteLine("Enter value different from 0");
                LinearEquation();
            }
        }
        private static int CalculatesAverage(int[] seq)
        {
            if (seq.Length == 0)
            {
                throw new ArgumentException("The sequence should not be empty");
            }
            int sum = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                sum += seq[i];
            }
            int result = sum / (seq.Length - 1);
            return result;
        }
        private static string ReverseDigits(BigInteger num)
        {
            string result = String.Empty;
            string number = num.ToString();
            StringBuilder sb = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }
            result = sb.ToString();
            return result;
        }
        private static void PrintMenu()
        {
            string[] commands = new string[]
            {
                "1.Reverses the digits of a number",
                "2.Calculates the average of a sequence of integers",
                "3.Solves a linear equation a * x + b = 0"
            };
            int maxLenth = commands.Max(str => str.Length);
            string menu = "Menu".PadLeft(maxLenth / 2, ' ');
            Console.WriteLine(menu);
            Console.WriteLine(new string('=',maxLenth));
            for (int i = 0; i < commands.Length; i++)
            {
                Console.WriteLine(commands[i]);
            }
        }
    }
}
