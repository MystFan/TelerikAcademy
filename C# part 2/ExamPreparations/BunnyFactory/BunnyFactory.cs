
namespace BunnyFactory
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Numerics;
    using System.Linq;
    class BunnyFactory
    {
        static void Main()
        {
            List<int> bunnies = new List<int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("END"))
                {
                    break;
                }
                bunnies.Add(int.Parse(input));
            }

            int[] cages = bunnies.ToArray();

            string str = FirstCycle(cages);
            str = new String(str.Where(c => c != '0' && c != '1').ToArray());
            int counter = 1;
            string result = str;

            while (true)
            {
                counter++;
                if (result.Length < counter)
                {
                    break;
                }
                int s = 0;
                for (int i = 0; i < counter; i++)
                {
                    s += int.Parse(result[i].ToString());
                }
                if (s > result.Length)
                {
                    break;
                }
                string numbers = result.Substring(counter, s);
                BigInteger product = Product(ConvertToIntArray(numbers.ToCharArray()));
                BigInteger sum = Sum(ConvertToIntArray(numbers.ToCharArray()));
                string current = result.Substring(counter + s, result.Length - (counter + s));
                result = sum.ToString() + product + current;
                result = new String(result.Where(c => c != '0' && c != '1').ToArray());
            }

            PrintResult(result);
        }

        private static void PrintResult(string result)
        {
            foreach (var c in result)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }

        private static int[] ConvertToIntArray(char[] arr)
        {
            int[] digits = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                digits[i] = (int.Parse(arr[i].ToString()));
            }
            return digits;
        }
        private static string FirstCycle(int[] cells)
        {
            StringBuilder sb = new StringBuilder();
            int s = cells[0];
            int[] firstPart = PartArray(cells, 1, s);
            int[] secondPart = PartArray(cells, s + 1, cells.Length - 1);
            BigInteger product = Product(firstPart);
            BigInteger sum = Sum(firstPart);
            sb.Append(sum);
            sb.Append(product);
            for (int i = 0; i < secondPart.Length; i++)
            {
                sb.Append(secondPart[i]);
            }
            return sb.ToString();
        }

        private static BigInteger Sum(int[] array)
        {
            BigInteger sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        private static BigInteger Product(int[] array)
        {
            BigInteger product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }
            return product;
        }

        private static T[] PartArray<T>(T[] arr, int start, int end) where T : IComparable
        {
            int length = ((arr.Length - start) - (arr.Length - end)) + 1;
            T[] result = new T[length];
            Array.Copy(arr, start, result, 0, length);
            return result;
        }
    }
}
