using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySample.Startup))]
namespace MySample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
