namespace InformationalApplication.Infrastructure
{
    using System.Web;
    using System.Web.Routing;

    public class LocalhostConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext,
            Route route,
            string parameterName,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            if (values["controller"].ToString().IndexOf("Admin") >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}