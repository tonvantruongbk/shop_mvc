using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESHOP.Startup))]
namespace ESHOP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
