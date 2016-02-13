namespace LibrarySystem.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using Kendo.Mvc.Extensions;
    using LibrarySystem.Services.Contracts;
    using LibrarySystem.Web.Mappings;
    using LibrarySystem.Web.Models.Books;

    public class HomeController : Controller
    {
        private IBooksService books;

        public HomeController(IBooksService booksService)
        {
            this.books = booksService;
        }

        public ActionResult Index()
        {
            var allBooks = this.books
                        .GetAll()
                        .OrderByDescending(b => b.DateCreate)
                        .MapTo<BookViewModel>()
                        .Take(3)
                        .ToList();

            return View(allBooks);
        }      
    }
}