using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TMDT_Lab4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id =UrlParameter.Optional
                });
            routes.MapRoute(
                name: "Default",
                url: "web/{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id =UrlParameter.Optional
                }
            );
        }
    }
}
