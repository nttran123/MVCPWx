using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPWx.Startup))]
namespace MVCPWx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
