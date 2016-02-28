using NewsSystem.Web.Models;
using NewsSystem.Web.Services.Contracts;
using Ninject;
using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewsSystem.Web
{
    public partial class ArticleDetails : System.Web.UI.Page
    {

        [Inject]
        public IArticlesService ArticlesService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Article DetailsView_GetItem()
        {
            int id = Convert.ToInt16(Request.Params["id"]);

            return this.ArticlesService.GetById(id);
        }

        protected void LikeButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.Params["id"]);

            if (User.Identity.IsAuthenticated && Request.Params["id"] != null)
            {
                string userId = this.User.Identity.GetUserId();


                this.ArticlesService.LikeArticle(id, userId);
                this.DetailsViewLikes.Fields[0].HeaderText = this.ArticlesService.GetById(id).Likes.Count.ToString();
            }

            
        }

        protected void DislikeButton_Click(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated && Request.Params["id"] != null)
            {
                int id = Convert.ToInt16(Request.Params["id"]);
                this.ArticlesService.DislikeArticle(id);
            }   
        }
    }
}