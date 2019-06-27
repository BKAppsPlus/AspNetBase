using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityModel01.Startup))]
namespace IdentityModel01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
