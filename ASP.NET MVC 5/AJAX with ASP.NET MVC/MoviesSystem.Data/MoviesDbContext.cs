namespace MoviesSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using MoviesSystem.Models;

    public class MoviesDbContext : IdentityDbContext<User>, IMoviesDbContext
    {
        public MoviesDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Movie> Movies { get; set; }

        public virtual IDbSet<MovieMember> MovieMembers { get; set; }

        public virtual IDbSet<MovieStudio> MovieStudios { get; set; }

        public static MoviesDbContext Create()
        {
            return new MoviesDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                        .HasRequired(c => c.Director)
                        .WithMany()
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                        .HasRequired(c => c.LeadingFemaleRole)
                        .WithMany()
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                        .HasRequired(c => c.LeadingMaleRole)
                        .WithMany()
                        .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
