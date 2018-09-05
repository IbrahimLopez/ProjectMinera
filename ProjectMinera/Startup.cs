using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectMinera.Startup))]
namespace ProjectMinera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
