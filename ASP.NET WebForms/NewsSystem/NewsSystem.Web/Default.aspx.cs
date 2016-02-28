using NewsSystem.Web.Data;
using NewsSystem.Web.Models;
using NewsSystem.Web.Services.Contracts;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem.Web
{
    public partial class _Default : Page
    {
        [Inject]
        public IArticlesService ArticlesService { get; set; }

        [Inject]
        public ICategoriesService CategoriesService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Article> ListViewArticles_GetData()
        {
            return ArticlesService
                .All()
                .OrderBy(a => a.Likes.Count)
                .Take(3);
        }

        public IQueryable<CategoryHomeViewModel> ListViewCategories_GetData()
        {
            return CategoriesService.All()
                .Select(c => new CategoryHomeViewModel
                {
                    CategoryName = c.Name,
                    Articles = c.Articles.Take(3).ToList()
                }).AsQueryable();
        }
    }
}