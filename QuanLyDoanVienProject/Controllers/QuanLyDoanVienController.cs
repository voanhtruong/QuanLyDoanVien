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
    }
}