using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment3usingMVC.Startup))]
namespace Assignment3usingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
