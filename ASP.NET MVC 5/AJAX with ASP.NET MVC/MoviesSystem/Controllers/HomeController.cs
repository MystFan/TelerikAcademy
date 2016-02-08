namespace MoviesSystem.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using MoviesSystem.Data.Repositories;
    using MoviesSystem.Infrastructure.Filters;
    using MoviesSystem.Models;
    using MoviesSystem.ViewModels;

    public class HomeController : Controller
    {
        private IRepository<Movie> movies;

        public HomeController(IRepository<Movie> movies)
        {
            this.movies = movies;
        }

        public ActionResult Index()
        {
            var movies = this.movies
                .All()
                .Select(MovieHomePageViewModel.FromModel)
                .Take(3)
                .ToList();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_MoviesHomePagePartial", movies);
            }

            return View(movies);
        }

        [AjaxOnly]
        public ActionResult GetLastMovies()
        {
            var movies = this.movies
                .All()
                .Select(MovieHomePageViewModel.FromModel)
                .ToList();

            return PartialView("_MoviesHomePagePartial", movies); 
        }
    }
}