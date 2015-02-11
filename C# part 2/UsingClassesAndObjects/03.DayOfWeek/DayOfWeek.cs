/*Problem 3. Day of week

    Write a program that prints to the console which day of the week is today.
    Use System.DateTime.
*/
namespace _03.DayOfWeek
{
    using System;
    class DayOfWeek
    {
        static void Main()
        {
            DateTime day = DateTime.Now;
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
