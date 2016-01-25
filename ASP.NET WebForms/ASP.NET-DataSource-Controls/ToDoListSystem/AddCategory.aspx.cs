namespace ToDoListSystem
{
    using System;
    using ToDoSystem.Services;
    using ToDoSystem.Services.Common;

    public partial class AddCategory : System.Web.UI.Page
    {
        protected ICategoriesService CategoriesService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CategoriesService = new CategoriesService();
        }

        protected void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = this.TextBoxCategoryName.Text;

            this.CategoriesService.Add(categoryName);
            this.Response.Redirect("~/AddCategory.aspx");
        }
    }
}