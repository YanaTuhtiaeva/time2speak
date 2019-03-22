using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(timetospeak.Startup))]
namespace timetospeak
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
