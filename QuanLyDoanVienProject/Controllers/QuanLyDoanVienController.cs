using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDoanVienProject.Models;

namespace QuanLyDoanVienProject.Controllers
{
    public class QuanLyDoanVienController : Controller
    {
        // GET: QuanLyDoanVien
        QuanLyDoanVienEntities db = new QuanLyDoanVienEntities();
        public ActionResult QuanLyDoanVien()
        {
            return View(db.DoanViens);
        }
        [HttpGet]
        public ActionResult TaoMoiDoanVien()
        {
            ViewBag.MaSoDoan = new SelectList(db.SoDoans.OrderBy(n => n.MaSoDoan), "MaSoDoan", "MaSoDoan");
            ViewBag.MaChiDoan = new SelectList(db.ChiDoans.OrderBy(n => n.TenChiDoan), "MaChiDoan", "TenChiDoan");
            ViewBag.AccountID = new SelectList(db.Accounts.OrderBy(n => n.AccountID), "AccountID", "AccountID");
            return View();
        }
        [HttpPost]
        public ActionResult TaoMoiDoanVien(DoanVien doanVien)
        {
            ViewBag.MaSoDoan = new SelectList(db.SoDoans.OrderBy(n => n.MaSoDoan), "MaSoDoan", "MaSoDoan");
            ViewBag.MaChiDoan = new SelectList(db.ChiDoans.OrderBy(n => n.TenChiDoan), "MaChiDoan", "TenChiDoan");
            ViewBag.AccountID = new SelectList(db.Accounts.OrderBy(n => n.AccountID), "AccountID", "AccountID");
            

            db.DoanViens.Add(doanVien);
            db.SaveChanges();
            return RedirectToAction("QuanLyDoanVien");
        }
        [HttpGet]
        public ActionResult ChinhSua(String MaSinhVien)
        {
            if (MaSinhVien == null)
            {
                //trang duong dan khong hop le
                Response.StatusCode = 404;
                return null;
            }
            DoanVien dv = db.DoanViens.SingleOrDefault(n => n.MaSinhVien == MaSinhVien);
            if(dv == null)
            {
                return HttpNotFound();
            }

            ViewBag.MaSoDoan = new SelectList(db.SoDoans.OrderBy(n => n.MaSoDoan), "MaSoDoan", "MaSoDoan",dv.MaSoDoan);
            ViewBag.MaChiDoan = new SelectList(db.ChiDoans.OrderBy(n => n.TenChiDoan), "MaChiDoan", "TenChiDoan",dv.MaChiDoan);
            ViewBag.AccountID = new SelectList(db.Accounts.OrderBy(n => n.AccountID), "AccountID", "AccountID",dv.AccountID);
            
            return View(dv);
        }
        [ValidateInput (false)]
        [HttpPost]
        public ActionResult ChinhSua(DoanVien doanVien)
        {
            ViewBag.MaSoDoan = new SelectList(db.SoDoans.OrderBy(n => n.MaSoDoan), "MaSoDoan", "MaSoDoan", doanVien.MaSoDoan);
            ViewBag.MaChiDoan = new SelectList(db.ChiDoans.OrderBy(n => n.TenChiDoan), "MaChiDoan", "TenChiDoan", doanVien.MaChiDoan);
            ViewBag.AccountID = new SelectList(db.Accounts.OrderBy(n => n.AccountID), "AccountID", "AccountID", doanVien.AccountID);

            db.Entry(doanVien).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("QuanLyDoanVien");
            
        }
        [HttpGet]
        
        public ActionResult Xoa(String MaSinhVien)
        {
            if (MaSinhVien == null)
            {
                //trang duong dan khong hop le
                Response.StatusCode = 404;
                return null;
            }
            DoanVien dv = db.DoanViens.SingleOrDefault(n => n.MaSinhVien == MaSinhVien);
            if (dv == null)
            {
                return HttpNotFound();
            }

            ViewBag.MaSoDoan = new SelectList(db.SoDoans.OrderBy(n => n.MaSoDoan), "MaSoDoan", "MaSoDoan", dv.MaSoDoan);
            ViewBag.MaChiDoan = new SelectList(db.ChiDoans.OrderBy(n => n.TenChiDoan), "MaChiDoan", "TenChiDoan", dv.MaChiDoan);
            ViewBag.AccountID = new SelectList(db.Accounts.OrderBy(n => n.AccountID), "AccountID", "AccountID", dv.AccountID);
           
            return View(dv);
            
        }
        [HttpPost]
        public ActionResult Xoa(String MaSinhVien, String HoVaTenDoanVien)
        {
            if (MaSinhVien == null)
            {
                //trang duong dan khong hop le
                Response.StatusCode = 404;
                return null;
            }
            DoanVien dv = db.DoanViens.SingleOrDefault(n => n.MaSinhVien == MaSinhVien);
            if (dv == null)
            {
                return HttpNotFound();
            }

            db.DoanViens.Remove(dv);
            db.SaveChanges();
            return RedirectToAction("QuanLyDoanVien");
        }
        
        
    }
}