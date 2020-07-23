using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDoanVienProject.Models;

namespace QuanLyDoanVienProject.Controllers
{
    public class QuanLyHoatDongController : Controller
    {
        // GET: QuanLyHoatDong
        QuanLyDoanVienEntities db = new QuanLyDoanVienEntities();
        public ActionResult QuanLyHoatDong()
        {

            return View(db.HoatDongs);
        }
    }
}