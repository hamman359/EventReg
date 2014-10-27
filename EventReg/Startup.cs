using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventReg.Startup))]
namespace EventReg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
