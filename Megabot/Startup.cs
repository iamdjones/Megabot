using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Megabot.Startup))]
namespace Megabot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
