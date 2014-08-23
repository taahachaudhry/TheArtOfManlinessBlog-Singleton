using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogSingleton.Startup))]
namespace BlogSingleton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
