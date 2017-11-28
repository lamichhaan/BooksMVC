using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LamichhaneAngat_BooksMVC.Startup))]
namespace LamichhaneAngat_BooksMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
