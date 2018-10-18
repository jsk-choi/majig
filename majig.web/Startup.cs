using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(majig.web.Startup))]
namespace majig.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
