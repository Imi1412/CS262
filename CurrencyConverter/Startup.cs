﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CurrencyConverter.Startup))]
namespace CurrencyConverter
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
