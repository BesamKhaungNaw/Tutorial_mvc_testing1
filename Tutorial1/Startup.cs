using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tutorial1.Startup))]
namespace Tutorial1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
