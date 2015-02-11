/*
 Problem 1. Leap year

    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
 */
namespace _01.LeapYear
{
    using System;
    class LeapYear
    {
        static void Main()
        {
            string input = Console.ReadLine();
            ushort year;
            bool isNumber = ushort.TryParse(input, out year);
            bool isValidYear = year >= 0 && year <= DateTime.Now.Year;
            if (isNumber && isValidYear)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("Year {0} is a Leap-year", year);
                }
                else
                {
                    Console.WriteLine("Year {0} is not a Leap-year", year);
                }
            }
            // or DateTime.IsLeapYear(year);
        }
    }
}
