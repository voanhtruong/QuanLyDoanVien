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
                   url: "me",
                   defaults: new { controller = "DoanVien", action = "DoanVien", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "dang ky chuyen sinh hoat",
                   url: "chuyen-sinh-hoat",
                   defaults: new { controller = "DangKyChuyenSinhHoat", action = "DangKyChuyenSinhHoat", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "dang ky hoat dong",
                   url: "ren-luyen",
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
