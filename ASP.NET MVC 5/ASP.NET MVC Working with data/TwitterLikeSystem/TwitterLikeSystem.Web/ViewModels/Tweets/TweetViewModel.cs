namespace TwitterLikeSystem.Web.ViewModels.Tweets
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using AutoMapper;
    using TwitterLikeSystem.Models;
    using TwitterLikeSystem.Web.Mappings;

    public class TweetViewModel : IMapFrom<Tweet>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime DateCreate { get; set; }

        public string Creator { get; set; }

        public IList<string> Tags { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Tweet, TweetViewModel>()
                .ForMember(tvm => tvm.Creator, opt => opt.MapFrom(t => t.User.UserName));

            configuration.CreateMap<Tweet, TweetViewModel>()
                .ForMember(tvm => tvm.Tags, opt => opt.MapFrom(t => t.Tags.Select(tag => tag.Text)));
        }
    }
}