using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VBB.Admin.Startup))]
namespace VBB.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
