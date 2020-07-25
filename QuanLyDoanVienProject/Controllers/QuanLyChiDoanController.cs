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
        [HttpGet]
        public ActionResult ThemChiDoan()
        {
            ViewBag.MaDoanCoSo = new SelectList(db.DoanCoSoes.OrderBy(n => n.MaDoanCoSo), "MaDoanCoSo", "TenDoanCoSo");
            ViewBag.MaKhoaDaoTao = new SelectList(db.KhoaDaoTaos.OrderBy(n => n.MaKhoaDaoTao), "MaKhoaDaoTao", "MoTa");
            return View();
        }
    }
}