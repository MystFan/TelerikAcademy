namespace TwitterLikeSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using AutoMapper.QueryableExtensions;
    using TwitterLikeSystem.Services.Contracts;
    using TwitterLikeSystem.Web.ViewModels.Account;
    using TwitterLikeSystem.Web.ViewModels.Tweets;
    using TwitterLikeSystem.Web.ViewModels.Profile;

    public class ProfileController : Controller
    {
        private IUsersService users;
        private ITweetsService tweets;

        public ProfileController(IUsersService users, ITweetsService tweets)
        {
            this.users = users;
            this.tweets = tweets;
        }

        // GET: Profile
        public ActionResult Index()
        {
            var userId = this.User.Identity.GetUserId();
            var user = this.users.GetById(userId);
            var userViewModel = UserViewModel.Create(user);

            var userTweets = this.tweets
                .GetAll()
                .OrderByDescending(t => t.DateCreate)
                .ProjectTo<TweetViewModel>()
                .ToList();

            ProfileViewModel currentUserData = new ProfileViewModel
            {
                User = userViewModel,
                UserTweets = userTweets.ToList()
            };

            return View(currentUserData);
        }
    }
}