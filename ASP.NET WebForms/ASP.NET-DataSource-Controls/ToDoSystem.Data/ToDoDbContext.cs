namespace ToDoSystem.Data
{
    using System.Data.Entity;
    using ToDoSystem.Models;

    public class ToDoDbContext : DbContext, IToDoDbContext
    {
        public ToDoDbContext()
           : base("ToDoSystem")
        {

        }

        public virtual IDbSet<ToDo> ToDos { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public static ToDoDbContext Create()
        {
            return new ToDoDbContext();
        }
    }
}
