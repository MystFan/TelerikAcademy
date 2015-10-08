namespace MySqlLibrary
{
    using MySql.Data.MySqlClient;
    using System;

    public class MySqlLibraryProvider
    {
        public readonly string ConnectionString;
        private MySqlConnection connection;

        public MySqlLibraryProvider(string connectionString)
        {
            this.ConnectionString = connectionString;
            this.connection = new MySqlConnection(this.ConnectionString);
        }

        public void ListBooks(ILogger loger)
        {
            
            connection.Open();
            using (connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM books", connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string bookTitle = (string)reader["title"];
                    DateTime publishDate = (DateTime)reader["publishDate"];
                    string isbn = (string)reader["isbn"];
                    loger.Log(string.Format("Title: {0}, Publish date: {1}, isbn: {2}", bookTitle, publishDate, isbn));
                }
            }
        }

        public string GetBookByTitle(string title)
        {
            string result = string.Empty;
            connection.Open();
            using (connection)
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM books WHERE title = @title", connection);
                command.Parameters.AddWithValue("@title", title);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string bookTitle = (string)reader["title"];
                    DateTime publishDate = (DateTime)reader["publishDate"];
                    string isbn = (string)reader["isbn"];
                    result = string.Format("Title: {0}, Publish date: {1}, isbn: {2}", bookTitle, publishDate, isbn);
                }
            }

            return result;
        }

        public bool AddBook(string title, int authorId, DateTime publishDate, string isbn)
        {
            connection.Open();
            using (connection)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO books (title, authorID, publishDate, isbn) VALUES(@title, @authorID, @publishDate, @isbn)", connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@authorID", authorId);
                command.Parameters.AddWithValue("@publishDate", publishDate);
                command.Parameters.AddWithValue("@isbn", isbn);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
