namespace CSharpExamProblem1
{
    using System;

    public class Problem1
    {
        public static void Main()
        {
            decimal A = decimal.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            decimal C = decimal.Parse(Console.ReadLine());

            decimal max = A;
            if (B > max)
            {
                max = B;
            }

            if (C > max)
            {
                max = C;
            }

            decimal min = A;
            if (B < min)
            {
                min = B;
            }

            if (C < min)
            {
                min = C;
            }

            decimal arithmeticMean = (decimal)(A + B + C) / 3;
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F2}", arithmeticMean);
        }
    }
}
