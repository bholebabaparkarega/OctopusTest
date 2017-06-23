using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctopusTest.Startup))]
namespace OctopusTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //checkout
        }
    }
}
