namespace LibrarySystem.Models
{
    using System.Security.Claims;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class User : IdentityUser
    {
        private ICollection<Book> books;

        public User()
        {
            this.books = new HashSet<Book>();
        }

        public ICollection<Book> Books
        {
            get
            {
                return books;
            }

            set
            {
                books = value;
            }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
