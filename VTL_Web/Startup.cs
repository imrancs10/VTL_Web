using Microsoft.Owin;
using Microsoft.Owin.Builder;
using Owin;

[assembly: OwinStartupAttribute(typeof(VTL_Web.Startup))]
namespace VTL_Web
{
    public partial class Startup
    {
        public void Configuration(AppBuilder app)
        {
        }
    }
}
