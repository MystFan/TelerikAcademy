/*
 Problem 14. Integer calculations

    Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    Use variable number of arguments.

 */
namespace _14.IntegerCalculations
{
    using System;
    using System.Collections;
    class IntegerCalculations
    {
        static void Main()
        {
            Calculate calc = new Calculate();
            int maxValue = calc.CalculateMaxValue(2, 4, 5, 8, 7, 98, 1, 2, -2, -4, 0);
            Console.WriteLine("Max value {0}" ,maxValue);
            int minValue = calc.CalculateMinValue(2, 4, 5, 8, 7, 98, 1, 2, -2, -4, 0);
            Console.WriteLine("Min value {0}", minValue);
            int sum = calc.CalculateSum(2, 4, 5, 8, 7, 98, 1, 2, -2, -4, 0);
            Console.WriteLine("Sum {0}", sum);
            int average = calc.CalculateAverage(2, 4, 5, 8, 7, 98, 1, 2, -2, -4, 0);
            Console.WriteLine("Average {0}", average);
            int product = calc.CalculateProduct(2, 4, 5, 8, 7, 98, 1, 2, -2, -4);
            Console.WriteLine("Product {0}", product);
        }
    }
}
