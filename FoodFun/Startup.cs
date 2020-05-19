using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodFun.Startup))]
namespace FoodFun
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
