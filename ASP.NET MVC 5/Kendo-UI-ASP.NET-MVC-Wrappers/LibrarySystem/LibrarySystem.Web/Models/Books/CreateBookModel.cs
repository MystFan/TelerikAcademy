namespace LibrarySystem.Web.Models.Books
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateBookModel
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string ISBN { get; set; }

        [Required]
        public string ShortReview { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string AuthorName { get; set; }
    }
}