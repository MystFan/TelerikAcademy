namespace MoviesSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CreateStudioModel
    {
        [Required(ErrorMessage = "Studio name is required")]
        [MaxLength(200, ErrorMessage = "Studio name maximum length is 200")]
        [Display(Name = "Studio Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Studio address is required")]
        [MaxLength(200, ErrorMessage = "Studio address maximum length is 200")]
        [Display(Name = "Studio Address")]
        public string Address { get; set; }
    }
}