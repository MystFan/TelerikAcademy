namespace ToDoSystem.Services
{
    using System;
    using Models;
    using ToDoSystem.Services.Common;
    using Data.Repositories;
    using Data;
    using System.Data.Entity;
    using System.Linq;

    public class ToDoService : IToDoService
    {
        private IRepository<ToDo> todos;
        private IRepository<Category> categories;

        public ToDoService()
        {
            var db = new ToDoDbContext();
            this.todos = new EfGenericRepository<ToDo>(db);
            this.categories = new EfGenericRepository<Category>(db);
        }

        public void Add(string title, string body, int categoryId)
        {
            var newToDo = new ToDo()
            {
                Title = title,
                Body = body,
                LastChangeDate = DateTime.Now
            };

            var category = this.categories.GetById(categoryId);
            newToDo.Category = category;

            this.todos.Add(newToDo);
            this.todos.SaveChanges();
        }

        public IQueryable<ToDo> All()
        {
            return this.todos.All().Include("Category");
        }

        public ToDo GetById(int id)
        {
            return this.todos.GetById(id);
        }

        public void DeleteById(int id)
        {
            var todo = this.todos.GetById(id);
            this.todos.Delete(todo);
            this.todos.SaveChanges();
        }

        public ToDo Update(int id, string title, string body, int categoryId)
        {
            var todo = this.todos.GetById(id);
            var category = this.categories.GetById(categoryId);
            todo.Title = title;
            todo.Body = body;
            todo.Category = category;
            todo.LastChangeDate = DateTime.Now;

            todos.Update(todo);
            todos.SaveChanges();

            return todo;
        }
    }
}
