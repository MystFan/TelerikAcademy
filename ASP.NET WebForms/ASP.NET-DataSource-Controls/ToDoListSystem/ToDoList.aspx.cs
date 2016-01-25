namespace ToDoListSystem
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.UI.WebControls;
    using ToDoSystem.Data;
    using ToDoSystem.Data.Migrations;
    using ToDoSystem.Models;
    using ToDoSystem.Services;
    using ToDoSystem.Services.Common;

    public partial class ToDoList : System.Web.UI.Page
    {
        protected IToDoService ToDoService { get; set; }

        protected ICategoriesService CategoriesService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ToDoService = new ToDoService();
            this.CategoriesService = new CategoriesService();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ToDoDbContext, Configuration>());
        }

        public IQueryable<ToDo> GetTodos()
        {
            var todos = this.ToDoService.All();
            return todos;
        }

        public void GridViewToDos_UpdateItem(int id)
        {
            string title = ((TextBox)this.ListView.EditItem.FindControl("TitleTextBox")).Text;
            string content = ((TextBox)this.ListView.EditItem.FindControl("BodyTextBox")).Text;
            int categoryId = int.Parse(((DropDownList)this.ListView.EditItem.FindControl("DropDownListCategories")).SelectedValue);

            var todo = this.ToDoService.Update(id, title, content, categoryId);

            if (todo == null)
            {
                // The item wasn't found
                ModelState.AddModelError("",
                    string.Format("To Do with id {0} was not found", id));
                return;
            }

            TryUpdateModel(todo);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewToDos_DeleteItem(int id)
        {
            this.ToDoService.DeleteById(id);
        }

        public IQueryable<Category> GetCategories()
        {
            return this.CategoriesService.All();
        }
    }
}