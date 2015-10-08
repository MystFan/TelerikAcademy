namespace MySqlLibrary
{
    using MySql.Data.MySqlClient;
    using System;
    public class MySqlLibrary
    {
        public static void Main()
        {
            Console.Write("Enter pass: ");
            string password = Console.ReadLine();

            // Change connection string with your database name
            string connectionString = "Server=localhost;Database=library;Uid=root;Pwd=" + password + ";";

            MySqlLibraryProvider provider = new MySqlLibraryProvider(connectionString);
            ILogger logger = new ConsoleLogger();

            // List all books
            provider.ListBooks(logger);

            // Add new book
            string title = "It";
            bool isBookAdded = provider.AddBook(title, 2, new DateTime(), "A2123143234");
            if (isBookAdded)
            {
                logger.Log("Book added!");
            }

            // Get book by title
            string bookAsString = provider.GetBookByTitle(title);
            logger.Log("Book:");
            logger.Log(bookAsString);
        }
    }
}
