namespace LibrarySystem.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Caching;
    using System.Linq;
    using System.Web.Mvc;

    using LibrarySystem.Web.Models.Categories;
    using LibrarySystem.Web.Mappings;
    using LibrarySystem.Services.Contracts;

    public class CategoriesController : Controller
    {
        private const string CategoriesKey = "Categories";

        private ICategoriesService categories;

        public CategoriesController(ICategoriesService categoriesService)
        {
            this.categories = categoriesService;
        }

        public ActionResult All()
        {
            return View(GetCategories());
        }

        public ActionResult GetAll()
        {
            return PartialView("_CategoriesPartial", GetCategories());
        }

        private IList<CategoryViewModel> GetCategories()
        {
            IList<CategoryViewModel> allCategories = null;

            if (this.HttpContext.Cache[CategoriesKey] == null)
            {
                DateTime cacheCategoriesDate = DateTime.Now.AddMinutes(10);
                allCategories = this.categories
                    .GetAll()
                    .MapTo<CategoryViewModel>()
                    .ToList();

                this.HttpContext.Cache.Insert(
                    CategoriesKey,
                    allCategories,
                    null,
                    cacheCategoriesDate,
                    TimeSpan.Zero,
                    CacheItemPriority.Default,
                    null);
            }
            else
            {
                allCategories = (List<CategoryViewModel>)this.HttpContext.Cache[CategoriesKey];
            }

            return allCategories;
        }
    }
}