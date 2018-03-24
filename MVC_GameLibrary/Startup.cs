using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_GameLibrary.Startup))]
namespace MVC_GameLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
