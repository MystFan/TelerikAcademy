namespace LibrarySystem.Services.Contracts
{
    using System.Linq;
    using LibrarySystem.Models;

    public interface IBooksService
    {
        IQueryable<Book> GetAll();

        IQueryable<Book> GetAll(int page, int pageSize);

        IQueryable<Book> GetByTitle(string title);

        void Delete(int id);

        void Update(int id, string title, string content, string ISBN);

        void Add(string title, string review, string ISBN, string userId, string author, int categoryId);
    }
}
