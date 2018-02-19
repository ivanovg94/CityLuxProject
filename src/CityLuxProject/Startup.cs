using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CityLuxProject.Startup))]
namespace CityLuxProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
