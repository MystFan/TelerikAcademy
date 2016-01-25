namespace ToDoListSystem
{
    using System;
    using System.Linq;
    using System.Data.Entity;
    using ToDoSystem.Data;
    using ToDoSystem.Models;
    using ToDoSystem.Data.Migrations;
    using ToDoSystem.Services;
    using ToDoSystem.Services.Common;

    public partial class TODOlist : System.Web.UI.Page
    {
        protected IToDoService ToDoService { get; set; }

        protected ICategoriesService CategoriesService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ToDoService = new ToDoService();
            this.CategoriesService = new CategoriesService();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ToDoDbContext, Configuration>());
            ToDoDbContext.Create().Database.Initialize(true);
        }

        protected void ButtonAddToDo_Click(object sender, EventArgs e)
        {
            var title = this.TextBoxToDoTitle.Text;
            var content = this.TextAriaToDoBody.Value;
            int categoryId = int.Parse(this.DropDownListCategories.SelectedValue);

            this.ToDoService.Add(title, content, categoryId);
            this.Response.Redirect("~/AddTODO.aspx");
        }

        public IQueryable<Category> GetCategories()
        {
            return this.CategoriesService.All();
        }
    }
}