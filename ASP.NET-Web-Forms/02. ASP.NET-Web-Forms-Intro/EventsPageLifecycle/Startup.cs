using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventsPageLifecycle.Startup))]
namespace EventsPageLifecycle
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
