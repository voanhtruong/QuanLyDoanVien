using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuanLyDoanVienProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                  name: "Login",
                  url: "Verify",
                  defaults: new { controller = "Account", action = "Verify", id = UrlParameter.Optional }
              );
            
            routes.MapRoute(
                   name: "thong tin ca nhan",
                   url: "infor",
                   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "dang ky hoat dong",
                   url: "dang-ky-hoat-dong",
                   defaults: new { controller = "DangKyChuongTrinh", action = "DangKyChuongTrinh", id = UrlParameter.Optional }
               );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
