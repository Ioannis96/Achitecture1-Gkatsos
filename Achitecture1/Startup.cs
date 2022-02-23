using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Achitecture1.Startup))]
namespace Achitecture1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
