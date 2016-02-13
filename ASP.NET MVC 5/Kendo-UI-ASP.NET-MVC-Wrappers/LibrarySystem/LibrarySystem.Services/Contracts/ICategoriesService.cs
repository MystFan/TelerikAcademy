namespace LibrarySystem.Services.Contracts
{
    using System.Linq;
    using LibrarySystem.Models;

    public interface ICategoriesService
    {
        IQueryable<Category> GetAll();
    }
}
