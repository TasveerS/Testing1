using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkWithNowey.Startup))]
namespace WorkWithNowey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
