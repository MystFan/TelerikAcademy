
namespace DancingBits
{
    using System;
    using System.Text;
    class DancingBits
    {
        static void Main()
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(num, 2);
                sb.Append(binary);
            }
            string one = "1".PadLeft(K, '1');
            string zero = "0".PadLeft(K, '0');

            string[] ones = sb.ToString().Split('0');
            string[] zeros = sb.ToString().Split('1');

            ones = Array.FindAll<string>(ones, s => s == one);
            zeros = Array.FindAll<string>(zeros, s => s == zero);
            Console.WriteLine(ones.Length + zeros.Length);
        }
    }
}
