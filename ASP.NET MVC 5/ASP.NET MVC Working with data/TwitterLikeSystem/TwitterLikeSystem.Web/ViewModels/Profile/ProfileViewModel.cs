namespace TwitterLikeSystem.Web.ViewModels.Profile
{
    using System.Collections.Generic;
    using TwitterLikeSystem.Web.ViewModels.Account;
    using TwitterLikeSystem.Web.ViewModels.Tweets;

    public class ProfileViewModel
    {
        public UserViewModel User { get; set; }

        public IList<TweetViewModel> UserTweets { get; set; }
    }
}