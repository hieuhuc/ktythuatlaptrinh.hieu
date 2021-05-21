using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDiemSinhVien.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nhóm 3: Trần Minh Quân, Trần Trung Hiếu";

            return View();
        }
        
        public ActionResult Contact()   
        {
            ViewBag.Message = "Quản lý sinh viên đại học";

            return View();
        }
    }
}