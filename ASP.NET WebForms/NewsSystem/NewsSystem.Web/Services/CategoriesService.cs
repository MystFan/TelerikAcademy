using NewsSystem.Web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsSystem.Web.Models;
using NewsSystem.Web.Data.Repositories;

namespace NewsSystem.Web.Services
{
    public class CategoriesService : ICategoriesService
    {
        private IRepository<Category> categories;

        public CategoriesService(IRepository<Category> categories)
        {
            this.categories = categories;
        }

        public IQueryable<Category> All()
        {
            return categories.All();
        }
    }
}