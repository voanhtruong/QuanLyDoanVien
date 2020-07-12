using QuanLyDoanVienProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDoanVienProject.Controllers
{
    public class DangKyChuongTrinhController : Controller
    {
        QuanLyDoanVienEntities db = new QuanLyDoanVienEntities();
        //lay phieu dang ky
        public List<PhieuDangKyHoatDong> layPhieuDangKyHoatDong()
        {
            List<PhieuDangKyHoatDong> listPhieuDangKyHoatDong = Session["PhieuDangKyHoatDong"] as List<PhieuDangKyHoatDong>;
            if (listPhieuDangKyHoatDong == null)
            {
                //neu session phieu rong, khoi tao phieu
                listPhieuDangKyHoatDong = new List<PhieuDangKyHoatDong>();
                Session["PhieuDangKyHoatDong"] = listPhieuDangKyHoatDong;
            }
            return listPhieuDangKyHoatDong;
        }
        //them phieu dang ky
        public ActionResult themPhieuDangKy(int maHoatDong, string strURL)
        {
            // kiem tra hoat dong co trong csdl hay khong
            HoatDong hd = db.HoatDongs.SingleOrDefault(n => n.MaHoatDong == maHoatDong);
            if (hd == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //tao list phieu dang ky
            List<PhieuDangKyHoatDong> listPhieuDangKyHoatDong = layPhieuDangKyHoatDong();
            //neu hoat dong da ton tai trong phieu dang ky
            PhieuDangKyHoatDong hdCheck = listPhieuDangKyHoatDong.SingleOrDefault(n => n.maHoatDong == maHoatDong);
            if (hdCheck != null)
            {
                hdCheck.ngayDangKy = DateTime.Now;
                return Redirect(strURL);
            }
            PhieuDangKyHoatDong ItemPhieuDangKy = new PhieuDangKyHoatDong(maHoatDong);
            listPhieuDangKyHoatDong.Add(ItemPhieuDangKy);
            return Redirect(strURL);

        }
        public double TinhTongSoLuongChuongTrinh()
        {
            List<PhieuDangKyHoatDong> listPhieuDangKy = Session["PhieuDangKyHoatDong"] as List<PhieuDangKyHoatDong>;
            if (listPhieuDangKy == null)
            {
                return 0;
            }
            return listPhieuDangKy.Count;
        }
        // GET: DangKyChuongTrinh
        public ActionResult DangKyChuongTrinh()
        {
            return View();
        }

        public ActionResult PhieuDangKyHoatDongPartial()
        {
            if (TinhTongSoLuongChuongTrinh() == 0)
            {
                ViewBag.TongSoLuong = 0;
                return PartialView();
            }
            ViewBag.TongSoLuong = TinhTongSoLuongChuongTrinh();
            return PartialView();
        }
    }
}