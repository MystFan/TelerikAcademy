namespace TwitterLikeSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common;

    public class Tweet
    {
        private ICollection<Tag> tags;
        private ICollection<Comment> comments;

        public Tweet()
        {
            this.tags = new HashSet<Tag>();
            this.comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationModelConstants.TweetTitleMaxLength, MinimumLength = ValidationModelConstants.TweetTitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(ValidationModelConstants.TweetContentMaxLength, MinimumLength = ValidationModelConstants.TweetContentMinLength)]
        public string Content { get; set; }

        [Required]
        public DateTime DateCreate { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }
    }
}
