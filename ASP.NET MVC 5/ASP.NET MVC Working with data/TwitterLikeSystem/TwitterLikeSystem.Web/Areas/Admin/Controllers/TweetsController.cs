namespace TwitterLikeSystem.Web.Areas.Admin.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Kendo.Mvc.UI;
    using Kendo.Mvc.Extensions;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNet.Identity;
    using TwitterLikeSystem.Services.Contracts;
    using TwitterLikeSystem.Web.Areas.Admin.Models.Tweets;

    [Authorize(Roles = "Admin")]
    public class TweetsController : Controller
    {
        private ITweetsService tweets;

        public TweetsController(ITweetsService tweets)
        {
            this.tweets = tweets;
        }

        // GET: Admin/Tweets
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjaxIndex([DataSourceRequest]DataSourceRequest request)
        {
            var allTweets = this.tweets
               .GetAll()
               .ProjectTo<TweetAdminViewModel>()
               .ToList();

            return Json(allTweets.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create([DataSourceRequest] DataSourceRequest request,
            TweetAdminViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                this.tweets.Add(model.Title, model.Content, string.Join("", model.TagsList), this.User.Identity.GetUserId());
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Edit([DataSourceRequest] DataSourceRequest request,
            TweetAdminViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                this.tweets.Update(model.Id, model.Title, model.Content, model.DateCreate);
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Delete([DataSourceRequest] DataSourceRequest request, 
            TweetAdminViewModel model)
        {
            if (model != null)
            {
                this.tweets.Delete(model.Id);
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}
