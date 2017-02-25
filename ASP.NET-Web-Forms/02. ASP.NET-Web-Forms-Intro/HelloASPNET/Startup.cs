using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloASPNET.Startup))]
namespace HelloASPNET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
