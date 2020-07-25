using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDoanVienProject.Models;

namespace QuanLyDoanVienProject.Controllers
{
    public class QuanLySoDoanController : Controller
    {
        // GET: QuanLySoDoan
        QuanLyDoanVienEntities db = new QuanLyDoanVienEntities();
        public ActionResult QuanLySoDoan()
        {
            return View(db.SoDoans);
        }
        [HttpGet]
        public ActionResult ThemSoDoan()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult ThemSoDoan(SoDoan soDoan)
        {
            db.SoDoans.Add(soDoan);
            db.SaveChanges();
            return RedirectToAction("QuanLySoDoan");
        }
    }
}