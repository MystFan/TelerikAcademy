
namespace WeAllLoveBits
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class WeAllLoveBits
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            List<int> invert = new List<int>();
            List<int> reverse = new List<int>();
            List<int> results = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int P = int.Parse(Console.ReadLine());
                string p = Convert.ToString(P, 2).TrimStart('0');

                for (int l = 0; l < p.Length; l++)
                {
                    int bit = int.Parse(p[l].ToString());
                    if (bit == 1)
                    {
                        invert.Add(0);
                    }
                    else
                    {
                        invert.Add(1);
                    }
                }
                for (int d = p.Length - 1; d >= 0; d--)
                {
                    reverse.Add(int.Parse(p[d].ToString()));
                }

                for (int j = 0; j < invert.Count; j++)
                {
                    sb.Append(invert[j]);
                }
                int invP = Convert.ToInt32(sb.ToString(), 2);
                sb.Clear();
                for (int j = 0; j < reverse.Count; j++)
                {
                    sb.Append(reverse[j]);
                }
                int revP = Convert.ToInt32(sb.ToString(), 2);
                sb.Clear();
                invert.Clear();
                reverse.Clear();
                int result = (P ^ invP) & revP;
                results.Add(result);
            }

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
