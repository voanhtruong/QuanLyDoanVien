using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDoanVienProject.Models;

namespace QuanLyDoanVienProject.Controllers
{
    public class QuanLyTaiKhoanController : Controller
    {
        // GET: QuanLyTaiKhoan
        QuanLyDoanVienEntities db = new QuanLyDoanVienEntities();
        public ActionResult QuanLyTaiKhoan()
        {
            return View(db.Accounts);
        }
        [HttpGet]
        public ActionResult ThemTaiKhoan()
        {
            ViewBag.GrantID = new SelectList(db.Grants.OrderBy(n => n.GrantID), "GrantID", "GrantName");
            return View();
        }
    }
}