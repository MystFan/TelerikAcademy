using NewsSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Web.Services.Contracts
{
    public interface IArticlesService
    {
        IQueryable<Article> All();

        Article GetById(int id);

        void Create(string title, string content, int categoryId, string userId);

        void Update(Article article);

        void Delete(int id);

        void LikeArticle(int id, string userId);

        void DislikeArticle(int id);
    }
}
