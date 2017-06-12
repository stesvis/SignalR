using Owin;
using Microsoft.Owin;
[assembly: OwinStartupAttribute(typeof(SignalR.Startup))]
namespace SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}