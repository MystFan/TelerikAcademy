using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerCalculations
{
    public class Calculate
    {
        public int CalculateMaxValue(params int[] numbers)
        {
            int max = 0;
            int currentNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            return max;
        }

        public int CalculateMinValue(params int[] numbers)
        {
            int min = int.MaxValue;
            int currentNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                if (currentNumber < min)
                {
                    min = currentNumber;
                }
            }
            return min;
        }

        public int CalculateAverage(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int average = sum / numbers.Length - 1;
            return average;
        }
        public int CalculateProduct(params int[] productNumbers)
        {
            int product = 1;
            for (int row = 0; row < productNumbers.Length; row++)
            {
                product *= productNumbers[row];
            }
            return product;
        }
       
        public int CalculateSum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
