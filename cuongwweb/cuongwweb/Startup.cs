using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cuongwweb.Startup))]
namespace cuongwweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
