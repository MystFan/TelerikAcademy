namespace TwitterLikeSystem.Services
{
    using System;
    using System.Linq;
    using TwitterLikeSystem.Data.Repositories;
    using TwitterLikeSystem.Models;
    using TwitterLikeSystem.Services.Contracts;

    public class UsersService : IUsersService
    {
        private IRepository<User> users;

        public UsersService(IRepository<User> users)
        {
            this.users = users;
        }

        public void Add(User user)
        {
            this.users.Add(user);
            this.users.SaveChanges();
        }

        public void Delete(string id)
        {
            var user = this.users.GetById(id);
            this.users.Delete(user);
            this.users.SaveChanges();
        }

        public IQueryable<User> GetAll()
        {
            return this.users.All();
        }

        public User GetById(string id)
        {
            return this.users.GetById(id);
        }

        public void Update(User user)
        {
            this.users.Update(user);
            this.users.SaveChanges();
        }
    }
}
