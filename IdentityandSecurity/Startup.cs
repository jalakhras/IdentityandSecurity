using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityandSecurity.Startup))]
namespace IdentityandSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
