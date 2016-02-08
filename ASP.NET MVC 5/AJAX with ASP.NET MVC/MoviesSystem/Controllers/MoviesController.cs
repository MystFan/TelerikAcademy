namespace MoviesSystem.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using MoviesSystem.Data.Repositories;
    using MoviesSystem.Infrastructure.Filters;
    using MoviesSystem.Models;
    using MoviesSystem.ViewModels;

    [Authorize]
    public class MoviesController : Controller
    {
        private IRepository<Movie> movies;

        public MoviesController(IRepository<Movie> movies)
        {
            this.movies = movies;
        }

        public ActionResult Index()
        {
            var allMovies = this.movies
                .All()
                .Select(MovieViewModel.FromModel)
                .ToList();

            return View(allMovies);
        }

        [AjaxOnly]
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("_CreateMoviePartial");
        }

        [AjaxOnly]
        [HttpPost]
        public ActionResult Create(CreateMovieModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return PartialView("_CreateMoviePartial", model);
            }

            var newMovie = new Movie()
            {
                Title = model.Title,
                Year = model.Year,
                Director = new MovieMember()
                {
                    Name = model.Director.Name,
                    Age = model.Director.Age
                },
                LeadingMaleRole = new MovieMember()
                {
                    Name = model.LeadingMaleRole.Name,
                    Age = model.LeadingMaleRole.Age
                },
                LeadingFemaleRole = new MovieMember()
                {
                    Name = model.LeadingFemaleRole.Name,
                    Age = model.LeadingFemaleRole.Age
                },
                Studio = new MovieStudio()
                {
                    Name = model.Studio.Name,
                    Address = model.Studio.Address
                }
            };

            this.movies.Add(newMovie);
            this.movies.SaveChanges();

            var dbModel = this.movies
                .All()
                .Where(m => m.Id == newMovie.Id)
                .Select(MovieViewModel.FromModel)
                .FirstOrDefault();

            return PartialView("_MovieRowData", dbModel);
        }

        [AjaxOnly]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var movieToDelete = this.movies
                .All()
                .FirstOrDefault(m => m.Id == id);

            if (movieToDelete != null)
            {
                this.movies.Delete(movieToDelete);
                this.movies.SaveChanges();
            }

            return Json(new { Id = id }, JsonRequestBehavior.AllowGet);
        }

        [AjaxOnly]
        [HttpGet]
        public ActionResult Update(int id)
        {
            var movieToUpdate = this.movies
                .All()
                .Where(m => m.Id == id)
                .Select(m => new EditMovieModel
                {
                    Title = m.Title,
                    Year = m.Year,
                    Director = new EditMovieMemberModel
                    {
                        Name = m.Director.Name,
                        Age = m.Director.Age
                    },
                    LeadingMaleRole = new EditMovieMemberModel
                    {
                        Name = m.LeadingMaleRole.Name,
                        Age = m.LeadingMaleRole.Age
                    },
                    LeadingFemaleRole = new EditMovieMemberModel
                    {
                        Name = m.LeadingFemaleRole.Name,
                        Age = m.LeadingFemaleRole.Age
                    },
                    Studio = new EditStudioModel
                    {
                        Name = m.Studio.Name,
                        Address = m.Studio.Address
                    }
                })
                .FirstOrDefault();

            return PartialView("_EditMoviePartial", movieToUpdate);
        }

        [AjaxOnly]
        [HttpPost]
        public ActionResult Update(EditMovieModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return PartialView("_EditMoviePartial", model);
            }

            var dbModel = this.movies
                .All()
                .FirstOrDefault(m => m.Id == model.Id);

            if (dbModel != null)
            {
                dbModel.Title = model.Title;
                dbModel.Year = model.Year;
                dbModel.Director.Name = model.Director.Name;
                dbModel.Director.Age = model.Director.Age;
                dbModel.LeadingMaleRole.Name = model.LeadingMaleRole.Name;
                dbModel.LeadingMaleRole.Age = model.LeadingMaleRole.Age;
                dbModel.LeadingFemaleRole.Name = model.LeadingFemaleRole.Name;
                dbModel.LeadingFemaleRole.Age = model.LeadingFemaleRole.Age;
                dbModel.Studio.Name = model.Studio.Name;
                dbModel.Studio.Address = model.Studio.Address;

                this.movies.Update(dbModel);
                this.movies.SaveChanges();
            }

            return Json(new
            {
                id = dbModel.Id,
                title = dbModel.Title,
                year = dbModel.Year,
                director = dbModel.Director.Name,
                maleRole = dbModel.LeadingMaleRole.Name,
                fimaleRole = dbModel.LeadingFemaleRole.Name,
                studio = dbModel.Studio.Name
            }, JsonRequestBehavior.AllowGet);
        }

        [AjaxOnly]
        [HttpGet]
        public ActionResult Details(int id)
        {
            var movie = this.movies
               .All()
               .Where(m => m.Id == id)
               .Select(MovieViewModel.FromModel)
               .FirstOrDefault();

            if (movie == null)
            {
                return RedirectToAction("Index");
            }

            return PartialView("_MovieDetailsPartial", movie);
        }
    }
}