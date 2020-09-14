using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prueba1adm.Startup))]
namespace prueba1adm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
