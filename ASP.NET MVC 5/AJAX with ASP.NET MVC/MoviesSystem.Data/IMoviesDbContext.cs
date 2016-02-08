namespace MoviesSystem.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using MoviesSystem.Models;

    public interface IMoviesDbContext
    {
        IDbSet<Movie> Movies { get; set; }

        IDbSet<MovieMember> MovieMembers { get; set; }

        IDbSet<MovieStudio> MovieStudios { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
