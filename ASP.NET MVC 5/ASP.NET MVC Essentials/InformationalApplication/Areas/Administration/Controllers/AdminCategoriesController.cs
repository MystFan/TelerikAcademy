using InformationalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace InformationalApplication.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminCategoriesController : Controller
    {
        // GET: Administration/AdminCategories
        public ActionResult AllCategories()
        {
            // Just for homework
            ApplicationDbContext db = new ApplicationDbContext();
            var categories = db.Categories.ToList();

            return View(categories);
        }

        public ActionResult Delete(int categoryId)
        {
            // Just for homework
            ApplicationDbContext db = new ApplicationDbContext();
            var categoryToDelete = db.Categories.FirstOrDefault(c => c.Id == categoryId);

            if (categoryToDelete != null)
            {
                db.Categories.Remove(categoryToDelete);
                db.SaveChanges();
            }

            return RedirectToAction("AllCategories");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string name)
        {
            // Just for homework
            ApplicationDbContext db = new ApplicationDbContext();

            if(name != null)
            {
                var category = new Category
                {
                    Name = name
                };

                db.Categories.Add(category);
                db.SaveChanges();
            }

            return RedirectToAction("AllCategories");
        }
    }
}