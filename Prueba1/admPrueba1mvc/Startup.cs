using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admPrueba1mvc.Startup))]
namespace admPrueba1mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
