using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebHandler.Startup))]
namespace WebHandler
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
