
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
        }
    }
}
