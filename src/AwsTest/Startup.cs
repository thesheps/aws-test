﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AwsTest.Startup))]

namespace AwsTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
