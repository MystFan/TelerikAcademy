namespace TwitterLikeSystem.Web.ViewModels.Tweets
{
    using System.ComponentModel.DataAnnotations;
    using TwitterLikeSystem.Common;

    public class TweetInputModel
    {
        [Required]
        [Display(Name = "Tweet title")]
        [StringLength(ValidationModelConstants.TweetTitleMaxLength, MinimumLength = ValidationModelConstants.TweetTitleMinLength)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Your tweet")]
        [DataType(DataType.MultilineText)]
        [StringLength(ValidationModelConstants.TweetContentMaxLength, MinimumLength = ValidationModelConstants.TweetContentMinLength)]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Hashtags")]
        [MinLength(2)]
        [RegularExpression("[#A-Za-z0-9 _]+")]
        public string Tags { get; set; }
    }
}