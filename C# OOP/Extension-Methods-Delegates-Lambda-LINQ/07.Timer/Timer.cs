using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Timer
{
    public class Timer
    {
        private DateTime date;

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                this.date = value;
            }
        }
        public static void PrintZeroSeconds(int digit)
        {
            Console.WriteLine("Zero seconds");
        }
        public static void PrintTwentySeconds(int digit)
        {
            Console.WriteLine("Twenty seconds");
        }
        public static void PrintFourtyoSeconds(int digit)
        {
            Console.WriteLine("Fourty seconds");
        }
    }
}
