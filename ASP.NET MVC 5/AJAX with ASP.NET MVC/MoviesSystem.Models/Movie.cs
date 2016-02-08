namespace MoviesSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public int DirectorId { get; set; }

        public virtual MovieMember Director { get; set; }

        public int LeadingMaleRoleId { get; set; }

        public virtual MovieMember LeadingMaleRole { get; set; }

        public int LeadingFemaleRoleId { get; set; }

        public virtual MovieMember LeadingFemaleRole { get; set; }

        public int StudioId { get; set; }

        public virtual MovieStudio Studio { get; set; }
    }
}
