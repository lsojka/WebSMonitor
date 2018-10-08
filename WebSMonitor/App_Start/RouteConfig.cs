using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebSMonitor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // route for adress
            // http://localhost:57756 /Home/Index
            // TBD
            /*
            routes.MapRoute(
                name: "HomeToIndex",
                url: ""

            );
            */
            // http://localhost:57756 /Projector/Index
/*            
            routes.MapRoute(
                name: "Projector",
                url: "projector/{id}",
                defaults: new { controller = "Projector", action = "Index" }
            );
            */
            /*
            routes.MapRoute(
                name: "ProjectorPane",
                url: "projector/projectorpane",
                defaults: new { controller = "Projector", action = "ProjectorPane" }
                );
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
