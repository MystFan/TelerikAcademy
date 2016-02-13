namespace LibrarySystem.Services
{
    using System.Linq;
    using LibrarySystem.Models;
    using LibrarySystem.Data.Repositories;
    using LibrarySystem.Services.Contracts;

    public class CategoriesService : ICategoriesService
    {
        private IRepository<Category> categories;

        public CategoriesService(IRepository<Category> categoriesRepo)
        {
            this.categories = categoriesRepo;
        }

        public IQueryable<Category> GetAll()
        {
            return this.categories.All();
        }
    }
}
