using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shopping_cart.Startup))]
namespace Shopping_cart
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
