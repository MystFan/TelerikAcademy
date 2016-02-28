using NewsSystem.Web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsSystem.Web.Models;
using NewsSystem.Web.Data.Repositories;
using Microsoft.AspNet.Identity;

namespace NewsSystem.Web.Services
{
    public class ArticlesService : IArticlesService
    {
        private IRepository<Article> articles;
        private IRepository<Like> likes;

        public ArticlesService(IRepository<Article> articles, IRepository<Like> likes)
        {
            this.articles = articles;
            this.likes = likes;
        }

        public IQueryable<Article> All()
        {
            return articles.All();
        }

        public void Create(string title, string content, int categoryId, string userId)
        {
            var article = new Article
            {
                Title = title,
                Content = content,
                CreatedOn = DateTime.UtcNow,
                CategoryId = categoryId,
                UserId = userId
            };

            this.articles.Add(article);
            this.articles.SaveChanges();
        }

        public void Delete(int id)
        {
            this.articles.Delete(id);
            this.articles.SaveChanges();
        }

        public void DislikeArticle(int id)
        {
            var like = this.likes
                .All()
                .FirstOrDefault(l => l.ArticleID == id);

            this.likes.Delete(like);
            this.likes.SaveChanges();
        }

        public Article GetById(int id)
        {
            return this.articles.GetById(id);
        }

        public void LikeArticle(int id, string userId)
        {
            var article = this.articles.GetById(id);
            var like = this.likes.All().FirstOrDefault(l => l.UserID == userId);

            if(like == null)
            {
                article.Likes.Add(new Like()
                {
                    Value = 1,
                    UserID = userId
                });

                this.articles.SaveChanges();
            }
        }

        public void Update(Article article)
        {
            var dbArticle = this.articles.GetById(article.Id);

            if(dbArticle != null)
            {
                dbArticle.Title = article.Title;
                dbArticle.Content = article.Content;
                dbArticle.CategoryId = article.CategoryId;

                this.articles.Update(dbArticle);
                this.articles.SaveChanges();
            }
        }
    }
}