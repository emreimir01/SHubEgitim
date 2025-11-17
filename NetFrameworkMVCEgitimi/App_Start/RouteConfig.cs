using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NetFrameworkMVCEgitimi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", // url kısmı uygulama tarayıcıda çalıştığında 
                // site adından sonraki kısımda hangi controllerdeki hangi actionun çalışacağını ayarlar.
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // default kısmı uygulama çalıştığında
                // varsayılan anasayfa olarak hangi sayfadan çalıştırılacağını ayarlar.
            );
        }
    }
}
