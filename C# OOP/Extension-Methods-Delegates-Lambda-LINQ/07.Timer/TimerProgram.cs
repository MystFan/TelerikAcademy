/*Problem 7. Timer

    Using delegates write a class Timer that can execute certain method at each t seconds.
*/

using System;
using System.Threading;
namespace _07.Timer
{
    class TimerProgram
    {
        public delegate void Execute(int number);
        public static void PrintZero(int num)
        {
            Timer.PrintZeroSeconds(num);
        }

        public static void PrintTwenty(int num)
        {
            Timer.PrintTwentySeconds(num);
        }
        public static void PrintFourty(int num)
        {
            Timer.PrintFourtyoSeconds(num);
        }

        public static void Print(int number)
        {
            Console.Write(number + " ");
        }
        static void Main()
        {
            DateTime date;
            Execute ex;
            while (true)
            {
                date = DateTime.Now;

                if (date.Second == 0)
                {
                    ex = new Execute(PrintZero);
                }
                else if (date.Second == 20)
                {
                    ex = new Execute(PrintTwenty);
                }
                else if (date.Second == 40)
                {
                    ex = new Execute(PrintFourty);
                }
                else
                {
                    ex = new Execute(Print);
                }
                ex(date.Second);
                Thread.Sleep(1000);
            }
        }
    }
}
