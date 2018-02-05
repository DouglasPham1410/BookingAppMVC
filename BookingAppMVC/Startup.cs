using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookingAppMVC.Startup))]
namespace BookingAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
