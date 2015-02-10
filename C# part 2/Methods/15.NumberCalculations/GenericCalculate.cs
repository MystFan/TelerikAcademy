using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NumberCalculations
{
    public class GenericCalculate
    {
        public T CalculateMaxValue<T>(params T[] numbers) where T : IComparable
        {
            T max = default(T);
            T currentNumber = default(T);
            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                if (currentNumber.CompareTo(max) > 0)
                {
                    max = currentNumber;
                }
            }
            return max;
        }

        public T CalculateMinValue<T>(params T[] numbers) where T : IComparable
        {
            T min = default(T);
            T currentNumber = default(T);
            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                if (currentNumber.CompareTo(min) < 0)
                {
                    min = currentNumber;
                }
            }
            return min;
        }

    }
}
