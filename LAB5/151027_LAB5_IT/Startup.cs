using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_151027_LAB5_IT.Startup))]
namespace _151027_LAB5_IT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
