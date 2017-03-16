using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VBB.Web.Startup))]
namespace VBB.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
