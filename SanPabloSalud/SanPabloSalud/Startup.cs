using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SanPabloSalud.Startup))]
namespace SanPabloSalud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
