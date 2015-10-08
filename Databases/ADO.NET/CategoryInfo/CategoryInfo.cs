namespace CategoryInfo
{
    using System;
    using System.Data.SqlClient;

    public class CategoryInfo
    {
        public static void Main()
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=Northwind;Integrated Security=true");
            connection.Open();

            using (connection)
            {
                SqlCommand command = new SqlCommand(
                    "SELECT CategoryName, Description FROM Categories");
                command.Connection = connection;

                var reader = command.ExecuteReader();

                Console.WriteLine("Category ->  Description");
                Console.WriteLine(new string('-', 50));
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string categoryDescription = (string)reader["Description"];

                    Console.WriteLine(string.Format("{0} -> {1}", categoryName, categoryDescription));
                }
            }
        }
    }
}
