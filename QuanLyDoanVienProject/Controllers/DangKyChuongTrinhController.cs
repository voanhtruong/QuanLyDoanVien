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
        public List<PhieuDangKyHoatDong> LayPhieuDangKyHoatDong()
        {
            //List<PhieuDangKyHoatDong> listPhieuDangKyHoatDong = Session["PhieuDangKyHoatDong"] as List<PhieuDangKyHoatDong>;
            //if (listPhieuDangKyHoatDong == null)

            if (!(Session["PhieuDangKyHoatDong"] is List<PhieuDangKyHoatDong> listPhieuDangKyHoatDong))
            {
                //neu session phieu rong, khoi tao phieu
                listPhieuDangKyHoatDong = new List<PhieuDangKyHoatDong>();
                Session["PhieuDangKyHoatDong"] = listPhieuDangKyHoatDong;
            }
            return listPhieuDangKyHoatDong;
        }
        //them phieu dang ky (load lai trang)
        public ActionResult ThemPhieuDangKy(int MaHoatDong, string strURL)
        {
            // kiem tra hoat dong co trong csdl hay khong
            HoatDong hd = db.HoatDongs.SingleOrDefault(n => n.MaHoatDong == MaHoatDong);
            if (hd == null)
            {
                //trang duong dan khong hop le
                Response.StatusCode = 404;
                return null;
            }

            //tao list phieu dang ky
            List<PhieuDangKyHoatDong> listPhieuDangKyHoatDong = LayPhieuDangKyHoatDong();

            //neu hoat dong da ton tai trong phieu dang ky
            PhieuDangKyHoatDong hdCheck = listPhieuDangKyHoatDong.SingleOrDefault(n => n.MaHoatDong == MaHoatDong);
            if (hdCheck != null)
            {
                hdCheck.NgayDangKy = DateTime.Now;
                return Redirect(strURL);
            }
            PhieuDangKyHoatDong ItemPhieuDangKy = new PhieuDangKyHoatDong(MaHoatDong);
            listPhieuDangKyHoatDong.Add(ItemPhieuDangKy);
            return Redirect(strURL);

        }
        //tinh tong so luong chuong trinh da dang ky
        public double TinhTongSoLuongChuongTrinh()
        {
            if (!(Session["PhieuDangKyHoatDong"] is List<PhieuDangKyHoatDong> listPhieuDangKy))
            {
                return 0;
            }
            return listPhieuDangKy.Count;
        }
        // GET: DangKyChuongTrinh
        public ActionResult DangKyChuongTrinh()
        {
            var hoatDongs = db.HoatDongs;
            ViewBag.listHoatDong = hoatDongs;
            return View();
        }
        public ActionResult DangKyhoatDongPartial()
        {
            return PartialView();
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
        public ActionResult XemChuongTrinh()
        {
            List<PhieuDangKyHoatDong> listPhieuDangKyHoatDong = LayPhieuDangKyHoatDong();
            return View(listPhieuDangKyHoatDong);
        }
        public ActionResult XoaDangKy(int MaHoatDong)
        {
            //kiem tra sestion Phieu dang ky hoat dong ton tai hay chua
            if (Session["PhieuDangKyHoatDong"] == null){
                return RedirectToAction("DangKyChuongTrinh");
            }

            //kiem tra hoat dong co ton tai trong csdl hay khong
            HoatDong hd = db.HoatDongs.SingleOrDefault(n => n.MaHoatDong == MaHoatDong);
            if (hd == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            //lay list hoat dong tu sestion
            List<PhieuDangKyHoatDong> listPhieuDangKyHoatDong = LayPhieuDangKyHoatDong();

            //kiem tra hoat dong co nam trong phieu dang ky hay khong
            PhieuDangKyHoatDong hdCheck = listPhieuDangKyHoatDong.SingleOrDefault(n => n.MaHoatDong == MaHoatDong);
            if (hdCheck == null)
            {
                return RedirectToAction("DangKyChuongTrinh");
            }
            //xoa hoat dong da dang ky
            listPhieuDangKyHoatDong.Remove(hdCheck);

            return RedirectToAction("XemChuongTrinh");
        }
        public ActionResult LuuDangKy(DoanVien dv)
        {
            //kiem tra sestion Phieu dang ky hoat dong ton tai hay chua
            if (Session["PhieuDangKyHoatDong"] == null)
            {
                return RedirectToAction("DangKyChuongTrinh");
            }

            DoanVien doanVien = new DoanVien();
            Account ac = Session["AccountID"] as Account;

            //luu dang ky
            DangKyHoatDong dangKy = new DangKyHoatDong();
            
            
            dangKy.MaSinhVien = ac.AccountID;
            dangKy.MaHoatDong = 2;
            dangKy.NgayDangKy = DateTime.Now;
            db.DangKyHoatDongs.Add(dangKy);
            
            return View();
        }
    }
}