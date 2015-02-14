/*
 Problem 16. Date difference

    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days

 */
namespace _16.DateDifference
{
    using System;
    class DateDifference
    {
        static void Main()
        {
            Console.WriteLine("Enter two dates in the format: day.month.year");
            Console.Write("Enter the first date: ");
            string firstDate = Console.ReadLine();
            DateTime fDate = DateTime.Parse(firstDate);
            Console.Write("Enter the second date:");
            string secondDate = Console.ReadLine();
            DateTime sDate = DateTime.Parse(secondDate);
            Console.WriteLine("Days between: {0}", DaysBetweenDates(fDate,sDate));
        }

        private static int DaysBetweenDates(DateTime one, DateTime two)
        {
            TimeSpan result = one - two;
            int days = result.Days;
            if (days < 0)
            {
                days *= (-1);
            }
            return days;
        }
    }
}
