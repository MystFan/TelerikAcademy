namespace MoviesSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class EditMovieModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Movie title is required")]
        [MaxLength(100, ErrorMessage = "Movie title maximum length is 100")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Movie year is required")]
        public int Year { get; set; }

        public EditMovieMemberModel Director { get; set; }

        public EditMovieMemberModel LeadingMaleRole { get; set; }

        public EditMovieMemberModel LeadingFemaleRole { get; set; }

        public EditStudioModel Studio { get; set; }
    }
}