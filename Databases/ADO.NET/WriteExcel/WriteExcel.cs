namespace WriteExcel
{
    using System;
    using System.Data.OleDb;

    public class WriteExcel
    {
        public static void Main()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=..\\..\\results.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

            OleDbConnection dbConn = new OleDbConnection(connectionString);
            string personName = "Jhon Doe";
            double personScore = 30;

            dbConn.Open();
            using (dbConn)
            {
                OleDbCommand command = new OleDbCommand(
                    "INSERT INTO [results$] ([Name], [Score]) VALUES (@name, @score)");

                command.Parameters.AddWithValue("@name", personName);
                command.Parameters.AddWithValue("@score", personScore);
                command.Connection = dbConn;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (OleDbException exception)
                {
                    Console.WriteLine("SQL Error occured: " + exception.Message);
                }
            }
        }
    }
}
