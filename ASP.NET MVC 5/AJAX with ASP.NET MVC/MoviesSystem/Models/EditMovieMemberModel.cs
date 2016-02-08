namespace MoviesSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class EditMovieMemberModel
    {
        [Required(ErrorMessage = "Name of movie member is required")]
        public string Name { get; set; }

        [Required]
        [Range(1, 120, ErrorMessage = "Age must be in range 1 - 120 years old")]
        public byte Age { get; set; }
    }
}