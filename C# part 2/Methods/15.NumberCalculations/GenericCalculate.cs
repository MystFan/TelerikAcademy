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

        public T CalculateAverage<T>(params T[] numbers) where T : IComparable<T>
        {
            T sum = default(T);
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += (dynamic)numbers[i];
            }
            T average = sum / (dynamic)numbers.Length;
            return average;
        }

        public T CalculateProduct<T>(params T[] productNumbers) where T : IComparable<T>
        {
            T product = default(T);
            for (int row = 0; row < productNumbers.Length; row++)
            {
                product *= (dynamic)productNumbers[row];
            }
            return product;
        }

        public T CalculateSum<T>(params T[] numbers) where T : IComparable<T>
        {
            T sum = default(T);
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += (dynamic)numbers[i];
            }
            return sum;
        }
    }
}
