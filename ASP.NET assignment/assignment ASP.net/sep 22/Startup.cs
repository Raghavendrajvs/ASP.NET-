using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sep_22.Startup))]
namespace sep_22
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
