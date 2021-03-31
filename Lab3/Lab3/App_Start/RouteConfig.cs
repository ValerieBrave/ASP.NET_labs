using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"DefIndex",
                url:"{controller}/{action}/{name}",
                defaults: new {controller = "Dict", action="Index", name = UrlParameter.Optional}
                );
            //routes.MapRoute(
            //    name: "Error404",
            //    url: "{*url}",
            //    defaults: new { controller = "Dict", action = "Error" });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
