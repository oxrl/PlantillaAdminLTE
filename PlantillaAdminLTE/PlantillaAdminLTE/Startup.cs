using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlantillaAdminLTE.Startup))]
namespace PlantillaAdminLTE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
