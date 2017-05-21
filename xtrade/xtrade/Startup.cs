using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xtrade.Startup))]
namespace xtrade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
