namespace InformationalApplication.Infrastructure
{
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using InformationalApplication.Models;

    public class Seed
    {
        public static void SeedData()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            string roleName = "Admin";
            IdentityResult roleResult;

            if (!RoleManager.RoleExists(roleName))
            {
                roleResult = RoleManager.Create(new IdentityRole(roleName));
                PasswordHasher hasher = new PasswordHasher();
                var admin = new ApplicationUser
                {
                    Email = "admin@site.com",
                    PasswordHash = hasher.HashPassword("admin"),
                    UserName = "admin@site.com"
                };
                
               
                context.Users.Add(admin);
                context.SaveChanges();
                UserManager.UpdateSecurityStamp(admin.Id);

                UserManager.AddToRole(admin.Id, roleName);
            }

            if (!context.Categories.Any())
            {
                string[] categories = new string[]
                {
                    "Foods", "Sport", "Drinks", "Free Time", "Computers"
                };

                for (int i = 0; i < categories.Length; i++)
                {
                    context.Categories.Add(new Category
                    {
                        Name = categories[i]
                    });
                }

                context.SaveChanges();
            }
        }
    }
}