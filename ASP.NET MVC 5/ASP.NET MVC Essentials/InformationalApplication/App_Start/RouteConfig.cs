namespace InformationalApplication
{
    using System.Web.Mvc;
    using System.Web.Routing;
    using InformationalApplication.Infrastructure;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "AdminRoute",
            //    url: "{controller}/{action}",
            //    defaults: new { controller = "Admin", action = "Index" },
            //    constraints: new LocalhostConstraint()
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
