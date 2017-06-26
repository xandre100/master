using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(intcom.web.Startup))]
namespace intcom.web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
