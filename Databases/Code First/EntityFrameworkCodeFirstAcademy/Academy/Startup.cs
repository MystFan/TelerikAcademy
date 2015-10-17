namespace Academy
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Academy.Data;
    using Academy.Data.Migrations;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AcademyDbContext, Configuration>());

            var db = new AcademyDbContext();

            using (db)
            {
                Console.Write("Courses count: ");
                Console.WriteLine(db.Courses.Count());
                Console.Write("Students count: ");
                Console.WriteLine(db.Students.Count());
            }
        }
    }
}
