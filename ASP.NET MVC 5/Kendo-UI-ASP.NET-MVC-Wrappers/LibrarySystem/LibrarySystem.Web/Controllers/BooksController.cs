namespace LibrarySystem.Web.Controllers
{
    using System;
    using System.Web.Caching;
    using System.Linq;
    using System.Web.Mvc;

    using Microsoft.AspNet.Identity;
    using Kendo.Mvc.Extensions;
    using LibrarySystem.Services.Contracts;
    using LibrarySystem.Web.Mappings;
    using LibrarySystem.Web.Models.Books;

    [Authorize]
    public class BooksController : Controller
    {
        private const string BooksCountKey = "BooksCount";
        private IBooksService books;
        private ICategoriesService categories;

        public BooksController(IBooksService booksService, ICategoriesService categories)
        {
            this.books = booksService;
            this.categories = categories;
        }

        public ActionResult All(int page = 0, int pageSize = 3)
        {      
            ViewData[BooksCountKey] = 0;

            if (this.HttpContext.Cache[BooksCountKey] == null)
            {
                DateTime cacheCountDate = DateTime.Now.AddMinutes(10);
                var booksCount = this.books.GetAll().Count();
                ViewData[BooksCountKey] = booksCount;

                this.HttpContext.Cache.Insert(
                    BooksCountKey,
                    booksCount,                
                    null,
                    cacheCountDate, 
                    TimeSpan.Zero,               
                    CacheItemPriority.Default,        
                    null);
            }
            else
            {
                ViewData[BooksCountKey] = this.HttpContext.Cache[BooksCountKey];
            }

            var allBooks = this.books
                .GetAll(page, pageSize)
                .MapTo<BookViewModel>()
                .ToList();

            return View(allBooks);
        }

        [HttpPost]
        public ActionResult GetByTitle(string title)
        {
            var result = this.books
                .GetByTitle(title)
                .MapTo<BookViewModel>()
                .ToList();

            return PartialView("_BooksListPartial", result);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateBookModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View(model);
            }

            this.books.Add(
                model.Title,
                model.ShortReview,
                model.ISBN,
                this.User.Identity.GetUserId(),
                model.AuthorName,
                model.CategoryId);

            return RedirectToAction("All");
        }
    }
}