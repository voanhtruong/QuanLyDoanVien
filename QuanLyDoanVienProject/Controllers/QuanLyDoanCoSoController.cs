using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDoanVienProject.Models;

namespace QuanLyDoanVienProject.Controllers
{
    public class QuanLyDoanCoSoController : Controller
    {
        // GET: QuanLyDoanCoSo
        QuanLyDoanVienEntities db = new QuanLyDoanVienEntities();
        public ActionResult QuanLyDoanCoSo()
        {
            return View(db.DoanCoSoes);
        }
        public ActionResult ThemDoanCoSo()
        {
           
            return View();
        }
    }
}