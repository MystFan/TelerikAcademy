namespace TwitterLikeSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Common;

    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationModelConstants.CommentContentMaxLength, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = ValidationModelConstants.CommentContentMinLength)]
        public string Content { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int TweetId { get; set; }

        public virtual Tweet Tweet { get; set; }
    }
}