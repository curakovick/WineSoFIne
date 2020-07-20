using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WineSoFine.Startup))]
namespace WineSoFine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
