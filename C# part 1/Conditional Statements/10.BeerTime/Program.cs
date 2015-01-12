using System;
/*
 Problem 10.* Beer Time

    -A beer time is after 1:00 PM and before 3:00 AM.
    -Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
     and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
     Note: You may need to learn how to parse dates and times.
 */
namespace _10.BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)");
            string input = Console.ReadLine();

            DateTime time;
            bool isValid = DateTime.TryParse(input, out time);
            if (isValid)
            {
                DateTime startBeerTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
                DateTime endBeerTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 3, 0, 0);
                if (time > startBeerTime || time.Hour < endBeerTime.Hour)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
