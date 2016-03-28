using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VersteigerungWebAnwendung.Startup))]
namespace VersteigerungWebAnwendung
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
