using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoApp2.Startup))]
namespace DemoApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
