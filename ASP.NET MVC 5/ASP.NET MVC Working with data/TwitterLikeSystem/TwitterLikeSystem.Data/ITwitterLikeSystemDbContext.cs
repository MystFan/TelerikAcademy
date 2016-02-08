namespace TwitterLikeSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using TwitterLikeSystem.Models;

    public interface ITwitterLikeSystemDbContext
    {
        IDbSet<Tweet> Tweets { get; set; }

        IDbSet<Tag> Tags { get; set; }

        IDbSet<Comment> Comments { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
