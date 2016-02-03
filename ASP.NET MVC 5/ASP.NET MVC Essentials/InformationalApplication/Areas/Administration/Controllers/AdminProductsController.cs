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
    public class AdminProductsController : Controller
    {
        // GET: Administration/AdminProducts
        public ActionResult AllProducts()
        {
            // Just for homework
            ApplicationDbContext db = new ApplicationDbContext();
            var products = db.Products.Include("Category").ToList();

            return View(products);
        }

        public ActionResult Delete(int productId)
        {
            // Just for homework
            ApplicationDbContext db = new ApplicationDbContext();
            var productToDelete = db.Products.FirstOrDefault(p => p.Id == productId);

            if(productToDelete != null)
            {
                db.Products.Remove(productToDelete);
                db.SaveChanges();
            } 

            return RedirectToAction("AllProducts");
        }
    }
}