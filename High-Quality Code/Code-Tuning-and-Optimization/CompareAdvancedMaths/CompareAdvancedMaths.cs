namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class CompareAdvancedMaths
    {
        private static int count = 1000000;

        static void Main()
        {
            Console.WriteLine("Float value");
            FloatOperations();
            Console.WriteLine("Double value");
            DoubleOperations();
            Console.WriteLine("Decimal value");
            DecimalOperations();
        }

        private static void DecimalOperations()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            decimal result = 0m;
            for (int i = 0; i < count; i++)
            {
                result = (decimal)Math.Sqrt(7);
            }

            Console.WriteLine("Math.Sqrt(): {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                result = (decimal)Math.Log(7);
            }

            Console.WriteLine("Math.Log(): {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                result = (decimal)Math.Sin(7);
            }

            Console.WriteLine("Math.Sin(): {0}", sw.Elapsed);
        }

        private static void DoubleOperations()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            double result = 0;
            for (int i = 0; i < count; i++)
            {
                result = Math.Sqrt(7);
            }

            Console.WriteLine("Math.Sqrt(): {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                result = Math.Log(7);
            }

            Console.WriteLine("Math.Log(): {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                result = Math.Sin(7);
            }

            Console.WriteLine("Math.Sin(): {0}", sw.Elapsed);
        }

        private static void FloatOperations()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            float result = 0;
            for (int i = 0; i < count; i++)
            {
                result = (float)Math.Sqrt(7);
            }

            Console.WriteLine("Math.Sqrt(): {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                result = (float)Math.Log(7);
            }

            Console.WriteLine("Math.Log(): {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                result = (float)Math.Sin(7);
            }

            Console.WriteLine("Math.Sin(): {0}", sw.Elapsed);
        }
    }
}
