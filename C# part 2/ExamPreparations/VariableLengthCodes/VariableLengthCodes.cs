using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLengthCodes
{
    class VariableLengthCodes
    {
        private static char[] separators;
        private static List<int> inputNumbers;
        private static Dictionary<int, char> dictionary;
        static void Main()
        {
            separators = new char[] { ' ' };
            ReadNumbers();
            dictionary = new Dictionary<int, char>();
            ReadCodes();
            List<string> binaryNumbers = ConvertNumbersToBinary();
            string seq = ConcatBinaryNumbers(binaryNumbers);
            string text = DecodeText(seq);
            Console.WriteLine(text);
        }

        private static string DecodeText(string seq)
        {
            int counter = 0;
            string result = String.Empty;
            for (int i = 0; i < seq.Length; i++)
            {
                if (seq[i] == '1')
                {
                    counter++;
                }
                else if (seq[i] == '0')
                {
                    int key = dictionary.Keys.FirstOrDefault(k => k == counter);
                    bool hasKey = dictionary.Keys.Any(k => k == counter);
                    if (!hasKey)
                    {
                        break;
                    }
                    result += dictionary[key];
                    counter = 0;
                }
            }
            return result;
        }

        private static string ConcatBinaryNumbers(List<string> binaryNumbers)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < binaryNumbers.Count; i++)
            {
                sb.Append(binaryNumbers[i]);
            }
            return sb.ToString();
        }

        private static List<string> ConvertNumbersToBinary()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                string binary = Convert.ToString(inputNumbers[i], 2).PadLeft(8, '0');
                result.Add(binary);
            }
            return result;
        }

        private static void ReadNumbers()
        {
            inputNumbers = new List<int>();
            string[] nums = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < nums.Length; i++)
            {
                inputNumbers.Add(int.Parse(nums[i]));
            }
        }

        private static void ReadCodes()
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string value = input.Substring(1, input.Length - 1);
                dictionary.Add(int.Parse(value), (input[0]));
            }
        }
    }
}
