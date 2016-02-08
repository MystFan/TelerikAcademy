namespace MoviesSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CreateMovieModel
    {
        [Required(ErrorMessage = "Movie title is required")]
        [MaxLength(100, ErrorMessage = "Movie title maximum length is 100")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Movie year is required")]
        public int Year { get; set; }

        public CreateMovieMemberModel Director { get; set; }

        public CreateMovieMemberModel LeadingMaleRole { get; set; }

        public CreateMovieMemberModel LeadingFemaleRole { get; set; }

        public CreateStudioModel Studio { get; set; }
    }
}