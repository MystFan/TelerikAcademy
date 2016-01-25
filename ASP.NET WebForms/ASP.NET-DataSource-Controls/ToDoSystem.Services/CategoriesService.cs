namespace ToDoSystem.Services
{
    using System.Linq;
    using Data;
    using Data.Repositories;
    using ToDoSystem.Models;
    using ToDoSystem.Services.Common;

    public class CategoriesService : ICategoriesService
    {
        private IRepository<Category> categories;

        public CategoriesService()
        {
            this.categories = new EfGenericRepository<Category>(new ToDoDbContext());
        }

        public void Add(string name)
        {
            var category = new Category()
            {
                Name = name
            };

            this.categories.Add(category);
            this.categories.SaveChanges();
        }

        public IQueryable<Category> All()
        {
            return this.categories.All();
        }
    }
}
