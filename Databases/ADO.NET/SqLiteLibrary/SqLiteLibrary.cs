using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SqLiteLibrary
{
    using System.Data.SQLite;
    using MySqlLibrary;

    public class SqLiteLibrary
    {
        public static void Main()
        {
            ILogger logger = new ConsoleLogger();
            PrintBooks(logger);
            logger.Log("----------------------");
            AddBook(5, "Dead zone", "0002C65467", 1);
            PrintBooks(logger);
            logger.Log("----------------------");
            GetBookByName("Dead zone");
        }

        private static void GetBookByName(string pattern)
        {
            SQLiteConnection dbCon = new SQLiteConnection(@"Data Source=..\\..\\library.sqlite;Version=3;");
            dbCon.Open();
            using (dbCon)
            {
                SQLiteCommand cmdGetBookByName = new SQLiteCommand(
                   "select title from books where charindex(@pattern,title) > 0", dbCon
                    );
                cmdGetBookByName.Parameters.AddWithValue("@pattern", pattern);
                SQLiteDataReader reader = cmdGetBookByName.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0]);
                    }
                }
            }
        }

        private static void AddBook(int id, string title, string isbn, int authorId)
        {
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=..\\..\\library.sqlite;Version=3;");
            dbCon.Open();
            using (dbCon)
            {
                SQLiteCommand cmdAdd = new SQLiteCommand(
                    "insert into books(bookID,title,isbn,authorID)values(@id,@title,@isbn,@authorID)", dbCon
                    );
                cmdAdd.Parameters.AddWithValue("@id", id);
                cmdAdd.Parameters.AddWithValue("@title", title);
                cmdAdd.Parameters.AddWithValue("@isbn", isbn);
                cmdAdd.Parameters.AddWithValue("@authorID", authorId);
                cmdAdd.ExecuteNonQuery();
            }
        }

        private static void PrintBooks(ILogger logger)
        {
            SQLiteConnection db = new SQLiteConnection("Data Source=..\\..\\library.sqlite;Version=3;");
            db.Open();
            using (db)
            {
                SQLiteCommand cmdGetBooks = new SQLiteCommand(
                    "SELECT * FROM books", db
                    );
                SQLiteDataReader reader = cmdGetBooks.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        logger.Log(string.Format("bookID: {0} --> title: {1} --> isbnCode: {2} --> authorID: {3}",
                            reader[0], reader[1], reader[2], reader[3]));
                    }
                }
            }
        }
    }
}
