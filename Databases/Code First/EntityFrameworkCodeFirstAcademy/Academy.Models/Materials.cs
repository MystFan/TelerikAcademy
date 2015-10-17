namespace Academy.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Material
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
