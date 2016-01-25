namespace ToDoSystem.Services.Common
{
    using System.Linq;
    using ToDoSystem.Models;

    public interface ICategoriesService
    {
        IQueryable<Category> All();

        void Add(string name);
    }
}
