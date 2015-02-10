/*
 Problem 3. English digit

    Write a method that returns the last digit of given integer as an English word.
 */
namespace _03.EnglishDigit
{
    using System;

    class EnglishDigit
    {
        static void Main()
        {
            Console.Write("Number: ");
            string input = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(input, out number);
            if (isNumber)
            {
                string digit = LastDigitEnglish(number);
                Console.WriteLine(digit);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }

        private static string LastDigitEnglish(int num)
        {
            string result = String.Empty;
            int digit = num % 10;
            switch (digit)
            {
                case 0: result = "Zero"; break;
                case 1: result = "One"; break;
                case 2: result = "Two"; break;
                case 3: result = "Three"; break;
                case 4: result = "Four"; break;
                case 5: result = "Five"; break;
                case 6: result = "Six"; break;
                case 7: result = "Seven"; break;
                case 8: result = "Eight"; break;
                case 9: result = "Nine"; break;
            }
            return result;
        }
    }
}
