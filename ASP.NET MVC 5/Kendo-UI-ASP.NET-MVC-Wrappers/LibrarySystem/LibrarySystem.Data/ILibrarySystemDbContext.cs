namespace LibrarySystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using LibrarySystem.Models;

    public interface ILibrarySystemDbContext
    {
        IDbSet<Book> Books { get; set; }

        IDbSet<Author> Authors { get; set; }

        IDbSet<Category> Categories { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
