using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyDoanVienProject.Models;
namespace QuanLyDoanVienProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        QuanLyDoanVienEntities db = new QuanLyDoanVienEntities();
     
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verify(FormCollection f)
        {
            //Kiem tra ten dang nhap mat khau
            string sTaiKhoan = f["txtTenDangNhap"].ToString();
            string sMatKhau = f["txtMatKhau"].ToString();

            Account ac = db.Accounts.SingleOrDefault(n => n.AccountID == sTaiKhoan && n.Password == sMatKhau);
            if (ac != null && ac.IsActive==true)
            {
                Session["AccountID"] = ac.AccountID.ToString();

                return View("Create"); 
            }
            else if (ac != null && ac.IsActive == false)
            {
                ViewData["Message"] = "Tài khoản đã bị khóa, liên hệ với Admin để được hỗ trợ";
                return View("Error");
            }
            else
            {
                ViewData["Message"] = "Thông tin đăng nhập không chính xác";
                return View("Error");
            }

        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}