namespace CategoryImages
{
    using System;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.IO;
    using System.Drawing;

    public class CategoryImages
    {
        private const int OLE_METAFILEPICT_START_POSITION = 78;
        public static void Main()
        {
            ConnectionStringSettings dbConnectionString = ConfigurationManager.ConnectionStrings["NorthwindConnection"];
            SqlConnection connection = new SqlConnection(dbConnectionString.ConnectionString);

            connection.Open();
            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT Picture FROM Categories", connection);

                var reader = command.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    counter++;
                    byte[] picData = reader["Picture"] as byte[];
                    string filePath = String.Format(@"..\..\images\CategoryPicture{0}.jpg", counter);
                    SaveImageFile(filePath, picData);
                }
            }
        }

        private static void SaveImageFile(string fileName, byte[] fileContents)
        {
            using (var ms = new MemoryStream(fileContents, OLE_METAFILEPICT_START_POSITION, fileContents.Length - OLE_METAFILEPICT_START_POSITION))
            {
                Image img = Image.FromStream(ms);
                img.Save(fileName);
            }
        }
    }
}
