namespace Academy.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;
    using Academy.Models;

    public sealed class Configuration : DbMigrationsConfiguration<AcademyDbContext>
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "Academy.Data.AcademyDbContext";
        }

        protected override void Seed(AcademyDbContext context)
        {
            Random rand = new Random();
            string[] courseNames = new string[] { "Javascript", "C# Part 1", "C# Part 2", "C# OOP", "Javascript OOP", "HTML", "CSS", "UX Design" };

            for (int i = 0; i < 10; i++)
            {
                context.Courses.AddOrUpdate(new Course()
                {
                    Name = courseNames[rand.Next(0, courseNames.Length)],
                    Description = courseNames[rand.Next(0, courseNames.Length)] + " Description " + i
                });
            }

            for (int i = 0; i < 20; i++)
            {
                context.Students.AddOrUpdate(new Student()
                {
                    FirstName = RandomString(6),
                    LastName = RandomString(8),
                    Number = rand.Next(10000000, 99999999).ToString(),
                    Age = (byte)rand.Next(18, 30),
                    Status = StudentStatus.Onsite
                });
            }

            context.SaveChanges();

            for (int i = 0; i < 10; i++)
            {
                context.Courses
                    .Where(c => c.Id == i + 1)
                    .FirstOrDefault()
                    .Homeworks.Add(new Homework()
                    {
                        Content = RandomString(20),
                        StudentId = rand.Next(1, 21)
                    });
            }

            context.SaveChanges();

            for (int i = 0; i < 10; i++)
            {
                context.Courses
                    .Where(c => c.Id == i + 1)
                    .FirstOrDefault()
                    .Materials.Add(new Material()
                    {
                        Content = RandomString(20),
                        CourseId = rand.Next(1, 11)
                    });
            }

            context.SaveChanges();
        }

        private static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
