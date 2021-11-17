using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuoiTH2.Startup))]
namespace BuoiTH2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
