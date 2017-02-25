using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleSumatorWebFroms.Startup))]
namespace SimpleSumatorWebFroms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
