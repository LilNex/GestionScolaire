using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using GestionScolaire.BD;

[assembly: OwinStartup(typeof(GestionScolaire.Startup))]

namespace GestionScolaire
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            clsConnection.Init();

        }
    }
}
