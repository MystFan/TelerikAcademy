namespace LibrarySystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string ISBN { get; set; }

        [Required]
        public string ShortReview { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}
