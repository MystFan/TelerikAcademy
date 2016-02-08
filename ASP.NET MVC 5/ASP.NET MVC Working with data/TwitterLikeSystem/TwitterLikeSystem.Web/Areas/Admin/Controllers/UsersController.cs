namespace TwitterLikeSystem.Web.Areas.Admin.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNet.Identity;
    using TwitterLikeSystem.Models;
    using TwitterLikeSystem.Services.Contracts;
    using TwitterLikeSystem.Web.Areas.Admin.Models.Account;
    using TwitterLikeSystem.Web.Models;

    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private IUsersService users;

        public UsersController(IUsersService users)
        {
            this.users = users;
        }

        // GET: Admin/Users
        public ActionResult Index()
        {
            var allUsers = this.users
                .GetAll()
                .ProjectTo<UserAdminViewModel>()
                .ToList();

            return View(allUsers);
        }

        // GET: Admin/Users/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            UserAdminViewModel user = this.users
                .GetAll()
                .ProjectTo<UserAdminViewModel>()
                .FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                PasswordHasher hasher = new PasswordHasher();

                var user = new User
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    PasswordHash = hasher.HashPassword(model.Password)
                };

                this.users.Add(user);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Admin/Users/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            UserAdminViewModel user = this.users
                .GetAll()
                .ProjectTo<UserAdminViewModel>()
                .FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserAdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = this.users.GetById(model.Id);
                user.Email = model.Email;
                user.EmailConfirmed = model.EmailConfirmed;
                user.UserName = model.UserName;
                user.PhoneNumber = model.PhoneNumber;
                user.PhoneNumberConfirmed = model.PhoneNumberConfirmed;
                this.users.Update(user);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Admin/Users/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            UserAdminViewModel user = this.users
                .GetAll()
                .ProjectTo<UserAdminViewModel>()
                .FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        // POST: Admin/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            this.users.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
