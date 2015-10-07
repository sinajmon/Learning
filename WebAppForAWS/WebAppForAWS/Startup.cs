using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppForAWS.Startup))]
namespace WebAppForAWS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
