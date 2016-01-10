using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Adow_sOwnBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "All articles",
                url: "articles/",
                defaults: new  { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "Category Specific",
                url: "articles/{category}",
                defaults: new { controller = "Home", action = "showCategory", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Article Specific",
                url: "articles/{category}/{title}",
                defaults: new { controller = "Home", action = "showArticle" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
