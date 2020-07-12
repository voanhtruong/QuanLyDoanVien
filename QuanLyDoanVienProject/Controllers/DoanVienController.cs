using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDoanVienProject.Models;

namespace QuanLyDoanVienProject.Controllers
{
    public class DoanVienController : Controller
    {
        // GET: DoanVien
        // Sử dụng Partial view
        QuanLyDoanVienEntities db = new QuanLyDoanVienEntities();
        [ChildActionOnly]
        public ActionResult DoanVienPartial()
        {
            return PartialView();
        }
    }
}