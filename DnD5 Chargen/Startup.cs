using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnD5_Chargen.Startup))]
namespace DnD5_Chargen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
