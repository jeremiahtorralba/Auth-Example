using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Auth_Example.Startup))]
namespace Auth_Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
