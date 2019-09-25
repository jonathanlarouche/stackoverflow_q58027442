using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(_58027442.Startup))]

namespace _58027442
{
    public class Startup
    {
        
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
