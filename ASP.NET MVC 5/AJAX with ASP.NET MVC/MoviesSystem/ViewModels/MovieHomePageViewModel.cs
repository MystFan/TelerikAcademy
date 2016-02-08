namespace MoviesSystem.ViewModels
{
    using Models;
    using System;
    using System.Linq.Expressions;

    public class MovieHomePageViewModel
    {
        public static Expression<Func<Movie, MovieHomePageViewModel>> FromModel
        {
            get
            {
                return m => new MovieHomePageViewModel
                {
                    Title = m.Title,
                    Director = m.Director.Name,
                    Year = m.Year
                };
            }
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }
    }
}