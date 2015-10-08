
namespace CategoriesCount
{
    using System;
    using System.Data.SqlClient;

    public class CategoriesCount
    {
        public static void Main()
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=Northwind;Integrated Security=true");
            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand(
                    "SELECT COUNT(*) FROM Categories");
                command.Connection = connection;

                int categoriesCount = (int)command.ExecuteScalar();
                Console.WriteLine(categoriesCount);
            }
        }
    }
}
