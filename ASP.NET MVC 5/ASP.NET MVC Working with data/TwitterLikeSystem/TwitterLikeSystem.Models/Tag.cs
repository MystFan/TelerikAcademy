namespace TwitterLikeSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    using Common;

    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationModelConstants.TagTextMaxLength, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = ValidationModelConstants.TagTextMinLength)]
        public string Text { get; set; }

        public int TweetId { get; set; }

        public virtual Tweet Tweet { get; set; }
    }
}