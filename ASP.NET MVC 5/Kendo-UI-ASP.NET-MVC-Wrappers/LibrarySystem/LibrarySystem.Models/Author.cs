namespace LibrarySystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Author
    {
        private ICollection<Book> books;

        public Author()
        {
            this.books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Book> Books
        {
            get
            {
                return books;
            }

            set
            {
                books = value;
            }
        }
    }
}
