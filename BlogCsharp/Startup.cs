using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogCsharp.Startup))]
namespace BlogCsharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
