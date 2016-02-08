using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterLikeSystem.Web.Startup))]
namespace TwitterLikeSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
