namespace ToDoSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<ToDoDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ToDoDbContext context)
        {
            if (context.Categories.Count() == 0)
            {
                string[] categoriesNames = new string[]
                {
                    "sport", "work", "party"
                };

                for (int i = 0; i < categoriesNames.Length; i++)
                {
                    context.Categories.Add(new Category
                    {
                        Name = categoriesNames[i]
                    });
                }

                context.SaveChanges();
            }
        }
    }
}
