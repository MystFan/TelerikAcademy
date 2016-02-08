namespace TwitterLikeSystem.Web
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TwitterLikeSystemDbContext, Configuration>());
            TwitterLikeSystemDbContext.Create().Database.Initialize(true);
        }
    }
}