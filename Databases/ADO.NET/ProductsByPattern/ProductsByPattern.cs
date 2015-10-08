namespace ProductsByPattern
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class ProductsByPattern
    {
        public static void Main()
        {
            Console.Write("pattern: ");
            string input = DatabaseEscaping(Console.ReadLine());

            var products = GetProduct(input);
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        private static IEnumerable<string> GetProduct(string pattern)
        {
            List<string> result = new List<string>();
            SqlConnection dbCon = new SqlConnection(Settings.Default.ConString);
            dbCon.Open();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand(
                    "SELECT ProductName FROM Products WHERE charindex(@pattern, ProductName) > 0", dbCon);

                command.Parameters.AddWithValue("@pattern", pattern);
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        result.Add((string)reader["ProductName"]);
                    }
                }
            }

            return result;
        }

        private static string DatabaseEscaping(string input)
        {
            string symbols = "'%\\_";
            for (int i = 0; i < symbols.Length; i++)
			{
			    input = input.Replace(symbols[i], '\0');
			}

            return input;
        }
    }
}
