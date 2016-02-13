namespace LibrarySystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        private ICollection<Book> books;

        public Category()
        {
            this.books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
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
