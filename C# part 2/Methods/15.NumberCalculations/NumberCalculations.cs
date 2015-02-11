
namespace _15.NumberCalculations
{
    using System;
    class NumberCalculations
    {
        static void Main()
        {
            GenericCalculate calc = new GenericCalculate();
            int maxValue = calc.CalculateMaxValue(2, 4, 5, 8, 7, 98, 1, 2, -2, -4, 0);
            Console.WriteLine("Max value {0}", maxValue);
            int minValue = calc.CalculateMinValue(2, 4, 5, 8, 7, 98, 1, 2, -2, -4, 0);
            Console.WriteLine("Min value {0}", minValue);
            var average = calc.CalculateAverage(3, 4.7, 5.3, 6, 7.1, -3);
            Console.WriteLine("Average {0}", average);
            var product = calc.CalculateProduct(2, 4, 5, 8, 7, 98, 1, 2, -2, -4, 0);
            Console.WriteLine("Product {0}", product);
            var sum = calc.CalculateSum(3, 4.7, 5.3, 6, 7.1, -3);
            Console.WriteLine("Sum {0}", sum);
        }
    }
}
