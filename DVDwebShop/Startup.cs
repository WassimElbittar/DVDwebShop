using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVDwebShop.Startup))]
namespace DVDwebShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
