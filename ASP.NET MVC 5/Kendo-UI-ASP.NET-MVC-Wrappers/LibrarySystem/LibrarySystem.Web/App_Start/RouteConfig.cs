using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LibrarySystem.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "LibrarySystem.Web.Controllers" }
            );

            routes.MapRoute(
                name: "SearchBook",
                url: "Books/GetByTitle/{title}",
                defaults: new { controller = "Books", action = "GetByTitle", title = UrlParameter.Optional },
                namespaces: new string[] { "LibrarySystem.Web.Controllers" }
            );
        }
    }
}
