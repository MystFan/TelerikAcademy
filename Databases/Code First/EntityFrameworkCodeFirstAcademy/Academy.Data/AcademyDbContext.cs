namespace Academy.Data
{
    using System.Data.Entity;
    using Academy.Models;

    public class AcademyDbContext : DbContext
    {
        public AcademyDbContext()
            : base("name=AcademySystem")
        {
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public virtual IDbSet<Material> Materials { get; set; }
    }
}
