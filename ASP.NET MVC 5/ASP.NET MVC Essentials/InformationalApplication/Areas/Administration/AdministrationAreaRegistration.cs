using InformationalApplication.Infrastructure;
using System.Web.Mvc;

namespace InformationalApplication.Areas.Administration
{
    public class AdministrationAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Administration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: "Administration_default",
                url: "Administration/{controller}/{action}",
                defaults: new { controller = "Admin", action = "Index" },
                constraints: new LocalhostConstraint()
            );
        }
    }
}