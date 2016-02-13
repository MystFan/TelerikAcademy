namespace LibrarySystem.Data
{
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;
    using LibrarySystem.Models;

    public class LibrarySystemDbContext : IdentityDbContext<User>, ILibrarySystemDbContext
    {
        public LibrarySystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Book> Books { get; set; }

        public virtual IDbSet<Author> Authors { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public static LibrarySystemDbContext Create()
        {
            return new LibrarySystemDbContext();
        }
    }
}
