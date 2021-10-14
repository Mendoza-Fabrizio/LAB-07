using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppMVC1.Startup))]
namespace AppMVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
