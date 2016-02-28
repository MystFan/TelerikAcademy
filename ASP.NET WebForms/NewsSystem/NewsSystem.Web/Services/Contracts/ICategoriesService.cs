using NewsSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Web.Services.Contracts
{
    public interface ICategoriesService
    {
        IQueryable<Category> All();
    }
}
