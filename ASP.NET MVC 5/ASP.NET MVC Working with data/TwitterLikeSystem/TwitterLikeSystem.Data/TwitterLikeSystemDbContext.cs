namespace TwitterLikeSystem.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class TwitterLikeSystemDbContext : IdentityDbContext<User>, ITwitterLikeSystemDbContext
    {
        public TwitterLikeSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Tweet> Tweets { get; set; }

        public virtual IDbSet<Tag> Tags { get; set; }

        public virtual IDbSet<Comment> Comments { get; set; }

        public static TwitterLikeSystemDbContext Create()
        {
            return new TwitterLikeSystemDbContext();
        }
    }
}
