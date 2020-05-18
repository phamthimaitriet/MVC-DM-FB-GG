using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Demo_Login_FB_GG_MCTeam.Startup))]
namespace MVC_Demo_Login_FB_GG_MCTeam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
