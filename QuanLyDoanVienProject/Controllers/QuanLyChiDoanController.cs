using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDoanVienProject.Models;

namespace QuanLyDoanVienProject.Controllers
{
    public class QuanLyChiDoanController : Controller
    {
        // GET: QuanLyChiDoan
        QuanLyDoanVienEntities db = new QuanLyDoanVienEntities();
        public ActionResult QuanLyChiDoan()
        {
            return View(db.ChiDoans);
        }
    }
}