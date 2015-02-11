/*
 Problem 5. Workdays

    Write a method that calculates the number of workdays between today and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */
namespace _05.Workdays
{
    using System;
    class Workdays
    {
        static void Main()
        {
            Console.Write("Enter day:");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter month:");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter year:");
            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);
            Console.WriteLine("{0} workdays", CalculateWorkdays(date));
        }

        private static int CalculateWorkdays(DateTime givenDate)
        {
            DateTime[] holidays = new DateTime[]
            { 
                new DateTime(2014, 4, 21), 
                new DateTime(2014, 4, 18),
                new DateTime(2014,5,1),
                new DateTime(2014,5,2),
                new DateTime(2014,5,5),
                new DateTime(2014,5,6),
                new DateTime(2014,9,22),
                new DateTime(2014,12,24),
                new DateTime(2014,12,25),
                new DateTime(2014,12,31)
            };
            DateTime firstDay = DateTime.Now;
            DateTime lastDay = givenDate;
            if (firstDay > lastDay)
            {
                throw new ArgumentException("Incorrect last day " + lastDay);
            }

            TimeSpan span = lastDay - firstDay;
            int workDays = span.Days + 1;
            int fullWeekCount = workDays / 7;

            if (workDays > fullWeekCount * 7)
            {
                int firstDayOfWeek = (int)firstDay.DayOfWeek;
                int lastDayOfWeek = (int)lastDay.DayOfWeek;
                if (lastDayOfWeek < firstDayOfWeek)
                {
                    lastDayOfWeek += 7;
                }
                if (firstDayOfWeek <= 6)
                {
                    if (lastDayOfWeek >= 7)
                    {
                        workDays -= 2;
                    }
                    else if (lastDayOfWeek >= 6)
                    {
                        workDays -= 1;
                    }
                }
                else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)
                {
                    workDays -= 1;
                }
            }

            workDays -= fullWeekCount + fullWeekCount;

            foreach (DateTime holiday in holidays)
            {
                DateTime currentHolyday = holiday.Date;
                if (firstDay <= currentHolyday && currentHolyday <= lastDay)
                {
                    workDays--;
                }
            }
            return workDays;
        }

    }
}
