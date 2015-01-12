using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday in format day-month-year --> 02/12/1990");
            try
            {
                string date = Console.ReadLine();
                DateTime birthday = DateTime.Parse(date);
                Console.WriteLine("Date after 10 years: {0}", birthday.AddYears(10));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
