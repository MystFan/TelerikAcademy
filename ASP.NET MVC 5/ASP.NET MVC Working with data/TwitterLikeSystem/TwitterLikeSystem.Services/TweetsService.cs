namespace TwitterLikeSystem.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using TwitterLikeSystem.Data.Repositories;
    using TwitterLikeSystem.Models;
    using TwitterLikeSystem.Services.Contracts;

    public class TweetsService : ITweetsService
    {
        private IRepository<Tweet> tweets;

        public TweetsService(IRepository<Tweet> tweets)
        {
            this.tweets = tweets;
        }

        public void Add(string title, string content, string tags, string userId)
        {
            var newTweet = new Tweet
            {
                Title = title,
                Content = content,
                DateCreate = DateTime.Now,
                Tags = GetTags(tags),
                UserId = userId
            };

            this.tweets.Add(newTweet);
            this.tweets.SaveChanges();
        }

        public void Delete(int id)
        {
            this.tweets.Delete(id);
            this.tweets.SaveChanges();
        }

        public IQueryable<Tweet> GetAll()
        {
            return this.tweets.All();
        }

        public IQueryable<Tweet> GetByTagName(string tagName)
        {
            return
                this.tweets
                .All()
                .Where(t => t.Tags.FirstOrDefault(v => v.Text.Substring(1).ToLower() == tagName) != null);
        }

        public void Update(int id, string title, string content, DateTime createdOn)
        {
            var dbTweet = this.tweets.GetById(id);

            dbTweet.Title = title;
            dbTweet.Content = content;
            dbTweet.DateCreate = createdOn;

            this.tweets.Update(dbTweet);
            this.tweets.SaveChanges();
        }

        private ICollection<Tag> GetTags(string tagsText)
        {
            Regex regex = new Regex(@"(#)((?:[A-Za-z0-9-_]*))");

            List<Tag> tags = new List<Tag>();
            foreach (Match match in regex.Matches(tagsText))
            {
                var value = match.Value;
                tags.Add(new Tag
                {
                    Text = value
                });
            }

            return tags;
        }
    }
}
