using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admPrueba1.Startup))]
namespace admPrueba1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
