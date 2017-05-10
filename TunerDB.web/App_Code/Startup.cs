using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TunerDB.web.Startup))]
namespace TunerDB.web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
