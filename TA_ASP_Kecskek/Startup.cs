using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TA_ASP_Kecskek.Startup))]
namespace TA_ASP_Kecskek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
