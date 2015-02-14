/*
 Problem 17. Date in Bulgarian

    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */
namespace _17.DateInBulgarian
{
    using System;
using System.Globalization;
    static class DateInBulgarian
    {
        static void Main()
        {
            string date = "30.11.2009 11:30:32";
            Console.WriteLine(AddHoursAndMinutes(date, 6,30));
        }

        public static string AddHoursAndMinutes(string formatDate,int hour = 0,int minutes = 0,int seconds = 0)
        {
            string[] dateParts = formatDate.Split(' ');
            string[] secondHalf = dateParts[1].Split(':');
            string[] firstHalf = dateParts[0].Split('.');
            int day = int.Parse(firstHalf[0]);
            int month = int.Parse(firstHalf[1]);
            int year = int.Parse(firstHalf[2]);
            int h = int.Parse(secondHalf[0]) ;
            int m = int.Parse(secondHalf[1]) ;
            int s = int.Parse(secondHalf[2]) ;
            DateTime dt = new DateTime(year, month, day, h, m, s);
            dt = dt.AddHours(hour);
            dt = dt.AddMinutes(minutes);
            dt = dt.AddSeconds(seconds);
            CultureInfo ci = CultureInfo.CreateSpecificCulture("bg-BG");
            return dt.ToString("dd.MM.yyyy HH:mm:ss",ci);
        }
    }
}
