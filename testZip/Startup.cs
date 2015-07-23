using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testZip.Startup))]
namespace testZip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
