﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogCMS.Web.Startup))]
namespace BlogCMS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
