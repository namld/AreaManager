using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AreaManager.Startup))]
namespace AreaManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
