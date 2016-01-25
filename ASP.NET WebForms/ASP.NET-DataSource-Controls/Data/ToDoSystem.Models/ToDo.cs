namespace ToDoSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Body { get; set; }

        public DateTime LastChangeDate { get; set; }

        public Category Category { get; set; }
    }
}
