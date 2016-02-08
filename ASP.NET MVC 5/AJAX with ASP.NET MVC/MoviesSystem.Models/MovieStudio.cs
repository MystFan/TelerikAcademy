namespace MoviesSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class MovieStudio
    {
        private ICollection<Movie> movies;

        public MovieStudio()
        {
            this.Movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        public virtual ICollection<Movie> Movies
        {
            get
            {
                return movies;
            }

            set
            {
                movies = value;
            }
        }
    }
}
