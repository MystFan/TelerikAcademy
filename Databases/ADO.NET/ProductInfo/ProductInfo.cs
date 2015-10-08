namespace ProductInfo
{
    using System;
    using System.Data.SqlClient;

    public class ProductInfo
    {
        public static void Main()
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=Northwind;Integrated Security=true");
            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand(
                    @"SELECT p.ProductName, c.CategoryName, c.Description 
                        FROM Products p
                        INNER JOIN Categories c
                        ON p.CategoryID = c.CategoryID");
                command.Connection = connection;

                var reader = command.ExecuteReader();

                Console.WriteLine("Product name |  Category name | Description");
                Console.WriteLine(new string('-', 50));

                while (reader.Read())
                {
                    string productName = (string)reader["ProductName"];
                    string categoryName = (string)reader["CategoryName"];
                    string categoryDescription = (string)reader["Description"];

                    Console.WriteLine(string.Format("{0} | {1} | {2}", productName, categoryName, categoryDescription));
                }
            }
        }
    }
}
