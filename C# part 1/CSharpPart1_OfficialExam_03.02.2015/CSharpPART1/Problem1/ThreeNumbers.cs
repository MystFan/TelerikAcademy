namespace Problem1
{
    using System;
    class ThreeNumbers
    {
        static void Main()
        {
            decimal A = decimal.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            decimal C = decimal.Parse(Console.ReadLine());

            decimal max = 0;
            decimal min = 0;
            decimal arithmeticMean  = (decimal)(A + B + C)/3;
            max = A;
            if (B > max)
            {
                max = B;
            }
            if (C > max)
            {
                max = C;
            }
            

            min = A;
            if (B < min)
            {
                min = B;
            }
            if (C < min)
            {
                min = C;
            }
            

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F2}",arithmeticMean);
        }
    }
}
