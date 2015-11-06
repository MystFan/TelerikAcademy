namespace _02.Company
{
    using System;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Startup
    {
        private static Random Random = new Random((int)DateTime.Now.Ticks);

        public static void Main()
        {
            OrderedMultiDictionary<string, IArticle> d = new OrderedMultiDictionary<string, IArticle>(true);
            Article[] articles = GenerateArticles(10000);
            CompanyDatabase companyDatabase = new CompanyDatabase();
            for (int i = 0; i < articles.Length; i++)
            {
                companyDatabase.AddArticle(articles[i]);
            }

            var articlesByPriceRange = companyDatabase.GetByPriceRange(20m, 30m);
            Console.WriteLine("Articles count: {0}", articlesByPriceRange.Count);
        }

        private static Article[] GenerateArticles(int numberOfArticles)
        {
            Article[] result = new Article[numberOfArticles];
            for (int i = 0; i < numberOfArticles; i++)
            {
                string barcode = RandomNumberAsString(1000, 9999);
                string title = RandomString(7);
                string vendor = RandomString(6);
                decimal price = Random.Next(1, 100);
                result[i] = new Article(barcode, title, price, vendor);
            }

            return result;
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

        private static string RandomNumberAsString(int min, int max)
        {
            return Random.Next(min, max).ToString();
        }
    }
}
