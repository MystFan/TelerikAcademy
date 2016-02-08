namespace MoviesSystem.ViewModels
{
    using System;
    using System.Linq.Expressions;
    using MoviesSystem.Models;

    public class MovieViewModel
    {
        public static Expression<Func<Movie, MovieViewModel>> FromModel
        {
            get
            {
                return m => new MovieViewModel
                {
                    Id = m.Id,
                    Title = m.Title,
                    Director = m.Director.Name,
                    Year = m.Year,
                    LeadingMaleRole = m.LeadingMaleRole.Name,
                    LeadingFemaleRole = m.LeadingFemaleRole.Name,
                    Studio = m.Studio.Name
                };
            }
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }

        public string LeadingMaleRole { get; set; }

        public string LeadingFemaleRole { get; set; }

        public string Studio { get; set; }
    }
}