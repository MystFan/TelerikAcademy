using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            string input = Console.ReadLine();

            int n;
            bool isValidNumber = int.TryParse(input, out n);
            if (isValidNumber)
            {
                string output = "0, 1, ";
                double[] numbers = new double[n];
                numbers[0] = 0;
                numbers[1] = 1;
                for (int i = 2; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                    output += numbers[i] + ", ";
                }
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Input string was not in a correct format");
            }
        }
    }
}
