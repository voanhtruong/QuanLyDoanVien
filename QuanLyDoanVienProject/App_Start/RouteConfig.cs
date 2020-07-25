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
                   name: "quan ly doan co so",
                   url: "doan-co-so",
                   defaults: new { controller = "QuanLyDoanCoSo", action = "QuanLyDoanCoSo", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "them doan co so",
                   url: "them-doan-co-so",
                   defaults: new { controller = "QuanLyDoanCoSo", action = "ThemDoanCoSo", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "quan ly chi doan",
                   url: "chi-doan",
                   defaults: new { controller = "QuanLyChiDoan", action = "QuanLyChiDoan", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "quan ly doan vien",
                   url: "doan-vien",
                   defaults: new { controller = "QuanLyDoanVien", action = "QuanLyDoanVien", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "quan ly hoat dong",
                   url: "hoat-dong",
                   defaults: new { controller = "QuanLyHoatDong", action = "QuanLyHoatDong", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "quan ly so doan",
                   url: "so-doan",
                   defaults: new { controller = "QuanLySoDoan", action = "QuanLySoDoan", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                   name: "quan ly tai khoan",
                   url: "tai-khoan",
                   defaults: new { controller = "QuanLyTaiKhoan", action = "QuanLyTaiKhoan", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
