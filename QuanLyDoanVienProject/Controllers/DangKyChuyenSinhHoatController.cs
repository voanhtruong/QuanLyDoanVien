using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDoanVienProject.Controllers
{
    public class DangKyChuyenSinhHoatController : Controller
    {
        // GET: DangKyChuyenSinhHoat
        public ActionResult DangKyChuyenSinhHoat()
        {
            return View();
        }
        public ActionResult DangKyChuyenSinhHoatPartial()
        {
            return PartialView();
        }
    }
}