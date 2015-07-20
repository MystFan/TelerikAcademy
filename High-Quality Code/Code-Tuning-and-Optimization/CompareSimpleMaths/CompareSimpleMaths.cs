namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class CompareSimpleMaths
    {
        private static int count = 1000000;
        public static void Main()
        {
            Console.WriteLine("Integer value");
            IntegerOperations();
            Console.WriteLine("Long value");
            LongOperations();
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

            decimal sum = 0;
            for (decimal i = 0; i < count; i++)
            {
                sum += 2;
            }

            Console.WriteLine("Add: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (decimal i = 0; i < count; i++)
            {
                sum -= 2;
            }

            Console.WriteLine("Subtract: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (decimal i = 0; i < count; i++)
            {
                sum++;
            }

            Console.WriteLine("Increment: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (decimal i = 1; i <= count; i++)
            {
                sum *= 1;
            }

            Console.WriteLine("Multiply: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (decimal i = 1; i <= count; i++)
            {
                sum /= 2;
            }

            Console.WriteLine("Divide: {0}", sw.Elapsed);
        }

        private static void DoubleOperations()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            double sum = 0;
            for (double i = 0; i < count; i++)
            {
                sum += i;
            }

            Console.WriteLine("Add: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (double i = 0; i < count; i++)
            {
                sum -= 2;
            }

            Console.WriteLine("Subtract: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (double i = 0; i < count; i++)
            {
                sum++;
            }

            Console.WriteLine("Increment: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (double i = 1; i <= count; i++)
            {
                sum *= i;
            }

            Console.WriteLine("Multiply: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (double i = 1; i <= count; i++)
            {
                sum /= i;
            }

            Console.WriteLine("Divide: {0}", sw.Elapsed);
        }

        private static void FloatOperations()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            float sum = 0;
            for (float i = 0; i < count; i++)
            {
                sum += i;
            }

            Console.WriteLine("Add: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (float i = 0; i < count; i++)
            {
                sum -= 2;
            }

            Console.WriteLine("Subtract: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (float i = 0; i < count; i++)
            {
                sum++;
            }

            Console.WriteLine("Increment: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (float i = 1; i < count; i++)
            {
                sum *= i;
            }

            Console.WriteLine("Multiply: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (float i = 1; i < count; i++)
            {
                sum /= i;
            }

            Console.WriteLine("Divide: {0}", sw.Elapsed);
        }

        private static void LongOperations()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            long sum = 0;
            for (long i = 0; i < count; i++)
            {
                sum += i;
            }

            Console.WriteLine("Add: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (long i = 0; i < count; i++)
            {
                sum -= 2;
            }

            Console.WriteLine("Subtract: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (long i = 0; i < count; i++)
            {
                sum++;
            }

            Console.WriteLine("Increment: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (long i = 1; i <= count; i++)
            {
                sum *= i;
            }

            Console.WriteLine("Multiply: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (long i = 1; i <= count; i++)
            {
                sum /= i;
            }

            Console.WriteLine("Divide: {0}", sw.Elapsed);
        }

        private static void IntegerOperations()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += i;
            }

            Console.WriteLine("Add: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                sum -= 2;
            }

            Console.WriteLine("Subtract: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                sum++;
            }

            Console.WriteLine("Increment: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 1; i <= count; i++)
            {
                sum *= i;
            }

            Console.WriteLine("Multiply: {0}", sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (int i = 1; i <= count; i++)
            {
                sum /= i;
            }

            Console.WriteLine("Divide: {0}", sw.Elapsed);
        }
    }
}
