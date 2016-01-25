using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shagrirs.Startup))]
namespace Shagrirs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
