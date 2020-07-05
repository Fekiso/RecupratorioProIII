using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alquiler_de_Elementos.Startup))]
namespace Alquiler_de_Elementos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
