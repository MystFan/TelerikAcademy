namespace TwitterLikeSystem.Models
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class User : IdentityUser
    {
        private ICollection<Tweet> tweets;
        private ICollection<Comment> comments;

        public User()
        {
            this.tweets = new HashSet<Tweet>();
            this.comments = new HashSet<Comment>();
        }

        public ICollection<Tweet> Tweets
        {
            get
            {
                return tweets;
            }

            set
            {
                tweets = value;
            }
        }

        public ICollection<Comment> Comments
        {
            get
            {
                return comments;
            }

            set
            {
                comments = value;
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
