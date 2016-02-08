namespace TwitterLikeSystem.Web.Areas.Admin.Models.Tweets
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using TwitterLikeSystem.Common;
    using TwitterLikeSystem.Models;
    using AutoMapper;
    using Mappings;


    public class TweetAdminViewModel : IMapFrom<Tweet>, IHaveCustomMappings
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ValidationModelConstants.TweetTitleMaxLength, MinimumLength = ValidationModelConstants.TweetTitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(ValidationModelConstants.TweetContentMaxLength, MinimumLength = ValidationModelConstants.TweetContentMinLength)]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreate { get; set; }

        public string UserId { get; set; }

        public IList<string> TagsList { get; set; }

        public string TagsString
        {
            get
            {
                if(this.TagsList != null)
                {
                    return string.Join(" ", this.TagsList);
                }

                return string.Empty;
            }

            set
            {
                this.TagsList = new List<string>();
                this.TagsList.Add(value);
            }
        }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Tweet, TweetAdminViewModel>()
                .ForMember(tvm => tvm.TagsList, opt => opt.MapFrom(t => t.Tags.Select(tag => tag.Text)));
        }
    }
}