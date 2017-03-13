using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Milestone21Music.Startup))]
namespace Milestone21Music
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
