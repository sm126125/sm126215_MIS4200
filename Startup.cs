﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sm126215_MIS4200.Startup))]
namespace sm126215_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
