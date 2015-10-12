namespace DatabaseNorthwindTwin
{
    using System;
    using System.Configuration;
    using EntityFrameworkNorthwind;

    public class EntryPoint
    {
        public static void Main()
        {
            NorthwindEntities db = new NorthwindEntities();

            string differentConnectionString = ConfigurationManager.ConnectionStrings["NorthwindEntities"].ConnectionString;
            Console.WriteLine(differentConnectionString);

            using (db)
            {
                bool created = db.Database.CreateIfNotExists();

                if (created)
                {
                    Console.WriteLine("Database NorthwindTwin created!");
                }
                else
                {
                    Console.WriteLine("Database NorthwindTwin already exist!");
                }
            }
        }
    }
}
