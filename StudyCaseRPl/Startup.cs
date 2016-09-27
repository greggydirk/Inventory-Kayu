using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyCaseRPl.Startup))]
namespace StudyCaseRPl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
