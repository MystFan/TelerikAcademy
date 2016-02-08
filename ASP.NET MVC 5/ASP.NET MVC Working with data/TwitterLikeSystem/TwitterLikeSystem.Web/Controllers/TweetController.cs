namespace TwitterLikeSystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using AutoMapper.QueryableExtensions;
    using TwitterLikeSystem.Services.Contracts;
    using TwitterLikeSystem.Web.ViewModels.Tweets;

    [Authorize]
    public class TweetController : Controller
    {
        private ITweetsService tweets;
        
        public TweetController(ITweetsService tweets)
        {
            this.tweets = tweets;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [OutputCache(Duration = 15 * 60, VaryByParam = "tag")]
        public ActionResult TweetsByTag(string tag)
        {
            if(tag == null)
            {
                tag = string.Empty;
            }

            var tweetsResult = this.tweets
                .GetByTagName(tag)
                .ProjectTo<TweetViewModel>()
                .ToList();

            return View(tweetsResult);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TweetInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View("Create", model);
            }

            this.tweets.Add(model.Title, model.Content, model.Tags, this.User.Identity.GetUserId());

            return RedirectToAction("Index", "Profile");
        }
    }
}