namespace TwitterLikeSystem.Services.Contracts
{
    using System.Linq;
    using TwitterLikeSystem.Models;

    public interface IUsersService
    {
        IQueryable<User> GetAll();

        User GetById(string id);

        void Add(User user);

        void Update(User user);

        void Delete(string id);
    }
}
