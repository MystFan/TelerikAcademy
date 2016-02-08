namespace TwitterLikeSystem.Web.ViewModels.Account
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using TwitterLikeSystem.Models;

    public class UserViewModel
    {
        public static Expression<Func<User, UserViewModel>> FromModel
        {
            get
            {
                return m => new UserViewModel
                {
                    Id = m.Id,
                    Email = m.Email,
                    UserName = m.UserName,
                    Tweets = m.Tweets.ToList()
                };
            }
        }

        public string Id { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public IEnumerable<Tweet> Tweets { get; set; }

        public static UserViewModel Create(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Tweets = user.Tweets.ToList()
            };
        }
    }
}