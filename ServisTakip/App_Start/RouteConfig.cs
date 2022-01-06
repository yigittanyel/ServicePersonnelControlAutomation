using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ServisTakip
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "GirisYap", action = "Giris", id = UrlParameter.Optional }
                defaults: new { controller = "Kisi", action = "KisiListele", id = UrlParameter.Optional }
            );
        }
    }
}
