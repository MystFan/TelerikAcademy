namespace ToDoSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using ToDoSystem.Models;

    public interface IToDoDbContext
    {
        IDbSet<ToDo> ToDos { get; set; }

        IDbSet<Category> Categories { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }

}
