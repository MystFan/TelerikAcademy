namespace ToDoSystem.Services.Common
{
    using System.Linq;
    using Models;

    public interface IToDoService
    {
        void Add(string title, string body, int categoryId);

        IQueryable<ToDo> All();

        ToDo GetById(int id);

        void DeleteById(int id);

        ToDo Update(int id, string title, string body, int categoryId);
    }
}
