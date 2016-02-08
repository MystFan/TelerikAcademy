namespace TwitterLikeSystem.Services.Contracts
{
    using System;
    using System.Linq;
    using TwitterLikeSystem.Models;

    public interface ITweetsService
    {
        IQueryable<Tweet> GetAll();

        void Add(string title, string content, string tags, string userId);

        IQueryable<Tweet> GetByTagName(string tagName);

        void Update(int id, string title, string content, DateTime createdOn);

        void Delete(int id);
    }
}
