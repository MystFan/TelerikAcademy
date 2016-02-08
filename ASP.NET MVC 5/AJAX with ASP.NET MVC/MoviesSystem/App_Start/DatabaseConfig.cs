namespace MoviesSystem
{
    using System.Data.Entity;
    using MoviesSystem.Data;
    using MoviesSystem.Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesDbContext, Configuration>());
            MoviesDbContext.Create().Database.Initialize(true);
        }
    }
}