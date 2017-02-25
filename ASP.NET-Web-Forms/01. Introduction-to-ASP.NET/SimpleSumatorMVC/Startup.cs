using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleSumatorMVC.Startup))]
namespace SimpleSumatorMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
