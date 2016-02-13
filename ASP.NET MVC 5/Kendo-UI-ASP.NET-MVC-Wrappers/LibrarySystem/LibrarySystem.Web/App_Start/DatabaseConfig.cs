namespace LibrarySystem.Web
{
    using System.Data.Entity;
    using LibrarySystem.Data;
    using LibrarySystem.Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LibrarySystemDbContext, Configuration>());
            LibrarySystemDbContext.Create().Database.Initialize(true);
        }
    }
}