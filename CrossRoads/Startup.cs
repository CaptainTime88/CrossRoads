using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrossRoads.Startup))]
namespace CrossRoads
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
