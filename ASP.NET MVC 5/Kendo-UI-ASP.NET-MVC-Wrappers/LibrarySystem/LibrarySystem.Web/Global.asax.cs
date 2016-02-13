using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LibrarySystem.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            DatabaseConfig.Initialize();

            AutoMapperConfig automapperConfig = new AutoMapperConfig();
            automapperConfig.Execute(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
