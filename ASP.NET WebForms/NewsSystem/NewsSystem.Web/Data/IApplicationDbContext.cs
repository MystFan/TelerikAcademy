using NewsSystem.Web.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace NewsSystem.Web.Data
{
    public interface IApplicationDbContext
    {
        IDbSet<Article> Articles { get; set; }

        IDbSet<Category> Categories { get; set; }

        IDbSet<Like> Likes { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
