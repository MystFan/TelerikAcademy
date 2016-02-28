using NewsSystem.Web.Models;
using NewsSystem.Web.Services.Contracts;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using System.Linq.Dynamic;
using System.Web.ModelBinding;

namespace NewsSystem.Web.Admin
{
    public partial class Articles : System.Web.UI.Page
    {
        [Inject]
        public IArticlesService ArticlesService { get; set; }

        [Inject]
        public ICategoriesService CategoriesService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Article> ListViewAericles_GetData([QueryString]string orderBy)
        {
            var result = this.ArticlesService.All();

            result = string.IsNullOrEmpty(orderBy) ? result.OrderBy(a => a.Id) : result.OrderBy(orderBy + " Ascending");

            return result;
        }

        public void ListViewAericles_InsertItem()
        {
            var item = new Article();
            string title = ((TextBox)this.ListViewArticles.InsertItem.FindControl("TextBoxInsert")).Text;
            string content = ((TextBox)this.ListViewArticles.InsertItem.FindControl("TextBoxContentInsert")).Text;
            int categoryId = int.Parse(((DropDownList)this.ListViewArticles.InsertItem.FindControl("DropDownListCategoriesInsert")).SelectedValue);

            TryUpdateModel(item);

            this.ArticlesService.Create(title, content, categoryId, this.User.Identity.GetUserId());
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewAericles_DeleteItem(int id)
        {
            this.ArticlesService.Delete(id);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void ListViewAericles_UpdateItem(int id)
        {
            Article article = new Article();
            string title = ((TextBox)this.ListViewArticles.EditItem.FindControl("TextBoxUpdate")).Text;
            string content = ((TextBox)this.ListViewArticles.EditItem.FindControl("TextBoxContent")).Text;
            int categoryId = int.Parse(((DropDownList)this.ListViewArticles.EditItem.FindControl("DropDownListCategories")).SelectedValue);

            article.Title = title;
            article.Content = content;
            article.CategoryId = categoryId;
            article.Id = id;

            this.ArticlesService.Update(article);

            TryUpdateModel(article);

            
        }

        protected void ButtonNewArticle_Click(object sender, EventArgs e)
        {
            ListViewArticles.InsertItemPosition = InsertItemPosition.FirstItem;
        }

        protected void ListViewArticles_ItemCanceling(object sender, ListViewCancelEventArgs e)
        {
            if (e.CancelMode == ListViewCancelMode.CancelingInsert)
            {
                ListViewArticles.InsertItemPosition = InsertItemPosition.None;
            }
            else if(e.CancelMode == ListViewCancelMode.CancelingEdit)
            {
                ListViewArticles.EditIndex = -1;
            }
        }

        public IQueryable<Category> GetCategories()
        {
            return this.CategoriesService.All();
        }
    }
}