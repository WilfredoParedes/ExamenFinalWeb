using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBooks2010.Startup))]
namespace WebBooks2010
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
