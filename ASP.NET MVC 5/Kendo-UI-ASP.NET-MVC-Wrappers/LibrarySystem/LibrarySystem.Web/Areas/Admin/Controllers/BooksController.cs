namespace LibrarySystem.Web.Areas.Admin.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using AutoMapper;
    using Mappings;
    using LibrarySystem.Services.Contracts;
    using LibrarySystem.Web.Areas.Admin.Models;

    [Authorize(Roles = "Admin")]
    public class BooksController : Controller
    {
        private IBooksService books;
        private ICategoriesService categories;

        public BooksController(IBooksService books, ICategoriesService categories)
        {
            this.books = books;
            this.categories = categories;
        }

        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AjaxIndex([DataSourceRequest]DataSourceRequest request)
        {
            var allTweets = this.books
               .GetAll()
               .MapTo<BookAdminViewModel>()
               .ToList();

            return Json(allTweets.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Edit([DataSourceRequest] DataSourceRequest request,
            BookAdminViewModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                this.books.Update(model.Id, model.Title, model.Content, model.ISBN);
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult Delete([DataSourceRequest] DataSourceRequest request,
            BookAdminViewModel model)
        {
            if (model != null)
            {
                this.books.Delete(model.Id);
            }

            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }
}