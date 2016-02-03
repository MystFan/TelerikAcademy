using InformationalApplication.Models;
using InformationalApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace InformationalApplication.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        [ActionName("All")]
        public ActionResult ListProducts()
        {
            // Just for homework
            ApplicationDbContext db = new ApplicationDbContext();
            var products = db.Products.Include("Category").ToList();

            return View(products);
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(ProductInputModel product)
        {
            // Just for homework
            ApplicationDbContext db = new ApplicationDbContext();

            if (!this.ModelState.IsValid)
            {
                return View(product);
            }

            var newProduct = new Product
            {
                Name = product.Name,
                CategoryId = product.CategoryId
            };

            db.Products.Add(newProduct);
            db.SaveChanges();

            return RedirectToAction("All");
        }

        [ChildActionOnly]
        public ActionResult GetProductCategories()
        {
            // Just for homework
            ApplicationDbContext db = new ApplicationDbContext();
            var categories = db.Categories.ToList();

            return PartialView("_CategoriesPartial", categories);
        }
    }
}