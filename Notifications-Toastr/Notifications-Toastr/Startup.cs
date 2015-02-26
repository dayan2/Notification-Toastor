using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Notifications_Toastr.Startup))]
namespace Notifications_Toastr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
