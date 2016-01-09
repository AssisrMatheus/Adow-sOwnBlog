using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Adow_sOwnBlog.Startup))]
namespace Adow_sOwnBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
