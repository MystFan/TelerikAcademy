namespace TwitterLikeSystem.Web.Controllers
{
    using System.Web.Mvc;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using TwitterLikeSystem.Services.Contracts;
    using ViewModels.Tweets;

    public class HomeController : Controller
    {
        private ITweetsService tweets;

        public HomeController(ITweetsService tweets)
        {
            this.tweets = tweets;
        }

        public ActionResult Index()
        {
            var dbTweets = this.tweets
                .GetAll()
                .OrderByDescending(t => t.DateCreate)
                .ProjectTo<TweetViewModel>()
                .Take(10)
                .ToList();

            return View(dbTweets);
        }
    }
}