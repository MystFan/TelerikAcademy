namespace _02.ReadLargeCollection
{
    using System;
    using System.Diagnostics;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Startup
    {
        private static Random Random = new Random((int)DateTime.Now.Ticks);

        public static void Main()
        {
            string[] stringValues = new string[500000];
            for (int i = 0; i < 500000; i++)
            {
                stringValues[i] = RandomString(5);
            }

            decimal[] numberValues = new decimal[500000];
            for (int i = 0; i < 500000; i++)
            {
                numberValues[i] = GetRandomNumber(1, 1000);
            }
            
            OrderedBag<Product> products = new OrderedBag<Product>();

            for (int i = 0; i < 500000; i++)
            {
                products.Add(new Product
                {
                    Name = stringValues[i],
                    Price = numberValues[i]
                });
            }

            Console.WriteLine("Products added!");

            TestOrderBagSearchSpeed(products);
        }

        private static void TestOrderBagSearchSpeed(OrderedBag<Product> bag)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Product firstProduct = new Product()
            {
                Price = 123
            };

            Product secondProduct = new Product()
            {
                Price = 999
            };

            bag.Range(firstProduct, true, secondProduct, true);

            Console.WriteLine(sw.Elapsed);
            sw.Stop();
        }

        private static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Random.NextDouble() + 65)));
            builder.Append(ch.ToString());
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Random.NextDouble() + 97)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        public static int GetRandomNumber(int min = 0, int max = int.MaxValue / 2)
        {
            return Random.Next(min, max + 1);
        }
    }
}
