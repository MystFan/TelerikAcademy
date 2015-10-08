namespace ReadExcel
{
    using System;
    using System.Data.OleDb;

    public class ReadExcel
    {
        public static void Main()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=..\\..\\results.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";";

            OleDbConnection dbConn = new OleDbConnection(connectionString);


            dbConn.Open();
            using (dbConn)
            {
                OleDbCommand cmd = new OleDbCommand(
                    "SELECT * FROM [results$1:7]", dbConn);

                try
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        double score = (double)reader["Score"];
                        Console.WriteLine(string.Format("{0} - {1}", name, score));
                    }
                }
                catch (OleDbException exception)
                {
                    Console.WriteLine("SQL Error occured: " + exception.Message);
                }
            }
        }
    }
}
